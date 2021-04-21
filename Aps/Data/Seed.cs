using Aps.Models;
using System.Collections.Generic;
using System.Linq;

namespace Aps.Data
{
    public class Seed
    {
        private readonly Context _context;

        public Seed(Context context)
        {
            _context = context;
        }

        public void SeedTables()
        {
            var continentes = new List<Continente>();
            continentes.Add(new Continente("América"));
            continentes.Add(new Continente("Europa"));
            continentes.Add(new Continente("Ásia"));
            continentes.Add(new Continente("Africa"));
            continentes.Add(new Continente("Oceania"));
            continentes.Add(new Continente("Antártida"));

            if (!_context.Continentes.Any())
            {
                _context.Continentes.AddRange(continentes);
            }
            _context.SaveChanges();

            var paises = new List<Pais>();
            paises.Add(new Pais("Afeganistão", 3));
            paises.Add(new Pais("África do Sul", 4));
            paises.Add(new Pais("Albânia", 2));
            paises.Add(new Pais("Alemanha", 2));
            paises.Add(new Pais("Andorra", 2));
            paises.Add(new Pais("Angola", 4));
            paises.Add(new Pais("Antiga e Barbuda", 1));
            paises.Add(new Pais("Arábia Saudita", 3));
            paises.Add(new Pais("Argélia", 4));
            paises.Add(new Pais("Argentina", 1));
            paises.Add(new Pais("Arménia", 3));
            paises.Add(new Pais("Austrália", 5));
            paises.Add(new Pais("Áustria", 2));
            paises.Add(new Pais("Azerbaijão", 3));
            paises.Add(new Pais("Bahamas", 1));
            paises.Add(new Pais("Bangladexe", 3));
            paises.Add(new Pais("Barbados", 1));
            paises.Add(new Pais("Barém", 3));
            paises.Add(new Pais("Bélgica", 2));
            paises.Add(new Pais("Belize", 1));
            paises.Add(new Pais("Benim", 4));
            paises.Add(new Pais("Bielorrússia", 2));
            paises.Add(new Pais("Bolívia", 1));
            paises.Add(new Pais("Bósnia e Herzegovina", 2));
            paises.Add(new Pais("Botsuana", 4));
            paises.Add(new Pais("Brasil", 1));
            paises.Add(new Pais("Brunei", 3));
            paises.Add(new Pais("Bulgária", 2));
            paises.Add(new Pais("Burquina Faso", 4));
            paises.Add(new Pais("Burúndi", 4));
            paises.Add(new Pais("Butão", 3));
            paises.Add(new Pais("Cabo Verde", 4));
            paises.Add(new Pais("Camarões", 4));
            paises.Add(new Pais("Camboja", 3));
            paises.Add(new Pais("Canadá", 1));
            paises.Add(new Pais("Catar", 3));
            paises.Add(new Pais("Cazaquistão", 3));
            paises.Add(new Pais("Chade", 4));
            paises.Add(new Pais("Chile", 1));
            paises.Add(new Pais("China", 3));
            paises.Add(new Pais("Chipre", 2));
            paises.Add(new Pais("Colômbia", 1));
            paises.Add(new Pais("Comores", 4));
            paises.Add(new Pais("Congo-Brazzaville", 4));
            paises.Add(new Pais("Coreia do Norte", 3));
            paises.Add(new Pais("Coreia do Sul", 3));
            paises.Add(new Pais("Cosovo", 2));
            paises.Add(new Pais("Costa do Marfim", 4));
            paises.Add(new Pais("Costa Rica", 1));
            paises.Add(new Pais("Croácia", 2));
            paises.Add(new Pais("Cuaite", 3));
            paises.Add(new Pais("Cuba", 1));
            paises.Add(new Pais("Dinamarca", 2));
            paises.Add(new Pais("Dominica", 1));
            paises.Add(new Pais("Egito", 4));
            paises.Add(new Pais("Emirados Árabes Unidos", 3));
            paises.Add(new Pais("Equador", 1));
            paises.Add(new Pais("Eritreia", 4));
            paises.Add(new Pais("Eslováquia", 2));
            paises.Add(new Pais("Eslovénia", 2));
            paises.Add(new Pais("Espanha", 2));
            paises.Add(new Pais("Essuatíni", 4));
            paises.Add(new Pais("Estado da Palestina", 3));
            paises.Add(new Pais("Estados Unidos", 1));
            paises.Add(new Pais("Estónia", 2));
            paises.Add(new Pais("Etiópia", 4));
            paises.Add(new Pais("Fiji", 5));
            paises.Add(new Pais("Filipinas", 3));
            paises.Add(new Pais("Finlândia", 2));
            paises.Add(new Pais("França", 2));
            paises.Add(new Pais("Gabão", 4));
            paises.Add(new Pais("Gâmbia", 4));
            paises.Add(new Pais("Gana", 4));
            paises.Add(new Pais("Geórgia", 3));
            paises.Add(new Pais("Granada", 1));
            paises.Add(new Pais("Grécia", 2));
            paises.Add(new Pais("Guatemala", 1));
            paises.Add(new Pais("Guiana", 1));
            paises.Add(new Pais("Guiné", 4));
            paises.Add(new Pais("Guiné Equatorial", 4));
            paises.Add(new Pais("Guiné-Bissau", 4));
            paises.Add(new Pais("Haiti", 1));
            paises.Add(new Pais("Honduras", 1));
            paises.Add(new Pais("Hungria", 2));
            paises.Add(new Pais("Iémen", 3));
            paises.Add(new Pais("Ilhas Marechal", 5));
            paises.Add(new Pais("Índia", 3));
            paises.Add(new Pais("Indonésia", 3));
            paises.Add(new Pais("Irão", 3));
            paises.Add(new Pais("Iraque", 3));
            paises.Add(new Pais("Irlanda", 2));
            paises.Add(new Pais("Islândia", 2));
            paises.Add(new Pais("Israel", 3));
            paises.Add(new Pais("Itália", 2));
            paises.Add(new Pais("Jamaica", 1));
            paises.Add(new Pais("Japão", 3));
            paises.Add(new Pais("Jibuti", 4));
            paises.Add(new Pais("Jordânia", 3));
            paises.Add(new Pais("Laus", 3));
            paises.Add(new Pais("Lesoto", 4));
            paises.Add(new Pais("Letónia", 2));
            paises.Add(new Pais("Líbano", 3));
            paises.Add(new Pais("Libéria", 4));
            paises.Add(new Pais("Líbia", 4));
            paises.Add(new Pais("Listenstaine", 2));
            paises.Add(new Pais("Lituânia", 2));
            paises.Add(new Pais("Luxemburgo", 2));
            paises.Add(new Pais("Macedónia do Norte", 2));
            paises.Add(new Pais("Madagáscar", 4));
            paises.Add(new Pais("Malásia", 3));
            paises.Add(new Pais("Maláui", 4));
            paises.Add(new Pais("Maldivas", 3));
            paises.Add(new Pais("Mali", 4));
            paises.Add(new Pais("Malta", 2));
            paises.Add(new Pais("Marrocos", 4));
            paises.Add(new Pais("Maurícia", 4));
            paises.Add(new Pais("Mauritânia", 4));
            paises.Add(new Pais("México", 1));
            paises.Add(new Pais("Mianmar", 3));
            paises.Add(new Pais("Micronésia", 5));
            paises.Add(new Pais("Moçambique", 4));
            paises.Add(new Pais("Moldávia", 2));
            paises.Add(new Pais("Mónaco", 2));
            paises.Add(new Pais("Mongólia", 3));
            paises.Add(new Pais("Montenegro", 2));
            paises.Add(new Pais("Namíbia", 4));
            paises.Add(new Pais("Nauru", 5));
            paises.Add(new Pais("Nepal", 3));
            paises.Add(new Pais("Nicarágua", 1));
            paises.Add(new Pais("Níger", 4));
            paises.Add(new Pais("Nigéria", 4));
            paises.Add(new Pais("Noruega", 2));
            paises.Add(new Pais("Nova Zelândia", 5));
            paises.Add(new Pais("Omã", 3));
            paises.Add(new Pais("Países Baixos", 2));
            paises.Add(new Pais("Palau", 5));
            paises.Add(new Pais("Panamá", 1));
            paises.Add(new Pais("Papua Nova Guiné", 5));
            paises.Add(new Pais("Paquistão", 3));
            paises.Add(new Pais("Paraguai", 1));
            paises.Add(new Pais("Peru", 1));
            paises.Add(new Pais("Polónia", 2));
            paises.Add(new Pais("Portugal", 2));
            paises.Add(new Pais("Quénia", 4));
            paises.Add(new Pais("Quirguistão", 3));
            paises.Add(new Pais("Quiribáti", 5));
            paises.Add(new Pais("Reino Unido", 2));
            paises.Add(new Pais("República Centro-Africana", 4));
            paises.Add(new Pais("República Checa", 2));
            paises.Add(new Pais("República Democrática do Congo", 4));
            paises.Add(new Pais("República Dominicana", 1));
            paises.Add(new Pais("Roménia", 2));
            paises.Add(new Pais("Ruanda", 4));
            paises.Add(new Pais("Rússia", 2));
            paises.Add(new Pais("Salomão", 5));
            paises.Add(new Pais("Salvador", 1));
            paises.Add(new Pais("Samoa", 5));
            paises.Add(new Pais("Santa Lúcia", 1));
            paises.Add(new Pais("São Cristóvão e Neves", 1));
            paises.Add(new Pais("São Marinho", 2));
            paises.Add(new Pais("São Tomé e Príncipe", 4));
            paises.Add(new Pais("São Vicente e Granadinas", 1));
            paises.Add(new Pais("Seicheles", 4));
            paises.Add(new Pais("Senegal", 4));
            paises.Add(new Pais("Serra Leoa", 4));
            paises.Add(new Pais("Sérvia", 2));
            paises.Add(new Pais("Singapura", 3));
            paises.Add(new Pais("Síria", 3));
            paises.Add(new Pais("Somália", 4));
            paises.Add(new Pais("Sri Lanca", 3));
            paises.Add(new Pais("Sudão", 4));
            paises.Add(new Pais("Sudão do Sul", 4));
            paises.Add(new Pais("Suécia", 2));
            paises.Add(new Pais("Suíça", 2));
            paises.Add(new Pais("Suriname", 1));
            paises.Add(new Pais("Tailândia", 3));
            paises.Add(new Pais("Taiuã", 3));
            paises.Add(new Pais("Tajiquistão", 3));
            paises.Add(new Pais("Tanzânia", 4));
            paises.Add(new Pais("Timor-Leste", 5));
            paises.Add(new Pais("Togo", 4));
            paises.Add(new Pais("Tonga", 5));
            paises.Add(new Pais("Trindade e Tobago", 1));
            paises.Add(new Pais("Tunísia", 4));
            paises.Add(new Pais("Turcomenistão", 3));
            paises.Add(new Pais("Turquia", 3));
            paises.Add(new Pais("Tuvalu", 5));
            paises.Add(new Pais("Ucrânia", 2));
            paises.Add(new Pais("Uganda", 4));
            paises.Add(new Pais("Uruguai", 1));
            paises.Add(new Pais("Usbequistão", 3));
            paises.Add(new Pais("Vanuatu", 5));
            paises.Add(new Pais("Vaticano", 2));
            paises.Add(new Pais("Venezuela", 1));
            paises.Add(new Pais("Vietname", 3));
            paises.Add(new Pais("Zâmbia", 4));
            paises.Add(new Pais("Zimbábue", 4));

            if (!_context.Paises.Any())
            {
                _context.Paises.AddRange(paises);
            }
            _context.SaveChanges();
        }
    }

}
