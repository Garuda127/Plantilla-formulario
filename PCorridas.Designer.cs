
namespace Plantilla_formulario
{
    partial class PCorridas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.PCorTxtN = new System.Windows.Forms.TextBox();
            this.PCorTxtAlfa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PCorTxtVesp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PCorTxtVar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PCorTxtEstadist = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PCorTxtValTab = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DatosCorridas = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PCorTxtCo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.PCorTxtHo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatosCorridas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PCorTxtHo);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.PCorTxtCo);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.PCorTxtValTab);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.PCorTxtEstadist);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.PCorTxtVar);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.PCorTxtVesp);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.PCorTxtAlfa);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.PCorTxtN);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(177, 450);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "N=";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // PCorTxtN
            // 
            this.PCorTxtN.Enabled = false;
            this.PCorTxtN.Location = new System.Drawing.Point(74, 12);
            this.PCorTxtN.Name = "PCorTxtN";
            this.PCorTxtN.ReadOnly = true;
            this.PCorTxtN.Size = new System.Drawing.Size(100, 20);
            this.PCorTxtN.TabIndex = 1;
            // 
            // PCorTxtAlfa
            // 
            this.PCorTxtAlfa.Enabled = false;
            this.PCorTxtAlfa.Location = new System.Drawing.Point(74, 47);
            this.PCorTxtAlfa.Name = "PCorTxtAlfa";
            this.PCorTxtAlfa.ReadOnly = true;
            this.PCorTxtAlfa.Size = new System.Drawing.Size(100, 20);
            this.PCorTxtAlfa.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Alfa=";
            // 
            // PCorTxtVesp
            // 
            this.PCorTxtVesp.Enabled = false;
            this.PCorTxtVesp.Location = new System.Drawing.Point(74, 82);
            this.PCorTxtVesp.Name = "PCorTxtVesp";
            this.PCorTxtVesp.ReadOnly = true;
            this.PCorTxtVesp.Size = new System.Drawing.Size(100, 20);
            this.PCorTxtVesp.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "V.Esperado";
            // 
            // PCorTxtVar
            // 
            this.PCorTxtVar.Enabled = false;
            this.PCorTxtVar.Location = new System.Drawing.Point(74, 117);
            this.PCorTxtVar.Name = "PCorTxtVar";
            this.PCorTxtVar.ReadOnly = true;
            this.PCorTxtVar.Size = new System.Drawing.Size(100, 20);
            this.PCorTxtVar.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Varianza";
            // 
            // PCorTxtEstadist
            // 
            this.PCorTxtEstadist.Enabled = false;
            this.PCorTxtEstadist.Location = new System.Drawing.Point(74, 152);
            this.PCorTxtEstadist.Name = "PCorTxtEstadist";
            this.PCorTxtEstadist.ReadOnly = true;
            this.PCorTxtEstadist.Size = new System.Drawing.Size(100, 20);
            this.PCorTxtEstadist.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Estadistico";
            // 
            // PCorTxtValTab
            // 
            this.PCorTxtValTab.Enabled = false;
            this.PCorTxtValTab.Location = new System.Drawing.Point(80, 187);
            this.PCorTxtValTab.Name = "PCorTxtValTab";
            this.PCorTxtValTab.ReadOnly = true;
            this.PCorTxtValTab.Size = new System.Drawing.Size(94, 20);
            this.PCorTxtValTab.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Valor en tablas";
            // 
            // DatosCorridas
            // 
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.DatosCorridas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DatosCorridas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosCorridas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.DatosCorridas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatosCorridas.Location = new System.Drawing.Point(177, 0);
            this.DatosCorridas.Name = "DatosCorridas";
            this.DatosCorridas.Size = new System.Drawing.Size(623, 450);
            this.DatosCorridas.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Ri";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "S";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "No de corridas";
            this.Column3.Name = "Column3";
            // 
            // PCorTxtCo
            // 
            this.PCorTxtCo.Enabled = false;
            this.PCorTxtCo.Location = new System.Drawing.Point(74, 222);
            this.PCorTxtCo.Name = "PCorTxtCo";
            this.PCorTxtCo.ReadOnly = true;
            this.PCorTxtCo.Size = new System.Drawing.Size(100, 20);
            this.PCorTxtCo.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Co=";
            // 
            // PCorTxtHo
            // 
            this.PCorTxtHo.Enabled = false;
            this.PCorTxtHo.Location = new System.Drawing.Point(74, 248);
            this.PCorTxtHo.Name = "PCorTxtHo";
            this.PCorTxtHo.ReadOnly = true;
            this.PCorTxtHo.Size = new System.Drawing.Size(100, 20);
            this.PCorTxtHo.TabIndex = 15;
            this.PCorTxtHo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "ho=";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // PCorridas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DatosCorridas);
            this.Controls.Add(this.panel1);
            this.Enabled = false;
            this.Name = "PCorridas";
            this.Text = "PCorridas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatosCorridas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        public System.Windows.Forms.TextBox PCorTxtN;
        public System.Windows.Forms.TextBox PCorTxtValTab;
        public System.Windows.Forms.TextBox PCorTxtEstadist;
        public System.Windows.Forms.TextBox PCorTxtVar;
        public System.Windows.Forms.TextBox PCorTxtVesp;
        public System.Windows.Forms.TextBox PCorTxtAlfa;
        public System.Windows.Forms.DataGridView DatosCorridas;
        public System.Windows.Forms.TextBox PCorTxtCo;
        public System.Windows.Forms.TextBox PCorTxtHo;
        private System.Windows.Forms.Label label8;
    }
}