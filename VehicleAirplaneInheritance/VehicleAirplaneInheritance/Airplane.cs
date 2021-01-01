using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleAirplaneInheritance
{
    public class Airplane: Vehicle
    {
        private string _airline;
        private int _altitude;

        public Airplane() { }

        public Airplane(int capacity)
        {
            _capacity = capacity;
        }

        public Airplane(int capacity, int speed, string airline) 
        {
            _capacity = capacity;
            _speed = speed;
            _airline = airline;
        }

        public void Ascend(int distance)
        {
            _altitude += distance;
        }

        public void Descend(int distance)
        {
            _altitude -= distance;
        }

        public new string Move()
        {
            Position += _speed;
            return $"Moving along at an altitude of {_altitude} metres";
        }

        public new string Move(int times)
        {
            Position += times*_speed;
            return $"Moving along {times} times at an altitude of {_altitude} metres";
        }

        public override string ToString()
        {
            return $"Thank you for flying {_airline}: {base.ToString()}: capacity: {_capacity}, passengers: {NumPassengers}, speed: {_speed}, position: {Position}, altitude: {_altitude} ";
        }
    }
}
