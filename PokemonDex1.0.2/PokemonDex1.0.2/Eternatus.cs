using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDex1._0._2.PokemonClass
{

    internal class Eternatus : Pokemon
    {
        public Eternatus()
        {
            this.Name = "Eternatus";
            this.Type = PokemonType.Poison;
            this.Type2 = (int)PokemonType.Dragon;
            this.HP = 140;
            this.Attack = 85;
            this.Defense = 95;
            this.SpecialAttack = 145;
            this.SpecialDefense = 95;
            this.Speed = 130;
            this.Total = 690;
            this.image = Resource1.ResourceManager.GetObject("eternatus") as byte[] ?? Array.Empty<byte>();
        }
    }
}