using System;
namespace Ex3{
    public class Disque : Article
{
   public string Label { get; set; }

  
    public Disque(string designation, double prix, string label)
        : base(designation, prix)
    {
        Label = label;
    }
    }
}