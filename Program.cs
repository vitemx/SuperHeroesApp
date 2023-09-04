using SuperHeroesApp;
using SuperHeroesApp.Data;
using SuperHeroesApp.Interfaces;
using SuperHeroesApp.Models;
using System;

ImprimirInfo imprimirInfo = new ();
ISuperHeroe _superHeroe = new SuperHeroe();

Console.WriteLine("=============<----SUPER HEROES APP----->=============");
Console.WriteLine("Hola! Bienvenido a la app para super heroes");
Console.WriteLine("Elige la opción deseada");
Console.WriteLine("1. Mostrar Heroes\n 2. Mostrar Antiheroes");

var respuesta = Console.ReadLine();
switch (respuesta)
{
    case "1":
        await MostrarHeroes();
        break; 
    case "2":
        await MostrarAntiHeroes();
        break;   
    default:
        System.Console.WriteLine("Opción no correcta, intenta de nuevo");
        break;
}

async Task MostrarHeroes()
{
    Heroes heroes = new();
    var listaHeroes = await heroes.GetSuperHeroes();
    Console.WriteLine("Elige a tu heroe favorito, para ver su información");

    foreach (var heroe in listaHeroes)
    {
        Console.WriteLine($"{heroe.Id}. {heroe.Nombre}\n");
    }

    var seleccion = Console.ReadLine();
    var heroeSeleccionado = listaHeroes.Find(lh => lh.Id.Equals(Int32.Parse(seleccion)));

    if (heroeSeleccionado == null)
    {
        System.Console.WriteLine("La opción enviada no existe");
    }
    else 
    {
        heroeSeleccionado.SuperHeroeInfo(heroeSeleccionado);
    }
}

async Task MostrarAntiHeroes()
{
    AntiHeroes antiHeroes = new();
    Console.WriteLine("Elige a tu antiheroe favorito, para ver su información");
    var listaAntiHeroes = await antiHeroes.GetAntiHeroes();

    for (int i = 1; i == listaAntiHeroes.Count; i++)
    {
        Console.WriteLine($"{i}. {listaAntiHeroes[i-1].Nombre}\n");
    }

    var seleccion = Console.ReadLine();
    var antiHeroeSeleccionado = listaAntiHeroes.Find(lh => lh.Id.Equals(seleccion));

    if (antiHeroeSeleccionado == null)
    {
        System.Console.WriteLine("La opción enviada no existe");
    }
    else 
    {
        antiHeroeSeleccionado.SuperHeroeInfo(antiHeroeSeleccionado);
    }
}
