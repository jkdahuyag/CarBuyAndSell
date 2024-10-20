namespace CarBuyAndSell.Cards
{
    partial class VehicleCardView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VehicleCardView));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            this.bunifuShadowPanel1 = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.pcBoxVehicleImage = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.lblBrandAndModel = new ReaLTaiizor.BigLabel();
            this.lblValue = new ReaLTaiizor.BigLabel();
            this.lblOwner = new ReaLTaiizor.BigLabel();
            this.btnSell = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
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
            this.bunifuShadowPanel1.Controls.Add(this.btnSell);
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
            this.bunifuShadowPanel1.PanelColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuShadowPanel1.PanelColor2 = System.Drawing.Color.WhiteSmoke;
            this.bunifuShadowPanel1.ShadowColor = System.Drawing.Color.DarkGray;
            this.bunifuShadowPanel1.ShadowDept = 2;
            this.bunifuShadowPanel1.ShadowDepth = 10;
            this.bunifuShadowPanel1.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded;
            this.bunifuShadowPanel1.ShadowTopLeftVisible = false;
            this.bunifuShadowPanel1.Size = new System.Drawing.Size(310, 450);
            this.bunifuShadowPanel1.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            this.bunifuShadowPanel1.TabIndex = 0;
            this.bunifuShadowPanel1.Click += new System.EventHandler(this.ShowVehicleForm);
            // 
            // pcBoxVehicleImage
            // 
            this.pcBoxVehicleImage.AllowFocused = false;
            this.pcBoxVehicleImage.AutoSizeHeight = false;
            this.pcBoxVehicleImage.BorderRadius = 0;
            this.pcBoxVehicleImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.pcBoxVehicleImage.Image = ((System.Drawing.Image)(resources.GetObject("pcBoxVehicleImage.Image")));
            this.pcBoxVehicleImage.IsCircle = true;
            this.pcBoxVehicleImage.Location = new System.Drawing.Point(15, 15);
            this.pcBoxVehicleImage.Name = "pcBoxVehicleImage";
            this.pcBoxVehicleImage.Size = new System.Drawing.Size(280, 211);
            this.pcBoxVehicleImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcBoxVehicleImage.TabIndex = 0;
            this.pcBoxVehicleImage.TabStop = false;
            this.pcBoxVehicleImage.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            this.pcBoxVehicleImage.Click += new System.EventHandler(this.ShowVehicleForm);
            // 
            // lblBrandAndModel
            // 
            this.lblBrandAndModel.BackColor = System.Drawing.Color.Transparent;
            this.lblBrandAndModel.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBrandAndModel.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrandAndModel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblBrandAndModel.Location = new System.Drawing.Point(15, 226);
            this.lblBrandAndModel.Margin = new System.Windows.Forms.Padding(3, 20, 3, 10);
            this.lblBrandAndModel.Name = "lblBrandAndModel";
            this.lblBrandAndModel.Size = new System.Drawing.Size(280, 48);
            this.lblBrandAndModel.TabIndex = 1;
            this.lblBrandAndModel.Text = "bigLabel1";
            this.lblBrandAndModel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBrandAndModel.Click += new System.EventHandler(this.ShowVehicleForm);
            // 
            // lblValue
            // 
            this.lblValue.BackColor = System.Drawing.Color.Transparent;
            this.lblValue.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblValue.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblValue.Location = new System.Drawing.Point(15, 274);
            this.lblValue.Margin = new System.Windows.Forms.Padding(3, 20, 3, 10);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(280, 40);
            this.lblValue.TabIndex = 2;
            this.lblValue.Text = "bigLabel1";
            this.lblValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblValue.Click += new System.EventHandler(this.ShowVehicleForm);
            // 
            // lblOwner
            // 
            this.lblOwner.BackColor = System.Drawing.Color.Transparent;
            this.lblOwner.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblOwner.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblOwner.Location = new System.Drawing.Point(15, 314);
            this.lblOwner.Margin = new System.Windows.Forms.Padding(3, 20, 3, 10);
            this.lblOwner.Name = "lblOwner";
            this.lblOwner.Size = new System.Drawing.Size(280, 46);
            this.lblOwner.TabIndex = 3;
            this.lblOwner.Text = "bigLabel1";
            this.lblOwner.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblOwner.Click += new System.EventHandler(this.ShowVehicleForm);
            // 
            // btnSell
            // 
            this.btnSell.AllowAnimations = true;
            this.btnSell.AllowMouseEffects = true;
            this.btnSell.AllowToggling = false;
            this.btnSell.AnimationSpeed = 200;
            this.btnSell.AutoGenerateColors = false;
            this.btnSell.AutoRoundBorders = false;
            this.btnSell.AutoSizeLeftIcon = true;
            this.btnSell.AutoSizeRightIcon = true;
            this.btnSell.BackColor = System.Drawing.Color.Transparent;
            this.btnSell.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnSell.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSell.BackgroundImage")));
            this.btnSell.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnSell.ButtonText = "bunifuButton21";
            this.btnSell.ButtonTextMarginLeft = 0;
            this.btnSell.ColorContrastOnClick = 45;
            this.btnSell.ColorContrastOnHover = 45;
            this.btnSell.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnSell.CustomizableEdges = borderEdges1;
            this.btnSell.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSell.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSell.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSell.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSell.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSell.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnSell.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSell.ForeColor = System.Drawing.Color.White;
            this.btnSell.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSell.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnSell.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnSell.IconMarginLeft = 11;
            this.btnSell.IconPadding = 10;
            this.btnSell.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSell.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnSell.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnSell.IconSize = 25;
            this.btnSell.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnSell.IdleBorderRadius = 1;
            this.btnSell.IdleBorderThickness = 1;
            this.btnSell.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnSell.IdleIconLeftImage = null;
            this.btnSell.IdleIconRightImage = null;
            this.btnSell.IndicateFocus = false;
            this.btnSell.Location = new System.Drawing.Point(15, 360);
            this.btnSell.Name = "btnSell";
            this.btnSell.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSell.OnDisabledState.BorderRadius = 1;
            this.btnSell.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnSell.OnDisabledState.BorderThickness = 1;
            this.btnSell.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSell.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSell.OnDisabledState.IconLeftImage = null;
            this.btnSell.OnDisabledState.IconRightImage = null;
            this.btnSell.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnSell.onHoverState.BorderRadius = 1;
            this.btnSell.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnSell.onHoverState.BorderThickness = 1;
            this.btnSell.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnSell.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnSell.onHoverState.IconLeftImage = null;
            this.btnSell.onHoverState.IconRightImage = null;
            this.btnSell.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnSell.OnIdleState.BorderRadius = 1;
            this.btnSell.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnSell.OnIdleState.BorderThickness = 1;
            this.btnSell.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnSell.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnSell.OnIdleState.IconLeftImage = null;
            this.btnSell.OnIdleState.IconRightImage = null;
            this.btnSell.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnSell.OnPressedState.BorderRadius = 1;
            this.btnSell.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnSell.OnPressedState.BorderThickness = 1;
            this.btnSell.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnSell.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnSell.OnPressedState.IconLeftImage = null;
            this.btnSell.OnPressedState.IconRightImage = null;
            this.btnSell.Size = new System.Drawing.Size(280, 39);
            this.btnSell.TabIndex = 5;
            this.btnSell.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSell.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSell.TextMarginLeft = 0;
            this.btnSell.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnSell.UseDefaultRadiusAndThickness = true;
            this.btnSell.Click += new System.EventHandler(this.BtnSellClick);
            // 
            // VehicleCardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuShadowPanel1);
            this.Name = "VehicleCardView";
            this.Size = new System.Drawing.Size(310, 450);
            this.bunifuShadowPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxVehicleImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuShadowPanel bunifuShadowPanel1;
        private Bunifu.UI.WinForms.BunifuPictureBox pcBoxVehicleImage;
        private ReaLTaiizor.BigLabel lblOwner;
        private ReaLTaiizor.BigLabel lblValue;
        private ReaLTaiizor.BigLabel lblBrandAndModel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnSell;
    }
}
