using System;
namespace Ex1{
public abstract class Article
{

    public string Designation;
    public double Prix;

    // Constructeur
    public Article(string designation, double prix)
    {
        Designation = designation;
        Prix = prix;

    }

  
    public abstract void Acheter();
    

}
}