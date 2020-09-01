namespace ClienteHospitalSWNet.gui
{
    partial class GUIAgregarHistorialClinico
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtCodigoEnfermedad = new System.Windows.Forms.TextBox();
            this.txtDocumentoPaciente = new System.Windows.Forms.TextBox();
            this.txtNombreDoctor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumeroHistorial = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.butListarpacientes = new System.Windows.Forms.Button();
            this.butListarEmfermedades = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(380, 206);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 28);
            this.btnSalir.TabIndex = 23;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtCodigoEnfermedad
            // 
            this.txtCodigoEnfermedad.Location = new System.Drawing.Point(215, 153);
            this.txtCodigoEnfermedad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodigoEnfermedad.Name = "txtCodigoEnfermedad";
            this.txtCodigoEnfermedad.Size = new System.Drawing.Size(264, 22);
            this.txtCodigoEnfermedad.TabIndex = 21;
            this.txtCodigoEnfermedad.TextChanged += new System.EventHandler(this.txtCodigoEnfermedad_TextChanged);
            // 
            // txtDocumentoPaciente
            // 
            this.txtDocumentoPaciente.Location = new System.Drawing.Point(215, 108);
            this.txtDocumentoPaciente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDocumentoPaciente.Name = "txtDocumentoPaciente";
            this.txtDocumentoPaciente.Size = new System.Drawing.Size(264, 22);
            this.txtDocumentoPaciente.TabIndex = 20;
            this.txtDocumentoPaciente.TextChanged += new System.EventHandler(this.txtDocumentoPaciente_TextChanged);
            // 
            // txtNombreDoctor
            // 
            this.txtNombreDoctor.Location = new System.Drawing.Point(215, 62);
            this.txtNombreDoctor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombreDoctor.Name = "txtNombreDoctor";
            this.txtNombreDoctor.Size = new System.Drawing.Size(264, 22);
            this.txtNombreDoctor.TabIndex = 19;
            this.txtNombreDoctor.TextChanged += new System.EventHandler(this.txtNombreDoctor_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 156);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Codigo de la Enfermedad";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Documento del Paciente";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nombre del Doctor";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Numero de Historial";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNumeroHistorial
            // 
            this.txtNumeroHistorial.Location = new System.Drawing.Point(215, 15);
            this.txtNumeroHistorial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumeroHistorial.Name = "txtNumeroHistorial";
            this.txtNumeroHistorial.Size = new System.Drawing.Size(264, 22);
            this.txtNumeroHistorial.TabIndex = 13;
            this.txtNumeroHistorial.TextChanged += new System.EventHandler(this.txtNumeroHistorial_TextChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(215, 206);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 28);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // butListarpacientes
            // 
            this.butListarpacientes.Location = new System.Drawing.Point(486, 108);
            this.butListarpacientes.Name = "butListarpacientes";
            this.butListarpacientes.Size = new System.Drawing.Size(48, 23);
            this.butListarpacientes.TabIndex = 24;
            this.butListarpacientes.Text = "...";
            this.butListarpacientes.UseVisualStyleBackColor = true;
            this.butListarpacientes.Click += new System.EventHandler(this.butListarpacientes_Click);
            // 
            // butListarEmfermedades
            // 
            this.butListarEmfermedades.Location = new System.Drawing.Point(486, 156);
            this.butListarEmfermedades.Name = "butListarEmfermedades";
            this.butListarEmfermedades.Size = new System.Drawing.Size(48, 23);
            this.butListarEmfermedades.TabIndex = 25;
            this.butListarEmfermedades.Text = "...";
            this.butListarEmfermedades.UseVisualStyleBackColor = true;
            this.butListarEmfermedades.Click += new System.EventHandler(this.butListarEmfermedades_Click);
            // 
            // GUIAgregarHistorialClinico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 249);
            this.Controls.Add(this.butListarEmfermedades);
            this.Controls.Add(this.butListarpacientes);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtCodigoEnfermedad);
            this.Controls.Add(this.txtDocumentoPaciente);
            this.Controls.Add(this.txtNombreDoctor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumeroHistorial);
            this.Controls.Add(this.btnAgregar);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GUIAgregarHistorialClinico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Historial Clinico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtNombreDoctor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumeroHistorial;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button butListarpacientes;
        private System.Windows.Forms.Button butListarEmfermedades;
        public System.Windows.Forms.TextBox txtCodigoEnfermedad;
        public System.Windows.Forms.TextBox txtDocumentoPaciente;
    }
}