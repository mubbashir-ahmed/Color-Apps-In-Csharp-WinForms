namespace ColorPickerApp
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
        private void InitializeComponent()
        {
            this.SelectedColorPropGroup = new System.Windows.Forms.GroupBox();
            this.pnlSelectedColor = new System.Windows.Forms.Panel();
            this.txtBVal = new System.Windows.Forms.TextBox();
            this.txtGVal = new System.Windows.Forms.TextBox();
            this.txtRVal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCopyHSL = new System.Windows.Forms.Button();
            this.btnCopyHSV = new System.Windows.Forms.Button();
            this.txtHSLVal = new System.Windows.Forms.TextBox();
            this.txtHSVVal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCopyCMYK = new System.Windows.Forms.Button();
            this.btnCopyHEX = new System.Windows.Forms.Button();
            this.btnCopyRGB = new System.Windows.Forms.Button();
            this.txtCMYKVal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtHEXVal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRGBVal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtColorVal = new System.Windows.Forms.TextBox();
            this.pnlColor = new System.Windows.Forms.Panel();
            this.btnClearFields = new System.Windows.Forms.Button();
            this.btnConversions = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.picbxColorSpectrum = new System.Windows.Forms.PictureBox();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.SelectedColorPropGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxColorSpectrum)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectedColorPropGroup
            // 
            this.SelectedColorPropGroup.Controls.Add(this.pnlSelectedColor);
            this.SelectedColorPropGroup.Controls.Add(this.txtBVal);
            this.SelectedColorPropGroup.Controls.Add(this.txtGVal);
            this.SelectedColorPropGroup.Controls.Add(this.txtRVal);
            this.SelectedColorPropGroup.Controls.Add(this.label4);
            this.SelectedColorPropGroup.Controls.Add(this.label3);
            this.SelectedColorPropGroup.Controls.Add(this.label2);
            this.SelectedColorPropGroup.Location = new System.Drawing.Point(12, 339);
            this.SelectedColorPropGroup.Name = "SelectedColorPropGroup";
            this.SelectedColorPropGroup.Size = new System.Drawing.Size(242, 127);
            this.SelectedColorPropGroup.TabIndex = 1;
            this.SelectedColorPropGroup.TabStop = false;
            this.SelectedColorPropGroup.Text = "Selected Color";
            // 
            // pnlSelectedColor
            // 
            this.pnlSelectedColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSelectedColor.Location = new System.Drawing.Point(142, 27);
            this.pnlSelectedColor.Name = "pnlSelectedColor";
            this.pnlSelectedColor.Size = new System.Drawing.Size(90, 90);
            this.pnlSelectedColor.TabIndex = 8;
            // 
            // txtBVal
            // 
            this.txtBVal.Location = new System.Drawing.Point(28, 98);
            this.txtBVal.MaxLength = 3;
            this.txtBVal.Name = "txtBVal";
            this.txtBVal.Size = new System.Drawing.Size(100, 20);
            this.txtBVal.TabIndex = 6;
            this.txtBVal.TextChanged += new System.EventHandler(this.txtBVal_TextChanged);
            // 
            // txtGVal
            // 
            this.txtGVal.Location = new System.Drawing.Point(28, 62);
            this.txtGVal.MaxLength = 3;
            this.txtGVal.Name = "txtGVal";
            this.txtGVal.Size = new System.Drawing.Size(100, 20);
            this.txtGVal.TabIndex = 5;
            this.txtGVal.TextChanged += new System.EventHandler(this.txtGVal_TextChanged);
            // 
            // txtRVal
            // 
            this.txtRVal.Location = new System.Drawing.Point(28, 26);
            this.txtRVal.MaxLength = 3;
            this.txtRVal.Name = "txtRVal";
            this.txtRVal.Size = new System.Drawing.Size(100, 20);
            this.txtRVal.TabIndex = 4;
            this.txtRVal.TextChanged += new System.EventHandler(this.txtRVal_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "B:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "G:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "R:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Simple Color Picker";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCopyHSL);
            this.groupBox1.Controls.Add(this.btnCopyHSV);
            this.groupBox1.Controls.Add(this.txtHSLVal);
            this.groupBox1.Controls.Add(this.txtHSVVal);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnCopyCMYK);
            this.groupBox1.Controls.Add(this.btnCopyHEX);
            this.groupBox1.Controls.Add(this.btnCopyRGB);
            this.groupBox1.Controls.Add(this.txtCMYKVal);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtHEXVal);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtRGBVal);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(269, 339);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 127);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Color Conversions";
            // 
            // btnCopyHSL
            // 
            this.btnCopyHSL.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCopyHSL.FlatAppearance.BorderSize = 0;
            this.btnCopyHSL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopyHSL.ForeColor = System.Drawing.Color.White;
            this.btnCopyHSL.Location = new System.Drawing.Point(364, 61);
            this.btnCopyHSL.Name = "btnCopyHSL";
            this.btnCopyHSL.Size = new System.Drawing.Size(41, 21);
            this.btnCopyHSL.TabIndex = 21;
            this.btnCopyHSL.Text = "Copy";
            this.btnCopyHSL.UseVisualStyleBackColor = false;
            this.btnCopyHSL.Click += new System.EventHandler(this.btnCopyHSL_Click);
            // 
            // btnCopyHSV
            // 
            this.btnCopyHSV.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCopyHSV.FlatAppearance.BorderSize = 0;
            this.btnCopyHSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopyHSV.ForeColor = System.Drawing.Color.White;
            this.btnCopyHSV.Location = new System.Drawing.Point(364, 25);
            this.btnCopyHSV.Name = "btnCopyHSV";
            this.btnCopyHSV.Size = new System.Drawing.Size(41, 21);
            this.btnCopyHSV.TabIndex = 22;
            this.btnCopyHSV.Text = "Copy";
            this.btnCopyHSV.UseVisualStyleBackColor = false;
            this.btnCopyHSV.Click += new System.EventHandler(this.btnCopyHSV_Click);
            // 
            // txtHSLVal
            // 
            this.txtHSLVal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHSLVal.Enabled = false;
            this.txtHSLVal.Location = new System.Drawing.Point(258, 62);
            this.txtHSLVal.Name = "txtHSLVal";
            this.txtHSLVal.ReadOnly = true;
            this.txtHSLVal.Size = new System.Drawing.Size(100, 20);
            this.txtHSLVal.TabIndex = 20;
            // 
            // txtHSVVal
            // 
            this.txtHSVVal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHSVVal.Enabled = false;
            this.txtHSVVal.Location = new System.Drawing.Point(258, 26);
            this.txtHSVVal.Name = "txtHSVVal";
            this.txtHSVVal.ReadOnly = true;
            this.txtHSVVal.Size = new System.Drawing.Size(100, 20);
            this.txtHSVVal.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(213, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "HSV:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(213, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "HSL:";
            // 
            // btnCopyCMYK
            // 
            this.btnCopyCMYK.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCopyCMYK.FlatAppearance.BorderSize = 0;
            this.btnCopyCMYK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopyCMYK.ForeColor = System.Drawing.Color.White;
            this.btnCopyCMYK.Location = new System.Drawing.Point(157, 97);
            this.btnCopyCMYK.Name = "btnCopyCMYK";
            this.btnCopyCMYK.Size = new System.Drawing.Size(41, 21);
            this.btnCopyCMYK.TabIndex = 16;
            this.btnCopyCMYK.Text = "Copy";
            this.btnCopyCMYK.UseVisualStyleBackColor = false;
            this.btnCopyCMYK.Click += new System.EventHandler(this.btnCopyCMYK_Click);
            // 
            // btnCopyHEX
            // 
            this.btnCopyHEX.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCopyHEX.FlatAppearance.BorderSize = 0;
            this.btnCopyHEX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopyHEX.ForeColor = System.Drawing.Color.White;
            this.btnCopyHEX.Location = new System.Drawing.Point(157, 61);
            this.btnCopyHEX.Name = "btnCopyHEX";
            this.btnCopyHEX.Size = new System.Drawing.Size(41, 21);
            this.btnCopyHEX.TabIndex = 16;
            this.btnCopyHEX.Text = "Copy";
            this.btnCopyHEX.UseVisualStyleBackColor = false;
            this.btnCopyHEX.Click += new System.EventHandler(this.btnCopyHEX_Click);
            // 
            // btnCopyRGB
            // 
            this.btnCopyRGB.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCopyRGB.FlatAppearance.BorderSize = 0;
            this.btnCopyRGB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopyRGB.ForeColor = System.Drawing.Color.White;
            this.btnCopyRGB.Location = new System.Drawing.Point(157, 25);
            this.btnCopyRGB.Name = "btnCopyRGB";
            this.btnCopyRGB.Size = new System.Drawing.Size(41, 21);
            this.btnCopyRGB.TabIndex = 15;
            this.btnCopyRGB.Text = "Copy";
            this.btnCopyRGB.UseVisualStyleBackColor = false;
            this.btnCopyRGB.Click += new System.EventHandler(this.btnCopyRGB_Click);
            // 
            // txtCMYKVal
            // 
            this.txtCMYKVal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCMYKVal.Enabled = false;
            this.txtCMYKVal.Location = new System.Drawing.Point(51, 98);
            this.txtCMYKVal.Name = "txtCMYKVal";
            this.txtCMYKVal.ReadOnly = true;
            this.txtCMYKVal.Size = new System.Drawing.Size(100, 20);
            this.txtCMYKVal.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "RGB:";
            // 
            // txtHEXVal
            // 
            this.txtHEXVal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHEXVal.Enabled = false;
            this.txtHEXVal.Location = new System.Drawing.Point(51, 62);
            this.txtHEXVal.Name = "txtHEXVal";
            this.txtHEXVal.ReadOnly = true;
            this.txtHEXVal.Size = new System.Drawing.Size(100, 20);
            this.txtHEXVal.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "HEX:";
            // 
            // txtRGBVal
            // 
            this.txtRGBVal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRGBVal.Enabled = false;
            this.txtRGBVal.Location = new System.Drawing.Point(51, 26);
            this.txtRGBVal.Name = "txtRGBVal";
            this.txtRGBVal.ReadOnly = true;
            this.txtRGBVal.Size = new System.Drawing.Size(100, 20);
            this.txtRGBVal.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "CMYK:";
            // 
            // txtColorVal
            // 
            this.txtColorVal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtColorVal.Enabled = false;
            this.txtColorVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColorVal.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtColorVal.Location = new System.Drawing.Point(40, 296);
            this.txtColorVal.Name = "txtColorVal";
            this.txtColorVal.ReadOnly = true;
            this.txtColorVal.Size = new System.Drawing.Size(300, 31);
            this.txtColorVal.TabIndex = 4;
            this.txtColorVal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlColor
            // 
            this.pnlColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlColor.Location = new System.Drawing.Point(365, 296);
            this.pnlColor.Name = "pnlColor";
            this.pnlColor.Size = new System.Drawing.Size(300, 31);
            this.pnlColor.TabIndex = 5;
            // 
            // btnClearFields
            // 
            this.btnClearFields.BackColor = System.Drawing.Color.Red;
            this.btnClearFields.FlatAppearance.BorderSize = 0;
            this.btnClearFields.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearFields.ForeColor = System.Drawing.Color.White;
            this.btnClearFields.Location = new System.Drawing.Point(345, 472);
            this.btnClearFields.Name = "btnClearFields";
            this.btnClearFields.Size = new System.Drawing.Size(75, 25);
            this.btnClearFields.TabIndex = 9;
            this.btnClearFields.Text = "Clear Fields";
            this.btnClearFields.UseVisualStyleBackColor = false;
            this.btnClearFields.Click += new System.EventHandler(this.btnClearFields_Click);
            // 
            // btnConversions
            // 
            this.btnConversions.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnConversions.FlatAppearance.BorderSize = 0;
            this.btnConversions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConversions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConversions.ForeColor = System.Drawing.Color.White;
            this.btnConversions.Location = new System.Drawing.Point(507, 472);
            this.btnConversions.Name = "btnConversions";
            this.btnConversions.Size = new System.Drawing.Size(184, 25);
            this.btnConversions.TabIndex = 10;
            this.btnConversions.Text = "Perform Conversions";
            this.btnConversions.UseVisualStyleBackColor = false;
            this.btnConversions.Click += new System.EventHandler(this.btnConversions_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(426, 472);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 25);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.SystemColors.Control;
            this.pnlMain.Controls.Add(this.pnlTitleBar);
            this.pnlMain.Controls.Add(this.picbxColorSpectrum);
            this.pnlMain.Controls.Add(this.SelectedColorPropGroup);
            this.pnlMain.Controls.Add(this.groupBox1);
            this.pnlMain.Controls.Add(this.btnSave);
            this.pnlMain.Controls.Add(this.btnHelp);
            this.pnlMain.Controls.Add(this.btnConversions);
            this.pnlMain.Controls.Add(this.btnClearFields);
            this.pnlMain.Controls.Add(this.txtColorVal);
            this.pnlMain.Controls.Add(this.pnlColor);
            this.pnlMain.Controls.Add(this.btnAbout);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(703, 511);
            this.pnlMain.TabIndex = 19;
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlTitleBar.Controls.Add(this.pictureBox1);
            this.pnlTitleBar.Controls.Add(this.btnMinimize);
            this.pnlTitleBar.Controls.Add(this.btnClose);
            this.pnlTitleBar.Controls.Add(this.label1);
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(703, 35);
            this.pnlTitleBar.TabIndex = 19;
            this.pnlTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseDown);
            this.pnlTitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseMove);
            this.pnlTitleBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ColorPickerApp.resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = global::ColorPickerApp.resources.minimize;
            this.btnMinimize.Location = new System.Drawing.Point(642, 6);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(23, 23);
            this.btnMinimize.TabIndex = 17;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            this.btnMinimize.MouseHover += new System.EventHandler(this.btnMinimize_MouseHover);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::ColorPickerApp.resources.close;
            this.btnClose.Location = new System.Drawing.Point(669, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(23, 23);
            this.btnClose.TabIndex = 16;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseHover += new System.EventHandler(this.btnClose_MouseHover);
            // 
            // picbxColorSpectrum
            // 
            this.picbxColorSpectrum.Image = global::ColorPickerApp.resources.spectrum;
            this.picbxColorSpectrum.Location = new System.Drawing.Point(12, 46);
            this.picbxColorSpectrum.Name = "picbxColorSpectrum";
            this.picbxColorSpectrum.Size = new System.Drawing.Size(680, 240);
            this.picbxColorSpectrum.TabIndex = 0;
            this.picbxColorSpectrum.TabStop = false;
            this.picbxColorSpectrum.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picbxColorSpectrum_MouseDown);
            this.picbxColorSpectrum.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picbxColorSpectrum_MouseMove);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.SystemColors.Control;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.Color.White;
            this.btnHelp.Image = global::ColorPickerApp.resources.help;
            this.btnHelp.Location = new System.Drawing.Point(43, 472);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(25, 25);
            this.btnHelp.TabIndex = 11;
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            this.btnHelp.MouseHover += new System.EventHandler(this.btnHelp_MouseHover);
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.SystemColors.Control;
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.ForeColor = System.Drawing.Color.White;
            this.btnAbout.Image = global::ColorPickerApp.resources.info;
            this.btnAbout.Location = new System.Drawing.Point(12, 472);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(25, 25);
            this.btnAbout.TabIndex = 12;
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            this.btnAbout.MouseHover += new System.EventHandler(this.btnAbout_MouseHover);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 511);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Color Picker";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SelectedColorPropGroup.ResumeLayout(false);
            this.SelectedColorPropGroup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxColorSpectrum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picbxColorSpectrum;
        private System.Windows.Forms.GroupBox SelectedColorPropGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBVal;
        private System.Windows.Forms.TextBox txtGVal;
        private System.Windows.Forms.TextBox txtRVal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlSelectedColor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCMYKVal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtHEXVal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRGBVal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCopyRGB;
        private System.Windows.Forms.Button btnCopyCMYK;
        private System.Windows.Forms.Button btnCopyHEX;
        private System.Windows.Forms.TextBox txtColorVal;
        private System.Windows.Forms.Panel pnlColor;
        private System.Windows.Forms.Button btnCopyHSL;
        private System.Windows.Forms.Button btnCopyHSV;
        private System.Windows.Forms.TextBox txtHSLVal;
        private System.Windows.Forms.TextBox txtHSVVal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnClearFields;
        private System.Windows.Forms.Button btnConversions;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

