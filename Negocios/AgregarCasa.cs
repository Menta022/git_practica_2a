using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace git_practica_2.Negocios
{
    public class AgregarCasa 
    {
        public AgregarCasa()
        {
            con = new Datos.Coneccion();
        }
        Datos.Coneccion con;

        public DataTable FnCargarCmb(string comando)
        {
            return con.FnCargarCmb(comando);
        }
    }
}
