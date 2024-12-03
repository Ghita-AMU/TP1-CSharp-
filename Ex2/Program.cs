using System;
namespace Ex2{

class Program
{
    static void Main()
    {
    
        List<Publication> publications = new List<Publication>
        {
            new Livre("Antigone", 28.0, "9790", 150),
            new Disque("Action", 20.0, "Disque 2024"),
            new Video("Video", 10.0, 18)
        };

        foreach (Publication publication in publications)
        {
            publication.PublishDetails();  
            
        }
    }

}
}