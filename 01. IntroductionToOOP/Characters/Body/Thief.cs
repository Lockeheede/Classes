using _01.IntroductionToOOP;
using _01.IntroductionToOOP.Characters;
using _01.IntroductionToOOP.Weapons.Technology;
using System;

namespace IntroductionToOOP.Characters.Body
{
    public class Thief : Character
    {
    

        private const int DEFAULT_DAMAGE = 5;
        private const int DEFAULT_HEALTH_POINTS = 50;
        private const int DEFAULT_LEVEL = 3;
        private const string DEFAULT_NAME = "Remy";
        private readonly TechKnife DEFAULT_WEAPON = new TechKnife();

        public Thief(string name)
            :this(name, DEFAULT_LEVEL, DEFAULT_DAMAGE, DEFAULT_HEALTH_POINTS)
        {

        }
        public Thief(string name, int level, int damage, int healthPoints)
        {
            IdCounter++;
            this.ID = IdCounter;
            this.Level = level;
            this.Name = name;
            this.Damage = level * damage;
            this.HealthPoints = level * healthPoints;
            this.Weapon = new TechKnife();
        }


        public Thief()
        {
            IdCounter++;
            this.ID = IdCounter;
            this.Level = 1;
            this.Name = "Remy";
            this.Damage = 5 * Level;
            this.HealthPoints = 50 * Level;
            this.Weapon = new TechKnife();
        }

        public Thief(int damage)
            : base (damage)
        {
            
            IdCounter++;
            this.ID = IdCounter;
            this.Level = 3;
            this.Name = DEFAULT_NAME;
            this.HealthPoints = DEFAULT_HEALTH_POINTS * Level;
            this.Weapon = new TechKnife();

        }

        public override int HealthPoints
        {
            get
            {
                return base.HealthPoints;
            }
            set
            {
                if (value <= 0 && value >= 150)
                {
                    Console.WriteLine("Health Points value is inappropriate, setting default to 100!");
                    base.HealthPoints = 100;
                }
            }
        }

        public void Steal(string name)
        {
            Console.WriteLine($"{this.Name} tries to steal from {name}");
            //Use the this keyword when you have conflicting names in the arguments vs the fields
            //For instance, private string name is at the top of the class but the Steal method has an argument that is also name
            //The this keyword refers to the field at the top (the class)
            //Some people tend to use underscores as well. private string _name for example
        }

        public void Attack(Thief enemy)
        {
            enemy.HealthPoints -= Damage;
            Console.WriteLine($"{this.Name} is attacking {enemy.Name}. { enemy.Name} now has { enemy.HealthPoints} HP left!");
        }
        public void Sneak()
        {
            throw new NotImplementedException();
        }
        public static void GetAllDefaultInformation(Thief thief)
        {
            Tools.ColorfulWriteLine($"Default Name: {DEFAULT_NAME}" +
            $"\nDefault Level: {DEFAULT_LEVEL}" +
            $"\nDefault HP: {DEFAULT_HEALTH_POINTS}" +
            $"\nDefault Damage: {DEFAULT_DAMAGE}" +
            $"\nDefault Weapon: {thief.DEFAULT_WEAPON.GetType()}", ConsoleColor.Blue
            ); 
        }

        public override void Move(double speed)
        {
            speed *= 1.50;
            base.Move(speed);
        }
    }
}