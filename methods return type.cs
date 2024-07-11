
namespace Datatypes
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine(Cal());
        } 
        //Access [static] [return type] Method Name
        //return type - int float boolean
        //non return type - void
        
        public static int Cal()
        {
            int a = 30;
            int b = 20;
            int c = a + b;
            return c;

            float a = 30.5f;
            float b = 20.3f;
            float c = a + b;
            return c;
        }
        
        
    }
}