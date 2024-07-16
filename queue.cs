
//Queue<int> queue = new Queue
namespace Datatypes
{
    class Program
    {
        static void Main(string[] args) 
        {
            Queue<int> data = new Queue<int>();
            data.Enqueue(10);
            data.Enqueue(20);
            data.Enqueue(30);
            data.Enqueue(40);


            //Console.WriteLine(data.Count());
            //Console.WriteLine(data.Peek());

            //data.Dequeue();
            //Console.WriteLine(data.Peek());

            while(data.count > 0)
            {
                Console.WriteLine(data.Dequeue);
            }




        }
    }
}