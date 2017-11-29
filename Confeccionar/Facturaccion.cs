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
    public partial class Facturaccion : Form
    {
        public Facturaccion()
        {
            InitializeComponent();
        }
        Utilidades utilizar = new Utilidades();
        string d, numero_factura;
        int numero;

        private bool validarcampos()
        {
            bool ok = true;
          
            if (tex_nombre.Text == "")
            {
                ok = false;
                errorProvider1.SetError(tex_nombre, "Por favor Seleccione un producto del boton agregar producto");

            }
            if (tex_referencia.Text == "")
            {
                ok = false;
                errorProvider1.SetError(tex_referencia, "Por favor Seleccione un producto del boton agregar producto");

            }
            if (tex_cantidad.Text == "")
            {
                ok = false;
                errorProvider1.SetError(tex_cantidad, "Ingrese el valor sin puntos");

            }
            if (tex_venta.Text == "")
            {
                ok = false;
                errorProvider1.SetError(tex_venta, "Ingrese el valor sin puntos");

            }
            if (tex_cliente.Text == "")
            {
                ok = false;
                errorProvider1.SetError(tex_cliente, "Por favor Seleccione un producto del boton agregar cliente");
            }
            if (tex_docu.Text == "")
            {
                ok = false;
                errorProvider1.SetError(tex_docu, "Por favor Seleccione un producto del boton agregar cliente");

            }
            if (tex_tel.Text == "")
            {
                ok = false;
                errorProvider1.SetError(tex_tel, "Por favor Seleccione un producto del boton agregar producto");

            }
            return ok;
        }
        void limpiariconos()
        {
            errorProvider1.SetError(tex_nombre, "");
            errorProvider1.SetError(tex_referencia, "");
            errorProvider1.SetError(tex_cantidad, "");
            errorProvider1.SetError(tex_venta, "");
            errorProvider1.SetError(tex_cliente, "");
            errorProvider1.SetError(tex_docu, "");
            errorProvider1.SetError(tex_tel, "");


        }
        
        public static int contador = 0;//permite contar las filas de la tabla
        public static double total,total2,ta ;
        public static double ganancia,gan,nu;
        public static bool verificar = false;
        //agrega los elementos a la tabla
        private void btn_agragar_Click(object sender, EventArgs e)
        {
            bool existe = false;
            int num_fila = 0;
            if (validarcampos() == true)
            {
                limpiariconos();
                //agrega a la tabla lo que se digita en los textbox
                if (contador == 0)
                {
                    tabla_factura.Rows.Add(tex_referencia.Text, tex_nombre.Text, tex_venta.Text, tex_cantidad.Text);
                    double venta = Convert.ToDouble(tabla_factura.Rows[contador].Cells[2].Value) * Convert.ToDouble(tabla_factura.Rows[contador].Cells[3].Value);
                    tabla_factura.Rows[contador].Cells[4].Value = venta;
                    verificar = true;
                       contador++;
                }
                else
                {
                    //verifica si es la misma referencia para actualizar el valor y la cantidad
                    foreach (DataGridViewRow fila in tabla_factura.Rows)
                    {
                        if (fila.Cells[0].Value.ToString() == tex_referencia.Text)
                        {
                            existe = true;
                            num_fila = fila.Index;
                        }
                    }
                    if (existe == true)
                    {
                        tabla_factura.Rows[num_fila].Cells[3].Value = (Convert.ToDouble(tex_cantidad.Text) + Convert.ToDouble(tabla_factura.Rows[num_fila].Cells[3].Value)).ToString();
                        double venta = Convert.ToDouble(tabla_factura.Rows[num_fila].Cells[2].Value) * Convert.ToDouble(tabla_factura.Rows[num_fila].Cells[3].Value);
                        tabla_factura.Rows[num_fila].Cells[4].Value = venta;
                    }
                    else
                    {
                        tabla_factura.Rows.Add(tex_referencia.Text, tex_nombre.Text, tex_venta.Text, tex_cantidad.Text);
                        double venta = Convert.ToDouble(tabla_factura.Rows[contador].Cells[2].Value) * Convert.ToDouble(tabla_factura.Rows[contador].Cells[3].Value);
                        tabla_factura.Rows[contador].Cells[4].Value = venta;

                        contador++;
                    }
                }
                //esto permite sumar el total 
                total = 0;
                foreach (DataGridViewRow fila in tabla_factura.Rows)
                {
                    total += Convert.ToDouble(fila.Cells[4].Value);
                }

                lb_total.Text = "S " + total.ToString();
                //esto muestra la ganancia
                gan= 0;               
                ta = 0;
                if (existe == true)
                {
                    
                    gan += Convert.ToDouble(lb_neto.Text);
                    ta = Convert.ToDouble(tex_cantidad.Text) * gan;
                    nu += ta;
                    total2 = total - nu;
                }
                else
                {
                    gan += Convert.ToDouble(lb_neto.Text);
                    ta = Convert.ToDouble(tex_cantidad.Text) * gan;
                    nu += ta;
                    total2 = total - nu;
                }

                label2.Text = (ta).ToString();
                lb_ganar.Text = "$ " + (total2).ToString();
            }
            else
            {
                MessageBox.Show("Por favo diligenciar todos los campos","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

            
        }

        private void tex_referencia_TextChanged(object sender, EventArgs e)
        {

        }

        private void tex_nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_cliente_Click(object sender, EventArgs e)
        { Editar_clientes cli = new Editar_clientes();
            cli.ShowDialog();
            if (cli.DialogResult == DialogResult.OK)
            {
                tex_cliente.Text = cli.tabla_cliente.Rows[cli.tabla_cliente.CurrentRow.Index].Cells[1].Value.ToString();
                tex_docu.Text  = cli.tabla_cliente.Rows[cli.tabla_cliente.CurrentRow.Index].Cells[2].Value.ToString();
                tex_tel.Text = cli.tabla_cliente.Rows[cli.tabla_cliente.CurrentRow.Index].Cells[3].Value.ToString();

            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void tex_venta_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilizar.ValidarNumeros(e);
        }

        private void tex_cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilizar.ValidarNumeros(e);
        }

        private void btn_facturar_Click(object sender, EventArgs e)
        {
            if (verificar == true)
            {
                numero_factura = consecutivo();
                if (contador != 0)
                {
                    try
                    {
                        using (MySqlConnection conectar = new MySqlConnection(utilizar.Conexion()))
                        {
                            conectar.Open();
                            MySqlCommand cmd = new MySqlCommand("Agregar_factura", conectar);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("nufac", numero_factura);
                            cmd.Parameters.AddWithValue("clien", tex_cliente.Text.Trim());
                            cmd.Parameters.AddWithValue("nit", tex_docu.Text.Trim());
                            cmd.Parameters.AddWithValue("tel", tex_tel.Text.Trim());
                            cmd.Parameters.AddWithValue("gan", total2);
                            cmd.Parameters.AddWithValue("tot", total);
                            cmd.ExecuteNonQuery();
                            conectar.Close();
                        }

                        foreach (DataGridViewRow fila in tabla_factura.Rows)
                        {

                            utilizar.ejecutar("CALL Agregar_venta('" + numero_factura + "','" + fila.Cells[0].Value.ToString() + "','" + fila.Cells[1].Value.ToString() + "'," +
                                "'" + fila.Cells[3].Value.ToString() + "','" + fila.Cells[2].Value.ToString() + "','" + fila.Cells[4].Value.ToString() + "')");

                        }


                        DataSet dato;
                        dato = utilizar.ejecutar("CALL Consulta_venta('" + numero_factura + "')");

                        Reporte repor = new Reporte();
                        repor.reportViewer1.LocalReport.DataSources[0].Value = dato.Tables[0];
                        repor.ShowDialog();


                    }
                    catch (Exception se)
                    {
                        MessageBox.Show("Hubo un Error" + se.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            
        }

        void Limpiar()
        {
            tex_nombre.Text = "";
            tex_cantidad.Text = "";
            tex_cliente.Text = "";
            tex_docu.Text = "";
            tex_referencia.Text = "";
            tex_tel.Text = "";
            tex_venta.Text = "";
            lb_factura.Text = "";
            lb_ganar.Text = "$ 0";
            lb_total.Text = "$ 0";
            lb_max.Text = "$ 0";
            lb_min.Text = "$ 0";
            lb_neto.Text = "$ 0";
            lb_ganar.Text = "$ 0";
            contador = 0;
            total = 0;
            ganancia = 0;
            ta = 0;
            gan = 0;
            nu = 0;
            tabla_factura.Rows.Clear();


        }

        private void Facturaccion_Load(object sender, EventArgs e)
        {
            lb_fecha.Text = System.DateTime.Today.ToString("d");
            lb_ganar.Text = "$ 0";
            lb_total.Text = "$ 0";
            lb_max.Text = "$ 0";
            lb_min.Text = "$ 0";
            lb_neto.Text = "$ 0";
            lb_ganar.Text = "$ 0";
            lb_factura.Text = consecutivo();

        }

        private void btn_producto_Click(object sender, EventArgs e)
        {
            Consulta_de_blusa consu = new Consulta_de_blusa();
            consu.ShowDialog();
            if (consu.DialogResult == DialogResult.OK)
            {
                tex_referencia.Text = consu.tabla_consulta.Rows[consu.tabla_consulta.CurrentRow.Index].Cells[0].Value.ToString();
                tex_nombre.Text = consu.tabla_consulta.Rows[consu.tabla_consulta.CurrentRow.Index].Cells[1].Value.ToString();
                lb_neto.Text = consu.tabla_consulta.Rows[consu.tabla_consulta.CurrentRow.Index].Cells[2].Value.ToString();
                lb_min.Text = consu.tabla_consulta.Rows[consu.tabla_consulta.CurrentRow.Index].Cells[3].Value.ToString();
                lb_max.Text = consu.tabla_consulta.Rows[consu.tabla_consulta.CurrentRow.Index].Cells[4].Value.ToString();
            }

        }

        public string consecutivo()
        {
            MySqlDataReader ds;
            

            try
            {
                using (MySqlConnection cone = new MySqlConnection(utilizar.Conexion()))
                {
                    cone.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT count(*) FROM numfactura", cone);
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
                MessageBox.Show(" " + es);
            }
            return d;
        }


    }
}
