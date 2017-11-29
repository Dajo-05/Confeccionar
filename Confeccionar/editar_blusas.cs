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
    public partial class editar_blusas : Form
    {
        public editar_blusas()
        {
            InitializeComponent();
        }
        int id, marquilla , etiqueta , bolsa , admin ,maxi,min, neto;
        Utilidades valida = new Utilidades();
        string imagen, imagen2;
        decimal de, d;
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tex_buscar.Text.Trim()) == false)
            {
                try
                {
                    DataSet re = new DataSet();
                    Utilidades tr = new Utilidades();
                    re = tr.ejecutar("SELECT id, nombre, metros, confeccion, guipiur, accesorios, botones, tinturado, resortado, corte, forro, valor_neto, valor_minimo, " +
                        "valor_maximo,codigo,imagefron,imagetra,interes,admin,etiqueta,bolsa,marquilla FROM blusas WHERE nombre LIKE '" + tex_buscar.Text + "%'");
                    tabla_blusa.DataSource = re.Tables[0];
                    tabla_blusa.Columns[0].Visible = false;
                    tabla_blusa.Columns[14].Visible = false;
                    tabla_blusa.Columns[15].Visible = false;
                    tabla_blusa.Columns[16].Visible = false;
                    tabla_blusa.Columns[17].Visible = false;
                    tabla_blusa.Columns[18].Visible = false;
                    tabla_blusa.Columns[19].Visible = false;
                    tabla_blusa.Columns[20].Visible = false;
                    tabla_blusa.Columns[21].Visible = false;
                   
                }
                catch (Exception rt)
                {
                    MessageBox.Show("Hubo un error " + rt.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    DataSet re = new DataSet();
                    Utilidades tr = new Utilidades();
                    re = tr.ejecutar("SELECT id, nombre, metros, confeccion, guipiur, accesorios, botones, tinturado, resortado, corte, forro, valor_neto, valor_minimo, " +
                        "valor_maximo,codigo,imagefron,imagetra,interes,admin,etiqueta,bolsa,marquilla FROM blusas WHERE nombre LIKE '" + tex_buscar.Text + "%'");
                    tabla_blusa.DataSource = re.Tables[0];
                    tabla_blusa.Columns[0].Visible = false;
                    tabla_blusa.Columns[14].Visible = false;
                    tabla_blusa.Columns[15].Visible = false;
                    tabla_blusa.Columns[16].Visible = false;
                    tabla_blusa.Columns[17].Visible = false;
                    tabla_blusa.Columns[18].Visible = false;
                    tabla_blusa.Columns[19].Visible = false;
                    tabla_blusa.Columns[20].Visible = false;
                    tabla_blusa.Columns[21].Visible = false;
                    tabla_blusa.Columns[15].Visible = false;
                }
                catch (Exception rt)
                {
                    MessageBox.Show("Hubo un Error " + rt.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        int metros, accesorios, botones, guipuir, resortado, corte, forro,tinturado,confeccion;

        private void btn_ima2_Click(object sender, EventArgs e)
        {
            OpenFileDialog imag = new OpenFileDialog();
            imag.Filter = "Image Files(*.BMP;*.JPG;*.JPEG;*.GIF;)|*.BMP;*.JPG;*.JPEG;*.GIF|All files (*.*)|*.* ";
            if (imag.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.ImageLocation = imag.FileName;
                imagen2 = imag.FileName;

            }
        }

        private void btn_ima1_Click(object sender, EventArgs e)
        {
            OpenFileDialog imag = new OpenFileDialog();
            imag.Filter = "Image Files(*.BMP;*.JPG;*.JPEG;*.GIF;)|*.BMP;*.JPG;*.JPEG;*.GIF|All files (*.*)|*.* ";
            if (imag.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = imag.FileName;
                imagen = imag.FileName;

            }
        }

        Utilidades vali = new Utilidades();

        //agrega a los texbox los datos seleccionados de la taba
        private void tabla_blusa_DoubleClick(object sender, EventArgs e)
        {
            Decimal re,re3;
            int re1, re2, ne;
            try
            {
                if (tabla_blusa.CurrentRow.Index != -1)
                {
                    tex_nombre.Text = tabla_blusa.CurrentRow.Cells[1].Value.ToString();
                    tex_metros.Text = tabla_blusa.CurrentRow.Cells[2].Value.ToString();
                    tex_confeccion.Text = tabla_blusa.CurrentRow.Cells[3].Value.ToString();
                    tex_gui1.Text = tabla_blusa.CurrentRow.Cells[4].Value.ToString();
                    tex_accesorios.Text = tabla_blusa.CurrentRow.Cells[5].Value.ToString();
                    tex_botones.Text = tabla_blusa.CurrentRow.Cells[6].Value.ToString();
                    tex_tinturado.Text = tabla_blusa.CurrentRow.Cells[7].Value.ToString();
                    tex_resortado.Text = tabla_blusa.CurrentRow.Cells[8].Value.ToString();
                   lb_corte.Text = tabla_blusa.CurrentRow.Cells[9].Value.ToString();
                    tex_forro.Text = tabla_blusa.CurrentRow.Cells[10].Value.ToString();
                    lb_neto.Text = tabla_blusa.CurrentRow.Cells[11].Value.ToString();
                    lb_min.Text = tabla_blusa.CurrentRow.Cells[12].Value.ToString();
                    lb_max.Text = tabla_blusa.CurrentRow.Cells[13].Value.ToString();
                    lb_ref.Text = tabla_blusa.CurrentRow.Cells[14].Value.ToString();
                    imagen = pictureBox1.ImageLocation = tabla_blusa.CurrentRow.Cells[15].Value.ToString();
                    imagen2 = pictureBox2.ImageLocation = tabla_blusa.CurrentRow.Cells[16].Value.ToString();
                    lb_interes.Text = tabla_blusa.CurrentRow.Cells[17].Value.ToString();
                    ne = Convert.ToInt32(tabla_blusa.CurrentRow.Cells[11].Value.ToString());
                    re1 = ne - Convert.ToInt32(tabla_blusa.CurrentRow.Cells[17].Value.ToString());
                    re = Convert.ToDecimal(tabla_blusa.CurrentRow.Cells[17].Value.ToString()) / Convert.ToDecimal(re1);
                    re3 = re * 100;
                    re2 = Convert.ToInt32(re3);
                    tex_interes.Text = (re2).ToString();
                    lb_admin.Text = tabla_blusa.CurrentRow.Cells[18].Value.ToString();
                    lb_etiqueta.Text = tabla_blusa.CurrentRow.Cells[19].Value.ToString();
                    lb_bolsa.Text = tabla_blusa.CurrentRow.Cells[20].Value.ToString();
                    lb_marquilla.Text = tabla_blusa.CurrentRow.Cells[21].Value.ToString();
                    id = Convert.ToInt32(tabla_blusa.CurrentRow.Cells[0].Value.ToString());
                    //lb_corte.Text = tabla_blusa.CurrentRow.Cells[15].Value.ToString();

                    btn_guardar.Text = "Actualizar";
                }
            }
            catch (Exception rtf)
            {
                MessageBox.Show("Hubo un Error " + rtf.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //guarda el proceso de actualizacion de los productos
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            editar_blusas_Load(sender, e);
            if (validarcampos() == true)
            {
                limpiariconos();
                try
                {
                    metros = Convert.ToInt32(tex_metros.Text);
                    accesorios = Convert.ToInt32(tex_accesorios.Text);
                    botones = Convert.ToInt32(tex_botones.Text);
                    guipuir = Convert.ToInt32(tex_gui1.Text);
                    resortado = Convert.ToInt32(tex_resortado.Text);
                    corte = Convert.ToInt32(lb_corte.Text);
                    forro = Convert.ToInt32(tex_forro.Text);
                    tinturado = Convert.ToInt32(tex_tinturado.Text);
                    confeccion = Convert.ToInt32(tex_confeccion.Text);
                    min = Convert.ToInt32(lb_min.Text) - Convert.ToInt32(lb_neto.Text);
                    maxi = Convert.ToInt32(lb_max.Text) - Convert.ToInt32(lb_neto.Text);
                    neto = marquilla + etiqueta + bolsa + admin + accesorios + metros + botones + guipuir + resortado + corte + forro + tinturado + confeccion;
                    de = Convert.ToDecimal(tex_interes.Text) / 100;
                    d = Convert.ToDecimal(neto) * de;
                    neto += Convert.ToInt32(d);
                    maxi += neto;
                    min += neto;

                    using (MySqlConnection conectar1 = new MySqlConnection(valida.Conexion()))
                    {

                        conectar1.Open();
                        MySqlCommand insertar = new MySqlCommand("Actualizar_blusa", conectar1);
                        insertar.CommandType = CommandType.StoredProcedure;
                        insertar.Parameters.AddWithValue("nv_id", id);
                        insertar.Parameters.AddWithValue("nv_nombre", tex_nombre.Text.Trim());
                        insertar.Parameters.AddWithValue("nv_mts", metros);
                        insertar.Parameters.AddWithValue("nv_gui", guipuir);
                        insertar.Parameters.AddWithValue("nv_conf", confeccion);
                        insertar.Parameters.AddWithValue("nv_acce", accesorios);
                        insertar.Parameters.AddWithValue("nv_btn", botones);
                        insertar.Parameters.AddWithValue("nv_tintu", tinturado);
                        insertar.Parameters.AddWithValue("nv_reso", resortado);
                        insertar.Parameters.AddWithValue("nv_forro", forro);
                        insertar.Parameters.AddWithValue("nv_min", min);
                        insertar.Parameters.AddWithValue("nv_max", maxi);
                        insertar.Parameters.AddWithValue("nv_neto", neto);
                        insertar.Parameters.AddWithValue("nv_ima", imagen);
                        insertar.Parameters.AddWithValue("nv_ima2", imagen2);
                        insertar.Parameters.AddWithValue("nv_interes", d);
                        insertar.ExecuteNonQuery();

                        limpiarpantalla();
                        llenar();
                        

                    }



                }
                catch (Exception er)
                {
                    MessageBox.Show("Hubo un Error " + er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                MessageBox.Show("Se Actualizó con Éxito el Producto", "Actualización Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Por favor Seleccione un producto, y luego cambie los campos deseados " , "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        private void editar_blusas_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           

        }

        private void editar_blusas_Load(object sender, EventArgs e)
        {
            llenar();
            try
            {
                DataSet datos = new DataSet();
                datos = vali.ejecutar("SELECT * FROM empresa");
                marquilla = Convert.ToInt32(datos.Tables[0].Rows[0]["marquilla"].ToString().Trim());
                etiqueta = Convert.ToInt32(datos.Tables[0].Rows[0]["etiqueta"].ToString().Trim());
                bolsa = Convert.ToInt32(datos.Tables[0].Rows[0]["bolsa"].ToString().Trim());
                admin = Convert.ToInt32(datos.Tables[0].Rows[0]["admin"].ToString().Trim());
                
            }
            catch (Exception es)
            {
                MessageBox.Show("Hubo un Error " + es.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void llenar()
        {
            try
            {
                DataSet re = new DataSet();
                Utilidades tr = new Utilidades();
                re = tr.ejecutar("SELECT id, nombre, metros, confeccion, guipiur, accesorios, botones, tinturado, resortado, corte, forro, valor_neto, valor_minimo," +
                    "valor_maximo,codigo,imagefron,imagetra,interes,admin,etiqueta,bolsa,marquilla FROM blusas");
                tabla_blusa.DataSource = re.Tables[0];
                tabla_blusa.Columns[0].Visible = false;
                tabla_blusa.Columns[14].Visible = false;
                tabla_blusa.Columns[15].Visible = false;
                tabla_blusa.Columns[16].Visible = false;
                tabla_blusa.Columns[17].Visible = false;
                tabla_blusa.Columns[18].Visible = false;
                tabla_blusa.Columns[19].Visible = false;
                tabla_blusa.Columns[20].Visible = false;
                tabla_blusa.Columns[21].Visible = false;
            }
            catch (Exception rt)
            {
                MessageBox.Show("Hubo un Error " + rt.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void limpiarpantalla()
        {
            tex_nombre.Text = tex_forro.Text = tex_botones.Text = " ";
            tex_accesorios.Text = tex_tinturado.Text = tex_confeccion.Text = " ";
            tex_gui1.Text = tex_metros.Text = tex_resortado.Text = " ";
            lb_corte.Text = lb_max.Text = lb_min.Text = lb_neto.Text = lb_ref.Text = " ";
            tex_interes.Text = null;
            pictureBox1.Image = null;
            pictureBox2.Image = null;

        }

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
            if (tex_gui1.Text == "" )
            {
                ok = false;
                errorProvider1.SetError(tex_gui1, "Ingrese el valor del Guipiur");
                

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



            return ok;
        }

        void limpiariconos()
        {
            errorProvider1.SetError(tex_nombre, "");
            errorProvider1.SetError(tex_metros, "");
            errorProvider1.SetError(tex_gui1, "");
            errorProvider1.SetError(tex_botones, "");
            errorProvider1.SetError(tex_confeccion, "");

        }

    }
}
