namespace Datatypes
{
    class Program
    {
        static void Main(string[] args) 
        {
            Hashtable data = new Hashtable();
            data.Add(1,"Karthick");
            data.Add(2,"Max");
            data.Add(3, 12.4f);
            data.Add("A1",100);

            Console.WriteLine(data["A1"]);

            foreach(DictionaryEntry item in data)
            {
                Console.WriteLine($"{item.Key} : {item.Value}")
            }

            data.Remove(1); //delete by key 
            Console.WriteLine("Delete");
            foreach(DictionaryEntry item in data)
            {
                Console.WriteLine($"{item.Key} : {item.Value}")
            }
        }
    }
}