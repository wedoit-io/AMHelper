using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace AMHelper.WS
{
    /// <summary>
    /// Metadati WS
    /// </summary>
    public class ws_meta
    {
        /// <summary>
        /// Numero massimo di record ritornati
        /// </summary>
        public decimal limit { get; set; }
        /// <summary>
        /// Valore di ID massimo ritornato
        /// </summary>
        public decimal maxID { get; set; }
        /// <summary>
        /// Record da cui effettuare l'esportazione dei dati
        /// </summary>
        public decimal offset { get; set; }
        /// <summary>
        /// Numero totale dei record elaborati
        /// </summary>
        public decimal total_count { get; set; }
    }
}
