namespace PRACTICAPREEXAMEN
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.addArticulo = new System.Windows.Forms.Button();
            this.finalizarCompra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(117, 20);
            this.textBox1.TabIndex = 0;
            // 
            // addArticulo
            // 
            this.addArticulo.Location = new System.Drawing.Point(12, 39);
            this.addArticulo.Name = "addArticulo";
            this.addArticulo.Size = new System.Drawing.Size(117, 40);
            this.addArticulo.TabIndex = 1;
            this.addArticulo.Text = "añadir articulo";
            this.addArticulo.UseVisualStyleBackColor = true;
            this.addArticulo.Click += new System.EventHandler(this.addArticulo_Click);
            // 
            // finalizarCompra
            // 
            this.finalizarCompra.Location = new System.Drawing.Point(12, 85);
            this.finalizarCompra.Name = "finalizarCompra";
            this.finalizarCompra.Size = new System.Drawing.Size(117, 40);
            this.finalizarCompra.TabIndex = 2;
            this.finalizarCompra.Text = "finalizar compra";
            this.finalizarCompra.UseVisualStyleBackColor = true;
            this.finalizarCompra.Click += new System.EventHandler(this.finalizarCompra_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.finalizarCompra);
            this.Controls.Add(this.addArticulo);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button addArticulo;
        private System.Windows.Forms.Button finalizarCompra;
    }
}

