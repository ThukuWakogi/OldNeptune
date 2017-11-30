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

namespace Neptune
{
    public partial class ModifySystemUSerDirectorForm : Form
    {
        private string conn;
        private MySqlConnection connect;
        private Authentication authentication;

        public ModifySystemUSerDirectorForm(string workerDetail)
        {
            InitializeComponent();
            fillFields(workerDetail);
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
        
        private void fillFields(string workerDetail)
        {
            workerDetailsModifySystemUserDirectorLabel.Text = workerDetail;
        }

        private void ModifySystemUSerDirectorForm_Load(object sender, EventArgs e)
        {
            if (passwordModifySystemUserDirectorTextBox.Text == "" || confirmPasswordModifySystemUserDirectorTextBox.Text == "")
            {
                if (passwordModifySystemUserDirectorTextBox.Text == "")
                {
                    passwordErrorModifySystemUserDirectorLabel.Visible = true;
                    errorDetailsModifySystemUserDirectorForm.Visible = true;
                }
                else
                {
                    passwordErrorModifySystemUserDirectorLabel.Visible = false;
                    errorDetailsModifySystemUserDirectorForm.Visible = false;
                }

                if (confirmPasswordModifySystemUserDirectorTextBox.Text == "")
                {
                    confirmPasswordErrorModifySystemUserDirectorLabel.Visible = true;
                    errorDetailsModifySystemUserDirectorForm.Visible = true;
                }
                else
                {
                    confirmPasswordErrorModifySystemUserDirectorLabel.Visible = false;
                    errorDetailsModifySystemUserDirectorForm.Visible = false;
                }
            }
            else
            {
                if (confirmPasswordModifySystemUserDirectorTextBox.Text == passwordModifySystemUserDirectorTextBox.Text)
                {
                    databaseConnect();
                    using(MySqlCommand cmd = new MySqlCommand())
                    {
                        cmd.CommandText = "UPDATE authentication SET worker_password = @password WHERE worker_id = @id";
                        cmd.Parameters.AddWithValue("@password", confirmPasswordModifySystemUserDirectorTextBox.Text);
                        cmd.Parameters.AddWithValue("@id", workerDetailsModifySystemUserDirectorLabel.Text.Split(',')[0]);
                        cmd.Connection = connect;
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Credentials Modified");
                }
            }
        }

        private void cancelModifySystemUserDirectorButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}