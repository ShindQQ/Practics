using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bridge
{
    internal class Figure
    {
        public static void Draw(Form form, Shape shape, LineStyle lineStyle, Color color)
        {
            shape.implementor = lineStyle;
            shape.Draw(form, color);
        }
    }
}
