//CONSEGNA: usando la classe Product e i livelli di accesso (public, private), i costruttori, i metodi getter e setter, fare sì che:
// - Alla creazione di un nuovo prodotto il codice sia valorizzato con un numero random.
// - Il codice prodotto sia accessibile solo in lettura
// - Gli altri attributi siano accessibili sia in lettura che in scrittura

using CSHarpShop;

Product product_1 = new Product();

product_1.name = "Prodotto_1";

Console.WriteLine(product_1.name);

Console.WriteLine(product_1.code);

Console.WriteLine(product_1.ExtendedName());

product_1.price = 12;

Console.WriteLine(product_1.FullPrice());