using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            MyLİst<string> isimler = new MyLİst<string>();
            isimler.Add("Sefa");
            

            Console.WriteLine(isimler.Length);
        }
    }
}
