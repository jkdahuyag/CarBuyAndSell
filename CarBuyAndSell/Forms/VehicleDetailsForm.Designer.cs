using CarBuyAndSell.Properties;

namespace CarBuyAndSell.Forms
{
    partial class VehicleDetailsForm
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
            this.vehiclePictureBox = new System.Windows.Forms.PictureBox();
            this.detailsPanel = new System.Windows.Forms.Panel();
            this.lblBrandName = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblOwner = new System.Windows.Forms.Label();
            this.lblMileage = new System.Windows.Forms.Label();
            this.lblCondition = new System.Windows.Forms.Label();
            this.lblManufactureYear = new System.Windows.Forms.Label();
            this.lblPlateNumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclePictureBox)).BeginInit();
            this.detailsPanel.SuspendLayout();
            this.SuspendLayout();

            // 
            // vehiclePictureBox
            // 
            this.vehiclePictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.vehiclePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.vehiclePictureBox.Location = new System.Drawing.Point(0, 0);
            this.vehiclePictureBox.Name = "vehiclePictureBox";
            this.vehiclePictureBox.Size = new System.Drawing.Size(800, 300); // Adjust size as needed
            this.vehiclePictureBox.TabIndex = 0;
            this.vehiclePictureBox.TabStop = false;

            // 
            // detailsPanel
            // 
            this.detailsPanel.Controls.Add(this.lblBrandName);
            this.detailsPanel.Controls.Add(this.lblModel);
            this.detailsPanel.Controls.Add(this.lblOwner);
            this.detailsPanel.Controls.Add(this.lblMileage);
            this.detailsPanel.Controls.Add(this.lblCondition);
            this.detailsPanel.Controls.Add(this.lblManufactureYear);
            this.detailsPanel.Controls.Add(this.lblPlateNumber);
            this.detailsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailsPanel.Location = new System.Drawing.Point(0, 300); // Adjust as needed
            this.detailsPanel.Name = "detailsPanel";
            this.detailsPanel.Padding = new System.Windows.Forms.Padding(20); // Add some padding
            this.detailsPanel.Size = new System.Drawing.Size(800, 300);
            this.detailsPanel.TabIndex = 1;

            // 
            // lblBrandName
            // 
            this.lblBrandName.AutoSize = true;
            this.lblBrandName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBrandName.Location = new System.Drawing.Point(20, 20);
            this.lblBrandName.Name = "lblBrandName";
            this.lblBrandName.Size = new System.Drawing.Size(100, 21);
            this.lblBrandName.TabIndex = 0;
            this.lblBrandName.Text = "Brand: ";

            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblModel.Location = new System.Drawing.Point(20, 50);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(60, 21);
            this.lblModel.TabIndex = 1;
            this.lblModel.Text = "Model: ";

            // 
            // lblOwner
            // 
            this.lblOwner.AutoSize = true;
            this.lblOwner.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOwner.Location = new System.Drawing.Point(20, 80);
            this.lblOwner.Name = "lblOwner";
            this.lblOwner.Size = new System.Drawing.Size(64, 21);
            this.lblOwner.TabIndex = 2;
            this.lblOwner.Text = "Owner: ";

            // 
            // lblMileage
            // 
            this.lblMileage.AutoSize = true;
            this.lblMileage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMileage.Location = new System.Drawing.Point(20, 110);
            this.lblMileage.Name = "lblMileage";
            this.lblMileage.Size = new System.Drawing.Size(75, 21);
            this.lblMileage.TabIndex = 3;
            this.lblMileage.Text = "Mileage: ";

            // 
            // lblCondition
            // 
            this.lblCondition.AutoSize = true;
            this.lblCondition.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCondition.Location = new System.Drawing.Point(20, 140);
            this.lblCondition.Name = "lblCondition";
            this.lblCondition.Size = new System.Drawing.Size(84, 21);
            this.lblCondition.TabIndex = 4;
            this.lblCondition.Text = "Condition: ";

            // 
            // lblManufactureYear
            // 
            this.lblManufactureYear.AutoSize = true;
            this.lblManufactureYear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblManufactureYear.Location = new System.Drawing.Point(20, 170);
            this.lblManufactureYear.Name = "lblManufactureYear";
            this.lblManufactureYear.Size = new System.Drawing.Size(139, 21);
            this.lblManufactureYear.TabIndex = 5;
            this.lblManufactureYear.Text = "Manufacture Year: ";

            // 
            // lblPlateNumber
            // 
            this.lblPlateNumber.AutoSize = true;
            this.lblPlateNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPlateNumber.Location = new System.Drawing.Point(20, 200);
            this.lblPlateNumber.Name = "lblPlateNumber";
            this.lblPlateNumber.Size = new System.Drawing.Size(108, 21);
            this.lblPlateNumber.TabIndex = 6;
            this.lblPlateNumber.Text = "Plate Number: ";

            // 
            // VehicleDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600); // Adjust size as needed
            this.Controls.Add(this.detailsPanel);
            this.Controls.Add(this.vehiclePictureBox);
            this.Name = "VehicleDetailsForm";
            this.Text = "Vehicle Details";
            ((System.ComponentModel.ISupportInitialize)(this.vehiclePictureBox)).EndInit();
            this.detailsPanel.ResumeLayout(false);
            this.detailsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox vehiclePictureBox;
        private System.Windows.Forms.Panel detailsPanel;
        private System.Windows.Forms.Label lblBrandName;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblOwner;
        private System.Windows.Forms.Label lblMileage;
        private System.Windows.Forms.Label lblCondition;
        private System.Windows.Forms.Label lblManufactureYear;
        private System.Windows.Forms.Label lblPlateNumber;
    }
}