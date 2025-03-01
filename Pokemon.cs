using System;
using System.Globalization;
namespace PokeSharp
{
    class Pokemon
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<string> Tipo { get; set; }
        public double Altura { get; set; }
        public double Peso { get; set; }
        public List<string> Golpes { get; set; }
        public string UrlImagem { get; set; }

        public Pokemon(int id, string nome, List<string> tipo, double altura, double peso, List<string> golpes, string urlImagem)
        {
            this.Id = id;
            this.Nome = nome;
            this.Tipo = tipo;
            this.Altura = altura;
            this.Peso = peso;
            this.Golpes = golpes;
            this.UrlImagem = urlImagem;
        }

        public string deixarMaiusculo(string texto)
        {
            TextInfo global = CultureInfo.CurrentCulture.TextInfo;
            return global.ToTitleCase(texto.ToLower());
        }
    }
}
