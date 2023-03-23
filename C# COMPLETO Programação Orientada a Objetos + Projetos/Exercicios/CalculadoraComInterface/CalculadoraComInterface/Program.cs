using System;

interface IAnimal
{
    void Speak();
}

class Dog : IAnimal
{
    public void Speak()
    {
        Console.WriteLine("Woof!");
    }
}

class Cat : IAnimal
{
    public void Speak()
    {
        Console.WriteLine("Meow!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        IAnimal animal1 = new Dog();
        IAnimal animal2 = new Cat();

        animal1.Speak();
        animal2.Speak();
    }
}
