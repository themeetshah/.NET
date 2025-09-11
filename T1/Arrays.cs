using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Arrays
    {
        static void Main(string[] args)
        {
            int[] x = { 17, 10, 18, 20 };
            int[] num = new int[] { 10, 20, 30 };
            int[] y = new int[5] {1,2,3,4,5};
            y[0] = 45;
            y[1] = 20;
            y[2] = 35;
            y[3] = 45;
            y[4] = 95;

            int[] z = new int[5];
            Console.WriteLine("Enter elements for array z:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter value for index {i}: ");
                z[i] = int.Parse( Console.ReadLine() );
            }

            Console.WriteLine("\nConsole.WriteLine(z): " + z); // Gives type of z when z is array
            Console.WriteLine("\nThe array elements for z are: "+string.Join(",", z));
            
            Console.Write("\nThe array elements for y are: ");
            foreach (var item in y)
            {
                Console.Write(item + ",");
            }
            Array.Sort(y);
            Console.WriteLine("\nThe array elements for y in sorted manner are: "+String.Join(",",y));

            Console.WriteLine("\nThe array elements for x are: "+String.Join(",",x));
            Array.Reverse(x);
            Console.WriteLine("The array elements for x in reverse manner are: "+String.Join(",",x));

            Console.WriteLine("\nIndex of 3 in array y: "+Array.IndexOf(y,3));
            Console.WriteLine("Index of 45 in array y: "+Array.IndexOf(y,45));

            Array.Resize(ref x, 5);
            Console.WriteLine("\nResized array x without changing new element: " + String.Join(",", x));
            x[4] = 101;
            Console.WriteLine("Resized array x after changing new element: " + String.Join(",", x));

            int[] copy_arr = new int[y.Length];
            Array.Copy(y, copy_arr, 3);
            Console.WriteLine("\nThe array elements for copy_arr of 3 elements of y are: " + String.Join(",", copy_arr));

            int[] clone_arr = (int[])y.Clone();
            Console.WriteLine("The array elements for clone_arr of y are: " + String.Join(",", clone_arr));

            // Clone copies whole array
            // Copy copies specified number of elements of that array

            int[,] rectangle = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };
            Console.WriteLine("\nThe array element 0th row and 2nd col of rectangle array is: " + rectangle[0,2]);

            int[][] jagged_arr = new int[2][] { new int[] { 1, 2, 3 }, new int[] { 11, 22, 33, 44, 55 } };
            Console.WriteLine("The array element 1st row and 2nd col of jagged array is: " + jagged_arr[1][2]);
        }
    }
}
