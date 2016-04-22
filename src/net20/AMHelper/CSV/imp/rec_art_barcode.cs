
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
    public class rec_art_barcode
    {
        /// <summary>
        /// Chiave univoca del record generata dai dati di origine
        /// </summary>
        public string CHIAVE { get; set; }

        /// <summary>
        /// Codice della ditta. E' il codice che identifica univocamente una ditta dentro il gestionale che, 
        /// nel caso sia multisocietario, porebbe contenere dati di più aziende
        /// </summary>
        public string COD_DITTA { get; set; }

        /// <summary>
        /// Codice dell'articolo
        /// </summary>
        public string COD_ART { get; set; }

        /// <summary>
        /// Codice a barre
        /// </summary>
        public string BARCODE { get; set; }

        /// <summary>
        /// Codice dell'unità di misura (es: PZ=Pezzi, KG=Chilogrammi, ecc...)
        /// </summary>
        public string UM { get; set; }

        /// <summary>
        /// Quantità
        /// </summary>
        public string QTA { get; set; }

        /// <summary>
        /// Tipologia di codice a Barre
        /// Valori possibili (EAN-13=ean13, EAN-8=Ean8, CODE-39=Code39, CODE-128=Code128, CODE-92=Code93, CODE-32=Farmaceutico,  ISBN=Isbn, UPC=UPC, 2OF5=2di5, DM=DataMatrix, QR=QRCode')
        /// </summary>
        public string TIPO_BARCODE { get; set; }

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