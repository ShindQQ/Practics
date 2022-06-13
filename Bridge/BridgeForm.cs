using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bridge
{
    public partial class BridgeForm : Form
    {
        public BridgeForm()
        {
            InitializeComponent();
            this.Text = "Bridge";
            BackColor = Color.White;
        }

        private void BridgeForm_Load(object sender, EventArgs e)
        {
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            //Figure.Draw(this, new Square(), new DotLine(), Color.Gray);
            //Figure.Draw(this, new Triangle(), new DotLine(), Color.Gray);
            Figure.Draw(this, new Pentagon(), new DotLine(), Color.Gray);
            //Figure.Draw(this, new Square(), new DashDotLine(), Color.Gray);
            //Figure.Draw(this, new Square(), new DotLine(), Color.Gray);
        }
    }
}
