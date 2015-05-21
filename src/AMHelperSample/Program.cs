using System;
using System.Collections.Generic;
using System.Text;
using AMHelper.WS;
using AMHelper.CSV;


namespace AMHelperSample
{
    class Program
    {

        static void Main(string[] args)
        {
            //SendNotificationByAgent_Sample();

            SendNotificationByUserName_Sample();

            //GetOrders_Sample();

        }


        static void GetOrders_Sample()
        {

            try
            {
                // Impostare le chiavi di autorizzazione
                string AuthKeyLM = "3405D863-C49C-4D4B-B1FF-35D6231C61D9";
                string AuthKeyAM = "FDFC769C-E950-4067-B4FF-0F3A134FB94B";

                // Impostare true per l'utilizzo dei server di produzione (default)
                // false consente l'utilizzo di server di test (solo ad uso interno)
                bool Produzione =  true;

                // Impostazioni da usare solo se si è sotto proxy
                // ----------------------------------------------
                string ProxyUser = "teo";
                string ProxyPassword = "gigi";
                string ProxyHost = "192.168.10.134";
                int ProxyPort = 8081;
                bool ProxyEnable = false;
                // ----------------------------------------------


                // Quale è l'ultimo ID Ordine che è stato elaborato ?
                // Questo dato, che qui è impostato a un valore fisso, deve essere recuperato da una tabella
                // in cui il programma deve memorizzare l'ultimo ID ordine che è stato acquisito
                int LastStoredID = 30;

                // Dove è situato il mio AM ?
                // Per prima cosa viene chiamato il License Manager (con l'opportuna chiave di autenticazione).
                GetDataLM lmdata = new GetDataLM(AuthKeyLM, Produzione);

                // Devo impostare un proxy ?
                // Se ProxyEnable = true prevedo l'utilizzo del proxy
                if (ProxyEnable)
                {
                    lmdata.HttpProxyAutentication(ProxyUser, ProxyPassword, ProxyHost, ProxyPort);
                }


                // Quali sono i dati per il collegamento all'AppManager ?
                // Grazie all'oggetto fornito dal License Manager, recupero i dati dei parametri dell'AppManagere mi faccio restituire
                // la struttura dei dati (se ce ne sono
                ws_rec_lmparam AMData = null;
                bool lmRetVal = lmdata.get_am_par(ref AMData);
                
                // Che versione di connettore sto usando ?
                // Per tenere una traccia centralizzata delle versioni dei connettori, è possibile inviare al server
                // la versione del proprio connettore.
                bool retRelease = lmdata.send_release("1.0");


                string wsURL = AMData.url_am_api ;
                
                string CodProgetto = AMData.cod_prog;
                
           

                // Leggo l'ID dell'ultimo ordine recuperato dal WS. Se è la prima volta tornerà 0 (zero)

                //int LastStoredID = 12484;
                // Istanzio l'oggetto Export dell'AMHelper
                GetDataAM ed = new GetDataAM(AuthKeyAM, wsURL);


                if (ProxyEnable)
                {
                    ed.HttpProxyAutentication(ProxyUser, ProxyPassword, ProxyHost, ProxyPort);
                }
                    


                // Chiamo il WS per farmi dare la lista dei leads
                ws_rec_orders OrdersData = null;
                bool RetVal;

                try
                {

                    RetVal = ed.exp_orders(LastStoredID, ref OrdersData);

                    if (RetVal && OrdersData != null)
                    {
                        Console.WriteLine(String.Format("... found {0} record ", OrdersData.testate.Count.ToString()));

                        System.Globalization.CultureInfo itIT = System.Globalization.CultureInfo.CreateSpecificCulture("it-IT");

                        foreach (var t in OrdersData.testate)
                        {
                            Console.WriteLine("Codclifor:" + t.cod_clifor);
                            Console.WriteLine("Data consegna:" + t.data_consegna);

                            foreach (var r in t.righe)
                            {
                                Console.WriteLine(">>> Riga: " + r.id);
                                Console.WriteLine(">>> Cod art: " + r.codice_articolo);
                                // .... etc..
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("... booh! Sembra che non ci siano dati");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("..error:" + ex.Message);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("..error:" + ex.Message);
            }

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();

        }

        static void SendNotificationByAgent_Sample()
        {
            // notifica_push_send_by_username
            // Impostare le chiavi di autorizzazione
            string AuthKeyLM = "41AF11C0-36C9-4C16-8BAF-83B033B959CA";
            // string AuthKeyAM = "FDFC769C-E950-4067-B4FF-0F3A134FB94B";

            // Impostare true per l'utilizzo dei server di produzione (default)
            // false consente l'utilizzo di server di test (solo ad uso interno)
            bool Produzione =  true;

            GetDataLM lmdata = new GetDataLM(AuthKeyLM, Produzione);

            ws_rec_lmparam AMData = null;
            bool lmRetVal = lmdata.get_am_par(ref AMData);

            bool retRelease = lmdata.send_push_notification_by_agent("8", "Test");
        }

        static void SendNotificationByUserName_Sample()
        {
            // notifica_push_send_by_username
            // Impostare le chiavi di autorizzazione
            string AuthKeyLM = "41AF11C0-36C9-4C16-8BAF-83B033B959CA";
            // string AuthKeyAM = "FDFC769C-E950-4067-B4FF-0F3A134FB94B";

            // Impostare true per l'utilizzo dei server di produzione (default)
            // false consente l'utilizzo di server di test (solo ad uso interno)
            bool Produzione = true;

            GetDataLM lmdata = new GetDataLM(AuthKeyLM, Produzione);

            ws_rec_lmparam AMData = null;
            bool lmRetVal = lmdata.get_am_par(ref AMData);

            bool retRelease = lmdata.send_push_notification_by_username("admin", "Test");
        }
    }
}
