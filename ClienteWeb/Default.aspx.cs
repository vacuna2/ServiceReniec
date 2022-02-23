using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace ClienteWeb
{
    public partial class _Default : Page
    {
        srListar.ReniecServiceSoapClient servicio = new srListar.ReniecServiceSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string dni = txtDNI.Text.Trim();
            gvCiudadanos.DataSource = servicio.ListarCiudadanoDni(dni).Tables[0];
            gvCiudadanos.DataBind();
        }


    }
}