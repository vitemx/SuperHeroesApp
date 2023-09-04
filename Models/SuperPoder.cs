namespace SuperHeroesApp.Models
{
    public class SuperPoder
    {
        public string? Nombre;
        public string? Descripcion;
        public NivelPoder Nivel;

        public SuperPoder()
        {
            Nombre = "SuperPoder";
            Descripcion = "";
            Nivel = NivelPoder.Bajo;
        }
    }
}