namespace CarBuyAndSell.Forms
{
    partial class TransactionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            this.tblLayout = new System.Windows.Forms.TableLayoutPanel();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblHeader = new ReaLTaiizor.BigLabel();
            this.cmbPaymentMethod = new ReaLTaiizor.ComboBoxEdit();
            this.bigLabel1 = new ReaLTaiizor.BigLabel();
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.bigLabel4 = new ReaLTaiizor.BigLabel();
            this.bigLabel2 = new ReaLTaiizor.BigLabel();
            this.bigLabel3 = new ReaLTaiizor.BigLabel();
            this.lblPartial = new ReaLTaiizor.BigLabel();
            this.lblService = new ReaLTaiizor.BigLabel();
            this.lblTotal = new ReaLTaiizor.BigLabel();
            this.btnCancel = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.bunifuPanel3 = new Bunifu.UI.WinForms.BunifuPanel();
            this.btnContinue = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.tblLayout.SuspendLayout();
            this.bunifuPanel1.SuspendLayout();
            this.bunifuPanel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.bunifuPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblLayout
            // 
            this.tblLayout.ColumnCount = 1;
            this.tblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayout.Controls.Add(this.bunifuPanel1, 0, 0);
            this.tblLayout.Controls.Add(this.bunifuPanel2, 0, 1);
            this.tblLayout.Controls.Add(this.bunifuPanel3, 0, 2);
            this.tblLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblLayout.Location = new System.Drawing.Point(20, 0);
            this.tblLayout.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.tblLayout.Name = "tblLayout";
            this.tblLayout.RowCount = 3;
            this.tblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.00001F));
            this.tblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tblLayout.Size = new System.Drawing.Size(472, 456);
            this.tblLayout.TabIndex = 0;
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Gray;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.bigLabel1);
            this.bunifuPanel1.Controls.Add(this.cmbPaymentMethod);
            this.bunifuPanel1.Controls.Add(this.lblHeader);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 10);
            this.bunifuPanel1.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(472, 182);
            this.bunifuPanel1.TabIndex = 1;
            // 
            // lblHeader
            // 
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHeader.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblHeader.Location = new System.Drawing.Point(0, 10);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(472, 63);
            this.lblHeader.TabIndex = 2;
            this.lblHeader.Text = "bigLabel1";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmbPaymentMethod
            // 
            this.cmbPaymentMethod.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPaymentMethod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.cmbPaymentMethod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbPaymentMethod.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbPaymentMethod.DropDownHeight = 100;
            this.cmbPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentMethod.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPaymentMethod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.cmbPaymentMethod.FormattingEnabled = true;
            this.cmbPaymentMethod.HoverSelectionColor = System.Drawing.Color.Silver;
            this.cmbPaymentMethod.IntegralHeight = false;
            this.cmbPaymentMethod.ItemHeight = 20;
            this.cmbPaymentMethod.Location = new System.Drawing.Point(275, 73);
            this.cmbPaymentMethod.Name = "cmbPaymentMethod";
            this.cmbPaymentMethod.Size = new System.Drawing.Size(191, 26);
            this.cmbPaymentMethod.StartIndex = 0;
            this.cmbPaymentMethod.TabIndex = 3;
            // 
            // bigLabel1
            // 
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel1.Location = new System.Drawing.Point(3, 76);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(180, 23);
            this.bigLabel1.TabIndex = 4;
            this.bigLabel1.Text = "Payment Method";
            // 
            // bunifuPanel2
            // 
            this.bunifuPanel2.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel2.BackgroundImage")));
            this.bunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel2.BorderColor = System.Drawing.Color.Gray;
            this.bunifuPanel2.BorderRadius = 3;
            this.bunifuPanel2.BorderThickness = 1;
            this.bunifuPanel2.Controls.Add(this.tableLayoutPanel2);
            this.bunifuPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuPanel2.Location = new System.Drawing.Point(0, 212);
            this.bunifuPanel2.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.Padding = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.bunifuPanel2.ShowBorders = true;
            this.bunifuPanel2.Size = new System.Drawing.Size(472, 183);
            this.bunifuPanel2.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.bigLabel4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.bigLabel2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.bigLabel3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblPartial, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblService, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblTotal, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 10);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(466, 169);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // bigLabel4
            // 
            this.bigLabel4.AutoSize = true;
            this.bigLabel4.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel4.Location = new System.Drawing.Point(3, 112);
            this.bigLabel4.Name = "bigLabel4";
            this.bigLabel4.Size = new System.Drawing.Size(51, 21);
            this.bigLabel4.TabIndex = 7;
            this.bigLabel4.Text = "Total";
            // 
            // bigLabel2
            // 
            this.bigLabel2.AutoSize = true;
            this.bigLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel2.Location = new System.Drawing.Point(3, 0);
            this.bigLabel2.Name = "bigLabel2";
            this.bigLabel2.Size = new System.Drawing.Size(133, 21);
            this.bigLabel2.TabIndex = 5;
            this.bigLabel2.Text = "Partial Amount";
            // 
            // bigLabel3
            // 
            this.bigLabel3.AutoSize = true;
            this.bigLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel3.Location = new System.Drawing.Point(3, 56);
            this.bigLabel3.Name = "bigLabel3";
            this.bigLabel3.Size = new System.Drawing.Size(105, 21);
            this.bigLabel3.TabIndex = 6;
            this.bigLabel3.Text = "Service Fee";
            // 
            // lblPartial
            // 
            this.lblPartial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPartial.AutoSize = true;
            this.lblPartial.BackColor = System.Drawing.Color.Transparent;
            this.lblPartial.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblPartial.Location = new System.Drawing.Point(330, 0);
            this.lblPartial.Name = "lblPartial";
            this.lblPartial.Size = new System.Drawing.Size(133, 21);
            this.lblPartial.TabIndex = 8;
            this.lblPartial.Text = "Partial Amount";
            // 
            // lblService
            // 
            this.lblService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblService.AutoSize = true;
            this.lblService.BackColor = System.Drawing.Color.Transparent;
            this.lblService.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblService.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblService.Location = new System.Drawing.Point(330, 56);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(133, 21);
            this.lblService.TabIndex = 9;
            this.lblService.Text = "Partial Amount";
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblTotal.Location = new System.Drawing.Point(330, 112);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(133, 21);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "Partial Amount";
            // 
            // btnCancel
            // 
            this.btnCancel.AllowAnimations = true;
            this.btnCancel.AllowMouseEffects = true;
            this.btnCancel.AllowToggling = false;
            this.btnCancel.AnimationSpeed = 200;
            this.btnCancel.AutoGenerateColors = false;
            this.btnCancel.AutoRoundBorders = false;
            this.btnCancel.AutoSizeLeftIcon = true;
            this.btnCancel.AutoSizeRightIcon = true;
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnCancel.ButtonText = "Cancel";
            this.btnCancel.ButtonTextMarginLeft = 0;
            this.btnCancel.ColorContrastOnClick = 45;
            this.btnCancel.ColorContrastOnHover = 45;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnCancel.CustomizableEdges = borderEdges2;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCancel.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCancel.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCancel.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCancel.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnCancel.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnCancel.IconMarginLeft = 11;
            this.btnCancel.IconPadding = 10;
            this.btnCancel.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnCancel.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnCancel.IconSize = 25;
            this.btnCancel.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnCancel.IdleBorderRadius = 15;
            this.btnCancel.IdleBorderThickness = 1;
            this.btnCancel.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnCancel.IdleIconLeftImage = null;
            this.btnCancel.IdleIconRightImage = null;
            this.btnCancel.IndicateFocus = false;
            this.btnCancel.Location = new System.Drawing.Point(0, 0);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCancel.OnDisabledState.BorderRadius = 15;
            this.btnCancel.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnCancel.OnDisabledState.BorderThickness = 1;
            this.btnCancel.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCancel.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCancel.OnDisabledState.IconLeftImage = null;
            this.btnCancel.OnDisabledState.IconRightImage = null;
            this.btnCancel.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(70)))), ((int)(((byte)(37)))));
            this.btnCancel.onHoverState.BorderRadius = 15;
            this.btnCancel.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnCancel.onHoverState.BorderThickness = 1;
            this.btnCancel.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(70)))), ((int)(((byte)(37)))));
            this.btnCancel.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnCancel.onHoverState.IconLeftImage = null;
            this.btnCancel.onHoverState.IconRightImage = null;
            this.btnCancel.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnCancel.OnIdleState.BorderRadius = 15;
            this.btnCancel.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnCancel.OnIdleState.BorderThickness = 1;
            this.btnCancel.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnCancel.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnCancel.OnIdleState.IconLeftImage = null;
            this.btnCancel.OnIdleState.IconRightImage = null;
            this.btnCancel.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnCancel.OnPressedState.BorderRadius = 15;
            this.btnCancel.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnCancel.OnPressedState.BorderThickness = 1;
            this.btnCancel.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnCancel.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnCancel.OnPressedState.IconLeftImage = null;
            this.btnCancel.OnPressedState.IconRightImage = null;
            this.btnCancel.Size = new System.Drawing.Size(136, 42);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCancel.TextMarginLeft = 0;
            this.btnCancel.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnCancel.UseDefaultRadiusAndThickness = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // bunifuPanel3
            // 
            this.bunifuPanel3.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel3.BackgroundImage")));
            this.bunifuPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel3.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel3.BorderRadius = 3;
            this.bunifuPanel3.BorderThickness = 1;
            this.bunifuPanel3.Controls.Add(this.btnContinue);
            this.bunifuPanel3.Controls.Add(this.btnCancel);
            this.bunifuPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuPanel3.Location = new System.Drawing.Point(3, 408);
            this.bunifuPanel3.Name = "bunifuPanel3";
            this.bunifuPanel3.ShowBorders = true;
            this.bunifuPanel3.Size = new System.Drawing.Size(466, 45);
            this.bunifuPanel3.TabIndex = 5;
            // 
            // btnContinue
            // 
            this.btnContinue.AllowAnimations = true;
            this.btnContinue.AllowMouseEffects = true;
            this.btnContinue.AllowToggling = false;
            this.btnContinue.AnimationSpeed = 200;
            this.btnContinue.AutoGenerateColors = false;
            this.btnContinue.AutoRoundBorders = false;
            this.btnContinue.AutoSizeLeftIcon = true;
            this.btnContinue.AutoSizeRightIcon = true;
            this.btnContinue.BackColor = System.Drawing.Color.Transparent;
            this.btnContinue.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(175)))), ((int)(((byte)(0)))));
            this.btnContinue.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnContinue.BackgroundImage")));
            this.btnContinue.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnContinue.ButtonText = "Continue";
            this.btnContinue.ButtonTextMarginLeft = 0;
            this.btnContinue.ColorContrastOnClick = 45;
            this.btnContinue.ColorContrastOnHover = 45;
            this.btnContinue.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnContinue.CustomizableEdges = borderEdges1;
            this.btnContinue.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnContinue.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnContinue.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnContinue.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnContinue.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnContinue.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinue.ForeColor = System.Drawing.Color.White;
            this.btnContinue.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContinue.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnContinue.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnContinue.IconMarginLeft = 11;
            this.btnContinue.IconPadding = 10;
            this.btnContinue.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnContinue.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnContinue.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnContinue.IconSize = 25;
            this.btnContinue.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(175)))), ((int)(((byte)(0)))));
            this.btnContinue.IdleBorderRadius = 15;
            this.btnContinue.IdleBorderThickness = 1;
            this.btnContinue.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(175)))), ((int)(((byte)(0)))));
            this.btnContinue.IdleIconLeftImage = null;
            this.btnContinue.IdleIconRightImage = null;
            this.btnContinue.IndicateFocus = false;
            this.btnContinue.Location = new System.Drawing.Point(149, 0);
            this.btnContinue.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnContinue.OnDisabledState.BorderRadius = 15;
            this.btnContinue.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnContinue.OnDisabledState.BorderThickness = 1;
            this.btnContinue.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnContinue.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnContinue.OnDisabledState.IconLeftImage = null;
            this.btnContinue.OnDisabledState.IconRightImage = null;
            this.btnContinue.onHoverState.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnContinue.onHoverState.BorderRadius = 15;
            this.btnContinue.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnContinue.onHoverState.BorderThickness = 1;
            this.btnContinue.onHoverState.FillColor = System.Drawing.Color.DarkOrange;
            this.btnContinue.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnContinue.onHoverState.IconLeftImage = null;
            this.btnContinue.onHoverState.IconRightImage = null;
            this.btnContinue.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(175)))), ((int)(((byte)(0)))));
            this.btnContinue.OnIdleState.BorderRadius = 15;
            this.btnContinue.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnContinue.OnIdleState.BorderThickness = 1;
            this.btnContinue.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(175)))), ((int)(((byte)(0)))));
            this.btnContinue.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnContinue.OnIdleState.IconLeftImage = null;
            this.btnContinue.OnIdleState.IconRightImage = null;
            this.btnContinue.OnPressedState.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnContinue.OnPressedState.BorderRadius = 15;
            this.btnContinue.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnContinue.OnPressedState.BorderThickness = 1;
            this.btnContinue.OnPressedState.FillColor = System.Drawing.Color.DarkOrange;
            this.btnContinue.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnContinue.OnPressedState.IconLeftImage = null;
            this.btnContinue.OnPressedState.IconRightImage = null;
            this.btnContinue.Size = new System.Drawing.Size(317, 42);
            this.btnContinue.TabIndex = 4;
            this.btnContinue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnContinue.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnContinue.TextMarginLeft = 0;
            this.btnContinue.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnContinue.UseDefaultRadiusAndThickness = true;
            this.btnContinue.Click += new System.EventHandler(this.BtnContinue_Click);
            // 
            // TransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(512, 526);
            this.Controls.Add(this.tblLayout);
            this.Name = "TransactionForm";
            this.Padding = new System.Windows.Forms.Padding(20, 0, 20, 70);
            this.Text = "TransactionForm";
            this.tblLayout.ResumeLayout(false);
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            this.bunifuPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.bunifuPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblLayout;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private ReaLTaiizor.BigLabel lblHeader;
        private ReaLTaiizor.ComboBoxEdit cmbPaymentMethod;
        private ReaLTaiizor.BigLabel bigLabel1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private ReaLTaiizor.BigLabel bigLabel4;
        private ReaLTaiizor.BigLabel bigLabel2;
        private ReaLTaiizor.BigLabel bigLabel3;
        private ReaLTaiizor.BigLabel lblPartial;
        private ReaLTaiizor.BigLabel lblService;
        private ReaLTaiizor.BigLabel lblTotal;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel3;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnContinue;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnCancel;
    }
}