using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

        // Calling the Cyclic Rotation
             CyclicRotation();
        }

        private static void CyclicRotation()
        {          
            int[] A = { 1, 4, 5, 6 };
            int K = Convert.ToInt32(Console.ReadLine());
            foreach(int value in A)
            {
                Console.Write(" {0}",value);
            }
            
            int[] B = new int[A.Length];

            for(int i =0; i< A.Length; i++)
            {
                B[(i + K) % A.Length] = A[i];
            }
            foreach (int value in B)
            {
                Console.Write(" {0}", value);
            }
        }
     }
}
