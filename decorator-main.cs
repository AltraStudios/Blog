class Program
{
    static void Main(string[] args)
    {
        // Normal Walk with no sound
        Car noSoundCar = new Car();
        noSoundCar.Walk();

        Console.WriteLine("------------");

        // now the car will make sounds while walking
        CarMakingSound carMakingSound = new CarMakingSound(noSoundCar);
        carMakingSound.Walk();

        Console.ReadKey();
    }
}
