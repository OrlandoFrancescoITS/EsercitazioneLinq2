using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercitazioneLinq2
{
    internal class Box : Immobile
    {
        int postiAuto { get; set; }

        public Box(string codice, string indirizzo, int cAP, string citta, int superficie, string tipologia, int postiAuto) : base(codice, indirizzo, cAP, citta, superficie, tipologia)
        {
            this.codice = codice;
            this.indirizzo = indirizzo;
            CAP = cAP;
            this.citta = citta;
            this.superficie = superficie;
            this.tipologia = tipologia;
            this.postiAuto = postiAuto;
        }
        
    }
}
