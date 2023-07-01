using System;
using System.Collections.Generic;
namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //key ve value olarak bu değerler tanımlarınken hangi tipte olduklarını söylememiz gerkmekte
            //system.collection.generic altında tanımlanırlar
            Dictionary<int,string> kullanıcılar = new Dictionary<int, string>();

            kullanıcılar.Add(5,"OBK");
            kullanıcılar.Add(11,"AB");
            kullanıcılar.Add(22,"AEB");
            kullanıcılar.Add(13,"MEA");

            //Dizinin elemanlarına erişim
            System.Console.WriteLine("**** Elemanlara Erişim ****");
            System.Console.WriteLine(kullanıcılar[11]);
            foreach (var item in kullanıcılar)
            {
                System.Console.WriteLine(item);
            }

            //Count /verinin sayısnı ölçmek için kullanıyorduk
            System.Console.WriteLine("**** Count ****");
            System.Console.WriteLine(kullanıcılar.Count);

            //Contains
            System.Console.WriteLine("**** Contains ****");
            System.Console.WriteLine(kullanıcılar.ContainsKey(11));
            System.Console.WriteLine(kullanıcılar.ContainsValue("Osman Batuhan Kalkan"));
            //bu iki değer false dönecektir çünkü yoklar, belirtilen karakterin bu dize içinde olup olmadığını belirtir.

            //Remove
            System.Console.WriteLine("**** Remove ****");
            kullanıcılar.Remove(11);
            foreach (var item in kullanıcılar)
            {
                System.Console.WriteLine(item);
                //System.Console.WriteLine(item.Value);
                //System.Console.WriteLine(item.Key);
                //olarak sadece anahyar yada sadece değer çağrılabilir
            }
            //Keys
            System.Console.WriteLine("**** KEYS ****");
            foreach (var item in kullanıcılar.Keys)
            {
                System.Console.WriteLine(item);
            }
            //Values
            System.Console.WriteLine("**** VALUES ****");
            foreach (var item in kullanıcılar.Values)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}