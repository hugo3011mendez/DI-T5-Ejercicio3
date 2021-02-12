using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace NuevoComponente
{
    public partial class Reproductor : UserControl
    {
        public int minutos = 0, segundos = 0;


        public Reproductor()
        {
            InitializeComponent();

            lblTiempo.Text = "";
        }


        // Este evento se lanza 
        [Category("Tiempo")]
        [Description("Se lanza cuando segundos supere 59")]
        public event EventHandler DesbordaTiempo;
        


        private void timer1_Tick(object sender, EventArgs e)
        {
            segundos++;

            if (segundos > 59)
            {
                DesbordaTiempo?.Invoke(this, EventArgs.Empty); // Lanzo el evento DesbordaTiempo

                segundos = 0;
                minutos++;

                if (minutos > 99)
                {
                    minutos = 0;
                }
            }

            lblTiempo.Text = minutos.ToString("D2") + ":" + segundos.ToString("D2");
        }


        private void btnPlayPausa_Click(object sender, EventArgs e)
        {
            if (btnPlayPausa.Image == Properties.Resources.Play)
            {
                btnPlayPausa.Image = Properties.Resources.Pause;
            }
            else
            {
                btnPlayPausa.Image = Properties.Resources.Play;
            }
        }
    }
}
