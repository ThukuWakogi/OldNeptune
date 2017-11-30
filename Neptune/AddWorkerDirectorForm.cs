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

namespace Neptune
{
    public partial class AddWorkerDirectorForm : Form
    {
        private string conn;
        private MySqlConnection connect;
        private List<WorkerPositionClass> positions = new List<WorkerPositionClass>();

        public AddWorkerDirectorForm()
        {
            InitializeComponent();
            fillWorkerPositionDirectorAddWorkerComboBox();
        }

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

        private void fillWorkerPositionDirectorAddWorkerComboBox()
        {
            databaseConnect();
            using(MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "SELECT * FROM worker_position_table";
                cmd.Connection = connect;
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        workerPositionDirectorAddWorkerComboBox.Items.Add(reader["worker_position"].ToString());
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

        private string positionIDSelector()
        {
            string positionID = "";

            foreach (WorkerPositionClass position in positions)
            {
                if (position.WorkerPosition == workerPositionDirectorAddWorkerComboBox.Text) positionID = position.WorkerPositionID;
            }
            return positionID;
        }

        private void cancelAddWorkerDirectorForm_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void addAddWorkerDirectorButton_Click(object sender, EventArgs e)
        {
            databaseConnect();
            using(MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "INSERT INTO workers (worker_first_name, worker_last_name, worker_position_id, worker_phone_number, worker_employement_status) VALUES (@firstName, @lastName, @positionID, @phoneNumber, @employementStatus);";
                cmd.Parameters.AddWithValue("@firstName", workerFirstNameDirectorAddWorkerTextBox.Text);
                cmd.Parameters.AddWithValue("@lastName", workerLastNameDirectorAddWorkerTextBox.Text);
                cmd.Parameters.AddWithValue("@positionID", positionIDSelector());
                cmd.Parameters.AddWithValue("@phoneNumber", workerPhoneNumberDirectorAddWorkerTextBox.Text);
                cmd.Parameters.AddWithValue("@employementStatus", "Employeed");
                cmd.Connection = connect;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Worker Added.");
                Close();
            }
        }
    }
}