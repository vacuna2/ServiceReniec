using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data; //bd's
using System.Data.SqlClient; //sql server
using System.Configuration; //web config

namespace ServiceReniec
{
    /// <summary>
    /// Descripción breve de ReniecService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class ReniecService : System.Web.Services.WebService
    {
        private static string cadena = ConfigurationManager.ConnectionStrings["Cadena"].ConnectionString;
        private static SqlConnection conexion = new SqlConnection(cadena);

        [WebMethod(Description = "Listar los datos de acuerdo a DNI")]
        public DataSet ListarCiudadanoDni(string dni)
        {
            string query = "select * from TCiudadano where dni = '" + dni +"'";
            SqlCommand cmd = new SqlCommand(query, conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet data = new DataSet();
            adapter.Fill(data);
            return data;
        }

        [WebMethod(Description = "Listar Todo")]
        public DataSet Listar()
        {
            string query = "select * from TCiudadano";
            SqlCommand cmd = new SqlCommand(query, conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet data = new DataSet();
            adapter.Fill(data);
            return data;
        }
    }
}
