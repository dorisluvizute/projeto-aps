namespace Aps.Models
{
    public class Denuncia
    {
        public Denuncia(string textoDenuncia, int paisId)
        {
            TextoDenuncia = textoDenuncia;
            PaisId = paisId;
        }

        public int Id { get; set; }

        public string TextoDenuncia { get; set; }

        private Pais Pais { get; set; }
        public int PaisId { get; set; }
    }
}
