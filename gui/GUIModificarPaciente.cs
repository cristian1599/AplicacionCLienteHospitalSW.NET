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
    public partial class GUIModificarPaciente : Form
    {
        ServidorPacienteSW.PacienteSWClient servicio;
        ServidorPacienteSW.paciente p;
        public GUIModificarPaciente()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscar();
        }

        public void buscar()
        {
           

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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!, El Paciente buscado no existe");
            }
        }
        public void modificar()
        {
            String documentoBuscar = txtDocumentoBuscar.Text;
           
            String documento;
            String nombre;
            String correo;
            String telefono;
            String genero;

            servicio = ServicioLocalPaciente.getServicio();
            p = new ServidorPacienteSW.paciente();
            documento = txtDocumento.Text;
            nombre = txtNombre.Text;
            correo = txtCorreo.Text;
            telefono = txtTelefono.Text;
            genero = txtGenero.Text;
            p.documento = documento;
            p.nombre = nombre;
            p.correo = correo;
            p.telefono = telefono;
            p.genero = genero;
            int modificado;
            modificado = servicio.modificarPaciente(p, documentoBuscar);
            if(modificado == 1)
            {
                MessageBox.Show("Paciente modificado con exito");
            }
            else
            {
                MessageBox.Show("Error,Paciente no modificado");
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            modificar();
            limpiar();
        }

        public void limpiar()
        {
            txtDocumentoBuscar.Text = "";
            txtDocumento.Text = "";
            txtNombre.Text = "";
            txtCorreo.Text = "";
            txtTelefono.Text = "";
            txtGenero.Text = "";
        }
    }
}
