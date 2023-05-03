using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControlPanelActrivity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public String output1 {
            set { textBox1.Text = value; }
        }
        public String output2 {
            set { textBox2.Text = value; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
