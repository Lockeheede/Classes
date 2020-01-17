

    public class EntryPoint
    {
        static void Main()
        {
        //Within the main class, you make an instance of your class
        //This is call instanciating 
        Thief playerOne = new Thief();

        //To access the variables of the new instance, you use the
        //dot operator
        playerOne.name = "Lockes";
        playerOne.level = 5;
        playerOne.damage = playerOne.level * 3; //Note for game, this character will have 3 damage added per level 
        playerOne.healthPoints = playerOne.level * 50; //50 health per level
        System.Console.WriteLine(playerOne.healthPoints);

        //You can instanciate with another object, but you can create new variables
        Thief enemyOne = new Thief();

        enemyOne.name = "Ratface";
        enemyOne.level = 10;
        enemyOne.damage = enemyOne.level * 5;
        enemyOne.healthPoints = enemyOne.level * 20;

        //Make a new class file by right clicking the project in the solution explorer
        //Choose Add > Class. Make sure your class is the same name as the class you created
        //For example, this Thief class will be named Thief.cs
        }
    }
