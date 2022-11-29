//CONSEGNA: Nel progetto CSharpShop , creare la classe Prodotto che gestisce i prodotti del vostro shop.
//Caratteristiche: codice, nome, descrizione, prezzo, iva

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CSHarpShop
{
    public class Product
    {

    //Viene utilizzato "public" ma assieme ai setter e getter auto-implementati, che rendono le caratteristiche private, ma peremttono di usare i getter e i setter.
        public int code { get; }                    //Il codice prodotto è accessibile solo in lettura

        public string name { get; set; }

        public string description { get; set; }

        public double price { get; set; }

        public double iva { get; set; }

        //Il codice del prodotto viene generato casualmente

        public Product()
        {
            Random GeneratorRandomNumber = new Random();

            int RandomNumber = GeneratorRandomNumber.Next(0, 99999999);

            code = RandomNumber;
        }

        //---------- Definizioni delle funzioni ----------

        //Funzione che calcola l'iva del prodotto e ritorna il prezzo pieno
        public double FullPrice()
        {
            iva = (0.22 * price);
            iva = Math.Round(iva, 2);
            price = price + iva;
            price = Math.Round(price, 2);
            return price;
        }

        //Funzione che ritorna il nome esteso del prodotto (codice + nome)

        public string ExtendedName()
        {
            string output = code + name;
            return output;
        }

    }
}
