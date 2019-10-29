using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace random
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int A = 0, B = 100;
            int count = 1;
            while ( B > A + 1 )
            {
                int C = (A + B) / 2;
                    Console.Write("Q{0} : so cua ban co lon hon  {1} ", count, C);
                count++;
                string dapan = Console.ReadLine();
                if (dapan == "y")
                    A = C;
                if ( dapan == "n")
                {
                    B = C;                    
                }
            }
                Console.Write("Q{0} : {1} co phai la so cua ban", count, A);
                string ketqua = Console.ReadLine();
                if (ketqua == "y")
                    Console.WriteLine("so cua ban la " + A);
                else
                    Console.WriteLine(" hoi hoi cl ");
        }
    }
}
