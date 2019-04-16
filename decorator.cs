public interface ICar
{
    void Walk();
}

public class Car : ICar
{
    public void Walk()
    {
        Console.WriteLine("Walking");
    }
}

public interface IDecorator : ICar
{
    void MakeSound();
}

public class CarMakingSound : IDecorator
{
    ICar myCarObject;
    public CarMakingSound(ICar _myCarObject)
    {
        this.myCarObject = _myCarObject;
    }
    public void MakeSound()
    {
        Console.WriteLine("Peep! Peep!");
    }

    public void Walk()
    {
        myCarObject.Walk();
        this.MakeSound();
    }
}
