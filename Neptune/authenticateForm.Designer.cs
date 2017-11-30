namespace Neptune
{
    partial class AuthenticateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.authenticatePanel = new System.Windows.Forms.Panel();
            this.textBoxErrorDetailsLabel = new System.Windows.Forms.Label();
            this.workerPasswordErrorLabel = new System.Windows.Forms.Label();
            this.workerIdErrorLabel = new System.Windows.Forms.Label();
            this.authenticateButton = new System.Windows.Forms.Button();
            this.workerPasswordTextBox = new System.Windows.Forms.TextBox();
            this.workerIDTextBox = new System.Windows.Forms.TextBox();
            this.workerPasswordLabel = new System.Windows.Forms.Label();
            this.workerIDLabel = new System.Windows.Forms.Label();
            this.authenticationFailedPanel = new System.Windows.Forms.Panel();
            this.tryAgainAuthenticateButton = new System.Windows.Forms.Button();
            this.authenticationFailedLabel = new System.Windows.Forms.Label();
            this.authenticationFailureDetalisLabel = new System.Windows.Forms.Label();
            this.cancelAuthenticateButton = new System.Windows.Forms.Button();
            this.authenticatePanel.SuspendLayout();
            this.authenticationFailedPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // authenticatePanel
            // 
            this.authenticatePanel.Controls.Add(this.authenticationFailedPanel);
            this.authenticatePanel.Controls.Add(this.textBoxErrorDetailsLabel);
            this.authenticatePanel.Controls.Add(this.workerPasswordErrorLabel);
            this.authenticatePanel.Controls.Add(this.workerIdErrorLabel);
            this.authenticatePanel.Controls.Add(this.authenticateButton);
            this.authenticatePanel.Controls.Add(this.workerPasswordTextBox);
            this.authenticatePanel.Controls.Add(this.workerIDTextBox);
            this.authenticatePanel.Controls.Add(this.workerPasswordLabel);
            this.authenticatePanel.Controls.Add(this.workerIDLabel);
            this.authenticatePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.authenticatePanel.Location = new System.Drawing.Point(0, 0);
            this.authenticatePanel.Name = "authenticatePanel";
            this.authenticatePanel.Size = new System.Drawing.Size(425, 250);
            this.authenticatePanel.TabIndex = 0;
            // 
            // textBoxErrorDetailsLabel
            // 
            this.textBoxErrorDetailsLabel.AutoSize = true;
            this.textBoxErrorDetailsLabel.ForeColor = System.Drawing.Color.Red;
            this.textBoxErrorDetailsLabel.Location = new System.Drawing.Point(212, 144);
            this.textBoxErrorDetailsLabel.Name = "textBoxErrorDetailsLabel";
            this.textBoxErrorDetailsLabel.Size = new System.Drawing.Size(87, 13);
            this.textBoxErrorDetailsLabel.TabIndex = 5;
            this.textBoxErrorDetailsLabel.Text = "* Field is required";
            this.textBoxErrorDetailsLabel.Visible = false;
            // 
            // workerPasswordErrorLabel
            // 
            this.workerPasswordErrorLabel.AutoSize = true;
            this.workerPasswordErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.workerPasswordErrorLabel.Location = new System.Drawing.Point(321, 111);
            this.workerPasswordErrorLabel.Name = "workerPasswordErrorLabel";
            this.workerPasswordErrorLabel.Size = new System.Drawing.Size(11, 13);
            this.workerPasswordErrorLabel.TabIndex = 5;
            this.workerPasswordErrorLabel.Text = "*";
            this.workerPasswordErrorLabel.Visible = false;
            // 
            // workerIdErrorLabel
            // 
            this.workerIdErrorLabel.AutoSize = true;
            this.workerIdErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.workerIdErrorLabel.Location = new System.Drawing.Point(321, 62);
            this.workerIdErrorLabel.Name = "workerIdErrorLabel";
            this.workerIdErrorLabel.Size = new System.Drawing.Size(11, 13);
            this.workerIdErrorLabel.TabIndex = 5;
            this.workerIdErrorLabel.Text = "*";
            this.workerIdErrorLabel.Visible = false;
            // 
            // authenticateButton
            // 
            this.authenticateButton.Location = new System.Drawing.Point(169, 170);
            this.authenticateButton.Name = "authenticateButton";
            this.authenticateButton.Size = new System.Drawing.Size(75, 23);
            this.authenticateButton.TabIndex = 4;
            this.authenticateButton.Text = "Login";
            this.authenticateButton.UseVisualStyleBackColor = true;
            this.authenticateButton.Click += new System.EventHandler(this.authenticateButton_Click);
            // 
            // workerPasswordTextBox
            // 
            this.workerPasswordTextBox.Location = new System.Drawing.Point(215, 108);
            this.workerPasswordTextBox.Name = "workerPasswordTextBox";
            this.workerPasswordTextBox.PasswordChar = '*';
            this.workerPasswordTextBox.Size = new System.Drawing.Size(100, 20);
            this.workerPasswordTextBox.TabIndex = 3;
            // 
            // workerIDTextBox
            // 
            this.workerIDTextBox.Location = new System.Drawing.Point(215, 59);
            this.workerIDTextBox.Name = "workerIDTextBox";
            this.workerIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.workerIDTextBox.TabIndex = 2;
            // 
            // workerPasswordLabel
            // 
            this.workerPasswordLabel.AutoSize = true;
            this.workerPasswordLabel.Location = new System.Drawing.Point(119, 108);
            this.workerPasswordLabel.Name = "workerPasswordLabel";
            this.workerPasswordLabel.Size = new System.Drawing.Size(53, 13);
            this.workerPasswordLabel.TabIndex = 1;
            this.workerPasswordLabel.Text = "Password";
            // 
            // workerIDLabel
            // 
            this.workerIDLabel.AutoSize = true;
            this.workerIDLabel.Location = new System.Drawing.Point(119, 62);
            this.workerIDLabel.Name = "workerIDLabel";
            this.workerIDLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.workerIDLabel.Size = new System.Drawing.Size(56, 13);
            this.workerIDLabel.TabIndex = 0;
            this.workerIDLabel.Text = "Worker ID";
            // 
            // authenticationFailedPanel
            // 
            this.authenticationFailedPanel.Controls.Add(this.cancelAuthenticateButton);
            this.authenticationFailedPanel.Controls.Add(this.authenticationFailureDetalisLabel);
            this.authenticationFailedPanel.Controls.Add(this.authenticationFailedLabel);
            this.authenticationFailedPanel.Controls.Add(this.tryAgainAuthenticateButton);
            this.authenticationFailedPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.authenticationFailedPanel.Location = new System.Drawing.Point(0, 0);
            this.authenticationFailedPanel.Name = "authenticationFailedPanel";
            this.authenticationFailedPanel.Size = new System.Drawing.Size(425, 250);
            this.authenticationFailedPanel.TabIndex = 8;
            // 
            // tryAgainAuthenticateButton
            // 
            this.tryAgainAuthenticateButton.Location = new System.Drawing.Point(45, 195);
            this.tryAgainAuthenticateButton.Name = "tryAgainAuthenticateButton";
            this.tryAgainAuthenticateButton.Size = new System.Drawing.Size(75, 23);
            this.tryAgainAuthenticateButton.TabIndex = 2;
            this.tryAgainAuthenticateButton.Text = "Try Again";
            this.tryAgainAuthenticateButton.UseVisualStyleBackColor = true;
            this.tryAgainAuthenticateButton.Click += new System.EventHandler(this.tryAgainAuthenticateButton_Click);
            // 
            // authenticationFailedLabel
            // 
            this.authenticationFailedLabel.AutoSize = true;
            this.authenticationFailedLabel.Location = new System.Drawing.Point(179, 43);
            this.authenticationFailedLabel.Name = "authenticationFailedLabel";
            this.authenticationFailedLabel.Size = new System.Drawing.Size(67, 13);
            this.authenticationFailedLabel.TabIndex = 0;
            this.authenticationFailedLabel.Text = "Login Failed,";
            this.authenticationFailedLabel.Click += new System.EventHandler(this.authenticationFailedLabel_Click);
            // 
            // authenticationFailureDetalisLabel
            // 
            this.authenticationFailureDetalisLabel.AutoSize = true;
            this.authenticationFailureDetalisLabel.Location = new System.Drawing.Point(142, 93);
            this.authenticationFailureDetalisLabel.Name = "authenticationFailureDetalisLabel";
            this.authenticationFailureDetalisLabel.Size = new System.Drawing.Size(140, 13);
            this.authenticationFailureDetalisLabel.TabIndex = 1;
            this.authenticationFailureDetalisLabel.Text = "Failure details will show here";
            // 
            // cancelAuthenticateButton
            // 
            this.cancelAuthenticateButton.Location = new System.Drawing.Point(304, 195);
            this.cancelAuthenticateButton.Name = "cancelAuthenticateButton";
            this.cancelAuthenticateButton.Size = new System.Drawing.Size(75, 23);
            this.cancelAuthenticateButton.TabIndex = 3;
            this.cancelAuthenticateButton.Text = "Cancel";
            this.cancelAuthenticateButton.UseVisualStyleBackColor = true;
            this.cancelAuthenticateButton.Click += new System.EventHandler(this.authenticateButton_Click);
            // 
            // AuthenticateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 250);
            this.Controls.Add(this.authenticatePanel);
            this.MaximizeBox = false;
            this.Name = "AuthenticateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Neptune Flies Company | Login";
            this.authenticatePanel.ResumeLayout(false);
            this.authenticatePanel.PerformLayout();
            this.authenticationFailedPanel.ResumeLayout(false);
            this.authenticationFailedPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel authenticatePanel;
        private System.Windows.Forms.Button authenticateButton;
        private System.Windows.Forms.TextBox workerPasswordTextBox;
        private System.Windows.Forms.TextBox workerIDTextBox;
        private System.Windows.Forms.Label workerPasswordLabel;
        private System.Windows.Forms.Label workerIDLabel;
        private System.Windows.Forms.Label textBoxErrorDetailsLabel;
        private System.Windows.Forms.Label workerPasswordErrorLabel;
        private System.Windows.Forms.Label workerIdErrorLabel;
        private System.Windows.Forms.Panel authenticationFailedPanel;
        private System.Windows.Forms.Button cancelAuthenticateButton;
        private System.Windows.Forms.Label authenticationFailureDetalisLabel;
        private System.Windows.Forms.Label authenticationFailedLabel;
        private System.Windows.Forms.Button tryAgainAuthenticateButton;
    }
}