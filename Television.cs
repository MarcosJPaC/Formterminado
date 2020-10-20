using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comptelpan
{
    class Television : Telefono
    {
        protected int canalestiene;
        public int Canalestiene
        {
            get { return canalestiene; }
            set { canalestiene = value; }
        }
        public Television(): base()
        {
            canalestiene = 0;
        }
        public override string ToString()
        {
            return base.ToString() + "- Tiene: " + canalestiene + " Canales" + " ";
        }

    }
}
