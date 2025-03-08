using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDex1._0._2 .pokemonClass
{
    internal class Zygarde : Pokemon
    {
        public Zygarde()
        {
            this.Name = "Zygarde";
            this.Type = PokemonType.Dragon;
            this.Type2 = (int)PokemonType.Ground;
            this.HP = 108;
            this.Attack = 100;
            this.Defense = 121;
            this.SpecialAttack = 81;
            this.SpecialDefense = 95;
            this.Speed = 95;
            this.Total = 600;
            this.image = Resource1.ResourceManager.GetObject("zygarde") as byte[] ?? Array.Empty<byte>();

        }
    }
}
