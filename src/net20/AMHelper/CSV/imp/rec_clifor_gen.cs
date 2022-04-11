
/*
  Classe autogenerata dal tool RecClassCreator
  by Stefano teodorani il 09/08/2013 14.35.39
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace AMHelper.CSV
{
    public class rec_clifor_gen
    {
        /// <summary>
        /// Chiave univoca del record generata dai dati di origine
        /// </summary>
        public string CHIAVE  { get; set; }
        /// <summary>
        /// Codice della ditta. E' il codice che identifica univocamente una ditta dentro il gestionale che, nel caso sia multisocietario, porebbe contenere dati di più aziende
        /// </summary>
        public string COD_DITTA  { get; set; }
        /// <summary>
        /// Tipo anagrafica (0=CLiente, 1=Fornitore)
        /// </summary>
        public string TIPO_CLIFOR  { get; set; }
        /// <summary>
        /// Codice del Cliente o Fornitore
        /// </summary>
        public string COD_CLIFOR  { get; set; }
        /// <summary>
        /// Ragione sociale
        /// </summary>
        public string RAG_SOC  { get; set; }
        /// <summary>
        /// Indirizzo (es: Via Marcuzzi, 8)
        /// </summary>
        public string INDIRIZZO  { get; set; }
        /// <summary>
        /// Partita IVA
        /// </summary>
        public string PARTITA_IVA  { get; set; }
        /// <summary>
        /// Codice fiscale
        /// </summary>
        public string CODICE_FISCALE  { get; set; }
        /// <summary>
        /// Telefono 1
        /// </summary>
        public string TELEFONO1  { get; set; }
        /// <summary>
        /// Telefono 2
        /// </summary>
        public string TELEFONO2  { get; set; }
        /// <summary>
        /// Fax
        /// </summary>
        public string FAX  { get; set; }
        /// <summary>
        /// Riferimento telefonico cellulare
        /// </summary>
        public string CELLULARE  { get; set; }
        /// <summary>
        /// Indirizzo di posta elettronica (es: 346 2738888)
        /// </summary>
        public string EMAIL  { get; set; }
        /// <summary>
        /// Indirizzo intenet del soggetto (es: http://www.acme.it)
        /// </summary>
        public string INTERNET  { get; set; }
        /// <summary>
        /// Indirizzo di posta elettronica certificata
        /// </summary>
        public string PEC { get; set; }
        /// <summary>
        /// Codice di avviamento postale (es: 45766)
        /// </summary>
        public string CAP  { get; set; }
        /// <summary>
        /// Città (Es. Cesena)
        /// </summary>
        public string CITTA  { get; set; }
        /// <summary>
        /// Sigra della provincia (es: FC)
        /// </summary>
        public string PROVINCIA  { get; set; }
        /// <summary>
        /// Latitudine a cui si trova l'azienda. Usare il punto come separatore (es: 40.8517964)
        /// </summary>
        public string LATITUDINE  { get; set; }
        /// <summary>
        /// Longitudine a cui si trova l'azienda. Usare il punto come separatore (es: 15.8517964)
        /// </summary>
        public string LONGITUDINE  { get; set; }
        public string COD_CLASSE_SCONTO  { get; set; }
        /// <summary>
        /// Flag che identifica la modificabilità dell'anagrafica nel dispositivo (0=Non modificabile, -1= Modificabile)
        /// </summary>
        public string FLG_MOD_NEL_DISP  { get; set; }
        /// <summary>
        /// Flag che identifica articoli di tipo deperibile. Usato per lo split di ordini che contendono
        /// articoli di (0=Non modificabile, -1= Modificabile)
        /// </summary>
        public string FLG_DEPERIBILITA  { get; set; }
        public string COD_CAT_EXTRA_SCONTO  { get; set; }
        public string NAZIONE  { get; set; }
        public string PAGAMENTO  { get; set; }
        public string BANCA  { get; set; }
        public string IBAN { get; set; }
        public string AGENZIA  { get; set; }
        public string LISTINO_ANAGRAFICO  { get; set; }
        public string COD_SVILUPPO { get; set; }
        public string VALUTA  { get; set; }
        public string SCONTI_ANAG_PERC  { get; set; }
        public string SCONTI_ANAG_IMP  { get; set; }
        public string SCO_PERC1 { get; set; }
        public string SCO_PERC2 { get; set; }
        public string SCO_PERC3 { get; set; }
        public string SCO_PERC4 { get; set; }
        public string SCO_PERC5 { get; set; }
        public string SCO_PERC6 { get; set; }
        public string TAG { get; set; }
        public string MAGGIORAZIONE_ANAG_PERC  { get; set; }
        public string SCONTO_PIEDE  { get; set; }
        public string COD_LISTINO  { get; set; }
        public string COD_CONDPAG  { get; set; }
        public string COD_VALUTA  { get; set; }
        public string MACROAREA  { get; set; }
        public string DATA_CREAZIONE  { get; set; }
        public string AREA  { get; set; }
        public string DES_ZONA  { get; set; }
        public string MACROCATEGORIA  { get; set; }
        public string DATA_ULT_DOC_NO_FT  { get; set; }
        public string CATEGORIA  { get; set; }
        public string SOTTOCATEGORIA  { get; set; }
        public string DATA_ULT_DOC_FT  { get; set; }
        public string DATA_ULT_ORDINE  { get; set; }
        public string FIDO_AZIENDALE  { get; set; }
        public string RAGGR1  { get; set; }
        public string RAGGR2  { get; set; }
        public string RAGGR3  { get; set; }
        public string COD_MACROAREA  { get; set; }
        public string COD_AREA  { get; set; }
        public string COD_ZONA  { get; set; }
        public string COD_MACROCATEGORIA  { get; set; }
        public string COD_CATEGORIA  { get; set; }
        public string COD_SOTTOCATEGORIA  { get; set; }
        /// <summary>
        /// Codice che identifica un colore da mostrare come pin nella mappa (Può valere 0, 1 o 2)
        /// </summary>
        public string COD_PIN_MAPPA { get; set; }
        /// <summary>
        /// Descrizione (legata al pin) da mostrare nel pin della mappa
        /// </summary>
        public string DES_PIN_MAPPA { get; set; }
        /// <summary>
        /// Totale minimo ordinabile. Se configurato agisce sull'inserimento ordini veloci
        /// per impostare un totale minimo sotto il quale non si può prendere l'ordine
        /// </summary>
        public string TOT_MIN_ORDINABILE { get; set; }
        /// <summary>
        /// Flag che identifica un cliente di tipo template.
        /// Utilizzato per la raccolta ordini su clienti nuovi
        /// </summary>
        public string FLG_NEW_CLIFOR { get; set; }
        /// <summary>
        /// Data di ultima modifica del record
        /// </summary>
        public string DAT_ULT_MOD { get; set; }
        /// <summary>
        /// Flag che identifica un cliente di tipo negozio.
        /// </summary>
        public string FLG_NEGOZIO { get; set; }
        /// <summary>
        /// Codice che identifica il tipo di blocco.
        /// </summary>
        public string COD_BLOCCO { get; set; }
        /// <summary>
        /// Codice giorno consegna.
        /// </summary>
        public string COD_GIORNO_CONSEGNA { get; set; }
        /// <summary>
        /// Codice tipo cliente.
        /// </summary>
        public string COD_TIPO_CLIENTE { get; set; }

        public string DES_STATO { get; set; }
    }
}