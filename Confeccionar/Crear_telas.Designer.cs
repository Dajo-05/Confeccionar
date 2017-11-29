namespace Confeccionar
{
    partial class Crear_telas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Crear_telas));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tex_nombre_tela = new System.Windows.Forms.TextBox();
            this.tex_metros = new System.Windows.Forms.TextBox();
            this.tex_valor = new System.Windows.Forms.TextBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(267, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Panel de Creacion de Telas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor de  Tela";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cantidad de Metros";
            // 
            // tex_nombre_tela
            // 
            this.tex_nombre_tela.Location = new System.Drawing.Point(272, 89);
            this.tex_nombre_tela.Name = "tex_nombre_tela";
            this.tex_nombre_tela.Size = new System.Drawing.Size(100, 20);
            this.tex_nombre_tela.TabIndex = 4;
            this.tex_nombre_tela.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tex_nombre_tela_KeyPress);
            // 
            // tex_metros
            // 
            this.tex_metros.Location = new System.Drawing.Point(272, 148);
            this.tex_metros.Name = "tex_metros";
            this.tex_metros.Size = new System.Drawing.Size(100, 20);
            this.tex_metros.TabIndex = 5;
            this.tex_metros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tex_metros_KeyPress);
            this.tex_metros.Validating += new System.ComponentModel.CancelEventHandler(this.tex_metros_Validating);
            // 
            // tex_valor
            // 
            this.tex_valor.Location = new System.Drawing.Point(272, 204);
            this.tex_valor.Name = "tex_valor";
            this.tex_valor.Size = new System.Drawing.Size(100, 20);
            this.tex_valor.TabIndex = 6;
            this.tex_valor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tex_valor_KeyPress);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(193, 333);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(212, 23);
            this.btn_guardar.TabIndex = 7;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Confeccionar.Properties.Resources.telas;
            this.pictureBox1.Location = new System.Drawing.Point(484, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(277, 255);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Crear_telas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(791, 404);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.tex_valor);
            this.Controls.Add(this.tex_metros);
            this.Controls.Add(this.tex_nombre_tela);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Crear_telas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel de Creacion de Telas";
            this.Load += new System.EventHandler(this.Crear_telas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tex_nombre_tela;
        private System.Windows.Forms.TextBox tex_metros;
        private System.Windows.Forms.TextBox tex_valor;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}