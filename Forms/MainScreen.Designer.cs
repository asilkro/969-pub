
namespace Silkroski_C969
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.appointments_DGV = new System.Windows.Forms.DataGridView();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.QuitButton = new System.Windows.Forms.Button();
            this.CreateApptBtn = new System.Windows.Forms.Button();
            this.EditApptBtn = new System.Windows.Forms.Button();
            this.DeleteApptBtn = new System.Windows.Forms.Button();
            this.CreateCxBtn = new System.Windows.Forms.Button();
            this.EditCxBtn = new System.Windows.Forms.Button();
            this.RemoveCxBtn = new System.Windows.Forms.Button();
            this.FullViewBtn = new System.Windows.Forms.Button();
            this.WeekViewBtn = new System.Windows.Forms.Button();
            this.MonthViewBtn = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.customer_DGV = new System.Windows.Forms.DataGridView();
            this.createCityBtn = new System.Windows.Forms.Button();
            this.createCountryBtn = new System.Windows.Forms.Button();
            this.createAddyBtn = new System.Windows.Forms.Button();
            this.ccaDGV = new System.Windows.Forms.DataGridView();
            this.viewCityBtn = new System.Windows.Forms.Button();
            this.viewCountryBtn = new System.Windows.Forms.Button();
            this.viewAddyBtn = new System.Windows.Forms.Button();
            this.viewingLbl = new System.Windows.Forms.Label();
            this.editCityBtn = new System.Windows.Forms.Button();
            this.editCountryBtn = new System.Windows.Forms.Button();
            this.editAddyBtn = new System.Windows.Forms.Button();
            this.removeCityBtn = new System.Windows.Forms.Button();
            this.removeCountryBtn = new System.Windows.Forms.Button();
            this.removeAddyBtn = new System.Windows.Forms.Button();
            this.apptTypesBtn = new System.Windows.Forms.Button();
            this.scheduleByUserBtn = new System.Windows.Forms.Button();
            this.scheduleByCxBtn = new System.Windows.Forms.Button();
            this.cxIdTb = new System.Windows.Forms.TextBox();
            this.cxIdLbl = new System.Windows.Forms.Label();
            this.userIdTb = new System.Windows.Forms.TextBox();
            this.userIdLbl = new System.Windows.Forms.Label();
            this.alertCheckerBtn = new System.Windows.Forms.Button();
            this.alertUserIdTb = new System.Windows.Forms.TextBox();
            this.alertUserIdLbl = new System.Windows.Forms.Label();
            this.LoadDatabtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.appointments_DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customer_DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccaDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // appointments_DGV
            // 
            this.appointments_DGV.AllowUserToAddRows = false;
            this.appointments_DGV.AllowUserToDeleteRows = false;
            this.appointments_DGV.AllowUserToOrderColumns = true;
            this.appointments_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointments_DGV.Location = new System.Drawing.Point(12, 11);
            this.appointments_DGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.appointments_DGV.MultiSelect = false;
            this.appointments_DGV.Name = "appointments_DGV";
            this.appointments_DGV.ReadOnly = true;
            this.appointments_DGV.RowTemplate.Height = 27;
            this.appointments_DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.appointments_DGV.Size = new System.Drawing.Size(411, 307);
            this.appointments_DGV.TabIndex = 1;
            this.appointments_DGV.SelectionChanged += new System.EventHandler(this.EnableOnSelected);
            // 
            // LogOutButton
            // 
            this.LogOutButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.LogOutButton.Location = new System.Drawing.Point(1060, 624);
            this.LogOutButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(88, 46);
            this.LogOutButton.TabIndex = 2;
            this.LogOutButton.Text = "Log Out";
            this.LogOutButton.UseVisualStyleBackColor = true;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // QuitButton
            // 
            this.QuitButton.Location = new System.Drawing.Point(1154, 624);
            this.QuitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(88, 46);
            this.QuitButton.TabIndex = 2;
            this.QuitButton.Text = "Quit";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // CreateApptBtn
            // 
            this.CreateApptBtn.Location = new System.Drawing.Point(75, 322);
            this.CreateApptBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CreateApptBtn.Name = "CreateApptBtn";
            this.CreateApptBtn.Size = new System.Drawing.Size(83, 46);
            this.CreateApptBtn.TabIndex = 2;
            this.CreateApptBtn.Text = "Create Appointment";
            this.CreateApptBtn.UseVisualStyleBackColor = true;
            this.CreateApptBtn.Click += new System.EventHandler(this.CreateApptBtn_Click);
            // 
            // EditApptBtn
            // 
            this.EditApptBtn.Enabled = false;
            this.EditApptBtn.Location = new System.Drawing.Point(164, 322);
            this.EditApptBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EditApptBtn.Name = "EditApptBtn";
            this.EditApptBtn.Size = new System.Drawing.Size(83, 46);
            this.EditApptBtn.TabIndex = 2;
            this.EditApptBtn.Text = "Edit Appointment";
            this.EditApptBtn.UseVisualStyleBackColor = true;
            this.EditApptBtn.Click += new System.EventHandler(this.EditApptBtn_Click);
            // 
            // DeleteApptBtn
            // 
            this.DeleteApptBtn.Enabled = false;
            this.DeleteApptBtn.Location = new System.Drawing.Point(253, 322);
            this.DeleteApptBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteApptBtn.Name = "DeleteApptBtn";
            this.DeleteApptBtn.Size = new System.Drawing.Size(83, 46);
            this.DeleteApptBtn.TabIndex = 2;
            this.DeleteApptBtn.Text = "Remove Appointment";
            this.DeleteApptBtn.UseVisualStyleBackColor = true;
            this.DeleteApptBtn.Click += new System.EventHandler(this.DeleteApptBtn_Click);
            // 
            // CreateCxBtn
            // 
            this.CreateCxBtn.Location = new System.Drawing.Point(912, 322);
            this.CreateCxBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CreateCxBtn.Name = "CreateCxBtn";
            this.CreateCxBtn.Size = new System.Drawing.Size(83, 46);
            this.CreateCxBtn.TabIndex = 2;
            this.CreateCxBtn.Text = "Create Customer";
            this.CreateCxBtn.UseVisualStyleBackColor = true;
            this.CreateCxBtn.Click += new System.EventHandler(this.CreateCxBtn_Click);
            // 
            // EditCxBtn
            // 
            this.EditCxBtn.Enabled = false;
            this.EditCxBtn.Location = new System.Drawing.Point(1001, 322);
            this.EditCxBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EditCxBtn.Name = "EditCxBtn";
            this.EditCxBtn.Size = new System.Drawing.Size(83, 46);
            this.EditCxBtn.TabIndex = 2;
            this.EditCxBtn.Text = "Edit Customer";
            this.EditCxBtn.UseVisualStyleBackColor = true;
            this.EditCxBtn.Click += new System.EventHandler(this.UpdateCxBtn_Click);
            // 
            // RemoveCxBtn
            // 
            this.RemoveCxBtn.Enabled = false;
            this.RemoveCxBtn.Location = new System.Drawing.Point(1090, 322);
            this.RemoveCxBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RemoveCxBtn.Name = "RemoveCxBtn";
            this.RemoveCxBtn.Size = new System.Drawing.Size(83, 46);
            this.RemoveCxBtn.TabIndex = 2;
            this.RemoveCxBtn.Text = "Remove Customer";
            this.RemoveCxBtn.UseVisualStyleBackColor = true;
            this.RemoveCxBtn.Click += new System.EventHandler(this.RemoveCxBtn_Click);
            // 
            // FullViewBtn
            // 
            this.FullViewBtn.Location = new System.Drawing.Point(253, 372);
            this.FullViewBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FullViewBtn.Name = "FullViewBtn";
            this.FullViewBtn.Size = new System.Drawing.Size(83, 56);
            this.FullViewBtn.TabIndex = 2;
            this.FullViewBtn.Text = "View All Appointments";
            this.FullViewBtn.UseVisualStyleBackColor = true;
            this.FullViewBtn.Click += new System.EventHandler(this.FullViewBtn_Click);
            // 
            // WeekViewBtn
            // 
            this.WeekViewBtn.Location = new System.Drawing.Point(75, 372);
            this.WeekViewBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WeekViewBtn.Name = "WeekViewBtn";
            this.WeekViewBtn.Size = new System.Drawing.Size(83, 56);
            this.WeekViewBtn.TabIndex = 2;
            this.WeekViewBtn.Text = "View Current Week\'s Appointments";
            this.WeekViewBtn.UseVisualStyleBackColor = true;
            this.WeekViewBtn.Click += new System.EventHandler(this.WeekViewBtn_Click);
            // 
            // MonthViewBtn
            // 
            this.MonthViewBtn.Location = new System.Drawing.Point(164, 372);
            this.MonthViewBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MonthViewBtn.Name = "MonthViewBtn";
            this.MonthViewBtn.Size = new System.Drawing.Size(83, 56);
            this.MonthViewBtn.TabIndex = 2;
            this.MonthViewBtn.Text = "View Current Month\'s Appointments";
            this.MonthViewBtn.UseVisualStyleBackColor = true;
            this.MonthViewBtn.Click += new System.EventHandler(this.MonthViewBtn_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(966, 624);
            this.RefreshButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(88, 46);
            this.RefreshButton.TabIndex = 2;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // customer_DGV
            // 
            this.customer_DGV.AllowUserToAddRows = false;
            this.customer_DGV.AllowUserToDeleteRows = false;
            this.customer_DGV.AllowUserToOrderColumns = true;
            this.customer_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customer_DGV.Location = new System.Drawing.Point(841, 11);
            this.customer_DGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customer_DGV.MultiSelect = false;
            this.customer_DGV.Name = "customer_DGV";
            this.customer_DGV.ReadOnly = true;
            this.customer_DGV.RowTemplate.Height = 27;
            this.customer_DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customer_DGV.Size = new System.Drawing.Size(411, 307);
            this.customer_DGV.TabIndex = 1;
            this.customer_DGV.SelectionChanged += new System.EventHandler(this.EnableOnSelected);
            // 
            // createCityBtn
            // 
            this.createCityBtn.Enabled = false;
            this.createCityBtn.Location = new System.Drawing.Point(431, 421);
            this.createCityBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createCityBtn.Name = "createCityBtn";
            this.createCityBtn.Size = new System.Drawing.Size(88, 46);
            this.createCityBtn.TabIndex = 2;
            this.createCityBtn.Text = "Create City";
            this.createCityBtn.UseVisualStyleBackColor = true;
            this.createCityBtn.Click += new System.EventHandler(this.createCityBtn_Click);
            // 
            // createCountryBtn
            // 
            this.createCountryBtn.Enabled = false;
            this.createCountryBtn.Location = new System.Drawing.Point(581, 421);
            this.createCountryBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createCountryBtn.Name = "createCountryBtn";
            this.createCountryBtn.Size = new System.Drawing.Size(88, 46);
            this.createCountryBtn.TabIndex = 2;
            this.createCountryBtn.Text = "Create Country";
            this.createCountryBtn.UseVisualStyleBackColor = true;
            this.createCountryBtn.Click += new System.EventHandler(this.createCountryBtn_Click);
            // 
            // createAddyBtn
            // 
            this.createAddyBtn.Enabled = false;
            this.createAddyBtn.Location = new System.Drawing.Point(750, 421);
            this.createAddyBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createAddyBtn.Name = "createAddyBtn";
            this.createAddyBtn.Size = new System.Drawing.Size(88, 46);
            this.createAddyBtn.TabIndex = 2;
            this.createAddyBtn.Text = "Create Address";
            this.createAddyBtn.UseVisualStyleBackColor = true;
            this.createAddyBtn.Click += new System.EventHandler(this.createAddyBtn_Click);
            // 
            // ccaDGV
            // 
            this.ccaDGV.AllowUserToAddRows = false;
            this.ccaDGV.AllowUserToDeleteRows = false;
            this.ccaDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ccaDGV.Location = new System.Drawing.Point(427, 11);
            this.ccaDGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ccaDGV.MultiSelect = false;
            this.ccaDGV.Name = "ccaDGV";
            this.ccaDGV.ReadOnly = true;
            this.ccaDGV.RowTemplate.Height = 27;
            this.ccaDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ccaDGV.Size = new System.Drawing.Size(411, 307);
            this.ccaDGV.TabIndex = 1;
            this.ccaDGV.SelectionChanged += new System.EventHandler(this.EnableOnSelected);
            // 
            // viewCityBtn
            // 
            this.viewCityBtn.Location = new System.Drawing.Point(427, 322);
            this.viewCityBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.viewCityBtn.Name = "viewCityBtn";
            this.viewCityBtn.Size = new System.Drawing.Size(88, 46);
            this.viewCityBtn.TabIndex = 2;
            this.viewCityBtn.Text = "View Cities";
            this.viewCityBtn.UseVisualStyleBackColor = true;
            this.viewCityBtn.Click += new System.EventHandler(this.viewCityBtn_Click);
            // 
            // viewCountryBtn
            // 
            this.viewCountryBtn.Location = new System.Drawing.Point(581, 322);
            this.viewCountryBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.viewCountryBtn.Name = "viewCountryBtn";
            this.viewCountryBtn.Size = new System.Drawing.Size(88, 46);
            this.viewCountryBtn.TabIndex = 2;
            this.viewCountryBtn.Text = "View Countries";
            this.viewCountryBtn.UseVisualStyleBackColor = true;
            this.viewCountryBtn.Click += new System.EventHandler(this.viewCountryBtn_Click);
            // 
            // viewAddyBtn
            // 
            this.viewAddyBtn.Location = new System.Drawing.Point(750, 322);
            this.viewAddyBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.viewAddyBtn.Name = "viewAddyBtn";
            this.viewAddyBtn.Size = new System.Drawing.Size(88, 46);
            this.viewAddyBtn.TabIndex = 2;
            this.viewAddyBtn.Text = "View Addresses";
            this.viewAddyBtn.UseVisualStyleBackColor = true;
            this.viewAddyBtn.Click += new System.EventHandler(this.viewAddyBtn_Click);
            // 
            // viewingLbl
            // 
            this.viewingLbl.AutoSize = true;
            this.viewingLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewingLbl.Location = new System.Drawing.Point(427, 384);
            this.viewingLbl.Name = "viewingLbl";
            this.viewingLbl.Size = new System.Drawing.Size(88, 24);
            this.viewingLbl.TabIndex = 10;
            this.viewingLbl.Text = "Viewing: ";
            // 
            // editCityBtn
            // 
            this.editCityBtn.Enabled = false;
            this.editCityBtn.Location = new System.Drawing.Point(431, 471);
            this.editCityBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editCityBtn.Name = "editCityBtn";
            this.editCityBtn.Size = new System.Drawing.Size(88, 46);
            this.editCityBtn.TabIndex = 2;
            this.editCityBtn.Text = "Edit City";
            this.editCityBtn.UseVisualStyleBackColor = true;
            this.editCityBtn.Click += new System.EventHandler(this.editCityBtn_Click);
            // 
            // editCountryBtn
            // 
            this.editCountryBtn.Enabled = false;
            this.editCountryBtn.Location = new System.Drawing.Point(581, 471);
            this.editCountryBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editCountryBtn.Name = "editCountryBtn";
            this.editCountryBtn.Size = new System.Drawing.Size(88, 46);
            this.editCountryBtn.TabIndex = 2;
            this.editCountryBtn.Text = "Edit Country";
            this.editCountryBtn.UseVisualStyleBackColor = true;
            this.editCountryBtn.Click += new System.EventHandler(this.editCountryBtn_Click);
            // 
            // editAddyBtn
            // 
            this.editAddyBtn.Enabled = false;
            this.editAddyBtn.Location = new System.Drawing.Point(750, 471);
            this.editAddyBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editAddyBtn.Name = "editAddyBtn";
            this.editAddyBtn.Size = new System.Drawing.Size(88, 46);
            this.editAddyBtn.TabIndex = 2;
            this.editAddyBtn.Text = "Edit Address";
            this.editAddyBtn.UseVisualStyleBackColor = true;
            this.editAddyBtn.Click += new System.EventHandler(this.editAddyBtn_Click);
            // 
            // removeCityBtn
            // 
            this.removeCityBtn.Enabled = false;
            this.removeCityBtn.Location = new System.Drawing.Point(431, 521);
            this.removeCityBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.removeCityBtn.Name = "removeCityBtn";
            this.removeCityBtn.Size = new System.Drawing.Size(88, 46);
            this.removeCityBtn.TabIndex = 2;
            this.removeCityBtn.Text = "Remove City";
            this.removeCityBtn.UseVisualStyleBackColor = true;
            this.removeCityBtn.Click += new System.EventHandler(this.removeCityBtn_Click);
            // 
            // removeCountryBtn
            // 
            this.removeCountryBtn.Enabled = false;
            this.removeCountryBtn.Location = new System.Drawing.Point(581, 521);
            this.removeCountryBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.removeCountryBtn.Name = "removeCountryBtn";
            this.removeCountryBtn.Size = new System.Drawing.Size(88, 46);
            this.removeCountryBtn.TabIndex = 2;
            this.removeCountryBtn.Text = "Remove Country";
            this.removeCountryBtn.UseVisualStyleBackColor = true;
            this.removeCountryBtn.Click += new System.EventHandler(this.removeCountryBtn_Click);
            // 
            // removeAddyBtn
            // 
            this.removeAddyBtn.Enabled = false;
            this.removeAddyBtn.Location = new System.Drawing.Point(750, 521);
            this.removeAddyBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.removeAddyBtn.Name = "removeAddyBtn";
            this.removeAddyBtn.Size = new System.Drawing.Size(88, 46);
            this.removeAddyBtn.TabIndex = 2;
            this.removeAddyBtn.Text = "Remove Address";
            this.removeAddyBtn.UseVisualStyleBackColor = true;
            this.removeAddyBtn.Click += new System.EventHandler(this.removeAddyBtn_Click);
            // 
            // apptTypesBtn
            // 
            this.apptTypesBtn.Location = new System.Drawing.Point(75, 540);
            this.apptTypesBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.apptTypesBtn.Name = "apptTypesBtn";
            this.apptTypesBtn.Size = new System.Drawing.Size(83, 56);
            this.apptTypesBtn.TabIndex = 2;
            this.apptTypesBtn.Text = "Count Appointments by Month";
            this.apptTypesBtn.UseVisualStyleBackColor = true;
            this.apptTypesBtn.Click += new System.EventHandler(this.apptTypesBtn_Click);
            // 
            // scheduleByUserBtn
            // 
            this.scheduleByUserBtn.Location = new System.Drawing.Point(75, 461);
            this.scheduleByUserBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.scheduleByUserBtn.Name = "scheduleByUserBtn";
            this.scheduleByUserBtn.Size = new System.Drawing.Size(83, 56);
            this.scheduleByUserBtn.TabIndex = 2;
            this.scheduleByUserBtn.Text = "View Schedule by Consultant";
            this.scheduleByUserBtn.UseVisualStyleBackColor = true;
            this.scheduleByUserBtn.Click += new System.EventHandler(this.scheduleByUserBtn_Click);
            // 
            // scheduleByCxBtn
            // 
            this.scheduleByCxBtn.Location = new System.Drawing.Point(912, 451);
            this.scheduleByCxBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.scheduleByCxBtn.Name = "scheduleByCxBtn";
            this.scheduleByCxBtn.Size = new System.Drawing.Size(83, 56);
            this.scheduleByCxBtn.TabIndex = 2;
            this.scheduleByCxBtn.Text = "View Schedule by Customer";
            this.scheduleByCxBtn.UseVisualStyleBackColor = true;
            this.scheduleByCxBtn.Click += new System.EventHandler(this.scheduleByCxBtn_Click);
            // 
            // cxIdTb
            // 
            this.cxIdTb.Location = new System.Drawing.Point(1022, 480);
            this.cxIdTb.Name = "cxIdTb";
            this.cxIdTb.Size = new System.Drawing.Size(100, 20);
            this.cxIdTb.TabIndex = 11;
            // 
            // cxIdLbl
            // 
            this.cxIdLbl.AutoSize = true;
            this.cxIdLbl.Location = new System.Drawing.Point(1019, 464);
            this.cxIdLbl.Name = "cxIdLbl";
            this.cxIdLbl.Size = new System.Drawing.Size(107, 13);
            this.cxIdLbl.TabIndex = 12;
            this.cxIdLbl.Text = "Enter Customer Id (#)";
            // 
            // userIdTb
            // 
            this.userIdTb.Location = new System.Drawing.Point(185, 480);
            this.userIdTb.Name = "userIdTb";
            this.userIdTb.Size = new System.Drawing.Size(100, 20);
            this.userIdTb.TabIndex = 11;
            // 
            // userIdLbl
            // 
            this.userIdLbl.AutoSize = true;
            this.userIdLbl.Location = new System.Drawing.Point(182, 464);
            this.userIdLbl.Name = "userIdLbl";
            this.userIdLbl.Size = new System.Drawing.Size(85, 13);
            this.userIdLbl.TabIndex = 12;
            this.userIdLbl.Text = "Enter User Id (#)";
            // 
            // alertCheckerBtn
            // 
            this.alertCheckerBtn.Location = new System.Drawing.Point(912, 530);
            this.alertCheckerBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.alertCheckerBtn.Name = "alertCheckerBtn";
            this.alertCheckerBtn.Size = new System.Drawing.Size(83, 56);
            this.alertCheckerBtn.TabIndex = 2;
            this.alertCheckerBtn.Text = "Upcoming Appointments for User";
            this.alertCheckerBtn.UseVisualStyleBackColor = true;
            this.alertCheckerBtn.Click += new System.EventHandler(this.alertCheckerBtn_Click);
            // 
            // alertUserIdTb
            // 
            this.alertUserIdTb.Location = new System.Drawing.Point(1022, 559);
            this.alertUserIdTb.Name = "alertUserIdTb";
            this.alertUserIdTb.Size = new System.Drawing.Size(100, 20);
            this.alertUserIdTb.TabIndex = 11;
            // 
            // alertUserIdLbl
            // 
            this.alertUserIdLbl.AutoSize = true;
            this.alertUserIdLbl.Location = new System.Drawing.Point(1019, 543);
            this.alertUserIdLbl.Name = "alertUserIdLbl";
            this.alertUserIdLbl.Size = new System.Drawing.Size(85, 13);
            this.alertUserIdLbl.TabIndex = 12;
            this.alertUserIdLbl.Text = "Enter User Id (#)";
            // 
            // LoadDatabtn
            // 
            this.LoadDatabtn.Location = new System.Drawing.Point(12, 624);
            this.LoadDatabtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoadDatabtn.Name = "LoadDatabtn";
            this.LoadDatabtn.Size = new System.Drawing.Size(932, 46);
            this.LoadDatabtn.TabIndex = 2;
            this.LoadDatabtn.Text = "Load Data";
            this.LoadDatabtn.UseVisualStyleBackColor = true;
            this.LoadDatabtn.Click += new System.EventHandler(this.LoadDatabtn_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.LogOutButton;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.userIdLbl);
            this.Controls.Add(this.alertUserIdLbl);
            this.Controls.Add(this.cxIdLbl);
            this.Controls.Add(this.userIdTb);
            this.Controls.Add(this.alertUserIdTb);
            this.Controls.Add(this.cxIdTb);
            this.Controls.Add(this.viewingLbl);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.RemoveCxBtn);
            this.Controls.Add(this.DeleteApptBtn);
            this.Controls.Add(this.EditCxBtn);
            this.Controls.Add(this.viewAddyBtn);
            this.Controls.Add(this.viewCountryBtn);
            this.Controls.Add(this.removeAddyBtn);
            this.Controls.Add(this.editAddyBtn);
            this.Controls.Add(this.createAddyBtn);
            this.Controls.Add(this.viewCityBtn);
            this.Controls.Add(this.removeCountryBtn);
            this.Controls.Add(this.editCountryBtn);
            this.Controls.Add(this.createCountryBtn);
            this.Controls.Add(this.removeCityBtn);
            this.Controls.Add(this.editCityBtn);
            this.Controls.Add(this.createCityBtn);
            this.Controls.Add(this.LoadDatabtn);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.MonthViewBtn);
            this.Controls.Add(this.WeekViewBtn);
            this.Controls.Add(this.EditApptBtn);
            this.Controls.Add(this.CreateCxBtn);
            this.Controls.Add(this.alertCheckerBtn);
            this.Controls.Add(this.apptTypesBtn);
            this.Controls.Add(this.scheduleByCxBtn);
            this.Controls.Add(this.scheduleByUserBtn);
            this.Controls.Add(this.FullViewBtn);
            this.Controls.Add(this.CreateApptBtn);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.customer_DGV);
            this.Controls.Add(this.ccaDGV);
            this.Controls.Add(this.appointments_DGV);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Database Utility Tool - Logged In";
            ((System.ComponentModel.ISupportInitialize)(this.appointments_DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customer_DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccaDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView appointments_DGV;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.Button CreateApptBtn;
        private System.Windows.Forms.Button EditApptBtn;
        private System.Windows.Forms.Button DeleteApptBtn;
        private System.Windows.Forms.Button CreateCxBtn;
        private System.Windows.Forms.Button EditCxBtn;
        private System.Windows.Forms.Button RemoveCxBtn;
        private System.Windows.Forms.Button FullViewBtn;
        private System.Windows.Forms.Button WeekViewBtn;
        private System.Windows.Forms.Button MonthViewBtn;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.DataGridView customer_DGV;
        private System.Windows.Forms.Button createCityBtn;
        private System.Windows.Forms.Button createCountryBtn;
        private System.Windows.Forms.Button createAddyBtn;
        private System.Windows.Forms.DataGridView ccaDGV;
        private System.Windows.Forms.Button viewCityBtn;
        private System.Windows.Forms.Button viewCountryBtn;
        private System.Windows.Forms.Button viewAddyBtn;
        private System.Windows.Forms.Label viewingLbl;
        private System.Windows.Forms.Button editCityBtn;
        private System.Windows.Forms.Button editCountryBtn;
        private System.Windows.Forms.Button editAddyBtn;
        private System.Windows.Forms.Button removeCityBtn;
        private System.Windows.Forms.Button removeCountryBtn;
        private System.Windows.Forms.Button removeAddyBtn;
        private System.Windows.Forms.Button apptTypesBtn;
        private System.Windows.Forms.Button scheduleByUserBtn;
        private System.Windows.Forms.Button scheduleByCxBtn;
        private System.Windows.Forms.TextBox cxIdTb;
        private System.Windows.Forms.Label cxIdLbl;
        private System.Windows.Forms.TextBox userIdTb;
        private System.Windows.Forms.Label userIdLbl;
        private System.Windows.Forms.Button alertCheckerBtn;
        private System.Windows.Forms.TextBox alertUserIdTb;
        private System.Windows.Forms.Label alertUserIdLbl;
        private System.Windows.Forms.Button LoadDatabtn;
    }
}

