using ClienteHospitalSWNet.model;
using ClienteHospitalSWNet.ServicioHistorialClinicoSW;
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
    public partial class GUIListarHistorialClinico : Form
    {
        public GUIListarHistorialClinico()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            ServicioHistorialClinicoSW.HistorialClinicoSWClient servicio;
            ServicioHistorialClinicoSW.historialClinico h;

            DataTable dt = new DataTable();
            DataRow dr;
            servicio = ServicioLocalHistorial.getServicio();
           
            Object[] Object;
            h = new ServicioHistorialClinicoSW.historialClinico();
            dt.Columns.Add(new DataColumn("numeroHistoria"));
            dt.Columns.Add(new DataColumn("nombreDoctor"));
            dt.Columns.Add(new DataColumn("fk_paciente"));
            dt.Columns.Add(new DataColumn("fk_enfermedad"));
            try
            {
                Object = servicio.listarHistorial();
                for (int i = 0; i < Object.Length; i++)
                {
                    h = (historialClinico)Object[i];
                    dr = dt.NewRow();
                    dr["numeroHistoria"] = h.numeroHistoria;
                    dr["nombreDoctor"] = h.nombreDoctor;
                    dr["fk_paciente"] = h.fk_paciente;
                    dr["fk_enfermedad"] = h.fk_enfermedad;
                    dt.Rows.Add(dr);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar Historiales Clinicos ! " + ex);
            }
            grilla.DataSource = dt;
        }
        public void limpiar()
        {
            DataTable dt = (DataTable)grilla.DataSource;
            dt.Clear();
        }
    }
}
