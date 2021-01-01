using System;

namespace VehicleAirplaneInheritance
{
    public class Vehicle
    {
        protected int _capacity;
        protected int _numPassengers;
        protected int _speed = 10;

        public int NumPassengers { get; set; }
        public int Position { get; set; }

        public Vehicle() { }

        public Vehicle(int capacity, int speed = 10) 
        {
            _capacity = capacity;
            _speed = speed;
        }


        public string Move()
        {
            return $"Moving along";
        }

        public string Move(int times)
        {
            return $"Moving along {times} times";
        }


        static void Main(string[] args)
        {
            Airplane a = new Airplane(200, 100, "JetsRUs")
            { NumPassengers = 150 };
            a.Ascend(500);
            Console.WriteLine(a.Move(3));
            Console.WriteLine(a);
            a.Descend(200);
            Console.WriteLine(a.Move());
            a.Move();
            Console.WriteLine(a);
        }
    }
}
