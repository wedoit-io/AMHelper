using System;
using System.Collections.Generic;
using System.Text;

namespace AMHelper.WS
{
    public class ws_rec_orders
    {
        public ws_meta meta { get; set; }
        public string cod_progetto { get; set; }
        public DateTime? last_data_import { get; set; }
        public decimal? last_id { get; set; }
        public List<TestataOrdineExport> testate { get; set; }
    }

    // In API Cercare CodaTestataOrdineExport
    public class TestataOrdineExport
    {
        public string cod_agente { get; set; }
        public string cod_clifor { get; set; }
        public string cod_cond_pag { get; set; }
        public string cod_cond_pag_deperibilita { get; set; }
        public string cod_destinazione { get; set; }
        public string cod_ditta { get; set; }
        public string cod_operatore { get; set; }
        public string cod_prog { get; set; }
        public string cod_porto { get; set; }
        public string cod_mod_sped { get; set; }
        public string cod_valuta { get; set; }
        public DateTime? data_consegna { get; set; }
        public DateTime? data_ordine { get; set; }
        public string ext_cod_tipo_ord { get; set; }
        public string guid_test_ord { get; set; }
        public decimal id { get; set; }
        public string unique_id { get; set; }
        public decimal? sconto { get; set; }
        public string note { get; set; }
        public string utente { get; set; }
        public string cod_materiale_estensione1 { get; set; }
        public string cod_materiale_estensione2 { get; set; }
        public string cod_colore_estensione1 { get; set; }
        public string cod_colore_estensione2 { get; set; }
        public DateTime? data_import { get; set; }
        public List<Clienti> clienti { get; set; }
        public List<RigaOrdineExport> righe { get; set; }
    }

    // In API cercare CodaNuovoClienteOrdineExport
    public class Clienti
    {
        public string ragione_sociale;
        public string partita_iva;
        public string codice_fiscale;
        public string telefono1;
        public string telefono2;
        public string cellulare;
        public string email;
        public string fax;
        public string indirizzo;
        public string cod_citta;
        public string des_citta;
        public string cap;
        public string provincia;
        public string cod_nazione;
        public string des_nazione;
        public string cod_cond_pag;
        public string des_cond_pag;
        public string iban;
        public string note;
        public string cod_classe_sconto;
        public string cod_canale_vendita;
        public string cod_categoria;
        public string cod_porto_sped;

        public string ragione_sociale_destinazione;
        public string indirizzo_consegna;
        public string cod_citta_consegna;
        public string des_citta_consegna;
        public string cap_consegna;
        public string provincia_consegna;
        public string cod_nazione_consegna;
        public string des_nazione_consegna;
        public string telefono_consegna;
        public string cellulare_consegna;
        public string fax_consegna;

    }

    public class RigaOrdineExport
    {
        public string cod_um_1 { get; set; }
        public string cod_um_2 { get; set; }
        public string codice_articolo { get; set; }
        public string codice_confezione { get; set; }
        public DateTime? data_consegna_riga { get; set; }
        public string descrizione_riga { get; set; }
        public string ext_cod_tipo_riga_omag { get; set; }
        public string ext_cod_tipo_riga_ord { get; set; }
        public decimal? fattore_conversione { get; set; }
        public decimal id { get; set; }
        public decimal? mag_importo { get; set; }
        public decimal? mag_perc_1 { get; set; }
        public decimal? mag_perc_2 { get; set; }
        public string note { get; set; }
        public decimal? prezzo { get; set; }
        public decimal? prezzo_2 { get; set; }
        public decimal? qta { get; set; }
        public decimal? qta_2 { get; set; }
        public decimal? qta_confezione { get; set; }
        public decimal? sconto_1 { get; set; }
        public decimal? sconto_2 { get; set; }
        public decimal? sconto_3 { get; set; }
        public decimal? sconto_4 { get; set; }
        public decimal? sconto_5 { get; set; }
        public decimal? sconto_6 { get; set; }
        public decimal? sconto_importo { get; set; }
        public string tipo_um { get; set; }
        public string cod_combinazione { get; set; }
        public string cod_catalogo { get; set; }
        public string cod_materiale1 { get; set; }
        public string cod_colore1 { get; set; }
        public string cod_materiale2 { get; set; }
        public string cod_colore2 { get; set; }
        public string cod_materiale3 { get; set; }
        public string cod_colore3 { get; set; }
        public string cod_materiale4 { get; set; }
        public string cod_colore4 { get; set; }
        public string cod_materiale5 { get; set; }
        public string cod_colore5 { get; set; }
        public string cod_materiale6 { get; set; }
        public string cod_colore6 { get; set; }
        public string cod_materiale7 { get; set; }
        public string cod_colore7 { get; set; }
        public string cod_materiale8 { get; set; }
        public string cod_colore8 { get; set; }
        public string cod_materiale9 { get; set; }
        public string cod_colore9 { get; set; }
        public string cod_materiale10 { get; set; }
        public string cod_colore10 { get; set; }
        public string cod_materiale11 { get; set; }
        public string cod_colore11 { get; set; }
        public string cod_materiale12 { get; set; }
        public string cod_colore12 { get; set; }
        public string cod_materiale13 { get; set; }
        public string cod_colore13 { get; set; }
        public string cod_materiale14 { get; set; }
        public string cod_colore14 { get; set; }
        public string cod_materiale15 { get; set; }
        public string cod_colore15 { get; set; }
        public List<DettaglioRigaOrdineExport> dettagli { get; set; }
    }

    public class DettaglioRigaOrdineExport
    {
        public string cod_assortimento { get; set; }
        public string cod_sviluppo { get; set; }
        public string cod_taglia { get; set; }
        public string cod_taglia_guida { get; set; }
        public string ext_cod_tipo_det_riga_ord { get; set; }
        public decimal? qta { get; set; }
    }
}