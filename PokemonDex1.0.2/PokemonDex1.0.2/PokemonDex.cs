using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDex1._0._2 
{
    public enum PokemonType
    {
        Normal,
        Flying,
        Electric,
        Fire,
        Water,
        Grass,
        Ice,
        Fighting,
        Poison,
        Ground,
        Rock,
        Bug,
        Ghost,
        Steel,
        Psychic,
        Dragon,
        Dark,
        Fairy,
        None
    }
    public class Pokemon
    {
        //class attributes
        public string Name;
        public int HP;
        public int Attack;
        public int Defense;
        public int SpecialAttack;
        public int SpecialDefense;
        public int Speed;
        public int Total;
        public int Type2;
        public PokemonType Type;
        public byte[] image;
        internal readonly PokemonType Type2_dis;

        //constructor
        public Pokemon() { }
        //methods
        public string getName()
        {
            return this.Name;
        }
        public byte[] getImage()
        {
            return this.image;
        }
    }
}

