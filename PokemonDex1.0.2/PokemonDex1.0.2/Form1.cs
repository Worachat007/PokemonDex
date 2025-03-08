using System.Reflection;
using PokemonDex1._0._2.pokemonClass;
using PokemonDex1._0._2.PokemonClass;

namespace PokemonDex1._0._2
{
    public partial class Form1 : Form
    {
        private List<Pokemon> pokemonsList = new List<Pokemon>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Pikachu pikachu = new Pikachu();
            this.pokemonsList.Add(pikachu);
            this.displayPokemon(pikachu);

        }


        private void displayPokemon(Pokemon pokemon)
        {
            NewMethod(pokemon);

            void NewMethod(Pokemon pokemon)
            {
                this.pictureBox1.Text = pokemon.Name;
                using (var ms = new MemoryStream(pokemon.getImage()))
                {
                    this.pictureBox1.Image = Image.FromStream(ms);
                }
                this.Name_dis.Text = pokemon.Name;
                this.Type_dis.Text = pokemon.Type.ToString();
                if ((PokemonType)pokemon.Type2 == PokemonType.None)
                {
                    this.Type2_dis.Visible = false;
                }
                else
                {
                    this.Type2_dis.Text = pokemon.Type.ToString();
                    this.Type2_dis.Visible = true;
                }
                this.Name_dis.Text = pokemon.Name;
                this.Type_dis.Text = pokemon.Type.ToString();
                this.Type2_dis.Text = ((PokemonType)pokemon.Type2).ToString();
                this.HP_dis.Text = pokemon.HP.ToString();
                this.Atk_dis.Text = pokemon.Attack.ToString();
                this.Def_dis.Text = pokemon.Defense.ToString();
                this.SpAtk_dis.Text = pokemon.SpecialAttack.ToString();
                this.SpDef_dis.Text = pokemon.SpecialDefense.ToString();
                this.Speed_dis.Text = pokemon.Speed.ToString();
                this.Total_dis.Text = pokemon.Total.ToString();
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Pikachu_Click(object sender, EventArgs e)
        {
            Pikachu pikachu = new Pikachu();
            this.pokemonsList.Add(pikachu);
            this.displayPokemon(pikachu);
        }

        private void Rayquaza_Click(object sender, EventArgs e)
        {
            Rayquaza rayquaza = new Rayquaza();
            this.pokemonsList.Add(rayquaza);
            this.displayPokemon(rayquaza);
        }

        private void Marshadow_Click(object sender, EventArgs e)
        {
            Marshadow marshadow = new Marshadow();
            this.pokemonsList.Add(marshadow);
            this.displayPokemon(marshadow);
        }

        private void Eternatus_Click(object sender, EventArgs e)
        {
            Eternatus eternatus = new Eternatus();
            this.pokemonsList.Add(eternatus);
            this.displayPokemon(eternatus);
        }

        private void Necrozma_Click(object sender, EventArgs e)
        {
            Necrozma necrozma = new Necrozma();
            this.pokemonsList.Add(necrozma);
            this.displayPokemon(necrozma);
        }

        private void Chien_Pao_Click(object sender, EventArgs e)
        {
            Zygarde zygarde = new Zygarde();
            this.pokemonsList.Add(zygarde);
            this.displayPokemon(zygarde);
        }
    }
}
