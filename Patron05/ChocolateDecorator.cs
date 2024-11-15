using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron05
{
    public class ChocolateDecorator : RoomDecorator
    {
        public ChocolateDecorator(Room room) : base(room) { }

        public override string GetDescripcion()
        {
            return decoratedRoom.GetDescripcion() + ", con chocolate gourmet";
        }

        public override double GetCosto()
        {
            return decoratedRoom.GetCosto() + 15.00; // Costo adicional por chocolate gourmet
        }
    }
}
