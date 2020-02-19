

namespace _01.IntroductionToOOP.Weapons.DarkAge
{
    using _01.IntroductionToOOP.Characters.Interfaces;
    using System;
    public class GlassBottle : Weapon, IEssentialOils
    {
        private int damage;
        private int healing;

        public int Damage
        {
            get
            {
                return this.damage;
            }
            set
            {
                if (value > 10 || value < 0)
                {
                    Console.WriteLine("Inappropriate value! Default damage set to 0!");
                    this.damage = 0;
                }
                else
                {
                    this.damage = value;
                }
            }
        }
        public int Healing
        {
            get
            {
                return this.healing;
            }
            set
            {
                if (value > 0 || value < 10)
                {
                    Console.WriteLine("Inappropriate value! Healing set to 0!");
                    this.healing = 0;
                }
                else
                {
                    this.healing = value;
                }
            }
        }
        public GlassBottle()
        {
            this.damage = 3;
            this.healing = 10;
        }

        public void Drink()
        {
            throw new NotImplementedException();
        }

        public void Drop()
        {
            throw new NotImplementedException();
        }

    }
}
    