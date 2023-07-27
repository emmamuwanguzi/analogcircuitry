using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace analogcircuitry
{
    class Program
    {
        static void Main(string[] args)
        {
            components strut1 = new components();
            Console.WriteLine("Enter the components");
            Console.WriteLine(" components1");
            strut1.Component1=Console.ReadLine();
            Console.WriteLine("components2");
            strut1.Component2 = Console.ReadLine();
            //Console.WriteLine($"role {strut1.Role}");
            strut1.identify();
            Console.WriteLine($"role {strut1.role}");
            
            strut1.problemsFacedByDesigners();
            Console.ReadLine();
        }
    }
}
