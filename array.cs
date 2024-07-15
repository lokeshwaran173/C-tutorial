int[] num = {}

namespace Datatypes
{
    class Program
    {
        static void Main(string[] args) 
        {
            int[] num = new int[5];
            num[0] = 1;
            num[1] = 2
            num[2] = 3;
            num[3] = 4;
            num[4] = 5;

            //for
            for (int i =0; i< num.Length;i++)
            {
                Console.WriteLine(num[i]);
            }

            foreach(int i in num)
            {
                Console.WriteLine(i);
            }
        }
    }
}