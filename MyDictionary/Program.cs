using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionaryClass<int, string> product = new MyDictionaryClass<int, string>();
            product.Add(1, "Elma");
            product.Add(2, "Armut");
            product.Add(3, "Karpuz");
            product.Add(4, "Üzüm");
            product.Add(5, "Çilek");


            //Console.WriteLine(dictionary1.keysLength);

            for (int i = 0; i < product.keysLength; i++)
            {
                Console.WriteLine("Ürün Adı : " + product.Values[i] + "                  Barkod No : " + product.Keys[i]);
            }
        }
    }
}
