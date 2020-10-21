using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comptelpan
{
    class Pantallatv
    {

        //Variables
        protected string tamaño_pantalla;
        public string Tamaño_pantalla
        {
            get { return tamaño_pantalla; }
            set { tamaño_pantalla = value; }
        }
        protected int peso;
        public int Peso
        {
            get { return peso; }
            set { peso = value; }
        }
        protected bool touch;
        public bool Touch
        {
            get { return touch; }
            set { touch = value; }
        }


        //Constructor
        public Pantallatv()
        {
            tamaño_pantalla = " ";
            peso = 0;
            touch = true;
        }
        //Metodos
        public override string ToString()
        {
            return "Tamaño de la pantalla: " + tamaño_pantalla + " - Peso: " + peso + " Kg";
        }
    }
}
