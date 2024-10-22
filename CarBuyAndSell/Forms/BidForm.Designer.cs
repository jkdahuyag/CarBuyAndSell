namespace CarBuyAndSell.Forms
{
    partial class BidForm
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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BidForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.btnSave = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.btnCancel = new ReaLTaiizor.Button();
            this.txtAskingPrice = new Bunifu.UI.WinForms.BunifuTextBox();
            this.lblTopBids = new ReaLTaiizor.MoonLabel();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblExpiryDate = new ReaLTaiizor.BigLabel();
            this.lblOwner = new ReaLTaiizor.BigLabel();
            this.lblAskingPrice = new ReaLTaiizor.BigLabel();
            this.lblBrandAndModel = new ReaLTaiizor.BigLabel();
            this.picBoxVehicleImage = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.lblBidAmount = new ReaLTaiizor.MoonLabel();
            this.pnlTopBids = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxVehicleImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.AllowAnimations = true;
            this.btnSave.AllowMouseEffects = true;
            this.btnSave.AllowToggling = false;
            this.btnSave.AnimationSpeed = 200;
            this.btnSave.AutoGenerateColors = false;
            this.btnSave.AutoRoundBorders = false;
            this.btnSave.AutoSizeLeftIcon = true;
            this.btnSave.AutoSizeRightIcon = true;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(175)))), ((int)(((byte)(0)))));
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnSave.ButtonText = "Save";
            this.btnSave.ButtonTextMarginLeft = 0;
            this.btnSave.ColorContrastOnClick = 45;
            this.btnSave.ColorContrastOnHover = 45;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnSave.CustomizableEdges = borderEdges2;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSave.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSave.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSave.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSave.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnSave.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnSave.IconMarginLeft = 11;
            this.btnSave.IconPadding = 10;
            this.btnSave.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnSave.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnSave.IconSize = 25;
            this.btnSave.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(175)))), ((int)(((byte)(0)))));
            this.btnSave.IdleBorderRadius = 10;
            this.btnSave.IdleBorderThickness = 1;
            this.btnSave.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(175)))), ((int)(((byte)(0)))));
            this.btnSave.IdleIconLeftImage = null;
            this.btnSave.IdleIconRightImage = null;
            this.btnSave.IndicateFocus = false;
            this.btnSave.Location = new System.Drawing.Point(823, 401);
            this.btnSave.Name = "btnSave";
            this.btnSave.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSave.OnDisabledState.BorderRadius = 10;
            this.btnSave.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnSave.OnDisabledState.BorderThickness = 1;
            this.btnSave.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSave.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSave.OnDisabledState.IconLeftImage = null;
            this.btnSave.OnDisabledState.IconRightImage = null;
            this.btnSave.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(175)))), ((int)(((byte)(0)))));
            this.btnSave.onHoverState.BorderRadius = 10;
            this.btnSave.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnSave.onHoverState.BorderThickness = 1;
            this.btnSave.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(175)))), ((int)(((byte)(0)))));
            this.btnSave.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnSave.onHoverState.IconLeftImage = null;
            this.btnSave.onHoverState.IconRightImage = null;
            this.btnSave.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(175)))), ((int)(((byte)(0)))));
            this.btnSave.OnIdleState.BorderRadius = 10;
            this.btnSave.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnSave.OnIdleState.BorderThickness = 1;
            this.btnSave.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(175)))), ((int)(((byte)(0)))));
            this.btnSave.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnSave.OnIdleState.IconLeftImage = null;
            this.btnSave.OnIdleState.IconRightImage = null;
            this.btnSave.OnPressedState.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnSave.OnPressedState.BorderRadius = 10;
            this.btnSave.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnSave.OnPressedState.BorderThickness = 1;
            this.btnSave.OnPressedState.FillColor = System.Drawing.Color.DarkOrange;
            this.btnSave.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnSave.OnPressedState.IconLeftImage = null;
            this.btnSave.OnPressedState.IconRightImage = null;
            this.btnSave.Size = new System.Drawing.Size(90, 29);
            this.btnSave.TabIndex = 45;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSave.TextMarginLeft = 0;
            this.btnSave.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnSave.UseDefaultRadiusAndThickness = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = null;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnCancel.Location = new System.Drawing.Point(933, 401);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnCancel.Size = new System.Drawing.Size(90, 29);
            this.btnCancel.TabIndex = 47;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // txtAskingPrice
            // 
            this.txtAskingPrice.AcceptsReturn = false;
            this.txtAskingPrice.AcceptsTab = false;
            this.txtAskingPrice.AnimationSpeed = 200;
            this.txtAskingPrice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtAskingPrice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtAskingPrice.AutoSizeHeight = true;
            this.txtAskingPrice.BackColor = System.Drawing.Color.Transparent;
            this.txtAskingPrice.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtAskingPrice.BackgroundImage")));
            this.txtAskingPrice.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtAskingPrice.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtAskingPrice.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtAskingPrice.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtAskingPrice.BorderRadius = 10;
            this.txtAskingPrice.BorderThickness = 1;
            this.txtAskingPrice.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.txtAskingPrice.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtAskingPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAskingPrice.DefaultFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAskingPrice.DefaultText = "";
            this.txtAskingPrice.FillColor = System.Drawing.Color.MintCream;
            this.txtAskingPrice.HideSelection = true;
            this.txtAskingPrice.IconLeft = null;
            this.txtAskingPrice.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAskingPrice.IconPadding = 10;
            this.txtAskingPrice.IconRight = null;
            this.txtAskingPrice.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAskingPrice.Lines = new string[0];
            this.txtAskingPrice.Location = new System.Drawing.Point(823, 332);
            this.txtAskingPrice.MaxLength = 32767;
            this.txtAskingPrice.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtAskingPrice.Modified = false;
            this.txtAskingPrice.Multiline = false;
            this.txtAskingPrice.Name = "txtAskingPrice";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtAskingPrice.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtAskingPrice.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtAskingPrice.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.MintCream;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtAskingPrice.OnIdleState = stateProperties8;
            this.txtAskingPrice.Padding = new System.Windows.Forms.Padding(3);
            this.txtAskingPrice.PasswordChar = '\0';
            this.txtAskingPrice.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtAskingPrice.PlaceholderText = "Enter text";
            this.txtAskingPrice.ReadOnly = false;
            this.txtAskingPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAskingPrice.SelectedText = "";
            this.txtAskingPrice.SelectionLength = 0;
            this.txtAskingPrice.SelectionStart = 0;
            this.txtAskingPrice.ShortcutsEnabled = true;
            this.txtAskingPrice.Size = new System.Drawing.Size(200, 41);
            this.txtAskingPrice.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtAskingPrice.TabIndex = 46;
            this.txtAskingPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAskingPrice.TextMarginBottom = 0;
            this.txtAskingPrice.TextMarginLeft = 3;
            this.txtAskingPrice.TextMarginTop = 1;
            this.txtAskingPrice.TextPlaceholder = "Enter text";
            this.txtAskingPrice.UseSystemPasswordChar = false;
            this.txtAskingPrice.WordWrap = true;
            // 
            // lblTopBids
            // 
            this.lblTopBids.AutoSize = true;
            this.lblTopBids.BackColor = System.Drawing.Color.Transparent;
            this.lblTopBids.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopBids.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTopBids.Location = new System.Drawing.Point(355, 30);
            this.lblTopBids.Name = "lblTopBids";
            this.lblTopBids.Size = new System.Drawing.Size(73, 21);
            this.lblTopBids.TabIndex = 42;
            this.lblTopBids.Text = "TopBids";
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.lblExpiryDate);
            this.bunifuPanel1.Controls.Add(this.lblOwner);
            this.bunifuPanel1.Controls.Add(this.lblAskingPrice);
            this.bunifuPanel1.Controls.Add(this.lblBrandAndModel);
            this.bunifuPanel1.Controls.Add(this.picBoxVehicleImage);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuPanel1.Location = new System.Drawing.Point(10, 10);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.Padding = new System.Windows.Forms.Padding(10, 30, 10, 10);
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(339, 463);
            this.bunifuPanel1.TabIndex = 41;
            // 
            // lblExpiryDate
            // 
            this.lblExpiryDate.BackColor = System.Drawing.Color.Transparent;
            this.lblExpiryDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblExpiryDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpiryDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblExpiryDate.Location = new System.Drawing.Point(10, 299);
            this.lblExpiryDate.Margin = new System.Windows.Forms.Padding(3, 20, 3, 10);
            this.lblExpiryDate.Name = "lblExpiryDate";
            this.lblExpiryDate.Size = new System.Drawing.Size(319, 46);
            this.lblExpiryDate.TabIndex = 8;
            this.lblExpiryDate.Text = "bigLabel1";
            this.lblExpiryDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOwner
            // 
            this.lblOwner.BackColor = System.Drawing.Color.Transparent;
            this.lblOwner.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblOwner.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblOwner.Location = new System.Drawing.Point(10, 253);
            this.lblOwner.Margin = new System.Windows.Forms.Padding(3, 20, 3, 10);
            this.lblOwner.Name = "lblOwner";
            this.lblOwner.Size = new System.Drawing.Size(319, 46);
            this.lblOwner.TabIndex = 7;
            this.lblOwner.Text = "bigLabel1";
            this.lblOwner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAskingPrice
            // 
            this.lblAskingPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblAskingPrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAskingPrice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAskingPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblAskingPrice.Location = new System.Drawing.Point(10, 213);
            this.lblAskingPrice.Margin = new System.Windows.Forms.Padding(3, 20, 3, 10);
            this.lblAskingPrice.Name = "lblAskingPrice";
            this.lblAskingPrice.Size = new System.Drawing.Size(319, 40);
            this.lblAskingPrice.TabIndex = 6;
            this.lblAskingPrice.Text = "bigLabel1";
            this.lblAskingPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBrandAndModel
            // 
            this.lblBrandAndModel.BackColor = System.Drawing.Color.Transparent;
            this.lblBrandAndModel.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBrandAndModel.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrandAndModel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblBrandAndModel.Location = new System.Drawing.Point(10, 177);
            this.lblBrandAndModel.Margin = new System.Windows.Forms.Padding(3, 20, 3, 10);
            this.lblBrandAndModel.Name = "lblBrandAndModel";
            this.lblBrandAndModel.Size = new System.Drawing.Size(319, 36);
            this.lblBrandAndModel.TabIndex = 5;
            this.lblBrandAndModel.Text = "bigLabel1";
            this.lblBrandAndModel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picBoxVehicleImage
            // 
            this.picBoxVehicleImage.AllowFocused = false;
            this.picBoxVehicleImage.AutoSizeHeight = false;
            this.picBoxVehicleImage.BorderRadius = 0;
            this.picBoxVehicleImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.picBoxVehicleImage.Image = ((System.Drawing.Image)(resources.GetObject("picBoxVehicleImage.Image")));
            this.picBoxVehicleImage.IsCircle = false;
            this.picBoxVehicleImage.Location = new System.Drawing.Point(10, 30);
            this.picBoxVehicleImage.Name = "picBoxVehicleImage";
            this.picBoxVehicleImage.Size = new System.Drawing.Size(319, 147);
            this.picBoxVehicleImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxVehicleImage.TabIndex = 4;
            this.picBoxVehicleImage.TabStop = false;
            this.picBoxVehicleImage.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Custom;
            // 
            // lblBidAmount
            // 
            this.lblBidAmount.AutoSize = true;
            this.lblBidAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblBidAmount.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBidAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblBidAmount.Location = new System.Drawing.Point(669, 340);
            this.lblBidAmount.Name = "lblBidAmount";
            this.lblBidAmount.Size = new System.Drawing.Size(148, 21);
            this.lblBidAmount.TabIndex = 43;
            this.lblBidAmount.Text = "Bid Amount: Php";
            // 
            // pnlTopBids
            // 
            this.pnlTopBids.AutoScroll = true;
            this.pnlTopBids.BackgroundColor = System.Drawing.Color.MintCream;
            this.pnlTopBids.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlTopBids.BackgroundImage")));
            this.pnlTopBids.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTopBids.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlTopBids.BorderRadius = 3;
            this.pnlTopBids.BorderThickness = 1;
            this.pnlTopBids.Location = new System.Drawing.Point(359, 54);
            this.pnlTopBids.Name = "pnlTopBids";
            this.pnlTopBids.Padding = new System.Windows.Forms.Padding(5);
            this.pnlTopBids.ShowBorders = true;
            this.pnlTopBids.Size = new System.Drawing.Size(664, 245);
            this.pnlTopBids.TabIndex = 48;
            // 
            // BidForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1035, 483);
            this.Controls.Add(this.pnlTopBids);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtAskingPrice);
            this.Controls.Add(this.lblBidAmount);
            this.Controls.Add(this.lblTopBids);
            this.Controls.Add(this.bunifuPanel1);
            this.MaximumSize = new System.Drawing.Size(1053, 530);
            this.MinimumSize = new System.Drawing.Size(1053, 530);
            this.Name = "BidForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "BidForm";
            this.bunifuPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxVehicleImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnSave;
        private ReaLTaiizor.Button btnCancel;
        private Bunifu.UI.WinForms.BunifuTextBox txtAskingPrice;
        private ReaLTaiizor.MoonLabel lblTopBids;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private ReaLTaiizor.BigLabel lblOwner;
        private ReaLTaiizor.BigLabel lblAskingPrice;
        private ReaLTaiizor.BigLabel lblBrandAndModel;
        private Bunifu.UI.WinForms.BunifuPictureBox picBoxVehicleImage;
        private ReaLTaiizor.MoonLabel lblBidAmount;
        private ReaLTaiizor.BigLabel lblExpiryDate;
        private Bunifu.UI.WinForms.BunifuPanel pnlTopBids;
    }
}