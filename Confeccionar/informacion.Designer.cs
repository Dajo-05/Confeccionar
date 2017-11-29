namespace Confeccionar
{
    partial class informacion
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.lb_ref = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_neto = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_min = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_max = new System.Windows.Forms.Label();
            this.frontal = new System.Windows.Forms.PictureBox();
            this.trasera = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.frontal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trasera)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Referencia";
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(241, 439);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(159, 23);
            this.btn_aceptar.TabIndex = 1;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // lb_ref
            // 
            this.lb_ref.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ref.Location = new System.Drawing.Point(259, 60);
            this.lb_ref.Name = "lb_ref";
            this.lb_ref.Size = new System.Drawing.Size(69, 20);
            this.lb_ref.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Valor neto de Producción";
            // 
            // lb_neto
            // 
            this.lb_neto.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_neto.Location = new System.Drawing.Point(259, 114);
            this.lb_neto.Name = "lb_neto";
            this.lb_neto.Size = new System.Drawing.Size(80, 20);
            this.lb_neto.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(75, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Valor Minino de venta";
            // 
            // lb_min
            // 
            this.lb_min.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_min.Location = new System.Drawing.Point(259, 164);
            this.lb_min.Name = "lb_min";
            this.lb_min.Size = new System.Drawing.Size(69, 20);
            this.lb_min.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(75, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Valor Maximo de Venta";
            // 
            // lb_max
            // 
            this.lb_max.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_max.Location = new System.Drawing.Point(259, 212);
            this.lb_max.Name = "lb_max";
            this.lb_max.Size = new System.Drawing.Size(69, 20);
            this.lb_max.TabIndex = 8;
            // 
            // frontal
            // 
            this.frontal.Location = new System.Drawing.Point(434, 60);
            this.frontal.Name = "frontal";
            this.frontal.Size = new System.Drawing.Size(139, 153);
            this.frontal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.frontal.TabIndex = 9;
            this.frontal.TabStop = false;
            // 
            // trasera
            // 
            this.trasera.Location = new System.Drawing.Point(434, 260);
            this.trasera.Name = "trasera";
            this.trasera.Size = new System.Drawing.Size(139, 162);
            this.trasera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trasera.TabIndex = 10;
            this.trasera.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(443, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Imagen Frontal";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(443, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Imagen  Trasera";
            // 
            // informacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(665, 474);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trasera);
            this.Controls.Add(this.frontal);
            this.Controls.Add(this.lb_max);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lb_min);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lb_neto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_ref);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.label1);
            this.Name = "informacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Información";
            this.Load += new System.EventHandler(this.informacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.frontal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trasera)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Label lb_ref;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_neto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_min;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_max;
        private System.Windows.Forms.PictureBox frontal;
        private System.Windows.Forms.PictureBox trasera;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}