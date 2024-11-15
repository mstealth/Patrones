using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron05
{
    public class BasicRoom : Room
    {
        public override double GetCosto()
        {
            return 100.00; // Costo base de la habitación
        }

        public override string GetDescripcion()
        {
            return "Habitación básica";
        }
    }
}
