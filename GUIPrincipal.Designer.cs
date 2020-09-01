namespace ClienteHospitalSWNet.gui
{
    partial class GUIPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarPacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarPacientesPorParametroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarPacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarPacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialClinicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarHistorialClinicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarHistoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarPorParametroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarHistorialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarHistorialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarHistorialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.pacienteToolStripMenuItem,
            this.historialClinicoToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(589, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.menuToolStripMenuItem.Text = "Archivo";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // pacienteToolStripMenuItem
            // 
            this.pacienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarPacienteToolStripMenuItem,
            this.listarPacientesToolStripMenuItem,
            this.listarPacientesPorParametroToolStripMenuItem,
            this.buscarPacienteToolStripMenuItem,
            this.modificarPacientesToolStripMenuItem,
            this.eliminarPacientesToolStripMenuItem});
            this.pacienteToolStripMenuItem.Name = "pacienteToolStripMenuItem";
            this.pacienteToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.pacienteToolStripMenuItem.Text = "Paciente";
            // 
            // agregarPacienteToolStripMenuItem
            // 
            this.agregarPacienteToolStripMenuItem.Name = "agregarPacienteToolStripMenuItem";
            this.agregarPacienteToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.agregarPacienteToolStripMenuItem.Text = "Agregar Paciente";
            this.agregarPacienteToolStripMenuItem.Click += new System.EventHandler(this.agregarPacienteToolStripMenuItem_Click);
            // 
            // listarPacientesToolStripMenuItem
            // 
            this.listarPacientesToolStripMenuItem.Name = "listarPacientesToolStripMenuItem";
            this.listarPacientesToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.listarPacientesToolStripMenuItem.Text = "Listar Pacientes";
            this.listarPacientesToolStripMenuItem.Click += new System.EventHandler(this.listarPacientesToolStripMenuItem_Click);
            // 
            // listarPacientesPorParametroToolStripMenuItem
            // 
            this.listarPacientesPorParametroToolStripMenuItem.Name = "listarPacientesPorParametroToolStripMenuItem";
            this.listarPacientesPorParametroToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.listarPacientesPorParametroToolStripMenuItem.Text = "Listar Pacientes por Parametro";
            this.listarPacientesPorParametroToolStripMenuItem.Click += new System.EventHandler(this.listarPacientesPorParametroToolStripMenuItem_Click);
            // 
            // buscarPacienteToolStripMenuItem
            // 
            this.buscarPacienteToolStripMenuItem.Name = "buscarPacienteToolStripMenuItem";
            this.buscarPacienteToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.buscarPacienteToolStripMenuItem.Text = "Buscar Paciente";
            this.buscarPacienteToolStripMenuItem.Click += new System.EventHandler(this.buscarPacienteToolStripMenuItem_Click);
            // 
            // modificarPacientesToolStripMenuItem
            // 
            this.modificarPacientesToolStripMenuItem.Name = "modificarPacientesToolStripMenuItem";
            this.modificarPacientesToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.modificarPacientesToolStripMenuItem.Text = "Modificar Paciente";
            this.modificarPacientesToolStripMenuItem.Click += new System.EventHandler(this.modificarPacientesToolStripMenuItem_Click);
            // 
            // eliminarPacientesToolStripMenuItem
            // 
            this.eliminarPacientesToolStripMenuItem.Name = "eliminarPacientesToolStripMenuItem";
            this.eliminarPacientesToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.eliminarPacientesToolStripMenuItem.Text = "Eliminar Paciente";
            this.eliminarPacientesToolStripMenuItem.Click += new System.EventHandler(this.eliminarPacientesToolStripMenuItem_Click);
            // 
            // historialClinicoToolStripMenuItem
            // 
            this.historialClinicoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarHistorialClinicoToolStripMenuItem,
            this.listarHistoriaToolStripMenuItem,
            this.listarPorParametroToolStripMenuItem,
            this.buscarHistorialToolStripMenuItem,
            this.eliminarHistorialToolStripMenuItem,
            this.modificarHistorialToolStripMenuItem});
            this.historialClinicoToolStripMenuItem.Name = "historialClinicoToolStripMenuItem";
            this.historialClinicoToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.historialClinicoToolStripMenuItem.Text = "Historial Clinico";
            // 
            // agregarHistorialClinicoToolStripMenuItem
            // 
            this.agregarHistorialClinicoToolStripMenuItem.Name = "agregarHistorialClinicoToolStripMenuItem";
            this.agregarHistorialClinicoToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.agregarHistorialClinicoToolStripMenuItem.Text = "Agregar Historial Clinico";
            this.agregarHistorialClinicoToolStripMenuItem.Click += new System.EventHandler(this.agregarHistorialClinicoToolStripMenuItem_Click);
            // 
            // listarHistoriaToolStripMenuItem
            // 
            this.listarHistoriaToolStripMenuItem.Name = "listarHistoriaToolStripMenuItem";
            this.listarHistoriaToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.listarHistoriaToolStripMenuItem.Text = "Listar Historias Clinicas";
            this.listarHistoriaToolStripMenuItem.Click += new System.EventHandler(this.listarHistoriaToolStripMenuItem_Click);
            // 
            // listarPorParametroToolStripMenuItem
            // 
            this.listarPorParametroToolStripMenuItem.Name = "listarPorParametroToolStripMenuItem";
            this.listarPorParametroToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.listarPorParametroToolStripMenuItem.Text = "Listar por Parametro";
            this.listarPorParametroToolStripMenuItem.Click += new System.EventHandler(this.listarPorParametroToolStripMenuItem_Click);
            // 
            // buscarHistorialToolStripMenuItem
            // 
            this.buscarHistorialToolStripMenuItem.Name = "buscarHistorialToolStripMenuItem";
            this.buscarHistorialToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.buscarHistorialToolStripMenuItem.Text = "Buscar Historial";
            this.buscarHistorialToolStripMenuItem.Click += new System.EventHandler(this.buscarHistorialToolStripMenuItem_Click);
            // 
            // eliminarHistorialToolStripMenuItem
            // 
            this.eliminarHistorialToolStripMenuItem.Name = "eliminarHistorialToolStripMenuItem";
            this.eliminarHistorialToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.eliminarHistorialToolStripMenuItem.Text = "Eliminar Historial";
            this.eliminarHistorialToolStripMenuItem.Click += new System.EventHandler(this.eliminarHistorialToolStripMenuItem_Click);
            // 
            // modificarHistorialToolStripMenuItem
            // 
            this.modificarHistorialToolStripMenuItem.Name = "modificarHistorialToolStripMenuItem";
            this.modificarHistorialToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.modificarHistorialToolStripMenuItem.Text = "Modificar Historial";
            this.modificarHistorialToolStripMenuItem.Click += new System.EventHandler(this.modificarHistorialToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ClienteHospitalSWNet.Properties.Resources.WhatsApp_Image_2020_08_28_at_2_07_04_AM;
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(589, 324);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // GUIPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 351);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GUIPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Hospital";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarPacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarPacientesPorParametroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarPacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarPacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialClinicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarHistorialClinicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarHistoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarPorParametroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarHistorialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarHistorialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarHistorialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}