using ClienteHospitalSWNet.ServicioEnfermedadSW;
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
    public partial class GUIListarEnfermedades : Form
    {
        GUIAgregarHistorialClinico padre;
        public GUIListarEnfermedades(GUIAgregarHistorialClinico pPadre)
        {
            InitializeComponent();
            padre = pPadre;
        }

        private void GUIListarEnfermedades_Load(object sender, EventArgs e)
        {

        }

        public void listar()
        {

           
            ServicioEnfermedadSW.ServicioEnfermedadSWClient servicio;
            ServicioEnfermedadSW.enfermedad e;

            DataTable dt = new DataTable();
            DataRow dr;
           

            Object[] Object;
            servicio = new ServicioEnfermedadSW.ServicioEnfermedadSWClient();
            e = new ServicioEnfermedadSW.enfermedad();
            dt.Columns.Add(new DataColumn("Codigo"));
            dt.Columns.Add(new DataColumn("Nombre"));
            dt.Columns.Add(new DataColumn("Tipo"));
            
            try
            {
                Object = servicio.listarEnfermedades();
                for (int i = 0; i < Object.Length; i++)
                {
                    e = (enfermedad)Object[i];
                    dr = dt.NewRow();
                    dr["Codigo"] = e.codigo;
                    dr["Nombre"] = e.nombre;
                    dr["Tipo"] = e.tipo;
                   
                    dt.Rows.Add(dr);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar Enfermedades ! " + ex);
            }
            grilla.DataSource = dt;

        }


        private void grilla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GUIListarEnfermedades_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void grilla_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            String dato = grilla.CurrentRow.Cells[0].Value.ToString();
            padre.txtCodigoEnfermedad.Text = dato;
            this.Dispose();
        }
    }
}
