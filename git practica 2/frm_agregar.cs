﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace git_practica_2
{
    public partial class frm_agregar : Form
    {
        public frm_agregar()
        {
            InitializeComponent();
            agregar = new Negocios.AgregarCasa();
        }

        Negocios.AgregarCasa agregar;
        //=================
        //Metodos.
        private void fnKeyPressLetras(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == true)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }

        private void fnKeyPressNumeros(KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }

        private void fnLocalidadCmb(ComboBox cmb)
        {
            DataTable dt = agregar.FnCargarCmb("select nombre, id_localidad from localidad");

            DataRow fila = dt.NewRow();
            fila[0] = "elija localidad";
            fila[1] = 0;
            dt.Rows.InsertAt(fila, 0);
            cmb.DataSource = dt;
            cmb.DisplayMember = "nombre";
            cmb.ValueMember = "id_localidad";
        }
        //==================

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            fnKeyPressLetras(e);
        }

        private void txt_apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            fnKeyPressLetras(e);
        }

        private void txt_dni_KeyPress(object sender, KeyPressEventArgs e)
        {
            fnKeyPressNumeros(e);
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_agregar_Load(object sender, EventArgs e)
        {
            fnLocalidadCmb(cmb_localidad);
        }
    }
}
