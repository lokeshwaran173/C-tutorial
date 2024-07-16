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

            //Dictionary<key,value> dataBook = new Dictionary<key,value>();
            Dictionary<int,string> dataBook = new Dictionary<int,string>();
            dataBook.Add(1,"Sam");
            dataBook.Add(2,"Max");
            dataBook.Add("A1","Bule");

            for(int i =0;i<dataBook.Count; i++)
            {
                Console.WriteLine($"{dataBook.Keys.ElementAt(i)} : {dataBook.Values.ElementAt(i)}");
            }
            dataBook.Remove(11);
            Console.WriteLine("-------------------------");
            for(int i =0;i<dataBook.Count; i++)
            {
                Console.WriteLine($"{dataBook.Keys.ElementAt(i)} : {dataBook.Values.ElementAt(i)}");
            }

                
        }
    }
}
