
/*
  Classe autogenerata dal tool RecClassCreator
  by Stefano teodorani il 09/08/2013 14.35.39
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace AMHelper.CSV
{
    public class rec_clifor_testdoc
    {
        // CHIAVE|COD_DITTA|TIPO_CLIFOR|COD_CLIFOR|COD_TIPODOC|COD_STIPODOC|FLGDAEVADERE|DATDOC|NUMREG|TIPODOC|TIPO|SOTTOTIPO|DATAREG|SEZIONALE|NUMDOC|DOCORIG|DEPOSITO|VALUTA|TOTALEDOC|DATACONS|SCADENZE|ESTCONT|TIPOSTATO_DOC|DESSTATO_DOC|DATA_FATT|NUM_FATT|NOTE_DOC|DATA_CONFERMA|DAT_ULT_MOD
        public string CHIAVE { get; set; }
        public string COD_DITTA { get; set; }
        public string TIPO_CLIFOR { get; set; }
        public string COD_CLIFOR { get; set; }
        public string COD_TIPODOC { get; set; }
        public string COD_STIPODOC { get; set; }
        public string NUMREG { get; set; }
        public string TIPODOC { get; set; }
        public string TIPO { get; set; }
        public string SOTTOTIPO { get; set; }
        public string DATAREG { get; set; }
        public string SEZIONALE { get; set; }
        public string DES_DOC { get; set; }
        public string NUM_DOC { get; set; }
        public string DES_NOTE { get; set; } 
        public string DATA_DOC { get; set; }
        public string DOCORIG { get; set; }
        public string DEPOSITO { get; set; }
        /// <summary>
        /// Codice della Valuta
        /// </summary>
        public string COD_VALUTA { get; set; }
        public string TOTALEDOC { get; set; }
        public string DATACONS { get; set; }
        public string SCADENZE { get; set; }
        public string ESTCONT { get; set; }
        public string TIPOSTATO_DOC { get; set; }
        public string DESSTATO_DOC { get; set; }
        public string DATA_FATT { get; set; }
        public string NUM_FATT { get; set; }
        public string DATA_CONSEGNA { get; set; }
        public string DAT_ULT_MOD { get; set; }

        /*

        [Obsolete("Deprecato. Eliminare")]
        public string DATA_CONFERMA { get; set; }

        [Obsolete("Deprecato. Utilizzare NUM_DOC")]
        public string NUMDOC { get; set; }   // Doppione da eliminare mantenuto per compatibilita (vedi sopra)

        [Obsolete("Deprecato. Utilizzare DES_NOTE")]
        public string NOTE_DOC { get; set; }  // Doppione da eliminare mantenuto per compatibilita (vedi sopra)

        [Obsolete("Deprecato. Utilizzare DATA_DOC")]
        public string DATADOC { get; set; }
        */
    }

}