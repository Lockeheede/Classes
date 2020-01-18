
using System;
//First you make the class
public class Thief
{
    //The access modifiers need to be public 
    //So the class can be accessed by methods, etc
    private int level;
    private string name;
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

    public int Level { get; set; }
    public string Name { get; set; }
    public int Damage { get; set; }
    public int HealthPoints { get; set; }

    //Creating methods in classes is a little different
    //Notice there is static
    public void Steal(string name)
    {
        System.Console.WriteLine($"{Name} tries to steal from {name}");
    }

    public void Attack(Thief enemy)
    {
        enemy.HealthPoints -= Damage;
        Console.WriteLine($"{ Name} is attacking {enemy.Name}. { enemy.Name} now has { enemy.HealthPoints} HP left!");
    }
}