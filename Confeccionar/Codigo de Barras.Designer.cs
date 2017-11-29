namespace Confeccionar
{
    partial class Codigo_de_Barras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Codigo_de_Barras));
            this.label1 = new System.Windows.Forms.Label();
            this.lb_neto = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_referencia = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_nombre = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_max = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lb_min = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tabla_barra = new System.Windows.Forms.DataGridView();
            this.tex_buscar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_generar = new System.Windows.Forms.Button();
            this.barra = new System.Windows.Forms.PictureBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_barra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barra)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(296, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Creacion de Codigos de Barras ";
            // 
            // lb_neto
            // 
            this.lb_neto.AutoSize = true;
            this.lb_neto.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lb_neto.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_neto.Location = new System.Drawing.Point(174, 182);
            this.lb_neto.Name = "lb_neto";
            this.lb_neto.Size = new System.Drawing.Size(0, 20);
            this.lb_neto.TabIndex = 1;
            this.lb_neto.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor neto";
            // 
            // lb_referencia
            // 
            this.lb_referencia.AutoSize = true;
            this.lb_referencia.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lb_referencia.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_referencia.Location = new System.Drawing.Point(174, 145);
            this.lb_referencia.Name = "lb_referencia";
            this.lb_referencia.Size = new System.Drawing.Size(0, 20);
            this.lb_referencia.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Referencia";
            // 
            // lb_nombre
            // 
            this.lb_nombre.AutoSize = true;
            this.lb_nombre.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lb_nombre.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nombre.Location = new System.Drawing.Point(174, 110);
            this.lb_nombre.Name = "lb_nombre";
            this.lb_nombre.Size = new System.Drawing.Size(0, 20);
            this.lb_nombre.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(38, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Nombre";
            // 
            // lb_max
            // 
            this.lb_max.AutoSize = true;
            this.lb_max.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lb_max.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_max.Location = new System.Drawing.Point(174, 245);
            this.lb_max.Name = "lb_max";
            this.lb_max.Size = new System.Drawing.Size(0, 20);
            this.lb_max.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(37, 245);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "Ganancia maxima";
            // 
            // lb_min
            // 
            this.lb_min.AutoSize = true;
            this.lb_min.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lb_min.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_min.Location = new System.Drawing.Point(174, 212);
            this.lb_min.Name = "lb_min";
            this.lb_min.Size = new System.Drawing.Size(0, 20);
            this.lb_min.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(38, 212);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 20);
            this.label12.TabIndex = 11;
            this.label12.Text = "Gnanacia minima";
            // 
            // tabla_barra
            // 
            this.tabla_barra.AllowUserToAddRows = false;
            this.tabla_barra.AllowUserToDeleteRows = false;
            this.tabla_barra.AllowUserToResizeColumns = false;
            this.tabla_barra.AllowUserToResizeRows = false;
            this.tabla_barra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabla_barra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla_barra.Location = new System.Drawing.Point(287, 107);
            this.tabla_barra.Name = "tabla_barra";
            this.tabla_barra.RowHeadersVisible = false;
            this.tabla_barra.Size = new System.Drawing.Size(561, 336);
            this.tabla_barra.TabIndex = 12;
            this.tabla_barra.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.tabla_barra.DoubleClick += new System.EventHandler(this.tabla_barra_DoubleClick);
            // 
            // tex_buscar
            // 
            this.tex_buscar.Location = new System.Drawing.Point(508, 71);
            this.tex_buscar.Name = "tex_buscar";
            this.tex_buscar.Size = new System.Drawing.Size(154, 20);
            this.tex_buscar.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(355, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Buscar Por Referencia";
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(685, 69);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 15;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_generar
            // 
            this.btn_generar.Location = new System.Drawing.Point(31, 420);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(97, 23);
            this.btn_generar.TabIndex = 16;
            this.btn_generar.Text = "Generar";
            this.btn_generar.UseVisualStyleBackColor = true;
            this.btn_generar.Click += new System.EventHandler(this.btn_generar_Click);
            // 
            // barra
            // 
            this.barra.Location = new System.Drawing.Point(12, 329);
            this.barra.Name = "barra";
            this.barra.Size = new System.Drawing.Size(269, 86);
            this.barra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.barra.TabIndex = 17;
            this.barra.TabStop = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.Location = new System.Drawing.Point(148, 420);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(87, 23);
            this.btn_imprimir.TabIndex = 18;
            this.btn_imprimir.Text = "Imprimir";
            this.btn_imprimir.UseVisualStyleBackColor = true;
            this.btn_imprimir.Click += new System.EventHandler(this.btn_imprimir_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(287, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 23);
            this.label2.TabIndex = 102;
            this.label2.Text = "Nombre";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(391, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 23);
            this.label4.TabIndex = 103;
            this.label4.Text = "Referencia";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(495, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 23);
            this.label6.TabIndex = 104;
            this.label6.Text = "Valor Neto";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(730, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 23);
            this.label9.TabIndex = 105;
            this.label9.Text = "Valor Maximo";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(612, 107);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 23);
            this.label11.TabIndex = 106;
            this.label11.Text = "Valor Minimo";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Codigo_de_Barras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(872, 455);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_imprimir);
            this.Controls.Add(this.barra);
            this.Controls.Add(this.btn_generar);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tex_buscar);
            this.Controls.Add(this.tabla_barra);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lb_min);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lb_max);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lb_nombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lb_referencia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_neto);
            this.Controls.Add(this.label1);
            this.Name = "Codigo_de_Barras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Codigo_de_Barras";
            this.Load += new System.EventHandler(this.Codigo_de_Barras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabla_barra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_neto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_referencia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_nombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_max;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lb_min;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView tabla_barra;
        private System.Windows.Forms.TextBox tex_buscar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_generar;
        private System.Windows.Forms.PictureBox barra;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
    }
}