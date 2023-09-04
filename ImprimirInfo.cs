using SuperHeroesApp.Interfaces;
using System;

namespace SuperHeroesApp
{
    class ImprimirInfo
    {
        public void ImprimirHeroe(ISuperHeroe superHeroe)
        {
            Console.WriteLine($"Id: {superHeroe.Id}");
            Console.WriteLine($"Nombre: {superHeroe.Nombre}");
            Console.WriteLine($"Identidad secreta: {superHeroe.IdentidadSecreta} \n");
        }
    }
}