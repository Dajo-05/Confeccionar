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
    public partial class Consulta_de_blusa : Form
    {
        public Consulta_de_blusa()
        {
            InitializeComponent();
        }
        Utilidades tr = new Utilidades();
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Consulta_de_blusa_Load(object sender, EventArgs e)
        {
            llenar();
        }

        void llenar()
        {
            try
            {
                DataSet re = new DataSet();
                
                re = tr.ejecutar("SELECT  codigo, nombre, valor_neto, valor_minimo, valor_maximo FROM blusas");
                tabla_consulta.DataSource = re.Tables[0];
                
            }
            catch (Exception rt)
            {
                MessageBox.Show("ocurrio un error" + rt.Message);
            }
        }

        private void btn_selclie_Click(object sender, EventArgs e)
        {
            if (tabla_consulta.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
