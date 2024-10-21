﻿using System.Windows.Forms;

namespace CarBuyAndSell
{
    partial class UsersViewControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersViewControl));
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.pnlHeader = new Bunifu.UI.WinForms.BunifuPanel();
            this.pnlTransactions = new Bunifu.UI.WinForms.BunifuPanel();
            this.flwTransactions = new System.Windows.Forms.FlowLayoutPanel();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.mainLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.searchButton = new System.Windows.Forms.Button();
            this.paginationPanel = new System.Windows.Forms.Panel();
            this.sellButton = new System.Windows.Forms.Button();
            this.firstPageBtn = new System.Windows.Forms.Button();
            this.prevPageBtn = new System.Windows.Forms.Button();
            this.pageLabel = new System.Windows.Forms.Label();
            this.nextPageBtn = new System.Windows.Forms.Button();
            this.lastPageBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblNumber = new ReaLTaiizor.BigLabel();
            this.lblRole = new ReaLTaiizor.BigLabel();
            this.lblUsername = new ReaLTaiizor.BigLabel();
            this.lblAddress = new ReaLTaiizor.BigLabel();
            this.lblUserId = new ReaLTaiizor.BigLabel();
            this.lblName = new ReaLTaiizor.BigLabel();
            this.pnlHeader.SuspendLayout();
            this.pnlTransactions.SuspendLayout();
            this.mainLayoutPanel.SuspendLayout();
            this.searchPanel.SuspendLayout();
            this.paginationPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator1.BackgroundImage")));
            this.bunifuSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator1.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.Silver;
            this.bunifuSeparator1.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 44);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator1.Size = new System.Drawing.Size(776, 17);
            this.bunifuSeparator1.TabIndex = 6;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackgroundColor = System.Drawing.Color.MintCream;
            this.pnlHeader.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlHeader.BackgroundImage")));
            this.pnlHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlHeader.BorderColor = System.Drawing.Color.Transparent;
            this.pnlHeader.BorderRadius = 3;
            this.pnlHeader.BorderThickness = 1;
            this.pnlHeader.Controls.Add(this.bunifuSeparator1);
            this.pnlHeader.Controls.Add(this.tableLayoutPanel1);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.ShowBorders = true;
            this.pnlHeader.Size = new System.Drawing.Size(776, 64);
            this.pnlHeader.TabIndex = 4;
            // 
            // pnlTransactions
            // 
            this.pnlTransactions.BackgroundColor = System.Drawing.Color.MintCream;
            this.pnlTransactions.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlTransactions.BackgroundImage")));
            this.pnlTransactions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTransactions.BorderColor = System.Drawing.Color.Transparent;
            this.pnlTransactions.BorderRadius = 3;
            this.pnlTransactions.BorderThickness = 1;
            this.pnlTransactions.Controls.Add(this.flwTransactions);
            this.pnlTransactions.Controls.Add(this.pnlHeader);
            this.pnlTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTransactions.Location = new System.Drawing.Point(3, 53);
            this.pnlTransactions.Name = "pnlTransactions";
            this.pnlTransactions.ShowBorders = true;
            this.pnlTransactions.Size = new System.Drawing.Size(776, 437);
            this.pnlTransactions.TabIndex = 3;
            // 
            // flwTransactions
            // 
            this.flwTransactions.AutoScroll = true;
            this.flwTransactions.BackColor = System.Drawing.Color.Transparent;
            this.flwTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flwTransactions.Location = new System.Drawing.Point(0, 64);
            this.flwTransactions.Name = "flwTransactions";
            this.flwTransactions.Size = new System.Drawing.Size(776, 373);
            this.flwTransactions.TabIndex = 5;
            // 
            // searchBox
            // 
            this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox.Location = new System.Drawing.Point(491, 10);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(200, 22);
            this.searchBox.TabIndex = 0;
            // 
            // mainLayoutPanel
            // 
            this.mainLayoutPanel.ColumnCount = 1;
            this.mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 782F));
            this.mainLayoutPanel.Controls.Add(this.searchPanel, 0, 0);
            this.mainLayoutPanel.Controls.Add(this.paginationPanel, 0, 2);
            this.mainLayoutPanel.Controls.Add(this.pnlTransactions, 0, 1);
            this.mainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainLayoutPanel.Name = "mainLayoutPanel";
            this.mainLayoutPanel.RowCount = 3;
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.mainLayoutPanel.Size = new System.Drawing.Size(782, 553);
            this.mainLayoutPanel.TabIndex = 3;
            // 
            // searchPanel
            // 
            this.searchPanel.Controls.Add(this.searchBox);
            this.searchPanel.Controls.Add(this.searchButton);
            this.searchPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchPanel.Location = new System.Drawing.Point(3, 3);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Padding = new System.Windows.Forms.Padding(10);
            this.searchPanel.Size = new System.Drawing.Size(776, 44);
            this.searchPanel.TabIndex = 0;
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.Location = new System.Drawing.Point(691, 9);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 25);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Search";
            // 
            // paginationPanel
            // 
            this.paginationPanel.Controls.Add(this.sellButton);
            this.paginationPanel.Controls.Add(this.firstPageBtn);
            this.paginationPanel.Controls.Add(this.prevPageBtn);
            this.paginationPanel.Controls.Add(this.pageLabel);
            this.paginationPanel.Controls.Add(this.nextPageBtn);
            this.paginationPanel.Controls.Add(this.lastPageBtn);
            this.paginationPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paginationPanel.Location = new System.Drawing.Point(3, 496);
            this.paginationPanel.Name = "paginationPanel";
            this.paginationPanel.Size = new System.Drawing.Size(776, 54);
            this.paginationPanel.TabIndex = 2;
            // 
            // sellButton
            // 
            this.sellButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.sellButton.Location = new System.Drawing.Point(0, 0);
            this.sellButton.Name = "sellButton";
            this.sellButton.Size = new System.Drawing.Size(75, 54);
            this.sellButton.TabIndex = 0;
            this.sellButton.Text = "Sell";
            // 
            // firstPageBtn
            // 
            this.firstPageBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.firstPageBtn.Location = new System.Drawing.Point(376, 0);
            this.firstPageBtn.Name = "firstPageBtn";
            this.firstPageBtn.Size = new System.Drawing.Size(75, 54);
            this.firstPageBtn.TabIndex = 0;
            this.firstPageBtn.Text = "<< First";
            // 
            // prevPageBtn
            // 
            this.prevPageBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.prevPageBtn.Enabled = false;
            this.prevPageBtn.Location = new System.Drawing.Point(451, 0);
            this.prevPageBtn.Name = "prevPageBtn";
            this.prevPageBtn.Size = new System.Drawing.Size(75, 54);
            this.prevPageBtn.TabIndex = 0;
            this.prevPageBtn.Text = "Previous";
            // 
            // pageLabel
            // 
            this.pageLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.pageLabel.Location = new System.Drawing.Point(526, 0);
            this.pageLabel.Name = "pageLabel";
            this.pageLabel.Size = new System.Drawing.Size(100, 54);
            this.pageLabel.TabIndex = 1;
            this.pageLabel.Text = "Page 0 of 10";
            this.pageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nextPageBtn
            // 
            this.nextPageBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.nextPageBtn.Enabled = false;
            this.nextPageBtn.Location = new System.Drawing.Point(626, 0);
            this.nextPageBtn.Name = "nextPageBtn";
            this.nextPageBtn.Size = new System.Drawing.Size(75, 54);
            this.nextPageBtn.TabIndex = 1;
            this.nextPageBtn.Text = "Next";
            // 
            // lastPageBtn
            // 
            this.lastPageBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.lastPageBtn.Location = new System.Drawing.Point(701, 0);
            this.lastPageBtn.Name = "lastPageBtn";
            this.lastPageBtn.Size = new System.Drawing.Size(75, 54);
            this.lastPageBtn.TabIndex = 3;
            this.lastPageBtn.Text = "Last >>";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.479543F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.39771F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.151211F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.31798F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.3435F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.64339F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Controls.Add(this.lblNumber, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblRole, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblUsername, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblAddress, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblUserId, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblName, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(776, 44);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // lblNumber
            // 
            this.lblNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumber.AutoSize = true;
            this.lblNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblNumber.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblNumber.Location = new System.Drawing.Point(565, 23);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(76, 21);
            this.lblNumber.TabIndex = 5;
            this.lblNumber.Text = "Number";
            this.lblNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRole
            // 
            this.lblRole.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRole.AutoSize = true;
            this.lblRole.BackColor = System.Drawing.Color.Transparent;
            this.lblRole.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblRole.Location = new System.Drawing.Point(210, 23);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(65, 21);
            this.lblRole.TabIndex = 2;
            this.lblRole.Text = "Role";
            this.lblRole.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblUsername.Location = new System.Drawing.Point(454, 23);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(105, 21);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "Username";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAddress
            // 
            this.lblAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblAddress.Location = new System.Drawing.Point(281, 23);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(167, 21);
            this.lblAddress.TabIndex = 3;
            this.lblAddress.Text = "Address";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUserId
            // 
            this.lblUserId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserId.AutoSize = true;
            this.lblUserId.BackColor = System.Drawing.Color.Transparent;
            this.lblUserId.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblUserId.Location = new System.Drawing.Point(3, 23);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(28, 21);
            this.lblUserId.TabIndex = 0;
            this.lblUserId.Text = "Id";
            this.lblUserId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblName.Location = new System.Drawing.Point(37, 23);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(167, 21);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UsersViewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainLayoutPanel);
            this.Name = "UsersViewControl";
            this.Size = new System.Drawing.Size(782, 553);
            this.pnlHeader.ResumeLayout(false);
            this.pnlTransactions.ResumeLayout(false);
            this.mainLayoutPanel.ResumeLayout(false);
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.paginationPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private Bunifu.UI.WinForms.BunifuPanel pnlHeader;
        private Bunifu.UI.WinForms.BunifuPanel pnlTransactions;
        private FlowLayoutPanel flwTransactions;
        private TextBox searchBox;
        private TableLayoutPanel mainLayoutPanel;
        private Panel searchPanel;
        private Button searchButton;
        private Panel paginationPanel;
        private Button sellButton;
        private Button firstPageBtn;
        private Button prevPageBtn;
        private Label pageLabel;
        private Button nextPageBtn;
        private Button lastPageBtn;
        private TableLayoutPanel tableLayoutPanel1;
        private ReaLTaiizor.BigLabel lblNumber;
        private ReaLTaiizor.BigLabel lblRole;
        private ReaLTaiizor.BigLabel lblUsername;
        private ReaLTaiizor.BigLabel lblAddress;
        private ReaLTaiizor.BigLabel lblUserId;
        private ReaLTaiizor.BigLabel lblName;
    }
}
