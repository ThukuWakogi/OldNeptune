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
    public partial class ModifyMaterialDirectorForm : Form
    {
        private string conn;
        private MySqlConnection connect;
        private Worker userOfModifyMaterialDirectorForm = new Worker();
        private List<WorkerPositionClass> positions = new List<WorkerPositionClass>();
        private Material materialInModification = new Material();
        private List<MaterialCategoryClass> materialCategories = new List<MaterialCategoryClass>();
        private List<Worker> workers = new List<Worker>();

        public ModifyMaterialDirectorForm(string materialID, string userID)
        {
            InitializeComponent();
            fillPositions();
            populateWorkerList();
            fillMaterialCategories();
            fillUserOfModifyMaterialDirectorForm(userID);
            fillMaterialInModification(materialID);
            fillFields();
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
                        materialCategories.Add(new MaterialCategoryClass
                        {
                            MaterialCategoryID = reader["material_category_id"].ToString(),
                            MaterialCategory = reader["material_category"].ToString()
                        });
                    }
                }
            }
        }

        private void fillUserOfModifyMaterialDirectorForm(string id)
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
                        userOfModifyMaterialDirectorForm = new Worker
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

        private void fillMaterialInModification(string id)
        {
            databaseConnect();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "SELECT * FROM materialS WHERE material_id = @id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Connection = connect;
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        materialInModification = new Material
                        {
                            MaterialID = reader["material_id"].ToString(),
                            MaterialName = reader["material_name"].ToString(),
                            MaterialCategory = materialCategorySelector(reader["material_category_id"].ToString()),
                            MaterialQuantity = Convert.ToDecimal(reader["material_quantity"]),
                            MaterialPrice = Convert.ToDecimal(reader["material_price"]),
                            MaterialDepletionAlert = Convert.ToDecimal(reader["material_depletion_alert"]),
                            MaterialAdditionDate = Convert.ToDateTime(reader["material_addition_date"]),
                            MaterialAddedBy = workerSelector(reader["material_added_by"].ToString()),
                            MaterialUpdateDate = Convert.ToDateTime(reader["material_update_date"]),
                            MaterialLastUpdatedBy = workerSelector(reader["material_last_updated_by"].ToString())
                        };
                    }
                }
            }
        }

        private MaterialCategoryClass materialCategorySelector(string id)
        {
            MaterialCategoryClass category = new MaterialCategoryClass();
            foreach (MaterialCategoryClass materialCategory in materialCategories) if (materialCategory.MaterialCategoryID == id) category = materialCategory;
            return category;
        }

        private Worker workerSelector(string id)
        {
            Worker returningWorker = new Worker();
            foreach (Worker worker in workers) if (worker.WorkerID == id) returningWorker = worker;
            return returningWorker;
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

        private void populateWorkerList()
        {
            string id = "";
            string firstName = "";
            string lastName = "";
            string position = "";

            databaseConnect();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "SELECT * FROM workers WHERE worker_employement_status = @employement";
                cmd.Parameters.AddWithValue("@employement", "Employeed");
                cmd.Connection = connect;
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        id = reader["worker_id"].ToString();
                        firstName = reader["worker_first_name"].ToString();
                        lastName = reader["worker_last_name"].ToString();

                        databaseConnect();
                        using (MySqlCommand cmdPosition = new MySqlCommand())
                        {
                            cmdPosition.CommandText = "SELECT worker_position FROM worker_position_table, workers WHERE worker_position_table.worker_position_id = (SELECT workers.worker_position_id WHERE workers.worker_id = @id)";
                            cmdPosition.Parameters.AddWithValue("@id", id);
                            cmdPosition.Connection = connect;
                            position = cmdPosition.ExecuteScalar().ToString();
                        }

                        workers.Add(new Worker
                        {
                            WorkerFirstName = firstName,
                            WorkerID = id,
                            WorkerLastName = lastName,
                            WorkerPosition = position
                        });
                    }
                }
                connect.Close();
            }
        }

        private string positionSelector(string workerPositionID)
        {
            string workerPosition = "";
            foreach (WorkerPositionClass position in positions) if (position.WorkerPositionID == workerPositionID) workerPosition = position.WorkerPosition;
            return workerPosition;
        }

        private void fillFields()
        {
            nameModifyMaterialDirectorFormTextBox.Text = materialInModification.MaterialName;
            categoryModifyMaterialDirectorFormComboBox.Text = materialInModification.MaterialCategory.MaterialCategory;
            quantityModifyMaterialDirectorFormTextBox.Text = materialInModification.MaterialQuantity.ToString();
            priceModifyMaterialDirectorFormTextBox.Text = materialInModification.MaterialPrice.ToString();
            depletionModifyLevelAddMaterialDirectorFormTextBox.Text = materialInModification.MaterialDepletionAlert.ToString();
        }

        private string materialCategoryIDSelector(string materialCategory)
        {
            string categoryID = "";
            foreach (MaterialCategoryClass materialCategoryClass in materialCategories) if (materialCategoryClass.MaterialCategory == materialCategory) categoryID = materialCategoryClass.MaterialCategoryID;
            return categoryID;
        }

        private void cancelModifyMaterialDirectorFormButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void modifyModifyMaterialDirectorFormButton_Click(object sender, EventArgs e)
        {
            databaseConnect();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "UPDATE materials SET material_name = @name, material_category_id = @category, material_quantity = @quantity, material_depletion_alert = @depletionAlert, material_price = @price, material_update_date = NOW(), material_last_updated_by = @updatingWorker WHERE material_id = @id";
                cmd.Parameters.AddWithValue("@name", nameModifyMaterialDirectorFormTextBox.Text);
                cmd.Parameters.AddWithValue("@category", materialCategoryIDSelector(categoryModifyMaterialDirectorFormComboBox.Text));
                cmd.Parameters.AddWithValue("@quantity", quantityModifyMaterialDirectorFormTextBox.Text);
                cmd.Parameters.AddWithValue("@depletionAlert", priceModifyMaterialDirectorFormTextBox.Text);
                cmd.Parameters.AddWithValue("@price", priceModifyMaterialDirectorFormTextBox.Text);
                cmd.Parameters.AddWithValue("@updatingWorker", userOfModifyMaterialDirectorForm.WorkerID);
                cmd.Parameters.AddWithValue("@id", materialInModification.MaterialID);
                cmd.Connection = connect;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Material modified.");
                Close();
            }
        }
    }
}