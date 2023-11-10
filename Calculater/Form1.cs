using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculater
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void co_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txt1.Text);
            int b = int.Parse(txt2.Text);
            Calculation kq = new Calculation(a, b);
            txt3.Text = kq.Execute("+").ToString();
        }

        private void tr_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txt1.Text);
            int b = int.Parse(txt2.Text);
            Calculation kq = new Calculation(a, b);
            txt3.Text = kq.Execute("-").ToString();
        }

        private void nh_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txt1.Text);
            int b = int.Parse(txt2.Text);
            Calculation kq = new Calculation(a, b);
            txt3.Text = kq.Execute("*").ToString();
        }

        private void ch_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txt1.Text);
            int b = int.Parse(txt2.Text);
            Calculation kq = new Calculation(a, b);
            txt3.Text = kq.Execute("/").ToString();
        }
    }
}
