//syntax for methods

<Access Specifier><Return Type><Method Name>(Parameter List)
{
    Method Body
}

//two types
// 1.non Return - void
// 2.return type

namespace Datatypes
{
    class Program
    {
        static void Main(string[] args) 
        {
            Printer();
        } 
        //Access [static] [return type] Method Name
        public static void Printer()
        Console.WriteLine("Hi, Am from function")
        Console.ReadKey();
    }
}