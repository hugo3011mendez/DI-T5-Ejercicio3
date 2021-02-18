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
        private int minutos;
        private int segundos;

        [Category("Tiempo")]
        [Description("Indica el tiempo transcurrido referente a los segundos")]
        public int Segundos
        {
            set
            {
                segundos = value;

                if (segundos > 59)
                {
                    segundos = segundos % 60;
                    DesbordaTiempo?.Invoke(this, EventArgs.Empty);
                }

                lblTiempo.Text = Minutos.ToString("D2") + ":" + Segundos.ToString("D2");
            }

            get
            {
                return segundos;
            }
        }



        [Category("Tiempo")]
        [Description("Indica el tiempo transcurrido referente a los minutos")]
        public int Minutos
        {
            set
            {
                minutos = value;

                if (minutos > 99)
                {
                    minutos = 0;
                }

                lblTiempo.Text = Minutos.ToString("D2") + ":" + Segundos.ToString("D2");
            }

            get
            {
                return minutos;
            }
        }



        private bool estaEnPlay = true;
        public bool EstaEnPlay
        {
            set
            {
                estaEnPlay = value;
            }

            get
            {
                return estaEnPlay;
            }
        }


        public Reproductor()
        {
            InitializeComponent();

            lblTiempo.Text = "";
        }


        [Category("Tiempo")]
        [Description("Se lanza cuando segundos supere 59")]
        public event EventHandler DesbordaTiempo;


        [Category("Reproducción")]
        [Description("Se lanza cuando se pulsa el botón de play/pausa")]
        public event EventHandler PulsaBoton;


        public void btnPlayPausa_Click(object sender, EventArgs e)
        {

            PulsaBoton?.Invoke(this, EventArgs.Empty);

            if (EstaEnPlay)
            {
                btnPlayPausa.BackgroundImage = Properties.Resources.Pause;
            }
            else
            {
                btnPlayPausa.BackgroundImage = Properties.Resources.Play;
            }

            EstaEnPlay = !EstaEnPlay;
        }
    }
}
