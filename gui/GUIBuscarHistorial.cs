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
    public partial class GUIBuscarHistorial : Form
    {
        public GUIBuscarHistorial()
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
            txtNumeroHistorialBuscar.Text = "";
            txtDocumentoPacienteBuscar.Text = "";
        }
        public void buscar()
        {
            ServicioHistorialClinicoSW.HistorialClinicoSWClient servicio;
            ServicioHistorialClinicoSW.historialClinico h;

            //int numeroBuscar = Convert.ToInt32(txtNumeroHistorialBuscar.Text);
            int numeroBuscar;
            int.TryParse(txtNumeroHistorialBuscar.Text, out numeroBuscar);
            String documento = txtDocumentoPacienteBuscar.Text;
            servicio = ServicioLocalHistorial.getServicio();
            h = new ServicioHistorialClinicoSW.historialClinico();
            try
            {
                h = servicio.buscarHistorial(numeroBuscar,documento);

                txtNumeroHistorial.Text = Convert.ToString(h.numeroHistoria);
                txtNombreDoctor.Text = h.nombreDoctor;
                txtDocumentoPaciente.Text = h.fk_paciente;
                txtCodigoEnfermedad.Text = Convert.ToString(h.fk_enfermedad);
                MessageBox.Show("Historial buscado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("El Historial no existe");
            }
           
        }
        public void limpiar()
        {
            txtNumeroHistorial.Text = "";
            txtNombreDoctor.Text = "";
            txtDocumentoPaciente.Text = "";
            txtCodigoEnfermedad.Text = "";
        }
    }
}
