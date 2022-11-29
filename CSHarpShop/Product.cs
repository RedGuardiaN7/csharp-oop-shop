//CONSEGNA: Nel progetto CSharpShop , creare la classe Prodotto che gestisce i prodotti del vostro shop.
//Caratteristiche: codice, nome, descrizione, prezzo, iva

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHarpShop
{
    public class Product
    {

    //Viene utilizzato "public" ma assieme ai setter e getter auto-implementati, che rendono le caratteristiche private, ma peremttono di usare i getter e i setter.
        public int code { get; set; }

        public string name { get; }

        public string description { get; set; }

        public int price { get; set; }

        public int iva { get; set; }




    }
}
