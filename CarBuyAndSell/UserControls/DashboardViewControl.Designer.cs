using System.Windows.Forms;

namespace CarBuyAndSell
{
    partial class DashboardViewControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardViewControl));
            Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges borderEdges6 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges borderEdges7 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges borderEdges8 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges();
            this.pnlTotalUsers = new Bunifu.UI.WinForms.BunifuPanel();
            this.chrtEarningsPerMonth = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            this.bigLabel1 = new ReaLTaiizor.BigLabel();
            this.lblTotalUsers = new ReaLTaiizor.BigLabel();
            this.bunifuIconButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuIconButton2 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton();
            this.lblTotalVehicles = new ReaLTaiizor.BigLabel();
            this.bigLabel4 = new ReaLTaiizor.BigLabel();
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuIconButton3 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton();
            this.lblTotalBrands = new ReaLTaiizor.BigLabel();
            this.bigLabel6 = new ReaLTaiizor.BigLabel();
            this.bunifuPanel3 = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuIconButton4 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton();
            this.lblTotalPlatformEarnings = new ReaLTaiizor.BigLabel();
            this.bigLabel8 = new ReaLTaiizor.BigLabel();
            this.chrtTransactionsPerMonth = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            this.pnlTotalUsers.SuspendLayout();
            this.bunifuPanel1.SuspendLayout();
            this.bunifuPanel2.SuspendLayout();
            this.bunifuPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTotalUsers
            // 
            this.pnlTotalUsers.BackgroundColor = System.Drawing.Color.Transparent;
            this.pnlTotalUsers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlTotalUsers.BackgroundImage")));
            this.pnlTotalUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTotalUsers.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlTotalUsers.BorderRadius = 3;
            this.pnlTotalUsers.BorderThickness = 1;
            this.pnlTotalUsers.Controls.Add(this.bunifuIconButton1);
            this.pnlTotalUsers.Controls.Add(this.lblTotalUsers);
            this.pnlTotalUsers.Controls.Add(this.bigLabel1);
            this.pnlTotalUsers.Location = new System.Drawing.Point(33, 34);
            this.pnlTotalUsers.Name = "pnlTotalUsers";
            this.pnlTotalUsers.ShowBorders = true;
            this.pnlTotalUsers.Size = new System.Drawing.Size(209, 125);
            this.pnlTotalUsers.TabIndex = 0;
            // 
            // chrtEarningsPerMonth
            // 
            this.chrtEarningsPerMonth.BackColor = System.Drawing.Color.MintCream;
            this.chrtEarningsPerMonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chrtEarningsPerMonth.Location = new System.Drawing.Point(33, 183);
            this.chrtEarningsPerMonth.Name = "chrtEarningsPerMonth";
            this.chrtEarningsPerMonth.Size = new System.Drawing.Size(436, 328);
            this.chrtEarningsPerMonth.TabIndex = 2;
            // 
            // bigLabel1
            // 
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel1.Location = new System.Drawing.Point(9, 93);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(98, 21);
            this.bigLabel1.TabIndex = 0;
            this.bigLabel1.Text = "Total Users";
            // 
            // lblTotalUsers
            // 
            this.lblTotalUsers.AutoSize = true;
            this.lblTotalUsers.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalUsers.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblTotalUsers.Location = new System.Drawing.Point(7, 53);
            this.lblTotalUsers.Name = "lblTotalUsers";
            this.lblTotalUsers.Size = new System.Drawing.Size(151, 34);
            this.lblTotalUsers.TabIndex = 1;
            this.lblTotalUsers.Text = "bigLabel2";
            // 
            // bunifuIconButton1
            // 
            this.bunifuIconButton1.AllowAnimations = true;
            this.bunifuIconButton1.AllowBorderColorChanges = true;
            this.bunifuIconButton1.AllowMouseEffects = true;
            this.bunifuIconButton1.AnimationSpeed = 200;
            this.bunifuIconButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuIconButton1.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.bunifuIconButton1.BorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuIconButton1.BorderRadius = 1;
            this.bunifuIconButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderStyles.Solid;
            this.bunifuIconButton1.BorderThickness = 1;
            this.bunifuIconButton1.ColorContrastOnClick = 30;
            this.bunifuIconButton1.ColorContrastOnHover = 30;
            this.bunifuIconButton1.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges5.BottomLeft = true;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = true;
            borderEdges5.TopRight = true;
            this.bunifuIconButton1.CustomizableEdges = borderEdges5;
            this.bunifuIconButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuIconButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuIconButton1.Image")));
            this.bunifuIconButton1.ImageMargin = new System.Windows.Forms.Padding(0);
            this.bunifuIconButton1.Location = new System.Drawing.Point(13, 15);
            this.bunifuIconButton1.Name = "bunifuIconButton1";
            this.bunifuIconButton1.RoundBorders = true;
            this.bunifuIconButton1.ShowBorders = true;
            this.bunifuIconButton1.Size = new System.Drawing.Size(35, 35);
            this.bunifuIconButton1.Style = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.ButtonStyles.Round;
            this.bunifuIconButton1.TabIndex = 2;
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.bunifuIconButton2);
            this.bunifuPanel1.Controls.Add(this.lblTotalVehicles);
            this.bunifuPanel1.Controls.Add(this.bigLabel4);
            this.bunifuPanel1.Location = new System.Drawing.Point(260, 34);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(209, 125);
            this.bunifuPanel1.TabIndex = 3;
            // 
            // bunifuIconButton2
            // 
            this.bunifuIconButton2.AllowAnimations = true;
            this.bunifuIconButton2.AllowBorderColorChanges = true;
            this.bunifuIconButton2.AllowMouseEffects = true;
            this.bunifuIconButton2.AnimationSpeed = 200;
            this.bunifuIconButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuIconButton2.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.bunifuIconButton2.BorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuIconButton2.BorderRadius = 1;
            this.bunifuIconButton2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderStyles.Solid;
            this.bunifuIconButton2.BorderThickness = 1;
            this.bunifuIconButton2.ColorContrastOnClick = 30;
            this.bunifuIconButton2.ColorContrastOnHover = 30;
            this.bunifuIconButton2.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges6.BottomLeft = true;
            borderEdges6.BottomRight = true;
            borderEdges6.TopLeft = true;
            borderEdges6.TopRight = true;
            this.bunifuIconButton2.CustomizableEdges = borderEdges6;
            this.bunifuIconButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuIconButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuIconButton2.Image")));
            this.bunifuIconButton2.ImageMargin = new System.Windows.Forms.Padding(0);
            this.bunifuIconButton2.Location = new System.Drawing.Point(13, 15);
            this.bunifuIconButton2.Name = "bunifuIconButton2";
            this.bunifuIconButton2.RoundBorders = true;
            this.bunifuIconButton2.ShowBorders = true;
            this.bunifuIconButton2.Size = new System.Drawing.Size(35, 35);
            this.bunifuIconButton2.Style = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.ButtonStyles.Round;
            this.bunifuIconButton2.TabIndex = 2;
            // 
            // lblTotalVehicles
            // 
            this.lblTotalVehicles.AutoSize = true;
            this.lblTotalVehicles.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalVehicles.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalVehicles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblTotalVehicles.Location = new System.Drawing.Point(7, 53);
            this.lblTotalVehicles.Name = "lblTotalVehicles";
            this.lblTotalVehicles.Size = new System.Drawing.Size(151, 34);
            this.lblTotalVehicles.TabIndex = 1;
            this.lblTotalVehicles.Text = "bigLabel3";
            // 
            // bigLabel4
            // 
            this.bigLabel4.AutoSize = true;
            this.bigLabel4.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel4.Location = new System.Drawing.Point(9, 93);
            this.bigLabel4.Name = "bigLabel4";
            this.bigLabel4.Size = new System.Drawing.Size(125, 21);
            this.bigLabel4.TabIndex = 0;
            this.bigLabel4.Text = "Total Vehicles";
            // 
            // bunifuPanel2
            // 
            this.bunifuPanel2.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel2.BackgroundImage")));
            this.bunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel2.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.bunifuPanel2.BorderRadius = 3;
            this.bunifuPanel2.BorderThickness = 1;
            this.bunifuPanel2.Controls.Add(this.bunifuIconButton3);
            this.bunifuPanel2.Controls.Add(this.lblTotalBrands);
            this.bunifuPanel2.Controls.Add(this.bigLabel6);
            this.bunifuPanel2.Location = new System.Drawing.Point(494, 34);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.ShowBorders = true;
            this.bunifuPanel2.Size = new System.Drawing.Size(209, 125);
            this.bunifuPanel2.TabIndex = 3;
            // 
            // bunifuIconButton3
            // 
            this.bunifuIconButton3.AllowAnimations = true;
            this.bunifuIconButton3.AllowBorderColorChanges = true;
            this.bunifuIconButton3.AllowMouseEffects = true;
            this.bunifuIconButton3.AnimationSpeed = 200;
            this.bunifuIconButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuIconButton3.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.bunifuIconButton3.BorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuIconButton3.BorderRadius = 1;
            this.bunifuIconButton3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderStyles.Solid;
            this.bunifuIconButton3.BorderThickness = 1;
            this.bunifuIconButton3.ColorContrastOnClick = 30;
            this.bunifuIconButton3.ColorContrastOnHover = 30;
            this.bunifuIconButton3.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges7.BottomLeft = true;
            borderEdges7.BottomRight = true;
            borderEdges7.TopLeft = true;
            borderEdges7.TopRight = true;
            this.bunifuIconButton3.CustomizableEdges = borderEdges7;
            this.bunifuIconButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuIconButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuIconButton3.Image")));
            this.bunifuIconButton3.ImageMargin = new System.Windows.Forms.Padding(0);
            this.bunifuIconButton3.Location = new System.Drawing.Point(13, 15);
            this.bunifuIconButton3.Name = "bunifuIconButton3";
            this.bunifuIconButton3.RoundBorders = true;
            this.bunifuIconButton3.ShowBorders = true;
            this.bunifuIconButton3.Size = new System.Drawing.Size(35, 35);
            this.bunifuIconButton3.Style = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.ButtonStyles.Round;
            this.bunifuIconButton3.TabIndex = 2;
            // 
            // lblTotalBrands
            // 
            this.lblTotalBrands.AutoSize = true;
            this.lblTotalBrands.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalBrands.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBrands.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblTotalBrands.Location = new System.Drawing.Point(7, 53);
            this.lblTotalBrands.Name = "lblTotalBrands";
            this.lblTotalBrands.Size = new System.Drawing.Size(151, 34);
            this.lblTotalBrands.TabIndex = 1;
            this.lblTotalBrands.Text = "bigLabel5";
            // 
            // bigLabel6
            // 
            this.bigLabel6.AutoSize = true;
            this.bigLabel6.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel6.Location = new System.Drawing.Point(9, 93);
            this.bigLabel6.Name = "bigLabel6";
            this.bigLabel6.Size = new System.Drawing.Size(112, 21);
            this.bigLabel6.TabIndex = 0;
            this.bigLabel6.Text = "Total Brands";
            // 
            // bunifuPanel3
            // 
            this.bunifuPanel3.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel3.BackgroundImage")));
            this.bunifuPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel3.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.bunifuPanel3.BorderRadius = 3;
            this.bunifuPanel3.BorderThickness = 1;
            this.bunifuPanel3.Controls.Add(this.bunifuIconButton4);
            this.bunifuPanel3.Controls.Add(this.lblTotalPlatformEarnings);
            this.bunifuPanel3.Controls.Add(this.bigLabel8);
            this.bunifuPanel3.Location = new System.Drawing.Point(721, 34);
            this.bunifuPanel3.Name = "bunifuPanel3";
            this.bunifuPanel3.ShowBorders = true;
            this.bunifuPanel3.Size = new System.Drawing.Size(209, 125);
            this.bunifuPanel3.TabIndex = 3;
            // 
            // bunifuIconButton4
            // 
            this.bunifuIconButton4.AllowAnimations = true;
            this.bunifuIconButton4.AllowBorderColorChanges = true;
            this.bunifuIconButton4.AllowMouseEffects = true;
            this.bunifuIconButton4.AnimationSpeed = 200;
            this.bunifuIconButton4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuIconButton4.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.bunifuIconButton4.BorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuIconButton4.BorderRadius = 1;
            this.bunifuIconButton4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderStyles.Solid;
            this.bunifuIconButton4.BorderThickness = 1;
            this.bunifuIconButton4.ColorContrastOnClick = 30;
            this.bunifuIconButton4.ColorContrastOnHover = 30;
            this.bunifuIconButton4.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges8.BottomLeft = true;
            borderEdges8.BottomRight = true;
            borderEdges8.TopLeft = true;
            borderEdges8.TopRight = true;
            this.bunifuIconButton4.CustomizableEdges = borderEdges8;
            this.bunifuIconButton4.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuIconButton4.Image = ((System.Drawing.Image)(resources.GetObject("bunifuIconButton4.Image")));
            this.bunifuIconButton4.ImageMargin = new System.Windows.Forms.Padding(0);
            this.bunifuIconButton4.Location = new System.Drawing.Point(13, 15);
            this.bunifuIconButton4.Name = "bunifuIconButton4";
            this.bunifuIconButton4.RoundBorders = true;
            this.bunifuIconButton4.ShowBorders = true;
            this.bunifuIconButton4.Size = new System.Drawing.Size(35, 35);
            this.bunifuIconButton4.Style = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.ButtonStyles.Round;
            this.bunifuIconButton4.TabIndex = 2;
            // 
            // lblTotalPlatformEarnings
            // 
            this.lblTotalPlatformEarnings.AutoSize = true;
            this.lblTotalPlatformEarnings.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalPlatformEarnings.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPlatformEarnings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblTotalPlatformEarnings.Location = new System.Drawing.Point(7, 53);
            this.lblTotalPlatformEarnings.Name = "lblTotalPlatformEarnings";
            this.lblTotalPlatformEarnings.Size = new System.Drawing.Size(151, 34);
            this.lblTotalPlatformEarnings.TabIndex = 1;
            this.lblTotalPlatformEarnings.Text = "bigLabel7";
            // 
            // bigLabel8
            // 
            this.bigLabel8.AutoSize = true;
            this.bigLabel8.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel8.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel8.Location = new System.Drawing.Point(9, 93);
            this.bigLabel8.Name = "bigLabel8";
            this.bigLabel8.Size = new System.Drawing.Size(150, 21);
            this.bigLabel8.TabIndex = 0;
            this.bigLabel8.Text = "Platform Earnings";
            // 
            // chrtTransactionsPerMonth
            // 
            this.chrtTransactionsPerMonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chrtTransactionsPerMonth.Location = new System.Drawing.Point(494, 183);
            this.chrtTransactionsPerMonth.Name = "chrtTransactionsPerMonth";
            this.chrtTransactionsPerMonth.Size = new System.Drawing.Size(436, 328);
            this.chrtTransactionsPerMonth.TabIndex = 5;
            // 
            // DashboardViewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.Controls.Add(this.chrtTransactionsPerMonth);
            this.Controls.Add(this.bunifuPanel2);
            this.Controls.Add(this.bunifuPanel1);
            this.Controls.Add(this.bunifuPanel3);
            this.Controls.Add(this.chrtEarningsPerMonth);
            this.Controls.Add(this.pnlTotalUsers);
            this.Name = "DashboardViewControl";
            this.Size = new System.Drawing.Size(960, 553);
            this.pnlTotalUsers.ResumeLayout(false);
            this.pnlTotalUsers.PerformLayout();
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            this.bunifuPanel2.ResumeLayout(false);
            this.bunifuPanel2.PerformLayout();
            this.bunifuPanel3.ResumeLayout(false);
            this.bunifuPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel pnlTotalUsers;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart chrtEarningsPerMonth;
        private Bunifu.UI.WinForms.BunifuButton.BunifuIconButton bunifuIconButton1;
        private ReaLTaiizor.BigLabel lblTotalUsers;
        private ReaLTaiizor.BigLabel bigLabel1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuIconButton bunifuIconButton2;
        private ReaLTaiizor.BigLabel lblTotalVehicles;
        private ReaLTaiizor.BigLabel bigLabel4;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuIconButton bunifuIconButton3;
        private ReaLTaiizor.BigLabel lblTotalBrands;
        private ReaLTaiizor.BigLabel bigLabel6;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel3;
        private Bunifu.UI.WinForms.BunifuButton.BunifuIconButton bunifuIconButton4;
        private ReaLTaiizor.BigLabel lblTotalPlatformEarnings;
        private ReaLTaiizor.BigLabel bigLabel8;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart chrtTransactionsPerMonth;
    }
}
