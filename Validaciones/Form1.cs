using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Validaciones
{
    public partial class Form1 : Form
    {

        private bool useFirstMask = true;

        public Form1()
        {
            InitializeComponent();

            // Configuracion de la primera máscara de las patentes
            maskedTxtPatente.Mask = "";
            // Configuracion mascara Cuit
            //maskedTxtCuit.Mask = "00-00000000-0";

            // Configuracion de eventos
            maskedTxtPatente.TextChanged += MaskedTxtPatente_TextChanged;
        }

        private void btnCargarPatente_Click(object sender, EventArgs e)
        {
            if (maskedTxtPatente.Text == "")
            {
                MessageBox.Show("Ingrese un codigo de patente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                lblPatente.Text = maskedTxtPatente.Text;
                Limpiar();
            }
        }

        private void btnCargarCuit_Click(object sender, EventArgs e)
        {
            if (txtCuit.Text.Length == 11)
            {
                lblCuit.Text = "El Cuit ingresado es:" + txtCuit.Text.Substring(0, 2) + "-" + txtCuit.Text.Substring(2, 8) + "-" + txtCuit.Text.Substring(10, 1);
                lblDni.Text = "El Dni ingresado es:" + txtCuit.Text.Substring(2, 8);
            }
            else
            {
                MessageBox.Show("Complete el CUIT", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }
        public void Limpiar()
        {
            rdbtnNueva.Checked = false;
            rdbtnVieja.Checked = false;
            maskedTxtPatente.Text = "";
            maskedTxtPatente.Mask = "";

        }

        private void MaskedTxtPatente_TextChanged(object sender, EventArgs e)
        {
            if (rdbtnVieja.Checked)
            {
                useFirstMask = false;
                maskedTxtPatente.Mask = "LLL-000";
            }
            else if (rdbtnNueva.Checked)
            {
                useFirstMask = false;
                maskedTxtPatente.Mask = "LL-000-LL";
            }
        }

        private void txtCuil_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
