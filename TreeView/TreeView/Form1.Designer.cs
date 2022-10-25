namespace TreeView
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.txtNodo = new System.Windows.Forms.TextBox();
            this.btnAdicionaNodo = new System.Windows.Forms.Button();
            this.txtElemento = new System.Windows.Forms.TextBox();
            this.btnAdicionaElemento = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEliminaNodo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(185, 270);
            this.treeView1.TabIndex = 0;
            // 
            // txtNodo
            // 
            this.txtNodo.Location = new System.Drawing.Point(225, 12);
            this.txtNodo.Name = "txtNodo";
            this.txtNodo.Size = new System.Drawing.Size(108, 20);
            this.txtNodo.TabIndex = 1;
            // 
            // btnAdicionaNodo
            // 
            this.btnAdicionaNodo.Location = new System.Drawing.Point(339, 12);
            this.btnAdicionaNodo.Name = "btnAdicionaNodo";
            this.btnAdicionaNodo.Size = new System.Drawing.Size(111, 20);
            this.btnAdicionaNodo.TabIndex = 2;
            this.btnAdicionaNodo.Text = "Adiciona Nodo";
            this.btnAdicionaNodo.UseVisualStyleBackColor = true;
            this.btnAdicionaNodo.Click += new System.EventHandler(this.btnAdicionaNodo_Click);
            // 
            // txtElemento
            // 
            this.txtElemento.Location = new System.Drawing.Point(226, 46);
            this.txtElemento.Name = "txtElemento";
            this.txtElemento.Size = new System.Drawing.Size(106, 20);
            this.txtElemento.TabIndex = 3;
            // 
            // btnAdicionaElemento
            // 
            this.btnAdicionaElemento.Location = new System.Drawing.Point(338, 46);
            this.btnAdicionaElemento.Name = "btnAdicionaElemento";
            this.btnAdicionaElemento.Size = new System.Drawing.Size(112, 20);
            this.btnAdicionaElemento.TabIndex = 4;
            this.btnAdicionaElemento.Text = "Adiciona Elemento";
            this.btnAdicionaElemento.UseVisualStyleBackColor = true;
            this.btnAdicionaElemento.Click += new System.EventHandler(this.btnAdicionaElemento_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(339, 81);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(111, 21);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpia Arbol";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEliminaNodo
            // 
            this.btnEliminaNodo.Location = new System.Drawing.Point(339, 117);
            this.btnEliminaNodo.Name = "btnEliminaNodo";
            this.btnEliminaNodo.Size = new System.Drawing.Size(111, 20);
            this.btnEliminaNodo.TabIndex = 6;
            this.btnEliminaNodo.Text = "Elimina Nodo";
            this.btnEliminaNodo.UseVisualStyleBackColor = true;
            this.btnEliminaNodo.Click += new System.EventHandler(this.btnEliminaNodo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 450);
            this.Controls.Add(this.btnEliminaNodo);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAdicionaElemento);
            this.Controls.Add(this.txtElemento);
            this.Controls.Add(this.btnAdicionaNodo);
            this.Controls.Add(this.txtNodo);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TextBox txtNodo;
        private System.Windows.Forms.Button btnAdicionaNodo;
        private System.Windows.Forms.TextBox txtElemento;
        private System.Windows.Forms.Button btnAdicionaElemento;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminaNodo;
    }
}

