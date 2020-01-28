
namespace _01.IntroductionToOOP.Weapons.Technology
{
using System;
    public  class TechKnife
    {
        private int damage;

        public int Damage 
        {
         get
            {
                return this.damage;
            }
         set
            {
                if (value >= 1 && value <= 5)
                {
                    this.damage = value;
                }
                else
                {
                    this.damage = 1;
                    Console.WriteLine("Invalid damage value. Default set to 1!");
                }

            }    


        }
        
        
        //To generate an auto constructor, select your property and select Ctrl+. 
        //Then generate a constructor
        public TechKnife()
        {
            this.Damage = 5;
        }

        public void BackStab()
        {
            throw new NotImplementedException();
        }



    }
}
