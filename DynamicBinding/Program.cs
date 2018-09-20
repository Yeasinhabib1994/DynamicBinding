using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicBinding
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic name = "Yeasin";
            name = 24; // changed from string type to int type.
            int age = name;
            Console.WriteLine("age: "+age);

            dynamic a = 10;
            dynamic b = 5;
            var c = a + b; // c also becomes dynamic;
            Console.WriteLine("c: "+c);

            int number = 10;
            dynamic score = number; // score becomes an int type.
            int point = score;
            Console.WriteLine("point: " + point);
        }
    }
}
