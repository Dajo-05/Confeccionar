using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Confeccionar
{
    class Utilidades
    {
        public bool ret;
        public static bool ve;
        public static bool ve1;
        public DataSet ejecutar(string u)
        {
            MySqlConnection conectar = new MySqlConnection("server=localhost; database=co;Uid=root;pwd=omega0418");
            DataSet dato = new DataSet();

            conectar.Open();


            MySqlDataAdapter cmd = new MySqlDataAdapter(u, conectar);
            cmd.SelectCommand.CommandType = CommandType.Text;
            cmd.Fill(dato);

            conectar.Close();

            return dato;

        }
        public void ValidarLetras(KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsLetter(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception re)
            {
                MessageBox.Show("error" + re.Message);

            }
            

        }

        public bool ValidarDecimal (KeyPressEventArgs e, TextBox texto)
        {
    
            Char veri = e.KeyChar;
            
            try
            {
                if (veri == 46 && texto.Text.IndexOf(".") != -1)
                {
                    e.Handled = true;
                    ret = true;
                }
               else if (!Char.IsDigit(veri) && veri != 8 && veri != 46)
                {
                    e.Handled = true;
                     ret=true;
                    
                }
                else
                {
                    ret = false;
                }
              
            }
            catch (Exception re)
            {
                MessageBox.Show("error" + re.Message);

            }


            return ret;
        }

        public void ValidarNumeros(KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception re)
            {
                MessageBox.Show("error" + re.Message);

            }


        }

        public string Conexion()
        {
            return "server=localhost; database=co;Uid=root;pwd=omega0418";
        }

        public Boolean Repetida(TextBox texto)
        {
            DataSet dato = new DataSet();
           
            try
            {
                MySqlConnection conectar = new MySqlConnection("server=localhost; database=co;Uid=root;pwd=omega0418");
                conectar.Open();
                if (texto.Text == "") {

                    ve1 = false;
                }
                else
                {        
                    MySqlDataAdapter cmd = new MySqlDataAdapter("SELECT nombre FROM blusas WHERE nombre = '" + texto.Text.Trim() + "'", conectar);
                    cmd.SelectCommand.CommandType = CommandType.Text;
                    cmd.Fill(dato);
                    ve1 = true;
                    conectar.Close();
                }
                if (ve1 == true)
                {
                    if (texto.Text.Equals(dato.Tables[0].Rows[0]["nombre"].ToString().Trim()))
                    {
                        ve = true;
                    }
                    else
                    {
                        ve = false;
                    }
                }
                else
                {
                    ve = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Continue" , "Valido", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

          

            return ve;
        }

        

    }

  
}
