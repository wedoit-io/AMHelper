using System;
using System.Collections.Generic;
using System.Text;

namespace AMHelper.WS
{
    public class ws_rec_leads_note
    {
        public ws_meta meta  { get; set; }
        public string cod_progetto { get; set; }
        public DateTime? last_data_import { get; set; }
        public decimal? last_id { get; set; }
        public List<TestataLeadsNoteExport> note { get; set; }
    }


    public class TestataLeadsNoteExport
    {
        public string cod_agente { get; set; }
        public string cod_ditta { get; set; }
        public string cod_lead { get; set; }
        public string cod_operatore { get; set; }
        public string cod_prog { get; set; }
        public decimal id { get; set; }
        public string unique_id { get; set; }
        public string nota { get; set; }
        public string progressivo { get; set; }
        public string tipo_nota { get; set; }
        public string utente { get; set; }
        public DateTime? data_import { get; set; }
    }
}