using MySql.Data.MySqlClient;
using NeptuneLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neptune
{
    public partial class AddMaterialDirectorForm : Form
    {
        private string conn;
        private MySqlConnection connect;
        private Worker userOfAddMaterialDirectorForm = new Worker();
        private List<WorkerPositionClass> positions = new List<WorkerPositionClass>();
        private List<MaterialCategoryClass> materialCategories = new List<MaterialCategoryClass>();

        public AddMaterialDirectorForm(string id)
        {
            InitializeComponent();
            fillPositions();
            fillMaterialCategories();
            fillUserOfAddMaterialDirectorForm(id);
        }

        /// <summary>
        /// Opens database connection
        /// </summary>
        private void databaseConnect()
        {
            try
            {
                conn = "Server=localhost;Database=neptune_database;Uid=root;Pwd=;Convert Zero Datetime=True";
                connect = new MySqlConnection(conn);
                connect.Open();
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void fillUserOfAddMaterialDirectorForm(string id)
        {
            databaseConnect();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "SELECT * FROM workers WHERE worker_id = @id AND worker_employement_status = @employement";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@employement", "Employeed");
                cmd.Connection = connect;
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        userOfAddMaterialDirectorForm = new Worker
                        {
                            WorkerID = reader["worker_id"].ToString(),
                            WorkerFirstName = reader["worker_first_name"].ToString(),
                            WorkerLastName = reader["worker_last_name"].ToString(),
                            WorkerPhoneNumber = reader["worker_phone_number"].ToString(),
                            WorkerPosition = positionSelector(reader["worker_position_id"].ToString())
                        };
                    }
                }
            }
        }

        private string positionSelector(string workerPositionID)
        {
            string workerPosition = "";
            foreach (WorkerPositionClass position in positions) if (position.WorkerPositionID == workerPositionID) workerPosition = position.WorkerPosition;
            return workerPosition;
        }

        private void fillPositions()
        {
            databaseConnect();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "SELECT * FROM worker_position_table";
                cmd.Connection = connect;
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        positions.Add(new WorkerPositionClass
                        {
                            WorkerPositionID = reader["worker_position_id"].ToString(),
                            WorkerPosition = reader["worker_position"].ToString(),
                            WorkerSalary = Convert.ToInt32(reader["worker_fixed_salary"].ToString())
                        });
                    }
                }
            }
        }

        private string materialCategoryIDSelector(string materialCategory)
        {
            string categoryID = "";
            foreach (MaterialCategoryClass materialCategoryClass in materialCategories) if (materialCategoryClass.MaterialCategory == materialCategory) categoryID = materialCategoryClass.MaterialCategoryID;
            return categoryID;
        }

        private void fillMaterialCategories()
        {
            databaseConnect();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "SELECT * FROM material_category";
                cmd.Connection = connect;
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        categoryAddMaterialDirectorFormComboBox.Items.Add(reader["material_category"]);
                        materialCategories.Add(new MaterialCategoryClass
                        {
                            MaterialCategoryID = reader["material_category_id"].ToString(),
                            MaterialCategory = reader["material_category"].ToString()
                        });
                    }
                }
            }
        }

        private void addAddMaterialDirectorFormButton_Click(object sender, EventArgs e)
        {
            if (nameAddMaterialDirectorFormTextBox.Text == "" ||
                categoryAddMaterialDirectorFormComboBox.Text == "" ||
                quantityAddMaterialDirectorFormTextBox.Text == "" ||
                priceAddMaterialDirectorFormTextBox.Text == "" ||
                depletionAlertLevelAddMaterialDirectorFormTextBox.Text == "")
            {
                errorDetailsAddMaterialDirectorFormLabel.Visible = true;

                if (nameAddMaterialDirectorFormTextBox.Text == "")
                {
                    nameErrorAddMaterialDirectorFormLabel.Visible = true;
                }
                else
                {
                    nameErrorAddMaterialDirectorFormLabel.Visible = false;
                }

                if (categoryAddMaterialDirectorFormComboBox.Text == "")
                {
                    categoryErrorAddMaterialDirectorFormLabel.Visible = true;
                }
                else
                {
                    categoryErrorAddMaterialDirectorFormLabel.Visible = false;
                }

                if (quantityAddMaterialDirectorFormTextBox.Text == "")
                {
                    quantityErrorAddMaterialDirectorFormLabel.Visible = true;
                }
                else
                {
                    quantityErrorAddMaterialDirectorFormLabel.Visible = false;
                }

                if (priceAddMaterialDirectorFormTextBox.Text == "")
                {
                    priceErrorAddMaterialDirectorFormLabel.Visible = true;
                }
                else
                {
                    priceErrorAddMaterialDirectorFormLabel.Visible = false;
                }

                if (depletionAlertLevelAddMaterialDirectorFormTextBox.Text == "")
                {
                    depletionErrorAlertLevelAddMaterialDirectorFormLabel.Visible = true;
                }
                else
                {
                    depletionErrorAlertLevelAddMaterialDirectorFormLabel.Visible = false;
                }
            }
            else
            {
                nameErrorAddMaterialDirectorFormLabel.Visible = false;
                categoryErrorAddMaterialDirectorFormLabel.Visible = false;
                quantityErrorAddMaterialDirectorFormLabel.Visible = false;
                priceErrorAddMaterialDirectorFormLabel.Visible = false;
                depletionErrorAlertLevelAddMaterialDirectorFormLabel.Visible = false;
                errorDetailsAddMaterialDirectorFormLabel.Visible = false;

                databaseConnect();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.CommandText = @"INSERT INTO materials (material_name, material_category_id, material_quantity, material_depletion_alert, material_price, material_added_by, material_update_date, material_last_updated_by) VALUES (@name, @category, @quantity, @depletionAlert, @price, @addingWorker, NOW(), @updatingWorker)";
                    cmd.Parameters.AddWithValue("@name", nameAddMaterialDirectorFormTextBox.Text);
                    cmd.Parameters.AddWithValue("@category", materialCategoryIDSelector(categoryAddMaterialDirectorFormComboBox.Text));
                    cmd.Parameters.AddWithValue("@quantity", quantityAddMaterialDirectorFormTextBox.Text);
                    cmd.Parameters.AddWithValue("@depletionAlert", depletionAlertLevelAddMaterialDirectorFormTextBox.Text);
                    cmd.Parameters.AddWithValue("@price", priceAddMaterialDirectorFormTextBox.Text);
                    cmd.Parameters.AddWithValue("@addingWorker", userOfAddMaterialDirectorForm.WorkerID);
                    cmd.Parameters.AddWithValue("@updatingWorker", userOfAddMaterialDirectorForm.WorkerID);
                    cmd.Connection = connect;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Material added.");
                    Close();
                }
            }
        }

        private void cancelAddMaterialDirectorFormButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
