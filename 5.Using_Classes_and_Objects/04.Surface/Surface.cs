//Write methods that calculate the surface of a triangle by given:
//Side and an altitude to it; Three sides; Two sides and an angle between them. Use System.Math.


using System;

class SurfaceOfTriangle
{
    static int IntegerCheck(string check)                                        //Check if the input information is integer
    {
        while (true)
        {
            int integer;
            bool result = int.TryParse(check, out integer);
            if (result == true && integer > 0)
            {
                return integer;
            }
            else
            {
                Console.Write("Invalid integer, try again: ");
                check = Console.ReadLine();
            }
        }
    }

    static double DoubleCheck(string check)                                     //Check if the input information is integer
    {
        while (true)
        {
            double integer;
            bool result = double.TryParse(check, out integer);
            if (result == true && integer > 0)
            {
                return integer;
            }
            else
            {
                Console.Write("Invalid value, try again: ");
                check = Console.ReadLine();
            }
        }
    }

    static double SideAndAltitude(double side, double altitude)
    {
        double surface = (side * altitude) / 2;
        return surface;
    }

    static double ThreeSides(double sideA, double sideB, double sideC)
    {
        double i = (sideA + sideB + sideC) / 2.0;
        double surface = Math.Round(Math.Sqrt(i * (i - sideA) * (i - sideB) * (i - sideC)));
        return surface;
    }

    static double TwoSidesAndAnAngle(double sideA, double sideB, double angle)
    {
        double surface = (sideA * sideB * Math.Sin(angle)) / 2;
        return surface;
    }

    static void Main()
    {
        Console.Title = "Surface of triangle";
        Console.WriteLine("Choose wich task to solve:");
        Console.WriteLine(" - Enter 1 to calculate the surface of triangle by given side and an altitude to it");
        Console.WriteLine(" - Enter 2 to calculate the surface of triangle by given three sides");
        Console.WriteLine(" - Enter 3 to calculate the surface of triangle by given two sides and an angle between them");
        int choise;
        while (true)
        {
            choise = IntegerCheck(Console.ReadLine());
            if (choise == 1 || choise == 2 || choise == 3)
            {
                break;
            }
            else
            {
                Console.Write("Choose 1, 2 or 3: ");
            }
        }
        switch (choise)
        {
            case 1:
                {
                    Console.Write("Enter value for the side: ");
                    double side = DoubleCheck(Console.ReadLine());
                    Console.Write("Enter value for the altitude: ");
                    double altitude = DoubleCheck(Console.ReadLine());
                    Console.WriteLine("The surface is: " + SideAndAltitude(side, altitude));
                    break;
                }
            case 2:
                {
                    Console.Write("Enter value for side a: ");
                    double sideA = DoubleCheck(Console.ReadLine());
                    Console.Write("Enter value for side b: ");
                    double sideB = DoubleCheck(Console.ReadLine());
                    Console.Write("Enter value for side c: ");
                    double sideC = DoubleCheck(Console.ReadLine());
                    Console.WriteLine("The surface is: " + ThreeSides(sideA, sideB, sideC));
                    break;
                }
            case 3:
                {
                    Console.Write("Enter value for side a: ");
                    double sideA = DoubleCheck(Console.ReadLine());
                    Console.Write("Enter value for side b: ");
                    double sideB = DoubleCheck(Console.ReadLine());
                    Console.Write("Enter value for angle in radians: ");
                    double angle = DoubleCheck(Console.ReadLine());
                    Console.WriteLine("The surface is: " + TwoSidesAndAnAngle(sideA, sideB, angle));
                    break;
                }

        }

    }
}

//Note that the angle is measured in radians!!!
//90 [degrees] = 1,5707963267948966192313216916398 [rads]