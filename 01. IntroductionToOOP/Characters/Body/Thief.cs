
using _01.IntroductionToOOP.Weapons.Technology;
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
        private readonly int ID;//A read only const cannot be changed and it is only accessible through constructors. It
        //can be assigned during runtime
        //const are another constant that cannot be changed, they are assigned right off the bat
        private const int DEFAULT_DAMAGE = 5;
        private const int DEFAULT_HEALTH_POINTS = 50;
        private const int DEFAULT_LEVEL = 3;
        private const string DEFAULT_NAME = "Remy";
        private readonly TechKnife DEFAULT_WEAPON = new TechKnife();//const are static, so you cannot use objects, it must be read only
        private int level;
        private int damage;
        private int healthPoints;
        private TechKnife weapon;
        //These variables are called fields, or internal logic
        //Meaning they should only be accessed in the class
        //Also meaning they should be private

        //Two other access modifiers are internal and protected
        //Internal modifiers can be used between projects, but you must reference them (far right, right click reference)
        //Protected modifiers can only be used between inherited classes. So the Characters > Body > Thief classes can access
        //Any fields, methods, properties, variables, etc that are protected between them.

        private static int idCounter; //A static can only be accessed within the class itself. See the constructors here and the EntryPoint.cs
                                      //A static member keeps track of itself. This would be a good way to see how many versions of a class there is.
        public static int IdCounter 
        { 
            get
            {
                return idCounter;
            }
            private set
            {
                idCounter = value;
            }
        }


        //Note: Alt+Shift and keys up down, etc is a mass edit

        //Properties are variables that connect the fields to their
        //External logic versions outside the class
        //Remember to capitalize properties normally, and use getters and setters
        //The shortcut for properties is prop+TAB+TAB

        public int Level { 
            get
            {
                //Code inside happens when you are getting a value
                return this.level;
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
                    this.level = value;
                }
                else
                {
                    Console.WriteLine("Inappropriate level! Must be between 1 and 100. Default level 1 was set!");
                    this.level = 1;
                }
                //This sends the value back into the field
                //The value is whatever value you set the property to
                //(See EntryPoint.cs)
            }
                }
   
        public string Name { get => this.name; set => this.name = value; }
        public int Damage { get => this.damage; set => this.damage = value; }//To get this, you select the private field variable above and select
                                                                   //The lightbulb and choose encapsulate field (but still use field)
                                                                   /// This is the same thing as the normal get and set blocks but it is a 
                                                                   /// shorthanded version. Only use if you are 100% certain you won't be putting
                                                                   /// more information in those blocks of code.
        public int HealthPoints { get => this.healthPoints; set => this.healthPoints = value; }
        public TechKnife Weapon { get => this.weapon; set => this.weapon = value; }
        public int Id
        {
            get
            {
                return this.ID;
            }
        }

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
            idCounter++;
            this.ID = IdCounter;
            this.Level = level;//Set the properties to the fields
            this.Name = name;
            this.Damage = level * damage;
            this.HealthPoints = level * healthPoints;
            this.Weapon = new TechKnife();
        }
        //Constuctors are used to initalized when you need to 
        //To automatically create a constructor, type "ctor + TAB +TAB"
        public Thief()
        {
            idCounter++;
            this.ID = IdCounter;
            this.Level = 1;
            this.Name = "Remy";
            this.Damage = 5 * level;
            this.HealthPoints = 50 * level;
            this.Weapon = new TechKnife();
        }

        public Thief(string name)
        {
            
            idCounter++;
            this.ID = IdCounter;
            this.Level = 3;
            this.Name = name;
            this.Damage = 5 * level;
            this.HealthPoints = 50 * level;
            this.Weapon = new TechKnife();

        }
        //Chain constructors to reduce redundant code!
        //In my ThiefAndMuses2020Code, I'm not going to be using that in case of custom characters. The second overloading constructor
        //Is beneficial for making basic, enemy or friendly characters. The only thing that will affect the changes would be the level.


        //Creating methods in classes is a little different
        //Notice there is no static. The objects you create can call on these methods with the dot operator
        public void Steal(string name)
        {
            Console.WriteLine($"{this.name} tries to steal from {name}");
            //Use the this keyword when you have conflicting names in the arguments vs the fields
            //For instance, private string name is at the top of the class but the Steal method has an argument that is also name
            //The this keyword refers to the field at the top (the class)
            //Some people tend to use underscores as well. private string _name for example
        }

        public void Attack(Thief enemy)
        {
            enemy.HealthPoints -= Damage;
            Console.WriteLine($"{this.name} is attacking {enemy.Name}. { enemy.Name} now has { enemy.HealthPoints} HP left!");
        }

        //Use exceptions in extreme cases. The NotImplementedException is a placeholder until I can make methods for these skills
        public void Sneak()
        {
            throw new NotImplementedException();
        }
    }
}