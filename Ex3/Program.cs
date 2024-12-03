using System;

namespace Ex3{


class Program
{
    static void Main(string[] args)
    {
        Article livre = new Livre("C# ", 50.0, "97890", 150);
        Article disque = new Disque("Video", 30.0, "Action");

        // Delegués
        DiscountStrategy discount1 = FixedDiscount;    
        DiscountStrategy discount2 = TypeDiscount; 
        
        // appliquer remise
    static void ApplyDiscount(Article article, DiscountStrategy discountStrategy)
    {
        double remise = discountStrategy(article); 
        double prixFinal = article.Prix - remise; 
        Console.WriteLine($"L'article: {article.Designation}, le prix initial: {article.Prix}euro, La remise: {remise}euro, Prix après remise: {prixFinal}euro");
    }

        // Application des remises 
        ApplyDiscount(livre, discount1);  
        ApplyDiscount(disque, discount2); 
    }

    //remise de 10%
    public static double FixedDiscount(Article article)
    {
        return article.Prix * 0.10;  
    }

    
    public static double TypeDiscount(Article article)
    {
        if (article is Livre)
        {
            return article.Prix * 0.15; 
        }
        else if (article is Disque)
        {
            return article.Prix * 0.20; 
        }
        return 0;  

    
    }
}
}
