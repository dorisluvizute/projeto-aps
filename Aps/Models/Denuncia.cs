using System;

namespace Aps.Models
{
    public class Denuncia
    {
        public Denuncia(string textoDenuncia, int paisId, DateTime dataCriacao)
        {
            TextoDenuncia = textoDenuncia;
            PaisId = paisId;
            DataCriacao = dataCriacao;
        }

        public int Id { get; set; }

        public string TextoDenuncia { get; set; }

        public DateTime DataCriacao { get; set; }

        private Pais Pais { get; set; }
        public int PaisId { get; set; }
    }
}
