
namespace Silkroski_C969.Forms
{
    partial class Alert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alert));
            this.closeButton = new System.Windows.Forms.Button();
            this.endDTP = new System.Windows.Forms.DateTimePicker();
            this.startDTP = new System.Windows.Forms.DateTimePicker();
            this.typeTB = new System.Windows.Forms.TextBox();
            this.contactTB = new System.Windows.Forms.TextBox();
            this.locTB = new System.Windows.Forms.TextBox();
            this.descTB = new System.Windows.Forms.TextBox();
            this.titleTB = new System.Windows.Forms.TextBox();
            this.endLabel = new System.Windows.Forms.Label();
            this.startLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.contactLabel = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.alertLabel = new System.Windows.Forms.Label();
            this.cxTB = new System.Windows.Forms.TextBox();
            this.cxLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeButton.Location = new System.Drawing.Point(82, 350);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(128, 30);
            this.closeButton.TabIndex = 20;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // endDTP
            // 
            this.endDTP.CustomFormat = "MM/dd/yyyy HH:mm";
            this.endDTP.Enabled = false;
            this.endDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDTP.Location = new System.Drawing.Point(82, 311);
            this.endDTP.MaxDate = new System.DateTime(2999, 12, 31, 0, 0, 0, 0);
            this.endDTP.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.endDTP.Name = "endDTP";
            this.endDTP.Size = new System.Drawing.Size(128, 20);
            this.endDTP.TabIndex = 38;
            // 
            // startDTP
            // 
            this.startDTP.CustomFormat = "MM/dd/yyyy HH:mm";
            this.startDTP.Enabled = false;
            this.startDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDTP.Location = new System.Drawing.Point(82, 280);
            this.startDTP.MaxDate = new System.DateTime(2999, 12, 31, 0, 0, 0, 0);
            this.startDTP.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.startDTP.Name = "startDTP";
            this.startDTP.Size = new System.Drawing.Size(128, 20);
            this.startDTP.TabIndex = 37;
            // 
            // typeTB
            // 
            this.typeTB.Enabled = false;
            this.typeTB.Location = new System.Drawing.Point(83, 251);
            this.typeTB.Name = "typeTB";
            this.typeTB.ReadOnly = true;
            this.typeTB.Size = new System.Drawing.Size(128, 20);
            this.typeTB.TabIndex = 35;
            // 
            // contactTB
            // 
            this.contactTB.Enabled = false;
            this.contactTB.Location = new System.Drawing.Point(83, 221);
            this.contactTB.Name = "contactTB";
            this.contactTB.ReadOnly = true;
            this.contactTB.Size = new System.Drawing.Size(128, 20);
            this.contactTB.TabIndex = 34;
            // 
            // locTB
            // 
            this.locTB.Enabled = false;
            this.locTB.Location = new System.Drawing.Point(83, 191);
            this.locTB.Name = "locTB";
            this.locTB.ReadOnly = true;
            this.locTB.Size = new System.Drawing.Size(128, 20);
            this.locTB.TabIndex = 33;
            // 
            // descTB
            // 
            this.descTB.Enabled = false;
            this.descTB.Location = new System.Drawing.Point(83, 111);
            this.descTB.Multiline = true;
            this.descTB.Name = "descTB";
            this.descTB.ReadOnly = true;
            this.descTB.Size = new System.Drawing.Size(128, 70);
            this.descTB.TabIndex = 32;
            // 
            // titleTB
            // 
            this.titleTB.Enabled = false;
            this.titleTB.Location = new System.Drawing.Point(83, 81);
            this.titleTB.Name = "titleTB";
            this.titleTB.ReadOnly = true;
            this.titleTB.Size = new System.Drawing.Size(128, 20);
            this.titleTB.TabIndex = 31;
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.Location = new System.Drawing.Point(49, 317);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(26, 13);
            this.endLabel.TabIndex = 30;
            this.endLabel.Text = "End";
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Location = new System.Drawing.Point(46, 286);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(29, 13);
            this.startLabel.TabIndex = 29;
            this.startLabel.Text = "Start";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(45, 254);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(31, 13);
            this.typeLabel.TabIndex = 27;
            this.typeLabel.Text = "Type";
            // 
            // contactLabel
            // 
            this.contactLabel.AutoSize = true;
            this.contactLabel.Location = new System.Drawing.Point(32, 224);
            this.contactLabel.Name = "contactLabel";
            this.contactLabel.Size = new System.Drawing.Size(44, 13);
            this.contactLabel.TabIndex = 26;
            this.contactLabel.Text = "Contact";
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(28, 194);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(48, 13);
            this.locationLabel.TabIndex = 25;
            this.locationLabel.Text = "Location";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(16, 114);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.descriptionLabel.TabIndex = 24;
            this.descriptionLabel.Text = "Description";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(49, 84);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(27, 13);
            this.titleLabel.TabIndex = 23;
            this.titleLabel.Text = "Title";
            // 
            // alertLabel
            // 
            this.alertLabel.AutoSize = true;
            this.alertLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alertLabel.Location = new System.Drawing.Point(28, 24);
            this.alertLabel.Name = "alertLabel";
            this.alertLabel.Size = new System.Drawing.Size(193, 16);
            this.alertLabel.TabIndex = 39;
            this.alertLabel.Text = "Upcoming Appointment Details";
            // 
            // cxTB
            // 
            this.cxTB.Enabled = false;
            this.cxTB.Location = new System.Drawing.Point(82, 55);
            this.cxTB.Name = "cxTB";
            this.cxTB.ReadOnly = true;
            this.cxTB.Size = new System.Drawing.Size(128, 20);
            this.cxTB.TabIndex = 41;
            // 
            // cxLabel
            // 
            this.cxLabel.AutoSize = true;
            this.cxLabel.Location = new System.Drawing.Point(25, 58);
            this.cxLabel.Name = "cxLabel";
            this.cxLabel.Size = new System.Drawing.Size(51, 13);
            this.cxLabel.TabIndex = 40;
            this.cxLabel.Text = "Customer";
            // 
            // Alert
            // 
            this.AcceptButton = this.closeButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.closeButton;
            this.ClientSize = new System.Drawing.Size(265, 404);
            this.ControlBox = false;
            this.Controls.Add(this.cxTB);
            this.Controls.Add(this.cxLabel);
            this.Controls.Add(this.alertLabel);
            this.Controls.Add(this.endDTP);
            this.Controls.Add(this.startDTP);
            this.Controls.Add(this.typeTB);
            this.Controls.Add(this.contactTB);
            this.Controls.Add(this.locTB);
            this.Controls.Add(this.descTB);
            this.Controls.Add(this.titleTB);
            this.Controls.Add(this.endLabel);
            this.Controls.Add(this.startLabel);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.contactLabel);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.closeButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Alert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Appointment Alert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.DateTimePicker endDTP;
        private System.Windows.Forms.DateTimePicker startDTP;
        private System.Windows.Forms.TextBox typeTB;
        private System.Windows.Forms.TextBox contactTB;
        private System.Windows.Forms.TextBox locTB;
        private System.Windows.Forms.TextBox descTB;
        private System.Windows.Forms.TextBox titleTB;
        private System.Windows.Forms.Label endLabel;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label contactLabel;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label alertLabel;
        private System.Windows.Forms.TextBox cxTB;
        private System.Windows.Forms.Label cxLabel;
    }
}