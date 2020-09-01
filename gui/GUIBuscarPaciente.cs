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
    public partial class GUIBuscarPaciente : Form
    {
        public GUIBuscarPaciente()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            limpiar();
            buscar();
            txtDocumentoBuscar.Text = "";
            

        }

        public void buscar()
        {
            ServidorPacienteSW.PacienteSWClient servicio;
            ServidorPacienteSW.paciente p;

            String documentoBuscar = txtDocumentoBuscar.Text;
            servicio = ServicioLocalPaciente.getServicio();
            p = new ServidorPacienteSW.paciente();
            try
            {
                p = servicio.buscarPaciente(documentoBuscar);
                txtDocumento.Text = p.documento;
                txtNombre.Text = p.nombre;
                txtCorreo.Text = p.correo;
                txtTelefono.Text = p.telefono;
                txtGenero.Text = p.genero;
                MessageBox.Show("Paciente buscado");
            }catch(Exception ex)
            {
                MessageBox.Show("Error, El Paciente Buscado No existe");
            }
        }
        public void limpiar()
        {
            //txtDocumentoBuscar.Text = "";
            txtDocumento.Text = "";
            txtNombre.Text = "";
            txtCorreo.Text = "";
            txtTelefono.Text = "";
            txtGenero.Text = "";
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
