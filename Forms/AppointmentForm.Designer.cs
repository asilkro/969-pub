
namespace Silkroski_C969.Forms
{
    partial class AppointmentForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppointmentForm));
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.AptTitleTB = new System.Windows.Forms.TextBox();
            this.UserIdLabel = new System.Windows.Forms.Label();
            this.AptTitleLabel = new System.Windows.Forms.Label();
            this.CustomerId_Label = new System.Windows.Forms.Label();
            this.AptDescLabel = new System.Windows.Forms.Label();
            this.AptDetailsTB = new System.Windows.Forms.TextBox();
            this.StartTime = new System.Windows.Forms.Label();
            this.EndTime = new System.Windows.Forms.Label();
            this.CustomerId_TB = new System.Windows.Forms.TextBox();
            this.startDateTimeCal = new System.Windows.Forms.DateTimePicker();
            this.startDateTimeClock = new System.Windows.Forms.DateTimePicker();
            this.endDateTimeClock = new System.Windows.Forms.DateTimePicker();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.apptDateLbl = new System.Windows.Forms.Label();
            this.tzLbl = new System.Windows.Forms.Label();
            this.AptLocTB = new System.Windows.Forms.TextBox();
            this.AptLocLbl = new System.Windows.Forms.Label();
            this.AptUrlLbl = new System.Windows.Forms.Label();
            this.AptUrlTB = new System.Windows.Forms.TextBox();
            this.AptContactLbl = new System.Windows.Forms.Label();
            this.AptContactTB = new System.Windows.Forms.TextBox();
            this.validateBtn = new System.Windows.Forms.Button();
            this.AppointmentIdTB = new System.Windows.Forms.TextBox();
            this.AppointmentIdLbl = new System.Windows.Forms.Label();
            this.userIdTB = new System.Windows.Forms.TextBox();
            this.AptTypeTB = new System.Windows.Forms.TextBox();
            this.AptTypeLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(897, 407);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 13;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Enabled = false;
            this.SaveButton.Location = new System.Drawing.Point(1012, 407);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 14;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // AptTitleTB
            // 
            this.AptTitleTB.Location = new System.Drawing.Point(172, 306);
            this.AptTitleTB.Name = "AptTitleTB";
            this.AptTitleTB.Size = new System.Drawing.Size(200, 20);
            this.AptTitleTB.TabIndex = 2;
            // 
            // UserIdLabel
            // 
            this.UserIdLabel.AutoSize = true;
            this.UserIdLabel.Location = new System.Drawing.Point(172, 395);
            this.UserIdLabel.Name = "UserIdLabel";
            this.UserIdLabel.Size = new System.Drawing.Size(160, 13);
            this.UserIdLabel.TabIndex = 20;
            this.UserIdLabel.Text = "Employee Handling Appointment";
            // 
            // AptTitleLabel
            // 
            this.AptTitleLabel.AutoSize = true;
            this.AptTitleLabel.Location = new System.Drawing.Point(169, 290);
            this.AptTitleLabel.Name = "AptTitleLabel";
            this.AptTitleLabel.Size = new System.Drawing.Size(89, 13);
            this.AptTitleLabel.TabIndex = 20;
            this.AptTitleLabel.Text = "Appointment Title";
            // 
            // CustomerId_Label
            // 
            this.CustomerId_Label.AutoSize = true;
            this.CustomerId_Label.Location = new System.Drawing.Point(169, 236);
            this.CustomerId_Label.Name = "CustomerId_Label";
            this.CustomerId_Label.Size = new System.Drawing.Size(65, 13);
            this.CustomerId_Label.TabIndex = 22;
            this.CustomerId_Label.Text = "Customer ID";
            // 
            // AptDescLabel
            // 
            this.AptDescLabel.AutoSize = true;
            this.AptDescLabel.Location = new System.Drawing.Point(169, 345);
            this.AptDescLabel.Name = "AptDescLabel";
            this.AptDescLabel.Size = new System.Drawing.Size(101, 13);
            this.AptDescLabel.TabIndex = 24;
            this.AptDescLabel.Text = "Appointment Details";
            // 
            // AptDetailsTB
            // 
            this.AptDetailsTB.Location = new System.Drawing.Point(172, 361);
            this.AptDetailsTB.Name = "AptDetailsTB";
            this.AptDetailsTB.Size = new System.Drawing.Size(200, 20);
            this.AptDetailsTB.TabIndex = 3;
            // 
            // StartTime
            // 
            this.StartTime.AutoSize = true;
            this.StartTime.Location = new System.Drawing.Point(438, 266);
            this.StartTime.Name = "StartTime";
            this.StartTime.Size = new System.Drawing.Size(91, 13);
            this.StartTime.TabIndex = 22;
            this.StartTime.Text = "Appointment Start";
            // 
            // EndTime
            // 
            this.EndTime.AutoSize = true;
            this.EndTime.Location = new System.Drawing.Point(610, 266);
            this.EndTime.Name = "EndTime";
            this.EndTime.Size = new System.Drawing.Size(88, 13);
            this.EndTime.TabIndex = 22;
            this.EndTime.Text = "Appointment End";
            // 
            // CustomerId_TB
            // 
            this.CustomerId_TB.Location = new System.Drawing.Point(172, 252);
            this.CustomerId_TB.Name = "CustomerId_TB";
            this.CustomerId_TB.Size = new System.Drawing.Size(200, 20);
            this.CustomerId_TB.TabIndex = 1;
            // 
            // startDateTimeCal
            // 
            this.startDateTimeCal.CustomFormat = "dd/MM/yyyy";
            this.startDateTimeCal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDateTimeCal.Location = new System.Drawing.Point(439, 234);
            this.startDateTimeCal.MaxDate = new System.DateTime(2999, 12, 31, 0, 0, 0, 0);
            this.startDateTimeCal.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            this.startDateTimeCal.Name = "startDateTimeCal";
            this.startDateTimeCal.Size = new System.Drawing.Size(85, 20);
            this.startDateTimeCal.TabIndex = 6;
            // 
            // startDateTimeClock
            // 
            this.startDateTimeClock.CustomFormat = "HH:mm";
            this.startDateTimeClock.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDateTimeClock.Location = new System.Drawing.Point(439, 282);
            this.startDateTimeClock.MaxDate = new System.DateTime(2999, 12, 31, 0, 0, 0, 0);
            this.startDateTimeClock.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            this.startDateTimeClock.Name = "startDateTimeClock";
            this.startDateTimeClock.ShowUpDown = true;
            this.startDateTimeClock.Size = new System.Drawing.Size(85, 20);
            this.startDateTimeClock.TabIndex = 7;
            // 
            // endDateTimeClock
            // 
            this.endDateTimeClock.CustomFormat = "HH:mm";
            this.endDateTimeClock.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDateTimeClock.Location = new System.Drawing.Point(613, 282);
            this.endDateTimeClock.MaxDate = new System.DateTime(2999, 12, 31, 0, 0, 0, 0);
            this.endDateTimeClock.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            this.endDateTimeClock.Name = "endDateTimeClock";
            this.endDateTimeClock.ShowUpDown = true;
            this.endDateTimeClock.Size = new System.Drawing.Size(85, 20);
            this.endDateTimeClock.TabIndex = 8;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "user";
            // 
            // apptDateLbl
            // 
            this.apptDateLbl.AutoSize = true;
            this.apptDateLbl.Location = new System.Drawing.Point(436, 212);
            this.apptDateLbl.Name = "apptDateLbl";
            this.apptDateLbl.Size = new System.Drawing.Size(92, 13);
            this.apptDateLbl.TabIndex = 22;
            this.apptDateLbl.Text = "Appointment Date";
            // 
            // tzLbl
            // 
            this.tzLbl.AutoSize = true;
            this.tzLbl.Location = new System.Drawing.Point(431, 177);
            this.tzLbl.Name = "tzLbl";
            this.tzLbl.Size = new System.Drawing.Size(93, 13);
            this.tzLbl.TabIndex = 22;
            this.tzLbl.Text = "Your time zone is: ";
            // 
            // AptLocTB
            // 
            this.AptLocTB.Location = new System.Drawing.Point(897, 196);
            this.AptLocTB.Name = "AptLocTB";
            this.AptLocTB.Size = new System.Drawing.Size(200, 20);
            this.AptLocTB.TabIndex = 9;
            // 
            // AptLocLbl
            // 
            this.AptLocLbl.AutoSize = true;
            this.AptLocLbl.Location = new System.Drawing.Point(897, 181);
            this.AptLocLbl.Name = "AptLocLbl";
            this.AptLocLbl.Size = new System.Drawing.Size(110, 13);
            this.AptLocLbl.TabIndex = 20;
            this.AptLocLbl.Text = "Appointment Location";
            // 
            // AptUrlLbl
            // 
            this.AptUrlLbl.AutoSize = true;
            this.AptUrlLbl.Location = new System.Drawing.Point(897, 235);
            this.AptUrlLbl.Name = "AptUrlLbl";
            this.AptUrlLbl.Size = new System.Drawing.Size(91, 13);
            this.AptUrlLbl.TabIndex = 20;
            this.AptUrlLbl.Text = "Appointment URL";
            // 
            // AptUrlTB
            // 
            this.AptUrlTB.Location = new System.Drawing.Point(897, 250);
            this.AptUrlTB.Name = "AptUrlTB";
            this.AptUrlTB.ReadOnly = true;
            this.AptUrlTB.Size = new System.Drawing.Size(200, 20);
            this.AptUrlTB.TabIndex = 10;
            this.AptUrlTB.Text = "Not Utilized";
            // 
            // AptContactLbl
            // 
            this.AptContactLbl.AutoSize = true;
            this.AptContactLbl.Location = new System.Drawing.Point(897, 289);
            this.AptContactLbl.Name = "AptContactLbl";
            this.AptContactLbl.Size = new System.Drawing.Size(106, 13);
            this.AptContactLbl.TabIndex = 20;
            this.AptContactLbl.Text = "Appointment Contact";
            // 
            // AptContactTB
            // 
            this.AptContactTB.Location = new System.Drawing.Point(897, 304);
            this.AptContactTB.Name = "AptContactTB";
            this.AptContactTB.Size = new System.Drawing.Size(200, 20);
            this.AptContactTB.TabIndex = 11;
            this.AptContactTB.Text = "Phone";
            // 
            // validateBtn
            // 
            this.validateBtn.Location = new System.Drawing.Point(897, 359);
            this.validateBtn.Name = "validateBtn";
            this.validateBtn.Size = new System.Drawing.Size(190, 23);
            this.validateBtn.TabIndex = 12;
            this.validateBtn.Text = "Validate";
            this.validateBtn.UseVisualStyleBackColor = true;
            this.validateBtn.Click += new System.EventHandler(this.ValidateBtn_Click);
            // 
            // AppointmentIdTB
            // 
            this.AppointmentIdTB.Location = new System.Drawing.Point(172, 198);
            this.AppointmentIdTB.Name = "AppointmentIdTB";
            this.AppointmentIdTB.ReadOnly = true;
            this.AppointmentIdTB.Size = new System.Drawing.Size(132, 20);
            this.AppointmentIdTB.TabIndex = 25;
            // 
            // AppointmentIdLbl
            // 
            this.AppointmentIdLbl.AutoSize = true;
            this.AppointmentIdLbl.Location = new System.Drawing.Point(172, 181);
            this.AppointmentIdLbl.Name = "AppointmentIdLbl";
            this.AppointmentIdLbl.Size = new System.Drawing.Size(80, 13);
            this.AppointmentIdLbl.TabIndex = 22;
            this.AppointmentIdLbl.Text = "Appointment ID";
            // 
            // userIdTB
            // 
            this.userIdTB.Location = new System.Drawing.Point(172, 411);
            this.userIdTB.Name = "userIdTB";
            this.userIdTB.Size = new System.Drawing.Size(200, 20);
            this.userIdTB.TabIndex = 4;
            // 
            // AptTypeTB
            // 
            this.AptTypeTB.Location = new System.Drawing.Point(172, 458);
            this.AptTypeTB.Name = "AptTypeTB";
            this.AptTypeTB.Size = new System.Drawing.Size(200, 20);
            this.AptTypeTB.TabIndex = 5;
            // 
            // AptTypeLbl
            // 
            this.AptTypeLbl.AutoSize = true;
            this.AptTypeLbl.Location = new System.Drawing.Point(169, 442);
            this.AptTypeLbl.Name = "AptTypeLbl";
            this.AptTypeLbl.Size = new System.Drawing.Size(93, 13);
            this.AptTypeLbl.TabIndex = 20;
            this.AptTypeLbl.Text = "Appointment Type";
            // 
            // AppointmentForm
            // 
            this.AcceptButton = this.validateBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelBtn;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.AppointmentIdTB);
            this.Controls.Add(this.endDateTimeClock);
            this.Controls.Add(this.startDateTimeClock);
            this.Controls.Add(this.startDateTimeCal);
            this.Controls.Add(this.AptDescLabel);
            this.Controls.Add(this.AptContactTB);
            this.Controls.Add(this.AptUrlTB);
            this.Controls.Add(this.AptLocTB);
            this.Controls.Add(this.userIdTB);
            this.Controls.Add(this.AptDetailsTB);
            this.Controls.Add(this.tzLbl);
            this.Controls.Add(this.EndTime);
            this.Controls.Add(this.apptDateLbl);
            this.Controls.Add(this.StartTime);
            this.Controls.Add(this.AptContactLbl);
            this.Controls.Add(this.AppointmentIdLbl);
            this.Controls.Add(this.CustomerId_Label);
            this.Controls.Add(this.AptUrlLbl);
            this.Controls.Add(this.AptTypeLbl);
            this.Controls.Add(this.AptTitleLabel);
            this.Controls.Add(this.AptLocLbl);
            this.Controls.Add(this.UserIdLabel);
            this.Controls.Add(this.CustomerId_TB);
            this.Controls.Add(this.AptTypeTB);
            this.Controls.Add(this.AptTitleTB);
            this.Controls.Add(this.validateBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.SaveButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AppointmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Appointment Form";
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button SaveButton;
        public System.Windows.Forms.TextBox AptTitleTB;
        private System.Windows.Forms.Label UserIdLabel;
        private System.Windows.Forms.Label AptTitleLabel;
        private System.Windows.Forms.Label CustomerId_Label;
        private System.Windows.Forms.Label AptDescLabel;
        public System.Windows.Forms.TextBox AptDetailsTB;
        private System.Windows.Forms.Label StartTime;
        private System.Windows.Forms.Label EndTime;
        public System.Windows.Forms.TextBox CustomerId_TB;
        public System.Windows.Forms.DateTimePicker startDateTimeCal;
        public System.Windows.Forms.DateTimePicker startDateTimeClock;
        public System.Windows.Forms.DateTimePicker endDateTimeClock;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.Label apptDateLbl;
        private System.Windows.Forms.Label tzLbl;
        public System.Windows.Forms.TextBox AptLocTB;
        private System.Windows.Forms.Label AptLocLbl;
        private System.Windows.Forms.Label AptUrlLbl;
        public System.Windows.Forms.TextBox AptUrlTB;
        private System.Windows.Forms.Label AptContactLbl;
        public System.Windows.Forms.TextBox AptContactTB;
        private System.Windows.Forms.Button validateBtn;
        public System.Windows.Forms.TextBox AppointmentIdTB;
        private System.Windows.Forms.Label AppointmentIdLbl;
        public System.Windows.Forms.TextBox userIdTB;
        public System.Windows.Forms.TextBox AptTypeTB;
        private System.Windows.Forms.Label AptTypeLbl;
    }
}