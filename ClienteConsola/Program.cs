using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ClienteConsola
{
    class Program
    {
        static ServicioReniecFake.ReniecServiceSoapClient service = new ServicioReniecFake.ReniecServiceSoapClient();

        static DataSet ListarDni(string dni)
        {
            DataSet data = service.ListarCiudadanoDni(dni);
            return data;
        }

        static void Main(string[] args)
        {
            bool op = true;
            while(op)
            {
                Console.Write("Ingrese el Numero de DNI que desea Buscar: ");
                string dni = Console.ReadLine();
                DataSet tabla = ListarDni(dni);
                Console.WriteLine();

                if (tabla.Tables[0].Rows.Count != 0)
                {
                    Console.WriteLine("DNI: " + tabla.Tables[0].Rows[0][0] + " NOMBRE: " + tabla.Tables[0].Rows[0][1] + " APELLIDO: " + tabla.Tables[0].Rows[0][2]);
                }
                else
                {
                    Console.WriteLine("NO SE ENCONTRARON DATOS");
                }
                Console.Write("REALIZAR OTRA BUSQUEDA? S/N: ");
                op = Console.ReadLine() == "S" ? true : false;
                Console.WriteLine();
            }
        }
    }
}