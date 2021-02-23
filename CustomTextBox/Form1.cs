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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.txtBoxUserControl1.Control_textBox.Text = "Using user control";
            this.txtBoxClass1.Code_TxtBox.Text = "Using Code";
        }
    }
}
