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
    public partial class GUIModificarHistorial : Form
    {
        ServicioHistorialClinicoSW.HistorialClinicoSWClient servicio;
        ServicioHistorialClinicoSW.historialClinico h;
        public GUIModificarHistorial()
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

            String numeroBuscar = txtNumeroHistorialBuscar.Text;
            servicio = ServicioLocalHistorial.getServicio();
            h = new ServicioHistorialClinicoSW.historialClinico();
            try
            {
                h = servicio.buscarHistorialSolo(Convert.ToInt32(numeroBuscar));

                txtNumeroHistorial.Text = Convert.ToString(h.numeroHistoria);
                txtNombreDoctor.Text = h.nombreDoctor;
                txtDocumentoPaciente.Text = h.fk_paciente;
                txtCodigoEnfermedad.Text = Convert.ToString(h.fk_enfermedad);
                MessageBox.Show("Historial buscado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error, El hsitorial Buscado No Existe");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            modificar();
            limpiar();
        }
        public void modificar()
        {
            String numeroBuscar = txtNumeroHistorialBuscar.Text;

            int numeroHistoria;
            String nombreDoctor;
            String fk_paciente;
            int fk_enfermedad;

            servicio = ServicioLocalHistorial.getServicio();
            h = new ServicioHistorialClinicoSW.historialClinico();

            numeroHistoria = Convert.ToInt32(txtNumeroHistorial.Text);
            nombreDoctor = txtNombreDoctor.Text;
            fk_paciente = txtDocumentoPaciente.Text;
            fk_enfermedad = Convert.ToInt32(txtCodigoEnfermedad.Text);

            h.numeroHistoria = numeroHistoria;
            h.nombreDoctor = nombreDoctor;
            h.fk_paciente = fk_paciente;
            h.fk_enfermedad = fk_enfermedad;

            int modificado;

            modificado = servicio.modificarHistorial(h, Convert.ToInt32(numeroBuscar));
            if (modificado == 1)
            {
                MessageBox.Show("Historial modificado con exito");
            }
            else
            {
                MessageBox.Show("Error, Historial no modificado");
            }
           
        }

        public void limpiar()
        {
            txtNumeroHistorialBuscar.Text = "";
            txtNumeroHistorial.Text = "";
            txtNombreDoctor.Text = "";
            txtCodigoEnfermedad.Text = "";
            txtDocumentoPaciente.Text = "";
        }
    }
}
