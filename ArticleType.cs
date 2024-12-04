using System;

public class ArticleType
{
    public string Nom {get ; set;}
    public double Prix {get ; set;}
    public int Quantite {get ; set;}
    public TypeArticle Type {get ; set;}

    // Constructeur
    public ArticleType(string nom, double prix, int quantite, TypeArticle type)
    {
        Nom = nom;
        Prix = prix;
        Quantite = quantite;
        Type = type;
    }

    // Méthode afficher
    public void Afficher()
    {
        Console.WriteLine($"Nom: {Nom}, Prix: {Prix}euro, Quantité: {Quantite}, TypeArticle: {Type}");
    }

    //Méthode modifier 
    public void ModifierQuantite(int nouvelleQuantite)
{
    int ancienneQuantite = Quantite;  
    Quantite = nouvelleQuantite;     

    Console.WriteLine($"L'ancienne quantité de l'article '{Nom}' était : {ancienneQuantite}. " +
                      $"La nouvelle quantité est : {Quantite}.");
}

}
