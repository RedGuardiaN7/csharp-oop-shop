//CONSEGNA: usando la classe Product e i livelli di accesso (public, private), i costruttori, i metodi getter e setter, fare sì che:
// - Alla creazione di un nuovo prodotto il codice sia valorizzato con un numero random.
// - Il codice prodotto sia accessibile solo in lettura
// - Gli altri attributi siano accessibili sia in lettura che in scrittura

using CSHarpShop;

Random GeneratorRandomNumber = new Random();

int RandomNumber = GeneratorRandomNumber.Next(0, 99999999);

Product product_1 = new Product();

product_1.name = "Prova!";

Console.WriteLine(product_1.name);