using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class Ejercicio3 : Form
    {
        public Ejercicio3()
        {
            InitializeComponent();

            lblImagenEscogida.Text = "";

            this.openFileDialog.Title = "Selección de directorio para almacenar datos";
            this.openFileDialog.InitialDirectory = "G:\\2DAM\\MobileApps\\Dungeons Without Dragons\\Dungeons Without Dragons\\DungeonsWithoutDragons\android\assets";
            this.openFileDialog.Filter = "imagenes PNG (*.png) |*.png|imagenes JPG (*.jpg) |*.jpg|Todos los archivos (*.*) |*.*";
            this.openFileDialog.ValidateNames = true;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            reproductor.segundos ++;

            if (reproductor.segundos > 59)
            {
                reproductor_DesbordaTiempo(sender, e);
            }

            reproductor.lblTiempo.Text = reproductor.minutos.ToString("D2") + ":" + reproductor.segundos.ToString("D2");
        }


        private void reproductor_DesbordaTiempo(object sender, EventArgs e)
        {
            reproductor.segundos = 0;

            reproductor.minutos++;

            if (reproductor.minutos > 99)
            {
                reproductor.minutos = 0;
            }
        }


        private void reproductor_PulsaBoton(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
            }
            else
            {
                timer1.Start();
            }
        }

        private void btnEscogerArchivo_Click(object sender, EventArgs e)
        {
            this.openFileDialog.ShowDialog();
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            lblImagenEscogida.Text = "Imagen Escogida : " + openFileDialog.FileName.Split('\\')[openFileDialog.FileName.Split('\\').Length-1];
        }
    }
}
