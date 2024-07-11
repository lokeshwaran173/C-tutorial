namespace Datatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            int c = a+b;
            Console.WriteLine("Integer"+c);

            float num1 = 1.23f;
            float num2 = 1.50f;
            float num3 = num1+num2;
            Console.WriteLine("Float"+num3);

            long a = 100000200;
            long b = 20;
            long c = a+b;
            Console.WriteLine("Long"+c);

            double num4 = 3.1415;
            double num5 = 5.1;
            double num6 = num4 / num5;
            Console.WriteLine(num6);

        }
    }
}