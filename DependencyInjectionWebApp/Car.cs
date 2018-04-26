using System;

namespace DependencyInjectionWebApp
{
    public class Car : ICar
    {
        private bool _running = false;
        public string ChassisNr { get; set; }

        public Car()
        {
            ChassisNr = Guid.NewGuid().ToString();
        }

        public string Start()
        {
            var result = _running ? $"Car {ChassisNr} already running." : $"Car {ChassisNr} started.";
            _running = true;
            return result;
        }

        public string Stop()
        {
            var result = _running ? $"Car {ChassisNr} stopped." : $"Car {ChassisNr} is not running.";
            _running = false;
            return result;
        }
    }
}
