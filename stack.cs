//stack<int> stack = new Stack

namespace Datatypes
{
    class Program
    {
        static void Main(string[] args) 
        {
            stackalloc<int> stack = new Stack<int>()
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Push(40);

            //Console.WriteLine(stack.Count());
            //Console.WriteLine(stack.Peek());
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Peek());

            while(stackalloc.Count() > 0)
            {
                Console.WriteLine(stack.Pop());
            }
        }      
    }
}