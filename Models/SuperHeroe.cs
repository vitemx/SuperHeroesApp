using System.Runtime.CompilerServices;
using System.Text;
using SuperHeroesApp.Interfaces;

namespace SuperHeroesApp.Models
{
    class SuperHeroe : Heroe, ISuperHeroe
    {
        public int Id { get; set; } = 1;
        private string? _nombre;
        public override string? Nombre
        {
            get  =>  _nombre; 
            set 
            { 
                _nombre = !string.IsNullOrEmpty(value) ? value.Trim() : "";
            }
        }

        public string NombreEIdentidadSecreta
        {
            get
            {
                return $"{Nombre} ({IdentidadSecreta})";
            }
        }
        public string IdentidadSecreta { get; set; }
        public string? Ciudad;
        public List<SuperPoder> SuperPoderes;
        public bool PuedeVolar;

        public SuperHeroe()
        {
            IdentidadSecreta = string.Empty;
            _nombre = "";
            Id = 1;
            SuperPoderes = new();
            PuedeVolar = false;
        }
        public override string SalvarElMundo()
        {
            return $"{NombreEIdentidadSecreta} ha salvado el mundo";
        }
        public override string SalvarLaTierra()
        {
            //return base.SalvarLaTierra();
            return $"{NombreEIdentidadSecreta} ha salvado la tierra";
        }
        public override string UsarSuperPoderes(List<SuperPoder> SuperPoderes)
        {
            //return base.UsarSuperPoderes(SuperPoderes);
            StringBuilder sb = new StringBuilder();
            foreach (var poder in SuperPoderes)
            {
                sb.AppendLine($"{NombreEIdentidadSecreta} esta usando el super poder {poder.Nombre}!!");
            }
            return sb.ToString();
        }

        public void SuperHeroeInfo(SuperHeroe heroe)
        {
            System.Console.WriteLine($"El super heroe que elgiste es: {heroe.Nombre} \n" +
            $"Identidad secreta: {heroe.IdentidadSecreta} \nCiudad: {heroe.Ciudad}");
        }
    }
}