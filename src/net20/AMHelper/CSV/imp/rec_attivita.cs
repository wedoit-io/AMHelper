
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
    /// Tracciato record delle tipologie di attivita (Gestione CRM).
    /// Contiene l'anagrafica delle tipologie di attività da effettuare (es: Fare offerta).
    /// </summary>
    public class rec_attivita
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
        /// Codice dell'attività master
        /// Ogni singola attività può avere un codice di attivita' master che le raggruppa
        /// </summary>
        public string COD_ATTIVITA { get; set; } 
        /// <summary>
        /// Codice del Lead
        /// </summary>
        public string COD_LEAD { get; set; } 
        /// <summary>
        /// Codice della tipologia di attività (tracciato rec_tipi_attivita)
        /// </summary>
        public string COD_TIPO_ATTIVITA { get; set; }
        /// <summary>
        /// Oggetto dell'attività
        /// </summary>
        public string DES_OGGETTO { get; set; } 
        /// <summary>
        /// Note dell'attività
        /// </summary>
        public string DES_NOTE_ATTIVITA { get; set; } 
        /// <summary>
        /// Codice dell'operatore a cui è assegnata l'attività
        /// </summary>
        public string COD_OPERATORE { get; set; } 
        /// <summary>
        /// Codice dello Stato della attività
        /// Valori consentiti: D=Da eseguire, E=Eseguito, A=Annullato
        /// </summary>
        public string COD_STATO { get; set; }
        /// <summary>
        /// Data di in cui l'attività è stata effettuata
        /// </summary>
        public string DATA_ESECUZIONE { get; set; }
         /// <summary>
        /// Orario in cui l'attività è stata effettuata nel formato HH:MM con riempimento di zeri a sinistra
        /// Esempi: 14:55, 04:05
        /// </summary>
        public string ORA_ESECUZIONE { get; set; }
        /// <summary>
        /// Note dell'attività master
        /// Si tratta un ulteriore campo descrittivo della'attività
        /// </summary>
        public string DES_NOTE { get; set; }
        /// <summary>
        /// Data di ultima modifica del record
        /// </summary>
        public string DAT_ULT_MOD { get; set; }
    }
}