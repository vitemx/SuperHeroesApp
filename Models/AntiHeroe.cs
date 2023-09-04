namespace SuperHeroesApp.Models
{
    internal class AntiHeroe : SuperHeroe
    {
        public string RealizarAccionDeAntiHeroe(string accion)
        {
            return $"El antiHeroe {NombreEIdentidadSecreta} Ha realizado: {accion}";
        }
    }
}