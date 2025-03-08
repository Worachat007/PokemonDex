using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDex1._0._2.PokemonClass
{
    internal class Marshadow : Pokemon
    {
        public Marshadow()
        {
            this.Name = "Marshadow";
            this.Type = PokemonType.Fighting;
            this.Type2 = (int)PokemonType.Ghost;
            this.HP = 90;
            this.Attack = 125;
            this.Defense = 80;
            this.SpecialAttack = 90;
            this.SpecialDefense = 90;
            this.Speed = 125;
            this.Total = 600;
            this.image = Resource1.ResourceManager.GetObject("marshadow") as byte[] ?? Array.Empty<byte>();
        }
    }
}
