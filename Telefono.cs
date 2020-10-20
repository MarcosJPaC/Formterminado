using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comptelpan
{
    class Telefono : Computadora
    {
        protected string tipodeconexion;
        public string Tipodeconexion
        {
            get { return tipodeconexion; }
            set { tipodeconexion = value; }
        }
        protected bool ttouch;
        
        public bool Ttouch
        {
            get { return ttouch; }
            set { ttouch = value; }
        }

        public Telefono(): base()
        {
            tipodeconexion = " ";
            ttouch = true;
        }
        public override string ToString()
        {
            return base.ToString() + " - Tipo de conexion: " + tipodeconexion + " ";
        }



    }
}
