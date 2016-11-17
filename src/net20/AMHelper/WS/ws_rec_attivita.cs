using System;
using System.Collections.Generic;
using System.Text;

namespace AMHelper.WS
{
    public class ws_rec_attivita
    {
        public ws_meta meta  { get; set; }
        /// <summary>
        /// Codice del progetto
        /// </summary>
        public string cod_progetto { get; set; }
        public DateTime? last_data_import { get; set; }
        public decimal? last_id { get; set; }
        public List<TestataAttivita> attivita { get; set; }
    }

    public class TestataAttivita
    {
        /// <summary>
        /// Identificativo progressivo della coda.
        /// La stessa attività può essere più colte messa coda per l'esportazione
        /// </summary>
        public decimal id { get; set; }
        /// <summary>
        /// Identificativo univoco dell'attività (non cambia mai)
        /// </summary>
        public string unique_id { get; set; }
        /// <summary>
        /// Codice della ditta
        /// </summary>
        public string cod_ditta { get; set; }
        /// <summary>
        /// Codice dell'attività master
        /// Ogni singola attività può avere un codice di attivita' master che le raggruppa
        /// </summary>
        public string cod_attivita { get; set; }
        /// <summary>
        /// Codice del lead
        /// </summary>
        public string cod_lead { get; set; }
        /// <summary>
        /// Codice del tipo attività
        /// </summary>
        public string cod_tipo_attivita { get; set; }
        /// <summary>
        /// Oggetto dell'attività
        /// </summary>
        public string des_oggetto { get; set; }
        /// <summary>
        /// Nota descrittiva della singola attività operatore
        /// </summary>
        public string des_note_attivita { get; set; }
        /// <summary>
        /// Codice dell'operatore che ha compiuto l'attività
        /// </summary>
        public string cod_operatore { get; set; }
        /// <summary>
        /// Codice dello Stato della attività
        /// Valori consentiti: D=Da eseguire, E=Eseguito, A=Annullato
        /// </summary>
        public string cod_stato { get; set; }
        /// <summary>
        /// Data di in cui l'attività è stata effettuata
        /// </summary>
        public DateTime? data_esecuzione { get; set; }
        /// <summary>
        /// Orario in cui l'attività è stata effettuata nel formato HH:MM con riempimento di zeri a sinistra
        /// Esempi: 14:55, 04:05
        /// </summary>
        public string ora_esecuzione { get; set; }
        /// <summary>
        /// Note dell'attività master
        /// Si tratta un ulteriore campo descrittivo della'attività
        /// </summary>
        public string des_note { get; set; }
        /// <summary>
        /// Codice dell'agente che ha effettuato l'attività
        /// </summary>
        public string cod_agente { get; set; }
        /// <summary>
        /// Utente che ha effettuato l'attività
        /// </summary>
        public string utente { get; set; }
        /// <summary>
        /// DAta import
        /// </summary>
        public DateTime? data_import { get; set; }
    }
}