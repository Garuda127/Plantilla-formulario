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
    public partial class CuadradosMedios : Form
    {
        public CuadradosMedios()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int x0 = Convert.ToInt32(txtX0.Text);
            int N = Convert.ToInt32(txtN.Text);
            int Xi1 = 0;
           
            Xi1 = x0;
            double Ri ;
            string temp1;
            for (int i = 0; i < N; i++)
            {
                Xi1 = ((int)Math.Pow(Xi1, 2));
                temp1 = Xi1.ToString();
                if (temp1.Length == 6)
                {
                    Xi1 = Convert.ToInt32(temp1.Substring(1, 4));
                    dataGridView1.Rows.Add();
                    dataGridView1[0, i].Value = "X" + (i+1);
                    dataGridView1[1, i].Value = "" + Xi1;
                    Ri = (double)Xi1 / 10000;
                    dataGridView1[2, i].Value = String.Format("{0:0.000#}", Ri);
                   
                }

                else if (temp1.Length % 2 == 0)
                {
                    Xi1 = Convert.ToInt32(temp1.Substring(2, 4));
                    dataGridView1.Rows.Add();
                    dataGridView1[0, i].Value = "X" + (i + 1);
                    dataGridView1[1, i].Value = "" + Xi1;
                    Ri = (double)Xi1 / 10000;
                    dataGridView1[2, i].Value = String.Format("{0:0.000#}", Ri);
                    
                }
                else
                {
                    Xi1 = Convert.ToInt32(temp1.Substring(1, 4));
                    dataGridView1.Rows.Add();
                    dataGridView1[0, i].Value = "X" + (i + 1);
                    dataGridView1[1, i].Value = "" + Xi1;
                    Ri = (double)Xi1 / 10000;
                    dataGridView1[2, i].Value = String.Format("{0:0.000#}", Ri);
                    
                }
            }
        }
    }
}
