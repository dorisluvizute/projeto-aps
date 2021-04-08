using System.Collections.Generic;

namespace Aps.Models
{
    public class Continente
    {
        public Continente(string nome)
        {
            Nome = nome;
        }
        public int Id { get; set; }
        public string Nome { get; set; }

        public ICollection<Pais> Paises { get; set; } = new List<Pais>();
    }
}
