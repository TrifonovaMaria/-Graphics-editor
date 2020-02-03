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
    public class PolyLine: GraphObject
    {
        public List<Point> Nodes = new List<Point>();

        public PolyLine()
        {

        }

        public PolyLine(List<Point> N)
        {
            type = ObjectType.PolyLine;
            for (int i = 0; i < N.Count; i++)
                Nodes.Add(N[i]);
        }
        public override void Paint(Graphics gr)
        {
            Pen P = new Pen(PenColor);
            P.Color = Color.FromArgb(Transparancy, P.Color);
            P.Width = PenWidth;
            P.Color = Color.FromArgb(Transparancy, P.Color);
            for (int i = 0; i < Nodes.Count - 1; i++)
                gr.DrawLine(P, Nodes[i], Nodes[i + 1]);
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
            for (int i = 6; i < substrings.Length - 1; i+=2)
            {
                Nodes.Add(new Point((int)Convert.ToSingle(substrings[i]), (int)Convert.ToSingle(substrings[i+1])));
            }
        }
        public override string Serialize()
        {
            string str = "P," + Convert.ToString(PenWidth) + ","
                + Convert.ToString(Transparancy) + ","
                + Convert.ToString(PenColor.R) + ","
                + Convert.ToString(PenColor.G) + ","
                + Convert.ToString(PenColor.B);
            for (int i = 0; i < Nodes.Count; i++)
            {
                str += "," + Convert.ToString(Nodes[i].X) + ","
                + Convert.ToString(Nodes[i].Y);
            }
            return str;
        }
    }
}
