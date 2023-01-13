
namespace Silkroski_C969.Forms
{
    partial class CountryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CountryForm));
            this.countryIdLbl = new System.Windows.Forms.Label();
            this.countryNameLbl = new System.Windows.Forms.Label();
            this.countryIdTB = new System.Windows.Forms.TextBox();
            this.countryNameTB = new System.Windows.Forms.TextBox();
            this.ValidateBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // countryIdLbl
            // 
            this.countryIdLbl.AutoSize = true;
            this.countryIdLbl.Location = new System.Drawing.Point(23, 47);
            this.countryIdLbl.Name = "countryIdLbl";
            this.countryIdLbl.Size = new System.Drawing.Size(55, 13);
            this.countryIdLbl.TabIndex = 14;
            this.countryIdLbl.Text = "Country Id";
            // 
            // countryNameLbl
            // 
            this.countryNameLbl.AutoSize = true;
            this.countryNameLbl.Location = new System.Drawing.Point(23, 80);
            this.countryNameLbl.Name = "countryNameLbl";
            this.countryNameLbl.Size = new System.Drawing.Size(74, 13);
            this.countryNameLbl.TabIndex = 15;
            this.countryNameLbl.Text = "Country Name";
            // 
            // countryIdTB
            // 
            this.countryIdTB.Location = new System.Drawing.Point(142, 40);
            this.countryIdTB.Name = "countryIdTB";
            this.countryIdTB.ReadOnly = true;
            this.countryIdTB.Size = new System.Drawing.Size(100, 20);
            this.countryIdTB.TabIndex = 12;
            // 
            // countryNameTB
            // 
            this.countryNameTB.Location = new System.Drawing.Point(26, 106);
            this.countryNameTB.Name = "countryNameTB";
            this.countryNameTB.Size = new System.Drawing.Size(216, 20);
            this.countryNameTB.TabIndex = 13;
            // 
            // ValidateBtn
            // 
            this.ValidateBtn.Location = new System.Drawing.Point(179, 327);
            this.ValidateBtn.Name = "ValidateBtn";
            this.ValidateBtn.Size = new System.Drawing.Size(75, 23);
            this.ValidateBtn.TabIndex = 9;
            this.ValidateBtn.Text = "Validate";
            this.ValidateBtn.UseVisualStyleBackColor = true;
            this.ValidateBtn.Click += new System.EventHandler(this.ValidateBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(98, 356);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 10;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Enabled = false;
            this.SaveButton.Location = new System.Drawing.Point(179, 356);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 11;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CountryForm
            // 
            this.AcceptButton = this.ValidateBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(284, 411);
            this.Controls.Add(this.countryIdLbl);
            this.Controls.Add(this.countryNameLbl);
            this.Controls.Add(this.countryIdTB);
            this.Controls.Add(this.countryNameTB);
            this.Controls.Add(this.ValidateBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SaveButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CountryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CountryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label countryIdLbl;
        private System.Windows.Forms.Label countryNameLbl;
        private System.Windows.Forms.TextBox countryIdTB;
        private System.Windows.Forms.TextBox countryNameTB;
        private System.Windows.Forms.Button ValidateBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button SaveButton;
    }
}