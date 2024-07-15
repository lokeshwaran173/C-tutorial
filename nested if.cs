namespace Datatypes
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Enter your age");
            string ageString = Console.ReadLine();
            int age;
            bool result = int.TryParse(ageString, out age);

            if(result)
            {
                if(age>10)
                {
                    if(age>18)
                    {
                        Console.WriteLine("Permission to enter a movie");
                    }
                Console.WriteLine("Permission to Enter Shopping");
                Console.WriteLine("Permission to Enter Mall");

                }
                else
                {
                    Console.WriteLine("Permission Denied");
                }   
            }
            else
            {
                Console.WriteLine("Please enter your valid age");

            }


        }
    }
}