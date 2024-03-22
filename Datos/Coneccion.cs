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

        public bool FnAgregarCasa(string SP, List<SqlParameter> para)
        {
            try
            {
                using (var con = FnConeccion())
                {
                    con.Open();

                    using (var orden = new SqlCommand())
                    {
                        orden.Connection = con;
                        orden.CommandText = SP;
                        orden.CommandType = CommandType.StoredProcedure;

                        foreach (var item in para)
                        {
                            orden.Parameters.Add(item);
                        }
                        orden.ExecuteNonQuery();

                        return true;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        /*vista con SP con entrada de parametros.*/
        public DataTable FnVistaSP(string SP, List<SqlParameter> parametro)
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
                        orden.CommandText = SP;
                        orden.CommandType = CommandType.StoredProcedure;

                        foreach (var item in parametro)
                        {
                            orden.Parameters.Add(item);
                        }

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

        /*vista con SP sin entrada de parametros.*/
        public DataTable FnVistaSP(string SP)
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
                        orden.CommandText = SP;
                        orden.CommandType = CommandType.StoredProcedure;

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
