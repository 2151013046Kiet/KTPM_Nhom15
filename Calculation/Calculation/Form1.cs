using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Cong_Click(object sender, EventArgs e)
        {
            int a, b, ketqua;
            a = int.Parse(txt_1.Text);
            b = int.Parse(txt_2.Text);
            Calculation c = new Calculation(a, b);
            ketqua = c.Execute("+");
            txt_kq.Text = ketqua.ToString();
        }

        private void Tru_Click(object sender, EventArgs e)
        {
            int a, b, ketqua;
            a = int.Parse(txt_1.Text);
            b = int.Parse(txt_2.Text);
            Calculation c = new Calculation(a, b);
            ketqua = c.Execute("-");
            txt_kq.Text = ketqua.ToString();
        }

        private void Nhan_Click(object sender, EventArgs e)
        {
            int a, b, ketqua;
            a = int.Parse(txt_1.Text);
            b = int.Parse(txt_2.Text);
            Calculation c = new Calculation(a, b);
            ketqua = c.Execute("*");
            txt_kq.Text = ketqua.ToString();
        }

        private void Chia_Click(object sender, EventArgs e)
        {
            int a, b, ketqua;
            a = int.Parse(txt_1.Text);
            b = int.Parse(txt_2.Text);
            Calculation c = new Calculation(a, b);
            ketqua = c.Execute("/");
            txt_kq.Text = ketqua.ToString();
        }
    }
}
