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
            int m2 = M - 1;
            double Ri;
            int count=0;
            int count2 =N;
            int temp = 0; 
            for (int i = 0; i < N; i++)
            {

               
                t[i] = ((TextBox)panel1.Controls["TxtBox" + (i + 1).ToString()]).Text;


            }
            dataGridView1.Rows.Add();
            count = (Convert.ToInt32(t[0]) + Convert.ToInt32(t[4]));
            Xi1 = count  % (M);
            dataGridView1.Rows.Add();
            dataGridView1[0, 0].Value = "X1";
            dataGridView1[1, 0].Value = "" + Xi1;
            Ri = (double) Xi1 / m2;
            dataGridView1[2, 0].Value = String.Format("{0:0.000#}", Ri);
            temp = Xi1;
            for (int i = 1; i < N; i++)
            {
                count = (Convert.ToInt32(t[i]) + Convert.ToInt32(temp));
                Xi1 = count % (M);
                dataGridView1.Rows.Add();
                    dataGridView1[0, i].Value = "X" + (1);
                    dataGridView1[1, i].Value = "" + Xi1;
                Ri =(double) Xi1 / m2;
                    dataGridView1[2, i].Value = String.Format("{0:0.000#}", Ri);
                temp = Xi1;
            }           
        }

        private void btnOK_Click_1(object sender, EventArgs e)
        {
            int N = Convert.ToInt32(txtN.Text);
            for (int i = 0; i < N; i++)
            {


                txtBox = new TextBox();
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

