namespace CarBuyAndSell.Cards
{
    partial class ListingCardView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListingCardView));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            this.bunifuShadowPanel1 = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.btnBid = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.lblOwner = new ReaLTaiizor.BigLabel();
            this.lblValue = new ReaLTaiizor.BigLabel();
            this.lblBrandAndModel = new ReaLTaiizor.BigLabel();
            this.pcBoxVehicleImage = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.bunifuShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxVehicleImage)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuShadowPanel1
            // 
            this.bunifuShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuShadowPanel1.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuShadowPanel1.BorderRadius = 3;
            this.bunifuShadowPanel1.BorderThickness = 1;
            this.bunifuShadowPanel1.Controls.Add(this.btnBid);
            this.bunifuShadowPanel1.Controls.Add(this.lblOwner);
            this.bunifuShadowPanel1.Controls.Add(this.lblValue);
            this.bunifuShadowPanel1.Controls.Add(this.lblBrandAndModel);
            this.bunifuShadowPanel1.Controls.Add(this.pcBoxVehicleImage);
            this.bunifuShadowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuShadowPanel1.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            this.bunifuShadowPanel1.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            this.bunifuShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuShadowPanel1.Name = "bunifuShadowPanel1";
            this.bunifuShadowPanel1.Padding = new System.Windows.Forms.Padding(15);
            this.bunifuShadowPanel1.PanelColor = System.Drawing.Color.MintCream;
            this.bunifuShadowPanel1.PanelColor2 = System.Drawing.Color.MintCream;
            this.bunifuShadowPanel1.ShadowColor = System.Drawing.Color.DarkGray;
            this.bunifuShadowPanel1.ShadowDept = 2;
            this.bunifuShadowPanel1.ShadowDepth = 3;
            this.bunifuShadowPanel1.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.ForwardDiagonal;
            this.bunifuShadowPanel1.ShadowTopLeftVisible = false;
            this.bunifuShadowPanel1.Size = new System.Drawing.Size(350, 365);
            this.bunifuShadowPanel1.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            this.bunifuShadowPanel1.TabIndex = 1;
            this.bunifuShadowPanel1.Click += new System.EventHandler(this.ShowVehicleForm);
            // 
            // btnBid
            // 
            this.btnBid.AllowAnimations = true;
            this.btnBid.AllowMouseEffects = true;
            this.btnBid.AllowToggling = false;
            this.btnBid.AnimationSpeed = 200;
            this.btnBid.AutoGenerateColors = false;
            this.btnBid.AutoRoundBorders = false;
            this.btnBid.AutoSizeLeftIcon = true;
            this.btnBid.AutoSizeRightIcon = true;
            this.btnBid.BackColor = System.Drawing.Color.Transparent;
            this.btnBid.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnBid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBid.BackgroundImage")));
            this.btnBid.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnBid.ButtonText = "Go to Bidding Details";
            this.btnBid.ButtonTextMarginLeft = 0;
            this.btnBid.ColorContrastOnClick = 45;
            this.btnBid.ColorContrastOnHover = 45;
            this.btnBid.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnBid.CustomizableEdges = borderEdges1;
            this.btnBid.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBid.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnBid.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnBid.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnBid.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBid.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnBid.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBid.ForeColor = System.Drawing.Color.White;
            this.btnBid.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBid.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnBid.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnBid.IconMarginLeft = 11;
            this.btnBid.IconPadding = 10;
            this.btnBid.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBid.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnBid.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnBid.IconSize = 25;
            this.btnBid.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnBid.IdleBorderRadius = 20;
            this.btnBid.IdleBorderThickness = 1;
            this.btnBid.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnBid.IdleIconLeftImage = null;
            this.btnBid.IdleIconRightImage = null;
            this.btnBid.IndicateFocus = false;
            this.btnBid.Location = new System.Drawing.Point(15, 284);
            this.btnBid.Name = "btnBid";
            this.btnBid.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnBid.OnDisabledState.BorderRadius = 20;
            this.btnBid.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnBid.OnDisabledState.BorderThickness = 1;
            this.btnBid.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnBid.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnBid.OnDisabledState.IconLeftImage = null;
            this.btnBid.OnDisabledState.IconRightImage = null;
            this.btnBid.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnBid.onHoverState.BorderRadius = 20;
            this.btnBid.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnBid.onHoverState.BorderThickness = 1;
            this.btnBid.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnBid.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnBid.onHoverState.IconLeftImage = null;
            this.btnBid.onHoverState.IconRightImage = null;
            this.btnBid.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnBid.OnIdleState.BorderRadius = 20;
            this.btnBid.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnBid.OnIdleState.BorderThickness = 1;
            this.btnBid.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnBid.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnBid.OnIdleState.IconLeftImage = null;
            this.btnBid.OnIdleState.IconRightImage = null;
            this.btnBid.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnBid.OnPressedState.BorderRadius = 20;
            this.btnBid.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnBid.OnPressedState.BorderThickness = 1;
            this.btnBid.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnBid.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnBid.OnPressedState.IconLeftImage = null;
            this.btnBid.OnPressedState.IconRightImage = null;
            this.btnBid.Size = new System.Drawing.Size(320, 39);
            this.btnBid.TabIndex = 5;
            this.btnBid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBid.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBid.TextMarginLeft = 0;
            this.btnBid.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnBid.UseDefaultRadiusAndThickness = true;
            this.btnBid.Click += new System.EventHandler(this.BtnBiddingClick);
            // 
            // lblOwner
            // 
            this.lblOwner.BackColor = System.Drawing.Color.Transparent;
            this.lblOwner.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblOwner.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblOwner.Location = new System.Drawing.Point(15, 238);
            this.lblOwner.Margin = new System.Windows.Forms.Padding(3, 20, 3, 10);
            this.lblOwner.Name = "lblOwner";
            this.lblOwner.Size = new System.Drawing.Size(320, 46);
            this.lblOwner.TabIndex = 3;
            this.lblOwner.Text = "bigLabel1";
            this.lblOwner.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblOwner.Click += new System.EventHandler(this.ShowVehicleForm);
            // 
            // lblValue
            // 
            this.lblValue.BackColor = System.Drawing.Color.Transparent;
            this.lblValue.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblValue.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblValue.Location = new System.Drawing.Point(15, 198);
            this.lblValue.Margin = new System.Windows.Forms.Padding(3, 20, 3, 10);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(320, 40);
            this.lblValue.TabIndex = 2;
            this.lblValue.Text = "bigLabel1";
            this.lblValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblValue.Click += new System.EventHandler(this.ShowVehicleForm);
            // 
            // lblBrandAndModel
            // 
            this.lblBrandAndModel.BackColor = System.Drawing.Color.Transparent;
            this.lblBrandAndModel.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBrandAndModel.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrandAndModel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblBrandAndModel.Location = new System.Drawing.Point(15, 162);
            this.lblBrandAndModel.Margin = new System.Windows.Forms.Padding(3, 20, 3, 10);
            this.lblBrandAndModel.Name = "lblBrandAndModel";
            this.lblBrandAndModel.Size = new System.Drawing.Size(320, 36);
            this.lblBrandAndModel.TabIndex = 1;
            this.lblBrandAndModel.Text = "bigLabel1";
            this.lblBrandAndModel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBrandAndModel.Click += new System.EventHandler(this.ShowVehicleForm);
            // 
            // pcBoxVehicleImage
            // 
            this.pcBoxVehicleImage.AllowFocused = false;
            this.pcBoxVehicleImage.AutoSizeHeight = false;
            this.pcBoxVehicleImage.BorderRadius = 0;
            this.pcBoxVehicleImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.pcBoxVehicleImage.Image = ((System.Drawing.Image)(resources.GetObject("pcBoxVehicleImage.Image")));
            this.pcBoxVehicleImage.IsCircle = false;
            this.pcBoxVehicleImage.Location = new System.Drawing.Point(15, 15);
            this.pcBoxVehicleImage.Name = "pcBoxVehicleImage";
            this.pcBoxVehicleImage.Size = new System.Drawing.Size(320, 147);
            this.pcBoxVehicleImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcBoxVehicleImage.TabIndex = 0;
            this.pcBoxVehicleImage.TabStop = false;
            this.pcBoxVehicleImage.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Custom;
            this.pcBoxVehicleImage.Click += new System.EventHandler(this.ShowVehicleForm);
            // 
            // ListingCardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.bunifuShadowPanel1);
            this.DoubleBuffered = true;
            this.Name = "ListingCardView";
            this.Size = new System.Drawing.Size(350, 365);
            this.bunifuShadowPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxVehicleImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuShadowPanel bunifuShadowPanel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnBid;
        private ReaLTaiizor.BigLabel lblOwner;
        private ReaLTaiizor.BigLabel lblValue;
        private ReaLTaiizor.BigLabel lblBrandAndModel;
        private Bunifu.UI.WinForms.BunifuPictureBox pcBoxVehicleImage;
    }
}
