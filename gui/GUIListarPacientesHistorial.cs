using ClienteHospitalSWNet.model;
using ClienteHospitalSWNet.ServidorPacienteSW;
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
    public partial class GUIListarPacientesHistorial : Form
    {
        GUIAgregarHistorialClinico padre;
        public GUIListarPacientesHistorial(GUIAgregarHistorialClinico pPadre)
        {
            padre = pPadre;
            InitializeComponent();
        }

        private void grilla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void listar()
        {
            ServidorPacienteSW.PacienteSWClient servicio;

            ServidorPacienteSW.paciente p;
            DataTable dt = new DataTable();
            DataRow dr;

            servicio = ServicioLocalPaciente.getServicio();
            Object[] Object;
            p = new ServidorPacienteSW.paciente();
            dt.Columns.Add(new DataColumn("Documento"));
            dt.Columns.Add(new DataColumn("Nombre"));
            dt.Columns.Add(new DataColumn("Correo"));
            dt.Columns.Add(new DataColumn("Telefono"));
            dt.Columns.Add(new DataColumn("Genero"));

            try
            {

                // pacientes =(paciente[])servicio.listar();
                Object = servicio.listar();
                for (int i = 0; i < Object.Length; i++)
                {
                    p = (paciente)Object[i];
                    dr = dt.NewRow();
                    dr["Documento"] = p.documento;
                    dr["Nombre"] = p.nombre;
                    dr["Correo"] = p.correo;
                    dr["Telefono"] = p.telefono;
                    dr["Genero"] = p.genero;

                    dt.Rows.Add(dr);


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al listar Pacientes ! " + ex);
            }
            grilla.DataSource = dt;
        }

        private void GUIListarPacientesHistorial_Load(object sender, EventArgs e)
        {

        }

        private void grilla_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            

            String dato = grilla.CurrentRow.Cells[0].Value.ToString();
            padre.txtDocumentoPaciente.Text = dato;
            this.Dispose();

        }
    }
}
