namespace Confeccionar
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tELASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarYEditarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bLUSASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarYEditarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.generarCodigoBarrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearProduciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultdarYEditarClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tELASToolStripMenuItem,
            this.bLUSASToolStripMenuItem,
            this.administracionToolStripMenuItem,
            this.empresaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1362, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tELASToolStripMenuItem
            // 
            this.tELASToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearToolStripMenuItem,
            this.consultarYEditarToolStripMenuItem});
            this.tELASToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tELASToolStripMenuItem.Name = "tELASToolStripMenuItem";
            this.tELASToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.tELASToolStripMenuItem.Text = "Telas";
            // 
            // crearToolStripMenuItem
            // 
            this.crearToolStripMenuItem.Name = "crearToolStripMenuItem";
            this.crearToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.crearToolStripMenuItem.Text = "Crear";
            this.crearToolStripMenuItem.Click += new System.EventHandler(this.crearToolStripMenuItem_Click);
            // 
            // consultarYEditarToolStripMenuItem
            // 
            this.consultarYEditarToolStripMenuItem.Name = "consultarYEditarToolStripMenuItem";
            this.consultarYEditarToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.consultarYEditarToolStripMenuItem.Text = "Consultar y Actualizar";
            this.consultarYEditarToolStripMenuItem.Click += new System.EventHandler(this.consultarYEditarToolStripMenuItem_Click);
            // 
            // bLUSASToolStripMenuItem
            // 
            this.bLUSASToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearToolStripMenuItem1,
            this.consultarYEditarToolStripMenuItem1,
            this.generarCodigoBarrasToolStripMenuItem});
            this.bLUSASToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLUSASToolStripMenuItem.Name = "bLUSASToolStripMenuItem";
            this.bLUSASToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.bLUSASToolStripMenuItem.Text = "Blusas";
            // 
            // crearToolStripMenuItem1
            // 
            this.crearToolStripMenuItem1.Name = "crearToolStripMenuItem1";
            this.crearToolStripMenuItem1.Size = new System.Drawing.Size(202, 22);
            this.crearToolStripMenuItem1.Text = "Crear";
            this.crearToolStripMenuItem1.Click += new System.EventHandler(this.crearToolStripMenuItem1_Click);
            // 
            // consultarYEditarToolStripMenuItem1
            // 
            this.consultarYEditarToolStripMenuItem1.Name = "consultarYEditarToolStripMenuItem1";
            this.consultarYEditarToolStripMenuItem1.Size = new System.Drawing.Size(202, 22);
            this.consultarYEditarToolStripMenuItem1.Text = "Consultar y Actualizar";
            this.consultarYEditarToolStripMenuItem1.Click += new System.EventHandler(this.consultarYEditarToolStripMenuItem1_Click);
            // 
            // generarCodigoBarrasToolStripMenuItem
            // 
            this.generarCodigoBarrasToolStripMenuItem.Name = "generarCodigoBarrasToolStripMenuItem";
            this.generarCodigoBarrasToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.generarCodigoBarrasToolStripMenuItem.Text = "Generar Codigo Barras";
            this.generarCodigoBarrasToolStripMenuItem.Click += new System.EventHandler(this.generarCodigoBarrasToolStripMenuItem_Click);
            // 
            // administracionToolStripMenuItem
            // 
            this.administracionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearProduciónToolStripMenuItem,
            this.consultarToolStripMenuItem,
            this.crearClientesToolStripMenuItem,
            this.consultdarYEditarClientesToolStripMenuItem});
            this.administracionToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.administracionToolStripMenuItem.Name = "administracionToolStripMenuItem";
            this.administracionToolStripMenuItem.Size = new System.Drawing.Size(158, 20);
            this.administracionToolStripMenuItem.Text = "Administracion de Ventas";
            this.administracionToolStripMenuItem.Click += new System.EventHandler(this.administracionToolStripMenuItem_Click);
            // 
            // crearProduciónToolStripMenuItem
            // 
            this.crearProduciónToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9F);
            this.crearProduciónToolStripMenuItem.Name = "crearProduciónToolStripMenuItem";
            this.crearProduciónToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.crearProduciónToolStripMenuItem.Text = "Generar Factura";
            this.crearProduciónToolStripMenuItem.Click += new System.EventHandler(this.crearProduciónToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Enabled = false;
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.consultarToolStripMenuItem.Text = "Consultar Producción";
            // 
            // crearClientesToolStripMenuItem
            // 
            this.crearClientesToolStripMenuItem.Name = "crearClientesToolStripMenuItem";
            this.crearClientesToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.crearClientesToolStripMenuItem.Text = "Crear Clientes";
            this.crearClientesToolStripMenuItem.Click += new System.EventHandler(this.crearClientesToolStripMenuItem_Click);
            // 
            // consultdarYEditarClientesToolStripMenuItem
            // 
            this.consultdarYEditarClientesToolStripMenuItem.Name = "consultdarYEditarClientesToolStripMenuItem";
            this.consultdarYEditarClientesToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.consultdarYEditarClientesToolStripMenuItem.Text = "Consultar y Actualizar Clientes";
            this.consultdarYEditarClientesToolStripMenuItem.Click += new System.EventHandler(this.consultdarYEditarClientesToolStripMenuItem_Click);
            // 
            // empresaToolStripMenuItem
            // 
            this.empresaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarToolStripMenuItem});
            this.empresaToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empresaToolStripMenuItem.Name = "empresaToolStripMenuItem";
            this.empresaToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.empresaToolStripMenuItem.Text = "Empresa";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.editarToolStripMenuItem.Text = "Actualizar Datos";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Confeccionar.Properties.Resources.melanie;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1362, 709);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confecionar ";
            this.TransparencyKey = System.Drawing.Color.White;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tELASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarYEditarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bLUSASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultarYEditarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem generarCodigoBarrasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearProduciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultdarYEditarClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empresaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
    }
}

