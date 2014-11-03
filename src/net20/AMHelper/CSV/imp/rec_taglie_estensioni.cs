
/*
  Classe autogenerata dal tool RecClassCreator
  by Stefano teodorani il 26/08/2013 10.27.46
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace AMHelper.CSV
{
    public class rec_taglie_estensioni
    {
        // CHIAVE|COD_DITTA|TIPO|COD_CLIENTE|COD_MATERIALE|DES_MATERIALE|COD_COLORE|DES_COLORE|DAT_ULT_MOD
        public string CHIAVE { get; set; }
        public string COD_DITTA { get; set; }
        public string TIPO { get; set; }           // (es: scatola o etichetta)
        public string COD_CLIENTE { get; set; }    // cod_cliente 
        public string COD_MATERIALE { get; set; }  // cod_materiale
        public string DES_MATERIALE { get; set; }  // des_materiale
        public string COD_COLORE { get; set; }     // cod_colore
        public string DES_COLORE { get; set; }     // des_colore
        public string DAT_ULT_MOD { get; set; }
    }
}