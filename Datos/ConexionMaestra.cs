using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace git_practica_2.Datos
{
    public class ConexionMaestra
    {
        private string Coneccion = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=venta_de_casas;Integrated Security=True";

        public SqlConnection FnConeccion()
        {
            return new SqlConnection(Coneccion);
        }
    }
}
