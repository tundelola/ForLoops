using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {

            // Write a program in C# Sharp to display the cube of the number upto given an integer
            //Console.WriteLine("Pls enter a number");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //int cube;
            //for (int i = 0;  i <= num1; i++)
            //{

            //    cube = i * i * i;

            //    Console.WriteLine("The number you entered = {0}  the cube of {1} is {2}", i,i, cube);

            //}


            // Write a program in C# Sharp to display the multiplication table of a given integer
            //Console.WriteLine("Pls enter a number");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //int n = 15;

            //for (int i = 1; i <= n; i++)
            //{

            //    Console.WriteLine("{0} * {1} = {2}", num1,i, num1 * i );

            //}
            // Write a program in C# Sharp to display the multiplication table vertically from 1 to n.

            //Console.WriteLine("Pls enter a number");
            //int n = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i <= 10; i++)

            //{
            //    for (int j = 1; j <= n; j++)
            //    {
            //        if (j <= n - 1)
            //        {

            //            Console.Write("{0} * {1} = {2}\n", j, i, i * j);

            //        }
            //        else
            //            Console.Write("{0} * {1} = {2}", j, i, i * j);
            //    }
            //    Console.Write("\n");


            //}
            //// Write a program in C# Sharp to display the pattern like right angle triangle using an asterisk
            // int i, j, rows;
            // Console.Write("\n\n");
            // Console.Write("Display the pattern like right angle using asterisk:\n");
            // Console.Write("------------------------------------------------------");
            // Console.Write("\n\n");
            // Console.WriteLine("Pls enter numbers of rows");
            //int  height = Convert.ToInt32(Console.ReadLine());
            // for (int row = 1; row <= height; row++)
            // {
            //     for (int column = 1; column <= row; column++)

            //         Console.Write("*");
            //     Console.Write("\n");



            // }

            // //rows = Convert.ToInt32(Console.ReadLine());
            //for (i = 1; i <= rows; i++)
            //{
            //    for (j = 1; j <= i; j++)
            //        Console.Write("*");
            //    Console.Write("\n");
            //}

            //Write a program in C# Sharp to display the pattern like right angle triangle with a number
            //Console.Write("\n\n");
            //Console.Write("Display the pattern like right angle using asterisk:\n");
            //Console.Write("------------------------------------------------------");
            //Console.Write("\n\n");
            //Console.WriteLine("Pls enter numbers of rows");
            //int height = Convert.ToInt32(Console.ReadLine());
            //for (int row = 1; row <= height; row++)
            //{
            //    for (int column = 1; column <= row; column++)

            //        Console.Write("{0}",column);
            //        Console.Write("\n");



            //}

            //   Write a program in C# Sharp to make such a pattern like right angle triangle with a number which will repeat a number in a row. The pattern is as follows : 
            //1
            //22
            //333
            //4444

            //Console.Write("\n\n");
            //Console.Write("Display the pattern like right angle using asterisk:\n");
            //Console.Write("------------------------------------------------------");
            //Console.Write("\n\n");
            //Console.WriteLine("Pls enter numbers of rows");
            //int height = Convert.ToInt32(Console.ReadLine());
            //for (int row = 1; row <= height; row++)
            //{
            //    for (int column = 1; column <= row; column++)

            //        Console.Write("{0}", row);
            //        Console.Write("\n");


            //}

            //12.Write a program in C# Sharp to make such a pattern like right angle triangle with number increased by 1. 
            //The pattern like : 
            //1
            //2 3
            //4 5 6
            //7 8 9 10

            //Console.Write("\n\n");
            //Console.Write("Display the pattern like right angle using asterisk:\n");
            //Console.Write("------------------------------------------------------");
            //Console.Write("\n\n");
            //Console.WriteLine("Pls enter numbers of rows");
            //int height = Convert.ToInt32(Console.ReadLine());
            //int k = 1;
            //for (int row = 1; row <= height; row++)
            //{
            //    for (int column = 1; column <= row; column++)

            //        Console.Write("{0}", k++);
            //    Console.Write("\n");


            //}
            // Write a program in C# Sharp to make such a pattern like a pyramid with numbers increased by 1

            // 1
            // 2 3
            //4 5 6
            //7 8 9 10
            //Console.Write("\n\n");
            //Console.Write("Display the pattern like right angle using asterisk:\n");
            //Console.Write("------------------------------------------------------");
            //Console.Write("\n\n");
            //Console.WriteLine("Pls enter numbers of rows");
            //int height = Convert.ToInt32(Console.ReadLine());
            //int k = 1;
            //for (int row = 1; row <= height; row++)
            //{
            //    for (int column = 1; column <= row; column++)

            //        Console.Write("{0}", k++);
            //    Console.Write("\n");


            //}
            //int column, k, t = 1, rwLenght;
            //Console.Write("\n\n");
            //Console.WriteLine("Display pattern like a pyramid with numbers increased by 1");
            //Console.Write("----------------------------------------------------------------");
            //Console.Write("\n\n");
            //Console.WriteLine("Pls enter numbers of rows");
            //int height = Convert.ToInt32(Console.ReadLine());
            //int rows = 1;
            //rwLenght = rows + 4 - 1;
            //for (rows = 1; rows <= height; rows++)
            //{
            //    for (k = rwLenght; k >= 1; k--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (column = 1; column <= rows; column++)
            //        Console.Write("0", t++);
            //    Console.Write("\n");
            //    rwLenght--;



            //}
            //int i, j, spc, rows, k, t = 1;

            //Console.Write("\n\n");
            //Console.Write("Display the pattern like pyramid with numbers increased by 1:\n");
            //Console.Write("---------------------------------------------------------------");
            //Console.Write("\n\n");

            //gets user's input
            //Console.Write("input number of rows : ");
            //rows = Convert.ToInt32(Console.ReadLine());
            //spc = rows + 4 - 1;//specifying the pattern of the rows with stars
            //for (i = 1; i <= rows; i++)
            //{
            //    for (k = spc; k >= 1; k--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (j = 1; j <= i; j++)
            //        Console.Write("{0}", t++);
            //    Console.Write("\n");
            //    spc--;
            //}

            // Write a program in C# Sharp to make such a pattern like a pyramid with numbers increased by 1

            // *
            // **
            //***
            //****

            //int i, j, spc, rows, k, t = 1;

            //Console.Write("\n\n");
            //Console.Write("Display the pattern like pyramid with numbers increased by 1:\n");
            //Console.Write("---------------------------------------------------------------");
            //Console.Write("\n\n");
            ////gets user's input
            //Console.Write("input number of rows : ");
            //rows = Convert.ToInt32(Console.ReadLine());
            //spc = rows + 4 - 1;//specifying the pattern of the rows with stars
            //for (i = 1; i <= rows; i++)
            //{
            //    //creates space to form pyramid
            //    for (k = spc; k >= 1; k--)
            //    {
            //        Console.Write(" ");
            //    }
            //    //input stars in the pyramid
            //    for (j = 1; j <= i; j++)
            //        Console.Write("*", t++);
            //    Console.Write("\n");
            //    spc--;
            //}
            ////Write a C# Sharp program to calculate the factorial of a given number.
            //Console.WriteLine("Please enter a number");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //int fact = num1;

            //for (int i = num1; i >= num1; i++)
            //{
            //    fact = fact * i;//calculates the factorial
            //    //display the factorial value
            //    Console.Write("factorial of {0} is {1}", num1, fact);
            //   Console.ReadLine();

            //}


            //Calculate n terms of even natural number and their sum

            Console.Write("Input number of terms : ");
             int   num = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nThe even numbers are :");
            int sum = 0;
            for (int i = 0; i <= num; i++)
            {
                Console.WriteLine("{0}", 2 * i);
                sum += 2 * i;


            }
            Console.Write("The Even Natural Numbers is {0} and the sums is {1}\n", num, sum);

            //    int i, n, sum = 0;

            //    Console.Write("\n\n");
            //    Console.Write("Calculate n terms of even natural number and their sum:\n");
            //    Console.Write("---------------------------------------------------------");
            //    Console.Write("\n\n");

            //    Console.Write("Input number of terms : ");
            //    n = Convert.ToInt32(Console.ReadLine());
            //    Console.Write("\nThe even numbers are :");
            //    for (i = 1; i <= n; i++)
            //    {
            //        Console.Write("{0} ", 2 * i);
            //        sum += 2 * i;
            //    }
            //    Console.Write("\nThe Sum of even Natural Number upto {0} terms : {1} \n", n, sum);
            //}


        }
    }
}

    



