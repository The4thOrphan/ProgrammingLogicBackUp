namespace Lab8;

using System;

class Animal  
{
    public virtual void animalSound()
    {
        Console.WriteLine("The animal makes a sound");
    }
}

class Cat : Animal  
{
    public override void animalSound()
    {
        Console.WriteLine("The cat says: meow");
    }
}

class Dog : Animal  
{
    public override void animalSound()
    {
        Console.WriteLine("The dog says: bow wow");
    }
}

class Program
{
    static void Main()
    {
        Animal mamimal = new Animal(); 
        Animal theFelinecompanion = new Cat();      
        Animal Bog = new Dog();       

        mamimal.animalSound(); 
        theFelinecompanion.animalSound();      
        Bog.animalSound();      
    }
}