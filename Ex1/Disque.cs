using System;
namespace Ex1{
public class Disque : Article, IRentable
{
    public string Label { get; set; }

    public Disque(string designation, double prix, string label) 
        : base(designation, prix)
    {
        Label = label;
    }

    public override void Acheter()
    {
        Console.WriteLine($"Disque acheté : {Designation} et Label : {Label}");
    }

    
    public double CalculateRent()
    {
        return 10.0; 
    }
    }
}
