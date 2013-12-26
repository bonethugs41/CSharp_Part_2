//Write a program that reads a rectangular matrix of size N x M
//and finds in it the square 3 x 3 that has maximal sum of its elements.



using System;

class MaximalSquare
{
    static void Main()
    {
        Console.Title = "Maximal sum in square";
        int n;
        int m;
        while (true)
        {
            Console.Write("Enter N: ");
            string checkN = Console.ReadLine();
            bool resultN = int.TryParse(checkN, out n);
            Console.Write("Enter M: ");
            string checkM = Console.ReadLine();
            bool resultM = int.TryParse(checkM, out m);
            if (resultM == true && resultN == true && m > 0 && n > 0)
            {
                break;
            }
        }
        int[,] matrix = new int[n, m];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
			{
                while (true)
                {
                    Console.Write("Element[{0},{1}]: ", i, j);
                    string check = Console.ReadLine();
                    bool result = int.TryParse(check, out matrix[i, j]);
                    if (result == true)
                    {
                        break;
                    }
                }
			}
        }
        
        int sum = int.MinValue;
        int tempSum = 0;
        int maxRow = 0;
        int maxCol = 0;
        for (int row = 0; row < matrix.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 2; col++)
            {
                sum = matrix[row, col] + matrix[row + 1, col + 1] + matrix[row + 1, col] + matrix[row, col + 1] + matrix[row + 2, col] + matrix[row, col + 2] + matrix[row + 1, col + 2] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                if (sum > tempSum)
                {
                    tempSum = sum;
                    maxRow = row;
                    maxCol = col;
                }
            }
        }

        Console.WriteLine("The maximal sum is: {0}", tempSum);
        Console.WriteLine();
        Console.WriteLine("The elements of the submatrix are:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write("{0, -4}", matrix[maxRow + i, maxCol + j]);
            }
            Console.WriteLine();
        }
    }
}