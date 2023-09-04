using SuperHeroesApp.Models;

namespace SuperHeroesApp.Data
{
    class AntiHeroes
    {
        public async Task<List<AntiHeroe>> GetAntiHeroes()
        {
            await Task.Delay(1000);
            List<AntiHeroe> antiHeroes = new()
            {
                new AntiHeroe
                {
                    Id = 1,
                    Nombre = "Wolverine",
                    IdentidadSecreta = "Logan",
                    PuedeVolar = false,
                    SuperPoderes = new List<SuperPoder>()
                    {
                        new SuperPoder()
                        {
                            Nombre = "Regeneración",
                            Descripcion = "Poder de regeneracion",
                            Nivel = NivelPoder.Alto
                        },
                        new SuperPoder()
                        {
                            Nombre = "Super Fuerza",
                            Descripcion = "Fuerza impresionante",
                            Nivel = NivelPoder.Alto,
                        },
                    }
                }
            };

            return antiHeroes;
        }
    }
}