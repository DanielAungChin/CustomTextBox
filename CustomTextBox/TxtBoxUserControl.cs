using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomTextBox
{
    public partial class TxtBoxUserControl : UserControl
    {
        public TxtBoxUserControl()
        {
            InitializeComponent();
        }

        private void TxtBoxUserControl_Paint(object sender, PaintEventArgs e)
        {
            Graphics gph = e.Graphics;
            Pen mypen = new Pen(Color.Yellow, 10);
            Point p1 = new Point(0, this.Height - 1);
            Point p2 = new Point(this.Width, this.Height - 1);
            gph.DrawLine(mypen, p1, p2);
        }
    }
}
