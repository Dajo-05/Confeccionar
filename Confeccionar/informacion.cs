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
    public partial class informacion : Form
    {
        public informacion()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void informacion_Load(object sender, EventArgs e)
        {
            try
            {
                Utilidades uso = new Utilidades();
                DataSet datos = uso.ejecutar("SELECT codigo,valor_neto,valor_maximo,valor_minimo,imagefron,imagetra  FROM blusas WHERE codigo ='" + Crear_Blusas.mostror_ref + "'");
                lb_ref.Text = datos.Tables[0].Rows[0]["codigo"].ToString();
                lb_neto.Text = "$ "+datos.Tables[0].Rows[0]["valor_neto"].ToString();
                lb_min.Text = "$ " + datos.Tables[0].Rows[0]["valor_minimo"].ToString();
                lb_max.Text = "$ " + datos.Tables[0].Rows[0]["valor_maximo"].ToString();
                frontal.ImageLocation = datos.Tables[0].Rows[0]["imagefron"].ToString();
                trasera.ImageLocation = datos.Tables[0].Rows[0]["imagetra"].ToString();

            }
            catch (Exception er)
            {
                MessageBox.Show("" + er.Message);
            }
          


        }
    }
}
