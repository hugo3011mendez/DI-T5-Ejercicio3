namespace Ejercicio3
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
            this.reproductor1 = new NuevoComponente.Reproductor();
            this.SuspendLayout();
            // 
            // reproductor1
            // 
            this.reproductor1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.reproductor1.Location = new System.Drawing.Point(27, 12);
            this.reproductor1.Name = "reproductor1";
            this.reproductor1.Size = new System.Drawing.Size(521, 318);
            this.reproductor1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reproductor1);
            this.Name = "Form1";
            this.Text = "Ejercicio 3";
            this.ResumeLayout(false);

        }

        #endregion

        private NuevoComponente.Reproductor reproductor1;
    }
}

