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
    public partial class GUIEliminarHistorial : Form
    {
        ServicioHistorialClinicoSW.HistorialClinicoSWClient servicio;
        ServicioHistorialClinicoSW.historialClinico h;

        public GUIEliminarHistorial()
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
                MessageBox.Show("Error, El Historial Buscado No Existe");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int numeroBuscar = Convert.ToInt32(txtNumeroHistorialBuscar.Text);
            servicio = ServicioLocalHistorial.getServicio();
            try
            {
                servicio.eliminarHistorial(numeroBuscar);
                MessageBox.Show("Historial Eliminado con Exito");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar historial ");
            }
            limpiar();
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
