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
    public partial class GUIAgregarHistorialClinico : Form
    {
        public GUIAgregarHistorialClinico()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCodigoEnfermedad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDocumentoPaciente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombreDoctor_TextChanged(object sender, EventArgs e)
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNumeroHistorial_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ServicioHistorialClinicoSW.HistorialClinicoSWClient servicio;
            ServicioHistorialClinicoSW.historialClinico h;

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
            try
            {
                servicio.agregarHistorial(h);
                MessageBox.Show("Historial agregado correctamente");
            }catch(Exception ex)
            {
                MessageBox.Show("Error!!!" + ex);
            }
            limpiar();
        }

        private void butListarpacientes_Click(object sender, EventArgs e)
        {
            GUIListarPacientesHistorial guiListarP = new GUIListarPacientesHistorial(this);
            guiListarP.listar();
            guiListarP.ShowDialog();
            
        }

        private void butListarEmfermedades_Click(object sender, EventArgs e)
        {
            GUIListarEnfermedades guiListarE = new GUIListarEnfermedades(this);
            guiListarE.listar();
            guiListarE.ShowDialog();
        }

        public void limpiar()
        {
            txtNumeroHistorial.Text = "";
            txtNombreDoctor.Text = "";
            txtCodigoEnfermedad.Text = "";
            txtDocumentoPaciente.Text = "";
        }
    }
}
