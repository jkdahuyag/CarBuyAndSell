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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MarketViewControl));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.mainLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.paginationPanel = new System.Windows.Forms.Panel();
            this.firstPageBtn = new System.Windows.Forms.Button();
            this.prevPageBtn = new System.Windows.Forms.Button();
            this.pageLabel = new System.Windows.Forms.Label();
            this.nextPageBtn = new System.Windows.Forms.Button();
            this.lastPageBtn = new System.Windows.Forms.Button();
            this.btnAddListing = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.pnlVehicles = new Bunifu.UI.WinForms.BunifuPanel();
            this.flwMarket = new System.Windows.Forms.FlowLayoutPanel();
            this.mainLayoutPanel.SuspendLayout();
            this.searchPanel.SuspendLayout();
            this.paginationPanel.SuspendLayout();
            this.bunifuPanel1.SuspendLayout();
            this.pnlVehicles.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainLayoutPanel
            // 
            this.mainLayoutPanel.ColumnCount = 1;
            this.mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 782F));
            this.mainLayoutPanel.Controls.Add(this.searchPanel, 0, 0);
            this.mainLayoutPanel.Controls.Add(this.paginationPanel, 0, 2);
            this.mainLayoutPanel.Controls.Add(this.bunifuPanel1, 0, 1);
            this.mainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainLayoutPanel.Name = "mainLayoutPanel";
            this.mainLayoutPanel.RowCount = 3;
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.mainLayoutPanel.Size = new System.Drawing.Size(782, 553);
            this.mainLayoutPanel.TabIndex = 1;
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
            this.searchButton.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(691, 9);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 25);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Search";
            // 
            // paginationPanel
            // 
            this.paginationPanel.Controls.Add(this.btnAddListing);
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
            this.firstPageBtn.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.prevPageBtn.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prevPageBtn.Location = new System.Drawing.Point(451, 0);
            this.prevPageBtn.Name = "prevPageBtn";
            this.prevPageBtn.Size = new System.Drawing.Size(75, 44);
            this.prevPageBtn.TabIndex = 0;
            this.prevPageBtn.Text = "Previous";
            // 
            // pageLabel
            // 
            this.pageLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.pageLabel.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.nextPageBtn.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextPageBtn.Location = new System.Drawing.Point(626, 0);
            this.nextPageBtn.Name = "nextPageBtn";
            this.nextPageBtn.Size = new System.Drawing.Size(75, 44);
            this.nextPageBtn.TabIndex = 1;
            this.nextPageBtn.Text = "Next";
            // 
            // lastPageBtn
            // 
            this.lastPageBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.lastPageBtn.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastPageBtn.Location = new System.Drawing.Point(701, 0);
            this.lastPageBtn.Name = "lastPageBtn";
            this.lastPageBtn.Size = new System.Drawing.Size(75, 44);
            this.lastPageBtn.TabIndex = 3;
            this.lastPageBtn.Text = "Last >>";
            // 
            // btnAddListing
            // 
            this.btnAddListing.AllowAnimations = true;
            this.btnAddListing.AllowMouseEffects = true;
            this.btnAddListing.AllowToggling = false;
            this.btnAddListing.AnimationSpeed = 200;
            this.btnAddListing.AutoGenerateColors = false;
            this.btnAddListing.AutoRoundBorders = false;
            this.btnAddListing.AutoSizeLeftIcon = true;
            this.btnAddListing.AutoSizeRightIcon = true;
            this.btnAddListing.BackColor = System.Drawing.Color.Transparent;
            this.btnAddListing.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnAddListing.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddListing.BackgroundImage")));
            this.btnAddListing.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddListing.ButtonText = "Add Vehicle";
            this.btnAddListing.ButtonTextMarginLeft = 0;
            this.btnAddListing.ColorContrastOnClick = 45;
            this.btnAddListing.ColorContrastOnHover = 45;
            this.btnAddListing.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnAddListing.CustomizableEdges = borderEdges1;
            this.btnAddListing.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddListing.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAddListing.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnAddListing.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnAddListing.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAddListing.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnAddListing.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddListing.ForeColor = System.Drawing.Color.White;
            this.btnAddListing.IconLeft = null;
            this.btnAddListing.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddListing.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddListing.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnAddListing.IconMarginLeft = 11;
            this.btnAddListing.IconPadding = 10;
            this.btnAddListing.IconRight = null;
            this.btnAddListing.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddListing.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddListing.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAddListing.IconSize = 25;
            this.btnAddListing.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnAddListing.IdleBorderRadius = 0;
            this.btnAddListing.IdleBorderThickness = 0;
            this.btnAddListing.IdleFillColor = System.Drawing.Color.Empty;
            this.btnAddListing.IdleIconLeftImage = null;
            this.btnAddListing.IdleIconRightImage = null;
            this.btnAddListing.IndicateFocus = false;
            this.btnAddListing.Location = new System.Drawing.Point(0, 0);
            this.btnAddListing.Name = "btnAddListing";
            this.btnAddListing.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAddListing.OnDisabledState.BorderRadius = 1;
            this.btnAddListing.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddListing.OnDisabledState.BorderThickness = 1;
            this.btnAddListing.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAddListing.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAddListing.OnDisabledState.IconLeftImage = null;
            this.btnAddListing.OnDisabledState.IconRightImage = null;
            this.btnAddListing.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnAddListing.onHoverState.BorderRadius = 1;
            this.btnAddListing.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddListing.onHoverState.BorderThickness = 1;
            this.btnAddListing.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnAddListing.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAddListing.onHoverState.IconLeftImage = null;
            this.btnAddListing.onHoverState.IconRightImage = null;
            this.btnAddListing.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnAddListing.OnIdleState.BorderRadius = 1;
            this.btnAddListing.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddListing.OnIdleState.BorderThickness = 1;
            this.btnAddListing.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnAddListing.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnAddListing.OnIdleState.IconLeftImage = null;
            this.btnAddListing.OnIdleState.IconRightImage = null;
            this.btnAddListing.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAddListing.OnPressedState.BorderRadius = 1;
            this.btnAddListing.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddListing.OnPressedState.BorderThickness = 1;
            this.btnAddListing.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAddListing.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAddListing.OnPressedState.IconLeftImage = null;
            this.btnAddListing.OnPressedState.IconRightImage = null;
            this.btnAddListing.Size = new System.Drawing.Size(150, 44);
            this.btnAddListing.TabIndex = 5;
            this.btnAddListing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddListing.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddListing.TextMarginLeft = 0;
            this.btnAddListing.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnAddListing.UseDefaultRadiusAndThickness = true;
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.pnlVehicles);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuPanel1.Location = new System.Drawing.Point(3, 53);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(776, 447);
            this.bunifuPanel1.TabIndex = 3;
            // 
            // pnlVehicles
            // 
            this.pnlVehicles.BackgroundColor = System.Drawing.Color.Transparent;
            this.pnlVehicles.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlVehicles.BackgroundImage")));
            this.pnlVehicles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlVehicles.BorderColor = System.Drawing.Color.Transparent;
            this.pnlVehicles.BorderRadius = 3;
            this.pnlVehicles.BorderThickness = 1;
            this.pnlVehicles.Controls.Add(this.flwMarket);
            this.pnlVehicles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlVehicles.Location = new System.Drawing.Point(0, 0);
            this.pnlVehicles.Name = "pnlVehicles";
            this.pnlVehicles.ShowBorders = true;
            this.pnlVehicles.Size = new System.Drawing.Size(776, 447);
            this.pnlVehicles.TabIndex = 4;
            // 
            // flwMarket
            // 
            this.flwMarket.AutoScroll = true;
            this.flwMarket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flwMarket.Location = new System.Drawing.Point(0, 0);
            this.flwMarket.Name = "flwMarket";
            this.flwMarket.Size = new System.Drawing.Size(776, 447);
            this.flwMarket.TabIndex = 0;
            // 
            // MarketViewControl
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
            this.bunifuPanel1.ResumeLayout(false);
            this.pnlVehicles.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel flwMarket;
        private TableLayoutPanel mainLayoutPanel;
        private Panel searchPanel;
        private TextBox searchBox;
        private Button searchButton;
        private Panel paginationPanel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAddListing;
        private Button firstPageBtn;
        private Button prevPageBtn;
        private Label pageLabel;
        private Button nextPageBtn;
        private Button lastPageBtn;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuPanel pnlVehicles;
    }
}
