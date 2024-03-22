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
    public partial class FrmVentas : Form
    {
        public FrmVentas()
        {
            InitializeComponent();
        }

        private void FrmVentas_Load(object sender, EventArgs e)
        {
            txt_nombre.MaxLength = 20;
            txt_apellido.MaxLength = 20;
            txt_dni.MaxLength = 10;
            txt_telefono.MaxLength = 20;
        }

        //================================
        // metodos
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
        //================================

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

        private void txt_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            fnKeyPressNumeros(e);
        }

        
    }
}
