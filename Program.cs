//Liskov:
/*using System;

interface IFlyingAnimal
{
    void Fly();
}

interface ISwimmingAnimal
{
    void Swim();
}

class Bird : IFlyingAnimal, ISwimmingAnimal
{
    public void Fly()
    {
        Console.WriteLine("Bird is flying");
    }

    public void Swim()
    {
        Console.WriteLine("Bird is swimming");
    }
}

class Fish : ISwimmingAnimal
{
    public void Swim()
    {
        Console.WriteLine("Fish is swimming");
    }
}

class Program
{
    static void Main()
    {
        IFlyingAnimal bird = new Bird();
        ISwimmingAnimal fish = new Fish();

        MakeAnimalFly(bird); 
        
    }

    static void MakeAnimalFly(IFlyingAnimal animal)
    {
        animal.Fly();
    }
}*/


//ISP
/*
using System;

interface IWorker
{
    void Work();
}

interface IEater
{
    void Eat();
}

class HumanWorker : IWorker, IEater
{
    public void Work()
    {
        Console.WriteLine("Human is working");
    }

    public void Eat()
    {
        Console.WriteLine("Human is eating");
    }
}

class RobotWorker : IWorker
{
    public void Work()
    {
        Console.WriteLine("Robot is working");
    }
}

class Program
{
    static void Main()
    {
        IWorker humanWorker = new HumanWorker();
        IEater humanEater = new HumanWorker();
        IWorker robotWorker = new RobotWorker();

        humanWorker.Work();
        humanEater.Eat();

        robotWorker.Work();
        // robotWorker.Eat(); // Bu sətri yazsaq xəta yaranar çünki robot worker yemək yeməyi dəstəkləmir.
    }
}
*/
//DIP
using System;

interface ISwitchable
{
    void TurnOn();
    void TurnOff();
}

class LightBulb : ISwitchable
{
    public void TurnOn()
    {
        Console.WriteLine("LightBulb is on");
    }

    public void TurnOff()
    {
        Console.WriteLine("LightBulb is off");
    }
}

class Switch
{
    private ISwitchable _device;

    public Switch(ISwitchable device)
    {
        _device = device;
    }

    public void TurnOn()
    {
        _device.TurnOn();
    }

    public void TurnOff()
    {
        _device.TurnOff();
    }
}

class Program
{
    static void Main()
    {
        ISwitchable bulb = new LightBulb();
        Switch sw = new Switch(bulb);

        sw.TurnOn(); // LightBulb is on
        sw.TurnOff(); // LightBulb is off
    }
}
//Switch" sinifi "LightBulb" sinifindən birbaşa asılı olmur,  "ISwitchable" interfeysindən asılı olur

