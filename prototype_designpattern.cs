using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototype_designpattern
{
    public interface ICloneable
    {
        ICloneable Clone();
    }

    public class CarProperty
    {
        public string Color;
    }
    public class Car1Prototype : CarProperty,  ICloneable
    {
        public Car1Prototype()
        {
            this.Color = "Red";
            Console.WriteLine("Created New Object of type Car1Prototype.");
        }

        public ICloneable Clone()
        {
            Console.WriteLine("Cloned Copy of type Car1Prototype.");

            return MemberwiseClone() as Car1Prototype;
        }
    }
    public class Car2Prototype : CarProperty, ICloneable
    {
        public Car2Prototype()
        {
            this.Color = "Blue";
            Console.WriteLine("Created New Object of type Car2Prototype.");

        }

        public ICloneable Clone()
        {
            Console.WriteLine("Cloned Copy of type Car2Prototype.");

            return MemberwiseClone() as Car2Prototype;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, ICloneable> cars = new Dictionary<string, ICloneable>();
            cars.Add("Red", new Car1Prototype());
            cars.Add("Blue", new Car2Prototype());
            cars.Add("Red2", cars["Red"].Clone());
            cars.Add("Blue2", cars["Blue"].Clone());

            Console.WriteLine("Cars Dictionary contains: " + cars.Count() + " cars.");
            Console.ReadKey();
        }
    }
}
