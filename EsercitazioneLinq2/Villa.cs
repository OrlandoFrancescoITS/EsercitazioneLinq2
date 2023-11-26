using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercitazioneLinq2
{
    internal class Villa: Appartamento
    {
        public string codice { get; set; }
        public string indirizzo { get; set; }
        public int CAP { get; set; }
        public string citta { get; set; }
        public int superficie { get; set; }
        public string tipologia { get; set; }
        public int numeroVani { get; set; }
        public int numeroBagni { get; set; }
        public int dimensioniGiardino { get; set; }

        public Villa(string codice, string indirizzo, int cAP, string citta, int superficie, string tipologia, int numeroVani, int numeroBagni, int dimendioniGiardino) : base(codice, indirizzo, cAP, citta, superficie, tipologia, numeroVani, numeroBagni)
        {
            this.codice = codice;
            this.indirizzo = indirizzo;
            this.CAP = cAP;
            this.citta = citta;
            this.superficie = superficie;
            this.tipologia = tipologia;
            this.numeroVani = numeroVani;
            this.numeroBagni = numeroBagni;
            this.dimensioniGiardino = dimendioniGiardino;
        }
    }
}
