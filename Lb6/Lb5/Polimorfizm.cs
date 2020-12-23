using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb6
{
        public class Overload
        {
            public void DisplayOverload(int a)//перегрузка метода
            {
                System.Console.WriteLine("DisplayOverload " + a);
            }
            public void DisplayOverload(string a)
            {
                System.Console.WriteLine("DisplayOverload " + a);
            }
            public void DisplayOverload(string a, int b)
            {
                System.Console.WriteLine("DisplayOverload " + a + b);
            }
        }
        public interface Car
        {
            void refuel();
        }

        public class NormalCar : Car
        {
            public void refuel()
            {
                Console.WriteLine("Заправка бензом");
            }
        }

        public class ElectricCar : Car
        {
            public void refuel()
            {
                Console.WriteLine("Зарядка батареи");
            }
        }
}
