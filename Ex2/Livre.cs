using System;
namespace Ex2{

public class Livre : Publication
{
    public string ISBN { get; set; }
    public int NbPages { get; set; }

    public Livre(string designation, double prix, string isbn, int nbPages)
        : base(designation, prix)
    {
        ISBN = isbn;
        NbPages = nbPages;
    }

      public override void PublishDetails()
    {
        Console.WriteLine($"Le livre: {Designation}, ISBN: {ISBN}, NbPages: {NbPages}, Prix: {Prix} euro");
    }
}


}