using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Blood myBlood = new Blood(AB0System.A);
            
            Console.WriteLine("Bloodgroup: " + myBlood.Group);
            Console.ReadLine();
        }
    }
}
