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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ejercicio3));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnEscogerArchivo = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.reproductor = new NuevoComponente.Reproductor();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnEscogerArchivo
            // 
            this.btnEscogerArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnEscogerArchivo.Location = new System.Drawing.Point(329, 12);
            this.btnEscogerArchivo.Name = "btnEscogerArchivo";
            this.btnEscogerArchivo.Size = new System.Drawing.Size(77, 44);
            this.btnEscogerArchivo.TabIndex = 1;
            this.btnEscogerArchivo.Text = "Escoger Directorio";
            this.btnEscogerArchivo.UseVisualStyleBackColor = true;
            this.btnEscogerArchivo.Click += new System.EventHandler(this.btnEscogerArchivo_Click);
            // 
            // reproductor
            // 
            this.reproductor.BackColor = System.Drawing.Color.Transparent;
            this.reproductor.EstaEnPlay = true;
            this.reproductor.Location = new System.Drawing.Point(12, 62);
            this.reproductor.Minutos = 0;
            this.reproductor.Name = "reproductor";
            this.reproductor.Segundos = 20;
            this.reproductor.Size = new System.Drawing.Size(97, 95);
            this.reproductor.TabIndex = 3;
            this.reproductor.DesbordaTiempo += new System.EventHandler(this.reproductor_DesbordaTiempo);
            this.reproductor.PulsaBoton += new System.EventHandler(this.reproductor_PulsaBoton);
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox.Location = new System.Drawing.Point(139, 62);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(344, 175);
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // Ejercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 249);
            this.Controls.Add(this.reproductor);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.btnEscogerArchivo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ejercicio3";
            this.Text = "Ejercicio3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnEscogerArchivo;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.PictureBox pictureBox;
        private NuevoComponente.Reproductor reproductor;
    }
}