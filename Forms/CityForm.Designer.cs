
namespace Silkroski_C969.Forms
{
    partial class CityForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CityForm));
            this.ValidateBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CityNameTB = new System.Windows.Forms.TextBox();
            this.CityIdTB = new System.Windows.Forms.TextBox();
            this.countryIdLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.countryIdTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ValidateBtn
            // 
            this.ValidateBtn.Location = new System.Drawing.Point(178, 340);
            this.ValidateBtn.Name = "ValidateBtn";
            this.ValidateBtn.Size = new System.Drawing.Size(75, 23);
            this.ValidateBtn.TabIndex = 3;
            this.ValidateBtn.Text = "Validate";
            this.ValidateBtn.UseVisualStyleBackColor = true;
            this.ValidateBtn.Click += new System.EventHandler(this.ValidateBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(97, 369);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 4;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CityCancelBtn_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Enabled = false;
            this.SaveButton.Location = new System.Drawing.Point(178, 369);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 5;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CityNameTB
            // 
            this.CityNameTB.Location = new System.Drawing.Point(37, 106);
            this.CityNameTB.Name = "CityNameTB";
            this.CityNameTB.Size = new System.Drawing.Size(216, 20);
            this.CityNameTB.TabIndex = 6;
            // 
            // CityIdTB
            // 
            this.CityIdTB.Location = new System.Drawing.Point(153, 52);
            this.CityIdTB.Name = "CityIdTB";
            this.CityIdTB.ReadOnly = true;
            this.CityIdTB.Size = new System.Drawing.Size(100, 20);
            this.CityIdTB.TabIndex = 6;
            // 
            // countryIdLbl
            // 
            this.countryIdLbl.AutoSize = true;
            this.countryIdLbl.Location = new System.Drawing.Point(34, 141);
            this.countryIdLbl.Name = "countryIdLbl";
            this.countryIdLbl.Size = new System.Drawing.Size(43, 13);
            this.countryIdLbl.TabIndex = 7;
            this.countryIdLbl.Text = "Country";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "City Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "City Id";
            // 
            // countryIdTB
            // 
            this.countryIdTB.Location = new System.Drawing.Point(37, 157);
            this.countryIdTB.Name = "countryIdTB";
            this.countryIdTB.Size = new System.Drawing.Size(216, 20);
            this.countryIdTB.TabIndex = 6;
            // 
            // CityForm
            // 
            this.AcceptButton = this.ValidateBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(284, 411);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.countryIdLbl);
            this.Controls.Add(this.countryIdTB);
            this.Controls.Add(this.CityIdTB);
            this.Controls.Add(this.CityNameTB);
            this.Controls.Add(this.ValidateBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SaveButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CityForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "City Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ValidateBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox CityNameTB;
        private System.Windows.Forms.TextBox CityIdTB;
        private System.Windows.Forms.Label countryIdLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox countryIdTB;
    }
}