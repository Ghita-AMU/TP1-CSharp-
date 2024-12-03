using System;

namespace Ex3{

public class Article
{
    public string Designation { get; set; }
    public double Prix { get; set; }

    
    public Article(string designation, double prix)
    {
        Designation = designation;
        Prix = prix;
    }
}
}