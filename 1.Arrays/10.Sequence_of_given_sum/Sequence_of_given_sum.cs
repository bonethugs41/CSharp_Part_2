////Write a program that finds in given array of integers a sequence of given sum S (if present).
////Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11 => {4, 2, 5}	



//using System;

//class SequenceSum
//{
//    static void Main()
//    {
//        Console.Title = "Sequence of given sum";
//        int n;
//        while (true)
//        {
//            Console.Write("Enter the array length: ");
//            string check = Console.ReadLine();
//            bool result = int.TryParse(check, out n);
//            if (result == true && n > 0)
//            {
//                break;
//            }
//        }

//        int[] array = new int[n];
//        for (int i = 0; i < n; i++)
//        {
//            while (true)
//            {
//                Console.Write("Element with index {0}: ", i);
//                string check = Console.ReadLine();
//                bool result = int.TryParse(check, out array[i]);
//                if (true)
//                {
//                    break;
//                }
//            }
//        }

//        int bigSum;
//        while (true)
//        {
//            Console.Write("Enter the sum: ");
//            string check = Console.ReadLine();
//            bool result = int.TryParse(check, out bigSum);
//            if (result == true)
//            {
//                break;
//            }
//        }

//        int index = 0;
//        int sum = 0;
//        int numOfElements = 0;
//        for (int k = 0; k < n; k++)
//        {
//            for (int j = 0; j < n - k; j++)
//            {
//                for (int i = 0; i < k; i++)
//                {
//                    sum = sum + array[j + i];
//                }
//                if (sum == bigSum)
//                {
//                    index = j;
//                    numOfElements = k;
//                    Console.WriteLine();
//                    Console.WriteLine("Those Elements, that have sum {0} are:", bigSum);
//                    for (int l = index; l < index + numOfElements; l++)
//                    {
//                        Console.WriteLine(array[l]);
//                    }
//                }
//                sum = 0;
//            }
//        }
//    }
//}




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.SequenceOfGivenSum
{
    class SequenceOfGivenSum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Size of array N:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter sum S:");
            int bigSum = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter an Array of {0} elements:", n);
            int[] arr = new int[n];
            int index = 0;
            int sum = 0;
            int numOfElements = 0;
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int k = 0; k < n; k++)
            {
                for (int j = 0; j < n - k; j++)
                {
                    for (int i = 0; i < k; i++)
                    {
                        sum = sum + arr[j + i];

                    }
                    if (sum == bigSum)
                    {
                        index = j;
                        numOfElements = k;
                        Console.WriteLine();
                        Console.WriteLine("Those Elements, that have sum {0} are:", bigSum);
                        for (int l = index; l < index + numOfElements; l++)
                        {
                            Console.WriteLine(arr[l]);
                        }
                    }
                    sum = 0;
                }
            }

        }
    }
}













