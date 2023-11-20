using System;

namespace RacingGame
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
    }

    public class Vehicle
    {
        private string _brand;
        private float _speed;
        private float _fuel;

        public Vehicle(string brand, float speed, float fuel)
        {
            
        }

        private void IncreaseSpeed()
        {
            Console.WriteLine("The speed increased to 90 kh");
        }
        private void DecreaseSpeed()
        {
            Console.WriteLine("The speed decreased to 50 kh");
        }
        private void RefuelVehicle()
        {
            
        }
    }

    public class Car : Vehicle , IDrivable
    {
        private int doorCount;
        
        public Car(string brand, float speed, float fuel) : base(brand, speed, fuel)
        {
        }

        private void CarHorn()
        {
            Console.WriteLine("car is horning");
        }

        public void SteerLeft()
        {
            Console.WriteLine("car is Steering Left");
        }

        public void SteerRight()
        {
            Console.WriteLine("car is Steering Right");
        }
    }

    public class Motorcycle : Vehicle , IDrivable
    {
        private bool HasSideCar;
        public Motorcycle(string brand, float speed, float fuel) : base(brand, speed, fuel)
        {
        }

        private void DoWheelie()
        {
            Console.WriteLine("Motorcycle Does Wheelie");
        }

        public void SteerLeft()
        {
            Console.WriteLine("Motorcycle is Steering Left");
        }

        public void SteerRight()
        {
            Console.WriteLine("Motorcycle is Steering Right");
        }
    }

    public interface IDrivable
    {
        void SteerLeft();
        void SteerRight();
        
    }
}