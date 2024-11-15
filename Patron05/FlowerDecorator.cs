using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron05
{
    internal class FlowerDecorator : RoomDecorator
    {
        public FlowerDecorator(Room room) : base(room) { }

        public override string GetDescripcion()
        {
            return decoratedRoom.GetDescripcion() + ", con flores frescas";
        }

        public override double GetCosto()
        {
            return decoratedRoom.GetCosto() + 20.00; // Costo adicional por flores frescas
        }
    }
}
