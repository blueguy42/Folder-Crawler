﻿namespace Folder_Crawler
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.kryptonPalette1 = new Krypton.Toolkit.KryptonPalette(this.components);
            this.BrowseFolderButton = new Krypton.Toolkit.KryptonButton();
            this.FolderLabel = new Krypton.Toolkit.KryptonLabel();
            this.StartingTitle = new Krypton.Toolkit.KryptonLabel();
            this.InputTitle = new Krypton.Toolkit.KryptonLabel();
            this.kryptonTextBox1 = new Krypton.Toolkit.KryptonTextBox();
            this.SemuaFileCheck = new Krypton.Toolkit.KryptonCheckBox();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.BFS = new Krypton.Toolkit.KryptonRadioButton();
            this.DFS = new Krypton.Toolkit.KryptonRadioButton();
            this.PohonLabel = new Krypton.Toolkit.KryptonLabel();
            this.kryptonButton2 = new Krypton.Toolkit.KryptonButton();
            this.kryptonWrapLabel1 = new Krypton.Toolkit.KryptonWrapLabel();
            this.Title = new Krypton.Toolkit.KryptonLabel();
            this.BatalButton = new Krypton.Toolkit.KryptonButton();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.StartButton = new Krypton.Toolkit.KryptonButton();
            this.DitemukanLabel = new Krypton.Toolkit.KryptonLabel();
            this.WarningLabel = new Krypton.Toolkit.KryptonLabel();
            this.WelcomeLabel = new Krypton.Toolkit.KryptonLabel();
            this.HasilLabel = new Krypton.Toolkit.KryptonLinkLabel();
            this.TimeTitleLable = new Krypton.Toolkit.KryptonLabel();
            this.TimeLabel = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.SuspendLayout();
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.BasePaletteMode = Krypton.Toolkit.PaletteMode.Global;
            this.kryptonPalette1.ButtonSpecs.FormClose.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.kryptonPalette1.ButtonSpecs.FormMax.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.kryptonPalette1.ButtonSpecs.FormMin.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.kryptonPalette1.ButtonSpecs.FormRestore.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(235)))), ((int)(((byte)(241)))));
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateCommon.Back.ColorAngle = 60F;
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateCommon.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(2)))));
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateCommon.Border.ColorAngle = 60F;
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateCommon.Border.Rounding = 25F;
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateCommon.Border.Width = 5;
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5);
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(29)))));
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(29)))));
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(235)))), ((int)(((byte)(241)))));
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateNormal.Back.ColorAngle = 60F;
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(2)))));
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateNormal.Border.ColorAngle = 60F;
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateNormal.Border.Rounding = 25F;
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateNormal.Border.Width = 5;
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateNormal.Content.Padding = new System.Windows.Forms.Padding(5);
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(29)))));
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(29)))));
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(235)))), ((int)(((byte)(241)))));
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StatePressed.Back.ColorAngle = 60F;
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(2)))));
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StatePressed.Border.ColorAngle = 60F;
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StatePressed.Border.Rounding = 25F;
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StatePressed.Border.Width = 5;
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StatePressed.Content.Padding = new System.Windows.Forms.Padding(5);
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(29)))));
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(29)))));
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(235)))), ((int)(((byte)(241)))));
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateTracking.Back.ColorAngle = 60F;
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(2)))));
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateTracking.Border.ColorAngle = 60F;
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateTracking.Border.Rounding = 25F;
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateTracking.Border.Width = 5;
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Border.Rounding = 10F;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Border.Width = 0;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Border.Rounding = 10F;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Border.Width = 0;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Border.Rounding = 10F;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Border.Width = 0;
            this.kryptonPalette1.FormStyles.FormMain.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.kryptonPalette1.FormStyles.FormMain.StateActive.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.kryptonPalette1.FormStyles.FormMain.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.kryptonPalette1.FormStyles.FormMain.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.kryptonPalette1.FormStyles.FormMain.StateActive.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateActive.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            this.kryptonPalette1.FormStyles.FormMain.StateActive.Border.Rounding = 12F;
            this.kryptonPalette1.FormStyles.FormMain.StateActive.Border.Width = 0;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 10;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            this.kryptonPalette1.LabelStyles.LabelCustom1.StateCommon.LongText.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kryptonPalette1.LabelStyles.LabelCustom1.StateCommon.ShortText.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kryptonPalette1.LabelStyles.LabelCustom1.StateNormal.LongText.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kryptonPalette1.LabelStyles.LabelCustom1.StateNormal.ShortText.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kryptonPalette1.PalettePaint += new System.EventHandler<Krypton.Toolkit.PaletteLayoutEventArgs>(this.kryptonPalette1_PalettePaint);
            // 
            // BrowseFolderButton
            // 
            this.BrowseFolderButton.ButtonStyle = Krypton.Toolkit.ButtonStyle.Custom1;
            this.BrowseFolderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BrowseFolderButton.Location = new System.Drawing.Point(18, 141);
            this.BrowseFolderButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BrowseFolderButton.Name = "BrowseFolderButton";
            this.BrowseFolderButton.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.BrowseFolderButton.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(235)))), ((int)(((byte)(241)))));
            this.BrowseFolderButton.OverrideDefault.Back.ColorAngle = 60F;
            this.BrowseFolderButton.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.BrowseFolderButton.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(2)))));
            this.BrowseFolderButton.OverrideDefault.Border.ColorAngle = 60F;
            this.BrowseFolderButton.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.BrowseFolderButton.OverrideDefault.Border.Rounding = 25F;
            this.BrowseFolderButton.OverrideDefault.Border.Width = 5;
            this.BrowseFolderButton.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BrowseFolderButton.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(191)))), ((int)(((byte)(198)))));
            this.BrowseFolderButton.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(235)))), ((int)(((byte)(241)))));
            this.BrowseFolderButton.OverrideFocus.Back.ColorAngle = 60F;
            this.BrowseFolderButton.OverrideFocus.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.BrowseFolderButton.OverrideFocus.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.BrowseFolderButton.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(2)))));
            this.BrowseFolderButton.OverrideFocus.Border.ColorAngle = 60F;
            this.BrowseFolderButton.OverrideFocus.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.BrowseFolderButton.OverrideFocus.Border.Rounding = 25F;
            this.BrowseFolderButton.OverrideFocus.Border.Width = 5;
            this.BrowseFolderButton.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BrowseFolderButton.Palette = this.kryptonPalette1;
            this.BrowseFolderButton.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.BrowseFolderButton.Size = new System.Drawing.Size(132, 37);
            this.BrowseFolderButton.TabIndex = 4;
            this.BrowseFolderButton.Values.Text = "Pilih Folder...";
            this.BrowseFolderButton.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // FolderLabel
            // 
            this.FolderLabel.AutoSize = false;
            this.FolderLabel.LabelStyle = Krypton.Toolkit.LabelStyle.NormalControl;
            this.FolderLabel.Location = new System.Drawing.Point(154, 151);
            this.FolderLabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FolderLabel.Name = "FolderLabel";
            this.FolderLabel.Palette = this.kryptonPalette1;
            this.FolderLabel.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.FolderLabel.Size = new System.Drawing.Size(237, 18);
            this.FolderLabel.StateCommon.ShortText.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FolderLabel.TabIndex = 5;
            this.FolderLabel.Values.Text = "Belum ada folder yang dipilih";
            this.FolderLabel.Paint += new System.Windows.Forms.PaintEventHandler(this.FolderLabel_Paint);
            // 
            // StartingTitle
            // 
            this.StartingTitle.LabelStyle = Krypton.Toolkit.LabelStyle.Custom1;
            this.StartingTitle.Location = new System.Drawing.Point(18, 112);
            this.StartingTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StartingTitle.Name = "StartingTitle";
            this.StartingTitle.Palette = this.kryptonPalette1;
            this.StartingTitle.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.StartingTitle.Size = new System.Drawing.Size(237, 27);
            this.StartingTitle.StateCommon.ShortText.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StartingTitle.TabIndex = 7;
            this.StartingTitle.Values.Text = "1. Pilih Direktori Mula-Mula";
            this.StartingTitle.Paint += new System.Windows.Forms.PaintEventHandler(this.kryptonLabel1_Paint);
            // 
            // InputTitle
            // 
            this.InputTitle.LabelStyle = Krypton.Toolkit.LabelStyle.Custom1;
            this.InputTitle.Location = new System.Drawing.Point(18, 200);
            this.InputTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InputTitle.Name = "InputTitle";
            this.InputTitle.Palette = this.kryptonPalette1;
            this.InputTitle.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.InputTitle.Size = new System.Drawing.Size(207, 27);
            this.InputTitle.StateCommon.ShortText.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.InputTitle.TabIndex = 9;
            this.InputTitle.Values.Text = "2. Masukkan Nama File";
            this.InputTitle.Paint += new System.Windows.Forms.PaintEventHandler(this.kryptonLabel2_Paint);
            // 
            // kryptonTextBox1
            // 
            this.kryptonTextBox1.CueHint.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(127)))), ((int)(((byte)(141)))));
            this.kryptonTextBox1.CueHint.CueHintText = "Tugas_Besar_Stima.pdf";
            this.kryptonTextBox1.CueHint.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kryptonTextBox1.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.kryptonTextBox1.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            this.kryptonTextBox1.Location = new System.Drawing.Point(18, 229);
            this.kryptonTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonTextBox1.Name = "kryptonTextBox1";
            this.kryptonTextBox1.Palette = this.kryptonPalette1;
            this.kryptonTextBox1.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.kryptonTextBox1.Size = new System.Drawing.Size(350, 27);
            this.kryptonTextBox1.StateActive.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonTextBox1.StateActive.Border.Rounding = 5F;
            this.kryptonTextBox1.StateActive.Border.Width = 0;
            this.kryptonTextBox1.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kryptonTextBox1.TabIndex = 10;
            this.kryptonTextBox1.TextChanged += new System.EventHandler(this.kryptonTextBox1_TextChanged);
            // 
            // SemuaFileCheck
            // 
            this.SemuaFileCheck.Location = new System.Drawing.Point(18, 256);
            this.SemuaFileCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SemuaFileCheck.Name = "SemuaFileCheck";
            this.SemuaFileCheck.Size = new System.Drawing.Size(284, 22);
            this.SemuaFileCheck.StateCommon.ShortText.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SemuaFileCheck.TabIndex = 12;
            this.SemuaFileCheck.Values.Text = "Cari semua file dengan nama tersebut";
            this.SemuaFileCheck.CheckedChanged += new System.EventHandler(this.SemuaFileCheck_CheckedChanged);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.LabelStyle = Krypton.Toolkit.LabelStyle.Custom1;
            this.kryptonLabel2.Location = new System.Drawing.Point(18, 297);
            this.kryptonLabel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Palette = this.kryptonPalette1;
            this.kryptonLabel2.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.kryptonLabel2.Size = new System.Drawing.Size(224, 27);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabel2.TabIndex = 13;
            this.kryptonLabel2.Values.Text = "3. Pilih Metode Pencarian";
            // 
            // BFS
            // 
            this.BFS.Location = new System.Drawing.Point(18, 326);
            this.BFS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BFS.Name = "BFS";
            this.BFS.Size = new System.Drawing.Size(203, 22);
            this.BFS.StateCommon.ShortText.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BFS.TabIndex = 14;
            this.BFS.Values.Text = "BFS (Breadth-First-Search)";
            this.BFS.CheckedChanged += new System.EventHandler(this.BFS_CheckedChanged);
            // 
            // DFS
            // 
            this.DFS.Location = new System.Drawing.Point(18, 349);
            this.DFS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DFS.Name = "DFS";
            this.DFS.Size = new System.Drawing.Size(191, 22);
            this.DFS.StateCommon.ShortText.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DFS.TabIndex = 15;
            this.DFS.Values.Text = "DFS (Depth-First-Search)";
            this.DFS.CheckedChanged += new System.EventHandler(this.DFS_CheckedChanged);
            // 
            // PohonLabel
            // 
            this.PohonLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PohonLabel.Location = new System.Drawing.Point(725, 25);
            this.PohonLabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PohonLabel.Name = "PohonLabel";
            this.PohonLabel.Size = new System.Drawing.Size(360, 27);
            this.PohonLabel.StateCommon.ShortText.Color1 = System.Drawing.Color.CornflowerBlue;
            this.PohonLabel.StateCommon.ShortText.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PohonLabel.TabIndex = 18;
            this.PohonLabel.Values.Text = "Yuk tonton pohon folder-mu bertumbuh!";
            this.PohonLabel.Visible = false;
            // 
            // kryptonButton2
            // 
            this.kryptonButton2.Location = new System.Drawing.Point(409, 19);
            this.kryptonButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonButton2.Name = "kryptonButton2";
            this.kryptonButton2.Size = new System.Drawing.Size(3, 465);
            this.kryptonButton2.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(191)))), ((int)(((byte)(198)))));
            this.kryptonButton2.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(191)))), ((int)(((byte)(198)))));
            this.kryptonButton2.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton2.StateCommon.Border.Rounding = 25F;
            this.kryptonButton2.StateCommon.Border.Width = 0;
            this.kryptonButton2.TabIndex = 19;
            this.kryptonButton2.Values.Text = "kryptonButton2";
            // 
            // kryptonWrapLabel1
            // 
            this.kryptonWrapLabel1.Font = new System.Drawing.Font("Poppins Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kryptonWrapLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.kryptonWrapLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.NormalControl;
            this.kryptonWrapLabel1.Location = new System.Drawing.Point(18, 69);
            this.kryptonWrapLabel1.Name = "kryptonWrapLabel1";
            this.kryptonWrapLabel1.Size = new System.Drawing.Size(385, 22);
            this.kryptonWrapLabel1.StateCommon.Font = new System.Drawing.Font("Poppins Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kryptonWrapLabel1.Text = "Selamat datang di Folder Crawler dari Pencari Pasangan Hidup!";
            this.kryptonWrapLabel1.Click += new System.EventHandler(this.kryptonWrapLabel1_Click);
            // 
            // Title
            // 
            this.Title.Location = new System.Drawing.Point(15, 25);
            this.Title.Margin = new System.Windows.Forms.Padding(0);
            this.Title.Name = "Title";
            this.Title.Palette = this.kryptonPalette1;
            this.Title.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.Title.Size = new System.Drawing.Size(224, 44);
            this.Title.StateCommon.ShortText.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Title.TabIndex = 20;
            this.Title.Values.Text = "Folder Crawler";
            // 
            // BatalButton
            // 
            this.BatalButton.ButtonStyle = Krypton.Toolkit.ButtonStyle.Custom1;
            this.BatalButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BatalButton.Location = new System.Drawing.Point(885, 416);
            this.BatalButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BatalButton.Name = "BatalButton";
            this.BatalButton.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.BatalButton.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(235)))), ((int)(((byte)(241)))));
            this.BatalButton.OverrideDefault.Back.ColorAngle = 60F;
            this.BatalButton.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.BatalButton.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(2)))));
            this.BatalButton.OverrideDefault.Border.ColorAngle = 60F;
            this.BatalButton.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.BatalButton.OverrideDefault.Border.Rounding = 25F;
            this.BatalButton.OverrideDefault.Border.Width = 5;
            this.BatalButton.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(191)))), ((int)(((byte)(198)))));
            this.BatalButton.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(235)))), ((int)(((byte)(241)))));
            this.BatalButton.OverrideFocus.Back.ColorAngle = 60F;
            this.BatalButton.OverrideFocus.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.BatalButton.OverrideFocus.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.BatalButton.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(2)))));
            this.BatalButton.OverrideFocus.Border.ColorAngle = 60F;
            this.BatalButton.OverrideFocus.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.BatalButton.OverrideFocus.Border.Rounding = 25F;
            this.BatalButton.OverrideFocus.Border.Width = 5;
            this.BatalButton.Palette = this.kryptonPalette1;
            this.BatalButton.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.BatalButton.Size = new System.Drawing.Size(200, 37);
            this.BatalButton.TabIndex = 21;
            this.BatalButton.Values.Text = "Batalkan Pencarian";
            this.BatalButton.Visible = false;
            // 
            // StartButton
            // 
            this.StartButton.ButtonStyle = Krypton.Toolkit.ButtonStyle.Custom1;
            this.StartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartButton.Location = new System.Drawing.Point(18, 416);
            this.StartButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StartButton.Name = "StartButton";
            this.StartButton.OverrideDefault.Back.Color1 = System.Drawing.Color.CornflowerBlue;
            this.StartButton.OverrideDefault.Back.Color2 = System.Drawing.Color.RoyalBlue;
            this.StartButton.OverrideDefault.Back.ColorAngle = 60F;
            this.StartButton.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.StartButton.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(2)))));
            this.StartButton.OverrideDefault.Border.ColorAngle = 60F;
            this.StartButton.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StartButton.OverrideDefault.Border.Rounding = 25F;
            this.StartButton.OverrideDefault.Border.Width = 5;
            this.StartButton.OverrideFocus.Back.Color1 = System.Drawing.Color.RoyalBlue;
            this.StartButton.OverrideFocus.Back.Color2 = System.Drawing.Color.CornflowerBlue;
            this.StartButton.OverrideFocus.Back.ColorAngle = 60F;
            this.StartButton.OverrideFocus.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.StartButton.OverrideFocus.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.StartButton.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(2)))));
            this.StartButton.OverrideFocus.Border.ColorAngle = 60F;
            this.StartButton.OverrideFocus.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StartButton.OverrideFocus.Border.Rounding = 25F;
            this.StartButton.OverrideFocus.Border.Width = 5;
            this.StartButton.Palette = this.kryptonPalette1;
            this.StartButton.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.StartButton.Size = new System.Drawing.Size(218, 37);
            this.StartButton.StateCommon.Back.Color1 = System.Drawing.Color.CornflowerBlue;
            this.StartButton.StateCommon.Back.Color2 = System.Drawing.Color.RoyalBlue;
            this.StartButton.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StartButton.StateCommon.Border.Width = 0;
            this.StartButton.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.StartButton.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StartButton.StatePressed.Back.Color1 = System.Drawing.Color.RoyalBlue;
            this.StartButton.StatePressed.Back.Color2 = System.Drawing.Color.CornflowerBlue;
            this.StartButton.StateTracking.Back.Color1 = System.Drawing.Color.CornflowerBlue;
            this.StartButton.StateTracking.Back.Color2 = System.Drawing.Color.RoyalBlue;
            this.StartButton.TabIndex = 23;
            this.StartButton.Values.Text = "Mulai Pencarian!";
            this.StartButton.Click += new System.EventHandler(this.kryptonButton4_Click);
            // 
            // DitemukanLabel
            // 
            this.DitemukanLabel.Location = new System.Drawing.Point(453, 326);
            this.DitemukanLabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DitemukanLabel.Name = "DitemukanLabel";
            this.DitemukanLabel.Size = new System.Drawing.Size(85, 27);
            this.DitemukanLabel.StateCommon.ShortText.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DitemukanLabel.TabIndex = 25;
            this.DitemukanLabel.Values.Text = "Ketemu!";
            this.DitemukanLabel.Visible = false;
            // 
            // WarningLabel
            // 
            this.WarningLabel.LabelStyle = Krypton.Toolkit.LabelStyle.Custom1;
            this.WarningLabel.Location = new System.Drawing.Point(18, 458);
            this.WarningLabel.Name = "WarningLabel";
            this.WarningLabel.Palette = this.kryptonPalette1;
            this.WarningLabel.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.WarningLabel.Size = new System.Drawing.Size(304, 22);
            this.WarningLabel.StateCommon.ShortText.Color1 = System.Drawing.Color.Coral;
            this.WarningLabel.StateCommon.ShortText.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.WarningLabel.TabIndex = 31;
            this.WarningLabel.Values.Text = "! Silakan lengkapi masukan terlebih dahulu";
            this.WarningLabel.Visible = false;
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WelcomeLabel.AutoSize = false;
            this.WelcomeLabel.Location = new System.Drawing.Point(440, 200);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(635, 76);
            this.WelcomeLabel.StateCommon.LongText.MultiLine = Krypton.Toolkit.InheritBool.True;
            this.WelcomeLabel.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(127)))), ((int)(((byte)(141)))));
            this.WelcomeLabel.StateCommon.ShortText.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.WelcomeLabel.StateCommon.ShortText.MultiLine = Krypton.Toolkit.InheritBool.True;
            this.WelcomeLabel.TabIndex = 35;
            this.WelcomeLabel.Values.Text = "    Isi masukan terlebih dahulu, kemudian tekan tombol \'Mulai Pencarian!\' \r\n< unt" +
    "uk mulai menanam pohon DFS-BFS pertamamu! (Maksudnya, \r\n    mulai mencari file h" +
    "ehe)";
            this.WelcomeLabel.Paint += new System.Windows.Forms.PaintEventHandler(this.WelcomeLabel_Paint);
            // 
            // HasilLabel
            // 
            this.HasilLabel.Location = new System.Drawing.Point(453, 379);
            this.HasilLabel.Name = "HasilLabel";
            this.HasilLabel.Size = new System.Drawing.Size(110, 20);
            this.HasilLabel.TabIndex = 39;
            this.HasilLabel.Values.Text = "kryptonLinkLabel1";
            // 
            // TimeTitleLable
            // 
            this.TimeTitleLable.LabelStyle = Krypton.Toolkit.LabelStyle.Custom1;
            this.TimeTitleLable.Location = new System.Drawing.Point(453, 455);
            this.TimeTitleLable.Name = "TimeTitleLable";
            this.TimeTitleLable.Palette = this.kryptonPalette1;
            this.TimeTitleLable.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.TimeTitleLable.Size = new System.Drawing.Size(174, 22);
            this.TimeTitleLable.TabIndex = 41;
            this.TimeTitleLable.Values.Text = "Waktu yang dibutuhkan:";
            this.TimeTitleLable.Visible = false;
            // 
            // TimeLabel
            // 
            this.TimeLabel.LabelStyle = Krypton.Toolkit.LabelStyle.Custom1;
            this.TimeLabel.Location = new System.Drawing.Point(620, 455);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Palette = this.kryptonPalette1;
            this.TimeLabel.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.TimeLabel.Size = new System.Drawing.Size(26, 22);
            this.TimeLabel.TabIndex = 42;
            this.TimeLabel.Values.Text = "0s";
            this.TimeLabel.Visible = false;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(456, 46);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(88, 20);
            this.kryptonLabel4.TabIndex = 44;
            this.kryptonLabel4.Values.Text = "kryptonLabel1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1105, 508);
            this.Controls.Add(this.kryptonLabel4);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.TimeTitleLable);
            this.Controls.Add(this.HasilLabel);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.WarningLabel);
            this.Controls.Add(this.DitemukanLabel);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.BatalButton);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.kryptonWrapLabel1);
            this.Controls.Add(this.kryptonButton2);
            this.Controls.Add(this.PohonLabel);
            this.Controls.Add(this.DFS);
            this.Controls.Add(this.BFS);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.SemuaFileCheck);
            this.Controls.Add(this.kryptonTextBox1);
            this.Controls.Add(this.InputTitle);
            this.Controls.Add(this.StartingTitle);
            this.Controls.Add(this.FolderLabel);
            this.Controls.Add(this.BrowseFolderButton);
            this.MaximumSize = new System.Drawing.Size(1121, 547);
            this.MinimumSize = new System.Drawing.Size(1121, 547);
            this.Name = "Form1";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Folder Crawler";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private Krypton.Toolkit.KryptonButton BrowseFolderButton;
        private Krypton.Toolkit.KryptonLabel FolderLabel;
        private Krypton.Toolkit.KryptonLabel StartingTitle;
        private Krypton.Toolkit.KryptonLabel InputTitle;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private Krypton.Toolkit.KryptonCheckBox SemuaFileCheck;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonRadioButton BFS;
        private Krypton.Toolkit.KryptonRadioButton DFS;
        private Krypton.Toolkit.KryptonLabel PohonLabel;
        private Krypton.Toolkit.KryptonButton kryptonButton2;
        private Krypton.Toolkit.KryptonWrapLabel kryptonWrapLabel1;
        private Krypton.Toolkit.KryptonLabel Title;
        private Krypton.Toolkit.KryptonButton BatalButton;
        private FolderBrowserDialog folderBrowserDialog1;
        private Krypton.Toolkit.KryptonButton StartButton;
        private Krypton.Toolkit.KryptonLabel DitemukanLabel;
        private Krypton.Toolkit.KryptonLabel WarningLabel;
        private Krypton.Toolkit.KryptonLabel WelcomeLabel;
        private Krypton.Toolkit.KryptonLinkLabel HasilLabel;
        private Krypton.Toolkit.KryptonLabel TimeTitleLable;
        private Krypton.Toolkit.KryptonLabel TimeLabel;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
    }
}