using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace git_practica_2
{
    public partial class FrmModificar : Form
    {
        public FrmModificar()
        {
            InitializeComponent();
            //casa = new FrmModificarCasaMenu(this.loc);
            agregar = new Negocios.AgregarCasa();
        }
        
        //FrmModificarCasaMenu casa;
        Negocios.AgregarCasa agregar;

        private int fila;
        private string loc;
        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmModificar_Load(object sender, EventArgs e)
        {
            int numero = 10;
            fnCargarGrilla();
        }

        //========================
        // metodos
        private void fnMostrarFormulario(Form frm)
        {
            frm.ShowDialog();
        }

        /*modificar la carga de la grilla, agregar las columnas a mano e ingresar losregistros.*/
        private void fnCargarGrilla()
        {
            if (dtg_mostrar_casas.Rows.Count > 0)
            {
                int indice = dtg_mostrar_casas.Rows.Count;
                for (int i = 0; i < indice; i++)
                {
                    dtg_mostrar_casas.Rows.RemoveAt(0);
                }
            }
            
            agregar.VarEstado = "en venta";
            DataTable dt = agregar.FnVistaSP("SP_VISTA_CASA_CON_ID", agregar.para(2));

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dtg_mostrar_casas.Rows.Add(dt.Rows[i]["color"].ToString(), dt.Rows[i]["direccion"].ToString(), dt.Rows[i]["num_direccion"].ToString(), 
                    dt.Rows[i]["estado"].ToString(), dt.Rows[i]["nombre"].ToString(),dt.Rows[i]["id_casa"].ToString());
            }
        }

        private void fnCargarGrillaAlCerrar(object sender, FormClosedEventArgs e)
        {
            fnCargarGrilla();
        }

        //========================
        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (fila != -1)
            {
                this.loc = dtg_mostrar_casas[4, fila].Value.ToString();

                FrmModificarCasaMenu casa = new FrmModificarCasaMenu(this.loc);
                casa.txt_color.Text = dtg_mostrar_casas[0, fila].Value.ToString();
                casa.txt_direccion.Text = dtg_mostrar_casas[1, fila].Value.ToString();
                casa.txt_numero.Text = dtg_mostrar_casas[2, fila].Value.ToString();
                casa.VarIdCasa = Convert.ToInt32(dtg_mostrar_casas["id_casa",fila].Value);
                casa.FormClosed += fnCargarGrillaAlCerrar;

                fnMostrarFormulario(casa);

                
            }
            else
            {
                MessageBox.Show("Eliga una fial", "Sin fila", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dtg_mostrar_casas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtg_mostrar_casas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
        }
    }
}
