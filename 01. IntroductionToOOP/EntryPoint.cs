//Note: Right click the Visual Studio in the start menu to open another one.
//Note: Select all data and press ctrl+M+M to minimize an entire block of code 
//this depends on where the cursor is. 
//Note: All the comments for notes are in the Thief_Notes.cs



using _01.IntroductionToOOP;
using _01.IntroductionToOOP.Characters;
using _01.IntroductionToOOP.Characters.Spirit;
using IntroductionToOOP.Characters.Body;
//Notice I'm using this custom namespace. The description on how to use it is in the Thief.cs file


using System;
using System.Collections.Generic;

public class EntryPoint
    {
        static void Main()
        {
            //Within the main class, you make an instance of your class
            //This is call instanciating (There is a Thief.cs in the Solution Explorer)
            Thief playerOne = new Thief("Lockes", 5, 3, 50);
            /*Thief enemyOne = new Thief("Ratface", 10, 5, 10);
            Thief enemyTwo = new Thief();
            Thief enemyThree = new Thief("Zidane");
            */
            Muse playerTwo = new Muse("Reflex", 5, 2, 50);
            Character playerThree = new Thief();//Polymorphism, since the Thief class inherits from the Character class. One object acts like other objects with this pillar of OOP

        //Tools.ColorfulWriteLine("Number of thieves is: " + Thief.IdCounter, ConsoleColor.Green);*/

        //To access the variables of the new instance, you use the
        //dot operator
        /*playerOne.Name = "Lockes";
        playerOne.Level = 5;
        playerOne.Damage = playerOne.Level * 3; //Note for game, this character will have 3 damage added per level 
        playerOne.HealthPoints = playerOne.Level * 50; //50 health per level
        */

        //You can instanciate with another object, but you can create new variables
        /*Thief enemyOne = new Thief();

        enemyOne.Name = "Ratface";
        enemyOne.Level = 10;
        enemyOne.Damage = enemyOne.Level * 5;
        enemyOne.HealthPoints = enemyOne.Level * 20;
        */

        //Make a new class file by right clicking the project in the solution explorer
        //Choose Add > Class. Make sure your class is the same name as the class you created
        //For example, this Thief class will be named Thief.cs

        //playerOne.Level = 200;
        /*Tools.ColorfulWriteLine($"{playerOne.Name} is at level " + playerOne.Level, ConsoleColor.Red);
        Tools.ColorfulWriteLine($"{enemyTwo.Name} total damage is " + enemyTwo.Damage, ConsoleColor.DarkMagenta);
        Tools.ColorfulWriteLine($"{enemyThree.Name} has " + enemyThree.HealthPoints + " health points", ConsoleColor.DarkYellow);
        Tools.ColorfulWriteLine($"{enemyTwo.Name} has an ID of " + enemyOne.ID, ConsoleColor.Blue);
        Tools.ColorfulWriteLine($"{playerOne.Name} has an ID of " + playerOne.ID, ConsoleColor.Blue);*/
        //This will assign the value of the Level property of the playerOne instance to 10 and 
        //Set the level field to 10 as well. 

        /*  playerOne.Steal(enemyOne.Name);
      Console.WriteLine($"{playerOne.Name} currently has {playerOne.HealthPoints} HP");
          playerOne.Attack(enemyOne);
          enemyOne.Attack(playerOne);
      Console.WriteLine($"{playerOne.Name} currently has {playerOne.HealthPoints} HP");
      */

        //using the static method from the Thief.cs
        /*Console.WriteLine();
        playerTwo.Move(1000);*/
        /* Thief.GetAllDefaultInformation(playerOne);*/

        /*Use abstraction to simplify the complexity of your code
        You use abstraction and interfaces to partial define
        a class. Interfaces are used to create a set of properties and methods
        Implementers provide how interfaces are used. Interfaces are the what is used*/
        playerOne.NumberA = 5; playerOne.NumberB = 15;
        playerOne.AddTwoNumbers();
        /*ecapsulation is only used to show what you want to show
         * use the access modifiers to show information
         * this includes public, private, protected, etc*/

        playerThree.Move(3);//Polymorphism: If any properities or methods are different in the other class, it takes the values of the other class (Thief), not the base (Character)

        //You can use polymorphism to put all the characters in a single list, even though they are different objects. This won't work with a List<Thief> or List<Muse>. It would have
        //To be a base class that Thief and Muse derive from.
        List<Character> theCharacters = new List<Character>();
        theCharacters.Add(playerOne);
        theCharacters.Add(playerTwo);
        theCharacters.Add(playerThree);

        
    }
}

