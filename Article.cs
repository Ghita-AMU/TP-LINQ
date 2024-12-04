using System;
namespace TP{
public class Article
{

    public string Nom {get ; set;}
    public double Prix {get ; set;}
    public int Quantite {get ; set;}

    // Constructeur
    public Article(string nom, double prix, int quantite)
    {
        Nom = nom;
        Prix = prix;
        Quantite= quantite;
    }

    // Méthode afficher
    public void Afficher()
    {
        Console.WriteLine($"Nom: {Nom}, Prix: {Prix}euro, Quantité: {Quantite}");
    }

     // Méthode Ajouter
    public void Ajouter(int quantiteAjoutee)
    {
        if (quantiteAjoutee > 0)
        {
            Quantite = Quantite+quantiteAjoutee;
            Console.WriteLine($"{quantiteAjoutee} unité(s) ajoutée(s). Nouvelle quantité: {Quantite}");
        }
        else
        {
            Console.WriteLine("la quantité est invalide , doit être positive");
        }
    }

    // Méthode Retirer
    public void Retirer(int quantitéRetirée)
    {
        if (quantitéRetirée > 0 && quantitéRetirée <= Quantite)
        {
            Quantite -= quantitéRetirée;
            Console.WriteLine($"{quantitéRetirée} unité(s) retirée(s). Nouvelle quantité: {Quantite}");
        }
        else
        {
            Console.WriteLine("La quantité à retirer est invalide");
         }

    }
}
}
