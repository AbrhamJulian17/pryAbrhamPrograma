using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pryAbrhamPrograma
{
    public partial class Programa : Form
    {
        public Programa()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private int nroTicket = 126;

        private void Programa_Load(object sender, EventArgs e)
        {
            cboTipo.Items.Clear();
            cboTipo.Items.Add("PC");
            cboTipo.Items.Add("Notebook");

            cboFalla.Items.Clear();
            cboFalla.Items.Add("No enciende");
            cboFalla.Items.Add("Pantalla");
            cboFalla.Items.Add("Disco / almacenamiento");
            cboFalla.Items.Add("Virus / software");
            cboFalla.Items.Add("Otra");

            txtNroTicket.Text = nroTicket.ToString();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() == "" || txtApellido.Text.Trim() == "")
            {
                MessageBox.Show("Ingresá nombre y apellido.");
                txtNombre.Focus();
                return;
            }

            if (!txtCorreo.Text.Contains("@"))
            {
                MessageBox.Show("El correo no es válido.");
                txtCorreo.Focus();
                return;
            }



            if (cboTipo.SelectedIndex == -1)
            {
                MessageBox.Show("Elegí el tipo de equipo.");
                cboTipo.Focus();
                return;
            }

            if (txtNroSerie.Text.Trim() == "")
            {
                MessageBox.Show("Ingresá el número de serie.");
                txtNroSerie.Focus();
                return;
            }

            if (cboFalla.SelectedIndex == -1)
            {
                MessageBox.Show("Elegí la categoría de la falla.");
                cboFalla.Focus();
                return;
            }

            if (txtDescripcion.Text.Trim() == "")
            {
                MessageBox.Show("Ingresá la descripción / diagnóstico.");
                txtDescripcion.Focus();
                return;
            }

            if (!decimal.TryParse(txtPresupuesto.Text, out decimal presupuesto) || presupuesto < 0)
            {
                MessageBox.Show("El presupuesto debe ser un número válido.");
                txtPresupuesto.Focus();
                return;

            }
            MessageBox.Show(
      "Ticket Nº " + nroTicket + " registrado\n\n" +
      "Cliente: " + txtNombre.Text + " " + txtApellido.Text + "\n" +
      "Equipo: " + cboTipo.Text + " (Serie: " + txtNroSerie.Text + ")\n" +
      "Falla: " + cboFalla.Text + "\n" +
      "Presupuesto: $" + presupuesto);

            nroTicket++;

        }

        private void txtNroTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {

            // 48 a 57 = números, 8 = borrar
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8)
            {
                e.Handled = false;   // deja escribir
            }
            else
            {
                e.Handled = true;    // bloquea la tecla
            }
        }
    }
    }


