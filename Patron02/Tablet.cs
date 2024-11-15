using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron02
{
    internal class Tablet : IObservador
    {
        public int DispositivoId { get; }

        public int UsuarioId { get; }


        public Tablet(int deviceId, int userId)
        {
            DispositivoId = deviceId;
            UsuarioId = userId;
        }

        public void Update(string mensaje)
        {
            Console.WriteLine($"Usuario {UsuarioId} - Dispositivo Tablet_{DispositivoId} - recibió el mensaje: {mensaje}");
        }
    }
}
