//CONSEGNA: usando la classe Product e i livelli di accesso (public, private), i costruttori, i metodi getter e setter, fare sì che:
// - Alla creazione di un nuovo prodotto il codice sia valorizzato con un numero random.
// - Il codice prodotto sia accessibile solo in lettura
// - Gli altri attributi siano accessibili sia in lettura che in scrittura

using Bonus;
//Viene usato l'encoding per vedere correttamente il prezzo in console (€)
Console.OutputEncoding = System.Text.Encoding.UTF8;

Product product_1 = new Product();

product_1.name = "Pallone";
product_1.description = "Costruzione con cuciture ad ottima aderenza e minore assorbimento dell'acqua";
product_1.price = 20.54;
product_1.Print(1);

Product product_2 = new Product("Mini_Proiettore", 79.99);
product_2.description = "Un cinema privato da portare con sé";
product_2.NoIvaPrint(2);