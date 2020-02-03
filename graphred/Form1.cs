using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using graphred;
using System.Drawing.Text;
using System.IO;

namespace graphred
{
    public partial class Form1 : Form
    {
        ObjectType tool;
        List<Point> listOfPoints = new List<Point>();
        List<GraphObject> listOfGraphObjects = new List<GraphObject>();
        Point curentPoint = new Point();
        Point mouseDown = new Point();
        Point mouseUp = new Point();
        Color ContourColor = Color.Black;
        Color BodyColor = Color.White;
        Color TextColor = Color.Black;
        Font font1;
        FontFamily Family;
        float FSize;
        string s;
        public float d;
        public float w;
        public float h;

        public Form1()
        {
            InitializeComponent();
            pictureBox1.ImageLocation = @"Blank.bmp";
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                buttonColorK.BackColor = colorDialog1.Color;
                ContourColor = colorDialog1.Color;
            }
        }

        private void Font_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            //Family = ((ComboBox)sender).Text;
        }
        
        private void FontSize_SelectedIndexChanged(object sender, EventArgs e)
        {

            FSize = Convert.ToSingle(((ComboBox)sender).Text);
            font1 = new Font(FontF.Text, FSize);
            //FSize = float.Parse(FontSize.SelectedText);
        }


        private void textBox_TextChanged(object sender, EventArgs e)
        {
            s = textBox.Text;
        }

        
        private void ButtonLine_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < toolStrip1.Items.Count; i++)
            {
                toolStrip1.Items[i].BackColor = SystemColors.Control;
                toolStrip2.Items[i].BackColor = SystemColors.Control;
            }
            ButtonLine.BackColor = SystemColors.ControlDark;//Выделение кнопки

            if (listOfPoints.Count > 0)
            {
                CheckGraphObject(true);
                listOfPoints.Clear();
            }

            tool = ObjectType.Line;
        }

        private void CheckGraphObject(bool bFlush)
        {
            switch (tool)
            {
                case ObjectType.Line:
                    if (listOfPoints.Count == 2)
                    {
                        Line l = new Line(listOfPoints[0], listOfPoints[1]);
                        listOfPoints.Clear();
                        AddGraphObject(l);
                    }
                    break;
                case ObjectType.PolyLine:
                    if (bFlush && (listOfPoints.Count >= 2))
                    {
                        PolyLine p = new PolyLine(listOfPoints);
                        listOfPoints.Clear();
                        AddGraphObject(p);
                    }
                    break;
                case ObjectType.Rectangle:
                    if (listOfPoints.Count == 2)
                    {
                        w = Math.Abs(listOfPoints[0].X - listOfPoints[1].X);
                        h = Math.Abs(listOfPoints[0].Y - listOfPoints[1].Y);
                        Rectangle r = new Rectangle(listOfPoints[0], w, h);
                        listOfPoints.Clear();
                        AddGraphObject(r);
                    }
                    break;
                case ObjectType.Polygon:
                    if (bFlush && (listOfPoints.Count > 2))
                    {
                        Polygon p = new Polygon (listOfPoints);
                        listOfPoints.Clear();
                        AddGraphObject(p);
                    }
                    break;
                case ObjectType.Circle:
                    if (listOfPoints.Count == 2)
                    {
                        
                            if (Math.Abs(listOfPoints[1].X) > Math.Abs(listOfPoints[1].Y))
                            {
                                h = Math.Abs(listOfPoints[0].Y - listOfPoints[1].Y);
                                w = h;
                            }
                            else
                            {
                                w = Math.Abs(listOfPoints[0].X - listOfPoints[1].X);
                                h = w;
                            }
                        
                        Ellipse c = new Ellipse(listOfPoints[0], w, h);
                        listOfPoints.Clear();
                        AddGraphObject(c);
                    }
                    break;
                case ObjectType.Ellipse:
                    if (listOfPoints.Count == 2)
                    {
                        if (Math.Abs(listOfPoints[1].X) > Math.Abs(listOfPoints[1].Y))
                        {
                            h = Math.Abs(listOfPoints[0].Y - listOfPoints[1].Y);
                            w = Math.Abs(listOfPoints[0].X - listOfPoints[1].X);
                        }
                        else
                        {
                            w = Math.Abs(listOfPoints[0].X - listOfPoints[1].X);
                            h = Math.Abs(listOfPoints[0].Y - listOfPoints[1].Y);
                        }
                        Ellipse el = new Ellipse(listOfPoints[0], w, h);
                        listOfPoints.Clear();
                        AddGraphObject(el);
                    }
                    break;
                case ObjectType.Text:
                    if (listOfPoints.Count == 1)
                    {
                        Text t = new Text(listOfPoints[0]);
                        listOfPoints.Clear();
                        AddGraphObject(t);
                    }
                    break;
                case ObjectType.Bezier:
                    if (listOfPoints.Count == 4)
                    {
                        Bezier b = new Bezier(listOfPoints);
                        listOfPoints.Clear();
                        AddGraphObject(b);
                    }
                    break;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseDown.X = e.X;
                mouseDown.Y = e.Y;
                listOfPoints.Add(mouseDown);
                CheckGraphObject(false);
            }
            if (e.Button == MouseButtons.Right)
            {
                CheckGraphObject(true);
                listOfPoints.Clear();
            }
        }

        private void AddGraphObject(GraphObject obj)
        {
            obj.PenColor = ContourColor;
            obj.BrushColor = BodyColor;
            obj.TextColor = TextColor;
            obj.Transparancy = (byte)trackBarTransparancy.Value;
            obj.fontFamily = Family;
            obj.fontSize = FSize;
            obj.myFont = font1;
            obj.text = s;
            obj.PenWidth = (float)trackBarWidth.Value;//comboBoxWidth.SelectedIndex + 1;
            listOfGraphObjects.Add(obj);
            PaintObjects();
        }


        private void PaintObjects()
        {
            Bitmap bmp = new Bitmap(@"Blank.bmp", true);
            Graphics gr = Graphics.FromImage(bmp);

            foreach (GraphObject obj in listOfGraphObjects)
            {
                obj.Paint(gr);
            }
            switch (tool)
            {
                case ObjectType.Line:
                    if (listOfPoints.Count > 0)
                    {
                        Line l = new Line(listOfPoints[0], curentPoint);
                        l.PenColor = ContourColor;
                        l.Transparancy = (byte)trackBarTransparancy.Value;
                        l.PenWidth = (float)trackBarWidth.Value;
                        l.Transparancy = (byte)trackBarTransparancy.Value;
                        l.Paint(gr);
                    }
                    break;
                case ObjectType.PolyLine:
                    if ((listOfPoints.Count == 1))
                    {
                        Line l = new Line(listOfPoints[0], curentPoint);
                        l.PenColor = ContourColor;
                        l.Transparancy = (byte)trackBarTransparancy.Value;
                        l.PenWidth = (float)trackBarWidth.Value;
                        l.Transparancy = (byte)trackBarTransparancy.Value;
                        l.Paint(gr);
                    }
                    if ((listOfPoints.Count > 1))
                    {
                        if (listOfPoints[listOfPoints.Count - 1] == mouseDown)
                        {
                            listOfPoints.RemoveAt(listOfPoints.Count - 1);
                            curentPoint = mouseDown;
                        }
                        PolyLine p = new PolyLine(listOfPoints);
                        Line l = new Line(listOfPoints[listOfPoints.Count - 1], curentPoint);
                        p.PenColor = ContourColor;
                        p.Transparancy = (byte)trackBarTransparancy.Value;
                        p.PenWidth = (float)trackBarWidth.Value;
                        p.Transparancy = (byte)trackBarTransparancy.Value;
                        l.PenColor = ContourColor;
                        l.Transparancy = (byte)trackBarTransparancy.Value;
                        l.PenWidth = (float)trackBarWidth.Value;
                        l.Transparancy = (byte)trackBarTransparancy.Value;
                        l.Paint(gr);
                        p.Paint(gr);
                    }
                    break;
                case ObjectType.Rectangle:
                    if (listOfPoints.Count > 0)
                    {
                        if (listOfPoints.Count > 0)
                        {
                            Rectangle r = new Rectangle(listOfPoints[0], Math.Abs(listOfPoints[0].X - curentPoint.X), Math.Abs(listOfPoints[0].Y - curentPoint.Y));
                            r.PenColor = ContourColor;
                            r.BrushColor = BackColor;
                            r.PenWidth = (float)trackBarWidth.Value;
                            r.Transparancy = (byte)trackBarTransparancy.Value;
                            r.Paint(gr);
                        }
                    }
                    break;
                case ObjectType.Polygon:
                    if ((listOfPoints.Count == 1))
                    {
                        Line l = new Line(listOfPoints[0], curentPoint);
                        l.PenColor = ContourColor;
                        l.Transparancy = (byte)trackBarTransparancy.Value;
                        l.PenWidth = (float)trackBarWidth.Value;
                        l.Transparancy = (byte)trackBarTransparancy.Value;
                        l.Paint(gr);
                    }
                    if ((listOfPoints.Count > 1))
                    {
                        if (listOfPoints[listOfPoints.Count - 1] == mouseDown)
                        {
                            listOfPoints.RemoveAt(listOfPoints.Count - 1);
                            curentPoint = mouseDown;
                        }
                        if ((listOfPoints[listOfPoints.Count - 1].X <= listOfPoints[0].X + 3) &&
                            (listOfPoints[listOfPoints.Count - 1].X >= listOfPoints[0].X - 3) &&
                            (listOfPoints[listOfPoints.Count - 1].Y <= listOfPoints[0].Y + 3) &&
                            (listOfPoints[listOfPoints.Count - 1].Y >= listOfPoints[0].Y - 3))
                        {
                            listOfPoints.RemoveAt(listOfPoints.Count - 1);
                            CheckGraphObject(true);
                            listOfPoints.Clear();
                        }
                        else
                        {
                            PolyLine p = new PolyLine(listOfPoints);
                            Line l = new Line(listOfPoints[listOfPoints.Count - 1], curentPoint);
                            p.PenColor = ContourColor;
                            p.Transparancy = (byte)trackBarTransparancy.Value;
                            p.PenWidth = (float)trackBarWidth.Value;
                            p.Transparancy = (byte)trackBarTransparancy.Value;
                            l.PenColor = ContourColor;
                            l.Transparancy = (byte)trackBarTransparancy.Value;
                            l.PenWidth = (float)trackBarWidth.Value;
                            l.Transparancy = (byte)trackBarTransparancy.Value;
                            l.Paint(gr);
                            p.Paint(gr);
                        }
                    }
                    break;
                case ObjectType.Circle:
                    if (listOfPoints.Count > 0)
                    {
                        
                            if (Math.Abs(curentPoint.X)> Math.Abs(curentPoint.Y))
                            {
                                h = Math.Abs(listOfPoints[0].Y - curentPoint.Y);
                                w = h;
                            }
                            else
                            {
                                w = Math.Abs(listOfPoints[0].X - curentPoint.X);
                                h = w;
                            }
                        
                        Ellipse c = new Ellipse(listOfPoints[0], w, h);
                        c.PenColor = ContourColor;
                        c.BrushColor = BackColor;
                        c.Transparancy = (byte)trackBarTransparancy.Value;
                        c.PenWidth = (float)trackBarWidth.Value;
                        c.Transparancy = (byte)trackBarTransparancy.Value;
                        c.Paint(gr);
                    }
                    break;
                case ObjectType.Ellipse:
                    if (listOfPoints.Count > 0)
                    {
                            if (Math.Abs(curentPoint.X) > Math.Abs(curentPoint.Y))
                            {
                                h = Math.Abs(listOfPoints[0].Y - curentPoint.Y);
                                w = Math.Abs(listOfPoints[0].X - curentPoint.X);
                            }
                            else
                            {
                                w = Math.Abs(listOfPoints[0].X - curentPoint.X);
                                h = Math.Abs(listOfPoints[0].Y - curentPoint.Y);
                            }
                        Ellipse el = new Ellipse(listOfPoints[0], w, h);
                        el.PenColor = ContourColor;
                        el.BrushColor = BackColor;
                        el.Transparancy = (byte)trackBarTransparancy.Value;
                        el.PenWidth = (float)trackBarWidth.Value;
                        el.Transparancy = (byte)trackBarTransparancy.Value;
                        el.Paint(gr);
                    }
                    break;
                case ObjectType.Text:
                    if (listOfPoints.Count > 0)
                    {
                        Text t = new Text(listOfPoints[0]);
                        t.TextColor = TextColor;
                        t.Transparancy = (byte)trackBarTransparancy.Value;
                        t.text = s;
                        t.myFont = font1;
                        t.Paint(gr);
                        listOfPoints.Clear();
                    }
                    break;
                case ObjectType.Bezier:
                    if (listOfPoints.Count == 4)
                    {

                        Bezier b = new Bezier(listOfPoints);
                        b.PenColor = ContourColor;
                        b.Transparancy = (byte)trackBarTransparancy.Value;
                        b.PenWidth = (float)trackBarWidth.Value;
                        b.Transparancy = (byte)trackBarTransparancy.Value;
                        b.Paint(gr);
                    }
                    break;
            }
            pictureBox1.Image = bmp;
        }

        private void ButtonPolyline_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < toolStrip1.Items.Count; i++)
            {
                toolStrip1.Items[i].BackColor = SystemColors.Control;
                toolStrip2.Items[i].BackColor = SystemColors.Control;
            }
            ButtonPolyline.BackColor = SystemColors.ControlDark;//Выделение кнопки

            if (listOfPoints.Count > 0)
            {
                CheckGraphObject(true);
                listOfPoints.Clear();
            }

            tool = ObjectType.PolyLine;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                curentPoint.X = e.X;
                curentPoint.Y = e.Y;
                PaintObjects();
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            curentPoint.X = e.X;
            curentPoint.Y = e.Y;
            mouseUp.X = e.X;
            mouseUp.Y = e.Y;
            if ((tool != ObjectType.Text) && (tool != ObjectType.Bezier))
                listOfPoints.Add(mouseUp);
            CheckGraphObject(false);
        }

        private void ButtonRectangle_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < toolStrip1.Items.Count; i++)
            {
                toolStrip1.Items[i].BackColor = SystemColors.Control;
                toolStrip2.Items[i].BackColor = SystemColors.Control;
            }
            ButtonRectangle.BackColor = SystemColors.ControlDark;//Выделение кнопки

            if (listOfPoints.Count > 0)
            {
                CheckGraphObject(true);
                listOfPoints.Clear();
            }

            tool = ObjectType.Rectangle;
        }

        private void buttonColorB_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                buttonColorB.BackColor = colorDialog1.Color;
                BodyColor = colorDialog1.Color;
            }
        }

        private void ButtonPolygon_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < toolStrip1.Items.Count; i++)
            {
                toolStrip1.Items[i].BackColor = SystemColors.Control;
                toolStrip2.Items[i].BackColor = SystemColors.Control;
            }
            ButtonPolygon.BackColor = SystemColors.ControlDark;//Выделение кнопки

            if (listOfPoints.Count > 0)
            {
                CheckGraphObject(true);
                listOfPoints.Clear();
            }

            tool = ObjectType.Polygon;
        }

        private void ButtonCircle_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < toolStrip1.Items.Count; i++)
            {
                toolStrip1.Items[i].BackColor = SystemColors.Control;
                toolStrip2.Items[i].BackColor = SystemColors.Control;
            }
            ButtonCircle.BackColor = SystemColors.ControlDark;//Выделение кнопки

            if (listOfPoints.Count > 0)
            {
                CheckGraphObject(true);
                listOfPoints.Clear();
            }

            tool = ObjectType.Circle;
        }

        private void ButtonEllipse_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < toolStrip1.Items.Count; i++)
            {
                toolStrip1.Items[i].BackColor = SystemColors.Control;
                toolStrip2.Items[i].BackColor = SystemColors.Control;
            }
            ButtonEllipse.BackColor = SystemColors.ControlDark;//Выделение кнопки

            if (listOfPoints.Count > 0)
            {
                CheckGraphObject(true);
                listOfPoints.Clear();
            }

            tool = ObjectType.Ellipse;
        }

        private void ButtonText_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < toolStrip1.Items.Count; i++)
            {
                toolStrip1.Items[i].BackColor = SystemColors.Control;
                toolStrip2.Items[i].BackColor = SystemColors.Control;
            }
            ButtonText.BackColor = SystemColors.ControlDark;//Выделение кнопки

            if (listOfPoints.Count > 0)
            {
                CheckGraphObject(true);
                listOfPoints.Clear();
            }

            tool = ObjectType.Text;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ButtonBezier_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < toolStrip1.Items.Count; i++)
            {
                toolStrip1.Items[i].BackColor = SystemColors.Control;
                toolStrip2.Items[i].BackColor = SystemColors.Control;
            }
            ButtonBezier.BackColor = SystemColors.ControlDark;//Выделение кнопки

            if (listOfPoints.Count > 0)
            {
                CheckGraphObject(true);
                listOfPoints.Clear();
            }

            tool = ObjectType.Bezier;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InstalledFontCollection inst = new InstalledFontCollection();
            foreach (FontFamily fnt in inst.Families)
            {
               FontF.Items.Add(fnt.Name);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog savedialog = new SaveFileDialog();
            savedialog.Filter = "Image files (*.BMP)| *.bmp";
            if (savedialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = savedialog.FileName;
                string strFilExtn = fileName.Remove(fileName.Length - 3, 3);
                pictureBox1.Image.Save(fileName, System.Drawing.Imaging.ImageFormat.Bmp);

                FileStream file1 = new FileStream(strFilExtn + "txt", FileMode.Create); //создаем файловый поток
                StreamWriter writer = new StreamWriter(file1); //создаем «потоковый писатель» и связываем его с файловым потоком 
                for (int i = 0; i < listOfGraphObjects.Count; i++)
                {
                    writer.WriteLine(listOfGraphObjects[i].Serialize());
                }
                writer.Close();
            }
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog opendialog = new OpenFileDialog();
            opendialog.Filter = "Image files (*.TXT)| *.txt";
            if (opendialog.ShowDialog() == DialogResult.OK)
            {
                FileStream file1 = new FileStream(opendialog.FileName, FileMode.Open); //создаем файловый поток
                StreamReader reader = new StreamReader(file1); // создаем «потоковый читатель» и связываем его с файловым потоком 
                while (reader.Peek() >= 0)
                {
                    string str = reader.ReadLine();
                    switch (str[0])
                    {
                        case 'L':
                            {
                                Line l = new Line();
                                l.Deserialize(str);
                                listOfGraphObjects.Add(l);
                                break;
                            }
                        case 'P':
                            {
                                PolyLine l = new PolyLine();
                                l.Deserialize(str);
                                listOfGraphObjects.Add(l);
                                break;
                            }
                        case 'M':
                            {
                                Polygon l = new Polygon();
                                l.Deserialize(str);
                                listOfGraphObjects.Add(l);
                                break;
                            }
                        case 'R':
                            {
                                Rectangle l = new Rectangle();
                                l.Deserialize(str);
                                listOfGraphObjects.Add(l);
                                break;
                            }
                        case 'E':
                            {
                                Ellipse l = new Ellipse();
                                l.Deserialize(str);
                                listOfGraphObjects.Add(l);
                                break;
                            }
                        case 'C':
                            {
                                Circle l = new Circle();
                                l.Deserialize(str);
                                listOfGraphObjects.Add(l);
                                break;
                            }
                        case 'T':
                            {
                                Text l = new Text();
                                l.Deserialize(str);
                                listOfGraphObjects.Add(l);
                                break;
                            }
                        case 'B':
                            {
                                Bezier l = new Bezier();
                                l.Deserialize(str);
                                listOfGraphObjects.Add(l);
                                break;
                            }
                    }
                }
                PaintObjects();
            }
        }

        private void buttonColorT_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                buttonColorT.BackColor = colorDialog1.Color;
                TextColor = colorDialog1.Color;
            }
        }
    }
    
}
