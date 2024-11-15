using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron05
{
    public abstract class RoomDecorator : Room
    {
        protected Room decoratedRoom;

        public RoomDecorator(Room room)
        {
            this.decoratedRoom = room;
        }

        public override string GetDescripcion()
        {
            return decoratedRoom.GetDescripcion();
        }

        public override double GetCosto()
        {
            return decoratedRoom.GetCosto();
        }
    }
}
