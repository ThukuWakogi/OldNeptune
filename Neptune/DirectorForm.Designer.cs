namespace Neptune
{
    partial class DirectorForm
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
            this.directorFormTabControl = new System.Windows.Forms.TabControl();
            this.workersDirectorTabPage = new System.Windows.Forms.TabPage();
            this.removeSystemUserWorkerDirectorButton = new System.Windows.Forms.Button();
            this.systemUsersDirectorLabel = new System.Windows.Forms.Label();
            this.systemUsersDirectorListBox = new System.Windows.Forms.ListBox();
            this.workersDirectorLabel = new System.Windows.Forms.Label();
            this.refreshWorkerDirectorButton = new System.Windows.Forms.Button();
            this.fireWorkerDirectorButton = new System.Windows.Forms.Button();
            this.modifySystemUserWorkerDirectorButton = new System.Windows.Forms.Button();
            this.ModifyWorkerDirectorButton = new System.Windows.Forms.Button();
            this.addSystemUsersDirectorLinkLabel = new System.Windows.Forms.LinkLabel();
            this.addWorkersDirectorLinkLabel = new System.Windows.Forms.LinkLabel();
            this.workersDirectorListBox = new System.Windows.Forms.ListBox();
            this.materialsDirectorTabPage = new System.Windows.Forms.TabPage();
            this.detailsShortageOrDepletionAlertDirectorButton = new System.Windows.Forms.Button();
            this.refreshMaterialsDirectorButton = new System.Windows.Forms.Button();
            this.shortageOrDepletionDirectorFormListBox = new System.Windows.Forms.ListBox();
            this.shortageOrDepletionAlertDirectorFormLabel = new System.Windows.Forms.Label();
            this.detailsRequisitesDirectorButton = new System.Windows.Forms.Button();
            this.detailsMaterialsDirectorButton = new System.Windows.Forms.Button();
            this.materialsInStockDirectorFormLabel = new System.Windows.Forms.Label();
            this.materialsInStockDirectorFormListBox = new System.Windows.Forms.ListBox();
            this.modifyMaterialsDirectorButton = new System.Windows.Forms.Button();
            this.addMaterialsDirectorLinkLabel = new System.Windows.Forms.LinkLabel();
            this.materialsDirectorFormListBox = new System.Windows.Forms.ListBox();
            this.materialsDirectorFormLabel = new System.Windows.Forms.Label();
            this.ordersDirectorTabPage = new System.Windows.Forms.TabPage();
            this.fliesDirectorTabPage = new System.Windows.Forms.TabPage();
            this.salariesDirectorTabPage = new System.Windows.Forms.TabPage();
            this.ForecastDirectorTabPage = new System.Windows.Forms.TabPage();
            this.logOutDirectorButton = new System.Windows.Forms.Button();
            this.exitDirectorButton = new System.Windows.Forms.Button();
            this.userLoggedInTextDirectorLabel = new System.Windows.Forms.Label();
            this.userLoggedInNameDirectorLinkLabel = new System.Windows.Forms.LinkLabel();
            this.FliesDirectorFormListBox = new System.Windows.Forms.ListBox();
            this.fliesDirectorFormLabel = new System.Windows.Forms.Label();
            this.addFliesDirectorFormLinkLabel = new System.Windows.Forms.LinkLabel();
            this.flyMaterialsDirectorFormListBox = new System.Windows.Forms.ListBox();
            this.flyMaterialsDirectorFormLabel = new System.Windows.Forms.Label();
            this.modifyFlyDirectorFormButton = new System.Windows.Forms.Button();
            this.addFlyMaterialDirectorFormButton = new System.Windows.Forms.Button();
            this.removeFlyMaterialDirectorFormButton = new System.Windows.Forms.Button();
            this.disableFlyDirectorFormButton = new System.Windows.Forms.Button();
            this.directorFormTabControl.SuspendLayout();
            this.workersDirectorTabPage.SuspendLayout();
            this.materialsDirectorTabPage.SuspendLayout();
            this.fliesDirectorTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // directorFormTabControl
            // 
            this.directorFormTabControl.Controls.Add(this.workersDirectorTabPage);
            this.directorFormTabControl.Controls.Add(this.materialsDirectorTabPage);
            this.directorFormTabControl.Controls.Add(this.fliesDirectorTabPage);
            this.directorFormTabControl.Controls.Add(this.ordersDirectorTabPage);
            this.directorFormTabControl.Controls.Add(this.salariesDirectorTabPage);
            this.directorFormTabControl.Controls.Add(this.ForecastDirectorTabPage);
            this.directorFormTabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.directorFormTabControl.Location = new System.Drawing.Point(0, 0);
            this.directorFormTabControl.Name = "directorFormTabControl";
            this.directorFormTabControl.SelectedIndex = 0;
            this.directorFormTabControl.Size = new System.Drawing.Size(993, 518);
            this.directorFormTabControl.TabIndex = 0;
            // 
            // workersDirectorTabPage
            // 
            this.workersDirectorTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.workersDirectorTabPage.Controls.Add(this.removeSystemUserWorkerDirectorButton);
            this.workersDirectorTabPage.Controls.Add(this.systemUsersDirectorLabel);
            this.workersDirectorTabPage.Controls.Add(this.systemUsersDirectorListBox);
            this.workersDirectorTabPage.Controls.Add(this.workersDirectorLabel);
            this.workersDirectorTabPage.Controls.Add(this.refreshWorkerDirectorButton);
            this.workersDirectorTabPage.Controls.Add(this.fireWorkerDirectorButton);
            this.workersDirectorTabPage.Controls.Add(this.modifySystemUserWorkerDirectorButton);
            this.workersDirectorTabPage.Controls.Add(this.ModifyWorkerDirectorButton);
            this.workersDirectorTabPage.Controls.Add(this.addSystemUsersDirectorLinkLabel);
            this.workersDirectorTabPage.Controls.Add(this.addWorkersDirectorLinkLabel);
            this.workersDirectorTabPage.Controls.Add(this.workersDirectorListBox);
            this.workersDirectorTabPage.Location = new System.Drawing.Point(4, 22);
            this.workersDirectorTabPage.Name = "workersDirectorTabPage";
            this.workersDirectorTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.workersDirectorTabPage.Size = new System.Drawing.Size(985, 492);
            this.workersDirectorTabPage.TabIndex = 0;
            this.workersDirectorTabPage.Text = "Workers";
            // 
            // removeSystemUserWorkerDirectorButton
            // 
            this.removeSystemUserWorkerDirectorButton.Location = new System.Drawing.Point(717, 48);
            this.removeSystemUserWorkerDirectorButton.Name = "removeSystemUserWorkerDirectorButton";
            this.removeSystemUserWorkerDirectorButton.Size = new System.Drawing.Size(75, 23);
            this.removeSystemUserWorkerDirectorButton.TabIndex = 9;
            this.removeSystemUserWorkerDirectorButton.Text = "Remove";
            this.removeSystemUserWorkerDirectorButton.UseVisualStyleBackColor = true;
            this.removeSystemUserWorkerDirectorButton.Click += new System.EventHandler(this.removeSystemUserWorkerDirectorButton_Click);
            // 
            // systemUsersDirectorLabel
            // 
            this.systemUsersDirectorLabel.AutoSize = true;
            this.systemUsersDirectorLabel.Location = new System.Drawing.Point(472, 4);
            this.systemUsersDirectorLabel.Name = "systemUsersDirectorLabel";
            this.systemUsersDirectorLabel.Size = new System.Drawing.Size(71, 13);
            this.systemUsersDirectorLabel.TabIndex = 8;
            this.systemUsersDirectorLabel.Text = "System Users";
            // 
            // systemUsersDirectorListBox
            // 
            this.systemUsersDirectorListBox.FormattingEnabled = true;
            this.systemUsersDirectorListBox.Location = new System.Drawing.Point(475, 20);
            this.systemUsersDirectorListBox.Name = "systemUsersDirectorListBox";
            this.systemUsersDirectorListBox.Size = new System.Drawing.Size(236, 459);
            this.systemUsersDirectorListBox.TabIndex = 7;
            // 
            // workersDirectorLabel
            // 
            this.workersDirectorLabel.AutoSize = true;
            this.workersDirectorLabel.Location = new System.Drawing.Point(149, 3);
            this.workersDirectorLabel.Name = "workersDirectorLabel";
            this.workersDirectorLabel.Size = new System.Drawing.Size(47, 13);
            this.workersDirectorLabel.TabIndex = 6;
            this.workersDirectorLabel.Text = "Workers";
            // 
            // refreshWorkerDirectorButton
            // 
            this.refreshWorkerDirectorButton.Location = new System.Drawing.Point(12, 455);
            this.refreshWorkerDirectorButton.Name = "refreshWorkerDirectorButton";
            this.refreshWorkerDirectorButton.Size = new System.Drawing.Size(75, 23);
            this.refreshWorkerDirectorButton.TabIndex = 5;
            this.refreshWorkerDirectorButton.Text = "Refresh";
            this.refreshWorkerDirectorButton.UseVisualStyleBackColor = true;
            this.refreshWorkerDirectorButton.Click += new System.EventHandler(this.refreshWorkerDirectorButton_Click);
            // 
            // fireWorkerDirectorButton
            // 
            this.fireWorkerDirectorButton.Location = new System.Drawing.Point(394, 48);
            this.fireWorkerDirectorButton.Name = "fireWorkerDirectorButton";
            this.fireWorkerDirectorButton.Size = new System.Drawing.Size(75, 23);
            this.fireWorkerDirectorButton.TabIndex = 4;
            this.fireWorkerDirectorButton.Text = "Fire";
            this.fireWorkerDirectorButton.UseVisualStyleBackColor = true;
            this.fireWorkerDirectorButton.Click += new System.EventHandler(this.fireWorkerDirectorButton_Click);
            // 
            // modifySystemUserWorkerDirectorButton
            // 
            this.modifySystemUserWorkerDirectorButton.Location = new System.Drawing.Point(717, 20);
            this.modifySystemUserWorkerDirectorButton.Name = "modifySystemUserWorkerDirectorButton";
            this.modifySystemUserWorkerDirectorButton.Size = new System.Drawing.Size(75, 23);
            this.modifySystemUserWorkerDirectorButton.TabIndex = 3;
            this.modifySystemUserWorkerDirectorButton.Text = "Modify";
            this.modifySystemUserWorkerDirectorButton.UseVisualStyleBackColor = true;
            this.modifySystemUserWorkerDirectorButton.Click += new System.EventHandler(this.modifySystemUserWorkerDirectorButton_Click);
            // 
            // ModifyWorkerDirectorButton
            // 
            this.ModifyWorkerDirectorButton.Location = new System.Drawing.Point(394, 19);
            this.ModifyWorkerDirectorButton.Name = "ModifyWorkerDirectorButton";
            this.ModifyWorkerDirectorButton.Size = new System.Drawing.Size(75, 23);
            this.ModifyWorkerDirectorButton.TabIndex = 3;
            this.ModifyWorkerDirectorButton.Text = "Modify";
            this.ModifyWorkerDirectorButton.UseVisualStyleBackColor = true;
            this.ModifyWorkerDirectorButton.Click += new System.EventHandler(this.ModifyWorkerDirectorButton_Click);
            // 
            // addSystemUsersDirectorLinkLabel
            // 
            this.addSystemUsersDirectorLinkLabel.AutoSize = true;
            this.addSystemUsersDirectorLinkLabel.Location = new System.Drawing.Point(9, 35);
            this.addSystemUsersDirectorLinkLabel.Name = "addSystemUsersDirectorLinkLabel";
            this.addSystemUsersDirectorLinkLabel.Size = new System.Drawing.Size(89, 13);
            this.addSystemUsersDirectorLinkLabel.TabIndex = 2;
            this.addSystemUsersDirectorLinkLabel.TabStop = true;
            this.addSystemUsersDirectorLinkLabel.Text = "Add system users";
            this.addSystemUsersDirectorLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.addSystemUsersDirectorLinkLabel_LinkClicked);
            // 
            // addWorkersDirectorLinkLabel
            // 
            this.addWorkersDirectorLinkLabel.AutoSize = true;
            this.addWorkersDirectorLinkLabel.Location = new System.Drawing.Point(9, 10);
            this.addWorkersDirectorLinkLabel.Name = "addWorkersDirectorLinkLabel";
            this.addWorkersDirectorLinkLabel.Size = new System.Drawing.Size(66, 13);
            this.addWorkersDirectorLinkLabel.TabIndex = 1;
            this.addWorkersDirectorLinkLabel.TabStop = true;
            this.addWorkersDirectorLinkLabel.Text = "Add workers";
            this.addWorkersDirectorLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.addWorkersDirectorLinkLabel_LinkClicked);
            // 
            // workersDirectorListBox
            // 
            this.workersDirectorListBox.FormattingEnabled = true;
            this.workersDirectorListBox.Location = new System.Drawing.Point(152, 19);
            this.workersDirectorListBox.Name = "workersDirectorListBox";
            this.workersDirectorListBox.Size = new System.Drawing.Size(236, 459);
            this.workersDirectorListBox.TabIndex = 0;
            // 
            // materialsDirectorTabPage
            // 
            this.materialsDirectorTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.materialsDirectorTabPage.Controls.Add(this.detailsShortageOrDepletionAlertDirectorButton);
            this.materialsDirectorTabPage.Controls.Add(this.refreshMaterialsDirectorButton);
            this.materialsDirectorTabPage.Controls.Add(this.shortageOrDepletionDirectorFormListBox);
            this.materialsDirectorTabPage.Controls.Add(this.shortageOrDepletionAlertDirectorFormLabel);
            this.materialsDirectorTabPage.Controls.Add(this.detailsRequisitesDirectorButton);
            this.materialsDirectorTabPage.Controls.Add(this.detailsMaterialsDirectorButton);
            this.materialsDirectorTabPage.Controls.Add(this.materialsInStockDirectorFormLabel);
            this.materialsDirectorTabPage.Controls.Add(this.materialsInStockDirectorFormListBox);
            this.materialsDirectorTabPage.Controls.Add(this.modifyMaterialsDirectorButton);
            this.materialsDirectorTabPage.Controls.Add(this.addMaterialsDirectorLinkLabel);
            this.materialsDirectorTabPage.Controls.Add(this.materialsDirectorFormListBox);
            this.materialsDirectorTabPage.Controls.Add(this.materialsDirectorFormLabel);
            this.materialsDirectorTabPage.Location = new System.Drawing.Point(4, 22);
            this.materialsDirectorTabPage.Name = "materialsDirectorTabPage";
            this.materialsDirectorTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.materialsDirectorTabPage.Size = new System.Drawing.Size(985, 492);
            this.materialsDirectorTabPage.TabIndex = 1;
            this.materialsDirectorTabPage.Text = "Materials";
            // 
            // detailsShortageOrDepletionAlertDirectorButton
            // 
            this.detailsShortageOrDepletionAlertDirectorButton.Location = new System.Drawing.Point(717, 241);
            this.detailsShortageOrDepletionAlertDirectorButton.Name = "detailsShortageOrDepletionAlertDirectorButton";
            this.detailsShortageOrDepletionAlertDirectorButton.Size = new System.Drawing.Size(75, 23);
            this.detailsShortageOrDepletionAlertDirectorButton.TabIndex = 12;
            this.detailsShortageOrDepletionAlertDirectorButton.Text = "Details";
            this.detailsShortageOrDepletionAlertDirectorButton.UseVisualStyleBackColor = true;
            this.detailsShortageOrDepletionAlertDirectorButton.Click += new System.EventHandler(this.detailsShortageOrDepletionAlertDirectorButton_Click);
            // 
            // refreshMaterialsDirectorButton
            // 
            this.refreshMaterialsDirectorButton.Location = new System.Drawing.Point(12, 455);
            this.refreshMaterialsDirectorButton.Name = "refreshMaterialsDirectorButton";
            this.refreshMaterialsDirectorButton.Size = new System.Drawing.Size(75, 23);
            this.refreshMaterialsDirectorButton.TabIndex = 11;
            this.refreshMaterialsDirectorButton.Text = "Refresh";
            this.refreshMaterialsDirectorButton.UseVisualStyleBackColor = true;
            this.refreshMaterialsDirectorButton.Click += new System.EventHandler(this.refreshMaterialsDirectorButton_Click);
            // 
            // shortageOrDepletionDirectorFormListBox
            // 
            this.shortageOrDepletionDirectorFormListBox.FormattingEnabled = true;
            this.shortageOrDepletionDirectorFormListBox.Location = new System.Drawing.Point(475, 241);
            this.shortageOrDepletionDirectorFormListBox.Name = "shortageOrDepletionDirectorFormListBox";
            this.shortageOrDepletionDirectorFormListBox.Size = new System.Drawing.Size(236, 238);
            this.shortageOrDepletionDirectorFormListBox.TabIndex = 10;
            // 
            // shortageOrDepletionAlertDirectorFormLabel
            // 
            this.shortageOrDepletionAlertDirectorFormLabel.AutoSize = true;
            this.shortageOrDepletionAlertDirectorFormLabel.Location = new System.Drawing.Point(472, 225);
            this.shortageOrDepletionAlertDirectorFormLabel.Name = "shortageOrDepletionAlertDirectorFormLabel";
            this.shortageOrDepletionAlertDirectorFormLabel.Size = new System.Drawing.Size(136, 13);
            this.shortageOrDepletionAlertDirectorFormLabel.TabIndex = 9;
            this.shortageOrDepletionAlertDirectorFormLabel.Text = "Shortage Or Depletion Alert";
            // 
            // detailsRequisitesDirectorButton
            // 
            this.detailsRequisitesDirectorButton.Location = new System.Drawing.Point(717, 20);
            this.detailsRequisitesDirectorButton.Name = "detailsRequisitesDirectorButton";
            this.detailsRequisitesDirectorButton.Size = new System.Drawing.Size(75, 23);
            this.detailsRequisitesDirectorButton.TabIndex = 8;
            this.detailsRequisitesDirectorButton.Text = "Details";
            this.detailsRequisitesDirectorButton.UseVisualStyleBackColor = true;
            this.detailsRequisitesDirectorButton.Click += new System.EventHandler(this.detailsRequisitesDirectorButton_Click);
            // 
            // detailsMaterialsDirectorButton
            // 
            this.detailsMaterialsDirectorButton.Location = new System.Drawing.Point(394, 19);
            this.detailsMaterialsDirectorButton.Name = "detailsMaterialsDirectorButton";
            this.detailsMaterialsDirectorButton.Size = new System.Drawing.Size(75, 23);
            this.detailsMaterialsDirectorButton.TabIndex = 7;
            this.detailsMaterialsDirectorButton.Text = "Details";
            this.detailsMaterialsDirectorButton.UseVisualStyleBackColor = true;
            this.detailsMaterialsDirectorButton.Click += new System.EventHandler(this.detailsMaterialsDirectorButton_Click);
            // 
            // materialsInStockDirectorFormLabel
            // 
            this.materialsInStockDirectorFormLabel.AutoSize = true;
            this.materialsInStockDirectorFormLabel.Location = new System.Drawing.Point(472, 3);
            this.materialsInStockDirectorFormLabel.Name = "materialsInStockDirectorFormLabel";
            this.materialsInStockDirectorFormLabel.Size = new System.Drawing.Size(86, 13);
            this.materialsInStockDirectorFormLabel.TabIndex = 5;
            this.materialsInStockDirectorFormLabel.Text = "Material in Stock";
            // 
            // materialsInStockDirectorFormListBox
            // 
            this.materialsInStockDirectorFormListBox.FormattingEnabled = true;
            this.materialsInStockDirectorFormListBox.Location = new System.Drawing.Point(475, 20);
            this.materialsInStockDirectorFormListBox.Name = "materialsInStockDirectorFormListBox";
            this.materialsInStockDirectorFormListBox.Size = new System.Drawing.Size(236, 186);
            this.materialsInStockDirectorFormListBox.TabIndex = 4;
            // 
            // modifyMaterialsDirectorButton
            // 
            this.modifyMaterialsDirectorButton.Location = new System.Drawing.Point(394, 48);
            this.modifyMaterialsDirectorButton.Name = "modifyMaterialsDirectorButton";
            this.modifyMaterialsDirectorButton.Size = new System.Drawing.Size(75, 23);
            this.modifyMaterialsDirectorButton.TabIndex = 3;
            this.modifyMaterialsDirectorButton.Text = "Modify";
            this.modifyMaterialsDirectorButton.UseVisualStyleBackColor = true;
            this.modifyMaterialsDirectorButton.Click += new System.EventHandler(this.modifyMaterialsDirectorButton_Click);
            // 
            // addMaterialsDirectorLinkLabel
            // 
            this.addMaterialsDirectorLinkLabel.AutoSize = true;
            this.addMaterialsDirectorLinkLabel.Location = new System.Drawing.Point(9, 10);
            this.addMaterialsDirectorLinkLabel.Name = "addMaterialsDirectorLinkLabel";
            this.addMaterialsDirectorLinkLabel.Size = new System.Drawing.Size(71, 13);
            this.addMaterialsDirectorLinkLabel.TabIndex = 2;
            this.addMaterialsDirectorLinkLabel.TabStop = true;
            this.addMaterialsDirectorLinkLabel.Text = "Add Materials";
            this.addMaterialsDirectorLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.addMaterialsDirectorLinkLabel_LinkClicked);
            // 
            // materialsDirectorFormListBox
            // 
            this.materialsDirectorFormListBox.FormattingEnabled = true;
            this.materialsDirectorFormListBox.Location = new System.Drawing.Point(152, 19);
            this.materialsDirectorFormListBox.Name = "materialsDirectorFormListBox";
            this.materialsDirectorFormListBox.Size = new System.Drawing.Size(236, 459);
            this.materialsDirectorFormListBox.TabIndex = 1;
            // 
            // materialsDirectorFormLabel
            // 
            this.materialsDirectorFormLabel.AutoSize = true;
            this.materialsDirectorFormLabel.Location = new System.Drawing.Point(149, 3);
            this.materialsDirectorFormLabel.Name = "materialsDirectorFormLabel";
            this.materialsDirectorFormLabel.Size = new System.Drawing.Size(49, 13);
            this.materialsDirectorFormLabel.TabIndex = 0;
            this.materialsDirectorFormLabel.Text = "Materials";
            // 
            // ordersDirectorTabPage
            // 
            this.ordersDirectorTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.ordersDirectorTabPage.Location = new System.Drawing.Point(4, 22);
            this.ordersDirectorTabPage.Name = "ordersDirectorTabPage";
            this.ordersDirectorTabPage.Size = new System.Drawing.Size(985, 492);
            this.ordersDirectorTabPage.TabIndex = 2;
            this.ordersDirectorTabPage.Text = "Orders";
            // 
            // fliesDirectorTabPage
            // 
            this.fliesDirectorTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.fliesDirectorTabPage.Controls.Add(this.disableFlyDirectorFormButton);
            this.fliesDirectorTabPage.Controls.Add(this.removeFlyMaterialDirectorFormButton);
            this.fliesDirectorTabPage.Controls.Add(this.addFlyMaterialDirectorFormButton);
            this.fliesDirectorTabPage.Controls.Add(this.modifyFlyDirectorFormButton);
            this.fliesDirectorTabPage.Controls.Add(this.flyMaterialsDirectorFormLabel);
            this.fliesDirectorTabPage.Controls.Add(this.flyMaterialsDirectorFormListBox);
            this.fliesDirectorTabPage.Controls.Add(this.addFliesDirectorFormLinkLabel);
            this.fliesDirectorTabPage.Controls.Add(this.fliesDirectorFormLabel);
            this.fliesDirectorTabPage.Controls.Add(this.FliesDirectorFormListBox);
            this.fliesDirectorTabPage.Location = new System.Drawing.Point(4, 22);
            this.fliesDirectorTabPage.Name = "fliesDirectorTabPage";
            this.fliesDirectorTabPage.Size = new System.Drawing.Size(985, 492);
            this.fliesDirectorTabPage.TabIndex = 3;
            this.fliesDirectorTabPage.Text = "Flies";
            // 
            // salariesDirectorTabPage
            // 
            this.salariesDirectorTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.salariesDirectorTabPage.Location = new System.Drawing.Point(4, 22);
            this.salariesDirectorTabPage.Name = "salariesDirectorTabPage";
            this.salariesDirectorTabPage.Size = new System.Drawing.Size(985, 492);
            this.salariesDirectorTabPage.TabIndex = 4;
            this.salariesDirectorTabPage.Text = "Salaries";
            // 
            // ForecastDirectorTabPage
            // 
            this.ForecastDirectorTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.ForecastDirectorTabPage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ForecastDirectorTabPage.Location = new System.Drawing.Point(4, 22);
            this.ForecastDirectorTabPage.Name = "ForecastDirectorTabPage";
            this.ForecastDirectorTabPage.Size = new System.Drawing.Size(985, 492);
            this.ForecastDirectorTabPage.TabIndex = 5;
            this.ForecastDirectorTabPage.Text = "ForeCast";
            // 
            // logOutDirectorButton
            // 
            this.logOutDirectorButton.Location = new System.Drawing.Point(825, 540);
            this.logOutDirectorButton.Name = "logOutDirectorButton";
            this.logOutDirectorButton.Size = new System.Drawing.Size(75, 23);
            this.logOutDirectorButton.TabIndex = 1;
            this.logOutDirectorButton.Text = "Log Out";
            this.logOutDirectorButton.UseVisualStyleBackColor = true;
            this.logOutDirectorButton.Click += new System.EventHandler(this.logOutDirectorButton_Click);
            // 
            // exitDirectorButton
            // 
            this.exitDirectorButton.Location = new System.Drawing.Point(906, 540);
            this.exitDirectorButton.Name = "exitDirectorButton";
            this.exitDirectorButton.Size = new System.Drawing.Size(75, 23);
            this.exitDirectorButton.TabIndex = 2;
            this.exitDirectorButton.Text = "Exit";
            this.exitDirectorButton.UseVisualStyleBackColor = true;
            this.exitDirectorButton.Click += new System.EventHandler(this.exitDirectorButton_Click);
            // 
            // userLoggedInTextDirectorLabel
            // 
            this.userLoggedInTextDirectorLabel.AutoSize = true;
            this.userLoggedInTextDirectorLabel.Location = new System.Drawing.Point(13, 545);
            this.userLoggedInTextDirectorLabel.Name = "userLoggedInTextDirectorLabel";
            this.userLoggedInTextDirectorLabel.Size = new System.Drawing.Size(71, 13);
            this.userLoggedInTextDirectorLabel.TabIndex = 3;
            this.userLoggedInTextDirectorLabel.Text = "Logged in as:";
            // 
            // userLoggedInNameDirectorLinkLabel
            // 
            this.userLoggedInNameDirectorLinkLabel.AutoSize = true;
            this.userLoggedInNameDirectorLinkLabel.Location = new System.Drawing.Point(90, 545);
            this.userLoggedInNameDirectorLinkLabel.Name = "userLoggedInNameDirectorLinkLabel";
            this.userLoggedInNameDirectorLinkLabel.Size = new System.Drawing.Size(67, 13);
            this.userLoggedInNameDirectorLinkLabel.TabIndex = 5;
            this.userLoggedInNameDirectorLinkLabel.TabStop = true;
            this.userLoggedInNameDirectorLinkLabel.Text = "user to show";
            // 
            // FliesDirectorFormListBox
            // 
            this.FliesDirectorFormListBox.FormattingEnabled = true;
            this.FliesDirectorFormListBox.Location = new System.Drawing.Point(152, 19);
            this.FliesDirectorFormListBox.Name = "FliesDirectorFormListBox";
            this.FliesDirectorFormListBox.Size = new System.Drawing.Size(236, 459);
            this.FliesDirectorFormListBox.TabIndex = 0;
            // 
            // fliesDirectorFormLabel
            // 
            this.fliesDirectorFormLabel.AutoSize = true;
            this.fliesDirectorFormLabel.Location = new System.Drawing.Point(149, 3);
            this.fliesDirectorFormLabel.Name = "fliesDirectorFormLabel";
            this.fliesDirectorFormLabel.Size = new System.Drawing.Size(28, 13);
            this.fliesDirectorFormLabel.TabIndex = 1;
            this.fliesDirectorFormLabel.Text = "Flies";
            // 
            // addFliesDirectorFormLinkLabel
            // 
            this.addFliesDirectorFormLinkLabel.AutoSize = true;
            this.addFliesDirectorFormLinkLabel.Location = new System.Drawing.Point(9, 10);
            this.addFliesDirectorFormLinkLabel.Name = "addFliesDirectorFormLinkLabel";
            this.addFliesDirectorFormLinkLabel.Size = new System.Drawing.Size(50, 13);
            this.addFliesDirectorFormLinkLabel.TabIndex = 2;
            this.addFliesDirectorFormLinkLabel.TabStop = true;
            this.addFliesDirectorFormLinkLabel.Text = "Add Flies";
            // 
            // flyMaterialsDirectorFormListBox
            // 
            this.flyMaterialsDirectorFormListBox.FormattingEnabled = true;
            this.flyMaterialsDirectorFormListBox.Location = new System.Drawing.Point(475, 19);
            this.flyMaterialsDirectorFormListBox.Name = "flyMaterialsDirectorFormListBox";
            this.flyMaterialsDirectorFormListBox.Size = new System.Drawing.Size(236, 173);
            this.flyMaterialsDirectorFormListBox.TabIndex = 3;
            // 
            // flyMaterialsDirectorFormLabel
            // 
            this.flyMaterialsDirectorFormLabel.AutoSize = true;
            this.flyMaterialsDirectorFormLabel.Location = new System.Drawing.Point(472, 3);
            this.flyMaterialsDirectorFormLabel.Name = "flyMaterialsDirectorFormLabel";
            this.flyMaterialsDirectorFormLabel.Size = new System.Drawing.Size(65, 13);
            this.flyMaterialsDirectorFormLabel.TabIndex = 4;
            this.flyMaterialsDirectorFormLabel.Text = "Fly Materials";
            // 
            // modifyFlyDirectorFormButton
            // 
            this.modifyFlyDirectorFormButton.Location = new System.Drawing.Point(394, 19);
            this.modifyFlyDirectorFormButton.Name = "modifyFlyDirectorFormButton";
            this.modifyFlyDirectorFormButton.Size = new System.Drawing.Size(75, 23);
            this.modifyFlyDirectorFormButton.TabIndex = 5;
            this.modifyFlyDirectorFormButton.Text = "Modify";
            this.modifyFlyDirectorFormButton.UseVisualStyleBackColor = true;
            // 
            // addFlyMaterialDirectorFormButton
            // 
            this.addFlyMaterialDirectorFormButton.Location = new System.Drawing.Point(717, 19);
            this.addFlyMaterialDirectorFormButton.Name = "addFlyMaterialDirectorFormButton";
            this.addFlyMaterialDirectorFormButton.Size = new System.Drawing.Size(75, 23);
            this.addFlyMaterialDirectorFormButton.TabIndex = 6;
            this.addFlyMaterialDirectorFormButton.Text = "Add";
            this.addFlyMaterialDirectorFormButton.UseVisualStyleBackColor = true;
            // 
            // removeFlyMaterialDirectorFormButton
            // 
            this.removeFlyMaterialDirectorFormButton.Location = new System.Drawing.Point(717, 48);
            this.removeFlyMaterialDirectorFormButton.Name = "removeFlyMaterialDirectorFormButton";
            this.removeFlyMaterialDirectorFormButton.Size = new System.Drawing.Size(75, 23);
            this.removeFlyMaterialDirectorFormButton.TabIndex = 7;
            this.removeFlyMaterialDirectorFormButton.Text = "Remove";
            this.removeFlyMaterialDirectorFormButton.UseVisualStyleBackColor = true;
            // 
            // disableFlyDirectorFormButton
            // 
            this.disableFlyDirectorFormButton.Location = new System.Drawing.Point(394, 48);
            this.disableFlyDirectorFormButton.Name = "disableFlyDirectorFormButton";
            this.disableFlyDirectorFormButton.Size = new System.Drawing.Size(75, 23);
            this.disableFlyDirectorFormButton.TabIndex = 8;
            this.disableFlyDirectorFormButton.Text = "Disable";
            this.disableFlyDirectorFormButton.UseVisualStyleBackColor = true;
            // 
            // DirectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 575);
            this.Controls.Add(this.userLoggedInNameDirectorLinkLabel);
            this.Controls.Add(this.userLoggedInTextDirectorLabel);
            this.Controls.Add(this.exitDirectorButton);
            this.Controls.Add(this.logOutDirectorButton);
            this.Controls.Add(this.directorFormTabControl);
            this.Name = "DirectorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Neptunes Flies Company | Director";
            this.directorFormTabControl.ResumeLayout(false);
            this.workersDirectorTabPage.ResumeLayout(false);
            this.workersDirectorTabPage.PerformLayout();
            this.materialsDirectorTabPage.ResumeLayout(false);
            this.materialsDirectorTabPage.PerformLayout();
            this.fliesDirectorTabPage.ResumeLayout(false);
            this.fliesDirectorTabPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl directorFormTabControl;
        private System.Windows.Forms.TabPage workersDirectorTabPage;
        private System.Windows.Forms.TabPage materialsDirectorTabPage;
        private System.Windows.Forms.Button logOutDirectorButton;
        private System.Windows.Forms.TabPage ordersDirectorTabPage;
        private System.Windows.Forms.TabPage fliesDirectorTabPage;
        private System.Windows.Forms.Button exitDirectorButton;
        private System.Windows.Forms.LinkLabel addSystemUsersDirectorLinkLabel;
        private System.Windows.Forms.LinkLabel addWorkersDirectorLinkLabel;
        private System.Windows.Forms.ListBox workersDirectorListBox;
        private System.Windows.Forms.TabPage salariesDirectorTabPage;
        private System.Windows.Forms.Button ModifyWorkerDirectorButton;
        private System.Windows.Forms.Button fireWorkerDirectorButton;
        private System.Windows.Forms.Button refreshWorkerDirectorButton;
        private System.Windows.Forms.Label workersDirectorLabel;
        private System.Windows.Forms.Label systemUsersDirectorLabel;
        private System.Windows.Forms.ListBox systemUsersDirectorListBox;
        private System.Windows.Forms.Button modifySystemUserWorkerDirectorButton;
        private System.Windows.Forms.Button removeSystemUserWorkerDirectorButton;
        private System.Windows.Forms.ListBox materialsDirectorFormListBox;
        private System.Windows.Forms.Label materialsDirectorFormLabel;
        private System.Windows.Forms.ListBox materialsInStockDirectorFormListBox;
        private System.Windows.Forms.Button modifyMaterialsDirectorButton;
        private System.Windows.Forms.LinkLabel addMaterialsDirectorLinkLabel;
        private System.Windows.Forms.TabPage ForecastDirectorTabPage;
        private System.Windows.Forms.Label materialsInStockDirectorFormLabel;
        private System.Windows.Forms.Button detailsRequisitesDirectorButton;
        private System.Windows.Forms.Button detailsMaterialsDirectorButton;
        private System.Windows.Forms.ListBox shortageOrDepletionDirectorFormListBox;
        private System.Windows.Forms.Label shortageOrDepletionAlertDirectorFormLabel;
        private System.Windows.Forms.Label userLoggedInTextDirectorLabel;
        private System.Windows.Forms.LinkLabel userLoggedInNameDirectorLinkLabel;
        private System.Windows.Forms.Button refreshMaterialsDirectorButton;
        private System.Windows.Forms.Button detailsShortageOrDepletionAlertDirectorButton;
        private System.Windows.Forms.Button removeFlyMaterialDirectorFormButton;
        private System.Windows.Forms.Button addFlyMaterialDirectorFormButton;
        private System.Windows.Forms.Button modifyFlyDirectorFormButton;
        private System.Windows.Forms.Label flyMaterialsDirectorFormLabel;
        private System.Windows.Forms.ListBox flyMaterialsDirectorFormListBox;
        private System.Windows.Forms.LinkLabel addFliesDirectorFormLinkLabel;
        private System.Windows.Forms.Label fliesDirectorFormLabel;
        private System.Windows.Forms.ListBox FliesDirectorFormListBox;
        private System.Windows.Forms.Button disableFlyDirectorFormButton;
    }
}