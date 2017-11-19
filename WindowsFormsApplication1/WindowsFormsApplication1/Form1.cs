using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClassA g = new ClassA();
            int n = g.GetNumber();
            label1.Text = n.ToString();
            ClassB h = new ClassB();
            if (h.Prime(n) == 0) label2.Text = "Not Prime";
            if (h.Prime(n) == 1) label2.Text = "Is Prime";
        }
    }
}
