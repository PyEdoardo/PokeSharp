using MaterialSkin;
using MaterialSkin.Controls;

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
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string NomePokemon = textBoxNome.Text.Trim().ToLower();

            if (!string.IsNullOrWhiteSpace(NomePokemon))
            {
                Request request = new Request();
                var pokemon = await request.GetPokemon(NomePokemon);

                if (pokemon != null)
                {
                    labelNome.Text = $"{pokemon.Nome}";
                    foreach (string tipo in pokemon.Tipo)
                    {
                        labelTipos.Text += $"\n{tipo}";
                    }
                    labelAltura.Text = $"Altura: {pokemon.Altura.ToString()}m";
                    labelPeso.Text = $"Peso: {pokemon.Peso.ToString()}kg";
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
