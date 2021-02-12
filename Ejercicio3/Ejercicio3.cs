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
    }
}
