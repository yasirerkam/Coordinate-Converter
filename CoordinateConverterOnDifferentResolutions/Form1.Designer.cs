﻿namespace CoordinateConverterOnDifferentResolutions
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.numericUpDownResolution1_Width = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.numericUpDownResolution1_Height = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxResolution1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownCoordinate2_X = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownCoordinate2_Y = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.numericUpDownResolution2_Height = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownResolution2_Width = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBoxScreen1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxCoordinate1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelY1 = new System.Windows.Forms.Label();
            this.numericUpDownCoordinate1_X = new System.Windows.Forms.NumericUpDown();
            this.labelX1 = new System.Windows.Forms.Label();
            this.numericUpDownCoordinate1_Y = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownResolution1_Width)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownResolution1_Height)).BeginInit();
            this.groupBoxResolution1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCoordinate2_X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCoordinate2_Y)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownResolution2_Height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownResolution2_Width)).BeginInit();
            this.groupBoxScreen1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBoxCoordinate1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCoordinate1_X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCoordinate1_Y)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // numericUpDownResolution1_Width
            // 
            this.numericUpDownResolution1_Width.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDownResolution1_Width.Location = new System.Drawing.Point(3, 29);
            this.numericUpDownResolution1_Width.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
            this.numericUpDownResolution1_Width.Name = "numericUpDownResolution1_Width";
            this.numericUpDownResolution1_Width.Size = new System.Drawing.Size(66, 20);
            this.numericUpDownResolution1_Width.TabIndex = 2;
            this.numericUpDownResolution1_Width.Value = new decimal(new int[] {
            1280,
            0,
            0,
            0});
            this.numericUpDownResolution1_Width.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.numericUpDownResolution1_Height, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDownResolution1_Width, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(144, 52);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // numericUpDownResolution1_Height
            // 
            this.numericUpDownResolution1_Height.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDownResolution1_Height.Location = new System.Drawing.Point(75, 29);
            this.numericUpDownResolution1_Height.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
            this.numericUpDownResolution1_Height.Name = "numericUpDownResolution1_Height";
            this.numericUpDownResolution1_Height.Size = new System.Drawing.Size(66, 20);
            this.numericUpDownResolution1_Height.TabIndex = 3;
            this.numericUpDownResolution1_Height.Value = new decimal(new int[] {
            720,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Height";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Width";
            // 
            // groupBoxResolution1
            // 
            this.groupBoxResolution1.AutoSize = true;
            this.groupBoxResolution1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxResolution1.Controls.Add(this.tableLayoutPanel1);
            this.groupBoxResolution1.Location = new System.Drawing.Point(3, 99);
            this.groupBoxResolution1.Name = "groupBoxResolution1";
            this.groupBoxResolution1.Size = new System.Drawing.Size(156, 90);
            this.groupBoxResolution1.TabIndex = 5;
            this.groupBoxResolution1.TabStop = false;
            this.groupBoxResolution1.Text = "Resolution";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 351);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.tableLayoutPanel5);
            this.groupBox1.Location = new System.Drawing.Point(209, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 230);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Screen 2";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.AutoSize = true;
            this.tableLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.groupBox3, 0, 1);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(162, 192);
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.tableLayoutPanel6);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(156, 90);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Coordinate";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.AutoSize = true;
            this.tableLayoutPanel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.numericUpDownCoordinate2_X, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.numericUpDownCoordinate2_Y, 1, 1);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(144, 52);
            this.tableLayoutPanel6.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Y";
            // 
            // numericUpDownCoordinate2_X
            // 
            this.numericUpDownCoordinate2_X.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDownCoordinate2_X.Location = new System.Drawing.Point(3, 29);
            this.numericUpDownCoordinate2_X.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
            this.numericUpDownCoordinate2_X.Name = "numericUpDownCoordinate2_X";
            this.numericUpDownCoordinate2_X.Size = new System.Drawing.Size(66, 20);
            this.numericUpDownCoordinate2_X.TabIndex = 7;
            this.numericUpDownCoordinate2_X.ValueChanged += new System.EventHandler(this.numericUpDownCoordinate2_X_ValueChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "X";
            // 
            // numericUpDownCoordinate2_Y
            // 
            this.numericUpDownCoordinate2_Y.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDownCoordinate2_Y.Location = new System.Drawing.Point(75, 29);
            this.numericUpDownCoordinate2_Y.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
            this.numericUpDownCoordinate2_Y.Name = "numericUpDownCoordinate2_Y";
            this.numericUpDownCoordinate2_Y.Size = new System.Drawing.Size(66, 20);
            this.numericUpDownCoordinate2_Y.TabIndex = 8;
            this.numericUpDownCoordinate2_Y.ValueChanged += new System.EventHandler(this.numericUpDownCoordinate2_Y_ValueChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox3.Controls.Add(this.tableLayoutPanel7);
            this.groupBox3.Location = new System.Drawing.Point(3, 99);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(156, 90);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resolution";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.AutoSize = true;
            this.tableLayoutPanel7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.numericUpDownResolution2_Height, 1, 1);
            this.tableLayoutPanel7.Controls.Add(this.label5, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.numericUpDownResolution2_Width, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(144, 52);
            this.tableLayoutPanel7.TabIndex = 1;
            // 
            // numericUpDownResolution2_Height
            // 
            this.numericUpDownResolution2_Height.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDownResolution2_Height.Location = new System.Drawing.Point(75, 29);
            this.numericUpDownResolution2_Height.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
            this.numericUpDownResolution2_Height.Name = "numericUpDownResolution2_Height";
            this.numericUpDownResolution2_Height.Size = new System.Drawing.Size(66, 20);
            this.numericUpDownResolution2_Height.TabIndex = 3;
            this.numericUpDownResolution2_Height.Value = new decimal(new int[] {
            768,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Height";
            // 
            // numericUpDownResolution2_Width
            // 
            this.numericUpDownResolution2_Width.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDownResolution2_Width.Location = new System.Drawing.Point(3, 29);
            this.numericUpDownResolution2_Width.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
            this.numericUpDownResolution2_Width.Name = "numericUpDownResolution2_Width";
            this.numericUpDownResolution2_Width.Size = new System.Drawing.Size(66, 20);
            this.numericUpDownResolution2_Width.TabIndex = 2;
            this.numericUpDownResolution2_Width.Value = new decimal(new int[] {
            1366,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Width";
            // 
            // groupBoxScreen1
            // 
            this.groupBoxScreen1.AutoSize = true;
            this.groupBoxScreen1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxScreen1.Controls.Add(this.tableLayoutPanel3);
            this.groupBoxScreen1.Location = new System.Drawing.Point(3, 3);
            this.groupBoxScreen1.Name = "groupBoxScreen1";
            this.groupBoxScreen1.Size = new System.Drawing.Size(174, 230);
            this.groupBoxScreen1.TabIndex = 1;
            this.groupBoxScreen1.TabStop = false;
            this.groupBoxScreen1.Text = "Screen 1";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.groupBoxCoordinate1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBoxResolution1, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(162, 192);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // groupBoxCoordinate1
            // 
            this.groupBoxCoordinate1.AutoSize = true;
            this.groupBoxCoordinate1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxCoordinate1.Controls.Add(this.tableLayoutPanel2);
            this.groupBoxCoordinate1.Location = new System.Drawing.Point(3, 3);
            this.groupBoxCoordinate1.Name = "groupBoxCoordinate1";
            this.groupBoxCoordinate1.Size = new System.Drawing.Size(156, 90);
            this.groupBoxCoordinate1.TabIndex = 1;
            this.groupBoxCoordinate1.TabStop = false;
            this.groupBoxCoordinate1.Text = "Coordinate";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.labelY1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.numericUpDownCoordinate1_X, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelX1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.numericUpDownCoordinate1_Y, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(144, 52);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // labelY1
            // 
            this.labelY1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelY1.AutoSize = true;
            this.labelY1.Location = new System.Drawing.Point(101, 6);
            this.labelY1.Name = "labelY1";
            this.labelY1.Size = new System.Drawing.Size(14, 13);
            this.labelY1.TabIndex = 5;
            this.labelY1.Text = "Y";
            // 
            // numericUpDownCoordinate1_X
            // 
            this.numericUpDownCoordinate1_X.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDownCoordinate1_X.Location = new System.Drawing.Point(3, 29);
            this.numericUpDownCoordinate1_X.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
            this.numericUpDownCoordinate1_X.Name = "numericUpDownCoordinate1_X";
            this.numericUpDownCoordinate1_X.Size = new System.Drawing.Size(66, 20);
            this.numericUpDownCoordinate1_X.TabIndex = 0;
            this.numericUpDownCoordinate1_X.ValueChanged += new System.EventHandler(this.numericUpDownCoordinate1_X_ValueChanged);
            // 
            // labelX1
            // 
            this.labelX1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelX1.AutoSize = true;
            this.labelX1.Location = new System.Drawing.Point(29, 6);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(14, 13);
            this.labelX1.TabIndex = 4;
            this.labelX1.Text = "X";
            // 
            // numericUpDownCoordinate1_Y
            // 
            this.numericUpDownCoordinate1_Y.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDownCoordinate1_Y.Location = new System.Drawing.Point(75, 29);
            this.numericUpDownCoordinate1_Y.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
            this.numericUpDownCoordinate1_Y.Name = "numericUpDownCoordinate1_Y";
            this.numericUpDownCoordinate1_Y.Size = new System.Drawing.Size(66, 20);
            this.numericUpDownCoordinate1_Y.TabIndex = 1;
            this.numericUpDownCoordinate1_Y.ValueChanged += new System.EventHandler(this.numericUpDownCoordinate1_Y_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.groupBoxScreen1);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(38, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(386, 236);
            this.panel2.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.SteelBlue;
            this.label7.Location = new System.Drawing.Point(55, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(353, 39);
            this.label7.TabIndex = 4;
            this.label7.Text = "YSR Coordinate Converter";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(459, 351);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(475, 390);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YSR Coordinate Converter";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownResolution1_Width)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownResolution1_Height)).EndInit();
            this.groupBoxResolution1.ResumeLayout(false);
            this.groupBoxResolution1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCoordinate2_X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCoordinate2_Y)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownResolution2_Height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownResolution2_Width)).EndInit();
            this.groupBoxScreen1.ResumeLayout(false);
            this.groupBoxScreen1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.groupBoxCoordinate1.ResumeLayout(false);
            this.groupBoxCoordinate1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCoordinate1_X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCoordinate1_Y)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownResolution1_Width;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownResolution1_Height;
        private System.Windows.Forms.GroupBox groupBoxResolution1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBoxCoordinate1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.NumericUpDown numericUpDownCoordinate1_Y;
        private System.Windows.Forms.Label labelY1;
        private System.Windows.Forms.NumericUpDown numericUpDownCoordinate1_X;
        private System.Windows.Forms.Label labelX1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox groupBoxScreen1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownCoordinate2_X;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownCoordinate2_Y;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.NumericUpDown numericUpDownResolution2_Height;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownResolution2_Width;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
    }
}

