namespace Patron02
{
    public class MessageService
    {
        private List<IObservador> dispositivos = new List<IObservador>();

        public void Attach(IObservador dispositivo)
        {
            dispositivos.Add(dispositivo);
            Console.WriteLine($"Dispositivo {dispositivo.DispositivoId} agregado.");
        }

        public void Detach(IObservador dispositivo)
        {
            dispositivos.Remove(dispositivo);
            Console.WriteLine($"Dispositivo {dispositivo.DispositivoId} removido.");
        }

        public void Notify(string mensaje)
        {
            foreach (var dispositivo in dispositivos)
            {
                dispositivo.Update(mensaje);
            }
        }

        public void SendMessage(string mensaje)
        {
            Console.WriteLine("Nuevo mensaje: " + mensaje);
            Notify(mensaje);
        }
    }
}
