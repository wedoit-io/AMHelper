
/*
  Classe autogenerata dal tool RecClassCreator
  by Stefano teodorani il 09/08/2013 14.35.39
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace AMHelper.CSV
{
    /// <summary>
    /// Tracciato record delle tipologie di attivita crm.
    /// Contiene l'anagrafica delle tipologie di attività da effettuare (es: Fare offerta).
    /// </summary>
    public class rec_tipi_attivita
    {
        /// <summary>
        /// Chiave univoca della riga
        /// </summary>
        public string CHIAVE { get; set; }    
        /// <summary>
        /// Codice della ditta. 
        /// Identifica univocamente una ditta dentro il gestionale che, nel caso sia multisocietario, può contenere dati di più aziende
        /// </summary>
        public string COD_DITTA { get; set; }  
        /// <summary>
        /// Codice del tipo attività
        /// </summary>
        public string CODICE { get; set; }
        // Descrizione del tipo attivita
        // (Es: PZ=Fare offerta, Fare ordine, Prendere appuntamento)
        public string DESCRIZIONE { get; set; }
        /// <summary>
        /// Identifica una attività di tipo previsionale.
        /// Se = S, nell'iPad è possibile creare una attività che può avere le tipologia (Da effettuare, Effettuata, Annullata)
        /// Se = N, nell'iPad è possibile creare attività solo in stato Effettuata
        /// </summary>
        public string FLG_PREVISIONALE { get; set; }
    }
}