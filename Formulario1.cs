using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comptelpan
{
    public partial class Formulario1 : Form
    {
        public Formulario1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pantallatv p;
            p = new Pantallatv();
            p.Tamaño_pantalla = "1080x720";
            p.Peso = 80;
            p.Touch = false;
            MessageBox.Show(p.ToString());
            if (p.Touch == true)
            {
                MessageBox.Show("Tiene pantalla touch.");

            }
            else
                MessageBox.Show("No tiene touch");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Formulario1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pantallalg p;
            p = new Pantallalg();
            p.Tamaño_pantalla = "1080x720";
            p.Tipodeconexion = "Ethernet";
            p.Peso = 80;
            p.Tipodeconexion = "1280x720";
            p.Touch = true;
            MessageBox.Show(p.ToString());
            if (p.Touch == true)
            {
                MessageBox.Show("Tiene pantalla touch.");

            }
            else
                MessageBox.Show("No tiene touch");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Lgwebos p;
            p = new Lgwebos();
            p.Tamaño_pantalla = "1920x1080";
            p.Tipodeconexion = "Wifi";
            p.Peso = 80;
            p.Touch = true;
            p.Canalestiene = 12;
            p.Almacenamiento = 40;
            MessageBox.Show(p.ToString());
            if (p.Touch == true)
            {
                MessageBox.Show("Tiene pantalla touch.");

            }
            else
                MessageBox.Show("No tiene pantalla touch");
        }
    }
    
    
}
