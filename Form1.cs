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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncomputadora_Click(object sender, EventArgs e)
        {
            Computadora c;
            c = new Computadora();
            c.Tamaño_pantalla = "1020x720";
            c.Color = "Azul";
            MessageBox.Show(c.ToString());


            
        }

        private void btntouch_Click(object sender, EventArgs e)
        {
            Computadora c;
            c = new Computadora();
            if (c.Touch == true)
            {
                MessageBox.Show("Tiene pantalla touch");
            }
            else
                MessageBox.Show("No tiene pantala touch");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No tocar al perro, porfavor.");
            
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btntelefono_Click(object sender, EventArgs e)
        {
            Telefono t;
            t = new Telefono();
            t.Tamaño_pantalla = "161,3 x 75,8 x 9 mm";
            t.Color = "Blanco";
            t.Tipodeconexion = "Wifi";
            MessageBox.Show(t.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Telefono t;
            t = new Telefono();
            if (t.Ttouch == true)
            {
                MessageBox.Show("El telefono es Touch");
            }
            else
                MessageBox.Show("Este telefono no es touch");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Television t;
            t = new Television();
            t.Tamaño_pantalla = "161,3 x 75,8 x 9 mm";
            t.Color = "Blanco";
            t.Tipodeconexion = "Wifi";
            t.Canalestiene = 12;
            MessageBox.Show(t.ToString());
        }
    }
}
