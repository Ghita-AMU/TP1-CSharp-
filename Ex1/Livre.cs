using System;
namespace Ex1{
    public class Livre : Article, IRentable
{
    public string ISBN { get; set; }
    public int NbPages { get; set; }

    public Livre(string designation, double prix, string isbn, int nbPages) 
        : base(designation, prix)
    {
        ISBN = isbn;
        NbPages = nbPages;
    }

    public override void Acheter()
    {
        Console.WriteLine($"Le livre acheté : {Designation}" );
    }

    // Implémentation de la méthode CalculateRent
    public double CalculateRent()
    {
        return NbPages * 0.5; 
    }
}
}
