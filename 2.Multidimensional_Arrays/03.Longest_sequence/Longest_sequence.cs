//We are given a matrix of strings of size N x M. 
//Sequences in the matrix we define as sets of several neighbor elements located on the same line, column or diagonal.
//Write a program that finds the longest sequence of equal strings in the matrix. 


using System;

class LongestSequence
{
    static void Main()
    {
        Console.Title = "Maximal Sequence in matrix";
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
        string[,] matrix = new string[n, m];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write("Element[{0},{1}]: ", i, j);
                matrix[i, j] = Console.ReadLine();
            }
        }
        int currentSeq = 0;
        int maxSeq = 0;
        int rowSeq = 0;
        int colSeq = 0;
        
        //Printing the matrix
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write("{0, -5}", matrix[i, j]);
            }
            Console.WriteLine();
        }

        //Row sequences
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                if (matrix[row, col] == matrix[row, col + 1])
                {
                    currentSeq++;
                    if (currentSeq > maxSeq)
                    {
                        maxSeq = currentSeq;
                        rowSeq = row;
                        colSeq = col;
                    }
                }
                else
                {
                    currentSeq = 1;
                }
            }
        }
        currentSeq = 1;

        //Col sequences
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                if (matrix[row, col] == matrix[row + 1, col])
                {
                    currentSeq++;
                    if (currentSeq > maxSeq)
                    {
                        maxSeq = currentSeq;
                        rowSeq = row;
                        colSeq = col;
                    }
                }
                else
                {
                    currentSeq = 1;
                }
            }
        }
        currentSeq = 1;

        //Diagonal sequences - left to right
        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                for (int i = row; i < matrix.GetLength(0) - 1; i++)
                {
                    for (int j = col; j < matrix.GetLength(1) - 1; j++)
                    {
                        if (matrix[i, j] == matrix[i + 1, j + 1])
                        {
                            currentSeq++;
                            if (currentSeq > maxSeq)
                            {
                                maxSeq = currentSeq;
                                rowSeq = i + 1;
                                colSeq = j + 1;
                            }
                            else
                            {
                                currentSeq = 1;
                            }
                        }
                    }
                }
                currentSeq = 1;
            }
        }

        //DIagonal sequences - right to left
        for (int i = 0; i < matrix.GetLength(0) - 1; i++)
        {
            for (int j = 1; j < matrix.GetLength(1); j++)
            {
                for (int row = i, col = j; row < matrix.GetLength(0) - 1 && col > 0; row++, col--)
                {
                    if (matrix[row, col] == matrix[row + 1, col - 1])
                    {
                        currentSeq++;
                    }
                    else
                    {
                        currentSeq = 1;
                    }

                    if (currentSeq > maxSeq)
                    {
                        maxSeq = currentSeq;
                        rowSeq = i + 1;
                        colSeq = j - 1;
                    }
                }
                currentSeq = 1;
            }
        }
     
        Console.WriteLine();
        Console.WriteLine();

        for (int i = 0; i < maxSeq; i++)
        {
            Console.Write(matrix[rowSeq, colSeq] + "  ");
        }
        Console.WriteLine();

    }
}