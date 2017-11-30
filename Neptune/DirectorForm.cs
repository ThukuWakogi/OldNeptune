using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using NeptuneLib;

namespace Neptune
{
    public partial class DirectorForm : Form
    {
        private string conn;
        private MySqlConnection connect;
        Worker userOfDirectorForm;
        private List<Worker> workers = new List<Worker>();
        BindingSource workersListBoxBinding = new BindingSource();
        private List<Worker> systemUsers = new List<Worker>();
        BindingSource systemUsersListBoxBinding = new BindingSource();
        private List<Material> materials = new List<Material>();
        BindingSource materialsListBoxBinding = new BindingSource();
        private List<WorkerPositionClass> positions = new List<WorkerPositionClass>();
        private List<MaterialCategoryClass> materialCategories = new List<MaterialCategoryClass>();
        BindingSource materialsInStockListBoxBinding = new BindingSource();
        BindingSource shortageOrDepletionListBoxBinding = new BindingSource();

        public DirectorForm(string id)
        {
            InitializeComponent();
            fillPositions();
            fillMaterialCategories();
            fillUserOfDirectorForm(id);
            fillUserLabels();
            populateWorkerList();
            populateMaterialsList();
            populateSystemUsersList();
            workersListBoxBinding.DataSource = workers;
            workersDirectorListBox.DataSource = workersListBoxBinding;
            workersDirectorListBox.DisplayMember = "Display";
            workersDirectorListBox.ValueMember = "Display";
            systemUsersListBoxBinding.DataSource = systemUsers;
            systemUsersDirectorListBox.DataSource = systemUsersListBoxBinding;
            systemUsersDirectorListBox.DisplayMember = "Display";
            systemUsersDirectorListBox.ValueMember = "Display";
            materialsListBoxBinding.DataSource = materials;
            materialsDirectorFormListBox.DataSource = materialsListBoxBinding;
            materialsDirectorFormListBox.DisplayMember = "Display";
            materialsDirectorFormListBox.ValueMember = "Display";

            if (materials.Where(x => x.MaterialQuantity >= 0).Count() > 0)
            {
                materialsInStockListBoxBinding.DataSource = materials.Where(x => x.MaterialQuantity >= 0);
                materialsInStockDirectorFormListBox.DataSource = materialsInStockListBoxBinding;
                materialsInStockDirectorFormListBox.DisplayMember = "Display";
                materialsInStockDirectorFormListBox.ValueMember = "Display";
            }

            if (materials.Where(x => x.MaterialQuantity <= x.MaterialDepletionAlert).Count() > 0)
            {
                shortageOrDepletionListBoxBinding.DataSource = materials.Where(x => x.MaterialQuantity <= x.MaterialDepletionAlert);
                shortageOrDepletionDirectorFormListBox.DataSource = shortageOrDepletionListBoxBinding;
                shortageOrDepletionDirectorFormListBox.ValueMember = "Display";
                shortageOrDepletionDirectorFormListBox.DisplayMember = "Display";
            }
        }

