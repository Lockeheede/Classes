using System;

namespace _01.IntroductionToOOP.Weapons
{
    public class Weapon
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
                if (value < 0 || value > 10)
                {
                    this.damage = 0;
                    Console.WriteLine("Inappropriate value! Damage set to default of 0!");
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
                if (value < 0 || value > 10)
                {
                    this.healing = 0;
                    Console.WriteLine("Inappropriate value! Healing set to default of 0!");
                }
                else
                {
                    this.healing = value;
                }
            }
        }
        public Weapon()
        {

        }
    }
}
