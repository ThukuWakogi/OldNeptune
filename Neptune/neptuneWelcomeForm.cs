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
    public partial class neptuneWelcomeForm : Form
    {
        public neptuneWelcomeForm()
        {
            InitializeComponent();
        }

        private void nextWelcomeButton_Click(object sender, EventArgs e)
        {
            AuthenticateForm authenticateForm = new AuthenticateForm();
            authenticateForm.ShowDialog();
        }

        private void exitWelcomeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
