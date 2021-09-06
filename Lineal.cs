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
    public partial class Lineal : Form
    {
        public Lineal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int A = 0;
            int M = 0;
            int g = 0;
            int k = 0;
            int N = 0;
            int C = 0;
          C= Convert.ToInt32(txtC.Text);
            k = Convert.ToInt32(txtK.Text);            
            g = Convert.ToInt32(txtG.Text);          
            M = (int)Math.Pow(2, g);
            N = M;

            txtM.Text =""+M;
            A = 1 + 4 * k;
            txtN.Text = "" + N;
            txtA.Text = "" + A;
            //Xi---------------------------------------------
            int X0 = Convert.ToInt32(txtX0.Text);
            int Xi1 = 0;
            double Ri1 = 0.0;
            String Ritext = "" + Ri1;

            Xi1 = (A * X0 + C) % (M);
            Console.WriteLine("XI1"+Xi1);
            dataGridView1.Rows.Add();
            dataGridView1[0, 0].Value = "X1";
            dataGridView1[1, 0].Value = "" + Xi1;
            Ri1 = ((double)Xi1 / (M - 1));
            Ritext = String.Format("{0:0.000#}", Ri1);
            dataGridView1[2, 0].Value = Ritext;
            for (int Xi = 1; Xi < N; Xi++)
            {
                Xi1 = (A *Xi1  + C) % (M);
                Ri1 = ((double)Xi1 / (M - 1));
                Ritext = "" + Ri1;
                dataGridView1.Rows.Add();
                dataGridView1[0, Xi].Value = "X" + (Xi+1);
                dataGridView1[1, Xi].Value = ""+Xi1;
                //Ri-------------------------------------------

                Ritext = String.Format("{0:0.000#}", Ri1); 
                dataGridView1[2, Xi].Value = Ritext;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
