
/*
  Questo tracciato cinsende di definire una matrice di compatibilità 
  per la ricerca dei dati nell'App
  by Stefano teodorani il 09/08/2013 14.35.39
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace AMHelper.CSV
{


    //  : ITracciatoRecord
    //[NomeTracciato("nome_file.dat")]
    public class rec_art_matrici
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
        /// Codice della matrice di compatibilità
        /// </summary>
        public string COD_MATRICE { get; set; }
        /// <summary>
        /// Codice dell'articolo
        /// </summary>
        public string COD_ART { get; set; }
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