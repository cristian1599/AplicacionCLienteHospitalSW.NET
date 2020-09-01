namespace ClienteHospitalSWNet.gui
{
    partial class GUIListarPorParametroHistorialClinico
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
            this.grilla = new System.Windows.Forms.DataGridView();
            this.butListar = new System.Windows.Forms.Button();
            this.txtNombreDoctor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).BeginInit();
            this.SuspendLayout();
            // 
            // grilla
            // 
            this.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla.Location = new System.Drawing.Point(11, 76);
            this.grilla.Margin = new System.Windows.Forms.Padding(4);
            this.grilla.Name = "grilla";
            this.grilla.RowHeadersWidth = 51;
            this.grilla.Size = new System.Drawing.Size(736, 295);
            this.grilla.TabIndex = 7;
            // 
            // butListar
            // 
            this.butListar.Location = new System.Drawing.Point(357, 8);
            this.butListar.Name = "butListar";
            this.butListar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.butListar.Size = new System.Drawing.Size(75, 23);
            this.butListar.TabIndex = 10;
            this.butListar.Text = "Listar";
            this.butListar.UseVisualStyleBackColor = true;
            this.butListar.Click += new System.EventHandler(this.butListar_Click);
            // 
            // txtNombreDoctor
            // 
            this.txtNombreDoctor.Location = new System.Drawing.Point(180, 9);
            this.txtNombreDoctor.Name = "txtNombreDoctor";
            this.txtNombreDoctor.Size = new System.Drawing.Size(147, 22);
            this.txtNombreDoctor.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre Del Medico:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // GUIListarPorParametroHistorialClinico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 376);
            this.Controls.Add(this.butListar);
            this.Controls.Add(this.txtNombreDoctor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grilla);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GUIListarPorParametroHistorialClinico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listar por Parametro Historial Clinico";
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grilla;
        private System.Windows.Forms.Button butListar;
        private System.Windows.Forms.TextBox txtNombreDoctor;
        private System.Windows.Forms.Label label1;
    }
}