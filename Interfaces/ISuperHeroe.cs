using SuperHeroesApp.Models;

namespace SuperHeroesApp.Interfaces
{
    interface ISuperHeroe
    {
        int Id { get; set; }
        string Nombre { get; set; }
        string IdentidadSecreta { get; set; }
        void SuperHeroeInfo(SuperHeroe heroe);
    }
}