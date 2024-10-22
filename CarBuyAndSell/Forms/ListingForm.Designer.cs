namespace CarBuyAndSell.Forms
{
    partial class ListingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListingForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties13 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties14 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties15 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties16 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.btnCancel = new ReaLTaiizor.Button();
            this.lblAskingPrice = new ReaLTaiizor.MoonLabel();
            this.lblDescription = new ReaLTaiizor.MoonLabel();
            this.btnSave = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.txtAskingPrice = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txtDescription = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblOwner = new ReaLTaiizor.BigLabel();
            this.lblValue = new ReaLTaiizor.BigLabel();
            this.lblBrandAndModel = new ReaLTaiizor.BigLabel();
            this.picBoxVehicleImage = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxVehicleImage)).BeginInit();
            this.SuspendLayout();
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
            this.btnCancel.Location = new System.Drawing.Point(731, 391);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnCancel.Size = new System.Drawing.Size(90, 29);
            this.btnCancel.TabIndex = 40;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // lblAskingPrice
            // 
            this.lblAskingPrice.AutoSize = true;
            this.lblAskingPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblAskingPrice.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAskingPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblAskingPrice.Location = new System.Drawing.Point(430, 332);
            this.lblAskingPrice.Name = "lblAskingPrice";
            this.lblAskingPrice.Size = new System.Drawing.Size(150, 21);
            this.lblAskingPrice.TabIndex = 26;
            this.lblAskingPrice.Text = "Asking Price: Php";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDescription.Location = new System.Drawing.Point(374, 21);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(103, 21);
            this.lblDescription.TabIndex = 25;
            this.lblDescription.Text = "Description";
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
            this.btnSave.Location = new System.Drawing.Point(621, 391);
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
            this.btnSave.TabIndex = 32;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSave.TextMarginLeft = 0;
            this.btnSave.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnSave.UseDefaultRadiusAndThickness = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
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
            this.txtAskingPrice.Location = new System.Drawing.Point(621, 322);
            this.txtAskingPrice.MaxLength = 32767;
            this.txtAskingPrice.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtAskingPrice.Modified = false;
            this.txtAskingPrice.Multiline = false;
            this.txtAskingPrice.Name = "txtAskingPrice";
            stateProperties9.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtAskingPrice.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtAskingPrice.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties11.FillColor = System.Drawing.Color.Empty;
            stateProperties11.ForeColor = System.Drawing.Color.Empty;
            stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtAskingPrice.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.Silver;
            stateProperties12.FillColor = System.Drawing.Color.MintCream;
            stateProperties12.ForeColor = System.Drawing.Color.Empty;
            stateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtAskingPrice.OnIdleState = stateProperties12;
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
            this.txtAskingPrice.TabIndex = 34;
            this.txtAskingPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAskingPrice.TextMarginBottom = 0;
            this.txtAskingPrice.TextMarginLeft = 3;
            this.txtAskingPrice.TextMarginTop = 1;
            this.txtAskingPrice.TextPlaceholder = "Enter text";
            this.txtAskingPrice.UseSystemPasswordChar = false;
            this.txtAskingPrice.WordWrap = true;
            // 
            // txtDescription
            // 
            this.txtDescription.AcceptsReturn = false;
            this.txtDescription.AcceptsTab = false;
            this.txtDescription.AnimationSpeed = 200;
            this.txtDescription.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtDescription.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtDescription.AutoSizeHeight = true;
            this.txtDescription.BackColor = System.Drawing.Color.Transparent;
            this.txtDescription.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtDescription.BackgroundImage")));
            this.txtDescription.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtDescription.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtDescription.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtDescription.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtDescription.BorderRadius = 10;
            this.txtDescription.BorderThickness = 1;
            this.txtDescription.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.txtDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescription.DefaultFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.DefaultText = "";
            this.txtDescription.FillColor = System.Drawing.Color.MintCream;
            this.txtDescription.HideSelection = true;
            this.txtDescription.IconLeft = null;
            this.txtDescription.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescription.IconPadding = 10;
            this.txtDescription.IconRight = null;
            this.txtDescription.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescription.Lines = new string[0];
            this.txtDescription.Location = new System.Drawing.Point(378, 54);
            this.txtDescription.MaxLength = 1024;
            this.txtDescription.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtDescription.Modified = false;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            stateProperties13.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties13.FillColor = System.Drawing.Color.Empty;
            stateProperties13.ForeColor = System.Drawing.Color.Empty;
            stateProperties13.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtDescription.OnActiveState = stateProperties13;
            stateProperties14.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties14.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties14.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtDescription.OnDisabledState = stateProperties14;
            stateProperties15.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties15.FillColor = System.Drawing.Color.Empty;
            stateProperties15.ForeColor = System.Drawing.Color.Empty;
            stateProperties15.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtDescription.OnHoverState = stateProperties15;
            stateProperties16.BorderColor = System.Drawing.Color.Silver;
            stateProperties16.FillColor = System.Drawing.Color.MintCream;
            stateProperties16.ForeColor = System.Drawing.Color.Empty;
            stateProperties16.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtDescription.OnIdleState = stateProperties16;
            this.txtDescription.Padding = new System.Windows.Forms.Padding(3);
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtDescription.PlaceholderText = "Enter text";
            this.txtDescription.ReadOnly = false;
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescription.SelectedText = "";
            this.txtDescription.SelectionLength = 0;
            this.txtDescription.SelectionStart = 0;
            this.txtDescription.ShortcutsEnabled = true;
            this.txtDescription.Size = new System.Drawing.Size(443, 245);
            this.txtDescription.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtDescription.TabIndex = 29;
            this.txtDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDescription.TextMarginBottom = 0;
            this.txtDescription.TextMarginLeft = 3;
            this.txtDescription.TextMarginTop = 1;
            this.txtDescription.TextPlaceholder = "Enter text";
            this.txtDescription.UseSystemPasswordChar = false;
            this.txtDescription.WordWrap = true;
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.lblOwner);
            this.bunifuPanel1.Controls.Add(this.lblValue);
            this.bunifuPanel1.Controls.Add(this.lblBrandAndModel);
            this.bunifuPanel1.Controls.Add(this.picBoxVehicleImage);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuPanel1.Location = new System.Drawing.Point(10, 10);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.Padding = new System.Windows.Forms.Padding(10, 30, 10, 10);
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(339, 463);
            this.bunifuPanel1.TabIndex = 0;
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
            this.lblOwner.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblValue
            // 
            this.lblValue.BackColor = System.Drawing.Color.Transparent;
            this.lblValue.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblValue.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblValue.Location = new System.Drawing.Point(10, 213);
            this.lblValue.Margin = new System.Windows.Forms.Padding(3, 20, 3, 10);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(319, 40);
            this.lblValue.TabIndex = 6;
            this.lblValue.Text = "bigLabel1";
            this.lblValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // ListingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(870, 483);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtAskingPrice);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblAskingPrice);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.bunifuPanel1);
            this.MaximumSize = new System.Drawing.Size(888, 530);
            this.MinimumSize = new System.Drawing.Size(888, 530);
            this.Name = "ListingForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "ListingForm";
            this.bunifuPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxVehicleImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private ReaLTaiizor.BigLabel lblOwner;
        private ReaLTaiizor.BigLabel lblValue;
        private ReaLTaiizor.BigLabel lblBrandAndModel;
        private Bunifu.UI.WinForms.BunifuPictureBox picBoxVehicleImage;
        private ReaLTaiizor.Button btnCancel;
        private Bunifu.UI.WinForms.BunifuTextBox txtAskingPrice;
        private Bunifu.UI.WinForms.BunifuTextBox txtDescription;
        private ReaLTaiizor.MoonLabel lblAskingPrice;
        private ReaLTaiizor.MoonLabel lblDescription;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnSave;
    }
}