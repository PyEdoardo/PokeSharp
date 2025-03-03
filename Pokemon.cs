using System;
using System.ComponentModel.DataAnnotations;
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
        public byte[] Imagem { get; set; }

        public Pokemon(int id, string nome, List<string> tipo, double altura, double peso, List<string> golpes,byte[] Imagem)
        {
            this.Id = id;
            this.Nome = nome;
            this.Tipo = tipo;
            this.Altura = altura;
            this.Peso = peso;
            this.Golpes = golpes;
            this.Imagem = Imagem;
        }

        public string deixarMaiusculo(string texto)
        {
            TextInfo global = CultureInfo.CurrentCulture.TextInfo;
            return global.ToTitleCase(texto.ToLower());
        }
        public static async Task<byte[]> BaixarImagem(string url)
        {
            using (HttpClient cliente = new HttpClient())
            {
                try
                {
                    return await cliente.GetByteArrayAsync(url);
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Erro na hora de baixar a imagem: {e.Message}");
                    return null;
                }
            }
        }

        public void debugPokemon()
        {
            Console.WriteLine($"ID: {this.Id} | Nome: {this.Nome}");
        }
    }
}
