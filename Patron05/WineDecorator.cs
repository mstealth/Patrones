using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron05
{
    public class WineDecorator : RoomDecorator
    {
        public WineDecorator(Room room) : base(room) { }

        public override string GetDescripcion()
        {
            return decoratedRoom.GetDescripcion() + ", con vino de alta calidad";
        }

        public override double GetCosto()
        {
            return decoratedRoom.GetCosto() + 30.00; // Costo adicional por vino de alta calidad
        }
    }
}
