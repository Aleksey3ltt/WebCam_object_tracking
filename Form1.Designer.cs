namespace WebCam_object_tracking
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.trackBar5 = new System.Windows.Forms.TrackBar();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.trackBar4 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(153, 23);
            this.comboBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(182, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Start video";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(640, 480);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(9, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Reference Template";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(9, 80);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(128, 128);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(9, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Pattern Tracking";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(156, 27);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Reset tracking";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "10",
            "25",
            "50",
            "75",
            "100",
            "150"});
            this.comboBox2.Location = new System.Drawing.Point(172, 23);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(45, 23);
            this.comboBox2.TabIndex = 9;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(154, 80);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(128, 128);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Update sequence";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(220, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "select the region of interest with the mouse";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(9, 214);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(273, 265);
            this.dataGridView1.TabIndex = 14;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Frame";
            this.Column1.Name = "Column1";
            this.Column1.Width = 70;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "X";
            this.Column2.Name = "Column2";
            this.Column2.Width = 70;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Y";
            this.Column3.Name = "Column3";
            this.Column3.Width = 70;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Location = new System.Drawing.Point(658, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 488);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Object tracking";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(154, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 15);
            this.label9.TabIndex = 15;
            this.label9.Text = "Auxiliary template";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.trackBar5);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.comboBox3);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.trackBar4);
            this.groupBox2.Controls.Add(this.trackBar3);
            this.groupBox2.Controls.Add(this.trackBar2);
            this.groupBox2.Controls.Add(this.trackBar1);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(954, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(224, 392);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filter settings";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 327);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 15);
            this.label11.TabIndex = 30;
            this.label11.Text = "maxValValid";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(172, 346);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(45, 23);
            this.textBox5.TabIndex = 29;
            // 
            // trackBar5
            // 
            this.trackBar5.LargeChange = 10;
            this.trackBar5.Location = new System.Drawing.Point(6, 346);
            this.trackBar5.Maximum = 100;
            this.trackBar5.Name = "trackBar5";
            this.trackBar5.Size = new System.Drawing.Size(162, 45);
            this.trackBar5.SmallChange = 5;
            this.trackBar5.TabIndex = 28;
            this.trackBar5.Value = 93;
            this.trackBar5.Scroll += new System.EventHandler(this.trackBar5_Scroll);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 15);
            this.label10.TabIndex = 27;
            this.label10.Text = "Threshold Arguments";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "25",
            "50",
            "100",
            "200"});
            this.comboBox3.Location = new System.Drawing.Point(172, 58);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(45, 23);
            this.comboBox3.TabIndex = 26;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 15);
            this.label8.TabIndex = 25;
            this.label8.Text = "Number of measurements";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 15);
            this.label7.TabIndex = 24;
            this.label7.Text = "maxVal2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 15);
            this.label6.TabIndex = 23;
            this.label6.Text = "minVal2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 22;
            this.label5.Text = "maxVal1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 21;
            this.label4.Text = "minVal1";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(172, 296);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(45, 23);
            this.textBox4.TabIndex = 20;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(172, 246);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(45, 23);
            this.textBox3.TabIndex = 19;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(172, 196);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(45, 23);
            this.textBox2.TabIndex = 18;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(172, 146);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(45, 23);
            this.textBox1.TabIndex = 17;
            // 
            // trackBar4
            // 
            this.trackBar4.LargeChange = 10;
            this.trackBar4.Location = new System.Drawing.Point(6, 296);
            this.trackBar4.Maximum = 100;
            this.trackBar4.Name = "trackBar4";
            this.trackBar4.Size = new System.Drawing.Size(162, 45);
            this.trackBar4.SmallChange = 5;
            this.trackBar4.TabIndex = 16;
            this.trackBar4.Value = 96;
            this.trackBar4.Scroll += new System.EventHandler(this.trackBar4_Scroll);
            // 
            // trackBar3
            // 
            this.trackBar3.LargeChange = 10;
            this.trackBar3.Location = new System.Drawing.Point(6, 246);
            this.trackBar3.Maximum = 100;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(162, 45);
            this.trackBar3.SmallChange = 5;
            this.trackBar3.TabIndex = 15;
            this.trackBar3.Value = 5;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // trackBar2
            // 
            this.trackBar2.LargeChange = 10;
            this.trackBar2.Location = new System.Drawing.Point(6, 196);
            this.trackBar2.Maximum = 100;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(162, 45);
            this.trackBar2.SmallChange = 5;
            this.trackBar2.TabIndex = 14;
            this.trackBar2.Value = 80;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(6, 146);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(162, 45);
            this.trackBar1.SmallChange = 5;
            this.trackBar1.TabIndex = 13;
            this.trackBar1.Value = 95;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 560);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Debugging the algorithm of DoubleTemplateMatching";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboBox1;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private Button button2;
        private Button button3;
        private ComboBox comboBox2;
        private PictureBox pictureBox3;
        private Label label2;
        private Label label3;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private GroupBox groupBox2;
        private TrackBar trackBar4;
        private TrackBar trackBar3;
        private TrackBar trackBar2;
        private TrackBar trackBar1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private ComboBox comboBox3;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox textBox5;
        private TrackBar trackBar5;
    }
}