namespace Datatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //indexof 
            //isnullorwhitespace - null or blank
            string firstName = "lokesh";
            string lastName = "S";
            string fullName = string.Concat("" +firstName,lastName);
            bool data = string.IsNullOrWhiteSpace(fullName);
            Console.WriteLine(data);



        }
    }
}