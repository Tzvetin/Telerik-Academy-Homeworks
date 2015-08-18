using System;

class ComparingFloats
{
    static void Main()
    {
        double eps = 0.000001;
        double a = 5.3;
        double b = 6.01;
        Console.WriteLine("Comparing {0} and {1} -> {2}", a, b, Math.Abs(a - b) < eps);
        a = 5.00000001;
        b = 5.00000003;
        Console.WriteLine("Comparing {0} and {1} -> {2}", a, b, Math.Abs(a - b) < eps);
        a = 5.00000005;
        b = 5.00000001;
        Console.WriteLine("Comparing {0} and {1} -> {2}", a, b, Math.Abs(a - b) < eps);
        a = -0.0000007;
        b = 0.00000007;
        Console.WriteLine("Comparing {0} and {1} -> {2}", a, b, Math.Abs(a - b) < eps);
        a = -4.999999;
        b = -4.999998;
        Console.WriteLine("Comparing {0} and {1} -> {2}", a, b, Math.Abs(a - b) < eps);
        a = 4.999999;
        b = 4.999998;
        Console.WriteLine("Comparing {0} and {1} -> {2}", a, b, Math.Abs(a - b) < eps);

    }
}

