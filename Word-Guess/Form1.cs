// Bryce Haw
// 12/16/2020
// Guess A Word Dictiona
using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz1
{
    class Car
    {
        private int _year, _speed;
        private string _make, _model;
        public string MakeAndModel
        {
            get
            {
                return _make + _model;
            }
        }

        public Car(int carYear, int initialSpeed, string carMake, string carModel)
        {
            _year = carYear;
            _speed = initialSpeed;
            _make = carMake;
            _model = carModel;
        }

        public Car(int carYear, string carMake, string carModel)
        {
            _year = carYear;
            _speed = 0;
            _make = carMake;
            _model = carModel;
        }

        public string GetCarInfo()
        {
            return string.Format("Year: {0}, Make: {1}, Model: {2}", _year, _make, _model);
        }

        private void Accelerate(int speedToAdd)
        {
            _speed += speedToAdd;
        }

        public void Decelerate(int speedToDecrease)
        {
            _speed -= speedToDecrease;
        }

        public int GetSpeed()
        {
            return _speed;
        }
    }
}
