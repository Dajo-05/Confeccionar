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
    public partial class Editar_clientes : Form
    {
        public Editar_clientes()
        {
            InitializeComponent();
        }
        Utilidades varios = new Utilidades();
        int nid;
        void llenar2()
        {
            try
            {
                DataSet re = new DataSet();
                re = varios.ejecutar("SELECT * FROM clientes");
                tabla_cliente.DataSource = re.Tables[0];
                tabla_cliente.Columns[0].Visible = false;
            }
            catch (Exception rt)
            {
                MessageBox.Show("ocurrio un error" + rt.Message);
            }

        }

        private bool validarcampos()
        {
            bool ok = true;
            if (tex_nombre.Text == "")
            {
                ok = false;
                errorProvider1.SetError(tex_nombre, "Ingrese el Nombre o la Razón Social");

            }
            if (tex_documento.Text == "")
            {
                ok = false;
                errorProvider1.SetError(tex_documento, "Ingrese el documento o el número NIT");

            }
            if (tex_telefono.Text == "")
            {
                ok = false;
                errorProvider1.SetError(tex_telefono, "Ingrese el Número de telefono o Celular");

            }
            return ok;
        }

        void limpiariconos()
        {
            errorProvider1.SetError(tex_nombre, "");
            errorProvider1.SetError(tex_documento, "");
            errorProvider1.SetError(tex_telefono, "");

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (validarcampos() == true)
            {
                limpiariconos();
                tex_nombre.Focus();
                try
                {
                    using (MySqlConnection conectar1 = new MySqlConnection(varios.Conexion()))
                    {

                        conectar1.Open();
                        MySqlCommand nuevo_sql = new MySqlCommand("Actualizar_clientes", conectar1);
                        nuevo_sql.CommandType = CommandType.StoredProcedure;
                        nuevo_sql.Parameters.AddWithValue("nid", nid);
                        nuevo_sql.Parameters.AddWithValue("nom", tex_nombre.Text.Trim());
                        nuevo_sql.Parameters.AddWithValue("doc", tex_documento.Text.Trim());
                        nuevo_sql.Parameters.AddWithValue("tel", tex_telefono.Text.Trim());
                        nuevo_sql.ExecuteNonQuery();
                        MessageBox.Show("Se actualizó con exito","Operación Exitosa",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                        conectar1.Close();
                        llenar2();
                    }
                }
                catch (MySqlException et)
                {

                    MessageBox.Show("Erro no se puede guardar la edicion de datos" + et.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor diligenciar todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            tex_documento.Text = tex_nombre.Text = tex_telefono.Text = " ";
        }

        private void Editar_clientes_Load(object sender, EventArgs e)
        {
            llenar2();
        }

        private void tabla_cliente_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (tabla_cliente.CurrentRow.Index != -1)
                {
                    tex_nombre.Text = tabla_cliente.CurrentRow.Cells[1].Value.ToString();
                    tex_documento.Text = tabla_cliente.CurrentRow.Cells[2].Value.ToString();
                    tex_telefono.Text = tabla_cliente.CurrentRow.Cells[3].Value.ToString();
                    nid = Convert.ToInt32(tabla_cliente.CurrentRow.Cells[0].Value.ToString());
                    btn_guardar.Text = "Guardar";
                }

            }
            catch (Exception ef)
            {
                MessageBox.Show("Hubo un problema" + ef.Message);
            }
        }

        private void btn_seleccionar_Click(object sender, EventArgs e)
        {
            if (tabla_cliente.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        /* private void Editar_clientes_FormClosed(object sender, FormClosedEventArgs e)
         {
             Application.Exit();
         }*/
    }
}
