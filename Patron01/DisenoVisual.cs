namespace Patron01
{
    public class DisenoVisual
    {
        public string ColorPiel { get; set; }
        public string EstiloCabello { get; set; }

        public override string ToString()
        {
            return $"Color de Piel: {ColorPiel}, Estilo Cabello: {EstiloCabello}";
        }
    }
}
