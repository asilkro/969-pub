
namespace Silkroski_C969.Forms
{
    partial class CustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            this.CxNameTB = new System.Windows.Forms.TextBox();
            this.CxNameLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.CxAddressIdTB = new System.Windows.Forms.TextBox();
            this.CxIdTB = new System.Windows.Forms.TextBox();
            this.CxAddressIdLbl = new System.Windows.Forms.Label();
            this.CxIdLbl = new System.Windows.Forms.Label();
            this.ValidateBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CxNameTB
            // 
            this.CxNameTB.Location = new System.Drawing.Point(26, 108);
            this.CxNameTB.Name = "CxNameTB";
            this.CxNameTB.Size = new System.Drawing.Size(228, 20);
            this.CxNameTB.TabIndex = 0;
            // 
            // CxNameLabel
            // 
            this.CxNameLabel.AutoSize = true;
            this.CxNameLabel.Location = new System.Drawing.Point(23, 77);
            this.CxNameLabel.Name = "CxNameLabel";
            this.CxNameLabel.Size = new System.Drawing.Size(82, 13);
            this.CxNameLabel.TabIndex = 1;
            this.CxNameLabel.Text = "Customer Name";
            // 
            // SaveButton
            // 
            this.SaveButton.Enabled = false;
            this.SaveButton.Location = new System.Drawing.Point(179, 356);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(98, 356);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 2;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // CxAddressIdTB
            // 
            this.CxAddressIdTB.Location = new System.Drawing.Point(170, 145);
            this.CxAddressIdTB.Name = "CxAddressIdTB";
            this.CxAddressIdTB.Size = new System.Drawing.Size(84, 20);
            this.CxAddressIdTB.TabIndex = 4;
            // 
            // CxIdTB
            // 
            this.CxIdTB.Location = new System.Drawing.Point(170, 44);
            this.CxIdTB.Name = "CxIdTB";
            this.CxIdTB.ReadOnly = true;
            this.CxIdTB.Size = new System.Drawing.Size(84, 20);
            this.CxIdTB.TabIndex = 4;
            // 
            // CxAddressIdLbl
            // 
            this.CxAddressIdLbl.AutoSize = true;
            this.CxAddressIdLbl.Location = new System.Drawing.Point(23, 148);
            this.CxAddressIdLbl.Name = "CxAddressIdLbl";
            this.CxAddressIdLbl.Size = new System.Drawing.Size(57, 13);
            this.CxAddressIdLbl.TabIndex = 6;
            this.CxAddressIdLbl.Text = "Address Id";
            // 
            // CxIdLbl
            // 
            this.CxIdLbl.AutoSize = true;
            this.CxIdLbl.Location = new System.Drawing.Point(23, 47);
            this.CxIdLbl.Name = "CxIdLbl";
            this.CxIdLbl.Size = new System.Drawing.Size(63, 13);
            this.CxIdLbl.TabIndex = 6;
            this.CxIdLbl.Text = "Customer Id";
            // 
            // ValidateBtn
            // 
            this.ValidateBtn.Location = new System.Drawing.Point(179, 327);
            this.ValidateBtn.Name = "ValidateBtn";
            this.ValidateBtn.Size = new System.Drawing.Size(75, 23);
            this.ValidateBtn.TabIndex = 2;
            this.ValidateBtn.Text = "Validate";
            this.ValidateBtn.UseVisualStyleBackColor = true;
            this.ValidateBtn.Click += new System.EventHandler(this.ValidateBtn_Click);
            // 
            // CustomerForm
            // 
            this.AcceptButton = this.ValidateBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(284, 411);
            this.Controls.Add(this.CxIdLbl);
            this.Controls.Add(this.CxAddressIdLbl);
            this.Controls.Add(this.ValidateBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.CxNameLabel);
            this.Controls.Add(this.CxIdTB);
            this.Controls.Add(this.CxAddressIdTB);
            this.Controls.Add(this.CxNameTB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Customer Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox CxNameTB;
        private System.Windows.Forms.Label CxNameLabel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CancelBtn;
        public System.Windows.Forms.TextBox CxAddressIdTB;
        public System.Windows.Forms.TextBox CxIdTB;
        private System.Windows.Forms.Label CxAddressIdLbl;
        private System.Windows.Forms.Label CxIdLbl;
        private System.Windows.Forms.Button ValidateBtn;
    }
}