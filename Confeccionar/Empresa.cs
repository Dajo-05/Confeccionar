using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Confeccionar
{
    public partial class Empresa : Form
    {
        public Empresa()
        {
            InitializeComponent();
        }
        Utilidades herramienta = new Utilidades();
        int n_id = 0;
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private bool validarcampos()
        {
            bool ok = true;
            if (tex_social.Text == "")
            {
                ok = false;
                errorProvider1.SetError(tex_social, "Ingrese la Razóm Social de la Empresa");

            }
            if (tex_nit.Text == "")
            {
                ok = false;
                errorProvider1.SetError(tex_nit, "Ingrese el NIT de Empresa");

            }
            if (tex_telefono.Text == "")
            {
                ok = false;
                errorProvider1.SetError(tex_telefono, "Ingrese el Telefono");

            }

            if (tex_dir.Text == "")
            {
                ok = false;
                errorProvider1.SetError(tex_dir, "Ingrese la dirección de la empresa");

            }
            if (tex_marquilla.Text == "")
            {
                ok = false;
                errorProvider1.SetError(tex_marquilla, "Ingrese el valor sin puntos");

            }
            if (tex_etiqueta.Text == "")
            {
                ok = false;
                errorProvider1.SetError(tex_etiqueta, "Ingrese el valor sin puntos");

            }

            if (tex_bolsa.Text == "")
            {
                ok = false;
                errorProvider1.SetError(tex_bolsa, "Ingrese el valor sin puntos");

            }
            if (tex_blusa.Text == "")
            {
                ok = false;
                errorProvider1.SetError(tex_blusa, "Ingrese el valor sin puntos");

            }
            if (tex_vestido.Text == "")
            {
                ok = false;
                errorProvider1.SetError(tex_vestido, "Ingrese el valor sin puntos");

            }
            if (tex_admin.Text == "")
            {
                ok = false;
                errorProvider1.SetError(tex_admin, "Ingrese el valor sin puntos");

            }
            if (tex_interes.Text == "")
            {
                ok = false;
                errorProvider1.SetError(tex_interes, "Ingrese el valor sin puntos");

            }
            return ok;
        }

        void limpiariconos()
        {
            errorProvider1.SetError(tex_social, "");
            errorProvider1.SetError(tex_telefono, "");
            errorProvider1.SetError(tex_nit, "");
            errorProvider1.SetError(tex_dir, "");
            errorProvider1.SetError(tex_marquilla, "");
            errorProvider1.SetError(tex_etiqueta, "");
            errorProvider1.SetError(tex_blusa, "");
            errorProvider1.SetError(tex_bolsa, "");
            errorProvider1.SetError(tex_vestido, "");
            errorProvider1.SetError(tex_admin, "");
            errorProvider1.SetError(tex_interes, "");
        }

        private void Empresa_Load(object sender, EventArgs e)
        {
            DataSet dato = new DataSet();
            dato = herramienta.ejecutar("SELECT * FROM empresa");
            tex_social.Text = dato.Tables[0].Rows[0]["empresa"].ToString().Trim();
            tex_nit.Text = dato.Tables[0].Rows[0]["nit"].ToString().Trim();
            tex_telefono.Text = dato.Tables[0].Rows[0]["telefono"].ToString().Trim();
            tex_dir.Text = dato.Tables[0].Rows[0]["direccion"].ToString().Trim();
            tex_marquilla.Text = dato.Tables[0].Rows[0]["marquilla"].ToString().Trim();
            tex_etiqueta.Text = dato.Tables[0].Rows[0]["etiqueta"].ToString().Trim();
            tex_bolsa.Text = dato.Tables[0].Rows[0]["bolsa"].ToString().Trim();
            tex_blusa.Text = dato.Tables[0].Rows[0]["blusa"].ToString().Trim();
            tex_vestido.Text = dato.Tables[0].Rows[0]["vestido"].ToString().Trim();
            tex_admin.Text = dato.Tables[0].Rows[0]["admin"].ToString().Trim();
            tex_interes.Text = dato.Tables[0].Rows[0]["interes"].ToString().Trim();
            n_id = Convert.ToInt32(dato.Tables[0].Rows[0]["id"].ToString().Trim());

        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            if (validarcampos()== true)
            {
                limpiariconos();
                try
                {
                    using (MySqlConnection conectar = new MySqlConnection(herramienta.Conexion()))
                    {
                        conectar.Open();
                        MySqlCommand nuevo_sql = new MySqlCommand("Actulizar_empre", conectar);
                        nuevo_sql.CommandType = CommandType.StoredProcedure;
                        nuevo_sql.Parameters.AddWithValue("nid", n_id);
                        nuevo_sql.Parameters.AddWithValue("mar", tex_marquilla.Text.Trim());
                        nuevo_sql.Parameters.AddWithValue("eti", tex_etiqueta.Text.Trim());
                        nuevo_sql.Parameters.AddWithValue("bol", tex_bolsa.Text.Trim());
                        nuevo_sql.Parameters.AddWithValue("blu", tex_blusa.Text.Trim());
                        nuevo_sql.Parameters.AddWithValue("ves", tex_vestido.Text.Trim());
                        nuevo_sql.Parameters.AddWithValue("adm", tex_admin.Text.Trim());
                        nuevo_sql.Parameters.AddWithValue("inter", tex_interes.Text.Trim());
                        nuevo_sql.Parameters.AddWithValue("emp", tex_social.Text.Trim());
                        nuevo_sql.Parameters.AddWithValue("nit", tex_nit.Text.Trim());
                        nuevo_sql.Parameters.AddWithValue("tele", tex_telefono.Text.Trim());
                        nuevo_sql.Parameters.AddWithValue("dire", tex_dir.Text.Trim());
                        nuevo_sql.ExecuteNonQuery();
                        conectar.Close();

                        MessageBox.Show("Actualización Exitosa", "Operación Exisosa", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
                catch (Exception er)
                {
                    MessageBox.Show("Hubo un Error " + er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor llene todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tex_marquilla_KeyPress(object sender, KeyPressEventArgs e)
        {
            herramienta.ValidarNumeros(e);
        }

        private void tex_etiqueta_KeyPress(object sender, KeyPressEventArgs e)
        {
            herramienta.ValidarNumeros(e);
        }

        private void tex_bolsa_KeyPress(object sender, KeyPressEventArgs e)
        {
            herramienta.ValidarNumeros(e);
        }

        private void tex_blusa_KeyPress(object sender, KeyPressEventArgs e)
        {
            herramienta.ValidarNumeros(e);
        }

        private void tex_vestido_KeyPress(object sender, KeyPressEventArgs e)
        {
            herramienta.ValidarNumeros(e);
        }

        private void tex_admin_KeyPress(object sender, KeyPressEventArgs e)
        {
            herramienta.ValidarNumeros(e);
        }

        private void tex_interes_KeyPress(object sender, KeyPressEventArgs e)
        {
            herramienta.ValidarNumeros(e);
        }
    }
}
