namespace graphred
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.buttonColorK = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FontSize = new System.Windows.Forms.ComboBox();
            this.FontF = new System.Windows.Forms.ComboBox();
            this.textBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.ButtonBezier = new System.Windows.Forms.ToolStripButton();
            this.ButtonCircle = new System.Windows.Forms.ToolStripButton();
            this.ButtonEllipse = new System.Windows.Forms.ToolStripButton();
            this.ButtonText = new System.Windows.Forms.ToolStripButton();
            this.trackBarTransparancy = new System.Windows.Forms.TrackBar();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ButtonLine = new System.Windows.Forms.ToolStripButton();
            this.ButtonPolyline = new System.Windows.Forms.ToolStripButton();
            this.ButtonPolygon = new System.Windows.Forms.ToolStripButton();
            this.ButtonRectangle = new System.Windows.Forms.ToolStripButton();
            this.label4 = new System.Windows.Forms.Label();
            this.trackBarWidth = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonColorB = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonColorT = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTransparancy)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonColorK
            // 
            this.buttonColorK.BackColor = System.Drawing.Color.Black;
            this.buttonColorK.Location = new System.Drawing.Point(134, 118);
            this.buttonColorK.Name = "buttonColorK";
            this.buttonColorK.Size = new System.Drawing.Size(32, 31);
            this.buttonColorK.TabIndex = 2;
            this.buttonColorK.UseVisualStyleBackColor = false;
            this.buttonColorK.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonColorT);
            this.panel1.Controls.Add(this.FontSize);
            this.panel1.Controls.Add(this.FontF);
            this.panel1.Controls.Add(this.textBox);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Controls.Add(this.buttonOpen);
            this.panel1.Controls.Add(this.toolStrip2);
            this.panel1.Controls.Add(this.trackBarTransparancy);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.trackBarWidth);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.buttonColorK);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonColorB);
            this.panel1.Location = new System.Drawing.Point(0, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 643);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // FontSize
            // 
            this.FontSize.FormattingEnabled = true;
            this.FontSize.Items.AddRange(new object[] {
            "6",
            "8",
            "10",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "30",
            "32",
            "34",
            "36"});
            this.FontSize.Location = new System.Drawing.Point(147, 365);
            this.FontSize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FontSize.Name = "FontSize";
            this.FontSize.Size = new System.Drawing.Size(73, 28);
            this.FontSize.TabIndex = 21;
            this.FontSize.SelectedIndexChanged += new System.EventHandler(this.FontSize_SelectedIndexChanged);
            // 
            // FontF
            // 
            this.FontF.FormattingEnabled = true;
            this.FontF.Location = new System.Drawing.Point(76, 325);
            this.FontF.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FontF.Name = "FontF";
            this.FontF.Size = new System.Drawing.Size(144, 28);
            this.FontF.TabIndex = 20;
            this.FontF.SelectedIndexChanged += new System.EventHandler(this.Font_SelectedIndexChanged);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(76, 434);
            this.textBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(144, 26);
            this.textBox.TabIndex = 19;
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 438);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Текст:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 403);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Цвет шрифта:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 369);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Размер шрифта:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Шрифт:";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(118, 605);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(105, 35);
            this.buttonSave.TabIndex = 14;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(0, 605);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(112, 35);
            this.buttonOpen.TabIndex = 13;
            this.buttonOpen.Text = "Открыть";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ButtonBezier,
            this.ButtonCircle,
            this.ButtonEllipse,
            this.ButtonText});
            this.toolStrip2.Location = new System.Drawing.Point(0, 37);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip2.Size = new System.Drawing.Size(226, 37);
            this.toolStrip2.TabIndex = 5;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // ButtonBezier
            // 
            this.ButtonBezier.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButtonBezier.Image = global::graphred.Properties.Resources._3;
            this.ButtonBezier.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonBezier.Name = "ButtonBezier";
            this.ButtonBezier.Size = new System.Drawing.Size(34, 34);
            this.ButtonBezier.Text = "toolStripButton1";
            this.ButtonBezier.Click += new System.EventHandler(this.ButtonBezier_Click);
            // 
            // ButtonCircle
            // 
            this.ButtonCircle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButtonCircle.Image = global::graphred.Properties.Resources._6;
            this.ButtonCircle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonCircle.Name = "ButtonCircle";
            this.ButtonCircle.Size = new System.Drawing.Size(34, 34);
            this.ButtonCircle.Text = "Круг";
            this.ButtonCircle.Click += new System.EventHandler(this.ButtonCircle_Click);
            // 
            // ButtonEllipse
            // 
            this.ButtonEllipse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButtonEllipse.Image = global::graphred.Properties.Resources._7;
            this.ButtonEllipse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonEllipse.Name = "ButtonEllipse";
            this.ButtonEllipse.Size = new System.Drawing.Size(34, 34);
            this.ButtonEllipse.Text = "toolStripButton3";
            this.ButtonEllipse.Click += new System.EventHandler(this.ButtonEllipse_Click);
            // 
            // ButtonText
            // 
            this.ButtonText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButtonText.Image = global::graphred.Properties.Resources._8;
            this.ButtonText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonText.Name = "ButtonText";
            this.ButtonText.Size = new System.Drawing.Size(34, 34);
            this.ButtonText.Text = "toolStripButton4";
            this.ButtonText.Click += new System.EventHandler(this.ButtonText_Click);
            // 
            // trackBarTransparancy
            // 
            this.trackBarTransparancy.AutoSize = false;
            this.trackBarTransparancy.Location = new System.Drawing.Point(118, 248);
            this.trackBarTransparancy.Maximum = 255;
            this.trackBarTransparancy.Name = "trackBarTransparancy";
            this.trackBarTransparancy.Size = new System.Drawing.Size(106, 29);
            this.trackBarTransparancy.TabIndex = 12;
            this.trackBarTransparancy.Value = 255;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ButtonLine,
            this.ButtonPolyline,
            this.ButtonPolygon,
            this.ButtonRectangle});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(226, 37);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ButtonLine
            // 
            this.ButtonLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButtonLine.Image = global::graphred.Properties.Resources._1;
            this.ButtonLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonLine.Name = "ButtonLine";
            this.ButtonLine.Size = new System.Drawing.Size(34, 34);
            this.ButtonLine.Text = "Линия";
            this.ButtonLine.Click += new System.EventHandler(this.ButtonLine_Click);
            // 
            // ButtonPolyline
            // 
            this.ButtonPolyline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButtonPolyline.Image = global::graphred.Properties.Resources._2;
            this.ButtonPolyline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonPolyline.Name = "ButtonPolyline";
            this.ButtonPolyline.Size = new System.Drawing.Size(34, 34);
            this.ButtonPolyline.Text = "Полилиния";
            this.ButtonPolyline.Click += new System.EventHandler(this.ButtonPolyline_Click);
            // 
            // ButtonPolygon
            // 
            this.ButtonPolygon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButtonPolygon.Image = global::graphred.Properties.Resources._4;
            this.ButtonPolygon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonPolygon.Name = "ButtonPolygon";
            this.ButtonPolygon.Size = new System.Drawing.Size(34, 34);
            this.ButtonPolygon.Text = "Полигон";
            this.ButtonPolygon.Click += new System.EventHandler(this.ButtonPolygon_Click);
            // 
            // ButtonRectangle
            // 
            this.ButtonRectangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButtonRectangle.Image = global::graphred.Properties.Resources._5;
            this.ButtonRectangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonRectangle.Name = "ButtonRectangle";
            this.ButtonRectangle.Size = new System.Drawing.Size(34, 34);
            this.ButtonRectangle.Text = "Прямоугольник";
            this.ButtonRectangle.Click += new System.EventHandler(this.ButtonRectangle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Прозрачность:";
            // 
            // trackBarWidth
            // 
            this.trackBarWidth.AutoSize = false;
            this.trackBarWidth.Location = new System.Drawing.Point(118, 214);
            this.trackBarWidth.Minimum = 1;
            this.trackBarWidth.Name = "trackBarWidth";
            this.trackBarWidth.Size = new System.Drawing.Size(106, 29);
            this.trackBarWidth.TabIndex = 10;
            this.trackBarWidth.Value = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Цвет контура:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Цвет заливки:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Толщина:";
            // 
            // buttonColorB
            // 
            this.buttonColorB.BackColor = System.Drawing.Color.White;
            this.buttonColorB.Location = new System.Drawing.Point(134, 155);
            this.buttonColorB.Name = "buttonColorB";
            this.buttonColorB.Size = new System.Drawing.Size(32, 29);
            this.buttonColorB.TabIndex = 8;
            this.buttonColorB.UseVisualStyleBackColor = false;
            this.buttonColorB.Click += new System.EventHandler(this.buttonColorB_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(227, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(806, 643);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // buttonColorT
            // 
            this.buttonColorT.BackColor = System.Drawing.Color.Black;
            this.buttonColorT.Location = new System.Drawing.Point(134, 398);
            this.buttonColorT.Name = "buttonColorT";
            this.buttonColorT.Size = new System.Drawing.Size(32, 31);
            this.buttonColorT.TabIndex = 22;
            this.buttonColorT.UseVisualStyleBackColor = false;
            this.buttonColorT.Click += new System.EventHandler(this.buttonColorT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 652);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTransparancy)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button buttonColorK;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ButtonLine;
        private System.Windows.Forms.ToolStripButton ButtonPolyline;
        private System.Windows.Forms.ToolStripButton ButtonPolygon;
        private System.Windows.Forms.ToolStripButton ButtonRectangle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonColorB;
        private System.Windows.Forms.TrackBar trackBarWidth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackBarTransparancy;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton ButtonBezier;
        private System.Windows.Forms.ToolStripButton ButtonCircle;
        private System.Windows.Forms.ToolStripButton ButtonEllipse;
        private System.Windows.Forms.ToolStripButton ButtonText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox FontSize;
        private System.Windows.Forms.ComboBox FontF;
        private System.Windows.Forms.Button buttonColorT;
    }
}

