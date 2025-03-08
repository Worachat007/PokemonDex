using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDex1._0._2 .pokemonClass
{
    public class Pikachu : Pokemon
    {
        public Pikachu()
        {
            this.Name = "Pikachu";
            this.Type = PokemonType.Electric;
            this.Type2 = (int)PokemonType.None;
            this.HP = 35;
            this.Attack = 55;
            this.Defense = 40;
            this.SpecialAttack = 50;
            this.SpecialDefense = 50;
            this.Speed = 90;
            this.Total = 320;
            this.image = Resource1.ResourceManager.GetObject("pikachu") as byte[] ?? Array.Empty<byte>();
        }
    }
}
