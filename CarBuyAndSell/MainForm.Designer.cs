using System.Windows.Forms;
using System;

namespace CarBuyAndSell
{
    partial class MainForm
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
        // Initialize form components
        private void InitializeComponent()
        {
            this.mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.sideNav = new System.Windows.Forms.Panel();
            this.buyBtn = new System.Windows.Forms.Button();
            this.sellBtn = new System.Windows.Forms.Button();
            this.adminBtn = new System.Windows.Forms.Button();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.mainLayout.SuspendLayout();
            this.sideNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainLayout
            // 
            this.mainLayout.ColumnCount = 2;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayout.Controls.Add(this.sideNav, 0, 0);
            this.mainLayout.Controls.Add(this.contentPanel, 1, 0);
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.Location = new System.Drawing.Point(0, 0);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.RowCount = 1;
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainLayout.Size = new System.Drawing.Size(782, 553);
            this.mainLayout.TabIndex = 0;
            // 
            // sideNav
            // 
            this.sideNav.BackColor = System.Drawing.Color.LightGray;
            this.sideNav.Controls.Add(this.buyBtn);
            this.sideNav.Controls.Add(this.sellBtn);
            this.sideNav.Controls.Add(this.adminBtn);
            this.sideNav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sideNav.Location = new System.Drawing.Point(3, 3);
            this.sideNav.Name = "sideNav";
            this.sideNav.Size = new System.Drawing.Size(194, 547);
            this.sideNav.TabIndex = 0;
            // 
            // buyBtn
            // 
            this.buyBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.buyBtn.Location = new System.Drawing.Point(0, 46);
            this.buyBtn.Name = "buyBtn";
            this.buyBtn.Size = new System.Drawing.Size(194, 23);
            this.buyBtn.TabIndex = 0;
            this.buyBtn.Text = "Buy";
            this.buyBtn.Click += new System.EventHandler(this.BuyBtn_Click);
            // 
            // sellBtn
            // 
            this.sellBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.sellBtn.Location = new System.Drawing.Point(0, 23);
            this.sellBtn.Name = "sellBtn";
            this.sellBtn.Size = new System.Drawing.Size(194, 23);
            this.sellBtn.TabIndex = 1;
            this.sellBtn.Text = "Sell";
            this.sellBtn.Click += new System.EventHandler(this.SellBtn_Click);
            // 
            // adminBtn
            // 
            this.adminBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.adminBtn.Location = new System.Drawing.Point(0, 0);
            this.adminBtn.Name = "adminBtn";
            this.adminBtn.Size = new System.Drawing.Size(194, 23);
            this.adminBtn.TabIndex = 2;
            this.adminBtn.Text = "Admin Dashboards";
            this.adminBtn.Click += new System.EventHandler(this.AdminBtn_Click);
            // 
            // contentPanel
            // 
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(203, 3);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(576, 547);
            this.contentPanel.TabIndex = 1;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.mainLayout);
            this.Name = "MainForm";
            this.Text = "Car Selling App";
            this.mainLayout.ResumeLayout(false);
            this.sideNav.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion

        private Panel sideNav;
        private Button buyBtn;
        private Button sellBtn;
        private Button adminBtn;
        private Panel carPanel;
        private Button prevPageBtn;
        private Button nextPageBtn;
        private TableLayoutPanel mainLayout;
        private TableLayoutPanel paginationLayout;
        private Panel contentPanel;
    }
}

