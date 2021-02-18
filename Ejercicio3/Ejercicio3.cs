using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace Ejercicio3
{
    public partial class Ejercicio3 : Form
    {
        List<Image> imagenesSeleccionadas = new List<Image>(); // Creo una colección para guardar las imágenes de la carpeta seleccionada
        int contadorVisualizacionImagenes = 0; // Creo un contador para gestionar el orden de visualización de las imágenes de la carpeta seleccionada

        public Ejercicio3()
        {
            InitializeComponent();

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            reproductor.Segundos = reproductor.Segundos +1;

            try
            {
                // Cada vez que el timer hace el evento Tick (cada segundo), se cambia la imagen que se visualiza por la siguiente de la carpeta
                pictureBox.BackgroundImage = imagenesSeleccionadas[contadorVisualizacionImagenes];
                contadorVisualizacionImagenes++;


                // Si se está mostrando la última imagen en la carpeta, el contador de visualización vuelve a 0 para volver a mostrar la primera imagen
                if (contadorVisualizacionImagenes > imagenesSeleccionadas.Count - 1)
                {
                    contadorVisualizacionImagenes = 0;
                }
            }
            catch (ArgumentException){}
        }


        // En el evento DesbordaTiempo actualizo los minutos y los segundos cuando éstos llegan a más de 60;
        private void reproductor_DesbordaTiempo(object sender, EventArgs e)
        {
            reproductor.Minutos = reproductor.Minutos +1;
        }


        // Evento que se lanza cuando se pulsa el botón de reproducir en el reproductor
        private void reproductor_PulsaBoton(object sender, EventArgs e)
        {
            try
            {
                imagenesSeleccionadas.Clear(); // Limpio la colección de imágenes cuando se pulsa el botón play/pausa
                DirectoryInfo di = new DirectoryInfo(folderBrowserDialog.SelectedPath); // Creo una variable que guarda la info de la carpeta seleccionada en el folderBrowserDialog
                // Recorro los archivos de la carpeta
                for (int i = 0; i < di.GetFiles().Length; i++)
                {
                    // Si el archivo tiene una extensión de imagen, se guarda en la colección de imágenes contenidas en la carpeta seleccionada
                    if (di.GetFiles()[i].Name.EndsWith(".png") || di.GetFiles()[i].Name.EndsWith(".jpg") || di.GetFiles()[i].Name.EndsWith(".jpeg"))
                    {
                        try
                        {
                            imagenesSeleccionadas.Add(new Bitmap(Image.FromFile(di.GetFiles()[i].FullName)));
                        }
                        catch (OutOfMemoryException)
                        {
                            Console.WriteLine("Se ha encontrado una imagen corrupta en la carpeta");
                        }
                    }
                }            
            }
            catch (ArgumentException)
            {
                if (reproductor.EstaEnPlay)
                {
                    MessageBox.Show("Debes especificar una carpeta que tenga imágenes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Compruebo si el timer está en marcha o en pausa, para pararlo o iniciarlo según corresponda
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
            if (!reproductor.EstaEnPlay) // Si el contador está corriendo, lo paro
            {
                reproductor.btnPlayPausa_Click(sender, EventArgs.Empty);
            }

            this.folderBrowserDialog.ShowDialog();
        }
    }
}
