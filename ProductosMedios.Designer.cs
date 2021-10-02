
namespace Plantilla_formulario
{
    partial class ProductosMedios
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
            this.components = new System.ComponentModel.Container();
            this.txtXo = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtG = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAlfa = new System.Windows.Forms.TextBox();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.btnChi = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtXo
            // 
            this.txtXo.Location = new System.Drawing.Point(37, 12);
            this.txtXo.Name = "txtXo";
            this.txtXo.Size = new System.Drawing.Size(100, 20);
            this.txtXo.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(48, 96);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtG
            // 
            this.txtG.Location = new System.Drawing.Point(37, 38);
            this.txtG.Name = "txtG";
            this.txtG.Size = new System.Drawing.Size(100, 20);
            this.txtG.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(15, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "X1=";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "X0=";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(42)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtN);
            this.panel1.Controls.Add(this.txtXo);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.txtG);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(151, 614);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtAlfa);
            this.panel2.Controls.Add(this.iconButton3);
            this.panel2.Controls.Add(this.btnChi);
            this.panel2.Controls.Add(this.iconButton2);
            this.panel2.Controls.Add(this.iconButton1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 414);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(151, 200);
            this.panel2.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Right;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(20, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Alfa=";
            // 
            // txtAlfa
            // 
            this.txtAlfa.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtAlfa.Location = new System.Drawing.Point(51, 0);
            this.txtAlfa.Name = "txtAlfa";
            this.txtAlfa.Size = new System.Drawing.Size(100, 20);
            this.txtAlfa.TabIndex = 21;
            this.txtAlfa.Text = "0.05";
            // 
            // iconButton3
            // 
            this.iconButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(28)))));
            this.iconButton3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Font = new System.Drawing.Font("Arial Black", 9F);
            this.iconButton3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.ChevronRight;
            this.iconButton3.IconColor = System.Drawing.Color.LightGray;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(0, 32);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton3.Size = new System.Drawing.Size(151, 42);
            this.iconButton3.TabIndex = 20;
            this.iconButton3.Text = "P.CorridasUP.Down";
            this.iconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = false;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // btnChi
            // 
            this.btnChi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(28)))));
            this.btnChi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnChi.FlatAppearance.BorderSize = 0;
            this.btnChi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChi.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChi.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnChi.IconChar = FontAwesome.Sharp.IconChar.ChevronRight;
            this.btnChi.IconColor = System.Drawing.Color.LightGray;
            this.btnChi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnChi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChi.Location = new System.Drawing.Point(0, 74);
            this.btnChi.Name = "btnChi";
            this.btnChi.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnChi.Size = new System.Drawing.Size(151, 42);
            this.btnChi.TabIndex = 17;
            this.btnChi.Text = "Chi";
            this.btnChi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChi.UseVisualStyleBackColor = false;
            this.btnChi.Click += new System.EventHandler(this.btnChi_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(28)))));
            this.iconButton2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Arial Black", 10F);
            this.iconButton2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.ChevronRight;
            this.iconButton2.IconColor = System.Drawing.Color.LightGray;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(0, 116);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton2.Size = new System.Drawing.Size(151, 42);
            this.iconButton2.TabIndex = 19;
            this.iconButton2.Text = "P.Varianza";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(28)))));
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Arial Black", 10F);
            this.iconButton1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.ChevronRight;
            this.iconButton1.IconColor = System.Drawing.Color.LightGray;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 158);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton1.Size = new System.Drawing.Size(151, 42);
            this.iconButton1.TabIndex = 18;
            this.iconButton1.Text = "P.Media";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(5, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "N=";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(37, 70);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(100, 20);
            this.txtN.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(42)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero,
            this.Xi,
            this.Ri});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(42)))));
            this.dataGridView1.Location = new System.Drawing.Point(151, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(649, 614);
            this.dataGridView1.TabIndex = 11;
            // 
            // Numero
            // 
            this.Numero.HeaderText = "";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            this.Numero.Width = 50;
            // 
            // Xi
            // 
            this.Xi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Xi.HeaderText = "Xi";
            this.Xi.Name = "Xi";
            this.Xi.ReadOnly = true;
            // 
            // Ri
            // 
            this.Ri.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ri.HeaderText = "Ri";
            this.Ri.Name = "Ri";
            this.Ri.ReadOnly = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ProductosMedios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 614);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductosMedios";
            this.Text = "Productos Medios";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtXo;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Xi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ri;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtN;
        private FontAwesome.Sharp.IconButton btnChi;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAlfa;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}