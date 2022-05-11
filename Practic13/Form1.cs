using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practic13
{
    public partial class Form1 : Form
    {
        static Func<int, int, int> del1 = new Func<int, int, int>(Sum);
        static AsyncCallback asyncCallback = new AsyncCallback(Pow2);
        static IAsyncResult asyncResult = del1.BeginInvoke(0,0,null, null);

        static int Sum(int x, int y)
        {
            Thread.Sleep(2000);
            return x + y;
        }

        static void Pow2(IAsyncResult res)
        {
            Thread.Sleep(4000);
            MessageBox.Show("Callback");
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void IsCompleted_Click(object sender, EventArgs e)
        {
            if (asyncResult.IsCompleted)
            {
                MessageBox.Show("Completed");
            }
        }

        private void End_Click(object sender, EventArgs e)
        {
            asyncResult = del1.BeginInvoke(1, 2, null, null);
            MessageBox.Show(del1.EndInvoke(asyncResult).ToString());
        }

        private void Collback_Click(object sender, EventArgs e)
        {
            asyncResult = del1.BeginInvoke(1, 2, asyncCallback, null);
            MessageBox.Show(del1.EndInvoke(asyncResult).ToString());
        }
    }
}
