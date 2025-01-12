﻿using MathNet.Numerics.Distributions;
using System;
using System.Collections;
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
    public partial class Caditivo : Form
    {
        private TextBox txtBox;
        string[] t;
        private Label lblCount;
        int txtalt = 89;
        int Npublic = 0;
        int txtcount = 1;
        private Button btnAdd = new Button();
        public Caditivo()
        {
            InitializeComponent();
        }

        private void Caditivo_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int N = Convert.ToInt32(txtN.Text);
            int M = Convert.ToInt32(txtM.Text);
            int Xi1;
            Npublic = N;
            int m2 = M - 1;
            double Ri;
            int count = 0;
            int count2 = N;
            int temp = 0;
            for (int i = 0; i < N; i++)
            {


                t[i] = ((TextBox)panel1.Controls["TxtBox" + (i + 1).ToString()]).Text;


            }
            dataGridView1.Rows.Add();
            count = (Convert.ToInt32(t[0]) + Convert.ToInt32(t[4]));
            Xi1 = count % (M);
            dataGridView1.Rows.Add();
            dataGridView1[0, 0].Value = "X1";
            dataGridView1[1, 0].Value = "" + Xi1;
            Ri = (double)Xi1 / m2;
            dataGridView1[2, 0].Value = String.Format("{0:0.000#}", Ri);
            temp = Xi1;
            for (int i = 1; i < N; i++)
            {
                count = (Convert.ToInt32(t[i]) + Convert.ToInt32(temp));
                Xi1 = count % (M);
                dataGridView1.Rows.Add();
                dataGridView1[0, i].Value = "X" + (i + N);
                dataGridView1[1, i].Value = "" + Xi1;
                Ri = (double)Xi1 / m2;
                dataGridView1[2, i].Value = String.Format("{0:0.000#}", Ri);
                temp = Xi1;
            }
        }
        private bool ValidarCampos()
        {
            bool ok = true;


            if (txtAlfa.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtAlfa, "falta llenar");
            }
            if (txtM.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtM, "falta llenar");
            }
            if (txtN.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtN, "falta llenar");
            }

            return ok;
        }
        private void BorrarMSG()
        {
            errorProvider1.SetError(txtM, "");
            errorProvider1.SetError(txtAlfa, "");
            errorProvider1.SetError(txtN, "");

        }
        private void btnOK_Click_1(object sender, EventArgs e)
        {
            int btnok = 0;
            BorrarMSG();
            if (ValidarCampos() & btnok == 0)
            {

                btnok++;
                int N = Convert.ToInt32(txtN.Text);
                for (int i = 0; i < N; i++)
                {


                    txtBox = new TextBox();
                    this.txtBox.Text = "0";
                    this.txtBox.Name = "txtBox" + txtcount;
                    this.txtBox.Location = new System.Drawing.Point(36, txtalt);
                    this.txtBox.Size = new System.Drawing.Size(100, 20);
                    this.panel1.Controls.Add(this.txtBox);
                    t = new string[N];

                    //label
                    lblCount = new Label();
                    this.lblCount.ForeColor = Color.White;
                    this.lblCount.Text = "X" + txtcount + "=";
                    this.lblCount.Name = "lblCount" + txtcount;
                    this.lblCount.Location = new System.Drawing.Point(10, txtalt);
                    this.lblCount.Size = new System.Drawing.Size(100, 20);
                    txtalt += 22;
                    this.panel1.Controls.Add(this.lblCount);
                    txtcount++;
                }


                this.btnAdd.BackColor = Color.White;
                this.btnAdd.Name = "btnCalcular";
                this.btnAdd.Text = "Calcular";
                this.btnAdd.Location = new System.Drawing.Point(48, txtalt);
                this.btnAdd.Size = new System.Drawing.Size(75, 23);
                this.btnAdd.Enabled = true;

                this.panel1.Controls.Add(this.btnAdd);
                this.btnAdd.Click += new System.EventHandler(this.btnCalcular_Click);
                txtcount = 1;
                txtalt = 53;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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
            PChi frm = new PChi();

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
            double alf;
            alf = Convert.ToDouble(txtAlfa.Text);
            double chix2 = ChiSquared.InvCDF((Npublic - 1), (1 - alf));
            frm.txtTABLAchi.Text = chix2.ToString();

            frm.Show();
        }
        double Promedio;
        double Alpha;
        double li;
        double ls;
        double Z;
        private void iconButton1_Click(object sender, EventArgs e)
        {
            PMedia frmpMedia = new PMedia();
            li = 0;
            ls = 0;
            var curve = new MathNet.Numerics.Distributions.Normal();
            var PMediaZ = curve.InverseCumulativeDistribution(1 - (Convert.ToDouble(txtAlfa.Text) / 2));
            var PMediaZ2 = curve.InverseCumulativeDistribution((Convert.ToDouble(txtAlfa.Text) / 2));
            Z = PMediaZ;
            Promedio = 0;

            double temp = 0;
            frmpMedia.DatosMedia.Rows.Add(Npublic);
            for (int i = 0; i < Npublic; i++)
            {
                temp = Convert.ToDouble(dataGridView1[2, i].Value.ToString());
                frmpMedia.DatosMedia[0, i].Value = temp;
                Promedio += temp;
            }
            Promedio = Promedio / Npublic;

            Alpha = Convert.ToDouble(txtAlfa.Text);

            //li 0.5-(K9*(1/RAIZ(12*K5)))
            li = 0.5 - (Alpha * (1 / Math.Sqrt(12 * Npublic)));
            //ls 0.5+(K9*(1/RAIZ(12*K5)))
            ls = 0.5 + (Alpha * (1 / Math.Sqrt(12 * Npublic)));
            Console.WriteLine(Promedio);
            /* z= MathNet.Numerics.Distribution.Normal.InverseCumulativeDistribution;*/


            Console.WriteLine(Z);
            Console.WriteLine("li=" + li);
            Console.WriteLine("ls=" + ls);


            frmpMedia.PmediaTxtMedia.Text = Promedio.ToString();
            frmpMedia.PMediaTxtN.Text = Npublic.ToString();
            frmpMedia.PMediaTxt1.Text = Alpha.ToString();
            frmpMedia.PMediaTxtZ.Text = Z.ToString();
            frmpMedia.PMediaTxtLi.Text = li.ToString();
            frmpMedia.PMediaTxtLs.Text = ls.ToString();

            frmpMedia.Show();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Pvariable frmVar = new Pvariable();
            var curve = new MathNet.Numerics.Distributions.Normal();
            var PcorZ = curve.InverseCumulativeDistribution(1 - (Convert.ToDouble(txtAlfa.Text) / 2));
            var PcorZ2 = curve.InverseCumulativeDistribution((Convert.ToDouble(txtAlfa.Text) / 2));
            double temp;
            double temp2 = 0;
            double op;
            double chix;//(a/2)
            double chix2;//1-(a/2)
            double Vri = 0;
            double liv;
            double lsv;
            chix = ChiSquared.InvCDF((Npublic - 1), 1 - (Convert.ToDouble(txtAlfa.Text)));
            frmVar.PvarTxta2.Text = chix.ToString();

            chix2 = ChiSquared.InvCDF((Npublic - 1), (Convert.ToDouble(txtAlfa.Text)));
            frmVar.PvarTxt1a2.Text = chix2.ToString();
            //Promedio
            for (int i = 0; i < Npublic; i++)
            {
                temp = Convert.ToDouble(dataGridView1[2, i].Value.ToString());
                Promedio += temp;
            }
            Promedio = Promedio / Npublic;
            Console.WriteLine("Promedio= " + Promedio);
            //operacion 
            frmVar.DatosPvar.Rows.Add(Npublic);
            for (int i = 0; i < Npublic; i++)
            {
                temp = Convert.ToDouble(dataGridView1[2, i].Value.ToString());
                op = Math.Pow((temp - Promedio), 2);//=((tabla-promedio)^2)
                //llenar tabla
                frmVar.DatosPvar[0, i].Value = temp;
                frmVar.DatosPvar[1, i].Value = op;
                //llenar tabla
                temp2 += op;
            }
            Console.WriteLine(temp2);
            Vri = temp2 / (Npublic - 1);
            liv = chix2 / (12 * (Npublic - 1));//=chix2/(12*39)
            lsv = chix / (12 * (Npublic - 1));

            frmVar.PvarTxtVri.Text = Vri.ToString();
            frmVar.PvarTxtLi.Text = liv.ToString();
            frmVar.PvarTxtLs.Text = lsv.ToString();
            frmVar.Show();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            PCorridas frmcorridas = new PCorridas();
            double alpha;
            alpha = Convert.ToDouble(txtAlfa.Text);
            double valor1;
            double valor2;
            double S1;
            double S2;
            int corridas;
            int Co = 0;
            double valesp;
            double varianza;
            double estadistico;
            double vartab;
            frmcorridas.DatosCorridas.Rows.Add(Npublic);
            frmcorridas.PCorTxtAlfa.Text = alpha.ToString();
            for (int i = 0; i < Npublic; i++)
            {
                frmcorridas.DatosCorridas[0, i].Value = Convert.ToDouble(dataGridView1[2, i].Value.ToString());
            }
            //for S

            for (int i = 1; i < Npublic; i++)
            {
                valor1 = Convert.ToDouble(dataGridView1[2, i].Value.ToString());
                valor2 = Convert.ToDouble(dataGridView1[2, i - 1].Value.ToString());
                //if
                if (valor1 > valor2)
                {
                    frmcorridas.DatosCorridas[1, i].Value = "1";
                }
                else
                {
                    frmcorridas.DatosCorridas[1, i].Value = "0";
                }//if

            }//for S
            //for NO Corridas
            for (int i = 2; i < Npublic; i++)
            {
                S1 = Convert.ToDouble(frmcorridas.DatosCorridas[1, i].Value.ToString());
                S2 = Convert.ToDouble(frmcorridas.DatosCorridas[1, i - 1].Value.ToString());
                corridas = (int)Math.Abs(S1 - S2);
                frmcorridas.DatosCorridas[2, i].Value = corridas;
                Co += corridas;
            }//for NO Corridas
            frmcorridas.PCorTxtCo.Text = Co.ToString();
            frmcorridas.PCorTxtN.Text = Npublic.ToString();
            valesp = ((2 * Npublic) - 1) / 3;
            frmcorridas.PCorTxtVesp.Text = valesp.ToString();
            varianza = ((16 * Npublic) - 29) / 90;
            frmcorridas.PCorTxtVar.Text = varianza.ToString();
            estadistico = (Math.Abs(Co - valesp)) / (Math.Sqrt(varianza));
            frmcorridas.PCorTxtEstadist.Text = estadistico.ToString();
            var curve = new MathNet.Numerics.Distributions.Normal();
            vartab = curve.InverseCumulativeDistribution(1 - (alpha / 2));
            frmcorridas.PCorTxtValTab.Text = vartab.ToString();

            if (estadistico < vartab)
            {
                frmcorridas.PCorTxtHo.Text = "No se Rechaza";
            }
            else
            {
                frmcorridas.PCorTxtHo.Text = "se Rechaza";
            }
            frmcorridas.Show();
        }
        int cc;
        private void txtN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
                {
                    e.Handled = false;
                }
                else
                {
                    //el resto de teclas pulsadas se desactivan
                    e.Handled = true;
                }
            }

        }
        int cc2;
        private void txtM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
                else
                {
                    if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        //el resto de teclas pulsadas se desactivan
                        e.Handled = true;
                    }
                }
        }

        private void txtAlfa_TextChanged(object sender, EventArgs e)
        {

        }
        int cc3;
        private void txtAlfa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (Char.IsPunctuation(e.KeyChar) & cc3 == 0)
                {
                    cc3++;
                    e.Handled = false;

                }
                else
                {
                    if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        //el resto de teclas pulsadas se desactivan
                        e.Handled = true;
                    }
                }

            }
        }
    }
}

