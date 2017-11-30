using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NeptuneLib;

namespace Neptune
{
    public partial class AddSystemUserDirectorForm : Form
    {
        private string conn;
        private MySqlConnection connect;
        private List<WorkerPositionClass> positions = new List<WorkerPositionClass>();
        private List<Worker> theUncredented = new List<Worker>();

        /// <summary>
        /// Default Constructor
        /// </summary>
        public AddSystemUserDirectorForm()
        {
            InitializeComponent();
            fillPositions();
            fillTheUncredented();
            fillWorkerSystemUserDirectorComboBox();
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
        
        /// <summary>
        /// Polulates positions List collection with position values from database
        /// </summary>
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

        /// <summary>
        /// gives worker position text as string
        /// </summary>
        /// <param name="workerPositionID">This is the worker position id of the position</param>
        /// <returns>returns worker position in string</returns>
        private string positionSelector(string workerPositionID)
        {
            string workerPosition = "";

            foreach (WorkerPositionClass position in positions)
            {
                if (position.WorkerPositionID == workerPositionID) workerPosition = position.WorkerPosition;
            }
            return workerPosition;
        }

        private void fillTheUncredented()
        {
            databaseConnect();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "SELECT workers.worker_id, workers.worker_first_name, workers.worker_last_name, workers.worker_position_id FROM authentication, workers WHERE workers.worker_id NOT IN (SELECT authentication.authentication_id FROM authentication) AND workers.worker_position_id != 5 GROUP BY workers.worker_id";
                cmd.Connection = connect;
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        theUncredented.Add(new Worker
                        {
                            WorkerID = reader.GetString(0),
                            WorkerFirstName = reader.GetString(1),
                            WorkerLastName = reader.GetString(2),
                            WorkerPosition = positionSelector(reader.GetString(3))
                        });
                    }
                }
            }
        }

        private void fillWorkerSystemUserDirectorComboBox()
        {
            foreach (Worker item in theUncredented)
            {
                workerSystemUserDirectorComboBox.Items.Add(item.Display);
            }
        }

        private void cancelSystemUserDirectorButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addSystemUserDirectorButton_Click(object sender, EventArgs e)
        {
            if (workerSystemUserDirectorComboBox.Text == "" || passwordSystemUserDirectorTextBox.Text == "" || confirmPasswordSystemUserDirectorTextBox.Text == "")
            {
                if (workerSystemUserDirectorComboBox.Text == "")
                {
                    workerErrorSystemUserDirectorLabel.Visible = true;
                    errorDetailSystemUserDirectorLabel.Visible = true;
                }
                else
                {
                    workerErrorSystemUserDirectorLabel.Visible = false;
                    errorDetailSystemUserDirectorLabel.Visible = false;
                }

                if (passwordSystemUserDirectorTextBox.Text == "")
                {
                    passwordErrorSystemUserDirectorLabel.Visible = true;
                    errorDetailSystemUserDirectorLabel.Visible = true;
                }
                else
                {
                    passwordErrorSystemUserDirectorLabel.Visible = false;
                    errorDetailSystemUserDirectorLabel.Visible = false;
                }

                if (confirmPasswordSystemUserDirectorTextBox.Text == "")
                {
                    confirmPasswordErrorSystemUserDirectorLabel.Visible = true;
                    errorDetailSystemUserDirectorLabel.Visible = true;
                }
                else
                {
                    confirmPasswordErrorSystemUserDirectorLabel.Visible = false;
                    errorDetailSystemUserDirectorLabel.Visible = false;
                }
            }
            else
            {
                if(passwordSystemUserDirectorTextBox.Text == confirmPasswordSystemUserDirectorTextBox.Text)
                {
                    if (positionSelector(workerSystemUserDirectorComboBox.Text.Split(',')[0]) == "Tier")
                    {
                        MessageBox.Show("Tier cannot use the system");
                        workerSystemUserDirectorComboBox.Text = "";
                        passwordSystemUserDirectorTextBox.Text = "";
                        confirmPasswordSystemUserDirectorTextBox.Text = "";
                    }
                    else
                    {
                        databaseConnect();
                        using (MySqlCommand cmd = new MySqlCommand())
                        {
                            cmd.CommandText = "INSERT INTO authentication (worker_id, worker_password) VALUES (@id, @password)";
                            cmd.Parameters.AddWithValue("@id", workerSystemUserDirectorComboBox.Text.Split(',')[0]);
                            cmd.Parameters.AddWithValue("@password", passwordSystemUserDirectorTextBox.Text);
                            cmd.Connection = connect;
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("System user Added.");
                            Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Passwords do not much. Try again");
                }
            }
        }
    }
}