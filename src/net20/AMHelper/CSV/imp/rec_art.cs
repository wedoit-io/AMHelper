
/*
  Classe autogenerata dal tool RecClassCreator
  by Stefano teodorani il 09/08/2013 14.35.39
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace AMHelper.CSV
{


    //  : ITracciatoRecord
    //[NomeTracciato("nome_file.dat")]
    public class rec_art
    {
        /// <summary>
        /// Chiave univoca del record generata dai dati di origine
        /// </summary>
        public string CHIAVE { get; set; }
        /// <summary>
        /// Codice della ditta. E' il codice che identifica univocamente una ditta dentro il gestionale che, nel caso sia multisocietario, porebbe contenere dati di più aziende
        /// </summary>
        public string COD_DITTA { get; set; }
        /// <summary>
        /// Codice dell'articolo
        /// </summary>
        public string COD_ART { get; set; }
        /// <summary>
        /// Descrizione dell'articolo
        /// </summary>
        public string DES_ART { get; set; }
        /// <summary>
        /// Codice della famiglia degli articoli
        /// </summary>
        public string COD_FAM { get; set; }
        /// <summary>
        /// Descrizione della famiglia degli articoli
        /// </summary>
        public string DES_FAM { get; set; }
        /// <summary>
        /// Codice della Famiglia
        /// </summary>
        public string COD_SFAM { get; set; }
        /// <summary>
        /// Descrizione della sottofamiglia
        /// </summary>
        public string DES_SFAM { get; set; }
        /// <summary>
        /// Codice del gruppo merceologico 1
        /// </summary>
        public string COD_GRUPPO1 { get; set; }
        /// <summary>
        /// Descrizione del gruppo merceologico 1
        /// </summary>
        public string DES_GRUPPO1 { get; set; }
        /// <summary>
        /// Codice del gruppo merceologico 2
        /// </summary>
        public string COD_GRUPPO2 { get; set; }
        /// <summary>
        /// Descrizione del gruppo merceologico 2
        /// </summary>
        public string DES_GRUPPO2 { get; set; }
        /// <summary>
        ///  Unità di misura 1
        /// </summary>
        public string UM1 { get; set; }
        /// <summary> 
        ///  Unità di misura 2 (non usato)
        /// </summary>
        public string UM2 { get; set; }
        /// <summary>
        /// Codice dello stato (non usato)
        /// </summary>
        public string COD_STATO { get; set; }
        /// <summary>
        ///  Descrizione dello stato
        /// </summary>
        public string DES_STATO { get; set; }
        /// <summary>
        /// Fattore di conversione (non usato)
        /// </summary>
        public string FATTORE_CONVERSIONE { get; set; }
        /// <summary>
        /// Descrizione del gruppo statistico 1
        /// </summary>
        public string DES_GR_STAT1 { get; set; }
        /// <summary>
        /// Descrizione del gruppo statistico 2
        /// </summary>
        public string DES_GR_STAT2 { get; set; }
        /// <summary>
        /// Quantità minima di vendita.
        /// Se impostata determina una quantità minima sotto la quale non è possibile ordinare merce
        /// </summary>
        public string QTA_MIN_VEND { get; set; }
        /// <summary>
        /// Codice della classe sconto articolo
        /// </summary>
        public string COD_CLASSE_SCONTO { get; set; }
        /// <summary>
        /// Codice deperibilità.
        /// </summary>
        public string COD_DEPERIBILITA { get; set; }
        /// <summary>
        /// Indica un prezzo minimo di vendita sotto il quale non è possibile ordinare l'articolo
        /// </summary>
        public string PREZZO_MIN_VEN { get; set; }
        /// <summary>
        /// Sconto massimo di vendita. Indica uno sconto massimo applicabile per l'articolo
        /// </summary>
        public string SCONTO_MAX_VEN { get; set; }
        /// <summary>
        /// Sconot Massimo Extrasconto (non usato)
        /// </summary>
        public string MAX_EXTRA_SCONTO { get; set; }
        /// <summary>
        /// Prezzo retail
        /// </summary>
        public string PREZZO_RETAIL { get; set; }
        /// <summary>
        /// Descrizione del filtro 1. 
        /// Valore descrittivo i cui valori distinti sono usati nell'iPad per configurare un filtro di ricerca
        /// </summary>
        public string DES_FILTRO1 { get; set; }
        /// <summary>
        /// Descrizione del filtro 2 
        /// Valore descrittivo i cui valori distinti sono usati nell'iPad per configurare un filtro di ricerca. Dipende da Filtro 1
        /// </summary>
        public string DES_FILTRO2 { get; set; }
        /// <summary>
        /// Descrizione del filtro 3
        /// Valore descrittivo i cui valori distinti sono usati nell'iPad per configurare un filtro di ricerca. Dipende da Filtro 2
        /// </summary>
        public string DES_FILTRO3 { get; set; }
        /// <summary>
        /// Descrizione del filtro A. 
        /// Valore descrittivo i cui valori distinti sono usati nell'iPad per configurare un filtro di ricerca
        /// </summary>
        public string DES_FILTROA { get; set; }
        /// <summary>
        /// Descrizione del filtro B 
        /// Valore descrittivo i cui valori distinti sono usati nell'iPad per configurare un filtro di ricerca. Dipende da Filtro A
        /// </summary>
        public string DES_FILTROB { get; set; }
        /// <summary>
        /// Descrizione del filtro C
        /// Valore descrittivo i cui valori distinti sono usati nell'iPad per configurare un filtro di ricerca. Dipende da Filtro B
        /// </summary>
        public string DES_FILTROC { get; set; }
        /// <summary>
        /// Codice dello sviluppo. Usato solo per il modulo wTrendy
        /// </summary>
        public string COD_SVILUPPO_BASE { get; set; }
        /// <summary>
        /// Flag che identifica la possibilità, per l'utente, di modificare l'unità di misura 
        /// di default (FLG_DEFAULT di io_art_um.dat), in fase di inserimento ordine
        /// Valori consentiti: 0 = Modificabile (default), -1 = Non modificabile
        /// </summary>
        public string FLG_LOCK_UM_DEFAULT { get; set; }
        /// <summary>
        /// Descrizione estesa dell'articolo. Campo utilizzabile per aggiungere
        /// contenuti extra sotto la descrizione dell'articolo
        /// </summary>
        public string DES_ESTESA { get; set; }
        /// <summary>
        /// Data di ultima modifica del record
        /// </summary>
        public string DAT_ULT_MOD { get; set; }

        //public string Nome { get { return "nomefile.dat";  } }

        /*
        public string GetFileName()
        {
            return "nomefile.dat";
        }
         */
    }

}