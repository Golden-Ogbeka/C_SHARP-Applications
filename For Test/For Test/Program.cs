//Number one
/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Test
{
    class Program
    {
        
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++) 
            {
                Console.WriteLine("Student {0}",i+1);
                Console.WriteLine("Enter your test1 score: ");
                int test1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter your test2 score: ");
                int test2 = Convert.ToInt32(Console.ReadLine());
                int C_A = test1 + test2;
                Console.WriteLine("Enter your exam score: ");
                int exam = Convert.ToInt32(Console.ReadLine());
                int score = C_A + exam;
                string grade;
                if (score >= 70) { grade = "A"; }
                else if (score >= 60 && score <= 69) { grade = "B"; }
                else if (score >= 50 && score <= 59) { grade = "C"; }
                else if (score >= 45 && score <= 49) { grade = "D"; }
                else { grade = "F"; }
                Console.WriteLine("Your result grade is: {0}", grade);
                Console.WriteLine();
            }
                Console.ReadKey();
        }
        
    }
}
 */
//Number two
/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Test
{
    class Program
    {
        static int function(int[] x) 
        {
            int min=x[0];
            for (int i = 0; i < x.Length; i++) 
            {
                if (x[i] < min) 
                {
                    min = x[i];
                }
            }
            return min;
        }
        static void Main(string[] args)
        {
            int[] array = {4,7, 2,4, 0, 1 };
            int man = function(array);
            Console.WriteLine("The least value is: {0}",man);
            Console.ReadKey();
        }
        
    }
}
*/