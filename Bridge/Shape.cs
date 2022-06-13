using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bridge
{
    abstract class Shape
    {
        protected Graphics graphics = null;
        protected Pen pen = null;
        public LineStyle implementor = null;

        public virtual void Draw(Form form, Color color)
        {
            graphics = form.CreateGraphics();
            pen = implementor.Draw(color);
        }
    }
}
