using SuperHeroesApp.Models;

namespace SuperHeroesApp.Data
{
    class Heroes
    {
        public async Task<List<SuperHeroe>> GetSuperHeroes()
        {
            await Task.Delay(1000);
            List<SuperHeroe> superHeroes = new()
            {
                new SuperHeroe
                {
                    Id = 1,
                    Nombre = "Superman",
                    IdentidadSecreta = "Clark kent",
                    Ciudad = "Metropolis",
                    PuedeVolar = true,
                    SuperPoderes = new List<SuperPoder>()
                    {
                        new SuperPoder()
                        {
                            Nombre = "Volar",
                            Descripcion = "Capacidad para volar y planear en el aire",
                            Nivel = NivelPoder.Medio
                        },
                        new SuperPoder()
                        {
                            Nombre = "Super Fuerza",
                            Descripcion = "Fuerza impresionante",
                            Nivel = NivelPoder.Alto,
                        },
                    }
                },
                new SuperHeroe
                {
                    Id = 2,
                    Nombre = "Batman",
                    IdentidadSecreta = "Bruce Wayne",
                    Ciudad = "Gotham city",
                    PuedeVolar = false,
                    SuperPoderes = new List<SuperPoder>()
                    {
                        new SuperPoder()
                        {
                            Nombre = "Habilidad Nocturna",
                            Descripcion = "Capacidad de combatir en la obscuridad",
                            Nivel = NivelPoder.Medio,
                        },
                        new SuperPoder()
                        {
                        Nombre = "Millonetas",
                        Descripcion = "Tener mucho dinero para comprar armamento, autos y naves para combatir",
                        Nivel = NivelPoder.Bajo
                        },
                    }
                }
            };
            return superHeroes;
        }
    }
}