namespace Neptune
{
    partial class neptuneWelcomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(neptuneWelcomeForm));
            this.welcomePictureBox = new System.Windows.Forms.PictureBox();
            this.separatorWelcomeLabel = new System.Windows.Forms.Label();
            this.exitWelcomeButton = new System.Windows.Forms.Button();
            this.nextWelcomeButton = new System.Windows.Forms.Button();
            this.welcomeTextLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.welcomePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // welcomePictureBox
            // 
            this.welcomePictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("welcomePictureBox.BackgroundImage")));
            this.welcomePictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.welcomePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("welcomePictureBox.Image")));
            this.welcomePictureBox.Location = new System.Drawing.Point(0, 0);
            this.welcomePictureBox.Name = "welcomePictureBox";
            this.welcomePictureBox.Size = new System.Drawing.Size(100, 420);
            this.welcomePictureBox.TabIndex = 0;
            this.welcomePictureBox.TabStop = false;
            // 
            // separatorWelcomeLabel
            // 
            this.separatorWelcomeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.separatorWelcomeLabel.Location = new System.Drawing.Point(0, 339);
            this.separatorWelcomeLabel.Name = "separatorWelcomeLabel";
            this.separatorWelcomeLabel.Size = new System.Drawing.Size(721, 81);
            this.separatorWelcomeLabel.TabIndex = 1;
            // 
            // exitWelcomeButton
            // 
            this.exitWelcomeButton.Location = new System.Drawing.Point(619, 372);
            this.exitWelcomeButton.Name = "exitWelcomeButton";
            this.exitWelcomeButton.Size = new System.Drawing.Size(75, 23);
            this.exitWelcomeButton.TabIndex = 2;
            this.exitWelcomeButton.Text = "Exit";
            this.exitWelcomeButton.UseVisualStyleBackColor = true;
            this.exitWelcomeButton.Click += new System.EventHandler(this.exitWelcomeButton_Click);
            // 
            // nextWelcomeButton
            // 
            this.nextWelcomeButton.Location = new System.Drawing.Point(504, 372);
            this.nextWelcomeButton.Name = "nextWelcomeButton";
            this.nextWelcomeButton.Size = new System.Drawing.Size(75, 23);
            this.nextWelcomeButton.TabIndex = 3;
            this.nextWelcomeButton.Text = "Next";
            this.nextWelcomeButton.UseVisualStyleBackColor = true;
            this.nextWelcomeButton.Click += new System.EventHandler(this.nextWelcomeButton_Click);
            // 
            // welcomeTextLabel
            // 
            this.welcomeTextLabel.AutoSize = true;
            this.welcomeTextLabel.Location = new System.Drawing.Point(106, 9);
            this.welcomeTextLabel.Name = "welcomeTextLabel";
            this.welcomeTextLabel.Size = new System.Drawing.Size(225, 13);
            this.welcomeTextLabel.TabIndex = 4;
            this.welcomeTextLabel.Text = "Welcome To Neptune Management Software ";
            // 
            // neptuneWelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 420);
            this.Controls.Add(this.welcomeTextLabel);
            this.Controls.Add(this.nextWelcomeButton);
            this.Controls.Add(this.exitWelcomeButton);
            this.Controls.Add(this.welcomePictureBox);
            this.Controls.Add(this.separatorWelcomeLabel);
            this.MaximizeBox = false;
            this.Name = "neptuneWelcomeForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Neptune Flies Company";
            ((System.ComponentModel.ISupportInitialize)(this.welcomePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox welcomePictureBox;
        private System.Windows.Forms.Label separatorWelcomeLabel;
        private System.Windows.Forms.Button exitWelcomeButton;
        private System.Windows.Forms.Button nextWelcomeButton;
        private System.Windows.Forms.Label welcomeTextLabel;
    }
}

