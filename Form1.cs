using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace PokeSharp
{
    public partial class Form1 : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        private DB banco = new DB();
        public Form1()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue600, Primary.Blue700,
                Primary.Blue200, Accent.LightBlue200,
                TextShade.WHITE
            );

            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialCard1.Visible = false;
            this.Text = "Pokesharp ";
            AutoCompleteStringCollection cachePokemons = new AutoCompleteStringCollection();
            cachePokemons.AddRange(banco.GetPokemons().ToArray());
            textBox1.AutoCompleteCustomSource = cachePokemons;
            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }
        private async Task CarregarImagem(Pokemon pokemon)
        {
            if (pokemon.Imagem != null)
            {
                using (var streamImagem = new MemoryStream(pokemon.Imagem))
                {
                    pictureBox1.Image = Image.FromStream(streamImagem);
                    Console.WriteLine("Imagem Carregada");
                }
            }
        }

        private async Task CarregarImagemShiny(Pokemon pokemon)
        {
            if (pokemon.ImagemShiny != null)
            {
                using (var streamimagem = new MemoryStream(pokemon.ImagemShiny))
                {
                    pictureBox2.Image = Image.FromStream(streamimagem);
                    Console.WriteLine("ImagemShiny Carregada");
                }
            }
        }

        private void mostrarMaterialbar(string texto)
        {
            MaterialSnackBar aviso = new MaterialSnackBar(texto, 3000);
            aviso.Show(this);
        }

        private async void materialButton1_Click(object sender, EventArgs e)
        {
            string NomePokemon = textBox1.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(NomePokemon))
            {
                mostrarMaterialbar("Caixa de Texto vazia, digite um pokemon");
                return;
            }

            if (banco == null)
            {
                mostrarMaterialbar("Erro: Banco de dados não inicializado.");
                return;
            }

            Pokemon pokemon = banco.getPokemonNome(NomePokemon);

            if (pokemon == null)
            {
                Request request = new Request();
                Pokemon pokemonSalvo = await request.GetPokemon(NomePokemon);
                if (banco.verificarSeExiste(NomePokemon))
                {
                    return;
                }
                if (pokemonSalvo != null)
                {
                    banco.AdicionarPokemon(pokemonSalvo);
                    mostrarMaterialbar("Pokemon Adicionado a Base de Dados Local");
                    pokemon = pokemonSalvo;
                }
                else
                {
                    mostrarMaterialbar("Nome de pokémon errado ou não existente, tente novamente");
                    return;
                }
            }


            if (pokemon != null)
            {
                string tipos = "Tipos: ";
                labelNome.Text = $"Nome: {pokemon.deixarMaiusculo(pokemon.Nome)}";
                foreach (string tipo in pokemon.Tipo)
                {
                    tipos += pokemon.deixarMaiusculo(tipo) + " ";
                    Console.WriteLine($"Tipo adicionado na lista tipos");
                }
                labelAltura.Text = $"Altura: {pokemon.Altura}m";
                labelPeso.Text = $"Peso: {pokemon.Peso}kg";
                labelTipos.Text = tipos.Trim();
                await CarregarImagem(pokemon);
                await CarregarImagemShiny(pokemon);
                materialCard1.Visible = true;
            }
            else
            {
                mostrarMaterialbar("Erro ao recuperar informações do Pokémon.");
            }
        }


        private void materialCard1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void githubDoDesenvolvedorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void temaEscuroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
        }

        private void temaBrancoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }

        private void githubDoDesenvolvedorToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://github.com/PyEdoardo/PokeSharp",
                UseShellExecute = true
            });
        }

        private void resetarCacheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            banco.apagarCache();
            Console.WriteLine("Pokemons Apagados");
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                materialButton1_Click(sender, e);
            }
        }
    }
}
