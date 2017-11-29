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
    public partial class Crear_telas : Form
    { 
        int costo;
        string codigo;
        MySqlConnection conectar = new MySqlConnection("server=localhost; database=co;Uid=root;pwd=omega0418");
        Utilidades uti = new Utilidades();
        public Crear_telas()
        {
            InitializeComponent();
        }

        private bool validarcampos()
        {
            bool ok = true;
            if (tex_nombre_tela.Text == "")
            {
                ok = false;
                errorProvider1.SetError(tex_nombre_tela, "Ingrese el Nombre de la Tela");

            }
            if (tex_metros.Text == "")
            {
                ok = false;
                errorProvider1.SetError(tex_metros, "Ingrese los metros con el siguiente formato Ej: 5.766");

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
            errorProvider1.SetError(tex_nombre_tela, "");
            errorProvider1.SetError(tex_metros, "");
            errorProvider1.SetError(tex_valor, "");

        }
       

        //guarda la nueva tela en la base de datos 
        private void btn_guardar_Click(object sender, EventArgs e)
        {

            if(validarcampos() == true)
            {
                limpiariconos();
                try
                {
                    conectar.Open();
                    costo = Convert.ToInt32(tex_valor.Text);
                    codigo = "INSERT INTO telas (Nombre,Metros,Costo) VALUES ('" + tex_nombre_tela.Text + "','" + tex_metros.Text + "','" + costo + "')";
                    MySqlCommand insertar = new MySqlCommand(codigo, conectar);
                    insertar.ExecuteNonQuery();

                }
                catch (Exception er)
                {
                    MessageBox.Show("Hubo un Error " + er.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                }
                conectar.Clone();
                MessageBox.Show("Se Creo La Tela con Exito" , "Creación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Limpiar();
            }
            else
            {
                MessageBox.Show("Por favor Diligenciar Los Campos Requeridos " , "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           

        }
        private void Limpiar()
        {
            tex_metros.Text = null;
            tex_nombre_tela.Text = null;
            tex_valor.Text = null;
        }
    
        private void Crear_telas_Load(object sender, EventArgs e)
        {
          
        }

        private void tex_nombre_tela_KeyPress(object sender, KeyPressEventArgs e)
        {
            uti.ValidarLetras(e);
           

        }

        private void tex_metros_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void tex_metros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(uti.ValidarDecimal(e, tex_metros))
            {
                errorProvider1.SetError(tex_metros, "");
            }
            
        }

        private void tex_valor_KeyPress(object sender, KeyPressEventArgs e)
        {
            uti.ValidarNumeros(e);
        }
    }
}
