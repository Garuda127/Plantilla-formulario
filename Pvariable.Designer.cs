
namespace Plantilla_formulario
{
    partial class Pvariable
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.PvarTxta2 = new System.Windows.Forms.TextBox();
            this.DatosPvar = new System.Windows.Forms.DataGridView();
            this.PvarTxtVri = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PvarTxt1a2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PvarTxtLi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PvarTxtLs = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatosPvar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PvarTxtLs);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.PvarTxtLi);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.PvarTxt1a2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.PvarTxtVri);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.PvarTxta2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 450);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "a/2";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // PvarTxta2
            // 
            this.PvarTxta2.Enabled = false;
            this.PvarTxta2.Location = new System.Drawing.Point(47, 46);
            this.PvarTxta2.Name = "PvarTxta2";
            this.PvarTxta2.ReadOnly = true;
            this.PvarTxta2.Size = new System.Drawing.Size(100, 20);
            this.PvarTxta2.TabIndex = 1;
            // 
            // DatosPvar
            // 
            this.DatosPvar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosPvar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.DatosPvar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatosPvar.Location = new System.Drawing.Point(165, 0);
            this.DatosPvar.Name = "DatosPvar";
            this.DatosPvar.Size = new System.Drawing.Size(635, 450);
            this.DatosPvar.TabIndex = 1;
            // 
            // PvarTxtVri
            // 
            this.PvarTxtVri.Enabled = false;
            this.PvarTxtVri.Location = new System.Drawing.Point(47, 12);
            this.PvarTxtVri.Name = "PvarTxtVri";
            this.PvarTxtVri.ReadOnly = true;
            this.PvarTxtVri.Size = new System.Drawing.Size(100, 20);
            this.PvarTxtVri.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "V(ri)";
            // 
            // PvarTxt1a2
            // 
            this.PvarTxt1a2.Enabled = false;
            this.PvarTxt1a2.Location = new System.Drawing.Point(47, 80);
            this.PvarTxt1a2.Name = "PvarTxt1a2";
            this.PvarTxt1a2.ReadOnly = true;
            this.PvarTxt1a2.Size = new System.Drawing.Size(100, 20);
            this.PvarTxt1a2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "1-(a/2)";
            // 
            // PvarTxtLi
            // 
            this.PvarTxtLi.Enabled = false;
            this.PvarTxtLi.Location = new System.Drawing.Point(47, 114);
            this.PvarTxtLi.Name = "PvarTxtLi";
            this.PvarTxtLi.ReadOnly = true;
            this.PvarTxtLi.Size = new System.Drawing.Size(100, 20);
            this.PvarTxtLi.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Li";
            // 
            // PvarTxtLs
            // 
            this.PvarTxtLs.Enabled = false;
            this.PvarTxtLs.Location = new System.Drawing.Point(47, 148);
            this.PvarTxtLs.Name = "PvarTxtLs";
            this.PvarTxtLs.ReadOnly = true;
            this.PvarTxtLs.Size = new System.Drawing.Size(100, 20);
            this.PvarTxtLs.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ls";
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Numeros(Ri)";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "(ri-Media)^2";
            this.Column2.Name = "Column2";
            // 
            // Pvariable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DatosPvar);
            this.Controls.Add(this.panel1);
            this.Name = "Pvariable";
            this.Text = "Pvariable";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatosPvar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox PvarTxta2;
        public System.Windows.Forms.DataGridView DatosPvar;
        public System.Windows.Forms.TextBox PvarTxtLs;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox PvarTxtLi;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox PvarTxt1a2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox PvarTxtVri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}