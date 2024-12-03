using System;

namespace Ex1{
    public class Video : Article, IRentable
{
    public int Duree { get; set; } 
    public Video(string designation, double prix, int duree) 
        : base(designation, prix)
    {
        Duree = duree;
    }

    public override void Acheter()
    {
        Console.WriteLine($"la vidéo achetée : {Designation}");
    }

   
    public double CalculateRent()
    {
        return Duree * 0.5; 
    }
}
}
