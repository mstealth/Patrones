namespace Patron02
{
    public class Telefono : IObservador
    {
        public int DispositivoId { get; }
        public int UsuarioId { get; }

        public Telefono(int deviceId, int userId)
        {
            DispositivoId = deviceId;
            UsuarioId = userId;
        }

        public void Update(string mensaje)
        {
            Console.WriteLine($"Usuario {UsuarioId} - Dispositivo Telefono_{DispositivoId} - recibió el mensaje: {mensaje}");
        }

    }
}
