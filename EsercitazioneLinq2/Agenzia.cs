using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercitazioneLinq2
{
    internal class Agenzia
    {
        public List<Immobile> listaImmobili { get; set; } = new List<Immobile>();

        public void cerca(string codice)
        {
            Immobile risultato = listaImmobili.Find(x => x.codice.Contains(codice));
            if (risultato != null)
            {
                Console.WriteLine($"{risultato.codice} {risultato.indirizzo} {risultato.CAP} {risultato.citta} {risultato.superficie} {risultato.tipologia}");
            }
        }
    }
}
