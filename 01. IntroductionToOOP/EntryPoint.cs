//Note: Right click the Visual Studio in the start menu to open another one.
//Note: Select all data and press ctrl+M+M to minimize an entire block of code 
//this depends on where the cursor is. 

using IntroductionToOOP.Characters.Body;
//Notice I'm using this custom namespace. The description on how to use it is in the Thief.cs file


using System;

    public class EntryPoint
    {
        static void Main()
        {
            //Within the main class, you make an instance of your class
            //This is call instanciating (There is a Thief.cs in the Solution Explorer)
            Thief playerOne = new Thief("Lockes", 5, 3, 50);
            Thief enemyOne = new Thief("Ratface", 10, 5, 10);

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

        playerOne.Level = 200;
        Console.WriteLine(playerOne.Level);
        //This will assign the value of the Level property of the playerOne instance to 10 and 
        //Set the level field to 10 as well. 

            playerOne.Steal(enemyOne.Name);
        Console.WriteLine($"{playerOne.Name} currently has {playerOne.HealthPoints} HP");
            playerOne.Attack(enemyOne);
            enemyOne.Attack(playerOne);
        Console.WriteLine($"{playerOne.Name} currently has {playerOne.HealthPoints} HP");


        }
    }

