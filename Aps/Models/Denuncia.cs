using System;

namespace Aps.Models
{
    public class Denuncia
    {
        public Denuncia(string textoDenuncia, int paisId, DateTime dataCriacao, int continenteId)
        {
            TextoDenuncia = textoDenuncia;
            PaisId = paisId;
            DataCriacao = dataCriacao;
            ContinenteId = continenteId;
        }

        public int Id { get; set; }

        public string TextoDenuncia { get; set; }

        public DateTime DataCriacao { get; set; }

        private Pais Pais { get; set; }
        public int PaisId { get; set; }
        private Continente Continente { get; set; }
        public int ContinenteId { get; set; }
    }
}
