// Patrón Prototype
namespace Patron01
{
    public class Program
    {
        public static void Main()
        {
            // Crear un héroe guerrero
            Guerrero guerrero = new Guerrero
            {
                Nombre = "Aragorn",
                Nivel = 10,
                Experiencia = 1500,
                Habilidades = new List<Habilidad>
            {
                new Habilidad { Nombre = "Golpear", Daño = 25 },
                new Habilidad { Nombre = "Escudo", Daño = 0 }
            },
                Personalizacion = new DisenoVisual
                {
                    ColorPiel = "Blanco",
                    EstiloCabello = "Largo"
                }
            };

            // Clonar el héroe guerrero y personalizar
            Heroe guerreroClon = guerrero.Clone();
            guerreroClon.Nombre = "Boromir";
            guerreroClon.Personalizacion.ColorPiel = "Mestizo";

            // Mostrar el héroe original y el clon
            Console.WriteLine("Heroe Original: " + guerrero);
            Console.WriteLine("Heroe Clonado: " + guerreroClon);
        }
    }
}