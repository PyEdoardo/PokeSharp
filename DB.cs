using System;
using System.Data.SQLite;
using System.Collections.Generic;

namespace PokeSharp
{
    class DB
    {
        private readonly string _stringConexao = $"Data Source={Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "pokemon.db")};Version=3;";
        public DB()
        {
            using (var linkBanco = new SQLiteConnection(_stringConexao))
            {
                linkBanco.Open();

                string criarTabela = @"
                CREATE TABLE IF NOT EXISTS Pokemon (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Nome TEXT NOT NULL UNIQUE,
                    Tipos TEXT NOT NULL,
                    Altura REAL NOT NULL,
                    Peso REAL NOT NULL,
                    Golpes TEXT NOT NULL,
                    Imagem BLOB NOT NULL
                )";
                using (var comando = new SQLiteCommand(criarTabela, linkBanco))
                {
                    comando.ExecuteNonQueryAsync();
                }
            }
        }

        public void AdicionarPokemon(Pokemon pokemon)
        {
            using (var connection = new SQLiteConnection(_stringConexao))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    string insertQuery = @"
                INSERT INTO Pokemon (Nome, Tipos, Altura, Peso, Golpes, Imagem) 
                VALUES (@Nome, @Tipos, @Altura, @Peso, @Golpes, @Imagem)";

                    using (var command = new SQLiteCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Nome", pokemon.Nome);
                        command.Parameters.AddWithValue("@Tipos", string.Join(",", pokemon.Tipo));
                        command.Parameters.AddWithValue("@Altura", pokemon.Altura);
                        command.Parameters.AddWithValue("@Peso", pokemon.Peso);
                        command.Parameters.AddWithValue("@Golpes", string.Join(",", pokemon.Golpes));
                        command.Parameters.AddWithValue("@Imagem", pokemon.Imagem);

                        Console.WriteLine($"Inserindo Pokémon {pokemon.Nome} no banco...");
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("Pokémon inserido com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Erro ao inserir Pokémon.");
                        }
                    }

                    transaction.Commit();
                }
            }
        }
        public bool verificarSeExiste(string nome)
        {
            using (var linkBanco = new SQLiteConnection(_stringConexao))
            {
                linkBanco.Open();

                string query = @"SELECT COUNT(*) FROM Pokemon WHERE Nome = @Nome";
                using (var comando = new SQLiteCommand(query, linkBanco))
                {
                    comando.Parameters.AddWithValue("@Nome", nome);
                    long contador = (long)comando.ExecuteScalar();
                    return contador > 0;
                }
            }
        }

        public Pokemon getPokemonNome(string nomePokemon)
        {
            using (var linkBanco = new SQLiteConnection(_stringConexao))
            {
                linkBanco.Open();

                string queryGet = @"
                        SELECT * from Pokemon WHERE Nome == @nome LIMIT 1";

                using (var comando = new SQLiteCommand(queryGet, linkBanco))
                {
                    comando.Parameters.AddWithValue("@nome", nomePokemon);
                    using (var leitor = comando.ExecuteReader())
                    {
                        if (leitor.Read())
                        {
                            int id = leitor.GetInt32(0);
                            string nome = leitor.GetString(1);
                            List<string> tipos = new List<string>(leitor.GetString(2).Split(','));
                            double peso = leitor.GetDouble(3);
                            double altura = leitor.GetDouble(4);
                            List<string> golpes = new List<string>(leitor.GetString(5).Split(','));
                            byte[] imagem = (byte[])leitor["Imagem"];
                            Pokemon pokemonRetorno = new Pokemon(id, nome, tipos, peso, altura, golpes, imagem);
                            return pokemonRetorno;
                        }
                    }
                }
            }
            return null;
        }

        public void apagarCache()
        {
            using (var linkBanco = new SQLiteConnection(_stringConexao))
            {
                linkBanco.Open();

                string deleteQuery = @"
                        DELETE FROM Pokemon";

                using (var comando = new SQLiteCommand(deleteQuery, linkBanco))
                {
                    comando.ExecuteNonQuery();
                }
            }
        }
    }
}
