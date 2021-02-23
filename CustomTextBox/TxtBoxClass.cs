using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomTextBox
{
    public class TxtBoxClass:UserControl
    {
        public TextBox Code_TxtBox;
        public TxtBoxClass() : base()
        {
            Code_TxtBox = new TextBox();
            this.Code_TxtBox.Font= new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Code_TxtBox.BorderStyle = BorderStyle.None;
            this.Code_TxtBox.Dock = DockStyle.Fill;
            this.Controls.Add(Code_TxtBox);
            this.Size= new System.Drawing.Size(336, 32);
            this.BackColor = Color.White;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics gph = e.Graphics;
            Pen mypen = new Pen(Color.Red, 10);
            Point p1 = new Point(0, this.Height - 1);
            Point p2 = new Point(this.Width, this.Height - 1);
            gph.DrawLine(mypen, p1, p2);
        }
    }
}
