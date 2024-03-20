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
        public string VarColor;
        public string VarDireccion;
        public int VarNum_dir;
        public string VarEstado;
        public int VarId_localidad;


        public AgregarCasa()
        {
            con = new Datos.Coneccion();
        }
        Datos.Coneccion con;

        public DataTable FnCargarCmb(string comando)
        {
            return con.FnCargarCmb(comando);
        }

        public List<SqlParameter> para(int num)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();

            switch (num)
            {
                case 1:
                    parametros.Add(new SqlParameter("@color", VarColor));
                    parametros.Add(new SqlParameter("@direccion", VarDireccion));
                    parametros.Add(new SqlParameter("@num_direccion", VarNum_dir));
                    parametros.Add(new SqlParameter("@estado", VarEstado));
                    parametros.Add(new SqlParameter("@id_localidad", VarId_localidad));
                    break;
            }
            return parametros;
        }

        public bool FnAgregarCasa(string SP, List<SqlParameter> para)
        {
            return con.FnAgregarCasa(SP, para);
        }
    }
}
