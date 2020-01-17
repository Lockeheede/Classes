

    public class EntryPoint
    {
        static void Main()
        {
        //Within the main class, you make an instance of your class
        //This is call instanciating (There is a Thief.cs in the Solution Explorer)
        Thief playerOne = new Thief();

        //To access the variables of the new instance, you use the
        //dot operator
        playerOne.Name = "Lockes";
        playerOne.Level = 5;
        playerOne.Damage = playerOne.Level * 3; //Note for game, this character will have 3 damage added per level 
        playerOne.HealthPoints = playerOne.Level * 50; //50 health per level
        System.Console.WriteLine(playerOne.HealthPoints);

        //You can instanciate with another object, but you can create new variables
        Thief enemyOne = new Thief();

        enemyOne.Name = "Ratface";
        enemyOne.Level = 10;
        enemyOne.Damage = enemyOne.Level * 5;
        enemyOne.HealthPoints = enemyOne.Level * 20;

        //Make a new class file by right clicking the project in the solution explorer
        //Choose Add > Class. Make sure your class is the same name as the class you created
        //For example, this Thief class will be named Thief.cs
        }
    }
