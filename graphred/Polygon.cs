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
    public class Polygon: GraphObject
    {
        public List<Point> Nodes = new List<Point>();

        public Polygon()
        {

        }

        public Polygon(List<Point> N)
        {
            type = ObjectType.PolyLine;
            for (int i = 0; i < N.Count; i++)
                Nodes.Add(N[i]);
        }
        public override void Paint(Graphics gr)
        {
            Pen P = new Pen(PenColor);
            P.Color = Color.FromArgb(Transparancy, P.Color);
            SolidBrush B = new SolidBrush(BrushColor);
            B.Color = Color.FromArgb(Transparancy, B.Color);
            P.Width = PenWidth;
            P.Color = Color.FromArgb(Transparancy, P.Color);
            Point[] M = new Point[Nodes.Count];
            for (int i = 0; i < Nodes.Count; i++)
                M[i] = Nodes[i];
            gr.FillPolygon(B, M);
            gr.DrawPolygon(P, M);
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
            for (int i = 9; i < substrings.Length - 1; i += 2)
            {
                Nodes.Add(new Point((int)Convert.ToSingle(substrings[i]), (int)Convert.ToSingle(substrings[i + 1])));
            }
        }
        public override string Serialize()
        {
            string str = "M," + Convert.ToString(PenWidth) + ","
                + Convert.ToString(Transparancy) + ","
                + Convert.ToString(PenColor.R) + ","
                + Convert.ToString(PenColor.G) + ","
                + Convert.ToString(PenColor.B) + ","
                + Convert.ToString(BrushColor.R) + ","
                + Convert.ToString(BrushColor.G) + ","
                + Convert.ToString(BrushColor.B);
            for (int i = 0; i < Nodes.Count; i++)
            {
                str += "," + Convert.ToString(Nodes[i].X) + ","
                + Convert.ToString(Nodes[i].Y);
            }
            return str;
        }
    }
}
