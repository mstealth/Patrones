namespace Patron01
{
    public class Habilidad
    {
        public required string Nombre { get; set; }
        public int Daño { get; set; }

        public Habilidad Clone()
        {
            return (Habilidad)this.MemberwiseClone();
        }

        public override string ToString()
        {
            return $"{Nombre} (Daño: {Daño})";
        }
    }
}
