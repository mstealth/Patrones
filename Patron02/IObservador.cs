namespace Patron02
{
    public interface IObservador
    {
        public int DispositivoId { get; }
        public int UsuarioId { get; }
        void Update(string mensaje);
    }
}
