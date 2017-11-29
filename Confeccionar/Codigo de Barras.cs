using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;

namespace Confeccionar
{
    public partial class Codigo_de_Barras : Form
    {
        public Codigo_de_Barras()
        {
            InitializeComponent();
        }
        bool ok = false;
        bool veri = false;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        void llenar2()
        {
            try
            {
                DataSet re = new DataSet();
                Utilidades tr = new Utilidades();
                re = tr.ejecutar("SELECT nombre, codigo, valor_neto,valor_minimo, valor_maximo FROM blusas");
                tabla_barra.DataSource = re.Tables[0];
                
            }
            catch (Exception rt)
            {
                MessageBox.Show("ocurrio un error" + rt.Message);
            }

        }

        private void Codigo_de_Barras_Load(object sender, EventArgs e)
        {
            llenar2();
        }

        private void tabla_barra_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (tabla_barra.CurrentRow.Index !=-1)
                {
                    lb_nombre.Text = tabla_barra.CurrentRow.Cells[0].Value.ToString();
                    lb_referencia.Text = tabla_barra.CurrentRow.Cells[1].Value.ToString();
                    lb_neto.Text = "$ " + tabla_barra.CurrentRow.Cells[2].Value.ToString();
                    lb_min.Text = "$ " + tabla_barra.CurrentRow.Cells[3].Value.ToString();
                    lb_max.Text = "$ " + tabla_barra.CurrentRow.Cells[4].Value.ToString();
                    veri = true;

                }

            }
            catch (Exception ef)
            {
                MessageBox.Show("Hubo un problema" + ef.Message);
            }
        }

        private void btn_generar_Click(object sender, EventArgs e)
        {
            if (veri)
            {
                Barcode128 codigoB = new Barcode128();
                codigoB.BarHeight = 50;
                codigoB.Code = lb_referencia.Text;
                codigoB.CodeType = Barcode.CODE128;
                try
                {
                    Bitmap bm = new Bitmap(codigoB.CreateDrawingImage(Color.Black, Color.White));
                    Image ima;
                    ima = new Bitmap(bm.Width, bm.Height);
                    Graphics gra = Graphics.FromImage(ima);
                    gra.FillRectangle(new SolidBrush(Color.White), 0, 0, bm.Width, bm.Height);
                    gra.DrawImage(bm, 0, 0);
                    barra.Image = ima;
                    ok = true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se puede  generar " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor seleccione un elemeto de la tabla para generar codigo de barras" );
            }
            

        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            try
            {               
                if (ok)
                {
                    printPreviewDialog1.ShowDialog();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede  generar " + ex.Message);
            }

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(barra.Width, barra.Height);
            Bitmap bm1 = new Bitmap(barra.Width, barra.Height);
            barra.DrawToBitmap(bm, new Rectangle(10, 2, bm.Width, bm.Height));
            barra.DrawToBitmap(bm1, new Rectangle(10, 7, bm.Width, bm.Height));
            e.Graphics.DrawImage(bm, 2, 2);
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tex_buscar.Text.Trim()) == false)
            {
                try
                {
                    DataSet re = new DataSet();
                    Utilidades tr = new Utilidades();
                    re = tr.ejecutar("SELECT nombre, codigo, valor_neto,valor_minimo, valor_maximo FROM blusas WHERE nombre LIKE '" + tex_buscar.Text + "%'");
                    tabla_barra.DataSource = re.Tables[0];
                    tabla_barra.Columns[0].Visible = false;
                }
                catch (Exception rt)
                {
                    MessageBox.Show("ocurrio un error" + rt.Message);
                }
            }
            else
            {
                try
                {
                    DataSet re = new DataSet();
                    Utilidades tr = new Utilidades();
                    re = tr.ejecutar("SELECT nombre, codigo, valor_neto,valor_minimo, valor_maximo FROM blusas WHERE nombre LIKE '" + tex_buscar.Text + "%'");
                    tabla_barra.DataSource = re.Tables[0];
                    tabla_barra.Columns[0].Visible = false;
                }
                catch (Exception rt)
                {
                    MessageBox.Show("ocurrio un error" + rt.Message);
                }
            }
        }
    }
}
