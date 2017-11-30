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
    public partial class AuthenticateForm : Form
    {
        private string conn;
        private MySqlConnection connect;

        public AuthenticateForm()
        {
            InitializeComponent();
            authenticatePanel.Visible = true;
        }

        /// <summary>
        /// Begins Connection
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
        /// allows limited access to users in the system
        /// </summary>
        /// <param name="ID">stores workers ID</param>
        /// <param name="password">stores workers password</param>
        /// <returns>a boolean indicating if user is allowed in or not allowed</returns>
        private bool authenticate(string ID, string password)
        {
            databaseConnect();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT * FROM authentication WHERE worker_id=@ID and worker_password=@password";
            cmd.Parameters.AddWithValue("@ID", ID);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Connection = connect;
            MySqlDataReader login = cmd.ExecuteReader();

            if (login.Read())
            {
                connect.Close();
                return true;
            }
            else
            {
                connect.Close();
                return false;
            }
        }

        /// <summary>
        /// Selects a module
        /// </summary>
        /// <param name="id">worker id used in selecting module</param>
        private void moduleSelect(string id)
        {
            databaseConnect();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT worker_position FROM worker_position_table, workers WHERE worker_position_table.worker_position_id = (SELECT workers.worker_position_id WHERE workers.worker_id = @id)";
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Connection = connect;

            switch (cmd.ExecuteScalar().ToString())
            {
                case "Director":
                    DirectorForm directorForm = new DirectorForm(id);
                    directorForm.ShowDialog();
                    break;
                case "Supervisor":
                    SupervisorForm supervisorForm = new SupervisorForm();
                    supervisorForm.ShowDialog();
                    break;
                case "Manager":
                    managerForm managerForm = new managerForm();
                    managerForm.ShowDialog();
                    break;
                case "Storekeeper":
                    storekeeperForm storeKeeper = new storekeeperForm();
                    break;
            }
            connect.Close();
        }

        private void tryAgainAuthenticateButton_Click(object sender, EventArgs e)
        {
            authenticatePanel.Visible = true;
            authenticationFailedPanel.Visible = false;
        }

        private void cancelAuthenticateButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void authenticateButton_Click(object sender, EventArgs e)
        {
            if (workerIDTextBox.Text == "" || workerPasswordTextBox.Text == "")
            {
                if (workerIDTextBox.Text == "")
                {
                    workerIdErrorLabel.Visible = true;
                    textBoxErrorDetailsLabel.Visible = true;
                }
                else
                {
                    workerIdErrorLabel.Visible = false;
                    textBoxErrorDetailsLabel.Visible = false;
                }

                if (workerPasswordTextBox.Text == "")
                {
                    workerPasswordErrorLabel.Visible = true;
                    textBoxErrorDetailsLabel.Visible = true;
                }
                else
                {
                    workerPasswordErrorLabel.Visible = false;
                    textBoxErrorDetailsLabel.Visible = false;
                }
            }
            else
            {
                if (authenticate(workerIDTextBox.Text, workerPasswordTextBox.Text))
                {
                    Hide();
                    moduleSelect(workerIDTextBox.Text);
                }
                else
                {
                    authenticationFailedPanel.Visible = true;
                    authenticatePanel.Visible = false;
                }
            }
        }

        private void authenticationFailedLabel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
