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
    public partial class ModifyWorkerDirectorForm : Form
    {
        private string conn;
        private MySqlConnection connect;
        private Worker worker;
        private List<WorkerPositionClass> positions = new List<WorkerPositionClass>();
        string workerIDInUse = "";

        public ModifyWorkerDirectorForm(string id)
        {
            InitializeComponent();
            fillPositions();
            loadWorker(id);
            fillFields();
            workerIDInUse = id;
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

        private void loadWorker(string id)
        {
            databaseConnect();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "SELECT worker_id, worker_first_name, worker_last_name, worker_position_id, worker_phone_number FROM `workers`WHERE worker_id = @id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Connection = connect;
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        worker = new Worker
                        {
                            WorkerID = reader["worker_id"].ToString(),
                            WorkerFirstName = reader["worker_first_name"].ToString(),
                            WorkerLastName = reader["worker_last_name"].ToString(),
                            WorkerPosition = positionIDtoPositonConverter(reader["worker_position_id"].ToString()),
                            WorkerPhoneNumber = reader["worker_phone_number"].ToString()
                        };
                    }
                }
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
                        positionModifyWorkerDirectorComboBox.Items.Add(reader["worker_position"].ToString());
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

        private void fillFields()
        {
            workerModifyWorkerDirectorLabel.Text = worker.Display;
            firstNameModifyWorkerDirectorTextBox.Text = worker.WorkerFirstName;
            lastNameModifyWorkerDirectorTextBox.Text = worker.WorkerLastName;
            positionModifyWorkerDirectorComboBox.Text = worker.WorkerPosition;
            phoneNumberModifyWorkerDirectorTextBox.Text = worker.WorkerPhoneNumber;
        }

        private string positionIDSelector()
        {
            string positionID = "";

            foreach (WorkerPositionClass position in positions)
            {
                if (position.WorkerPosition == positionModifyWorkerDirectorComboBox.Text) positionID = position.WorkerPositionID;
            }
            return positionID;
        }

        private string positionIDtoPositonConverter(string id)
        {
            string workerPosition = "";

            foreach (WorkerPositionClass position in positions)
            {
                if (position.WorkerPositionID == id) workerPosition = position.WorkerPosition;

            }
            return workerPosition;
        }

        private bool credentialCheck()
        {
            bool credentialPresent = true;
            databaseConnect();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "SELECT workers.worker_id, workers.worker_first_name, workers.worker_last_name, workers.worker_position_id FROM authentication, workers WHERE workers.worker_id NOT IN (SELECT authentication.authentication_id FROM authentication)AND workers.worker_id = @id GROUP BY workers.worker_id";
                cmd.Parameters.AddWithValue("@id", workerIDInUse);
                cmd.Connection = connect;
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        credentialPresent = true;
                    }
                    else
                    {
                        credentialPresent = false;
                    }
                }
            }

            return credentialPresent;
        }

        private void CancelModifyWorkerDirectorButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void modifyModifyWorkerDirectorButton_Click(object sender, EventArgs e)
        {
            if (firstNameModifyWorkerDirectorTextBox.Text == "" || lastNameModifyWorkerDirectorTextBox.Text == "" || positionModifyWorkerDirectorComboBox.Text == "" || phoneNumberModifyWorkerDirectorTextBox.Text == "")
            {
                if(firstNameModifyWorkerDirectorTextBox.Text == "")
                {
                    firstNameErrorModifyWorkerDirectorLabel.Visible = true;
                    errorDetailsModifyWorkerDirectorLabel.Visible = true;
                }
                else
                {
                    firstNameErrorModifyWorkerDirectorLabel.Visible = false;
                    errorDetailsModifyWorkerDirectorLabel.Visible = false;
                }

                if (lastNameModifyWorkerDirectorTextBox.Text == "")
                {
                    lastNameErrorModifyWorkerDirectorLabel.Visible = true;
                    errorDetailsModifyWorkerDirectorLabel.Visible = true;
                }
                else
                {
                    lastNameErrorModifyWorkerDirectorLabel.Visible = false;
                    errorDetailsModifyWorkerDirectorLabel.Visible = false;
                }

                if (positionModifyWorkerDirectorComboBox.Text == "")
                {
                    positionErrorModifyWorkerDirectorLabel.Visible = true;
                    errorDetailsModifyWorkerDirectorLabel.Visible = true;
                }
                else
                {
                    positionErrorModifyWorkerDirectorLabel.Visible = false;
                    errorDetailsModifyWorkerDirectorLabel.Visible = false;
                }

                if (phoneNumberModifyWorkerDirectorTextBox.Text == "")
                {
                    phoneNumberErrorModifyWorkerDirectorLabel.Visible = true;
                    errorDetailsModifyWorkerDirectorLabel.Visible = true;
                }
                else
                {
                    phoneNumberErrorModifyWorkerDirectorLabel.Visible = false;
                    errorDetailsModifyWorkerDirectorLabel.Visible = false;
                }
            }
            else
            {
                if (positionModifyWorkerDirectorComboBox.Text == "Tier")
                {
                    if (credentialCheck() == true)
                    {
                        DialogResult result = MessageBox.Show("Changing position to tier will result to loss of user credentials. Do you wish to continue", "Credential Loss", MessageBoxButtons.YesNo);

                        if (result == DialogResult.Yes)
                        {
                            databaseConnect();
                            using (MySqlCommand cmd = new MySqlCommand())
                            {
                                cmd.CommandText = "UPDATE workers SET worker_first_name = @firstName, worker_last_name = @lastName, worker_position_id = @positionID, worker_phone_number = @phoneNumber WHERE worker_id = @id";
                                cmd.Parameters.AddWithValue("@firstName", firstNameModifyWorkerDirectorTextBox.Text);
                                cmd.Parameters.AddWithValue("@lastName", lastNameModifyWorkerDirectorTextBox.Text);
                                cmd.Parameters.AddWithValue("@positionID", positionIDSelector());
                                cmd.Parameters.AddWithValue("@phoneNumber", phoneNumberModifyWorkerDirectorTextBox.Text);
                                cmd.Parameters.AddWithValue("@id", workerIDInUse);
                                cmd.Connection = connect;
                                cmd.ExecuteNonQuery();
                            }

                            using (MySqlCommand cmd = new MySqlCommand())
                            {
                                cmd.CommandText = "DELETE FROM authentication WHERE worker_id = @id";
                                cmd.Parameters.AddWithValue("@id", workerIDInUse);
                                cmd.Connection = connect;
                                cmd.ExecuteNonQuery();
                            }

                            MessageBox.Show("Worker Modified.");
                            Close();
                        }
                    }
                }
                else
                {
                    databaseConnect();
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        cmd.CommandText = "UPDATE workers SET worker_first_name = @firstName, worker_last_name = @lastName, worker_position_id = @positionID, worker_phone_number = @phoneNumber WHERE worker_id = @id";
                        cmd.Parameters.AddWithValue("@firstName", firstNameModifyWorkerDirectorTextBox.Text);
                        cmd.Parameters.AddWithValue("@lastName", lastNameModifyWorkerDirectorTextBox.Text);
                        cmd.Parameters.AddWithValue("@positionID", positionIDSelector());
                        cmd.Parameters.AddWithValue("@phoneNumber", phoneNumberModifyWorkerDirectorTextBox.Text);
                        cmd.Parameters.AddWithValue("@id", workerIDInUse);
                        cmd.Connection = connect;
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Worker Modified.");
                    Close();
                }
            }
        }
    }
}