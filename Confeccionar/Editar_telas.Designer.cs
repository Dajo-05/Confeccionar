namespace Confeccionar
{
    partial class Editar_telas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editar_telas));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tex_nombre = new System.Windows.Forms.TextBox();
            this.tex_metros = new System.Windows.Forms.TextBox();
            this.tex_valor = new System.Windows.Forms.TextBox();
            this.btn_editar = new System.Windows.Forms.Button();
            this.tabla_edicion = new System.Windows.Forms.DataGridView();
            this.tex_buscar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_edicion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(350, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Panel de Actualización de telas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre de la Tlea";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Metros Comprados";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Valor";
            // 
            // tex_nombre
            // 
            this.tex_nombre.Location = new System.Drawing.Point(192, 93);
            this.tex_nombre.Name = "tex_nombre";
            this.tex_nombre.Size = new System.Drawing.Size(100, 20);
            this.tex_nombre.TabIndex = 1;
            this.tex_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tex_nombre_KeyPress);
            // 
            // tex_metros
            // 
            this.tex_metros.Location = new System.Drawing.Point(192, 146);
            this.tex_metros.Name = "tex_metros";
            this.tex_metros.Size = new System.Drawing.Size(100, 20);
            this.tex_metros.TabIndex = 2;
            this.tex_metros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tex_metros_KeyPress);
            // 
            // tex_valor
            // 
            this.tex_valor.Location = new System.Drawing.Point(192, 202);
            this.tex_valor.Name = "tex_valor";
            this.tex_valor.Size = new System.Drawing.Size(100, 20);
            this.tex_valor.TabIndex = 3;
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(87, 404);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(187, 23);
            this.btn_editar.TabIndex = 7;
            this.btn_editar.Text = "Guardar Edicion";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // tabla_edicion
            // 
            this.tabla_edicion.AllowUserToAddRows = false;
            this.tabla_edicion.AllowUserToDeleteRows = false;
            this.tabla_edicion.AllowUserToResizeColumns = false;
            this.tabla_edicion.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabla_edicion.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tabla_edicion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabla_edicion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla_edicion.Location = new System.Drawing.Point(352, 138);
            this.tabla_edicion.Name = "tabla_edicion";
            this.tabla_edicion.RowHeadersVisible = false;
            this.tabla_edicion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabla_edicion.Size = new System.Drawing.Size(643, 320);
            this.tabla_edicion.TabIndex = 9;
            this.tabla_edicion.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tabla_edicion_MouseDoubleClick);
            // 
            // tex_buscar
            // 
            this.tex_buscar.Location = new System.Drawing.Point(532, 83);
            this.tex_buscar.Name = "tex_buscar";
            this.tex_buscar.Size = new System.Drawing.Size(181, 20);
            this.tex_buscar.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(371, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Buscae Por Nombre";
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(746, 81);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 13;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(352, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(213, 23);
            this.label6.TabIndex = 103;
            this.label6.Text = "Nombre";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(781, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(213, 23);
            this.label7.TabIndex = 104;
            this.label7.Text = "Valor Metro de Tela";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(562, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(227, 23);
            this.label8.TabIndex = 105;
            this.label8.Text = "Metros Comprados";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Editar_telas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1007, 480);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tex_buscar);
            this.Controls.Add(this.tabla_edicion);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.tex_valor);
            this.Controls.Add(this.tex_metros);
            this.Controls.Add(this.tex_nombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Editar_telas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar y Actualizar Telas";
            this.Load += new System.EventHandler(this.Editar_telas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabla_edicion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tex_nombre;
        private System.Windows.Forms.TextBox tex_metros;
        private System.Windows.Forms.TextBox tex_valor;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.DataGridView tabla_edicion;
        private System.Windows.Forms.TextBox tex_buscar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}