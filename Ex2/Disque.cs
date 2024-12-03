using System;
namespace Ex2{

public class Disque : Publication
{
    public string Label { get; set; }

  
    public Disque(string designation, double prix, string label)
        : base(designation, prix)
    {
        Label = label;
    }

   
    public override void PublishDetails()
    {
        Console.WriteLine($"Le disque: {Designation}, Label: {Label}, Prix: {Prix} euro");
    }
}


}