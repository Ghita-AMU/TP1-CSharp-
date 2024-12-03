using System;
namespace Ex2{ 
public abstract class Publication
{
    
    public string Designation { get; set; }
    public double Prix { get; set; }

   
    public Publication(string designation, double prix)
    {
        Designation = designation;
        Prix = prix;
    }

   
    public abstract void PublishDetails();
}

}