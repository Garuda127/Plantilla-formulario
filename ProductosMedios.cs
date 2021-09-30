﻿using System;
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
        int Npublic = 0;
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
            Npublic = N;
            //Xi--------------Ri------------------------
            Xi1 = (x0 * x1);
            temp1 = Xi1.ToString();
            if (temp1.Length % 2 == 0)
            {
                Xi1 = Convert.ToInt32(temp1.Substring(2, 4));
                dataGridView1.Rows.Add();
                dataGridView1[0, 0].Value = "X" + 1;
                dataGridView1[1, 0].Value = "" + Xi1;
                Ri = (double)Xi1 / 10000;
                dataGridView1[2, 0].Value = String.Format("{0:0.000#}", Ri);
            }
            else
            {
                Xi1 = Convert.ToInt32(temp1.Substring(1, 4));
                dataGridView1.Rows.Add();
                dataGridView1[0, 0].Value = "X" +  1;
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
                    dataGridView1[0, i].Value = "X" + (i + 1);
                    dataGridView1[1, i].Value = "" + Xi1;
                    Ri = (double)Xi1 / 10000;
                    dataGridView1[2, i].Value = String.Format("{0:0.000#}", Ri);
                    Xi = Convert.ToInt32(temp);
                }
                
                else if (temp1.Length % 2 == 0)
                {
                    Xi1 = Convert.ToInt32(temp1.Substring(2, 4));
                    dataGridView1.Rows.Add();
                    dataGridView1[0, i].Value = "X" + (i + 1);
                    dataGridView1[1, i].Value = "" + Xi1;
                    Ri = (double)Xi1 / 10000;
                    dataGridView1[2, i].Value = String.Format("{0:0.000#}", Ri);
                    Xi = Convert.ToInt32(temp);
                }
                else
                {
                    Xi1 = Convert.ToInt32(temp1.Substring(1, 4));
                    dataGridView1.Rows.Add();
                    dataGridView1[0, i].Value = "X" + (i + 1);
                    dataGridView1[1, i].Value = "" + Xi1;
                    Ri = (double)Xi1 / 10000;
                    dataGridView1[2, i].Value = String.Format("{0:0.000#}", Ri);
                    Xi = Convert.ToInt32(temp);
                }


            }
        }
        double[] EiOi = new double[10];
        double Ei = 0;
        int intervalo0;
        int intervalo1;
        int intervalo2;
        int intervalo3;
        int intervalo4;
        int intervalo5;
        int intervalo6;
        int intervalo7;
        int intervalo8;
        int intervalo9;
        double suma;
        private void btnChi_Click(object sender, EventArgs e)
        {
            double temp = 0;
            Double raizM = Math.Sqrt(Npublic);
            //inicia contador
            for (int i = 0; i < Npublic; i++)
            {

                temp = Convert.ToDouble(dataGridView1[2, i].Value.ToString());

                if (temp >= 0 & temp < 0.10)
                {
                    intervalo0++;
                }
                else if (temp >= 0.10 & temp < 0.20)
                {
                    intervalo1++;
                }
                else if (temp >= 0.20 & temp < 0.30)
                {
                    intervalo2++;
                }
                else if (temp >= 0.30 & temp < 0.40)
                {
                    intervalo3++;
                }
                else if (temp >= 0.40 & temp < 0.50)
                {
                    intervalo4++;
                }
                else if (temp >= 0.50 & temp < 0.60)
                {
                    intervalo5++;
                }
                else if (temp >= 0.60 & temp < 0.70)
                {
                    intervalo6++;
                }
                else if (temp >= 0.70 & temp < 0.80)
                {
                    intervalo7++;
                }
                else if (temp >= 0.80 & temp < 0.90)
                {
                    intervalo8++;
                }
                else if (temp >= 0.90 & temp <= 1.00)
                {
                    intervalo9++;
                }

            }
            //fin de contador


            Ei = (Npublic / raizM);
            //((Ei-Oi)^2)/Ei

            EiOi[0] = ((Math.Pow((Ei - intervalo0), 2)) / Ei);
            EiOi[1] = ((Math.Pow((Ei - intervalo1), 2)) / Ei);
            EiOi[2] = ((Math.Pow((Ei - intervalo2), 2)) / Ei);
            EiOi[3] = ((Math.Pow((Ei - intervalo3), 2)) / Ei);
            EiOi[4] = ((Math.Pow((Ei - intervalo4), 2)) / Ei);
            EiOi[5] = ((Math.Pow((Ei - intervalo5), 2)) / Ei);
            EiOi[6] = ((Math.Pow((Ei - intervalo6), 2)) / Ei);
            EiOi[7] = ((Math.Pow((Ei - intervalo7), 2)) / Ei);
            EiOi[8] = ((Math.Pow((Ei - intervalo8), 2)) / Ei);
            EiOi[9] = ((Math.Pow((Ei - intervalo9), 2)) / Ei);

            //((Ei-Oi)^2)/Ei
            Console.WriteLine(intervalo0);
            for (int i = 0; i < 9; i++)
            {

                Console.WriteLine(EiOi[i]);
            }
            //suma
            suma = EiOi[0] + EiOi[1] + EiOi[2] + EiOi[3] + EiOi[4] + EiOi[5] + EiOi[6] + EiOi[7] + EiOi[8] + EiOi[9];
            Console.WriteLine(suma);
            //suma
            Chi frm = new Chi();

            frm.txtMchi.Text = raizM.ToString();
            frm.txtNchi.Text = Npublic.ToString();
            frm.DatosChi.Rows.Add(9);
            frm.DatosChi[0, 0].Value = "0.0 - 0.10";
            frm.DatosChi[0, 1].Value = "0.10 - 0.20";
            frm.DatosChi[0, 2].Value = "0.20 - 0.30";
            frm.DatosChi[0, 3].Value = "0.30 - 0.40";
            frm.DatosChi[0, 4].Value = "0.40 - 0.50";
            frm.DatosChi[0, 5].Value = "0.50 - 0.60";
            frm.DatosChi[0, 6].Value = "0.60 - 0.70";
            frm.DatosChi[0, 7].Value = "0.70 - 0.80";
            frm.DatosChi[0, 8].Value = "0.80 - 0.90";
            frm.DatosChi[0, 9].Value = "0.90 - 1.00";

            frm.DatosChi[1, 0].Value = intervalo0;
            frm.DatosChi[1, 1].Value = intervalo1;
            frm.DatosChi[1, 2].Value = intervalo2;
            frm.DatosChi[1, 3].Value = intervalo3;
            frm.DatosChi[1, 4].Value = intervalo4;
            frm.DatosChi[1, 5].Value = intervalo5;
            frm.DatosChi[1, 6].Value = intervalo6;
            frm.DatosChi[1, 7].Value = intervalo7;
            frm.DatosChi[1, 8].Value = intervalo8;
            frm.DatosChi[1, 9].Value = intervalo9;

            for (int i = 0; i < 10; i++)
            {
                frm.DatosChi[2, i].Value = Ei;
            }

            frm.DatosChi[3, 0].Value = EiOi[0];
            frm.DatosChi[3, 1].Value = EiOi[1];
            frm.DatosChi[3, 2].Value = EiOi[2];
            frm.DatosChi[3, 3].Value = EiOi[3];
            frm.DatosChi[3, 4].Value = EiOi[4];
            frm.DatosChi[3, 5].Value = EiOi[5];
            frm.DatosChi[3, 6].Value = EiOi[6];
            frm.DatosChi[3, 7].Value = EiOi[7];
            frm.DatosChi[3, 8].Value = EiOi[8];
            frm.DatosChi[3, 9].Value = EiOi[9];

            frm.txtSUMAchi.Text = suma.ToString();
            frm.txtTABLAchi.Text = "16.9190";

            frm.Show();
        }
    }
}
