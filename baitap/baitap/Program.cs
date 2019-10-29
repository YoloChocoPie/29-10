using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap
{
    class Program
    {
        static void Main(string[] args)
        {

      Vongtron c1 = new Vongtron();

      Console.WriteLine("The circle has radius of " + c1.getRadius() + " and area of " + c1.getArea());  

      Vongtron c2 = new Vongtron(2.0);

      Console.WriteLine("The circle has radius of " + c2.getRadius() + " and area of " + c2.getArea());

     //Vongtron c3 = new Vongtron(3, "Black");
     // Console.WriteLine(" Co ban kinh " + c3.getRadius() + " va mau " + c3.getRadius(), c3.getRadius());
     //     c3.

        }
    }
}
