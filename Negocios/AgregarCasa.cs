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
        public int VarId_casa;


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
                case 1: // agregar casa.
                    parametros.Add(new SqlParameter("@color", VarColor));
                    parametros.Add(new SqlParameter("@direccion", VarDireccion));
                    parametros.Add(new SqlParameter("@num_direccion", VarNum_dir));
                    parametros.Add(new SqlParameter("@estado", VarEstado));
                    parametros.Add(new SqlParameter("@id_localidad", VarId_localidad));
                    break;
                case 2: // vista de casa, estado en venta o vedido para SP_VISTA_CASA y SP_VISTA_CASA_CON_ID
                    parametros.Add(new SqlParameter("@estado", VarEstado));
                    break;
                case 3: // modificar casa.
                    parametros.Add(new SqlParameter("@color", VarColor));
                    parametros.Add(new SqlParameter("@direccion", VarDireccion));
                    parametros.Add(new SqlParameter("@num_direccion", VarNum_dir));
                    parametros.Add(new SqlParameter("@id_localidad", VarId_localidad));
                    parametros.Add(new SqlParameter("@id_casa", VarId_casa));
                    break;
            }
            return parametros;
        }

        public bool FnAgregarCasa(string SP, List<SqlParameter> para)
        {
            return con.FnAgregarCasa(SP, para);
        }

        /*vista con SP con entrada de parametros.*/
        public DataTable FnVistaSP(string SP, List<SqlParameter> parametro)
        {
            return con.FnVistaSP(SP, parametro);
        }

        /*vista con SP sin entrada de parametros.*/
        public DataTable FnVistaSP(string SP)
        {
            return con.FnVistaSP(SP);
        }
    }
}
