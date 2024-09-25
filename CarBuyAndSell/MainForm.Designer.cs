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
            this.btnUserList = new System.Windows.Forms.Button();
            this.btnVehicles = new System.Windows.Forms.Button();
            this.btnListing = new System.Windows.Forms.Button();
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
            this.sideNav.Controls.Add(this.btnUserList);
            this.sideNav.Controls.Add(this.btnVehicles);
            this.sideNav.Controls.Add(this.btnListing);
            this.sideNav.Controls.Add(this.adminBtn);
            this.sideNav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sideNav.Location = new System.Drawing.Point(3, 3);
            this.sideNav.Name = "sideNav";
            this.sideNav.Size = new System.Drawing.Size(194, 547);
            this.sideNav.TabIndex = 0;
            // 
            // btnUserList
            // 
            this.btnUserList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUserList.Location = new System.Drawing.Point(0, 153);
            this.btnUserList.Name = "btnUserList";
            this.btnUserList.Size = new System.Drawing.Size(194, 50);
            this.btnUserList.TabIndex = 0;
            this.btnUserList.Text = "User List";
            this.btnUserList.Click += new System.EventHandler(this.BtnUserList_Click);
            // 
            // btnVehicles
            // 
            this.btnVehicles.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVehicles.Location = new System.Drawing.Point(0, 103);
            this.btnVehicles.Name = "btnVehicles";
            this.btnVehicles.Size = new System.Drawing.Size(194, 50);
            this.btnVehicles.TabIndex = 0;
            this.btnVehicles.Text = "Vehicles";
            this.btnVehicles.Click += new System.EventHandler(this.BtnVehicles_Click);
            // 
            // btnListing
            // 
            this.btnListing.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListing.Location = new System.Drawing.Point(0, 51);
            this.btnListing.Name = "btnListing";
            this.btnListing.Size = new System.Drawing.Size(194, 50);
            this.btnListing.TabIndex = 1;
            this.btnListing.Text = "My Listing";
            this.btnListing.Click += new System.EventHandler(this.BtnListing_Click);
            // 
            // adminBtn
            // 
            this.adminBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.adminBtn.Location = new System.Drawing.Point(0, 0);
            this.adminBtn.Name = "adminBtn";
            this.adminBtn.Size = new System.Drawing.Size(194, 50);
            this.adminBtn.TabIndex = 2;
            this.adminBtn.Text = "Admin Dashboard";
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
        private Button btnVehicles;
        private Button btnListing;
        private Button btnUserList;
        private Button adminBtn;
        private Panel carPanel;
        private Button prevPageBtn;
        private Button nextPageBtn;
        private TableLayoutPanel mainLayout;
        private TableLayoutPanel paginationLayout;
        private Panel contentPanel;
    }
}

