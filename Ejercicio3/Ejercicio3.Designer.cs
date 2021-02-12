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
            this.reproductor1 = new NuevoComponente.Reproductor();
            this.SuspendLayout();
            // 
            // reproductor1
            // 
            this.reproductor1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.reproductor1.Location = new System.Drawing.Point(61, 48);
            this.reproductor1.Name = "reproductor1";
            this.reproductor1.Size = new System.Drawing.Size(181, 170);
            this.reproductor1.TabIndex = 0;
            // 
            // Ejercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reproductor1);
            this.Name = "Ejercicio3";
            this.Text = "Ejercicio3";
            this.ResumeLayout(false);

        }

        #endregion

        private NuevoComponente.Reproductor reproductor1;
    }
}