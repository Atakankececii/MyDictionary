using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            _MyDictionary<int, string> items = new _MyDictionary<int, string>();
            items.Add(1,"Kalem");
            items.Add(2, "Bilgisayar");
            items.Add(3, "Masa");
            items.Add(4, "Klavye");
            items.Add(5, "Mouse");
            items.Add(6, "Kitap");
            items.Add(7, "Telefon");


            Console.WriteLine("Listedeki eleman sayısı : " + items.Count);

            for (int i = 0; i <items.Count; i++)
            {
                Console.WriteLine(items.Keys);

            }

            foreach (var name in items.Values)
            {
                Console.WriteLine(name);
            }

        }
    }
}
