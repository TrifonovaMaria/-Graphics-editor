using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graphred
{
    public class Line: GraphObject
    {
        public Point Begin = new Point();
        public Point End = new Point();

        public Line()
        {

        }

        public Line(Point B, Point E)
        {
            type = ObjectType.Line;
            Begin = B;
            End = E;
        }

        public override void Paint(Graphics gr)
        {
            Pen P = new Pen(PenColor);
            P.Color = Color.FromArgb(Transparancy, P.Color);
            P.Width = PenWidth;
            gr.DrawLine(P, Begin, End);
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
            Begin.X = (int)Convert.ToSingle(substrings[6]);
            Begin.Y = (int)Convert.ToSingle(substrings[7]);
            End.X = (int)Convert.ToSingle(substrings[8]);
            End.Y = (int)Convert.ToSingle(substrings[9]);
        }
        public override string Serialize()
        {
            string str = "L," + Convert.ToString(PenWidth) + ","
                + Convert.ToString(Transparancy) + ","
                + Convert.ToString(PenColor.R) + ","
                + Convert.ToString(PenColor.G) + ","
                + Convert.ToString(PenColor.B) + ","
                + Convert.ToString(Begin.X) + ","
                + Convert.ToString(Begin.Y) + ","
                + Convert.ToString(End.X) + ","
                + Convert.ToString(End.Y);
            return str;
        }

    }
}
