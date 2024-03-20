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
    public partial class frm_agregar : Form
    {
        public frm_agregar()
        {
            InitializeComponent();
            agregar = new Negocios.AgregarCasa();
            txt_color.MaxLength = 20;
            txt_direccion.MaxLength = 20;
            txt_numero.MaxLength = 5;
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

        /*cargo el combobox con las localidades y sus PK de la base de datos.*/
        private void fnLocalidadCmb(ComboBox cmb)
        {
            DataTable dt = agregar.FnCargarCmb("select nombre, id_localidad from localidad");

            DataRow fila = dt.NewRow();
            fila[0] = "elija localidad";
            fila[1] = 0;
            dt.Rows.InsertAt(fila, 0);
            cmb.DataSource = dt;
            cmb.DisplayMember = "nombre";
            cmb.ValueMember = "id_localidad"; // PK.
        }

        private bool fnComprobarTextBox(Form frm)
        {
            bool seguir = true;

            foreach (var item in frm.Controls)
            {
                if (item is TextBox)
                {
                    if (((TextBox)item).Text == "")
                    {
                        seguir = false;
                        break;
                    }
                }
            }

            return seguir;
        }


        //==================

        //private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    fnKeyPressLetras(e);
        //}

        //private void txt_apellido_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    fnKeyPressLetras(e);
        //}

        //private void txt_dni_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    fnKeyPressNumeros(e);
        //}

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_agregar_Load(object sender, EventArgs e)
        {
            fnLocalidadCmb(cmb_localidad);
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (fnComprobarTextBox(this) && cmb_localidad.SelectedIndex > 0)
            {
                int num = Convert.ToInt32(cmb_localidad.SelectedValue);
                agregar.VarColor = txt_color.Text;
                agregar.VarDireccion = txt_direccion.Text;
                agregar.VarEstado = "en venta";
                agregar.VarNum_dir = Convert.ToInt32(txt_numero.Text);
                agregar.VarId_localidad = num;

                if (agregar.FnAgregarCasa("SP_CASAS", agregar.para(1)))
                {
                    MessageBox.Show("funciono.");
                }
                else
                {
                    MessageBox.Show("Error al ingresar datos");
                }
            }
            else
            {
                MessageBox.Show("esta vacio.");
            }
        }

        private void txt_color_KeyPress(object sender, KeyPressEventArgs e)
        {
            fnKeyPressLetras(e);
        }

        private void txt_direccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            fnKeyPressLetras(e);
        }

        private void txt_numero_KeyPress(object sender, KeyPressEventArgs e)
        {
            fnKeyPressNumeros(e);
        }
    }
}
