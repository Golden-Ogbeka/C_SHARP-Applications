using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_name
{
    class Program
    {
        static void Main(string[] args)
        {
            int [,] A = { { 1, 2 }, { 3, 4 } };
            int[,] B = {{3,4},{5,6} };
            int[,] C= new int[2,2];
            for (int i = 0; i < 2;i++ ) 
            {
                for (int j = 0; j < 2;j++ )
                {
                    C[i, j] = A[i, j] + B[i, j];
                }
                
            }
            for (int z = 0; z < 2;z++ )
            {
                for (int k = 0; k< 2;k++ )
                {
                    Console.Write( C[z, k]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
