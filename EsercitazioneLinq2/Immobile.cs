using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercitazioneLinq2
{
    internal class Immobile
    {
        public string codice { get; set; }
        public string indirizzo { get; set; }
        public int CAP { get; set; }
        public string citta { get; set; }
        public int superficie { get; set; }
        public string tipologia { get; set; }

        public Immobile(string codice, string indirizzo, int cAP, string citta, int superficie, string tipologia)
        {
            this.codice = codice;
            this.indirizzo = indirizzo;
            CAP = cAP;
            this.citta = citta;
            this.superficie = superficie;
            this.tipologia = tipologia;
        }

        public void Info()
        {
            Console.WriteLine($"{codice} | {indirizzo} | {CAP} | {citta} | {superficie} | {tipologia}");
        }
    }
}
