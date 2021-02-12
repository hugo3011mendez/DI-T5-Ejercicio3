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
        bool estaEnPlay = true;

        public Reproductor()
        {
            InitializeComponent();

            lblTiempo.Text = "";
        }


        [Category("Tiempo")]
        [Description("Se lanza cuando segundos supere 59")]
        public event EventHandler DesbordaTiempo;


        [Category("Tiempo")]
        [Description("Se lanza cuando se pulsa el botón de play/pausa")]
        public event EventHandler PulsaBoton;


        private void btnPlayPausa_Click(object sender, EventArgs e)
        {
            PulsaBoton?.Invoke(this, EventArgs.Empty);


            if (estaEnPlay)
            {
                btnPlayPausa.BackgroundImage = Properties.Resources.Pause;
            }
            else
            {
                btnPlayPausa.BackgroundImage = Properties.Resources.Play;
            }

            estaEnPlay = !estaEnPlay;
        }
    }
}
