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
    public partial class Crear_Blusas : Form
    {
        Utilidades valida = new Utilidades();
        public Crear_Blusas()
        {
            InitializeComponent();
        }
        MySqlConnection conectar = new MySqlConnection("server=localhost; database=co;Uid=root;pwd=omega0418");
        string combo = "";
        string d,codi, imagen,imagen2;
        int corte =0, marquilla = 0, etiqueta = 0, bolsa = 0, admin = 0, corte1 = 0, corte2 = 0;
        int numero = 0, val_min = 0, val_max = 0, guipiur = 0, resultado = 0, neto = 0, t = 0, t1 = 0, t2 = 0, t3 = 0, t4 = 0, t5 = 0, t6 = 0, total = 0;

        private void btn_imatra_Click(object sender, EventArgs e)
        {
            OpenFileDialog imag = new OpenFileDialog();
            imag.Filter = "Image Files(*.BMP;*.JPG;*.JPEG;*.GIF;)|*.BMP;*.JPG;*.JPEG;*.GIF|All files (*.*)|*.* ";
            if (imag.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.ImageLocation = imag.FileName;
                imagen2 = imag.FileName;

            }

        }

        private void tex_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            valida.ValidarLetras(e);
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void radio_blusa_CheckedChanged(object sender, EventArgs e)
        {
            lb_corte.Text = "300";
        }

        private void radio_vestido_CheckedChanged(object sender, EventArgs e)
        {
            lb_corte.Text = "600";
        }

        private void tex_porcentaje_KeyPress(object sender, KeyPressEventArgs e)
        {
            valida.ValidarNumeros(e);
        }

        private void tex_gui2_KeyPress(object sender, KeyPressEventArgs e)
        {
            valida.ValidarNumeros(e);
        }

        private void tex_resortado_KeyPress(object sender, KeyPressEventArgs e)
        {
            valida.ValidarNumeros(e);
        }

        private void tex_accesorios_KeyPress(object sender, KeyPressEventArgs e)
        {
            valida.ValidarNumeros(e);
        }

        private void tex_forro_KeyPress(object sender, KeyPressEventArgs e)
        {
            valida.ValidarNumeros(e);
        }

        private void tex_metros_KeyPress(object sender, KeyPressEventArgs e)
        {
            valida.ValidarNumeros(e);
        }

        private void tex_tinturado_KeyPress(object sender, KeyPressEventArgs e)
        {
            valida.ValidarNumeros(e);
        }

        private void tex_botones_KeyPress(object sender, KeyPressEventArgs e)
        {
            valida.ValidarNumeros(e);
        }

        private void tex_confeccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            valida.ValidarNumeros(e);
        }

        //valida los campos que no esten vacios
        private bool validarcampos()
        {
            bool ok = true;
            if (tex_nombre.Text == "")
            {
                ok = false;
                errorProvider1.SetError(tex_nombre, "Ingrese el Nombre de la Blusa");

            }
            if (tex_metros.Text == "")
            {
                ok = false;
                errorProvider1.SetError(tex_metros, "Ingrese el Valor de los metros utilizados");

            }
            if (tex_gui1.Text == "" && tex_gui2.Text == "")
            {
                ok = false;
                errorProvider1.SetError(tex_gui1, "Ingrese los metros del guipiur este formato ej: 3,4");
                errorProvider1.SetError(tex_gui2, "Ingrese el valor del Guipiur");

            }
            if (tex_botones.Text == "")
            {
                ok = false;
                errorProvider1.SetError(tex_botones, "Ingrese el Valor de los botones");
            }
            if (tex_confeccion.Text == "")
            {
                ok = false;
                errorProvider1.SetError(tex_confeccion, "Ingrese el Valor de la Confección");
            }
            if (tex_porcentaje.Text == "")
            {
                ok = false;
                errorProvider1.SetError(tex_porcentaje, "Ingrese el Porcentaje sin puntos y sin coma"+"\n"+
                    "Sino desea ingresar un porcentaje por favor digite el numero 0");
               
            }
             return ok;
        }

        //limpia los iconos del errorprovider
        void limpiariconos()
        {
            errorProvider1.SetError(tex_nombre, "");
            errorProvider1.SetError(tex_metros, "");
            errorProvider1.SetError(tex_gui1, "");
            errorProvider1.SetError(tex_gui2, "");
            errorProvider1.SetError(tex_botones, "");
            errorProvider1.SetError(tex_confeccion, "");
            errorProvider1.SetError(tex_porcentaje,"");


        }

        //busca la imagen en el explorador de windows y guarda la ruta de donde 
        //se encuntra la iimagen selecionada
        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ima = new OpenFileDialog();
            ima.Filter = "Image Files(*.BMP;*.JPG;*.JPEG;*.GIF;)|*.BMP;*.JPG;*.JPEG;*.GIF|All files (*.*)|*.* ";
            if (ima.ShowDialog() == DialogResult.OK) {
                pictureBox1.ImageLocation = ima.FileName;
                imagen = ima.FileName;

            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
     
        // metodo vacio que llena el combobox
        void llenarcombobox1()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(valida.Conexion()))
                {
                    con.Open();
                    MySqlDataAdapter cmd = new MySqlDataAdapter("SELECT * FROM telas", con);
                    cmd.SelectCommand.CommandType = CommandType.Text;
                    DataTable ta = new DataTable();
                    cmd.Fill(ta);
                    comboBox1.ValueMember = "id_tela";
                    comboBox1.DisplayMember = "Nombre";
                    comboBox1.DataSource = ta;

                    con.Close();
                }
            }
            catch (Exception es)
            {
                MessageBox.Show("Hubo un Error "+es.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //crea un numero consecutivo para la referencia de las blusas
        public string consecutivo()
        {
            MySqlDataReader ds;

            try
            {
                using (MySqlConnection cone = new MySqlConnection(valida.Conexion()))
                {
                    cone.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT count(*) FROM blusas", cone);
                    ds = cmd.ExecuteReader();
                    if (ds.Read())
                    {
                        numero = 1 + Convert.ToInt32(ds.GetString(0));
                    }
                    ds.Close();
                    if (numero < 10)
                    {
                        d = "0000" + numero.ToString();

                    }
                    if (numero < 100 && numero >= 10)
                    {
                        d = "000" + numero.ToString();

                    }
                    if (numero < 1000 && numero >= 100)
                    {
                        d = "00" + numero.ToString();

                    }
                    if (numero < 10000 && numero >= 1000)
                    {
                        d = "0" + numero.ToString();

                    }
                }

            }
            catch (Exception es)
            {
                MessageBox.Show("Hubo un Error " + es, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return d;
        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        // metodos que regresan la suma de los valores fijos que hay 
        
        //carga la informacion del combobox y de los label
        private void Crear_Blusas_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet datos = new DataSet();
                datos = valida.ejecutar("SELECT * FROM empresa");
                corte1 = Convert.ToInt32(datos.Tables[0].Rows[0]["blusa"].ToString().Trim());
                corte2 = Convert.ToInt32(datos.Tables[0].Rows[0]["vestido"].ToString().Trim());
                marquilla = Convert.ToInt32(datos.Tables[0].Rows[0]["marquilla"].ToString().Trim());
                etiqueta = Convert.ToInt32(datos.Tables[0].Rows[0]["etiqueta"].ToString().Trim());
                bolsa = Convert.ToInt32(datos.Tables[0].Rows[0]["bolsa"].ToString().Trim());
                admin = Convert.ToInt32(datos.Tables[0].Rows[0]["admin"].ToString().Trim());
               // interes = Convert.ToInt32(datos.Tables[0].Rows[0]["interes"].ToString().Trim());
            }
            catch(Exception es)
            {
                MessageBox.Show("Hubo un Error " + es.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

            llenarcombobox1();                        
            label_bolsa.Text = bolsa.ToString();
            label_marquilla.Text = marquilla.ToString();
            label_admin.Text = admin.ToString();
            label_etiqueta.Text = etiqueta.ToString();
           
            
        }
        public int suma()
        {

            resultado = marquilla + etiqueta + bolsa + admin;



            return resultado;
        }
        public int suma1()
        {

            resultado = marquilla + etiqueta + bolsa + admin;



            return resultado;
        }
        //selecciona el item en el combobx y lo guarda en la variable combo
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            combo = comboBox1.SelectedValue.ToString();
        }

        public static string mostror_ref = "";
       

        //guarda los datos de las blusas que se crean
        private void button1_Click(object sender, EventArgs e)
        {
            Decimal g = 0, d = 0, d1 = 0;
            int g1 = 0;

            /*if (valida.Repetida(tex_nombre) == false)
            {*/
            neto = 0;
                if (validarcampos() == true)
                {
                    limpiariconos();
                   
                    codi = combo + "" + consecutivo();
                    mostror_ref = codi;
                    try
                    {
                        g = Convert.ToDecimal(tex_gui1.Text);
                        g1 = Convert.ToInt32(tex_gui2.Text);
                        guipiur = Convert.ToInt32(g1 * g);


                        t = Convert.ToInt32(tex_accesorios.Text.Trim());
                        t1 = Convert.ToInt32(tex_metros.Text.Trim());
                        t2 = Convert.ToInt32(tex_confeccion.Text.Trim());
                        t3 = Convert.ToInt32(tex_botones.Text.Trim());
                        t4 = Convert.ToInt32(tex_tinturado.Text.Trim());
                        t5 = Convert.ToInt32(tex_resortado.Text.Trim());
                        t6 = Convert.ToInt32(tex_forro.Text.Trim());

                        total = t + t1 + t2 + t3 + t4 + t5 + t6;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Por favor llene los campos no usados con 0", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                if (radio_blusa.Checked == true)
                    {
                        d = Convert.ToDecimal(tex_porcentaje.Text)/100;
                        corte = corte1;
                        neto = suma1() + corte + guipiur + total;
                        d1 = neto * d;
                        neto += Convert.ToInt32(d1);
                        val_max = 6000 + neto;
                        val_min = 3000 + neto;
                }
                    else
                    {
                        d = Convert.ToDecimal(tex_porcentaje.Text) / 100;
                        corte = corte2;
                        neto = suma() + corte + guipiur + total;
                        d1 = neto * d;
                        neto += Convert.ToInt32(d1);
                        val_max = 10000 + neto;
                        val_min = 6000 + neto;
                    }
                    try
                    {
                        conectar.Open();
                        MySqlCommand insertar = new MySqlCommand("crear_producto", conectar);
                        insertar.CommandType = CommandType.StoredProcedure;
                        insertar.Parameters.AddWithValue("idtel", combo);
                        insertar.Parameters.AddWithValue("nom", tex_nombre.Text.Trim());
                        insertar.Parameters.AddWithValue("mts", tex_metros.Text.Trim());
                        insertar.Parameters.AddWithValue("conf", tex_confeccion.Text.Trim());
                        insertar.Parameters.AddWithValue("mar", marquilla);
                        insertar.Parameters.AddWithValue("eti", etiqueta);
                        insertar.Parameters.AddWithValue("cod", codi);
                        insertar.Parameters.AddWithValue("gui", guipiur);
                        insertar.Parameters.AddWithValue("bol", bolsa);
                        insertar.Parameters.AddWithValue("cor", corte);
                        insertar.Parameters.AddWithValue("adm", admin);
                        insertar.Parameters.AddWithValue("acc", tex_accesorios.Text.Trim());
                        insertar.Parameters.AddWithValue("btn", tex_botones.Text.Trim());
                        insertar.Parameters.AddWithValue("tin", tex_tinturado.Text.Trim());
                        insertar.Parameters.AddWithValue("res", tex_resortado.Text.Trim());
                        insertar.Parameters.AddWithValue("inter", d1);
                        insertar.Parameters.AddWithValue("ima", imagen);
                        insertar.Parameters.AddWithValue("imat", imagen2);
                        insertar.Parameters.AddWithValue("forr", tex_forro.Text.Trim());
                        insertar.Parameters.AddWithValue("mini", val_min);
                        insertar.Parameters.AddWithValue("maxi", val_max);
                        insertar.Parameters.AddWithValue("neto", neto);

                        insertar.ExecuteNonQuery();

                        informacion info = new informacion();
                         info.ShowDialog();
                         if (info.DialogResult == DialogResult.OK)
                         {
                             limpiarpantalla();
                         }
                }
                    catch (Exception er)
                    {
                        MessageBox.Show("Hubo un Error " + er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor diligenciar todos los Campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            /*  }
              else { MessageBox.Show("Ya existe el producto por favor dirijase a la opcion  Consultar y Actualizar de la pestaña blusas"+"\n"+
                  "Blusa ==> Consultar y Actualizar","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Exclamation); }*/
        }

        void limpiarpantalla()
        {
            conectar.Close();
            tex_nombre.Text = null;
            tex_forro.Text = null;
            tex_botones.Text = " ";
            tex_accesorios.Text = null;
            tex_tinturado.Text = null;
            tex_confeccion.Text = " ";
            tex_gui1.Text = null;
            tex_gui2.Text = null;
            tex_metros.Text = null;
            tex_resortado.Text = " ";
            tex_porcentaje.Text = "";
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            button1.Text = "Crear Producto";
             
        }

    }
}