        /// <summary>
        /// Opens database connection
        /// </summary>
        private void databaseConnect()
        {
            try
            {
                conn = "Server=localhost;Database=neptune_database;Uid=root;Pwd=;";
                connect = new MySqlConnection(conn);
                connect.Open();
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private string positionSelector(string workerPositionID)
        {
            string workerPosition = "";
            foreach (WorkerPositionClass position in positions) if (position.WorkerPositionID == workerPositionID) workerPosition = position.WorkerPosition;
            return workerPosition;
        }

        private void fillUserOfDirectorForm(string id)
        {
            databaseConnect();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "SELECT * FROM workers WHERE worker_id = @id AND worker_employement_status = @employement";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@employement", "Employeed");
                cmd.Connection = connect;
                using(MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        userOfDirectorForm = new Worker
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

        private void populateSystemUsersList()
        {
            string id = "";
            string firstName = "";
            string lastName = "";
            string position = "";

            databaseConnect();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "SELECT workers.worker_id, workers.worker_first_name, workers.worker_last_name, workers.worker_position_id FROM authentication, workers WHERE workers.worker_id IN (SELECT authentication.worker_id FROM authentication) GROUP BY workers.worker_id";
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

                        systemUsers.Add(new Worker
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

        private bool credentialCheck()
        {
            bool credentialPresent = false;
            databaseConnect();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "SELECT workers.worker_id, workers.worker_first_name, workers.worker_last_name, workers.worker_position_id FROM authentication, workers WHERE workers.worker_id NOT IN (SELECT authentication.authentication_id FROM authentication)AND workers.worker_id = @id GROUP BY workers.worker_id";
                cmd.Parameters.AddWithValue("@id", workersDirectorListBox.GetItemText(workersDirectorListBox.SelectedItem).Split(',')[0]);
                cmd.Connection = connect;
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        credentialPresent = true;
                    }
                }
            }

            return credentialPresent;
        }

        private void populateMaterialsList()
        {
            databaseConnect();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "SELECT * FROM materials";
                cmd.Connection = connect;
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        materials.Add(new Material
                        {
                            MaterialID = reader["material_id"].ToString(),
                            MaterialName = reader["material_name"].ToString(),
                            MaterialCategory = materialCategorySelector(reader["material_category_id"].ToString()),
                            MaterialPrice = Convert.ToDecimal(reader["material_price"]),
                            MaterialDepletionAlert = Convert.ToDecimal(reader["material_depletion_alert"]),
                            MaterialQuantity = Convert.ToDecimal(reader["material_quantity"]),
                            MaterialAdditionDate = Convert.ToDateTime(reader["material_addition_date"]),
                            MaterialAddedBy = workerSelector(reader["material_added_by"].ToString()),
                            MaterialUpdateDate = Convert.ToDateTime(reader["material_update_date"]),
                            MaterialLastUpdatedBy = workerSelector(reader["material_last_updated_by"].ToString())
                        });
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

        private void fillUserLabels()
        {
            userLoggedInNameDirectorLinkLabel.Text = userOfDirectorForm.WorkerFirstName + " " + userOfDirectorForm.WorkerLastName; 
        }

        private Worker workerSelector(string id)
        {
            Worker returningWorker = null;

            foreach (Worker worker in workers)
            {
                if (worker.WorkerID == id) returningWorker = worker;
            }

            return returningWorker;
        }
        
        private void logOutDirectorButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void exitDirectorButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addWorkersDirectorLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddWorkerDirectorForm addWorkerDirectorForm = new AddWorkerDirectorForm();
            addWorkerDirectorForm.Show();
        }

        private void refreshWorkerDirectorButton_Click(object sender, EventArgs e)
        {
            workersListBoxBinding.Clear();
            workers.Clear();
            populateWorkerList();
            workersListBoxBinding.DataSource = workers;
            workersDirectorListBox.DataSource = workersListBoxBinding;
            workersDirectorListBox.DisplayMember = "Display";
            workersDirectorListBox.ValueMember = "Display";
            workersListBoxBinding.ResetBindings(false);
            systemUsersListBoxBinding.Clear();
            systemUsers.Clear();
            populateSystemUsersList();
            systemUsersListBoxBinding.DataSource = systemUsers;
            systemUsersDirectorListBox.DataSource = systemUsersListBoxBinding;
            systemUsersDirectorListBox.DisplayMember = "Display";
            systemUsersDirectorListBox.ValueMember = "Display";
            systemUsersListBoxBinding.ResetBindings(false);
        }

        private void addSystemUsersDirectorLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddSystemUserDirectorForm addSystemUserDirectorForm = new AddSystemUserDirectorForm();
            addSystemUserDirectorForm.ShowDialog();
        }

        private void ModifyWorkerDirectorButton_Click(object sender, EventArgs e)
        {
            ModifyWorkerDirectorForm modifyWorkerDirectorForm = new ModifyWorkerDirectorForm(workersDirectorListBox.GetItemText(workersDirectorListBox.SelectedItem).Split(',')[0]);
            modifyWorkerDirectorForm.ShowDialog();
        }

        private void fireWorkerDirectorButton_Click(object sender, EventArgs e)
        {
            databaseConnect();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "INSERT INTO workers_left (worker_id) VALUES (@id)";
                cmd.Parameters.AddWithValue("@id", workersDirectorListBox.GetItemText(workersDirectorListBox.SelectedItem).Split(',')[0]);
                cmd.Connection = connect;
                cmd.ExecuteNonQuery();
            }

            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "UPDATE workers SET worker_employement_status = 'Unemployeed' WHERE worker_id = @id";
                cmd.Parameters.AddWithValue("@id", workersDirectorListBox.GetItemText(workersDirectorListBox.SelectedItem).Split(',')[0]);
                cmd.Connection = connect;
                cmd.ExecuteNonQuery();
            }

            if (credentialCheck())
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.CommandText = "DELETE FROM authentication WHERE worker_id = @id";
                    cmd.Parameters.AddWithValue("@id", workersDirectorListBox.GetItemText(workersDirectorListBox.SelectedItem).Split(',')[0]);
                    cmd.Connection = connect;
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Worker has been fired!");
        }

        private void modifySystemUserWorkerDirectorButton_Click(object sender, EventArgs e)
        {
            ModifySystemUSerDirectorForm modifySystemUserDirectorForm = new ModifySystemUSerDirectorForm(systemUsersDirectorListBox.GetItemText(systemUsersDirectorListBox.SelectedItem));
            modifySystemUserDirectorForm.Show();
        }

        private void removeSystemUserWorkerDirectorButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(systemUsersDirectorListBox.GetItemText(systemUsersDirectorListBox.SelectedItem) + " will not be able to use the sytem.\n Do you want to continue?", "Remove System User", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                databaseConnect();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.CommandText = "DELETE FROM authentication WHERE worker_id = @id";
                    cmd.Parameters.AddWithValue("@id", systemUsersDirectorListBox.GetItemText(systemUsersDirectorListBox.SelectedItem).Split(',')[0]);
                    cmd.Connection = connect;
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Worker removed as system user.");
            }
        }

        private void refreshMaterialsDirectorButton_Click(object sender, EventArgs e)
        {
            materialsListBoxBinding.Clear();
            materials.Clear();
            materialsInStockListBoxBinding.Clear();
            shortageOrDepletionListBoxBinding.Clear();
            populateMaterialsList();
            materialsListBoxBinding.DataSource = materials;
            materialsDirectorFormListBox.DataSource = materialsListBoxBinding;
            materialsDirectorFormListBox.DisplayMember = "Display";
            materialsDirectorFormListBox.ValueMember = "Display";

            if (materials.Where(x => x.MaterialQuantity >= 0).Count() > 0)
            {
                materialsInStockListBoxBinding.DataSource = materials.Where(x => x.MaterialQuantity >= 0);
                materialsInStockDirectorFormListBox.DataSource = materialsInStockListBoxBinding;
                materialsInStockDirectorFormListBox.DisplayMember = "Display";
                materialsInStockDirectorFormListBox.ValueMember = "Display";
            }

            if (materials.Where(x => x.MaterialQuantity <= x.MaterialDepletionAlert).Count() > 0)
            {
                shortageOrDepletionListBoxBinding.DataSource = materials.Where(x => x.MaterialQuantity <= x.MaterialDepletionAlert);
                shortageOrDepletionDirectorFormListBox.DataSource = shortageOrDepletionListBoxBinding;
                shortageOrDepletionDirectorFormListBox.ValueMember = "Display";
                shortageOrDepletionDirectorFormListBox.DisplayMember = "Display";
            }

            materialsListBoxBinding.ResetBindings(false);
            materialsInStockListBoxBinding.ResetBindings(false);
            shortageOrDepletionListBoxBinding.ResetBindings(false);
        }

        private void detailsMaterialsDirectorButton_Click(object sender, EventArgs e)
        {
            ViewMaterialDetailsDirectorForm viewMaterialDetailsDirectorForm = new ViewMaterialDetailsDirectorForm(materialsDirectorFormListBox.GetItemText(materialsDirectorFormListBox.SelectedItem).Split(',')[0], userOfDirectorForm.WorkerID);
            viewMaterialDetailsDirectorForm.ShowDialog();
        }

        private void detailsRequisitesDirectorButton_Click(object sender, EventArgs e)
        {
            ViewMaterialDetailsDirectorForm viewMaterialDetailsDirectorForm = new ViewMaterialDetailsDirectorForm(materialsInStockDirectorFormListBox.GetItemText(materialsInStockDirectorFormListBox.SelectedItem).Split(',')[0], userOfDirectorForm.WorkerID);
            viewMaterialDetailsDirectorForm.Text = "Materials In Stock Details | Director";
            viewMaterialDetailsDirectorForm.ShowDialog();
        }

        private void addMaterialsDirectorLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddMaterialDirectorForm addMaterialDirectorForm = new AddMaterialDirectorForm(userOfDirectorForm.WorkerID);
            addMaterialDirectorForm.ShowDialog();
        }

        private void detailsShortageOrDepletionAlertDirectorButton_Click(object sender, EventArgs e)
        {
            ViewMaterialDetailsDirectorForm viewMaterialDetailsDirectorForm = new ViewMaterialDetailsDirectorForm(shortageOrDepletionDirectorFormListBox.GetItemText(shortageOrDepletionDirectorFormListBox.SelectedItem).Split(',')[0], userOfDirectorForm.WorkerID);
            viewMaterialDetailsDirectorForm.Text = "Shortage or Depletion Alert Details | Director";
            viewMaterialDetailsDirectorForm.ShowDialog();
        }

        private void modifyMaterialsDirectorButton_Click(object sender, EventArgs e)
        {
            ModifyMaterialDirectorForm modifyMaterialDirectorForm = new ModifyMaterialDirectorForm(materialsDirectorFormListBox.GetItemText(materialsDirectorFormListBox.SelectedItem).Split(',')[0], userOfDirectorForm.WorkerID);
            modifyMaterialDirectorForm.ShowDialog();
        }
    }
}