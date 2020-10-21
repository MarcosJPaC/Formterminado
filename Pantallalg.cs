using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comptelpan
{
    class Pantallalg : Pantallatv
    {
        protected string tipodeconexion;
        public string Tipodeconexion
        {
            get { return tipodeconexion; }
            set { tipodeconexion = value; }
        }
        public Pantallalg(): base()
        {
            tipodeconexion = " ";
            
        }
        public override string ToString()
        {
            return base.ToString() + " - Tipo de conexion: " + tipodeconexion + " ";
        }



    }
}
