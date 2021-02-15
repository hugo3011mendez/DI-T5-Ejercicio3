namespace Ejercicio3
{
    partial class Ejercicio3
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.reproductor = new NuevoComponente.Reproductor();
            this.btnEscogerArchivo = new System.Windows.Forms.Button();
            this.lblImagenEscogida = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // reproductor
            // 
            this.reproductor.BackColor = System.Drawing.Color.Transparent;
            this.reproductor.Location = new System.Drawing.Point(12, 32);
            this.reproductor.Name = "reproductor";
            this.reproductor.Size = new System.Drawing.Size(181, 170);
            this.reproductor.TabIndex = 0;
            // 
            // btnEscogerArchivo
            // 
            this.btnEscogerArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnEscogerArchivo.Location = new System.Drawing.Point(329, 12);
            this.btnEscogerArchivo.Name = "btnEscogerArchivo";
            this.btnEscogerArchivo.Size = new System.Drawing.Size(70, 44);
            this.btnEscogerArchivo.TabIndex = 1;
            this.btnEscogerArchivo.Text = "Escoger Imagen";
            this.btnEscogerArchivo.UseVisualStyleBackColor = true;
            this.btnEscogerArchivo.Click += new System.EventHandler(this.btnEscogerArchivo_Click);
            // 
            // lblImagenEscogida
            // 
            this.lblImagenEscogida.AutoSize = true;
            this.lblImagenEscogida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblImagenEscogida.Location = new System.Drawing.Point(12, 12);
            this.lblImagenEscogida.Name = "lblImagenEscogida";
            this.lblImagenEscogida.Size = new System.Drawing.Size(127, 17);
            this.lblImagenEscogida.TabIndex = 2;
            this.lblImagenEscogida.Text = "Imagen escogida : ";
            // 
            // Ejercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 249);
            this.Controls.Add(this.lblImagenEscogida);
            this.Controls.Add(this.btnEscogerArchivo);
            this.Controls.Add(this.reproductor);
            this.Name = "Ejercicio3";
            this.Text = "Ejercicio3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private NuevoComponente.Reproductor reproductor;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnEscogerArchivo;
        private System.Windows.Forms.Label lblImagenEscogida;
    }
}