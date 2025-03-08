using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDex1._0._2.PokemonClass
{

    internal class Necrozma : Pokemon
    {
        public Necrozma()
        {
            this.Name = "Necrozma";
            this.Type = PokemonType.Psychic;
            this.Type2 = (int)PokemonType.None;
            this.HP = 97;
            this.Attack = 107;
            this.Defense = 101;
            this.SpecialAttack = 127;
            this.SpecialDefense = 89;
            this.Speed = 79;
            this.Total = 600;
            this.image = Resource1.ResourceManager.GetObject("necrozma") as byte[] ?? Array.Empty<byte>();
        }
    }
}

