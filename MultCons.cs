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
    public partial class MultCons : Form
    {
        public MultCons()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(TB1.Text);
            int b = Convert.ToInt32(TB2.Text);
            int N = Convert.ToInt32(TB3.Text);
            double Ri=0;
            int Xi1=0;
            String temp;
            String temp1;
            Xi1 = (b * a);
            temp1 = Xi1.ToString();
            if (temp1.Length % 2 == 0)
            {
                Xi1 = Convert.ToInt32(temp1.Substring(2, 4));
                dataGridView1.Rows.Add();
                dataGridView1[1, 0].Value = "" + Xi1;
                Ri = (double)Xi1 / 10000;
                dataGridView1[2, 0].Value = String.Format("{0:0.000#}", Ri);
            }
            else
            {
                Xi1 = Convert.ToInt32(temp1.Substring(1, 4));
                dataGridView1.Rows.Add();
                dataGridView1[1, 0].Value = "" + Xi1;
                Ri = (double)Xi1 / 10000;
                dataGridView1[2, 0].Value = String.Format("{0:0.000#}", Ri);
            }
            Ri = (double)Xi1 / 10000;
            for (int i = 1; i < N; i++)
            {
                
                Xi1 = (Xi1 * a);
                temp = Xi1.ToString();
                temp1 = Xi1.ToString();
                if (temp1.Length == 6)
                {
                    Xi1 = Convert.ToInt32(temp1.Substring(1, 4));
                    dataGridView1.Rows.Add();
                    dataGridView1[1, i].Value = "" + Xi1;
                    Ri = (double)Xi1 / 10000;
                    dataGridView1[2, i].Value = String.Format("{0:0.000#}", Ri);
                    b = Convert.ToInt32(temp);
                }

                else if (temp1.Length % 2 == 0)
                {
                    Xi1 = Convert.ToInt32(temp1.Substring(2, 4));
                    dataGridView1.Rows.Add();
                    dataGridView1[1, i].Value = "" + Xi1;
                    Ri = (double)Xi1 / 10000;
                    dataGridView1[2, i].Value = String.Format("{0:0.000#}", Ri);
                    b = Convert.ToInt32(temp);
                }
                else
                {
                    Xi1 = Convert.ToInt32(temp1.Substring(1, 4));
                    dataGridView1.Rows.Add();
                    dataGridView1[1, i].Value = "" + Xi1;
                    Ri = (double)Xi1 / 10000;
                    dataGridView1[2, i].Value = String.Format("{0:0.000#}", Ri);
                    b = Convert.ToInt32(temp);
                }


            }
        }
    }
}
