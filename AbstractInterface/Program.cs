using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInterface
{


    class Program
    {

        static void Main(String[] args)
        {
            Car car1 = new Car();

            car1.go();
            car1.stop();
            

            Bike bike1 = new Bike(); 

            bike1.ride();
            

        }
    }
}
