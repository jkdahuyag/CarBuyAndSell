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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionsViewControl));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.paginationPanel = new System.Windows.Forms.Panel();
            this.btnMakeTransaction = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.firstPageBtn = new System.Windows.Forms.Button();
            this.prevPageBtn = new System.Windows.Forms.Button();
            this.pageLabel = new System.Windows.Forms.Label();
            this.nextPageBtn = new System.Windows.Forms.Button();
            this.lastPageBtn = new System.Windows.Forms.Button();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.mainLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.pnlTransactions = new Bunifu.UI.WinForms.BunifuPanel();
            this.pnlTransactionsTable = new System.Windows.Forms.Panel();
            this.pnlHeader = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bigLabel4 = new ReaLTaiizor.BigLabel();
            this.bigLabel1 = new ReaLTaiizor.BigLabel();
            this.bigLabel3 = new ReaLTaiizor.BigLabel();
            this.bigLabel2 = new ReaLTaiizor.BigLabel();
            this.lblTransactionId = new ReaLTaiizor.BigLabel();
            this.lblBuyer = new ReaLTaiizor.BigLabel();
            this.paginationPanel.SuspendLayout();
            this.searchPanel.SuspendLayout();
            this.mainLayoutPanel.SuspendLayout();
            this.pnlTransactions.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // paginationPanel
            // 
            this.paginationPanel.Controls.Add(this.btnMakeTransaction);
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
            // btnMakeTransaction
            // 
            this.btnMakeTransaction.AllowAnimations = true;
            this.btnMakeTransaction.AllowMouseEffects = true;
            this.btnMakeTransaction.AllowToggling = false;
            this.btnMakeTransaction.AnimationSpeed = 200;
            this.btnMakeTransaction.AutoGenerateColors = false;
            this.btnMakeTransaction.AutoRoundBorders = false;
            this.btnMakeTransaction.AutoSizeLeftIcon = true;
            this.btnMakeTransaction.AutoSizeRightIcon = true;
            this.btnMakeTransaction.BackColor = System.Drawing.Color.Transparent;
            this.btnMakeTransaction.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnMakeTransaction.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMakeTransaction.BackgroundImage")));
            this.btnMakeTransaction.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnMakeTransaction.ButtonText = "Send Money";
            this.btnMakeTransaction.ButtonTextMarginLeft = 0;
            this.btnMakeTransaction.ColorContrastOnClick = 45;
            this.btnMakeTransaction.ColorContrastOnHover = 45;
            this.btnMakeTransaction.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnMakeTransaction.CustomizableEdges = borderEdges1;
            this.btnMakeTransaction.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMakeTransaction.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnMakeTransaction.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnMakeTransaction.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnMakeTransaction.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMakeTransaction.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnMakeTransaction.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakeTransaction.ForeColor = System.Drawing.Color.White;
            this.btnMakeTransaction.IconLeft = null;
            this.btnMakeTransaction.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMakeTransaction.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnMakeTransaction.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnMakeTransaction.IconMarginLeft = 11;
            this.btnMakeTransaction.IconPadding = 10;
            this.btnMakeTransaction.IconRight = null;
            this.btnMakeTransaction.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMakeTransaction.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnMakeTransaction.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnMakeTransaction.IconSize = 25;
            this.btnMakeTransaction.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnMakeTransaction.IdleBorderRadius = 0;
            this.btnMakeTransaction.IdleBorderThickness = 0;
            this.btnMakeTransaction.IdleFillColor = System.Drawing.Color.Empty;
            this.btnMakeTransaction.IdleIconLeftImage = null;
            this.btnMakeTransaction.IdleIconRightImage = null;
            this.btnMakeTransaction.IndicateFocus = false;
            this.btnMakeTransaction.Location = new System.Drawing.Point(0, 0);
            this.btnMakeTransaction.Name = "btnMakeTransaction";
            this.btnMakeTransaction.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnMakeTransaction.OnDisabledState.BorderRadius = 1;
            this.btnMakeTransaction.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnMakeTransaction.OnDisabledState.BorderThickness = 1;
            this.btnMakeTransaction.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnMakeTransaction.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnMakeTransaction.OnDisabledState.IconLeftImage = null;
            this.btnMakeTransaction.OnDisabledState.IconRightImage = null;
            this.btnMakeTransaction.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnMakeTransaction.onHoverState.BorderRadius = 1;
            this.btnMakeTransaction.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnMakeTransaction.onHoverState.BorderThickness = 1;
            this.btnMakeTransaction.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnMakeTransaction.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnMakeTransaction.onHoverState.IconLeftImage = null;
            this.btnMakeTransaction.onHoverState.IconRightImage = null;
            this.btnMakeTransaction.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnMakeTransaction.OnIdleState.BorderRadius = 1;
            this.btnMakeTransaction.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnMakeTransaction.OnIdleState.BorderThickness = 1;
            this.btnMakeTransaction.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnMakeTransaction.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnMakeTransaction.OnIdleState.IconLeftImage = null;
            this.btnMakeTransaction.OnIdleState.IconRightImage = null;
            this.btnMakeTransaction.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnMakeTransaction.OnPressedState.BorderRadius = 1;
            this.btnMakeTransaction.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnMakeTransaction.OnPressedState.BorderThickness = 1;
            this.btnMakeTransaction.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnMakeTransaction.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnMakeTransaction.OnPressedState.IconLeftImage = null;
            this.btnMakeTransaction.OnPressedState.IconRightImage = null;
            this.btnMakeTransaction.Size = new System.Drawing.Size(150, 54);
            this.btnMakeTransaction.TabIndex = 4;
            this.btnMakeTransaction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMakeTransaction.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnMakeTransaction.TextMarginLeft = 0;
            this.btnMakeTransaction.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnMakeTransaction.UseDefaultRadiusAndThickness = true;
            this.btnMakeTransaction.Click += new System.EventHandler(this.BtnMakeTransaction_Click);
            // 
            // firstPageBtn
            // 
            this.firstPageBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.firstPageBtn.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.prevPageBtn.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prevPageBtn.Location = new System.Drawing.Point(451, 0);
            this.prevPageBtn.Name = "prevPageBtn";
            this.prevPageBtn.Size = new System.Drawing.Size(75, 54);
            this.prevPageBtn.TabIndex = 0;
            this.prevPageBtn.Text = "Previous";
            // 
            // pageLabel
            // 
            this.pageLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.pageLabel.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.nextPageBtn.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextPageBtn.Location = new System.Drawing.Point(626, 0);
            this.nextPageBtn.Name = "nextPageBtn";
            this.nextPageBtn.Size = new System.Drawing.Size(75, 54);
            this.nextPageBtn.TabIndex = 1;
            this.nextPageBtn.Text = "Next";
            // 
            // lastPageBtn
            // 
            this.lastPageBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.lastPageBtn.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastPageBtn.Location = new System.Drawing.Point(701, 0);
            this.lastPageBtn.Name = "lastPageBtn";
            this.lastPageBtn.Size = new System.Drawing.Size(75, 54);
            this.lastPageBtn.TabIndex = 3;
            this.lastPageBtn.Text = "Last >>";
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
            this.mainLayoutPanel.TabIndex = 2;
            // 
            // pnlTransactions
            // 
            this.pnlTransactions.BackgroundColor = System.Drawing.Color.MintCream;
            this.pnlTransactions.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlTransactions.BackgroundImage")));
            this.pnlTransactions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTransactions.BorderColor = System.Drawing.Color.Transparent;
            this.pnlTransactions.BorderRadius = 3;
            this.pnlTransactions.BorderThickness = 1;
            this.pnlTransactions.Controls.Add(this.pnlTransactionsTable);
            this.pnlTransactions.Controls.Add(this.pnlHeader);
            this.pnlTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTransactions.Location = new System.Drawing.Point(3, 53);
            this.pnlTransactions.Name = "pnlTransactions";
            this.pnlTransactions.ShowBorders = true;
            this.pnlTransactions.Size = new System.Drawing.Size(776, 437);
            this.pnlTransactions.TabIndex = 3;
            // 
            // pnlTransactionsTable
            // 
            this.pnlTransactionsTable.BackColor = System.Drawing.Color.Transparent;
            this.pnlTransactionsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTransactionsTable.Location = new System.Drawing.Point(0, 64);
            this.pnlTransactionsTable.Name = "pnlTransactionsTable";
            this.pnlTransactionsTable.Size = new System.Drawing.Size(776, 373);
            this.pnlTransactionsTable.TabIndex = 5;
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
            this.bunifuSeparator1.Size = new System.Drawing.Size(776, 39);
            this.bunifuSeparator1.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.055611F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.27806F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.27806F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.18807F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.18807F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.01213F));
            this.tableLayoutPanel1.Controls.Add(this.bigLabel4, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.bigLabel1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.bigLabel3, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.bigLabel2, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTransactionId, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblBuyer, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(776, 44);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // bigLabel4
            // 
            this.bigLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bigLabel4.AutoSize = true;
            this.bigLabel4.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel4.Location = new System.Drawing.Point(684, 23);
            this.bigLabel4.Name = "bigLabel4";
            this.bigLabel4.Size = new System.Drawing.Size(89, 21);
            this.bigLabel4.TabIndex = 5;
            this.bigLabel4.Text = "Method";
            this.bigLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bigLabel1
            // 
            this.bigLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel1.Location = new System.Drawing.Point(238, 23);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(190, 21);
            this.bigLabel1.TabIndex = 2;
            this.bigLabel1.Text = "Seller";
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
            this.bigLabel3.Location = new System.Drawing.Point(559, 23);
            this.bigLabel3.Name = "bigLabel3";
            this.bigLabel3.Size = new System.Drawing.Size(119, 21);
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
            this.bigLabel2.Location = new System.Drawing.Point(434, 23);
            this.bigLabel2.Name = "bigLabel2";
            this.bigLabel2.Size = new System.Drawing.Size(119, 21);
            this.bigLabel2.TabIndex = 3;
            this.bigLabel2.Text = "Amount";
            this.bigLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTransactionId
            // 
            this.lblTransactionId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTransactionId.AutoSize = true;
            this.lblTransactionId.BackColor = System.Drawing.Color.Transparent;
            this.lblTransactionId.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblTransactionId.Location = new System.Drawing.Point(3, 23);
            this.lblTransactionId.Name = "lblTransactionId";
            this.lblTransactionId.Size = new System.Drawing.Size(33, 21);
            this.lblTransactionId.TabIndex = 0;
            this.lblTransactionId.Text = "Id";
            this.lblTransactionId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBuyer
            // 
            this.lblBuyer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBuyer.AutoSize = true;
            this.lblBuyer.BackColor = System.Drawing.Color.Transparent;
            this.lblBuyer.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuyer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblBuyer.Location = new System.Drawing.Point(42, 23);
            this.lblBuyer.Name = "lblBuyer";
            this.lblBuyer.Size = new System.Drawing.Size(190, 21);
            this.lblBuyer.TabIndex = 1;
            this.lblBuyer.Text = "Buyer";
            this.lblBuyer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TransactionsViewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.mainLayoutPanel);
            this.Name = "TransactionsViewControl";
            this.Size = new System.Drawing.Size(782, 553);
            this.paginationPanel.ResumeLayout(false);
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.mainLayoutPanel.ResumeLayout(false);
            this.pnlTransactions.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paginationPanel;
        private System.Windows.Forms.Button firstPageBtn;
        private System.Windows.Forms.Button prevPageBtn;
        private System.Windows.Forms.Label pageLabel;
        private System.Windows.Forms.Button nextPageBtn;
        private System.Windows.Forms.Button lastPageBtn;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TableLayoutPanel mainLayoutPanel;
        private Bunifu.UI.WinForms.BunifuPanel pnlTransactions;
        private Bunifu.UI.WinForms.BunifuPanel pnlHeader;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ReaLTaiizor.BigLabel bigLabel4;
        private ReaLTaiizor.BigLabel bigLabel1;
        private ReaLTaiizor.BigLabel bigLabel3;
        private ReaLTaiizor.BigLabel bigLabel2;
        private ReaLTaiizor.BigLabel lblTransactionId;
        private ReaLTaiizor.BigLabel lblBuyer;
        private System.Windows.Forms.Panel pnlTransactionsTable;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnMakeTransaction;
    }
}
