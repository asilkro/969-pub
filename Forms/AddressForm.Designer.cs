
namespace Silkroski_C969.Forms
{
    partial class AddressForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddressForm));
            this.addressIdLbl = new System.Windows.Forms.Label();
            this.phoneLbl = new System.Windows.Forms.Label();
            this.addressLine1Lbl = new System.Windows.Forms.Label();
            this.addressLine2Lbl = new System.Windows.Forms.Label();
            this.cityIdLbl = new System.Windows.Forms.Label();
            this.postalLbl = new System.Windows.Forms.Label();
            this.ValidateBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.addressIdTB = new System.Windows.Forms.TextBox();
            this.address1Tb = new System.Windows.Forms.TextBox();
            this.address2Tb = new System.Windows.Forms.TextBox();
            this.postalTb = new System.Windows.Forms.TextBox();
            this.phoneTb = new System.Windows.Forms.TextBox();
            this.cityIdTb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addressIdLbl
            // 
            this.addressIdLbl.AutoSize = true;
            this.addressIdLbl.Location = new System.Drawing.Point(28, 40);
            this.addressIdLbl.Name = "addressIdLbl";
            this.addressIdLbl.Size = new System.Drawing.Size(57, 13);
            this.addressIdLbl.TabIndex = 0;
            this.addressIdLbl.Text = "Address Id";
            // 
            // phoneLbl
            // 
            this.phoneLbl.AutoSize = true;
            this.phoneLbl.Location = new System.Drawing.Point(28, 181);
            this.phoneLbl.Name = "phoneLbl";
            this.phoneLbl.Size = new System.Drawing.Size(38, 13);
            this.phoneLbl.TabIndex = 0;
            this.phoneLbl.Text = "Phone";
            // 
            // addressLine1Lbl
            // 
            this.addressLine1Lbl.AutoSize = true;
            this.addressLine1Lbl.Location = new System.Drawing.Point(28, 68);
            this.addressLine1Lbl.Name = "addressLine1Lbl";
            this.addressLine1Lbl.Size = new System.Drawing.Size(77, 13);
            this.addressLine1Lbl.TabIndex = 0;
            this.addressLine1Lbl.Text = "Address Line 1";
            // 
            // addressLine2Lbl
            // 
            this.addressLine2Lbl.AutoSize = true;
            this.addressLine2Lbl.Location = new System.Drawing.Point(28, 107);
            this.addressLine2Lbl.Name = "addressLine2Lbl";
            this.addressLine2Lbl.Size = new System.Drawing.Size(77, 13);
            this.addressLine2Lbl.TabIndex = 0;
            this.addressLine2Lbl.Text = "Address Line 2";
            // 
            // cityIdLbl
            // 
            this.cityIdLbl.AutoSize = true;
            this.cityIdLbl.Location = new System.Drawing.Point(28, 215);
            this.cityIdLbl.Name = "cityIdLbl";
            this.cityIdLbl.Size = new System.Drawing.Size(24, 13);
            this.cityIdLbl.TabIndex = 0;
            this.cityIdLbl.Text = "City";
            // 
            // postalLbl
            // 
            this.postalLbl.AutoSize = true;
            this.postalLbl.Location = new System.Drawing.Point(28, 152);
            this.postalLbl.Name = "postalLbl";
            this.postalLbl.Size = new System.Drawing.Size(36, 13);
            this.postalLbl.TabIndex = 0;
            this.postalLbl.Text = "Postal";
            // 
            // ValidateBtn
            // 
            this.ValidateBtn.Location = new System.Drawing.Point(185, 334);
            this.ValidateBtn.Name = "ValidateBtn";
            this.ValidateBtn.Size = new System.Drawing.Size(75, 23);
            this.ValidateBtn.TabIndex = 12;
            this.ValidateBtn.Text = "Validate";
            this.ValidateBtn.UseVisualStyleBackColor = true;
            this.ValidateBtn.Click += new System.EventHandler(this.ValidateBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(104, 363);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 13;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Enabled = false;
            this.SaveButton.Location = new System.Drawing.Point(185, 363);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 14;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // addressIdTB
            // 
            this.addressIdTB.Location = new System.Drawing.Point(160, 40);
            this.addressIdTB.Name = "addressIdTB";
            this.addressIdTB.ReadOnly = true;
            this.addressIdTB.Size = new System.Drawing.Size(100, 20);
            this.addressIdTB.TabIndex = 15;
            // 
            // address1Tb
            // 
            this.address1Tb.Location = new System.Drawing.Point(31, 84);
            this.address1Tb.Name = "address1Tb";
            this.address1Tb.Size = new System.Drawing.Size(229, 20);
            this.address1Tb.TabIndex = 15;
            // 
            // address2Tb
            // 
            this.address2Tb.Location = new System.Drawing.Point(31, 123);
            this.address2Tb.Name = "address2Tb";
            this.address2Tb.Size = new System.Drawing.Size(229, 20);
            this.address2Tb.TabIndex = 15;
            // 
            // postalTb
            // 
            this.postalTb.Location = new System.Drawing.Point(104, 149);
            this.postalTb.Name = "postalTb";
            this.postalTb.Size = new System.Drawing.Size(156, 20);
            this.postalTb.TabIndex = 15;
            // 
            // phoneTb
            // 
            this.phoneTb.Location = new System.Drawing.Point(104, 178);
            this.phoneTb.Name = "phoneTb";
            this.phoneTb.Size = new System.Drawing.Size(156, 20);
            this.phoneTb.TabIndex = 15;
            // 
            // cityIdTb
            // 
            this.cityIdTb.Location = new System.Drawing.Point(104, 212);
            this.cityIdTb.Name = "cityIdTb";
            this.cityIdTb.Size = new System.Drawing.Size(156, 20);
            this.cityIdTb.TabIndex = 15;
            // 
            // AddressForm
            // 
            this.AcceptButton = this.ValidateBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(284, 411);
            this.Controls.Add(this.cityIdTb);
            this.Controls.Add(this.phoneTb);
            this.Controls.Add(this.postalTb);
            this.Controls.Add(this.address2Tb);
            this.Controls.Add(this.address1Tb);
            this.Controls.Add(this.addressIdTB);
            this.Controls.Add(this.ValidateBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.phoneLbl);
            this.Controls.Add(this.postalLbl);
            this.Controls.Add(this.cityIdLbl);
            this.Controls.Add(this.addressLine2Lbl);
            this.Controls.Add(this.addressLine1Lbl);
            this.Controls.Add(this.addressIdLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddressForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddressForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addressIdLbl;
        private System.Windows.Forms.Label phoneLbl;
        private System.Windows.Forms.Label addressLine1Lbl;
        private System.Windows.Forms.Label addressLine2Lbl;
        private System.Windows.Forms.Label cityIdLbl;
        private System.Windows.Forms.Label postalLbl;
        private System.Windows.Forms.Button ValidateBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox addressIdTB;
        private System.Windows.Forms.TextBox address1Tb;
        private System.Windows.Forms.TextBox address2Tb;
        private System.Windows.Forms.TextBox postalTb;
        private System.Windows.Forms.TextBox phoneTb;
        private System.Windows.Forms.TextBox cityIdTb;
    }
}