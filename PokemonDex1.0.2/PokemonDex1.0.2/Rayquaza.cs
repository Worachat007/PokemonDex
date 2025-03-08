using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDex1._0._2.PokemonClass
{
    internal class Rayquaza : Pokemon
    {
        public Rayquaza()
        {
            this.Name = "Rayquaza";
            this.Type = PokemonType.Dragon;
            this.Type2 = (int)PokemonType.Flying;
            this.HP = 105;
            this.Attack = 150;
            this.Defense = 90;
            this.SpecialAttack = 150;
            this.SpecialDefense = 90;
            this.Speed = 95;
            this.Total = 680;
            this.image = Resource1.ResourceManager.GetObject("rayquaza") as byte[] ?? Array.Empty<byte>();
        }
    }
}
