namespace Datatypes
{
    class Program
    {
        static void Main(string[] args) 
        {
            int num = 0;
            while(num < 10)
            {
                Console.WriteLine("Do While");
                num ++;
            }
            int num2 = 0;
            do
            {
                Console.WriteLine(num2);
                num2++;
            }while (num2>10);
        }
    }
}