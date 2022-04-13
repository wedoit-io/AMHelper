using System;
using System.Collections.Generic;
using System.Text;

namespace AMHelper.CSV
{
    public static class Tracciati
    {

        public static Dictionary<Type, string> NomeFile {
            get {
                return new Dictionary<Type, string>
                {
                    { typeof(rec_art), "io_art.dat"},
                    { typeof(rec_art_barcode), "io_art_barcode.dat"},
                    { typeof(rec_art_lang), "io_art_lang.dat" },
                    { typeof(rec_articoli_assortimenti), "io_articoli_assortimenti.dat" },
                    { typeof(rec_art_conf), "io_art_conf.dat" },
                    { typeof(rec_art_ultacq), "io_art_ultacq.dat" },
                    { typeof(rec_art_ultven), "io_art_ultven.dat" },
                    { typeof(rec_art_um), "io_art_um.dat" },
                    { typeof(rec_assortimenti), "io_assortimenti.dat" },
                    { typeof(rec_campagne), "io_campagne.dat" },
                    { typeof(rec_citta), "io_citta.dat" },
                    { typeof(rec_nazioni), "io_nazioni.dat" },
                    { typeof(rec_clienti_assortimenti), "io_clienti_assortimenti.dat" },
                    { typeof(rec_clifor_age), "io_clifor_age.dat" },
                    { typeof(rec_clifor_blo), "io_clifor_blo.dat" },
                    { typeof(rec_clifor_dest), "io_clifor_dest.dat" },
                    { typeof(rec_clifor_detcon), "io_clifor_detcon.dat" },
                    { typeof(rec_clifor_fatt), "io_clifor_fatt.dat" },
                    { typeof(rec_clifor_girovisita), "io_clifor_girovisita.dat" },
                    { typeof(rec_clifor_gen), "io_clifor_gen.dat" },
                    { typeof(rec_clifor_note), "io_clifor_note.dat" },
                    { typeof(rec_clifor_righdoc), "io_clifor_righdoc.dat" },
                    { typeof(rec_clifor_scadoc), "io_clifor_scadoc.dat" },
                    { typeof(rec_clifor_testdoc), "io_clifor_testdoc.dat" },
                    { typeof(rec_condpag), "io_condpag.dat" },
                    { typeof(rec_condpag_lang), "io_condpag_lang.dat" },
                    { typeof(rec_custom_fields), "io_custom_fields.dat" },
                    { typeof(rec_giacenze), "io_giacenze.dat" },
                    { typeof(rec_mod_sped), "io_mod_sped.dat" },
                    { typeof(rec_info), "io_info.dat" },
                    { typeof(rec_leads), "io_leads.dat" },
                    { typeof(rec_lead_acccrm), "io_lead_acccrm.dat" },
                    { typeof(rec_lead_accessi), "io_lead_accessi.dat" },
                    { typeof(rec_lead_note), "io_lead_note.dat" },
                    { typeof(rec_lead_righoff), "io_lead_righoff.dat" },
                    { typeof(rec_lead_sconti), "io_lead_sconti.dat" },
                    { typeof(rec_lead_testoff), "io_lead_testoff.dat" },
                    { typeof(rec_lead_detcon), "io_lead_detcon.dat" },
                    { typeof(rec_listini_full), "io_listini_full.dat" },
                    { typeof(rec_stoart), "io_stoart.dat" },
                    { typeof(rec_sconti), "io_sconti.dat" },
                    { typeof(rec_valute), "io_valute.dat" },
                    { typeof(rec_taglie_assortimenti), "io_taglie_assortimenti.dat" },
                    { typeof(rec_cataloghi), "io_cataloghi.dat" },
                    { typeof(rec_cataloghi_art), "io_cataloghi_art.dat" },
                    { typeof(rec_cataloghi), "io_taglie_cataloghi.dat" },
                    { typeof(rec_cataloghi_art), "io_taglie_cataloghi_art.dat" },
                    { typeof(rec_taglie_estensioni), "io_taglie_estensioni.dat" },
                    { typeof(rec_taglie_sviluppi), "io_taglie_sviluppi.dat" },
                    { typeof(rec_taglie_sviluppi_art), "io_taglie_sviluppi_art.dat" },
                    { typeof(rec_var_combinazioni), "io_var_combinazioni.dat" },
                    { typeof(rec_regole), "io_regole.dat" },
                    { typeof(rec_liste_materiali), "io_liste_materiali.dat" },
                    { typeof(rec_liste_colori), "io_liste_colori.dat" },
                    { typeof(rec_canali_vendita), "io_canali_vendita.dat" },
                    { typeof(rec_classi_sconto), "io_classi_sconto.dat" },
                    { typeof(rec_clifor_cate), "io_clifor_cate.dat" },
                    { typeof(rec_porto), "io_porto.dat" },
                    { typeof(rec_magazzini), "io_magazzini.dat" },
                    { typeof(rec_cli_escl), "io_clifor_esclusioni.dat" },
                    { typeof(rec_age_escl), "io_agenti_esclusioni.dat" },

                    { typeof(rec_lead_concorrenti), "io_lead_concorrenti.dat" },
                    { typeof(rec_lead_mod_acquisizione), "io_lead_mod_acquisizione.dat" },
                    { typeof(rec_lead_fonti), "io_lead_fonti.dat" },
                    { typeof(rec_lead_interessi), "io_lead_interessi.dat" },
                    { typeof(rec_lead_settori), "io_lead_settori.dat" },
                    { typeof(rec_lead_cate), "io_lead_cate.dat" },
                    { typeof(rec_lead_mansioni), "io_lead_mansioni.dat" },
                    { typeof(rec_agenti), "io_agenti.dat" },
                    { typeof(rec_multimedia), "io_catalogo.dat" },
                    { typeof(rec_reports), "io_reports.dat" },

                    { typeof(rec_exp_order), "AM_ORD_{0}_{1}.DAT" },
                    { typeof(rec_exp_clifor), "AM_CF_ANA_{0}_{1}.DAT" },
                    { typeof(rec_exp_clifor_note), "AM_CF_NOTE_{0}_{1}.DAT" },
                    { typeof(rec_exp_leads), "leads_data_{0}_{1}_{2}.xml" },
                    { typeof(rec_exp_leads_note), "leads_note_{0}_{1}_{2}.xml" }
                };
            }
        }

    }
}
