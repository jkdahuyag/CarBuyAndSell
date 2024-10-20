namespace CarBuyAndSell.UserControls
{
    partial class TransactionsViewControl
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
            this.paginationPanel = new System.Windows.Forms.Panel();
            this.lastPageBtn = new System.Windows.Forms.Button();
            this.nextPageBtn = new System.Windows.Forms.Button();
            this.pageLabel = new System.Windows.Forms.Label();
            this.prevPageBtn = new System.Windows.Forms.Button();
            this.firstPageBtn = new System.Windows.Forms.Button();
            this.sellButton = new System.Windows.Forms.Button();
            this.carsDataGridView = new System.Windows.Forms.DataGridView();
            this.deleteButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.editButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.mainLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.paginationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carsDataGridView)).BeginInit();
            this.searchPanel.SuspendLayout();
            this.mainLayoutPanel.SuspendLayout();
            this.SuspendLayout();
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
            // lastPageBtn
            // 
            this.lastPageBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.lastPageBtn.Location = new System.Drawing.Point(701, 0);
            this.lastPageBtn.Name = "lastPageBtn";
            this.lastPageBtn.Size = new System.Drawing.Size(75, 54);
            this.lastPageBtn.TabIndex = 3;
            this.lastPageBtn.Text = "Last >>";
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
            // firstPageBtn
            // 
            this.firstPageBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.firstPageBtn.Location = new System.Drawing.Point(376, 0);
            this.firstPageBtn.Name = "firstPageBtn";
            this.firstPageBtn.Size = new System.Drawing.Size(75, 54);
            this.firstPageBtn.TabIndex = 0;
            this.firstPageBtn.Text = "<< First";
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
            // carsDataGridView
            // 
            this.carsDataGridView.AllowUserToAddRows = false;
            this.carsDataGridView.ColumnHeadersHeight = 29;
            this.carsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.editButton,
            this.deleteButton});
            this.carsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.carsDataGridView.Location = new System.Drawing.Point(3, 53);
            this.carsDataGridView.Name = "carsDataGridView";
            this.carsDataGridView.RowHeadersWidth = 51;
            this.carsDataGridView.Size = new System.Drawing.Size(776, 437);
            this.carsDataGridView.TabIndex = 1;
            // 
            // deleteButton
            // 
            this.deleteButton.HeaderText = "";
            this.deleteButton.MinimumWidth = 6;
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseColumnTextForButtonValue = true;
            this.deleteButton.Width = 125;
            // 
            // editButton
            // 
            this.editButton.HeaderText = "";
            this.editButton.MinimumWidth = 6;
            this.editButton.Name = "editButton";
            this.editButton.Text = "Edit";
            this.editButton.UseColumnTextForButtonValue = true;
            this.editButton.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
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
            this.mainLayoutPanel.Controls.Add(this.carsDataGridView, 0, 1);
            this.mainLayoutPanel.Controls.Add(this.paginationPanel, 0, 2);
            this.mainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainLayoutPanel.Name = "mainLayoutPanel";
            this.mainLayoutPanel.RowCount = 3;
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.mainLayoutPanel.Size = new System.Drawing.Size(782, 553);
            this.mainLayoutPanel.TabIndex = 2;
            // 
            // TransactionsViewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainLayoutPanel);
            this.Name = "TransactionsViewControl";
            this.Size = new System.Drawing.Size(782, 553);
            this.paginationPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.carsDataGridView)).EndInit();
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.mainLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paginationPanel;
        private System.Windows.Forms.Button sellButton;
        private System.Windows.Forms.Button firstPageBtn;
        private System.Windows.Forms.Button prevPageBtn;
        private System.Windows.Forms.Label pageLabel;
        private System.Windows.Forms.Button nextPageBtn;
        private System.Windows.Forms.Button lastPageBtn;
        private System.Windows.Forms.DataGridView carsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewButtonColumn editButton;
        private System.Windows.Forms.DataGridViewButtonColumn deleteButton;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TableLayoutPanel mainLayoutPanel;
    }
}
