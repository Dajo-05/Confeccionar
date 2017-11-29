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
    public partial class Crear_clientes : Form
    {
        public Crear_clientes()
        {
            InitializeComponent();
        }
        Utilidades utilizar = new Utilidades();
        private bool validarcampos()
        {
            bool ok = true;
            if (tex_nombre.Text == "")
            {
                ok = false;
                errorProvider1.SetError(tex_nombre, "Ingrese el Nombre o Razón Social del Cliente");

            }
            if (tex_documento.Text == "")
            {
                ok = false;
                errorProvider1.SetError(tex_documento, "Ingrese el Documentoo o el NIT ");

            }
            if (tex_telefono.Text == "")
            {
                ok = false;
                errorProvider1.SetError(tex_telefono, "Ingrese un Número de Telefono");

            }
            return ok;
        }
        void limpiariconos()
        {
            errorProvider1.SetError(tex_nombre, "");
            errorProvider1.SetError(tex_documento, "");
            errorProvider1.SetError(tex_telefono, "");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(validarcampos() == true)
            {
                limpiariconos();
                try
                {
                    using (MySqlConnection conectar = new MySqlConnection(utilizar.Conexion()))
                    {
                        conectar.Open();
                        MySqlCommand cmd = new MySqlCommand("crear_cliente",conectar);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("nom",tex_nombre.Text.Trim());
                        cmd.Parameters.AddWithValue("docu", tex_documento.Text.Trim());
                        cmd.Parameters.AddWithValue("tel", tex_telefono.Text.Trim());
                        cmd.ExecuteNonQuery();
                        conectar.Close();
                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hubo un error "+ex.Message);
                }

                MessageBox.Show("Creación Exitosa");
                tex_documento.Text = null;
                tex_nombre.Text = null;
                tex_telefono.Text = null;
            }

        }

        private void tex_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilizar.ValidarLetras(e);
        }

        private void tex_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilizar.ValidarNumeros(e);
        }
    }
}
