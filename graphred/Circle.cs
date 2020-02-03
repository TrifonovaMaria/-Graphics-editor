using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graphred
{
    public class Circle: GraphObject
    {
        public Point Begin = new Point();
        float Radius;
        public Circle()
        {

        }
        public Circle(Point p, float r)
        {
            type = ObjectType.Circle;
            Begin = p;
            Radius = r;
        }
        public override void Paint(Graphics gr)
        {
            SolidBrush B = new SolidBrush(BrushColor);
            Pen P = new Pen(PenColor);
            P.Color = Color.FromArgb(Transparancy, P.Color);
            B.Color = Color.FromArgb(Transparancy, B.Color);
            P.Width = PenWidth;
            gr.DrawEllipse(P, Begin.X, Begin.Y, 2*Radius, 2*Radius);
            gr.FillEllipse(B, Begin.X + P.Width / 2, Begin.Y + P.Width / 2, 2 * Radius - P.Width, 2 * Radius - P.Width);

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
            Radius = (float)Convert.ToSingle(substrings[11]);
        }
        public override string Serialize()
        {
            string str = "C," + Convert.ToString(PenWidth) + ","
                + Convert.ToString(Transparancy) + ","
                + Convert.ToString(PenColor.R) + ","
                + Convert.ToString(PenColor.G) + ","
                + Convert.ToString(PenColor.B) + ","
                + Convert.ToString(BrushColor.R) + ","
                + Convert.ToString(BrushColor.G) + ","
                + Convert.ToString(BrushColor.B) + ","
                + Convert.ToString(Begin.X) + ","
                + Convert.ToString(Begin.Y) + ","
                + Convert.ToString(Radius);
            return str;
        }
    }
}
