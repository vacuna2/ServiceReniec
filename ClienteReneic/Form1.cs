using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteReneic
{
    public partial class Form1 : Form
    {
        ServiceReference1.ReniecServiceSoapClient servicio = new ServiceReference1.ReniecServiceSoapClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            string dni = txtDni.Text;
            if(dni.Length >= 8)
            {
                dgvReniec.DataSource = servicio.ListarCiudadanoDni(dni).Tables[0];
            }
            //servicio.ListarCiudadanoDni(dni);
        }
        private void listar()
        {
            
           // dgvReniec.DataBind();
        }

        private void dgvReniec_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
