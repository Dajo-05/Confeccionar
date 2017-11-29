namespace Confeccionar
{
    partial class Editar_clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editar_clientes));
            this.tabla_cliente = new System.Windows.Forms.DataGridView();
            this.tex_nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_seleccionar = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.tex_buscar = new System.Windows.Forms.TextBox();
            this.tex_documento = new System.Windows.Forms.TextBox();
            this.tex_telefono = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_cliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabla_cliente
            // 
            this.tabla_cliente.AllowUserToAddRows = false;
            this.tabla_cliente.AllowUserToDeleteRows = false;
            this.tabla_cliente.AllowUserToResizeColumns = false;
            this.tabla_cliente.AllowUserToResizeRows = false;
            this.tabla_cliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabla_cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla_cliente.Location = new System.Drawing.Point(12, 177);
            this.tabla_cliente.Name = "tabla_cliente";
            this.tabla_cliente.RowHeadersVisible = false;
            this.tabla_cliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabla_cliente.Size = new System.Drawing.Size(736, 237);
            this.tabla_cliente.TabIndex = 0;
            this.tabla_cliente.DoubleClick += new System.EventHandler(this.tabla_cliente_DoubleClick);
            // 
            // tex_nombre
            // 
            this.tex_nombre.Location = new System.Drawing.Point(195, 82);
            this.tex_nombre.Name = "tex_nombre";
            this.tex_nombre.Size = new System.Drawing.Size(117, 20);
            this.tex_nombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(232, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Consultar y Actualizar Datos";
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(408, 420);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(172, 23);
            this.btn_guardar.TabIndex = 3;
            this.btn_guardar.Text = "Actualizar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_seleccionar
            // 
            this.btn_seleccionar.Location = new System.Drawing.Point(124, 420);
            this.btn_seleccionar.Name = "btn_seleccionar";
            this.btn_seleccionar.Size = new System.Drawing.Size(210, 23);
            this.btn_seleccionar.TabIndex = 4;
            this.btn_seleccionar.Text = "Seleccionar";
            this.btn_seleccionar.UseVisualStyleBackColor = true;
            this.btn_seleccionar.Click += new System.EventHandler(this.btn_seleccionar_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(469, 136);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(91, 23);
            this.btn_buscar.TabIndex = 5;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            // 
            // tex_buscar
            // 
            this.tex_buscar.Location = new System.Drawing.Point(290, 139);
            this.tex_buscar.Name = "tex_buscar";
            this.tex_buscar.Size = new System.Drawing.Size(160, 20);
            this.tex_buscar.TabIndex = 6;
            // 
            // tex_documento
            // 
            this.tex_documento.Location = new System.Drawing.Point(633, 80);
            this.tex_documento.Name = "tex_documento";
            this.tex_documento.Size = new System.Drawing.Size(100, 20);
            this.tex_documento.TabIndex = 7;
            // 
            // tex_telefono
            // 
            this.tex_telefono.Location = new System.Drawing.Point(408, 84);
            this.tex_telefono.Name = "tex_telefono";
            this.tex_telefono.Size = new System.Drawing.Size(100, 20);
            this.tex_telefono.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(327, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Telefono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(533, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Documento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nombres o Razón Social";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(143, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Buscar por Nombre";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(12, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(261, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "Razón Social";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(270, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(238, 23);
            this.label7.TabIndex = 14;
            this.label7.Text = "NIT o Documento";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(487, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(261, 23);
            this.label8.TabIndex = 15;
            this.label8.Text = "Telefono";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Editar_clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(755, 453);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tex_telefono);
            this.Controls.Add(this.tex_documento);
            this.Controls.Add(this.tex_buscar);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.btn_seleccionar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tex_nombre);
            this.Controls.Add(this.tabla_cliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Editar_clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta y Actualización de Clientes";
            this.Load += new System.EventHandler(this.Editar_clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabla_cliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tex_nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox tex_buscar;
        private System.Windows.Forms.TextBox tex_documento;
        private System.Windows.Forms.TextBox tex_telefono;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        public System.Windows.Forms.DataGridView tabla_cliente;
        public System.Windows.Forms.Button btn_seleccionar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}