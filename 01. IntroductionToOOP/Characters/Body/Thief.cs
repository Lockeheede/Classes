
using System;
//A namespace is a collection of classes. 
//For example the System in System.Console.WriteLine(); is a namespace
//The Console is the class and the WriteLine is the method or dot operator
//When you use a namespace, you put it with your classes. 
//That way when you are using the classes outside of their place, you use the
//#using IntroductionToOOP; namespace for example.

namespace IntroductionToOOP.Characters.Body
{
    //Right click the project in the solution explorer and create a new folder Characters>Body to organize your characters.
    //For my game, I'm making Body, Mind and Spirit characters
    //You would need to put dots in the namespace for each folder, because they, too are namespaces


    //First you make the class
    public class Thief
    {
        //The access modifiers need to be public 
        //So the class can be accessed by methods, etc
        private string name;
        private int level;
        private int damage;
        private int healthPoints;
        //These variables are called fields, or internal logic
        //Meaning they should only be accessed in the class
        //Also meaning they should be private

        //Note: Alt+Shift and keys up down, etc is a mass edit

        //Properties are variables that connect the fields to their
        //External logic versions outside the class
        //Remember to capitalize properties normally, and use getters and setters
        //The shortcut for properties is prop+TAB+TAB

        public int Level { 
            get
            {
                //Code inside happens when you are getting a value
                return level;
                //When trying to get a value from a property (Level)
                //It returns the field (level). Properties are the
                //barriers between the real world and fields
            }
            set
            {
                //Code inside happens when you are setting a value

                //You will need to validate certain types of values
                //You validate in the set field. For instance
                //a character's level cannot be below 1 or unreasonably high
                //so you validate
                if (value >= 1 && value <= 100)
                {
                    level = value;
                }
                else
                {
                    Console.WriteLine("Inappropriate level! Must be between 1 and 100. Default level 1 was set!");
                    level = 1;
                }
                //This sends the value back into the field
                //The value is whatever value you set the property to
                //(See EntryPoint.cs)
            }
                }
   
        public string Name { get => name; set => name = value; }
        public int Damage { get => damage; set => damage = value; }//To get this, you select the private field variable above and select
                                                                   //The lightbulb and choose encapsulate field (but still use field)
                                                                   /// This is the same thing as the normal get and set blocks but it is a 
                                                                   /// shorthanded version. Only use if you are 100% certain you won't be putting
                                                                   /// more information in those blocks of code.
        public int HealthPoints { get; set; }

        /// Note: You can change a property to read, write or read-write. To make it read only, remove the set block
        /// To make it write only, remove the get block. To make both
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="level"></param>
        /// <param name="damage"></param>
        /// <param name="healthPoints"></param>
        /// </summary>



        //Constructors have access modifiers and the name of the class
        public Thief(string name, int level, int damage, int healthPoints)//use arguments, so when you instanciate the new character you can give them their values
        {
            Level = level;//Set the properties to the fields
            Name = name;
            Damage = level * damage;
            HealthPoints = level * healthPoints;
        }
        //Constuctors are used to initalized when you need to 
        //To automatically create a constructor, type "ctor + TAB +TAB"


        //Creating methods in classes is a little different
        //Notice there is no static. The objects you create can call on these methods with the dot operator
        public void Steal(string name)
        {
            System.Console.WriteLine($"{Name} tries to steal from {name}");
        }

        public void Attack(Thief enemy)
        {
            enemy.HealthPoints -= Damage;
            Console.WriteLine($"{ Name} is attacking {enemy.Name}. { enemy.Name} now has { enemy.HealthPoints} HP left!");
        }

        //Use exceptions in extreme cases.
        public void Sneak()
        {
            throw new NotImplementedException();
        }
    }
}