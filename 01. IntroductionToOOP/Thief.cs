
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
}