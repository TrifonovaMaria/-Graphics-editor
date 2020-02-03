using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graphred
{
    public class Ellipse:  GraphObject
    {
        public Point Begin = new Point();
        float Width;
        float Hight;

        public Ellipse()
        {

        }

        public Ellipse(Point p, float w, float h)
        {
            type = ObjectType.Ellipse;
            Begin = p;
            Width= w;
            Hight = h;
        }
        public override void Paint(Graphics gr)
        {
            SolidBrush B = new SolidBrush(BrushColor);
            Pen P = new Pen(PenColor);
            P.Color = Color.FromArgb(Transparancy, P.Color);
            B.Color = Color.FromArgb(Transparancy, B.Color);
            P.Width = PenWidth;
            gr.DrawEllipse(P, Begin.X, Begin.Y, Width, Hight);
            gr.FillEllipse(B, Begin.X + P.Width/2, Begin.Y + P.Width/2, Width - P.Width, Hight - P.Width);
        }
        public override void Deserialize(string str)
        {
            String[] substrings = str.Split(',');
            PenWidth = (float)Convert.ToSingle(substrings[1]);
            Transparancy = (byte)Convert.ToSingle(substrings[2]);
            PenColor = Color.FromArgb(Transparancy,
                (byte)Convert.ToSingle(substrings[3]),
                (byte)Convert.ToSingle(substrings[4]),
                (byte)Convert.ToSingle(substrings[5]));
            BrushColor = Color.FromArgb(Transparancy,
                (byte)Convert.ToSingle(substrings[6]),
                (byte)Convert.ToSingle(substrings[7]),
                (byte)Convert.ToSingle(substrings[8]));
            Begin.X = (int)Convert.ToSingle(substrings[9]);
            Begin.Y = (int)Convert.ToSingle(substrings[10]);
            Width = (float)Convert.ToSingle(substrings[11]);
            Hight = (float)Convert.ToSingle(substrings[12]);
        }
        public override string Serialize()
        {
            string str = "E," + Convert.ToString(PenWidth) + ","
                + Convert.ToString(Transparancy) + ","
                + Convert.ToString(PenColor.R) + ","
                + Convert.ToString(PenColor.G) + ","
                + Convert.ToString(PenColor.B) + ","
                + Convert.ToString(BrushColor.R) + ","
                + Convert.ToString(BrushColor.G) + ","
                + Convert.ToString(BrushColor.B) + ","
                + Convert.ToString(Begin.X) + ","
                + Convert.ToString(Begin.Y) + ","
                + Convert.ToString(Width) + ","
                + Convert.ToString(Hight);
            return str;
        }
    }
}

