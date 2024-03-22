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
    public partial class frm_venta_hogar : Form
    {
        public frm_venta_hogar()
        {
            InitializeComponent();
        }

        //=================
        // metodos.
        Form frm_contenedor;
        private void fnAbrirForms(Form frm)
        {
            if (frm_contenedor != null)
            {
                frm_contenedor = null;
            }
            if (pnl_contenedor.Controls.Count > 0)
            {
                pnl_contenedor.Controls.RemoveAt(0);
            }
            frm_contenedor = frm;

            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            pnl_contenedor.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }
        //=================
        private void frm_venta_hogar_Load(object sender, EventArgs e)
        {

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            //frm_agregar frmagr = new frm_agregar();
            fnAbrirForms(new frm_agregar());
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            fnAbrirForms(new FrmModificar());
        }

        private void btn_vender_Click(object sender, EventArgs e)
        {

        }

    }
}
