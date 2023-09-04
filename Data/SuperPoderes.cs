using SuperHeroesApp.Models;

namespace SuperHeroesApp.Data
{
    class SuperPoderes
    {
        public List<SuperPoder> GetSuperPoderes()
        {
            List<SuperPoder> superPoderes = new()
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
                new SuperPoder()
                {
                    Nombre = "Regeneración",
                    Descripcion = "Poder de regeneracion",
                    Nivel = NivelPoder.Alto
                }
            };

            return superPoderes;
        }
    }
}