using System.Collections.Generic;

namespace Aps.Models
{
    public class Pais
    {
        public Pais(string nome, int continenteId)
        {
            Nome = nome;
            ContinenteId = continenteId;
        }

        public int Id { get; set; }

        public string Nome { get; set; }

        private Continente continente { get; set; }
        public int ContinenteId { get; set; }

        public ICollection<Denuncia> Denuncias { get; set; } = new List<Denuncia>();
    }
}
