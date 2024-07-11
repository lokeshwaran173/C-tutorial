namespace Datatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Two number");
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            int num1 = Int32.Parse(a);
            int num2 = Int32.Parse(b);
            int c = num1+num2;
            
            Console.WriteLine(c);




            int a = 10;
            Console.WriteLine(a);
            Console.WriteLine(a.GetType());
            string data = a.ToString();
            Console.WriteLine(data);
            Console.WriteLine(data.GetType);
            
            int a = 10;
            Console.WriteLine(a);
            Console.WriteLine(a.GetType());
            string data = a.ToString();
            Console.WriteLine(data);
            Console.WriteLine(data.GetType);




            /*explicit conversion(large to small)
            float num = 3.1415f;
            int a = (int)num;
            Console.WriteLine(a);

            //implicit conversion(small to large)
            int b = 10;
            long num1 =(b);
            Console.WriteLine(num1);
            Console.WriteLine(num1.GetType());*/



        }
    }
}