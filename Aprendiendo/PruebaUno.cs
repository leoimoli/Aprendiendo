using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aprendiendo
{
    public partial class PruebaUno : Form
    {
        public PruebaUno()
        {
            InitializeComponent();
        }

        private void PersonaFisicaWF_Load(object sender, EventArgs e)
        {
            txtDni.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string Dni = txtDni.Text;
                string Apellido = txtApellido.Text;
                string Nombre = txtNombre.Text;
                DateTime Fecha = dtFecha.Value;
                string Sexo = cmbSexo.Text;
                string Telefono = txtTelefono.Text;
                ValidarCampos(Dni, Apellido, Nombre, Sexo, Telefono);
                GuardarPersona(Dni, Apellido, Nombre, Fecha, Sexo, Telefono);
                LimpiarCampos();
            }
            catch (Exception ex)
            {

            }

        }

        private void LimpiarCampos()
        {
            txtDni.Text = "";
            txtApellido.Text = "";
            txtNombre.Text = "";
            dtFecha.Value = DateTime.Now;
            cmbSexo.Text = "seleccione";
            txtTelefono.Text = "";
        }

        private void ValidarCampos(string dni, string Apellido, string Nombre, string Sexo, string Telefono)
        {
            if (dni == "" || Apellido == "" || Nombre == "" || Sexo == "" || Telefono == "")
            {
                MessageBox.Show("Los campos no pueden estar en blanco.");
                throw new Exception();
            }
            if (Sexo == "Seleccione")
            {
                MessageBox.Show("Debe seleccionar un Sexo.");
                throw new Exception();
            }
        }

        private void GuardarPersona(string dni, string apellido, string nombre, DateTime fecha, string Sexo, string Telefono)
        {
            MessageBox.Show("Exito");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                LimpiarCampos();
            }
            catch (Exception ex)
            { }
        }
    }
}
