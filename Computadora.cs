using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comptelpan
{
    class Computadora
    {

        //Variables
        protected string tamaño_pantalla;
        public string Tamaño_pantalla
        {
            get { return tamaño_pantalla; }
            set { tamaño_pantalla = value; }
        }
        protected string color;
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        protected bool touch;
        public bool Touch
        {
            get { return touch; }
            set { touch = value; }
        }


        //Constructor
        public Computadora()
        {
            tamaño_pantalla = " ";
            color = " ";
            touch = true;
        }
        //Metodos
        public override string ToString()
        {
            return "Tamaño de la pantalla: " + tamaño_pantalla + " - Color: " + color;
        }
    }
}
