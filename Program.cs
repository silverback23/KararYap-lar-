using System;

namespace kararYapıları
{
    class Program
    {
        static void Main(string[] args)
        {
            int time =DateTime.Now.Hour;
            if(time>=6&&time<=11)
                Console.WriteLine("Günaydın");
            else if(time>=18)
                Console.WriteLine("İyi günler");
             else
                Console.WriteLine("İyi Geceler");

            string sonuc=time<=18 ? "iyi günler" :"iyi geceler?";
            
        }
    }
}
