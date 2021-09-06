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
    public partial class ProductosMedios : Form
    {
        public ProductosMedios()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int x0 = 0;
            int x1 = 0;
            int Xi = 0;
            double Ri = 0;
            int Xi1 = 0;
            int N = 0;
            string temp1;
            string temp;
            x0 = Convert.ToInt32(txtXo.Text);
            x1 = Convert.ToInt32(txtG.Text);
            N = Convert.ToInt32(txtN.Text);
            Xi = x1;
            //Xi--------------Ri------------------------
            Xi1 = (x0 * x1);
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
                temp = Xi1.ToString();
                Xi1 = (Xi1 * Xi);

                temp1 = Xi1.ToString();
                if (temp1.Length == 6)
                {
                    Xi1 = Convert.ToInt32(temp1.Substring(1, 4));
                    dataGridView1.Rows.Add();
                    dataGridView1[1, i].Value = "" + Xi1;
                    Ri = (double)Xi1 / 10000;
                    dataGridView1[2, i].Value = String.Format("{0:0.000#}", Ri);
                    Xi = Convert.ToInt32(temp);
                }
                
                else if (temp1.Length % 2 == 0)
                {
                    Xi1 = Convert.ToInt32(temp1.Substring(2, 4));
                    dataGridView1.Rows.Add();
                    dataGridView1[1, i].Value = "" + Xi1;
                    Ri = (double)Xi1 / 10000;
                    dataGridView1[2, i].Value = String.Format("{0:0.000#}", Ri);
                    Xi = Convert.ToInt32(temp);
                }
                else
                {
                    Xi1 = Convert.ToInt32(temp1.Substring(1, 4));
                    dataGridView1.Rows.Add();
                    dataGridView1[1, i].Value = "" + Xi1;
                    Ri = (double)Xi1 / 10000;
                    dataGridView1[2, i].Value = String.Format("{0:0.000#}", Ri);
                    Xi = Convert.ToInt32(temp);
                }


            }
        }
    }
}
