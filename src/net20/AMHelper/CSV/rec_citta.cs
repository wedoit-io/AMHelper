
/*
  Classe autogenerata dal tool RecClassCreator
  by Stefano teodorani il 09/08/2013 14.35.39
*/

using System;
using System.Collections.Generic;
using System.Text;
//using FluentValidation;
//using FluentValidation.Results; 


namespace AMHelper.CSV
{
    public class rec_citta
    {
        public string CHIAVE { get; set; }
        public string COD_DITTA { get; set; }
        public string CODICE { get; set; }
        public string DESCRIZIONE { get; set; }
        public string CAP { get; set; }
        public string PROVINCIA { get; set; }
        public string DAT_ULT_MOD { get; set; }
    }

/*
    public class rec_citta_Validator : AbstractValidator<rec_citta>
    {
        public rec_citta_Validator() {
            RuleFor(citta => citta.CHIAVE).NotNull();
            RuleFor(citta => citta.COD_DITTA).NotNull();
            RuleFor(citta => citta.CODICE).NotNull();
            //RuleFor(citta => citta.CAP).NotNull().NotEmpty();
        }
    }
    */
    
}