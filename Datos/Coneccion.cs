using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace git_practica_2.Datos
{
    public class Coneccion : ConexionMaestra
    {
        public DataTable FnCargarCmb(string comando)
        {
            DataTable dt = new DataTable();
            try
            {
                using (var con = FnConeccion())
                {
                    con.Open();
                    using (var orden = new SqlCommand())
                    {
                        orden.Connection = con;
                        orden.CommandText = comando;
                        orden.CommandType = CommandType.Text;
                        SqlDataReader leer = orden.ExecuteReader();
                        dt.Load(leer);
                        return dt;
                    }
                }
            }
            catch
            {
                return null;
            }
        }
    }
}
