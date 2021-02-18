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
        // Variables enteros que representan los minutos y segundos que se mostraráne n la etiqueta tiempo
        private int minutos;
        private int segundos;


        [Category("Tiempo")]
        [Description("Indica el tiempo transcurrido referente a los segundos")]
        public int Segundos
        {
            // Si los segundos son mayores de 59, su valor se establece como el resto de su división entre 60 y se llama al evento DesbordaTiempo
            set
            {
                segundos = value;

                if (segundos > 59)
                {
                    segundos = segundos % 60;
                    DesbordaTiempo?.Invoke(this, EventArgs.Empty);
                }

                // Actualizamos la etiqueta
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
            // Si los minutos indicados son mayores de 99, su valor se establece a 0
            set
            {
                minutos = value;

                if (minutos > 99)
                {
                    minutos = 0;
                }

                // Y se actualiza la etiqueta
                lblTiempo.Text = Minutos.ToString("D2") + ":" + Segundos.ToString("D2");
            }

            get
            {
                return minutos;
            }
        }


        // Booleana que es usada para controlar si el botón está en play o pause
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

            lblTiempo.Text = ""; // En el constuctor limpiamos el texto de la etiqueta
        }


        // Evento propio creado que se ejecuta cuando los segundos superen 59
        [Category("Tiempo")]
        [Description("Se lanza cuando segundos supere 59")]
        public event EventHandler DesbordaTiempo;


        // Evento propio creado que se lanza cuando el botón play/pausa se clicke
        [Category("Reproducción")]
        [Description("Se lanza cuando se pulsa el botón de play/pausa")]
        public event EventHandler PulsaBoton;


        // Evento Click del botón Play/Pausa
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
