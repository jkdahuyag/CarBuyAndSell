using System.Windows.Forms;

namespace CarBuyAndSell
{
    partial class BidsViewControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BidsViewControl));
            this.searchBox = new System.Windows.Forms.TextBox();
            this.mainLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.searchButton = new System.Windows.Forms.Button();
            this.paginationPanel = new System.Windows.Forms.Panel();
            this.firstPageBtn = new System.Windows.Forms.Button();
            this.prevPageBtn = new System.Windows.Forms.Button();
            this.pageLabel = new System.Windows.Forms.Label();
            this.nextPageBtn = new System.Windows.Forms.Button();
            this.lastPageBtn = new System.Windows.Forms.Button();
            this.pnlTransactions = new Bunifu.UI.WinForms.BunifuPanel();
            this.pnlBids = new System.Windows.Forms.Panel();
            this.pnlHeader = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bigLabel1 = new ReaLTaiizor.BigLabel();
            this.bigLabel3 = new ReaLTaiizor.BigLabel();
            this.bigLabel2 = new ReaLTaiizor.BigLabel();
            this.lblBuyer = new ReaLTaiizor.BigLabel();
            this.mainLayoutPanel.SuspendLayout();
            this.searchPanel.SuspendLayout();
            this.paginationPanel.SuspendLayout();
            this.pnlTransactions.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
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
            // pnlTransactions
            // 
            this.pnlTransactions.BackgroundColor = System.Drawing.Color.MintCream;
            this.pnlTransactions.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlTransactions.BackgroundImage")));
            this.pnlTransactions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTransactions.BorderColor = System.Drawing.Color.Transparent;
            this.pnlTransactions.BorderRadius = 3;
            this.pnlTransactions.BorderThickness = 1;
            this.pnlTransactions.Controls.Add(this.pnlBids);
            this.pnlTransactions.Controls.Add(this.pnlHeader);
            this.pnlTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTransactions.Location = new System.Drawing.Point(3, 53);
            this.pnlTransactions.Name = "pnlTransactions";
            this.pnlTransactions.ShowBorders = true;
            this.pnlTransactions.Size = new System.Drawing.Size(776, 437);
            this.pnlTransactions.TabIndex = 3;
            // 
            // pnlBids
            // 
            this.pnlBids.BackColor = System.Drawing.Color.Transparent;
            this.pnlBids.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBids.Location = new System.Drawing.Point(0, 64);
            this.pnlBids.Name = "pnlBids";
            this.pnlBids.Size = new System.Drawing.Size(776, 373);
            this.pnlBids.TabIndex = 5;
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
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator1.BackgroundImage")));
            this.bunifuSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator1.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.Silver;
            this.bunifuSeparator1.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator1.LineThickness = 5;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 44);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator1.Size = new System.Drawing.Size(776, 38);
            this.bunifuSeparator1.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.12987F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.21069F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.82972F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.82972F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 146F));
            this.tableLayoutPanel1.Controls.Add(this.bigLabel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.bigLabel3, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.bigLabel2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblBuyer, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(776, 44);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // bigLabel1
            // 
            this.bigLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel1.Location = new System.Drawing.Point(98, 23);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(228, 21);
            this.bigLabel1.TabIndex = 2;
            this.bigLabel1.Text = "Bidder";
            this.bigLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bigLabel3
            // 
            this.bigLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bigLabel3.AutoSize = true;
            this.bigLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel3.Location = new System.Drawing.Point(482, 23);
            this.bigLabel3.Name = "bigLabel3";
            this.bigLabel3.Size = new System.Drawing.Size(144, 21);
            this.bigLabel3.TabIndex = 4;
            this.bigLabel3.Text = "Date";
            this.bigLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bigLabel2
            // 
            this.bigLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bigLabel2.AutoSize = true;
            this.bigLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel2.Location = new System.Drawing.Point(332, 23);
            this.bigLabel2.Name = "bigLabel2";
            this.bigLabel2.Size = new System.Drawing.Size(144, 21);
            this.bigLabel2.TabIndex = 3;
            this.bigLabel2.Text = "Amount";
            this.bigLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBuyer
            // 
            this.lblBuyer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBuyer.AutoSize = true;
            this.lblBuyer.BackColor = System.Drawing.Color.Transparent;
            this.lblBuyer.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuyer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblBuyer.Location = new System.Drawing.Point(3, 23);
            this.lblBuyer.Name = "lblBuyer";
            this.lblBuyer.Size = new System.Drawing.Size(89, 21);
            this.lblBuyer.TabIndex = 1;
            this.lblBuyer.Text = "Listing Id";
            this.lblBuyer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BidsViewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainLayoutPanel);
            this.Name = "BidsViewControl";
            this.Size = new System.Drawing.Size(782, 553);
            this.mainLayoutPanel.ResumeLayout(false);
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.paginationPanel.ResumeLayout(false);
            this.pnlTransactions.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private ReaLTaiizor.BigLabel bigLabel1;
        private ReaLTaiizor.BigLabel bigLabel3;
        private ReaLTaiizor.BigLabel bigLabel2;
        private ReaLTaiizor.BigLabel lblBuyer;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private Bunifu.UI.WinForms.BunifuPanel pnlHeader;
        private Bunifu.UI.WinForms.BunifuPanel pnlTransactions;
        private TextBox searchBox;
        private TableLayoutPanel mainLayoutPanel;
        private Panel searchPanel;
        private Button searchButton;
        private Panel paginationPanel;
        private Button firstPageBtn;
        private Button prevPageBtn;
        private Label pageLabel;
        private Button nextPageBtn;
        private Button lastPageBtn;
        private Panel pnlBids;
    }
}
