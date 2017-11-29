
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Confeccionar
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          //  pictureBox1.ImageLocation = "C:/Users/USUARIO/Documents/Visual Studio 2017/Projects/Confecciona/rConfeccionar/Resources ";   
        }

        private void administracionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        //este lleva a la ventana de crear una tela
        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Crear_telas telas = new Crear_telas();
            telas.MdiParent = this;
            telas.Show();
        }
        //este metodo lleva a la ventana de edicion y cinsulta de telas 
        private void consultarYEditarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Editar_telas editelas = new Editar_telas();
            editelas.MdiParent = this;
            editelas.Show();
        }
        // este metodo lleva a la ventana de creación de blusas
        private void crearToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Crear_Blusas blusa = new Crear_Blusas();
            blusa.MdiParent = this;
            blusa.Show();

        }

        private void consultarYEditarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            editar_blusas edi = new editar_blusas();
            edi.MdiParent = this;
            edi.Show();
        }

        private void generarCodigoBarrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Codigo_de_Barras barra = new Codigo_de_Barras();
            barra.MdiParent = this;
            barra.Show();
        }

        private void crearClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Crear_clientes cliente = new Crear_clientes();
            cliente.MdiParent = this;
            cliente.Show();
        }

        private void consultdarYEditarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Editar_clientes edi = new Editar_clientes();
            edi.MdiParent = this;
            edi.Show();
        }

        private void crearProduciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Facturaccion factura = new Facturaccion();
            factura.MdiParent = this;
            factura.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empresa emp = new Empresa();
            emp.MdiParent = this;
            emp.Show();
        }
    }
}
