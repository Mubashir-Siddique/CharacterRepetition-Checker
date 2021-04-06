using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharRepetition
{
    class Program
    {
        static void Main(string[] args)
        {
            Test TestObject = new Test();

            var InputString = "Shah";
            var CharToReturn =  TestObject.CheckRepeatition(InputString);

            if (CharToReturn == '\0')
            {
                Console.WriteLine("There is no Duplicate character in the Given String");
            }
            Console.WriteLine("The First Duplicated Character was {0}", CharToReturn);
            Console.ReadLine();
        }
    }
}
