namespace Datatypes
{
    class Program
    {
        static void Main(string[] args)
        {   
            string firstName = "lokesh";
            string lastName = "S";

            Console.WriteLine(firstName + "" + lastName);

            //uppercase and lowercase
            Console.WriteLine(firstName.ToUpper + "" + lastName);
            Console.WriteLine(firstName.ToLower + "" + lastName);


            //trim removing unwanted spaces

            string firstName = "lokesh";
            string lastName = "S";
            string fullName = string.Concat(" "+firstName,lastName + "");
            Console.WriteLine(fullName.Trim());

            //substring
            string firstName = "lokesh";
            string lastName = "S";
            Console.WriteLine(firstName.Substring(2));

        }
    }
}