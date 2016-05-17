
/*
  Classe autogenerata dal tool RecClassCreator
  by Stefano teodorani il 09/08/2013 14.35.39
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace AMHelper.CSV
{
    public class rec_multimedia
    {
        // NOMEFILE|TITOLO|COD_ART|L1|L2|L3|L4|DAT_ULT_MOD
        /// <summary>
        /// Nome del file creato nella cartella principale
        /// </summary>
        public string NOMEFILE { get; set; }
        /// <summary>
        /// Descrizione del file (obbligatorio)
        /// </summary>
        public string TITOLO { get; set; }
        /// <summary>
        /// Codice articolo associato all'immagine (obbligatorio)
        /// </summary>
        public string COD_ART { get; set; }
        /// <summary>
        /// Livello 1. (obbligatorio)
        /// Le immagini vengono create in una cartella che ha il none specificato in questo campo
        /// </summary>
        public string L1 { get; set; }
        /// <summary>
        /// Livello 2. (facoltativo)
        /// Le immagini vengono create in una cartella che ha il none specificato in questo campo
        /// e che viene mostrata come sottocartella della precedente L1
        /// </summary>
        public string L2 { get; set; }
        /// <summary>
        /// Livello 3. (facoltativo)
        /// Le immagini vengono create in una cartella che ha il none specificato in questo campo
        /// e che viene mostrata come sottocartella della precedente L2
        /// </summary>
        public string L3 { get; set; }
        /// <summary>
        /// Livello 4. (facoltativo)
        /// Le immagini vengono create in una cartella che ha il none specificato in questo campo
        /// e che viene mostrata come sottocartella della precedente L3
        /// </summary>
        public string L4 { get; set; }
        /// <summary>
        /// Ordinamento. (facoltativo)
        /// Campo numerico utilizzato per impostare l'ordinamento con cui l'immagine
        /// viene mostrata nel catalogo
        /// </summary>
        public string ORDINAMENTO { get; set; }
        /// <summary>
        /// Data di ultima modifica del record
        /// </summary>
        public string DAT_ULT_MOD { get; set; }
    }
}