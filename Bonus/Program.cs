//CONSEGNA: usando la classe Product e i livelli di accesso (public, private), i costruttori, i metodi getter e setter, fare sì che:
// - Alla creazione di un nuovo prodotto il codice sia valorizzato con un numero random.
// - Il codice prodotto sia accessibile solo in lettura
// - Gli altri attributi siano accessibili sia in lettura che in scrittura

using Bonus;
//Viene usato l'encoding per vedere correttamente il prezzo in console (€)
Console.OutputEncoding = System.Text.Encoding.UTF8;

Product product_1 = new Product();

product_1.Name = "Pallone";
product_1.Description = "Costruzione con cuciture ad ottima aderenza e minore assorbimento dell'acqua";
product_1.Price = 20.54;

Product product_2 = new Product("Mini_Proiettore", 79.99);
product_2.Description = "Un cinema privato da portare con sé";

//BONUS: Usando una List, dichiarate una lista dei prodotti di un negozio e inseriteci al suo interno qualche prodotto che vi aspettate di trovare nel negozio.
//Stampate poi l’elenco dei vostri prodotti che avete previsto nel negozio.

List<Product> products = new List<Product>();

products.Add(product_1);
products.Add(product_2);

Product product_3 = new Product("SmartPhone");
products.Add(product_3);

Product product_4 = new Product("Cuffie_Wireless");
products.Add(product_4);

Product product_5 = new Product("PowerBank");
products.Add(product_5);

for (int i = 0; i < products.Count; i++)
{
    products[i].Print(i + 1);
}