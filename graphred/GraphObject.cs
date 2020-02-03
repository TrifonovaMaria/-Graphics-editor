using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graphred
{
    public enum ObjectType { Line, PolyLine, Polygon, Bezier, Circle, Ellipse, Rectangle, Text };
    public abstract class GraphObject
    {
        public ObjectType type;
        public float PenWidth;
        public byte Transparancy;
        public Color PenColor;
        public Color BrushColor = Color.White;
        public Color TextColor;
        public Font myFont;
        public float fontSize;
        public FontFamily fontFamily;
        public string text;
        public abstract void Paint(Graphics gr);
        public abstract void Deserialize(string str);
        public abstract string Serialize();
    }


}
