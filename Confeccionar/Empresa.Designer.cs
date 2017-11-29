namespace Confeccionar
{
    partial class Empresa
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tex_social = new System.Windows.Forms.TextBox();
            this.tex_interes = new System.Windows.Forms.TextBox();
            this.tex_admin = new System.Windows.Forms.TextBox();
            this.tex_vestido = new System.Windows.Forms.TextBox();
            this.tex_blusa = new System.Windows.Forms.TextBox();
            this.tex_bolsa = new System.Windows.Forms.TextBox();
            this.tex_etiqueta = new System.Windows.Forms.TextBox();
            this.tex_marquilla = new System.Windows.Forms.TextBox();
            this.tex_dir = new System.Windows.Forms.TextBox();
            this.tex_telefono = new System.Windows.Forms.TextBox();
            this.tex_nit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Confeccionar.Properties.Resources.ima;
            this.pictureBox1.Location = new System.Drawing.Point(1, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(841, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tex_social
            // 
            this.tex_social.Location = new System.Drawing.Point(109, 187);
            this.tex_social.Name = "tex_social";
            this.tex_social.Size = new System.Drawing.Size(143, 20);
            this.tex_social.TabIndex = 1;
            // 
            // tex_interes
            // 
            this.tex_interes.Location = new System.Drawing.Point(667, 256);
            this.tex_interes.Name = "tex_interes";
            this.tex_interes.Size = new System.Drawing.Size(147, 20);
            this.tex_interes.TabIndex = 2;
            this.tex_interes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tex_interes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tex_interes_KeyPress);
            // 
            // tex_admin
            // 
            this.tex_admin.Location = new System.Drawing.Point(667, 219);
            this.tex_admin.Name = "tex_admin";
            this.tex_admin.Size = new System.Drawing.Size(147, 20);
            this.tex_admin.TabIndex = 3;
            this.tex_admin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tex_admin.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.tex_admin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tex_admin_KeyPress);
            // 
            // tex_vestido
            // 
            this.tex_vestido.Location = new System.Drawing.Point(667, 187);
            this.tex_vestido.Name = "tex_vestido";
            this.tex_vestido.Size = new System.Drawing.Size(147, 20);
            this.tex_vestido.TabIndex = 4;
            this.tex_vestido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tex_vestido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tex_vestido_KeyPress);
            // 
            // tex_blusa
            // 
            this.tex_blusa.Location = new System.Drawing.Point(380, 291);
            this.tex_blusa.Name = "tex_blusa";
            this.tex_blusa.Size = new System.Drawing.Size(139, 20);
            this.tex_blusa.TabIndex = 5;
            this.tex_blusa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tex_blusa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tex_blusa_KeyPress);
            // 
            // tex_bolsa
            // 
            this.tex_bolsa.Location = new System.Drawing.Point(380, 258);
            this.tex_bolsa.Name = "tex_bolsa";
            this.tex_bolsa.Size = new System.Drawing.Size(139, 20);
            this.tex_bolsa.TabIndex = 6;
            this.tex_bolsa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tex_bolsa.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            this.tex_bolsa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tex_bolsa_KeyPress);
            // 
            // tex_etiqueta
            // 
            this.tex_etiqueta.Location = new System.Drawing.Point(380, 221);
            this.tex_etiqueta.Name = "tex_etiqueta";
            this.tex_etiqueta.Size = new System.Drawing.Size(139, 20);
            this.tex_etiqueta.TabIndex = 7;
            this.tex_etiqueta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tex_etiqueta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tex_etiqueta_KeyPress);
            // 
            // tex_marquilla
            // 
            this.tex_marquilla.Location = new System.Drawing.Point(380, 189);
            this.tex_marquilla.Name = "tex_marquilla";
            this.tex_marquilla.Size = new System.Drawing.Size(139, 20);
            this.tex_marquilla.TabIndex = 8;
            this.tex_marquilla.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tex_marquilla.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tex_marquilla_KeyPress);
            // 
            // tex_dir
            // 
            this.tex_dir.Location = new System.Drawing.Point(109, 293);
            this.tex_dir.Name = "tex_dir";
            this.tex_dir.Size = new System.Drawing.Size(143, 20);
            this.tex_dir.TabIndex = 9;
            // 
            // tex_telefono
            // 
            this.tex_telefono.Location = new System.Drawing.Point(109, 260);
            this.tex_telefono.Name = "tex_telefono";
            this.tex_telefono.Size = new System.Drawing.Size(143, 20);
            this.tex_telefono.TabIndex = 10;
            // 
            // tex_nit
            // 
            this.tex_nit.Location = new System.Drawing.Point(109, 223);
            this.tex_nit.Name = "tex_nit";
            this.tex_nit.Size = new System.Drawing.Size(143, 20);
            this.tex_nit.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Razon Social";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(293, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Marquilla";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(545, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Administración";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(547, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Interes 5%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(293, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Bolsa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Dirección";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(293, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Corte Blusa";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(547, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Corte Vestido";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 260);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Telefono";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(293, 219);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "Etiqueta";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 223);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 20);
            this.label11.TabIndex = 22;
            this.label11.Text = "NIT";
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actualizar.Location = new System.Drawing.Point(297, 418);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(230, 27);
            this.btn_actualizar.TabIndex = 23;
            this.btn_actualizar.Text = "Actualizar Datos";
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Empresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(843, 457);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tex_nit);
            this.Controls.Add(this.tex_telefono);
            this.Controls.Add(this.tex_dir);
            this.Controls.Add(this.tex_marquilla);
            this.Controls.Add(this.tex_etiqueta);
            this.Controls.Add(this.tex_bolsa);
            this.Controls.Add(this.tex_blusa);
            this.Controls.Add(this.tex_vestido);
            this.Controls.Add(this.tex_admin);
            this.Controls.Add(this.tex_interes);
            this.Controls.Add(this.tex_social);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Empresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualización de Empresa";
            this.Load += new System.EventHandler(this.Empresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tex_social;
        private System.Windows.Forms.TextBox tex_interes;
        private System.Windows.Forms.TextBox tex_admin;
        private System.Windows.Forms.TextBox tex_vestido;
        private System.Windows.Forms.TextBox tex_blusa;
        private System.Windows.Forms.TextBox tex_bolsa;
        private System.Windows.Forms.TextBox tex_etiqueta;
        private System.Windows.Forms.TextBox tex_marquilla;
        private System.Windows.Forms.TextBox tex_dir;
        private System.Windows.Forms.TextBox tex_telefono;
        private System.Windows.Forms.TextBox tex_nit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}