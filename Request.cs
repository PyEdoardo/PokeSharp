using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PokeSharp
{
    class Request
    {
        private readonly HttpClient clienteHttp;

        public Request()
        {
            clienteHttp = new HttpClient();
        }

        public async Task<Pokemon?> GetPokemon(string nome)
        {
            string url = $"https://pokeapi.co/api/v2/pokemon/{nome.ToLower()}";

            try
            {
                HttpResponseMessage response = await clienteHttp.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    using JsonDocument doc = JsonDocument.Parse(json);
                    JsonElement root = doc.RootElement;

                    int id = root.GetProperty("id").GetInt32();
                    string nomePokemon = $"Nome: {root.GetProperty("name").GetString()}";
                    double altura = root.GetProperty("height").GetDouble() / 10;
                    double peso = root.GetProperty("weight").GetDouble() / 10;
                    byte[] imagem;
                    List<string> tipos = new();
                    foreach (JsonElement typeElement in root.GetProperty("types").EnumerateArray())
                    {
                        string tipo = typeElement.GetProperty("type").GetProperty("name").GetString();
                        tipos.Add($"{tipo} ");
                    }

                    List<string> golpes = new();
                    int count = 0;
                    foreach (JsonElement moveElement in root.GetProperty("moves").EnumerateArray())
                    {
                        if (count >= 5) break;
                        string golpe = moveElement.GetProperty("move").GetProperty("name").GetString();
                        golpes.Add($"{count + 1}: {golpe}");
                        count++;
                    }

                    string urlImagem = root.GetProperty("sprites").GetProperty("front_default").GetString();

                    using (var streamImg = Pokemon.BaixarImagem(urlImagem))
                    {
                        imagem = await streamImg;
                    }

                    return new Pokemon(id, nomePokemon, tipos, altura, peso, golpes, imagem);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao buscar Pokémon: {ex.Message}");
            }

            return null;
        }
    }
}
