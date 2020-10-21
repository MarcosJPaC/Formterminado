using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comptelpan
{
    class Lgwebos : Pantallalg
    {
        protected int canalestiene;
        public int Canalestiene
        {
            get { return canalestiene; }
            set { canalestiene = value; }
        }
        protected int almacenamiento;
        public int Almacenamiento
        {
            get { return almacenamiento; }
            set { almacenamiento = value; }
        }

        public Lgwebos(): base()
        {
            canalestiene = 0;
        }
        public override string ToString()
        {
            return base.ToString() + "- Tiene: " + canalestiene + " Canales" + " - " + "Su almacenamiento es de " + almacenamiento + " Gb";
        }

    }
}
