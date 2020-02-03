using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graphred
{
    public class Text : GraphObject
    {
        public Point Begin = new Point();
        //public String S;
        public Text(Point T)
        {
            type = ObjectType.Text;
            Begin = T;
        }
        public Text()
        {
        }
        public override void Paint(Graphics gr)
        {
            SolidBrush B = new SolidBrush(TextColor);
            B.Color = Color.FromArgb(Transparancy, B.Color);
            Font font = myFont;
            string S = text;
            gr.DrawString(S, font, B, Begin);
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
            text = substrings[8];
            fontSize = (float)Convert.ToSingle(substrings[9]);
            myFont = new Font(substrings[10], fontSize);
        }
        public override string Serialize()
        {
            string str = "T," + Convert.ToString(PenWidth) + ","
                + Convert.ToString(Transparancy) + ","
                + Convert.ToString(PenColor.R) + ","
                + Convert.ToString(PenColor.G) + ","
                + Convert.ToString(PenColor.B) + ","
                + Convert.ToString(Begin.X) + ","
                + Convert.ToString(Begin.Y) + ","
                + text + ","
                + Convert.ToString(fontSize) + ","
                + Convert.ToString(myFont.Name);
            return str;
        }
    }
}
