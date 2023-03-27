using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Car
    {
        private bool started;
        protected int MaxSpeed;
        public void start()
        {
            if(!started)
            {
                started = true;
                Console.WriteLine("Car started");
            }
            else
            {
                Console.WriteLine("Car already started");
            }
        }
        public void stop() {
            if(started)
            {
                started = false;
                Console.WriteLine("Car stopped");
            }
            else
            {
                Console.WriteLine("Car already stopped");
            }
        }
        public int GetMaxSpeed()
        {
            return MaxSpeed;
        }
        public virtual void ABS()
        {
            Console.WriteLine("ABS");
        }
    }
    public class Volvo : Car
    {
        public Volvo()
        {
            MaxSpeed = 40;
        }
        public override void ABS()
        {
            Console.WriteLine("Advanced ABS");
        }
    }
}
