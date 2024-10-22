using ReaLTaiizor;
using System.Windows.Forms;

namespace CarBuyAndSell
{
    partial class VehiclesViewControl
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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VehiclesViewControl));
            this.mainLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.paginationPanel = new System.Windows.Forms.Panel();
            this.btnAddVehicle = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.firstPageBtn = new System.Windows.Forms.Button();
            this.prevPageBtn = new System.Windows.Forms.Button();
            this.pageLabel = new System.Windows.Forms.Label();
            this.nextPageBtn = new System.Windows.Forms.Button();
            this.lastPageBtn = new System.Windows.Forms.Button();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.pnlVehicles = new Bunifu.UI.WinForms.BunifuPanel();
            this.flwVehicles = new System.Windows.Forms.FlowLayoutPanel();
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
            this.searchButton.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(691, 9);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 25);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Search";
            // 
            // paginationPanel
            // 
            this.paginationPanel.Controls.Add(this.btnAddVehicle);
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
            // btnAddVehicle
            // 
            this.btnAddVehicle.AllowAnimations = true;
            this.btnAddVehicle.AllowMouseEffects = true;
            this.btnAddVehicle.AllowToggling = false;
            this.btnAddVehicle.AnimationSpeed = 200;
            this.btnAddVehicle.AutoGenerateColors = false;
            this.btnAddVehicle.AutoRoundBorders = false;
            this.btnAddVehicle.AutoSizeLeftIcon = true;
            this.btnAddVehicle.AutoSizeRightIcon = true;
            this.btnAddVehicle.BackColor = System.Drawing.Color.Transparent;
            this.btnAddVehicle.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnAddVehicle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddVehicle.BackgroundImage")));
            this.btnAddVehicle.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddVehicle.ButtonText = "Add Vehicle";
            this.btnAddVehicle.ButtonTextMarginLeft = 0;
            this.btnAddVehicle.ColorContrastOnClick = 45;
            this.btnAddVehicle.ColorContrastOnHover = 45;
            this.btnAddVehicle.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnAddVehicle.CustomizableEdges = borderEdges2;
            this.btnAddVehicle.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddVehicle.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAddVehicle.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnAddVehicle.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnAddVehicle.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAddVehicle.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnAddVehicle.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddVehicle.ForeColor = System.Drawing.Color.White;
            this.btnAddVehicle.IconLeft = null;
            this.btnAddVehicle.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddVehicle.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddVehicle.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnAddVehicle.IconMarginLeft = 11;
            this.btnAddVehicle.IconPadding = 10;
            this.btnAddVehicle.IconRight = null;
            this.btnAddVehicle.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddVehicle.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddVehicle.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAddVehicle.IconSize = 25;
            this.btnAddVehicle.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnAddVehicle.IdleBorderRadius = 0;
            this.btnAddVehicle.IdleBorderThickness = 0;
            this.btnAddVehicle.IdleFillColor = System.Drawing.Color.Empty;
            this.btnAddVehicle.IdleIconLeftImage = null;
            this.btnAddVehicle.IdleIconRightImage = null;
            this.btnAddVehicle.IndicateFocus = false;
            this.btnAddVehicle.Location = new System.Drawing.Point(0, 0);
            this.btnAddVehicle.Name = "btnAddVehicle";
            this.btnAddVehicle.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAddVehicle.OnDisabledState.BorderRadius = 5;
            this.btnAddVehicle.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddVehicle.OnDisabledState.BorderThickness = 1;
            this.btnAddVehicle.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAddVehicle.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAddVehicle.OnDisabledState.IconLeftImage = null;
            this.btnAddVehicle.OnDisabledState.IconRightImage = null;
            this.btnAddVehicle.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnAddVehicle.onHoverState.BorderRadius = 5;
            this.btnAddVehicle.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddVehicle.onHoverState.BorderThickness = 1;
            this.btnAddVehicle.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnAddVehicle.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAddVehicle.onHoverState.IconLeftImage = null;
            this.btnAddVehicle.onHoverState.IconRightImage = null;
            this.btnAddVehicle.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnAddVehicle.OnIdleState.BorderRadius = 5;
            this.btnAddVehicle.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddVehicle.OnIdleState.BorderThickness = 1;
            this.btnAddVehicle.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnAddVehicle.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnAddVehicle.OnIdleState.IconLeftImage = null;
            this.btnAddVehicle.OnIdleState.IconRightImage = null;
            this.btnAddVehicle.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAddVehicle.OnPressedState.BorderRadius = 5;
            this.btnAddVehicle.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddVehicle.OnPressedState.BorderThickness = 1;
            this.btnAddVehicle.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAddVehicle.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAddVehicle.OnPressedState.IconLeftImage = null;
            this.btnAddVehicle.OnPressedState.IconRightImage = null;
            this.btnAddVehicle.Size = new System.Drawing.Size(150, 44);
            this.btnAddVehicle.TabIndex = 5;
            this.btnAddVehicle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddVehicle.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddVehicle.TextMarginLeft = 0;
            this.btnAddVehicle.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnAddVehicle.UseDefaultRadiusAndThickness = true;
            this.btnAddVehicle.Click += new System.EventHandler(this.BtnAddVehicle_Click);
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
            this.pnlVehicles.Controls.Add(this.flwVehicles);
            this.pnlVehicles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlVehicles.Location = new System.Drawing.Point(0, 0);
            this.pnlVehicles.Name = "pnlVehicles";
            this.pnlVehicles.ShowBorders = true;
            this.pnlVehicles.Size = new System.Drawing.Size(776, 447);
            this.pnlVehicles.TabIndex = 4;
            // 
            // flwVehicles
            // 
            this.flwVehicles.AutoScroll = true;
            this.flwVehicles.BackColor = System.Drawing.Color.MintCream;
            this.flwVehicles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flwVehicles.Location = new System.Drawing.Point(0, 0);
            this.flwVehicles.Name = "flwVehicles";
            this.flwVehicles.Size = new System.Drawing.Size(776, 447);
            this.flwVehicles.TabIndex = 0;
            // 
            // VehiclesViewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainLayoutPanel);
            this.Name = "VehiclesViewControl";
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
        private System.Windows.Forms.Button firstPageBtn, prevPageBtn, nextPageBtn, lastPageBtn;
        private Label pageLabel;
        private TextBox searchBox;
        private System.Windows.Forms.Button searchButton;
        //private NumericUpDown pageSelector;
        private TableLayoutPanel mainLayoutPanel;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.Panel paginationPanel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAddVehicle;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuPanel pnlVehicles;
        private FlowLayoutPanel flwVehicles;
    }
}
