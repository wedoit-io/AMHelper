using System;
using System.Collections.Generic;
using System.Text;

namespace AMHelper.WS
{
    public class ws_rec_clifor
    {
        public ws_meta meta  { get; set; }
        public string cod_progetto { get; set; }
        public DateTime? last_data_import { get; set; }
        public decimal? last_id { get; set; }
        public List<TestataCf> clienti { get; set; }
    }


    public class TestataCf
    {
        public string cap { get; set; }
        public string cellulare { get; set; }
        public string citta { get; set; }
        public string cod_agente { get; set; }
        public string cod_cliente { get; set; }
        public string cod_cond_pag { get; set; }
        public string cod_ditta { get; set; }
        public string cod_operatore { get; set; }
        public string cod_prog { get; set; }
        public string codice_fiscale { get; set; }
        public string email { get; set; }
        public string fax { get; set; }
        public decimal id { get; set; }
        public string unique_id { get; set; }
        public string indirizzo { get; set; }
        public string partita_iva { get; set; }
        public string provincia { get; set; }
        public string ragione_sociale { get; set; }
        public string telefono1 { get; set; }
        public string telefono2 { get; set; }
        public string utente { get; set; }
        public DateTime? data_import { get; set; }
    }
}