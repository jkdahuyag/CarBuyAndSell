﻿using System.Windows.Forms;
using System;

namespace CarBuyAndSell
{
    partial class MainForm
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
        // Initialize form components
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges7 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.tblLayoutMainDivider = new System.Windows.Forms.TableLayoutPanel();
            this.pnlHeader = new Bunifu.UI.WinForms.BunifuPanel();
            this.tblLayoutContentSide = new System.Windows.Forms.TableLayoutPanel();
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblViewName = new Bunifu.UI.WinForms.BunifuLabel();
            this.pnlUserControl = new Bunifu.UI.WinForms.BunifuPanel();
            this.tblLayoutSideNavPartition = new System.Windows.Forms.TableLayoutPanel();
            this.pnlSideBar = new Bunifu.UI.WinForms.BunifuPanel();
            this.btnUsers = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnTransactions = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnBids = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnListings = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnVehicles = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnMarket = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnDashboard = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pnlLogo = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblAppName = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblHeader = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuShadowPanel1 = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.tblLayoutMainDivider.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.tblLayoutContentSide.SuspendLayout();
            this.bunifuPanel2.SuspendLayout();
            this.pnlUserControl.SuspendLayout();
            this.tblLayoutSideNavPartition.SuspendLayout();
            this.pnlSideBar.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblLayoutMainDivider
            // 
            this.tblLayoutMainDivider.ColumnCount = 2;
            this.tblLayoutMainDivider.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 277F));
            this.tblLayoutMainDivider.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutMainDivider.Controls.Add(this.pnlHeader, 1, 0);
            this.tblLayoutMainDivider.Controls.Add(this.tblLayoutSideNavPartition, 0, 0);
            this.tblLayoutMainDivider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutMainDivider.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblLayoutMainDivider.Location = new System.Drawing.Point(0, 0);
            this.tblLayoutMainDivider.Margin = new System.Windows.Forms.Padding(0);
            this.tblLayoutMainDivider.Name = "tblLayoutMainDivider";
            this.tblLayoutMainDivider.RowCount = 1;
            this.tblLayoutMainDivider.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tblLayoutMainDivider.Size = new System.Drawing.Size(982, 578);
            this.tblLayoutMainDivider.TabIndex = 0;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackgroundColor = System.Drawing.Color.MintCream;
            this.pnlHeader.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlHeader.BackgroundImage")));
            this.pnlHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlHeader.BorderColor = System.Drawing.Color.Transparent;
            this.pnlHeader.BorderRadius = 0;
            this.pnlHeader.BorderThickness = 0;
            this.pnlHeader.Controls.Add(this.tblLayoutContentSide);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHeader.Location = new System.Drawing.Point(277, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.ShowBorders = true;
            this.pnlHeader.Size = new System.Drawing.Size(705, 578);
            this.pnlHeader.TabIndex = 1;
            // 
            // tblLayoutContentSide
            // 
            this.tblLayoutContentSide.ColumnCount = 1;
            this.tblLayoutContentSide.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutContentSide.Controls.Add(this.bunifuPanel2, 0, 0);
            this.tblLayoutContentSide.Controls.Add(this.pnlUserControl, 0, 1);
            this.tblLayoutContentSide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutContentSide.Location = new System.Drawing.Point(0, 0);
            this.tblLayoutContentSide.Margin = new System.Windows.Forms.Padding(0);
            this.tblLayoutContentSide.Name = "tblLayoutContentSide";
            this.tblLayoutContentSide.RowCount = 2;
            this.tblLayoutContentSide.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblLayoutContentSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutContentSide.Size = new System.Drawing.Size(705, 578);
            this.tblLayoutContentSide.TabIndex = 0;
            // 
            // bunifuPanel2
            // 
            this.bunifuPanel2.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel2.BackgroundImage")));
            this.bunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel2.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel2.BorderRadius = 0;
            this.bunifuPanel2.BorderThickness = 0;
            this.bunifuPanel2.Controls.Add(this.lblViewName);
            this.bunifuPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuPanel2.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.ShowBorders = true;
            this.bunifuPanel2.Size = new System.Drawing.Size(705, 78);
            this.bunifuPanel2.TabIndex = 2;
            // 
            // lblViewName
            // 
            this.lblViewName.AllowParentOverrides = false;
            this.lblViewName.AutoEllipsis = false;
            this.lblViewName.CursorType = null;
            this.lblViewName.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewName.Location = new System.Drawing.Point(40, 20);
            this.lblViewName.Name = "lblViewName";
            this.lblViewName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblViewName.Size = new System.Drawing.Size(85, 29);
            this.lblViewName.TabIndex = 0;
            this.lblViewName.Text = "Market";
            this.lblViewName.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblViewName.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // pnlUserControl
            // 
            this.pnlUserControl.BackgroundColor = System.Drawing.Color.Transparent;
            this.pnlUserControl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlUserControl.BackgroundImage")));
            this.pnlUserControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlUserControl.BorderColor = System.Drawing.Color.Transparent;
            this.pnlUserControl.BorderRadius = 0;
            this.pnlUserControl.BorderThickness = 0;
            this.pnlUserControl.Controls.Add(this.bunifuShadowPanel1);
            this.pnlUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUserControl.Location = new System.Drawing.Point(40, 83);
            this.pnlUserControl.Margin = new System.Windows.Forms.Padding(40, 5, 40, 15);
            this.pnlUserControl.Name = "pnlUserControl";
            this.pnlUserControl.ShowBorders = true;
            this.pnlUserControl.Size = new System.Drawing.Size(625, 480);
            this.pnlUserControl.TabIndex = 3;
            // 
            // tblLayoutSideNavPartition
            // 
            this.tblLayoutSideNavPartition.ColumnCount = 1;
            this.tblLayoutSideNavPartition.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutSideNavPartition.Controls.Add(this.pnlSideBar, 0, 0);
            this.tblLayoutSideNavPartition.Controls.Add(this.bunifuPanel1, 0, 1);
            this.tblLayoutSideNavPartition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutSideNavPartition.Location = new System.Drawing.Point(0, 0);
            this.tblLayoutSideNavPartition.Margin = new System.Windows.Forms.Padding(0);
            this.tblLayoutSideNavPartition.Name = "tblLayoutSideNavPartition";
            this.tblLayoutSideNavPartition.RowCount = 2;
            this.tblLayoutSideNavPartition.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutSideNavPartition.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tblLayoutSideNavPartition.Size = new System.Drawing.Size(277, 578);
            this.tblLayoutSideNavPartition.TabIndex = 2;
            // 
            // pnlSideBar
            // 
            this.pnlSideBar.BackgroundColor = System.Drawing.Color.MintCream;
            this.pnlSideBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlSideBar.BackgroundImage")));
            this.pnlSideBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlSideBar.BorderColor = System.Drawing.Color.Transparent;
            this.pnlSideBar.BorderRadius = 0;
            this.pnlSideBar.BorderThickness = 0;
            this.pnlSideBar.Controls.Add(this.btnUsers);
            this.pnlSideBar.Controls.Add(this.btnTransactions);
            this.pnlSideBar.Controls.Add(this.btnBids);
            this.pnlSideBar.Controls.Add(this.btnListings);
            this.pnlSideBar.Controls.Add(this.btnVehicles);
            this.pnlSideBar.Controls.Add(this.btnMarket);
            this.pnlSideBar.Controls.Add(this.btnDashboard);
            this.pnlSideBar.Controls.Add(this.pnlLogo);
            this.pnlSideBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSideBar.Location = new System.Drawing.Point(0, 0);
            this.pnlSideBar.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSideBar.Name = "pnlSideBar";
            this.pnlSideBar.Padding = new System.Windows.Forms.Padding(20, 20, 20, 0);
            this.pnlSideBar.ShowBorders = true;
            this.pnlSideBar.Size = new System.Drawing.Size(277, 498);
            this.pnlSideBar.TabIndex = 1;
            // 
            // btnUsers
            // 
            this.btnUsers.AllowAnimations = true;
            this.btnUsers.AllowMouseEffects = true;
            this.btnUsers.AllowToggling = false;
            this.btnUsers.AnimationSpeed = 200;
            this.btnUsers.AutoGenerateColors = false;
            this.btnUsers.AutoRoundBorders = false;
            this.btnUsers.AutoSizeLeftIcon = true;
            this.btnUsers.AutoSizeRightIcon = true;
            this.btnUsers.BackColor = System.Drawing.Color.Transparent;
            this.btnUsers.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnUsers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUsers.BackgroundImage")));
            this.btnUsers.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnUsers.ButtonText = "Users";
            this.btnUsers.ButtonTextMarginLeft = 0;
            this.btnUsers.ColorContrastOnClick = 45;
            this.btnUsers.ColorContrastOnHover = 45;
            this.btnUsers.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnUsers.CustomizableEdges = borderEdges1;
            this.btnUsers.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUsers.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnUsers.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnUsers.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsers.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnUsers.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnUsers.IconLeft = global::CarBuyAndSell.Properties.Resources.group;
            this.btnUsers.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnUsers.IconLeftPadding = new System.Windows.Forms.Padding(40, 3, 3, 3);
            this.btnUsers.IconMarginLeft = 11;
            this.btnUsers.IconPadding = 10;
            this.btnUsers.IconRight = null;
            this.btnUsers.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUsers.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnUsers.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnUsers.IconSize = 25;
            this.btnUsers.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnUsers.IdleBorderRadius = 0;
            this.btnUsers.IdleBorderThickness = 0;
            this.btnUsers.IdleFillColor = System.Drawing.Color.Empty;
            this.btnUsers.IdleIconLeftImage = global::CarBuyAndSell.Properties.Resources.group;
            this.btnUsers.IdleIconRightImage = null;
            this.btnUsers.IndicateFocus = false;
            this.btnUsers.Location = new System.Drawing.Point(20, 408);
            this.btnUsers.Margin = new System.Windows.Forms.Padding(5);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.OnDisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.btnUsers.OnDisabledState.BorderRadius = 0;
            this.btnUsers.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnUsers.OnDisabledState.BorderThickness = 0;
            this.btnUsers.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnUsers.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnUsers.OnDisabledState.IconLeftImage = null;
            this.btnUsers.OnDisabledState.IconRightImage = null;
            this.btnUsers.onHoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnUsers.onHoverState.BorderRadius = 0;
            this.btnUsers.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnUsers.onHoverState.BorderThickness = 0;
            this.btnUsers.onHoverState.FillColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnUsers.onHoverState.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnUsers.onHoverState.IconLeftImage = null;
            this.btnUsers.onHoverState.IconRightImage = null;
            this.btnUsers.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnUsers.OnIdleState.BorderRadius = 0;
            this.btnUsers.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnUsers.OnIdleState.BorderThickness = 0;
            this.btnUsers.OnIdleState.FillColor = System.Drawing.Color.MintCream;
            this.btnUsers.OnIdleState.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnUsers.OnIdleState.IconLeftImage = global::CarBuyAndSell.Properties.Resources.group;
            this.btnUsers.OnIdleState.IconRightImage = null;
            this.btnUsers.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnUsers.OnPressedState.BorderRadius = 0;
            this.btnUsers.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnUsers.OnPressedState.BorderThickness = 0;
            this.btnUsers.OnPressedState.FillColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnUsers.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnUsers.OnPressedState.IconLeftImage = null;
            this.btnUsers.OnPressedState.IconRightImage = null;
            this.btnUsers.Size = new System.Drawing.Size(237, 55);
            this.btnUsers.TabIndex = 7;
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnUsers.TextMarginLeft = 0;
            this.btnUsers.TextPadding = new System.Windows.Forms.Padding(85, 0, 0, 0);
            this.btnUsers.UseDefaultRadiusAndThickness = true;
            // 
            // btnTransactions
            // 
            this.btnTransactions.AllowAnimations = true;
            this.btnTransactions.AllowMouseEffects = true;
            this.btnTransactions.AllowToggling = false;
            this.btnTransactions.AnimationSpeed = 200;
            this.btnTransactions.AutoGenerateColors = false;
            this.btnTransactions.AutoRoundBorders = false;
            this.btnTransactions.AutoSizeLeftIcon = true;
            this.btnTransactions.AutoSizeRightIcon = true;
            this.btnTransactions.BackColor = System.Drawing.Color.Transparent;
            this.btnTransactions.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnTransactions.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTransactions.BackgroundImage")));
            this.btnTransactions.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnTransactions.ButtonText = "Transaction History";
            this.btnTransactions.ButtonTextMarginLeft = 0;
            this.btnTransactions.ColorContrastOnClick = 45;
            this.btnTransactions.ColorContrastOnHover = 45;
            this.btnTransactions.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnTransactions.CustomizableEdges = borderEdges2;
            this.btnTransactions.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnTransactions.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnTransactions.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnTransactions.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnTransactions.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTransactions.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnTransactions.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransactions.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnTransactions.IconLeft = global::CarBuyAndSell.Properties.Resources.transfer;
            this.btnTransactions.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransactions.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnTransactions.IconLeftPadding = new System.Windows.Forms.Padding(40, 3, 3, 3);
            this.btnTransactions.IconMarginLeft = 11;
            this.btnTransactions.IconPadding = 10;
            this.btnTransactions.IconRight = null;
            this.btnTransactions.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTransactions.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnTransactions.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnTransactions.IconSize = 25;
            this.btnTransactions.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnTransactions.IdleBorderRadius = 0;
            this.btnTransactions.IdleBorderThickness = 0;
            this.btnTransactions.IdleFillColor = System.Drawing.Color.Empty;
            this.btnTransactions.IdleIconLeftImage = global::CarBuyAndSell.Properties.Resources.transfer;
            this.btnTransactions.IdleIconRightImage = null;
            this.btnTransactions.IndicateFocus = false;
            this.btnTransactions.Location = new System.Drawing.Point(20, 353);
            this.btnTransactions.Margin = new System.Windows.Forms.Padding(5);
            this.btnTransactions.Name = "btnTransactions";
            this.btnTransactions.OnDisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.btnTransactions.OnDisabledState.BorderRadius = 0;
            this.btnTransactions.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnTransactions.OnDisabledState.BorderThickness = 0;
            this.btnTransactions.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnTransactions.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnTransactions.OnDisabledState.IconLeftImage = null;
            this.btnTransactions.OnDisabledState.IconRightImage = null;
            this.btnTransactions.onHoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnTransactions.onHoverState.BorderRadius = 0;
            this.btnTransactions.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnTransactions.onHoverState.BorderThickness = 0;
            this.btnTransactions.onHoverState.FillColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnTransactions.onHoverState.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnTransactions.onHoverState.IconLeftImage = null;
            this.btnTransactions.onHoverState.IconRightImage = null;
            this.btnTransactions.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnTransactions.OnIdleState.BorderRadius = 0;
            this.btnTransactions.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnTransactions.OnIdleState.BorderThickness = 0;
            this.btnTransactions.OnIdleState.FillColor = System.Drawing.Color.MintCream;
            this.btnTransactions.OnIdleState.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnTransactions.OnIdleState.IconLeftImage = global::CarBuyAndSell.Properties.Resources.transfer;
            this.btnTransactions.OnIdleState.IconRightImage = null;
            this.btnTransactions.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnTransactions.OnPressedState.BorderRadius = 0;
            this.btnTransactions.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnTransactions.OnPressedState.BorderThickness = 0;
            this.btnTransactions.OnPressedState.FillColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnTransactions.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnTransactions.OnPressedState.IconLeftImage = null;
            this.btnTransactions.OnPressedState.IconRightImage = null;
            this.btnTransactions.Size = new System.Drawing.Size(237, 55);
            this.btnTransactions.TabIndex = 6;
            this.btnTransactions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransactions.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnTransactions.TextMarginLeft = 0;
            this.btnTransactions.TextPadding = new System.Windows.Forms.Padding(85, 0, 0, 0);
            this.btnTransactions.UseDefaultRadiusAndThickness = true;
            // 
            // btnBids
            // 
            this.btnBids.AllowAnimations = true;
            this.btnBids.AllowMouseEffects = true;
            this.btnBids.AllowToggling = false;
            this.btnBids.AnimationSpeed = 200;
            this.btnBids.AutoGenerateColors = false;
            this.btnBids.AutoRoundBorders = false;
            this.btnBids.AutoSizeLeftIcon = true;
            this.btnBids.AutoSizeRightIcon = true;
            this.btnBids.BackColor = System.Drawing.Color.Transparent;
            this.btnBids.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnBids.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBids.BackgroundImage")));
            this.btnBids.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnBids.ButtonText = "My Bids";
            this.btnBids.ButtonTextMarginLeft = 0;
            this.btnBids.ColorContrastOnClick = 45;
            this.btnBids.ColorContrastOnHover = 45;
            this.btnBids.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnBids.CustomizableEdges = borderEdges3;
            this.btnBids.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBids.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnBids.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnBids.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnBids.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBids.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnBids.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBids.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnBids.IconLeft = global::CarBuyAndSell.Properties.Resources.bid;
            this.btnBids.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBids.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnBids.IconLeftPadding = new System.Windows.Forms.Padding(40, 3, 3, 3);
            this.btnBids.IconMarginLeft = 11;
            this.btnBids.IconPadding = 10;
            this.btnBids.IconRight = null;
            this.btnBids.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBids.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnBids.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnBids.IconSize = 25;
            this.btnBids.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnBids.IdleBorderRadius = 0;
            this.btnBids.IdleBorderThickness = 0;
            this.btnBids.IdleFillColor = System.Drawing.Color.Empty;
            this.btnBids.IdleIconLeftImage = global::CarBuyAndSell.Properties.Resources.bid;
            this.btnBids.IdleIconRightImage = null;
            this.btnBids.IndicateFocus = false;
            this.btnBids.Location = new System.Drawing.Point(20, 298);
            this.btnBids.Margin = new System.Windows.Forms.Padding(5);
            this.btnBids.Name = "btnBids";
            this.btnBids.OnDisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.btnBids.OnDisabledState.BorderRadius = 0;
            this.btnBids.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnBids.OnDisabledState.BorderThickness = 0;
            this.btnBids.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnBids.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnBids.OnDisabledState.IconLeftImage = null;
            this.btnBids.OnDisabledState.IconRightImage = null;
            this.btnBids.onHoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnBids.onHoverState.BorderRadius = 0;
            this.btnBids.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnBids.onHoverState.BorderThickness = 0;
            this.btnBids.onHoverState.FillColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnBids.onHoverState.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnBids.onHoverState.IconLeftImage = null;
            this.btnBids.onHoverState.IconRightImage = null;
            this.btnBids.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnBids.OnIdleState.BorderRadius = 0;
            this.btnBids.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnBids.OnIdleState.BorderThickness = 0;
            this.btnBids.OnIdleState.FillColor = System.Drawing.Color.MintCream;
            this.btnBids.OnIdleState.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnBids.OnIdleState.IconLeftImage = global::CarBuyAndSell.Properties.Resources.bid;
            this.btnBids.OnIdleState.IconRightImage = null;
            this.btnBids.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnBids.OnPressedState.BorderRadius = 0;
            this.btnBids.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnBids.OnPressedState.BorderThickness = 0;
            this.btnBids.OnPressedState.FillColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnBids.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnBids.OnPressedState.IconLeftImage = null;
            this.btnBids.OnPressedState.IconRightImage = null;
            this.btnBids.Size = new System.Drawing.Size(237, 55);
            this.btnBids.TabIndex = 5;
            this.btnBids.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBids.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBids.TextMarginLeft = 0;
            this.btnBids.TextPadding = new System.Windows.Forms.Padding(85, 0, 0, 0);
            this.btnBids.UseDefaultRadiusAndThickness = true;
            // 
            // btnListings
            // 
            this.btnListings.AllowAnimations = true;
            this.btnListings.AllowMouseEffects = true;
            this.btnListings.AllowToggling = false;
            this.btnListings.AnimationSpeed = 200;
            this.btnListings.AutoGenerateColors = false;
            this.btnListings.AutoRoundBorders = false;
            this.btnListings.AutoSizeLeftIcon = true;
            this.btnListings.AutoSizeRightIcon = true;
            this.btnListings.BackColor = System.Drawing.Color.Transparent;
            this.btnListings.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnListings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnListings.BackgroundImage")));
            this.btnListings.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnListings.ButtonText = "My Listings";
            this.btnListings.ButtonTextMarginLeft = 0;
            this.btnListings.ColorContrastOnClick = 45;
            this.btnListings.ColorContrastOnHover = 45;
            this.btnListings.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.btnListings.CustomizableEdges = borderEdges4;
            this.btnListings.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnListings.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnListings.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnListings.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnListings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListings.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnListings.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListings.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnListings.IconLeft = global::CarBuyAndSell.Properties.Resources.list;
            this.btnListings.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListings.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnListings.IconLeftPadding = new System.Windows.Forms.Padding(40, 3, 3, 3);
            this.btnListings.IconMarginLeft = 11;
            this.btnListings.IconPadding = 10;
            this.btnListings.IconRight = null;
            this.btnListings.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnListings.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnListings.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnListings.IconSize = 25;
            this.btnListings.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnListings.IdleBorderRadius = 0;
            this.btnListings.IdleBorderThickness = 0;
            this.btnListings.IdleFillColor = System.Drawing.Color.Empty;
            this.btnListings.IdleIconLeftImage = global::CarBuyAndSell.Properties.Resources.list;
            this.btnListings.IdleIconRightImage = null;
            this.btnListings.IndicateFocus = false;
            this.btnListings.Location = new System.Drawing.Point(20, 243);
            this.btnListings.Margin = new System.Windows.Forms.Padding(5);
            this.btnListings.Name = "btnListings";
            this.btnListings.OnDisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.btnListings.OnDisabledState.BorderRadius = 0;
            this.btnListings.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnListings.OnDisabledState.BorderThickness = 0;
            this.btnListings.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnListings.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnListings.OnDisabledState.IconLeftImage = null;
            this.btnListings.OnDisabledState.IconRightImage = null;
            this.btnListings.onHoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnListings.onHoverState.BorderRadius = 0;
            this.btnListings.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnListings.onHoverState.BorderThickness = 0;
            this.btnListings.onHoverState.FillColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnListings.onHoverState.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnListings.onHoverState.IconLeftImage = null;
            this.btnListings.onHoverState.IconRightImage = null;
            this.btnListings.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnListings.OnIdleState.BorderRadius = 0;
            this.btnListings.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnListings.OnIdleState.BorderThickness = 0;
            this.btnListings.OnIdleState.FillColor = System.Drawing.Color.MintCream;
            this.btnListings.OnIdleState.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnListings.OnIdleState.IconLeftImage = global::CarBuyAndSell.Properties.Resources.list;
            this.btnListings.OnIdleState.IconRightImage = null;
            this.btnListings.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnListings.OnPressedState.BorderRadius = 0;
            this.btnListings.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnListings.OnPressedState.BorderThickness = 0;
            this.btnListings.OnPressedState.FillColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnListings.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnListings.OnPressedState.IconLeftImage = null;
            this.btnListings.OnPressedState.IconRightImage = null;
            this.btnListings.Size = new System.Drawing.Size(237, 55);
            this.btnListings.TabIndex = 4;
            this.btnListings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListings.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnListings.TextMarginLeft = 0;
            this.btnListings.TextPadding = new System.Windows.Forms.Padding(85, 0, 0, 0);
            this.btnListings.UseDefaultRadiusAndThickness = true;
            // 
            // btnVehicles
            // 
            this.btnVehicles.AllowAnimations = true;
            this.btnVehicles.AllowMouseEffects = true;
            this.btnVehicles.AllowToggling = false;
            this.btnVehicles.AnimationSpeed = 200;
            this.btnVehicles.AutoGenerateColors = false;
            this.btnVehicles.AutoRoundBorders = false;
            this.btnVehicles.AutoSizeLeftIcon = true;
            this.btnVehicles.AutoSizeRightIcon = true;
            this.btnVehicles.BackColor = System.Drawing.Color.Transparent;
            this.btnVehicles.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnVehicles.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVehicles.BackgroundImage")));
            this.btnVehicles.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnVehicles.ButtonText = "My Vehicles";
            this.btnVehicles.ButtonTextMarginLeft = 0;
            this.btnVehicles.ColorContrastOnClick = 45;
            this.btnVehicles.ColorContrastOnHover = 45;
            this.btnVehicles.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges5.BottomLeft = true;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = true;
            borderEdges5.TopRight = true;
            this.btnVehicles.CustomizableEdges = borderEdges5;
            this.btnVehicles.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnVehicles.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnVehicles.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnVehicles.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnVehicles.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVehicles.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnVehicles.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVehicles.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnVehicles.IconLeft = global::CarBuyAndSell.Properties.Resources.car;
            this.btnVehicles.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVehicles.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnVehicles.IconLeftPadding = new System.Windows.Forms.Padding(40, 3, 3, 3);
            this.btnVehicles.IconMarginLeft = 11;
            this.btnVehicles.IconPadding = 10;
            this.btnVehicles.IconRight = null;
            this.btnVehicles.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVehicles.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnVehicles.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnVehicles.IconSize = 25;
            this.btnVehicles.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnVehicles.IdleBorderRadius = 0;
            this.btnVehicles.IdleBorderThickness = 0;
            this.btnVehicles.IdleFillColor = System.Drawing.Color.Empty;
            this.btnVehicles.IdleIconLeftImage = global::CarBuyAndSell.Properties.Resources.car;
            this.btnVehicles.IdleIconRightImage = null;
            this.btnVehicles.IndicateFocus = false;
            this.btnVehicles.Location = new System.Drawing.Point(20, 188);
            this.btnVehicles.Margin = new System.Windows.Forms.Padding(5);
            this.btnVehicles.Name = "btnVehicles";
            this.btnVehicles.OnDisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.btnVehicles.OnDisabledState.BorderRadius = 0;
            this.btnVehicles.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnVehicles.OnDisabledState.BorderThickness = 0;
            this.btnVehicles.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnVehicles.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnVehicles.OnDisabledState.IconLeftImage = null;
            this.btnVehicles.OnDisabledState.IconRightImage = null;
            this.btnVehicles.onHoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnVehicles.onHoverState.BorderRadius = 0;
            this.btnVehicles.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnVehicles.onHoverState.BorderThickness = 0;
            this.btnVehicles.onHoverState.FillColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnVehicles.onHoverState.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnVehicles.onHoverState.IconLeftImage = null;
            this.btnVehicles.onHoverState.IconRightImage = null;
            this.btnVehicles.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnVehicles.OnIdleState.BorderRadius = 0;
            this.btnVehicles.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnVehicles.OnIdleState.BorderThickness = 0;
            this.btnVehicles.OnIdleState.FillColor = System.Drawing.Color.MintCream;
            this.btnVehicles.OnIdleState.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnVehicles.OnIdleState.IconLeftImage = global::CarBuyAndSell.Properties.Resources.car;
            this.btnVehicles.OnIdleState.IconRightImage = null;
            this.btnVehicles.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnVehicles.OnPressedState.BorderRadius = 0;
            this.btnVehicles.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnVehicles.OnPressedState.BorderThickness = 0;
            this.btnVehicles.OnPressedState.FillColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnVehicles.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnVehicles.OnPressedState.IconLeftImage = null;
            this.btnVehicles.OnPressedState.IconRightImage = null;
            this.btnVehicles.Size = new System.Drawing.Size(237, 55);
            this.btnVehicles.TabIndex = 3;
            this.btnVehicles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVehicles.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnVehicles.TextMarginLeft = 0;
            this.btnVehicles.TextPadding = new System.Windows.Forms.Padding(85, 0, 0, 0);
            this.btnVehicles.UseDefaultRadiusAndThickness = true;
            // 
            // btnMarket
            // 
            this.btnMarket.AllowAnimations = true;
            this.btnMarket.AllowMouseEffects = true;
            this.btnMarket.AllowToggling = false;
            this.btnMarket.AnimationSpeed = 200;
            this.btnMarket.AutoGenerateColors = false;
            this.btnMarket.AutoRoundBorders = false;
            this.btnMarket.AutoSizeLeftIcon = true;
            this.btnMarket.AutoSizeRightIcon = true;
            this.btnMarket.BackColor = System.Drawing.Color.Transparent;
            this.btnMarket.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnMarket.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMarket.BackgroundImage")));
            this.btnMarket.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnMarket.ButtonText = "Market";
            this.btnMarket.ButtonTextMarginLeft = 0;
            this.btnMarket.ColorContrastOnClick = 45;
            this.btnMarket.ColorContrastOnHover = 45;
            this.btnMarket.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges6.BottomLeft = true;
            borderEdges6.BottomRight = true;
            borderEdges6.TopLeft = true;
            borderEdges6.TopRight = true;
            this.btnMarket.CustomizableEdges = borderEdges6;
            this.btnMarket.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMarket.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnMarket.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnMarket.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnMarket.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMarket.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnMarket.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarket.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnMarket.IconLeft = global::CarBuyAndSell.Properties.Resources.shopping_cart;
            this.btnMarket.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMarket.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnMarket.IconLeftPadding = new System.Windows.Forms.Padding(40, 3, 3, 3);
            this.btnMarket.IconMarginLeft = 11;
            this.btnMarket.IconPadding = 10;
            this.btnMarket.IconRight = null;
            this.btnMarket.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMarket.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnMarket.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnMarket.IconSize = 25;
            this.btnMarket.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnMarket.IdleBorderRadius = 0;
            this.btnMarket.IdleBorderThickness = 0;
            this.btnMarket.IdleFillColor = System.Drawing.Color.Empty;
            this.btnMarket.IdleIconLeftImage = global::CarBuyAndSell.Properties.Resources.shopping_cart;
            this.btnMarket.IdleIconRightImage = null;
            this.btnMarket.IndicateFocus = false;
            this.btnMarket.Location = new System.Drawing.Point(20, 133);
            this.btnMarket.Margin = new System.Windows.Forms.Padding(5);
            this.btnMarket.Name = "btnMarket";
            this.btnMarket.OnDisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.btnMarket.OnDisabledState.BorderRadius = 0;
            this.btnMarket.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnMarket.OnDisabledState.BorderThickness = 0;
            this.btnMarket.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnMarket.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnMarket.OnDisabledState.IconLeftImage = null;
            this.btnMarket.OnDisabledState.IconRightImage = null;
            this.btnMarket.onHoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnMarket.onHoverState.BorderRadius = 0;
            this.btnMarket.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnMarket.onHoverState.BorderThickness = 0;
            this.btnMarket.onHoverState.FillColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnMarket.onHoverState.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnMarket.onHoverState.IconLeftImage = null;
            this.btnMarket.onHoverState.IconRightImage = null;
            this.btnMarket.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnMarket.OnIdleState.BorderRadius = 0;
            this.btnMarket.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnMarket.OnIdleState.BorderThickness = 0;
            this.btnMarket.OnIdleState.FillColor = System.Drawing.Color.MintCream;
            this.btnMarket.OnIdleState.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnMarket.OnIdleState.IconLeftImage = global::CarBuyAndSell.Properties.Resources.shopping_cart;
            this.btnMarket.OnIdleState.IconRightImage = null;
            this.btnMarket.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnMarket.OnPressedState.BorderRadius = 0;
            this.btnMarket.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnMarket.OnPressedState.BorderThickness = 0;
            this.btnMarket.OnPressedState.FillColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnMarket.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnMarket.OnPressedState.IconLeftImage = null;
            this.btnMarket.OnPressedState.IconRightImage = null;
            this.btnMarket.Size = new System.Drawing.Size(237, 55);
            this.btnMarket.TabIndex = 2;
            this.btnMarket.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMarket.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnMarket.TextMarginLeft = 0;
            this.btnMarket.TextPadding = new System.Windows.Forms.Padding(85, 0, 0, 0);
            this.btnMarket.UseDefaultRadiusAndThickness = true;
            // 
            // btnDashboard
            // 
            this.btnDashboard.AllowAnimations = true;
            this.btnDashboard.AllowMouseEffects = true;
            this.btnDashboard.AllowToggling = false;
            this.btnDashboard.AnimationSpeed = 200;
            this.btnDashboard.AutoGenerateColors = false;
            this.btnDashboard.AutoRoundBorders = false;
            this.btnDashboard.AutoSizeLeftIcon = true;
            this.btnDashboard.AutoSizeRightIcon = true;
            this.btnDashboard.BackColor = System.Drawing.Color.Transparent;
            this.btnDashboard.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnDashboard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDashboard.BackgroundImage")));
            this.btnDashboard.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDashboard.ButtonText = "Dashboard";
            this.btnDashboard.ButtonTextMarginLeft = 0;
            this.btnDashboard.ColorContrastOnClick = 45;
            this.btnDashboard.ColorContrastOnHover = 45;
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges7.BottomLeft = true;
            borderEdges7.BottomRight = true;
            borderEdges7.TopLeft = true;
            borderEdges7.TopRight = true;
            this.btnDashboard.CustomizableEdges = borderEdges7;
            this.btnDashboard.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDashboard.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDashboard.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnDashboard.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnDashboard.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnDashboard.IconLeft = global::CarBuyAndSell.Properties.Resources.monitor;
            this.btnDashboard.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnDashboard.IconLeftPadding = new System.Windows.Forms.Padding(40, 3, 3, 3);
            this.btnDashboard.IconMarginLeft = 11;
            this.btnDashboard.IconPadding = 10;
            this.btnDashboard.IconRight = null;
            this.btnDashboard.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDashboard.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnDashboard.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnDashboard.IconSize = 25;
            this.btnDashboard.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnDashboard.IdleBorderRadius = 0;
            this.btnDashboard.IdleBorderThickness = 0;
            this.btnDashboard.IdleFillColor = System.Drawing.Color.Empty;
            this.btnDashboard.IdleIconLeftImage = global::CarBuyAndSell.Properties.Resources.monitor;
            this.btnDashboard.IdleIconRightImage = null;
            this.btnDashboard.IndicateFocus = false;
            this.btnDashboard.Location = new System.Drawing.Point(20, 78);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(5);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.OnDisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.btnDashboard.OnDisabledState.BorderRadius = 0;
            this.btnDashboard.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDashboard.OnDisabledState.BorderThickness = 0;
            this.btnDashboard.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnDashboard.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnDashboard.OnDisabledState.IconLeftImage = null;
            this.btnDashboard.OnDisabledState.IconRightImage = null;
            this.btnDashboard.onHoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnDashboard.onHoverState.BorderRadius = 0;
            this.btnDashboard.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDashboard.onHoverState.BorderThickness = 0;
            this.btnDashboard.onHoverState.FillColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnDashboard.onHoverState.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnDashboard.onHoverState.IconLeftImage = null;
            this.btnDashboard.onHoverState.IconRightImage = null;
            this.btnDashboard.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnDashboard.OnIdleState.BorderRadius = 0;
            this.btnDashboard.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDashboard.OnIdleState.BorderThickness = 0;
            this.btnDashboard.OnIdleState.FillColor = System.Drawing.Color.MintCream;
            this.btnDashboard.OnIdleState.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnDashboard.OnIdleState.IconLeftImage = global::CarBuyAndSell.Properties.Resources.monitor;
            this.btnDashboard.OnIdleState.IconRightImage = null;
            this.btnDashboard.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnDashboard.OnPressedState.BorderRadius = 0;
            this.btnDashboard.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDashboard.OnPressedState.BorderThickness = 0;
            this.btnDashboard.OnPressedState.FillColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnDashboard.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.OnPressedState.IconLeftImage = null;
            this.btnDashboard.OnPressedState.IconRightImage = null;
            this.btnDashboard.Size = new System.Drawing.Size(237, 55);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDashboard.TextMarginLeft = 0;
            this.btnDashboard.TextPadding = new System.Windows.Forms.Padding(85, 0, 0, 0);
            this.btnDashboard.UseDefaultRadiusAndThickness = true;
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackgroundColor = System.Drawing.Color.MintCream;
            this.pnlLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlLogo.BackgroundImage")));
            this.pnlLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLogo.BorderColor = System.Drawing.Color.Transparent;
            this.pnlLogo.BorderRadius = 0;
            this.pnlLogo.BorderThickness = 0;
            this.pnlLogo.Controls.Add(this.lblAppName);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(20, 20);
            this.pnlLogo.Margin = new System.Windows.Forms.Padding(0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.ShowBorders = true;
            this.pnlLogo.Size = new System.Drawing.Size(237, 58);
            this.pnlLogo.TabIndex = 0;
            // 
            // lblAppName
            // 
            this.lblAppName.AllowParentOverrides = false;
            this.lblAppName.AutoEllipsis = false;
            this.lblAppName.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblAppName.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblAppName.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppName.Location = new System.Drawing.Point(0, 0);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAppName.Size = new System.Drawing.Size(128, 19);
            this.lblAppName.TabIndex = 0;
            this.lblAppName.Text = "Cargadong Car";
            this.lblAppName.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAppName.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 498);
            this.bunifuPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(277, 80);
            this.bunifuPanel1.TabIndex = 2;
            // 
            // lblHeader
            // 
            this.lblHeader.AllowParentOverrides = false;
            this.lblHeader.AutoEllipsis = false;
            this.lblHeader.CursorType = null;
            this.lblHeader.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(21, 12);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblHeader.Size = new System.Drawing.Size(93, 29);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "Vehicle";
            this.lblHeader.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHeader.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuShadowPanel1
            // 
            this.bunifuShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuShadowPanel1.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuShadowPanel1.BorderRadius = 1;
            this.bunifuShadowPanel1.BorderThickness = 1;
            this.bunifuShadowPanel1.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            this.bunifuShadowPanel1.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            this.bunifuShadowPanel1.Location = new System.Drawing.Point(3, 50);
            this.bunifuShadowPanel1.Name = "bunifuShadowPanel1";
            this.bunifuShadowPanel1.PanelColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuShadowPanel1.PanelColor2 = System.Drawing.Color.WhiteSmoke;
            this.bunifuShadowPanel1.ShadowColor = System.Drawing.Color.DarkGray;
            this.bunifuShadowPanel1.ShadowDept = 2;
            this.bunifuShadowPanel1.ShadowDepth = 5;
            this.bunifuShadowPanel1.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded;
            this.bunifuShadowPanel1.ShadowTopLeftVisible = false;
            this.bunifuShadowPanel1.Size = new System.Drawing.Size(300, 230);
            this.bunifuShadowPanel1.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            this.bunifuShadowPanel1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(982, 578);
            this.Controls.Add(this.tblLayoutMainDivider);
            this.Name = "MainForm";
            this.Text = "Cargadong Car";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.tblLayoutMainDivider.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.tblLayoutContentSide.ResumeLayout(false);
            this.bunifuPanel2.ResumeLayout(false);
            this.bunifuPanel2.PerformLayout();
            this.pnlUserControl.ResumeLayout(false);
            this.tblLayoutSideNavPartition.ResumeLayout(false);
            this.pnlSideBar.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion
        private Panel carPanel;
        private Button prevPageBtn;
        private Button nextPageBtn;
        private TableLayoutPanel paginationLayout;
        private TableLayoutPanel tblLayoutMainDivider;
        private Bunifu.UI.WinForms.BunifuPanel pnlHeader;
        private TableLayoutPanel tblLayoutContentSide;
        private Bunifu.UI.WinForms.BunifuLabel lblHeader;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        private Bunifu.UI.WinForms.BunifuLabel lblViewName;
        private Bunifu.UI.WinForms.BunifuPanel pnlUserControl;
        private TableLayoutPanel tblLayoutSideNavPartition;
        private Bunifu.UI.WinForms.BunifuPanel pnlSideBar;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnUsers;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnTransactions;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnBids;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnListings;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnVehicles;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnMarket;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnDashboard;
        private Bunifu.UI.WinForms.BunifuPanel pnlLogo;
        private Bunifu.UI.WinForms.BunifuLabel lblAppName;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuShadowPanel bunifuShadowPanel1;
    }
}

