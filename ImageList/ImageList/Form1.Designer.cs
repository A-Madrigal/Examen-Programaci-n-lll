namespace ImageList
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imgFotos = new System.Windows.Forms.ImageList(this.components);
            this.lblFoto = new System.Windows.Forms.Label();
            this.btnCambio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // imgFotos
            // 
            this.imgFotos.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgFotos.ImageStream")));
            this.imgFotos.TransparentColor = System.Drawing.Color.Transparent;
            this.imgFotos.Images.SetKeyName(0, "pexels-ian-turnell-709552.jpg");
            this.imgFotos.Images.SetKeyName(1, "pexels-james-wheeler-1619317.jpg");
            this.imgFotos.Images.SetKeyName(2, "pexels-marlon-martinez-1450082.jpg");
            this.imgFotos.Images.SetKeyName(3, "pexels-nextvoyage-1476880.jpg");
            this.imgFotos.Images.SetKeyName(4, "pexels-pixabay-36717.jpg");
            this.imgFotos.Images.SetKeyName(5, "pexels-pixabay-206359.jpg");
            // 
            // lblFoto
            // 
            this.lblFoto.ImageIndex = 0;
            this.lblFoto.ImageList = this.imgFotos;
            this.lblFoto.Location = new System.Drawing.Point(50, 42);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(100, 100);
            this.lblFoto.TabIndex = 0;
            // 
            // btnCambio
            // 
            this.btnCambio.Location = new System.Drawing.Point(53, 166);
            this.btnCambio.Name = "btnCambio";
            this.btnCambio.Size = new System.Drawing.Size(93, 23);
            this.btnCambio.TabIndex = 1;
            this.btnCambio.Text = "Cambiar Imagen";
            this.btnCambio.UseVisualStyleBackColor = true;
            this.btnCambio.Click += new System.EventHandler(this.btnCambio_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 245);
            this.Controls.Add(this.btnCambio);
            this.Controls.Add(this.lblFoto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imgFotos;
        private System.Windows.Forms.Label lblFoto;
        private System.Windows.Forms.Button btnCambio;
    }
}

