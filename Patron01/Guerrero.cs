namespace Patron01
{
    public class Guerrero : Heroe
    {
        public string Espada { get; set; }
        public Guerrero()
        {
            TipoClase = "Guerrero";
        }

        public override Heroe Clone()
        {
            Guerrero clon = (Guerrero)this.MemberwiseClone();
            clon.Habilidades = new List<Habilidad>();

            foreach (var habilidad in Habilidades)
            {
                clon.Habilidades.Add(habilidad.Clone());
            }

            clon.Personalizacion = new DisenoVisual
            {
                ColorPiel = this.Personalizacion.ColorPiel,
                EstiloCabello = this.Personalizacion.EstiloCabello
            };

            return clon;
        }
    }
}
