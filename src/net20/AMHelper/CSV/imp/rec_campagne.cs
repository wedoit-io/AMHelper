
/*
  Classe autogenerata dal tool RecClassCreator
  by Stefano teodorani il 09/08/2013 17.29.13
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace AMHelper.CSV
{
    public class rec_campagne
    {
        /// <summary>
        /// Chiave univoca del record generata dai dati di origine
        /// </summary>
        public string CHIAVE { get; set; }
        /// <summary>
        /// Codice della ditta. E' il codice che identifica univocamente una ditta dentro il gestionale che, nel caso sia multisocietario, porebbe contenere dati di pi� aziende
        /// </summary>
        public string COD_DITTA { get; set; }
        public string COD_CAMPAGNA { get; set; }
        public string DES_CAMPAGNA { get; set; }
        public string DAT_ULT_MOD { get; set; }

    }
}