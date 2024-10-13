using System.Windows.Forms;

namespace CarBuyAndSell
{
    partial class MarketViewControl
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
            this.mainLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.carTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.paginationPanel = new System.Windows.Forms.Panel();
            this.firstPageBtn = new System.Windows.Forms.Button();
            this.prevPageBtn = new System.Windows.Forms.Button();
            this.pageLabel = new System.Windows.Forms.Label();
            this.nextPageBtn = new System.Windows.Forms.Button();
            this.lastPageBtn = new System.Windows.Forms.Button();
            this.mainLayoutPanel.SuspendLayout();
            this.searchPanel.SuspendLayout();
            this.paginationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainLayoutPanel
            // 
            this.mainLayoutPanel.ColumnCount = 1;
            this.mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainLayoutPanel.Controls.Add(this.searchPanel, 0, 0);
            this.mainLayoutPanel.Controls.Add(this.carTableLayoutPanel, 0, 1);
            this.mainLayoutPanel.Controls.Add(this.paginationPanel, 0, 2);
            this.mainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainLayoutPanel.Name = "mainLayoutPanel";
            this.mainLayoutPanel.RowCount = 3;
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.mainLayoutPanel.Size = new System.Drawing.Size(782, 553);
            this.mainLayoutPanel.TabIndex = 0;
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
            // searchBox
            // 
            this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox.Location = new System.Drawing.Point(491, 10);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(200, 22);
            this.searchBox.TabIndex = 0;
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
            // carTableLayoutPanel
            // 
            this.carTableLayoutPanel.ColumnCount = 5;
            this.carTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.carTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.carTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.carTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.carTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.carTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.carTableLayoutPanel.Location = new System.Drawing.Point(3, 53);
            this.carTableLayoutPanel.Name = "carTableLayoutPanel";
            this.carTableLayoutPanel.RowCount = 2;
            this.carTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.carTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.carTableLayoutPanel.Size = new System.Drawing.Size(776, 447);
            this.carTableLayoutPanel.TabIndex = 1;
            // 
            // paginationPanel
            // 
            this.paginationPanel.Controls.Add(this.firstPageBtn);
            this.paginationPanel.Controls.Add(this.prevPageBtn);
            this.paginationPanel.Controls.Add(this.pageLabel);
            this.paginationPanel.Controls.Add(this.nextPageBtn);
            this.paginationPanel.Controls.Add(this.lastPageBtn);
            this.paginationPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paginationPanel.Location = new System.Drawing.Point(3, 506);
            this.paginationPanel.Name = "paginationPanel";
            this.paginationPanel.Size = new System.Drawing.Size(776, 44);
            this.paginationPanel.TabIndex = 2;
            // 
            // firstPageBtn
            // 
            this.firstPageBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.firstPageBtn.Location = new System.Drawing.Point(376, 0);
            this.firstPageBtn.Name = "firstPageBtn";
            this.firstPageBtn.Size = new System.Drawing.Size(75, 44);
            this.firstPageBtn.TabIndex = 0;
            this.firstPageBtn.Text = "<< First";
            // 
            // prevPageBtn
            // 
            this.prevPageBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.prevPageBtn.Enabled = false;
            this.prevPageBtn.Location = new System.Drawing.Point(451, 0);
            this.prevPageBtn.Name = "prevPageBtn";
            this.prevPageBtn.Size = new System.Drawing.Size(75, 44);
            this.prevPageBtn.TabIndex = 0;
            this.prevPageBtn.Text = "Previous";
            // 
            // pageLabel
            // 
            this.pageLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.pageLabel.Location = new System.Drawing.Point(526, 0);
            this.pageLabel.Name = "pageLabel";
            this.pageLabel.Size = new System.Drawing.Size(100, 44);
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
            this.nextPageBtn.Size = new System.Drawing.Size(75, 44);
            this.nextPageBtn.TabIndex = 1;
            this.nextPageBtn.Text = "Next";
            // 
            // lastPageBtn
            // 
            this.lastPageBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.lastPageBtn.Location = new System.Drawing.Point(701, 0);
            this.lastPageBtn.Name = "lastPageBtn";
            this.lastPageBtn.Size = new System.Drawing.Size(75, 44);
            this.lastPageBtn.TabIndex = 3;
            this.lastPageBtn.Text = "Last >>";
            // 
            // BuyViewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainLayoutPanel);
            this.Name = "MarketViewControl";
            this.Size = new System.Drawing.Size(782, 553);
            this.mainLayoutPanel.ResumeLayout(false);
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.paginationPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel carTableLayoutPanel;
        private System.Windows.Forms.Button firstPageBtn, prevPageBtn, nextPageBtn, lastPageBtn;
        private Label pageLabel;
        private TextBox searchBox;
        private System.Windows.Forms.Button searchButton;
        //private NumericUpDown pageSelector;
        private TableLayoutPanel mainLayoutPanel;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.Panel paginationPanel;
    }
}
