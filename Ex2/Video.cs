using System;
namespace Ex2{

public class Video : Publication
{
    public int Duree { get; set; } 
   
    public Video(string designation, double prix, int duree)
        : base(designation, prix)
    {
        Duree = duree;
    }

      public override void PublishDetails()
    {
        Console.WriteLine($"La vidéo: {Designation}, Durée: {Duree} , Prix: {Prix} euro");
    }
}


}