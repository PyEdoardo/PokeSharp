using MaterialSkin;
using MaterialSkin.Controls;
using System.Net;

namespace PokeSharp
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK; // ou LIGHT

            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey800, Primary.BlueGrey900,
                Primary.BlueGrey500, Accent.LightBlue200,
                TextShade.WHITE);
            this.Text = "PokeSharp";
            materialCard1.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }
        private void CarregarImagem(string url)
        {
            try
            {
                using (WebClient wc = new WebClient())
                {
                    byte[] imagemBytes = wc.DownloadData(url);
                    using (var ms = new System.IO.MemoryStream(imagemBytes))
                    {
                        pictureBox1.Image = Image.FromStream(ms);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar a imagem: " + ex.Message);
            }
        }
        private async void materialButton1_Click(object sender, EventArgs e)
        {
            string NomePokemon = textBoxNome.Text.Trim().ToLower();

            if (!string.IsNullOrWhiteSpace(NomePokemon))
            {
                Request request = new Request();
                var pokemon = await request.GetPokemon(NomePokemon);
                string tipos = "Tipos: ";
                if (pokemon != null)
                {
                    labelNome.Text = $"{pokemon.deixarMaiusculo(pokemon.Nome)}";
                    foreach (string tipo in pokemon.Tipo)
                    {
                        tipos += pokemon.deixarMaiusculo(tipo);
                        Console.WriteLine($"Tipo adicionado na lista tipos");
                    }
                    labelAltura.Text = $"Altura: {pokemon.Altura.ToString()}m";
                    labelPeso.Text = $"Peso: {pokemon.Peso.ToString()}kg";
                    labelTipos.Text = tipos;
                    CarregarImagem(pokemon.UrlImagem);
                    materialCard1.Visible = true;
                }
                else
                {
                    MaterialSnackBar avisoNaoEncontrado = new MaterialSnackBar("Pokémon não encontrado!", 3000);
                    avisoNaoEncontrado.Show(this);
                }
            }
            else
            {
                MaterialSnackBar avisoNaoEncontrado = new MaterialSnackBar("Caixa de Texto vazia, digite um pokemon", 3000);
                avisoNaoEncontrado.Show(this);
            }
        }

        private void materialCard1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
