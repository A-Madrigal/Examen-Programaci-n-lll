namespace StatusStrip
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.stsInformacion = new System.Windows.Forms.StatusStrip();
            this.slblCoordenadas = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.stsInformacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // stsInformacion
            // 
            this.stsInformacion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slblCoordenadas,
            this.toolStripStatusLabel2});
            this.stsInformacion.Location = new System.Drawing.Point(0, 250);
            this.stsInformacion.Name = "stsInformacion";
            this.stsInformacion.Size = new System.Drawing.Size(325, 22);
            this.stsInformacion.TabIndex = 0;
            this.stsInformacion.Text = "statusStrip1";
            // 
            // slblCoordenadas
            // 
            this.slblCoordenadas.Name = "slblCoordenadas";
            this.slblCoordenadas.Size = new System.Drawing.Size(77, 17);
            this.slblCoordenadas.Text = "Coordenadas";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 272);
            this.Controls.Add(this.stsInformacion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.stsInformacion.ResumeLayout(false);
            this.stsInformacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip stsInformacion;
        private System.Windows.Forms.ToolStripStatusLabel slblCoordenadas;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
    }
}

