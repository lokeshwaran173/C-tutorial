namespace Datatypes
{
    class Program
    {
        static void Main(string[] args)
        {   
            //concatenation
            string name = "Karthik";
            int age = 25;
            string location = "Tamil Nadu";

            Console.WriteLine("Hi am " + name +"my age is " + age+ "from" + location);

            Console.WriteLine("Hi am {0} my age is {1} from {2}",name,age,location);

            Console.WriteLine($"Hi am {name} \n my age is {age} from {location}");

            Console.WriteLine(@"Hi am " + name +"my age is " + age+ "from" + location);
            


        }
    }
}