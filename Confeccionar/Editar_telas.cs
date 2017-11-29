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
    public partial class Editar_telas : Form
    {
        Utilidades uti = new Utilidades();
        MySqlConnection conectar2 = new MySqlConnection("server=localhost; database=co;Uid=root;pwd=omega0418");
        int n_id = 0;
       
        public Editar_telas()
        {
            InitializeComponent();
        }

      /*  private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tex_buscar.Text.Trim())) {
                try
                {
                    DataSet re = new DataSet();
                    Utilidades tr = new Utilidades();
                    re = tr.ejecutar("SELECT * FROM telas WHERE nombre LIKE '%"+tex_buscar.Text+"%'");
                    tabla_edicion.DataSource = re.Tables[0];
                    tabla_edicion.Columns[0].Visible = false;
                }
                catch (Exception rt)
                {
                    MessageBox.Show("ocurrio un error" + rt.Message);
                }
            }

        }*/

        private void Editar_telas_Load(object sender, EventArgs e)
        {
            llenar2();
        }

        private bool validarcampos()
        {
            bool ok = true;
            if (tex_nombre.Text == "")
            {
                ok = false;
                errorProvider1.SetError(tex_nombre, "Ingrese el Nombre de la Tela");

            }
            if (tex_metros.Text == "")
            {
                ok = false;
                errorProvider1.SetError(tex_metros, "Ingrese los metros con el siguiente formato ej: 43.4 o 1000");

            }
            if (tex_valor.Text == "")
            {
                ok = false;
                errorProvider1.SetError(tex_valor, "Ingrese el valor sin puntos");

            }
            return ok;
        }
        void limpiariconos()
        {
            errorProvider1.SetError(tex_nombre, "");
            errorProvider1.SetError(tex_metros, "");
            errorProvider1.SetError(tex_valor, "");

        }

        //guarda la edicion de la tabla
        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (validarcampos()==true)
            {
                limpiariconos();
                tex_nombre.Focus();
                try
                {
                    using (MySqlConnection conectar1 = new MySqlConnection(uti.Conexion()))
                    {

                        conectar1.Open();
                        MySqlCommand nuevo_sql = new MySqlCommand("Actualizar_datos", conectar1);
                        nuevo_sql.CommandType = CommandType.StoredProcedure;
                        nuevo_sql.Parameters.AddWithValue("id_nuevo", n_id);
                        nuevo_sql.Parameters.AddWithValue("nuevo_nombre", tex_nombre.Text.Trim());
                        nuevo_sql.Parameters.AddWithValue("nuevo_metros", tex_metros.Text.Trim());
                        nuevo_sql.Parameters.AddWithValue("nuevo_costo", tex_valor.Text.Trim());
                        nuevo_sql.ExecuteNonQuery();
                        MessageBox.Show("Los Datos Se Actualizaron con éxito ", "Actualización Exitosa ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        limpiar();
                        llenar2();
                    }
                }
                catch (MySqlException et)
                {

                    MessageBox.Show("Hubo un Error " + et.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por Favor diligenciar los Campos " , "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
          
            
        }
        //llena la tabla con los datos de la base de datos de la tabla telas
        void llenar2()
        {
            try
            {
                DataSet re = new DataSet();
                Utilidades tr = new Utilidades();
                re = tr.ejecutar("SELECT * FROM telas");
                tabla_edicion.DataSource = re.Tables[0];
                tabla_edicion.Columns[0].Visible = false;
            }
            catch(Exception rt)
            {
                MessageBox.Show("Hubo un Error " + rt.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
        //seleciona los datos dando doble click en una columna y los muestra en los textbox para editarlos
        private void tabla_edicion_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try { 
            if (tabla_edicion.CurrentRow.Index != -1)
            {
                tex_nombre.Text = tabla_edicion.CurrentRow.Cells[1].Value.ToString();
                tex_metros.Text = tabla_edicion.CurrentRow.Cells[2].Value.ToString();
                tex_valor.Text = tabla_edicion.CurrentRow.Cells[3].Value.ToString();
                n_id = Convert.ToInt32(tabla_edicion.CurrentRow.Cells[0].Value.ToString());
                btn_editar.Text = "Guardar"; 
            }

            }
            catch (Exception ef)
            {
                MessageBox.Show("Hubo un Problema  " + ef.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        // boton que regresa a la pagina principal
        private void btn_atras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 regresar = new Form1();
            regresar.Show();
        }
        //limpia los textbox y cierra la conecion de base datos cuando se realiza la edicion de los datos
        void limpiar()
        {
            tex_metros.Text = tex_nombre.Text = tex_valor.Text = " ";
            n_id = 0;
            conectar2.Close();

        }
        //metodo que busca los en la tabla 
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tex_buscar.Text.Trim()) == false)
            {
                try
                {
                    DataSet re = new DataSet();
                    Utilidades tr = new Utilidades();
                    re = tr.ejecutar("SELECT * FROM telas WHERE nombre LIKE '"+tex_buscar.Text+"%'");
                    tabla_edicion.DataSource = re.Tables[0];
                    tabla_edicion.Columns[0].Visible = false;
                }
                catch (Exception rt)
                {
                    MessageBox.Show("Hubo un Error " + rt.Message,"Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    DataSet re = new DataSet();
                    Utilidades tr = new Utilidades();
                    re = tr.ejecutar("SELECT * FROM telas WHERE nombre LIKE '" + tex_buscar.Text + "%'");
                    tabla_edicion.DataSource = re.Tables[0];
                    tabla_edicion.Columns[0].Visible = false;
                }
                catch (Exception rt)
                {
                    MessageBox.Show("Hubo un Error" + rt.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }

        }

        private void tex_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            uti.ValidarLetras(e);
        }

        private void tex_metros_KeyPress(object sender, KeyPressEventArgs e)
        {
           // uti.ValidarDecimal(e, tex_metros);
        }
    }
}
