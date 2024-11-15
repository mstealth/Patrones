namespace Patron01
{
    public class Mago : Heroe
    {
        public int Poder { get; set; }
        public Mago()
        {
            TipoClase = "Mago";
        }

        public override Heroe Clone()
        {
            Mago clon = (Mago)this.MemberwiseClone();
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
