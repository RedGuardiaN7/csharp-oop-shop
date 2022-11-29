//CONSEGNA: Nel progetto CSharpShop , creare la classe Prodotto che gestisce i prodotti del vostro shop.
//Caratteristiche: codice, nome, descrizione, prezzo, iva

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Bonus
{
    public class Product
    {

        //Viene utilizzato "public" ma assieme ai setter e getter auto-implementati, che rendono le caratteristiche private, ma peremttono di usare i getter e i setter.
        public string code { get; }                    //Il codice prodotto è accessibile solo in lettura

        public string name { get; set; }

        public string description { get; set; }

        public double price { get; set; }

        public double iva { get; set; }

        //Il codice del prodotto viene generato casualmente

        //------------ COSTRUTTORI ------------ //

        //Costruttore di default
        public Product()
        {
            Random GeneratorRandomNumber = new Random();

            int RandomNumber = GeneratorRandomNumber.Next(0, 999999);

            string PaddedCode = RandomNumber.ToString("D8");          //BONUS: metodo che restituisca il codice con un pad left di 0 per arrivare a 8 caratteri

            code = PaddedCode;
        }
        //Costruttore con nome e prezzo

        public Product(string name, double price)
        {
            Random GeneratorRandomNumber = new Random();
            int RandomNumber = GeneratorRandomNumber.Next(0, 999999);
            string PaddedCode = RandomNumber.ToString("D8");
            code = PaddedCode;

            this.name = name;
            this.price = price;
        }
        //---------- Definizioni dei metodi ---------- //

        //Metodo che calcola l'iva del prodotto e ritorna il prezzo pieno
        public double FullPrice()
        {
            iva = Math.Round(0.22 * price);
            double FullPrice = price + iva;
            FullPrice = Math.Round(FullPrice, 2);
            return FullPrice;
        }

        //Metodo che ritorna il nome esteso del prodotto (codice + nome)

        public string ExtendedName()
        {
            string output = code + name;
            return output;
        }

        //Metodo che stampa a video tutte le informazioni del prodotto (con l'IVA)
        public void Print(int num)
        {
            Console.WriteLine("-------------- Prodotto " + num + " --------------");
            Console.WriteLine();
            Console.WriteLine("Nome: " + name);
            Console.WriteLine();
            Console.WriteLine("Codice: " + code);
            Console.WriteLine();
            Console.WriteLine("Descrizione: " + description);
            Console.WriteLine();
            Console.WriteLine("Il nome esteso del prodotto è: " + this.ExtendedName());
            Console.WriteLine();

            double FullPrice = this.FullPrice();

            Console.WriteLine("Il prezzo del prodotto è di: " + FullPrice + "€ (senza IVA: " + this.price + "€)");
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine();

        }

        //Metodo che stampa a video tutte le informazioni del prodotto (senza l'IVA)
        public void NoIvaPrint(int num)
        {
            Console.WriteLine("-------------- Prodotto " + num + " --------------");
            Console.WriteLine();
            Console.WriteLine("Nome: " + name);
            Console.WriteLine();
            Console.WriteLine("Codice: " + code);
            Console.WriteLine();
            Console.WriteLine("Descrizione: " + description);
            Console.WriteLine();
            Console.WriteLine("Il nome esteso del prodotto è: " + this.ExtendedName());
            Console.WriteLine();
            Console.WriteLine("Il prezzo del prodotto è di: " + this.price + "€ (senza IVA)");
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine();

        }
    }

}
