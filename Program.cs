using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.IO;
using TP;

class Program
{
    static void Main(string[] args)
 {
    

Console.WriteLine("------Etape 2.1------");

List<ArticleType> articles = new List<ArticleType>
{
    new ArticleType("Pomme", 2.5, 50, TypeArticle.Alimentaire),
    new ArticleType("Savon", 3.2, 30, TypeArticle.Droguerie),
    new ArticleType("veste", 15.0, 20, TypeArticle.Habillement)
};

// Lister les articles appartenant au type ALIMENTAIRE
var articlesAlimentaires = articles.Where(a => a.Type == TypeArticle.Alimentaire);
foreach (var article in articlesAlimentaires)
{
    Console.WriteLine($"-Les articles alimentaires sont : {article.Nom}");
}

//Trier les articles par prix décroissant

var articlesTri = articles.OrderByDescending(a => a.Prix);
Console.WriteLine("- Les articles triés par ordre décroissant sont :");
foreach (var article in articlesTri)
{
    Console.WriteLine($"{article.Nom}, {article.Prix} euro");
}

//Calcul du stock total
int stockT = articles.Sum(s => s.Quantite);
Console.WriteLine($"- Stock total : {stockT}");

Console.WriteLine("------Etape 2.2------");

// creation d une liste contenant les objets Article et d'autres

var listMix = new List<object>
{
      new ArticleType("Pomme", 2.5, 50, TypeArticle.Alimentaire),
    new ArticleType("Savon", 3.2, 30, TypeArticle.Droguerie),
    new ArticleType("veste", 15.0, 20, TypeArticle.Habillement),
    "shirt", 15.0,
    
};

// extraire uniquement les articles typés 

var onlyArticles = listMix .OfType<ArticleType>();
Console.WriteLine("- Les articles typés sont :");
foreach (var article in onlyArticles)
{
    Console.WriteLine($"{article.Nom} - {article.Prix} euro");
}


Console.WriteLine("------Etape 2.3------");

var vue= articles.Select(v => new { v.Nom, v.Prix });
Console.WriteLine("Vue simplifiée des articles est:");
foreach (var article in vue)
{
    Console.WriteLine($"Nom : {article.Nom}, Prix : {article.Prix} euro");
}

Console.WriteLine("------Etape 3.1------");

Console.WriteLine("Tous les articles sont les suivants:");
articles.AfficherTous();
 


Console.WriteLine("------Etape 3.2------");
double valeurTotaleStock = articles.Sum(s => s.Prix * s.Quantite);
Console.WriteLine($"La valeur totale du stock est : {valeurTotaleStock} euro");


Console.WriteLine("------Etape 4.1------");


string json = JsonSerializer.Serialize(articles);
File.WriteAllText("Article.json", json);
Console.WriteLine(" La liste d'articles a été bien exportée vers le fichier JSON.");



Console.WriteLine("------Etape 4.2------");

// Désérialisation JSON : Lecture du fichier et conversion en objets
string jsonFromFile = File.ReadAllText("Article.json");
var articleJson = JsonSerializer.Deserialize<List<ArticleType>>(jsonFromFile);

Console.WriteLine("Les articles chargés depuis le fichier JSON sont:");
foreach (var article in articles)
{
    Console.WriteLine($"Nom : {article.Nom}, Prix : {article.Prix} euro, Quantité : {article.Quantite}, Type : {article.Type}");
}


}
}