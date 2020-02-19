
namespace _01.IntroductionToOOP.Characters.Spirit
{
using _01.IntroductionToOOP.Characters.Interfaces;
using _01.IntroductionToOOP.Weapons;
using _01.IntroductionToOOP.Weapons.DarkAge;
using _01.IntroductionToOOP.Weapons.Technology;
using System;
    public class Muse : Character, IDoMath, IMuse
    {
        private const int DEFAULT_DAMAGE = 4;
        private const int DEFAULT_HEALTH_POINTS = 50;
        private const int DEFAULT_LEVEL = 10;
        private const string DEFAULT_NAME = "Reflex";
        private readonly GlassBottle DEFAULT_WEAPON = new GlassBottle();
        

        public Muse (string name)
        :this(name, DEFAULT_LEVEL, DEFAULT_DAMAGE, DEFAULT_HEALTH_POINTS)
        {

        }

        public Muse(string name, int level, int damage, int healthPoints)
        {
            IdCounter++;
            this.ID = IdCounter;
            this.Level = level;
            this.Name = name;
            this.Damage = level * damage;
            this.HealthPoints = level * healthPoints;
            this.Weapon = new GlassBottle();
        }
        public Muse()
        {
            IdCounter++;
            this.ID = IdCounter;
            this.Level = 10;
            this.Name = "Reflex";
            this.Damage = 4 * Level;
            this.HealthPoints = 50 * Level;
            this.Weapon = new GlassBottle();
        }

        public Muse(int damage)
            : base (damage)
        {

            IdCounter++;
            this.ID = IdCounter;
            this.Level = 10;
            this.Name = DEFAULT_NAME;
            this.Damage = 4 * this.Level;
            this.HealthPoints = DEFAULT_HEALTH_POINTS * this.Level;
            this.Weapon = new GlassBottle();

        }

        public override int HealthPoints
        {
            get
            {
                return base.HealthPoints;
            }
            set
            {
                if (value <= 0 && value >= 120)
                {
                    Console.WriteLine("Health Points value is inappropriate, setting default to 100!");
                    base.HealthPoints = 100;
                }
            }
        }

        public int MagickPoints { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        GlassBottle IMuse.Weapon { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void Move(double speed)
        {
            speed *= 1.20;
            base.Move(speed);
        }
        public override void AddTwoNumbers()
        {
            int sum = base.NumberA + base.NumberB + 100;
            sum -= 100;
            Console.WriteLine(sum);
        }

        public void ChiBlast(Character character)
        {
            throw new NotImplementedException();
        }

        public void ChiRefresh()
        {
            throw new NotImplementedException();
        }
    }
}
