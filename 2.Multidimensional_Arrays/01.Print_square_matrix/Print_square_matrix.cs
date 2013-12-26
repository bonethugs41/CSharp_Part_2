//Write a program that fills and prints a matrix of size (n, n) in four different types.


using System;

class PrintMatrix
{
    static void Main(string[] args)
    {
        Console.Title = "Square matrix";
        int n;
        while (true)
        {
            Console.Write(" 0 < N < 21 \nInput size N of matrix: ");
            string check = Console.ReadLine();
            bool result = int.TryParse(check, out n);
            if (result == true && n > 0 && n < 21)
            {
                break;
            }
        }
        int[,] matrixA = new int[n, n];
        int[,] matrixB = new int[n, n];
        int[,] matrixC = new int[n, n];
        int[,] matrixD = new int[n, n];
        Console.WriteLine();
        
        //Type A
        Console.WriteLine("A:");
        int startNumber = 1;
        for (int col = 0; col < matrixA.GetLength(1); col++)
        {
            for (int row = 0; row < matrixA.GetLength(0); row++)
            {
                matrixA[row, col] = startNumber;
                startNumber++;
            }
        }
        for (int row = 0; row < matrixA.GetLength(1); row++)                                //Cycle for printing matrixA
        {
            for (int col = 0; col < matrixA.GetLength(0); col++)
            {
                Console.Write("{0, -4}", matrixA[row, col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
       
        //Type B
        Console.WriteLine("B:");
        startNumber = 1;
        int tempNumber = 0;
        for (int col = 0; col < matrixB.GetLength(1); col++)
        {
            if (col % 2 == 0)
            {
                for (int row = 0; row < matrixB.GetLength(0); row++)
                {
                    matrixB[row, col] = startNumber;
                    startNumber++;
                }
                tempNumber = startNumber + n - 1;
            }
            else
            {
                startNumber = tempNumber + 1;
                for (int row = 0; row < matrixB.GetLength(0); row++)
                {
                    matrixB[row, col] = tempNumber;
                    tempNumber--;
                }
            }
        }

        for (int row = 0; row < matrixB.GetLength(1); row++)                            //Cycle for printing matrixB
        {
            for (int col = 0; col < matrixB.GetLength(0); col++)
            {
                Console.Write("{0, -4}", matrixB[row, col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        //Type C
        Console.WriteLine("C:");
        int rowC = n - 1;
        int colC = 0;
        startNumber = 1;
        for (int i = 1; i < n * n; i++)
        {
            matrixC[rowC, colC] = startNumber;
            rowC++;
            colC++;
            startNumber++;
            if (rowC == n || colC == n)
            {
                rowC--;
                if (colC == n)
                {
                    rowC--;
                    colC--;
                }
                while (rowC - 1 >= 0 && colC - 1 >= 0)
                {
                    rowC--;
                    colC--;
                }
            }
        }
        matrixC[0, n - 1] = n * n;

        for (int row = 0; row < matrixC.GetLength(1); row++)                            //Cycle for printing matrixC
        {
            for (int col = 0; col < matrixC.GetLength(0); col++)
            {
                Console.Write("{0, -4}", matrixC[row, col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        //Type D
        Console.WriteLine("D:");
        int rowD = 0;
        int colD = 0;
        string direction = "right";
        int maxRotations = n * n;

        for (int i = 1; i <= maxRotations; i++)
        {
            if (direction == "right" && (colD > n - 1 || matrixD[rowD, colD] != 0))
            {
                direction = "down";
                colD--;
                rowD++;
            }
            if (direction == "down" && (rowD > n - 1 || matrixD[rowD, colD] != 0))
            {
                direction = "left";
                rowD--;
                colD--;
            }
            if (direction == "left" && (colD < 0 || matrixD[rowD, colD] != 0))
            {
                direction = "up";
                colD++;
                rowD--;
            }

            if (direction == "up" && rowD < 0 || matrixD[rowD, colD] != 0)
            {
                direction = "right";
                rowD++;
                colD++;
            }

            matrixD[rowD, colD] = i;

            if (direction == "right")
            {
                colD++;
            }
            if (direction == "down")
            {
                rowD++;
            }
            if (direction == "left")
            {
                colD--;
            }
            if (direction == "up")
            {
                rowD--;
            }
        }

        for (int row = 0; row < matrixD.GetLength(1); row++)                            //Cycle for printing matrixD
        {
            for (int col = 0; col < matrixD.GetLength(0); col++)
            {
                Console.Write("{0, -4}", matrixD[row, col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}