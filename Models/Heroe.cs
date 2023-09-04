using System.Text;

namespace SuperHeroesApp.Models
{
    internal abstract class Heroe
    {
        public abstract string Nombre { get; set; }
        public abstract string SalvarElMundo();
        public virtual string SalvarLaTierra()
        {
            return $"{Nombre} ha salvado la tierra";
        }
        public virtual string UsarSuperPoderes(List<SuperPoder> SuperPoderes)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var poder in SuperPoderes)
            {
                sb.AppendLine($"{Nombre} esta usando el super poder {poder.Nombre}!!");
            }
            return sb.ToString();
        }
    }
}