namespace Confeccionar
{
    partial class Consulta_de_blusa
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
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_selclie = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabla_consulta = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_consulta)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(527, 77);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 0;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            // 
            // btn_selclie
            // 
            this.btn_selclie.Location = new System.Drawing.Point(317, 456);
            this.btn_selclie.Name = "btn_selclie";
            this.btn_selclie.Size = new System.Drawing.Size(174, 23);
            this.btn_selclie.TabIndex = 1;
            this.btn_selclie.Text = "Seleccionar";
            this.btn_selclie.UseVisualStyleBackColor = true;
            this.btn_selclie.Click += new System.EventHandler(this.btn_selclie_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(317, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(181, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Buscar por Nombre";
            // 
            // tabla_consulta
            // 
            this.tabla_consulta.AllowUserToAddRows = false;
            this.tabla_consulta.AllowUserToDeleteRows = false;
            this.tabla_consulta.AllowUserToResizeColumns = false;
            this.tabla_consulta.AllowUserToResizeRows = false;
            this.tabla_consulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabla_consulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla_consulta.Location = new System.Drawing.Point(12, 111);
            this.tabla_consulta.Name = "tabla_consulta";
            this.tabla_consulta.RowHeadersVisible = false;
            this.tabla_consulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabla_consulta.Size = new System.Drawing.Size(777, 339);
            this.tabla_consulta.TabIndex = 5;
            // 
            // Consulta_de_blusa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 491);
            this.Controls.Add(this.tabla_consulta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_selclie);
            this.Controls.Add(this.btn_buscar);
            this.Name = "Consulta_de_blusa";
            this.Text = "Consulta de Producto";
            this.Load += new System.EventHandler(this.Consulta_de_blusa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabla_consulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_selclie;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView tabla_consulta;
    }
}