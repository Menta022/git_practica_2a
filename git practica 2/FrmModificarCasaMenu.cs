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
    public partial class FrmModificarCasaMenu : Form
    {
        public FrmModificarCasaMenu(string localidad)
        {
            InitializeComponent();
            agregar = new Negocios.AgregarCasa();
            loc = localidad;
        }

        Negocios.AgregarCasa agregar;
        private void FrmModificarCasaMenu_Load(object sender, EventArgs e)
        {
            fnLocalidadCmb(cmb_localidad);
            cmb_localidad.Text = loc;
        }

        private string loc;
        public int VarIdCasa;
        /*=============================*/
        /*metodos*/
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

        private void fnValidarDatos(Form frm)
        {
            if (fnComprobarTextBox(frm) && cmb_localidad.SelectedIndex > 0)
            {
                agregar.VarColor = txt_color.Text;
                agregar.VarDireccion = txt_direccion.Text;
                agregar.VarNum_dir = Convert.ToInt32(txt_numero.Text);
                agregar.VarId_localidad = Convert.ToInt32(cmb_localidad.SelectedValue);
                agregar.VarId_casa = VarIdCasa;

                if (agregar.FnAgregarCasa("SP_UPDATE_CASA", agregar.para(3)))
                {
                    MessageBox.Show("Se modifico la casa satisfactoriamente.", "Modificacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ocurrio un error al modificar casa, verifique los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Campos vacios", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //============================

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            fnValidarDatos(this);
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
