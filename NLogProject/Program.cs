using System;

namespace NLogProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to first NLog project.");
            addition ad = new addition();
            ad.Sum(50,100);
        }
    }
}
