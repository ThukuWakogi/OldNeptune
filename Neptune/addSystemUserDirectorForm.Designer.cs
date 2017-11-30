namespace Neptune
{
    partial class AddSystemUserDirectorForm
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
            this.textSystemUserDirectorLabel = new System.Windows.Forms.Label();
            this.workerSystemUserDirectorLabel = new System.Windows.Forms.Label();
            this.passwordSystemUserDirectorLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.workerSystemUserDirectorComboBox = new System.Windows.Forms.ComboBox();
            this.passwordSystemUserDirectorTextBox = new System.Windows.Forms.TextBox();
            this.confirmPasswordSystemUserDirectorTextBox = new System.Windows.Forms.TextBox();
            this.addSystemUserDirectorButton = new System.Windows.Forms.Button();
            this.cancelSystemUserDirectorButton = new System.Windows.Forms.Button();
            this.workerErrorSystemUserDirectorLabel = new System.Windows.Forms.Label();
            this.passwordErrorSystemUserDirectorLabel = new System.Windows.Forms.Label();
            this.confirmPasswordErrorSystemUserDirectorLabel = new System.Windows.Forms.Label();
            this.errorDetailSystemUserDirectorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textSystemUserDirectorLabel
            // 
            this.textSystemUserDirectorLabel.AutoSize = true;
            this.textSystemUserDirectorLabel.Location = new System.Drawing.Point(63, 6);
            this.textSystemUserDirectorLabel.Name = "textSystemUserDirectorLabel";
            this.textSystemUserDirectorLabel.Size = new System.Drawing.Size(332, 13);
            this.textSystemUserDirectorLabel.TabIndex = 0;
            this.textSystemUserDirectorLabel.Text = "Only workers who have no credentials can be added apart from Tiers";
            // 
            // workerSystemUserDirectorLabel
            // 
            this.workerSystemUserDirectorLabel.AutoSize = true;
            this.workerSystemUserDirectorLabel.Location = new System.Drawing.Point(165, 52);
            this.workerSystemUserDirectorLabel.Name = "workerSystemUserDirectorLabel";
            this.workerSystemUserDirectorLabel.Size = new System.Drawing.Size(42, 13);
            this.workerSystemUserDirectorLabel.TabIndex = 1;
            this.workerSystemUserDirectorLabel.Text = "Worker";
            // 
            // passwordSystemUserDirectorLabel
            // 
            this.passwordSystemUserDirectorLabel.AutoSize = true;
            this.passwordSystemUserDirectorLabel.Location = new System.Drawing.Point(154, 84);
            this.passwordSystemUserDirectorLabel.Name = "passwordSystemUserDirectorLabel";
            this.passwordSystemUserDirectorLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordSystemUserDirectorLabel.TabIndex = 2;
            this.passwordSystemUserDirectorLabel.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Confirm password";
            // 
            // workerSystemUserDirectorComboBox
            // 
            this.workerSystemUserDirectorComboBox.FormattingEnabled = true;
            this.workerSystemUserDirectorComboBox.Location = new System.Drawing.Point(213, 49);
            this.workerSystemUserDirectorComboBox.Name = "workerSystemUserDirectorComboBox";
            this.workerSystemUserDirectorComboBox.Size = new System.Drawing.Size(153, 21);
            this.workerSystemUserDirectorComboBox.TabIndex = 4;
            // 
            // passwordSystemUserDirectorTextBox
            // 
            this.passwordSystemUserDirectorTextBox.Location = new System.Drawing.Point(213, 81);
            this.passwordSystemUserDirectorTextBox.Name = "passwordSystemUserDirectorTextBox";
            this.passwordSystemUserDirectorTextBox.PasswordChar = '*';
            this.passwordSystemUserDirectorTextBox.Size = new System.Drawing.Size(153, 20);
            this.passwordSystemUserDirectorTextBox.TabIndex = 5;
            // 
            // confirmPasswordSystemUserDirectorTextBox
            // 
            this.confirmPasswordSystemUserDirectorTextBox.Location = new System.Drawing.Point(213, 114);
            this.confirmPasswordSystemUserDirectorTextBox.Name = "confirmPasswordSystemUserDirectorTextBox";
            this.confirmPasswordSystemUserDirectorTextBox.PasswordChar = '*';
            this.confirmPasswordSystemUserDirectorTextBox.Size = new System.Drawing.Size(153, 20);
            this.confirmPasswordSystemUserDirectorTextBox.TabIndex = 6;
            // 
            // addSystemUserDirectorButton
            // 
            this.addSystemUserDirectorButton.Location = new System.Drawing.Point(46, 181);
            this.addSystemUserDirectorButton.Name = "addSystemUserDirectorButton";
            this.addSystemUserDirectorButton.Size = new System.Drawing.Size(75, 23);
            this.addSystemUserDirectorButton.TabIndex = 7;
            this.addSystemUserDirectorButton.Text = "Add";
            this.addSystemUserDirectorButton.UseVisualStyleBackColor = true;
            this.addSystemUserDirectorButton.Click += new System.EventHandler(this.addSystemUserDirectorButton_Click);
            // 
            // cancelSystemUserDirectorButton
            // 
            this.cancelSystemUserDirectorButton.Location = new System.Drawing.Point(373, 181);
            this.cancelSystemUserDirectorButton.Name = "cancelSystemUserDirectorButton";
            this.cancelSystemUserDirectorButton.Size = new System.Drawing.Size(75, 23);
            this.cancelSystemUserDirectorButton.TabIndex = 8;
            this.cancelSystemUserDirectorButton.Text = "Cancel";
            this.cancelSystemUserDirectorButton.UseVisualStyleBackColor = true;
            this.cancelSystemUserDirectorButton.Click += new System.EventHandler(this.cancelSystemUserDirectorButton_Click);
            // 
            // workerErrorSystemUserDirectorLabel
            // 
            this.workerErrorSystemUserDirectorLabel.AutoSize = true;
            this.workerErrorSystemUserDirectorLabel.ForeColor = System.Drawing.Color.Red;
            this.workerErrorSystemUserDirectorLabel.Location = new System.Drawing.Point(372, 52);
            this.workerErrorSystemUserDirectorLabel.Name = "workerErrorSystemUserDirectorLabel";
            this.workerErrorSystemUserDirectorLabel.Size = new System.Drawing.Size(11, 13);
            this.workerErrorSystemUserDirectorLabel.TabIndex = 9;
            this.workerErrorSystemUserDirectorLabel.Text = "*";
            this.workerErrorSystemUserDirectorLabel.Visible = false;
            // 
            // passwordErrorSystemUserDirectorLabel
            // 
            this.passwordErrorSystemUserDirectorLabel.AutoSize = true;
            this.passwordErrorSystemUserDirectorLabel.ForeColor = System.Drawing.Color.Red;
            this.passwordErrorSystemUserDirectorLabel.Location = new System.Drawing.Point(372, 84);
            this.passwordErrorSystemUserDirectorLabel.Name = "passwordErrorSystemUserDirectorLabel";
            this.passwordErrorSystemUserDirectorLabel.Size = new System.Drawing.Size(11, 13);
            this.passwordErrorSystemUserDirectorLabel.TabIndex = 9;
            this.passwordErrorSystemUserDirectorLabel.Text = "*";
            this.passwordErrorSystemUserDirectorLabel.Visible = false;
            // 
            // confirmPasswordErrorSystemUserDirectorLabel
            // 
            this.confirmPasswordErrorSystemUserDirectorLabel.AutoSize = true;
            this.confirmPasswordErrorSystemUserDirectorLabel.BackColor = System.Drawing.Color.Transparent;
            this.confirmPasswordErrorSystemUserDirectorLabel.ForeColor = System.Drawing.Color.Red;
            this.confirmPasswordErrorSystemUserDirectorLabel.Location = new System.Drawing.Point(372, 121);
            this.confirmPasswordErrorSystemUserDirectorLabel.Name = "confirmPasswordErrorSystemUserDirectorLabel";
            this.confirmPasswordErrorSystemUserDirectorLabel.Size = new System.Drawing.Size(11, 13);
            this.confirmPasswordErrorSystemUserDirectorLabel.TabIndex = 9;
            this.confirmPasswordErrorSystemUserDirectorLabel.Text = "*";
            this.confirmPasswordErrorSystemUserDirectorLabel.Visible = false;
            // 
            // errorDetailSystemUserDirectorLabel
            // 
            this.errorDetailSystemUserDirectorLabel.AutoSize = true;
            this.errorDetailSystemUserDirectorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorDetailSystemUserDirectorLabel.Location = new System.Drawing.Point(237, 150);
            this.errorDetailSystemUserDirectorLabel.Name = "errorDetailSystemUserDirectorLabel";
            this.errorDetailSystemUserDirectorLabel.Size = new System.Drawing.Size(80, 13);
            this.errorDetailSystemUserDirectorLabel.TabIndex = 9;
            this.errorDetailSystemUserDirectorLabel.Text = "Field is required";
            this.errorDetailSystemUserDirectorLabel.Visible = false;
            // 
            // AddSystemUserDirectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 215);
            this.Controls.Add(this.errorDetailSystemUserDirectorLabel);
            this.Controls.Add(this.confirmPasswordErrorSystemUserDirectorLabel);
            this.Controls.Add(this.passwordErrorSystemUserDirectorLabel);
            this.Controls.Add(this.workerErrorSystemUserDirectorLabel);
            this.Controls.Add(this.cancelSystemUserDirectorButton);
            this.Controls.Add(this.addSystemUserDirectorButton);
            this.Controls.Add(this.confirmPasswordSystemUserDirectorTextBox);
            this.Controls.Add(this.passwordSystemUserDirectorTextBox);
            this.Controls.Add(this.workerSystemUserDirectorComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordSystemUserDirectorLabel);
            this.Controls.Add(this.workerSystemUserDirectorLabel);
            this.Controls.Add(this.textSystemUserDirectorLabel);
            this.MaximizeBox = false;
            this.Name = "AddSystemUserDirectorForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add System User | Director";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textSystemUserDirectorLabel;
        private System.Windows.Forms.Label workerSystemUserDirectorLabel;
        private System.Windows.Forms.Label passwordSystemUserDirectorLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox workerSystemUserDirectorComboBox;
        private System.Windows.Forms.TextBox passwordSystemUserDirectorTextBox;
        private System.Windows.Forms.TextBox confirmPasswordSystemUserDirectorTextBox;
        private System.Windows.Forms.Button addSystemUserDirectorButton;
        private System.Windows.Forms.Button cancelSystemUserDirectorButton;
        private System.Windows.Forms.Label workerErrorSystemUserDirectorLabel;
        private System.Windows.Forms.Label passwordErrorSystemUserDirectorLabel;
        private System.Windows.Forms.Label confirmPasswordErrorSystemUserDirectorLabel;
        private System.Windows.Forms.Label errorDetailSystemUserDirectorLabel;
    }
}