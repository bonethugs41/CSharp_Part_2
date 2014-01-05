//Write a method that adds two polynomials. Represent them as arrays of their coefficients.


using System;

class Polynomials
{
    static void Add(int[] arr1, int[] arr2)
    {
        int[] arrAddFirstSecond = new int[arr2.Length];

        for (int i = 0; i < arr1.Length; i++)
        {
            arrAddFirstSecond[i] = arr1[i] + arr2[i];

        }
        for (int i = arr1.Length; i < arrAddFirstSecond.Length; i++)
        {
            arrAddFirstSecond[i] = arr2[i];

        }
        Print(arrAddFirstSecond);
    }
    static void Print(int[] arr)
    {
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            Console.Write(arr[i] + " ");
        }
    }
    static void Main()
    {
        int temp;
        Console.WriteLine("Enter Degree of the first polynomial:");
        int smallerDegree = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Degree of the second polynomial:");
        int biggerDegree = int.Parse(Console.ReadLine());


        //Check biggest degree:
        if (smallerDegree >= biggerDegree)
        {
            temp = biggerDegree;
            biggerDegree = smallerDegree;
            smallerDegree = temp;
        }
        //Initializing arrays:
        int[] arrFirstPolynomial = new int[smallerDegree + 1];
        Console.WriteLine("Enter {0} coefficients of the first polynomial (Example: x^2 + 5 -> [1, 0, 5]):", smallerDegree + 1);
        for (int i = 0; i < arrFirstPolynomial.Length; i++)
        {
            arrFirstPolynomial[i] = int.Parse(Console.ReadLine());
        }

        int[] arrSecondPolynomial = new int[biggerDegree + 1];
        Console.WriteLine("Enter {0} coefficients of the second polynomial (Example: x^2 + 5 -> [1, 0, 5]):", biggerDegree + 1);
        for (int i = 0; i < arrSecondPolynomial.Length; i++)
        {
            arrSecondPolynomial[i] = int.Parse(Console.ReadLine());
        }
        Array.Reverse(arrFirstPolynomial);
        Array.Reverse(arrSecondPolynomial);
        Console.WriteLine("New Polynomial:");
        Add(arrFirstPolynomial, arrSecondPolynomial);
        Console.WriteLine();
    }
}