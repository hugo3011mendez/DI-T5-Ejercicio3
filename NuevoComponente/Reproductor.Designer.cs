﻿namespace NuevoComponente
{
    partial class Reproductor
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reproductor));
            this.btnPlayPausa = new System.Windows.Forms.Button();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnPlayPausa
            // 
            this.btnPlayPausa.BackColor = System.Drawing.SystemColors.Control;
            this.btnPlayPausa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPlayPausa.BackgroundImage")));
            this.btnPlayPausa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlayPausa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayPausa.Location = new System.Drawing.Point(58, 109);
            this.btnPlayPausa.Name = "btnPlayPausa";
            this.btnPlayPausa.Size = new System.Drawing.Size(60, 48);
            this.btnPlayPausa.TabIndex = 0;
            this.btnPlayPausa.UseVisualStyleBackColor = false;
            this.btnPlayPausa.Click += new System.EventHandler(this.btnPlayPausa_Click);
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo.Location = new System.Drawing.Point(43, 69);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(89, 25);
            this.lblTiempo.TabIndex = 1;
            this.lblTiempo.Text = "Tiempo";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Reproductor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.btnPlayPausa);
            this.Name = "Reproductor";
            this.Size = new System.Drawing.Size(181, 170);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlayPausa;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Timer timer1;
    }
}