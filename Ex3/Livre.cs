using System;
namespace Ex3{
    public class Livre : Article
{
  public string ISBN { get; set; }
    public int NbPages { get; set; }

    public Livre(string designation, double prix, string isbn, int nbPages)
        : base(designation, prix)
    {
        ISBN = isbn;
        NbPages = nbPages;
    }

}
}