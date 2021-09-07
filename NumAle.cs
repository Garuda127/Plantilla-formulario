using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plantilla_formulario
{
    public partial class NumAle : Form
    {
        public NumAle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int k = Convert.ToInt32(TB1.Text);
            int g = Convert.ToInt32(TB2.Text);
            int x0 = Convert.ToInt32(TB3.Text);
            int m = Convert.ToInt32(Math.Pow(2, g));
            int m2 = m - 1;
            int N = m / 4;
            LB6.Text = "N =" + N;
            int a = k*8+3;
            double Ri=0;
            for (int i=0; i < N; i++)
            {
                x0=((a*x0) % (m));
                dataGridView1.Rows.Add();
                dataGridView1[1, i].Value = "" + x0;
                Ri = (double) x0/m2;
                Console.WriteLine(Ri);
                dataGridView1[2, i].Value = String.Format("{0:0.00#}", Ri);
            }
        }
    }
}
