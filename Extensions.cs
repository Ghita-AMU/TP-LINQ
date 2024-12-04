using System;
using System.Linq;
using System.Collections.Generic;


public static class Extensions
{
    public static void AfficherTous(this List<ArticleType> articles)
    {
        foreach (var article in articles)
        {
            Console.WriteLine($"Nom : {article.Nom}, Prix : {article.Prix} euro, Quantité : {article.Quantite}, Type : {article.Type}");
        }
    }
    }