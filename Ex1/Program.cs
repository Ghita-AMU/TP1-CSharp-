using System;
using System.Runtime.InteropServices;

namespace Ex1{
class Program
{
    static void Main(string[] args)
    {
        List<IRentable> articles = new List<IRentable>
        {
            new Livre("Harry Potter", 20.0, "123459", 35),
            new Disque("Ammor", 15.0, "Music"),
            new Video("Video", 10.0, 150)
        };

        foreach (IRentable article in articles)
        {ComDefaultInterfaceAttribute
            Console.WriteLine($"Le coût de location est: {article.CalculateRent()} euro");
        }
    }
}
}