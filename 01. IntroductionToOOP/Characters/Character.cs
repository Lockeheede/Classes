
namespace _01.IntroductionToOOP.Characters
{
    using _01.IntroductionToOOP.Characters.Interfaces;
    using _01.IntroductionToOOP.Weapons;
    using _01.IntroductionToOOP.Weapons.Technology;
using System;
    using System.Threading;

    public abstract class Character : IDoMath
    {
        private int Id;
        private string name;
        private int level;
        private int damage;
        private int healthPoints;
        private Weapon weapon;


        private static int idCounter;
        public static int IdCounter
        {
            get
            {
                return idCounter;
            }
            protected set
            {
                idCounter = value;
            }
        }



        public int Level
        {
            get
            {
                return this.level;
            }
            set
            {
                if (value >= 1 && value <= 100)
                {
                    this.level = value;
                }
                else
                {
                    Console.WriteLine("Inappropriate level! Must be between 1 and 100. Default level 1 was set!");
                    this.level = 1;
                }
            }
        }

        public int ID
        {
            get => this.Id;
            set => this.Id = value;
        }

        public string Name { get => this.name; set => this.name = value; }
        public int Damage { get => this.damage; set => this.damage = value; }

        //Use virtual properties in case you want to use alternate properties in another class
        //Check the Thief and Muse classes to see the override properties 
        public virtual int HealthPoints 
        {
            get
            {
                return healthPoints;
            }
            set
            {
                if(value <= 0 && value >= 100)
                {
                    Console.WriteLine("Health Points value is inappropriate, setting default to 100!");
                    healthPoints = 100;
                }
            }

        }
        private int numberA, numberB;
        public int NumberA { get => this.numberA; set => this.numberA = value; }
        public int NumberB { get => this.numberB; set => this.numberB = value; }
        public Weapon Weapon { get => this.weapon; set => this.weapon = value; }

        protected Character()
        {
            
        }
        public Character(int damage)
        {
            this.damage = damage;
        }

        //You can also use virtual and override methods as well
        public virtual void Move(double speed)
        {
            Console.WriteLine(Convert.ToInt32(speed));

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("I am moving!");
                Thread.Sleep(Convert.ToInt32(speed));
            }
        }

        public abstract void AddTwoNumbers();
        
    }
}
