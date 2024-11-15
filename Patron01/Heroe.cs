namespace Patron01
{
    public abstract class Heroe
    {
        public string Nombre { get; set; }
        public int Nivel { get; set; }
        public int Experiencia { get; set; }
        public List<Habilidad> Habilidades { get; set; }
        public string TipoClase { get; set; }
        public DisenoVisual Personalizacion { get; set; }

        public abstract Heroe Clone();

        public override string ToString()
        {
            return $"Nombre: {Nombre}, Tipo Clase: {TipoClase}, Nivel: {Nivel}, Experiencia: {Experiencia}, Diseño Visual: {Personalizacion}";
        }
    }
}
