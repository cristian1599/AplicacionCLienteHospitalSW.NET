using ClienteHospitalSWNet.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteHospitalSWNet.gui
{
    public partial class GUIAgregarPaciente : Form
    {
        public GUIAgregarPaciente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            ServidorPacienteSW.PacienteSWClient servicio;
            ServidorPacienteSW.paciente p;
            String documento;
            String nombre;
            String correo;
            String telefono;
            String genero;

            // servicio = new ServidorPacienteSW.PacienteSWClient();
            servicio = ServicioLocalPaciente.getServicio();
            p = new ServidorPacienteSW.paciente();
            documento = txtDocumento.Text;
            nombre = txtNombre.Text;
            correo = txtCorreo.Text;
            telefono = txtTelefono.Text;
            if(radioButMasculino.Checked)
            {
                genero = radioButMasculino.Text;
            }
            else
            {
                genero = radioButFemenino.Text;
            }

            p.documento = documento;
            p.nombre = nombre;
            p.correo = correo;
            p.telefono = telefono;
            p.genero = genero;
            try
            {
                servicio.agregarPaciente(p);
                MessageBox.Show("paciente agregado correctamente");
            }catch(Exception ex)
            {
                MessageBox.Show("Error!!!" + ex);
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void limpiar()
        {
            txtDocumento.Text = "";
            txtNombre.Text = "";
            txtCorreo.Text = "";
            txtTelefono.Text = "";
            radioButFemenino.Checked = false;
            radioButFemenino.Checked = false;
        }
    }
}
