﻿using System;
using System.Collections.Generic;
using System.Net;
//using System.Collections.IEnumerable;
using System.Text;
using System.IO;
using RestSharp;

#if NET20
  using Newtonsoft.Json;
#endif

//using RestSharp.Serializers;

namespace AMHelper.WS
{
    public class GetDataAM
    {        
        // Private fields
        private string _AuthKeyAM;
        private string _BaseUrl;
        private string _LeadsUrl;
        private string _LeadsNoteUrl;
        private string _CliforUrl;
        private string _CliforNoteUrl;
        private string _OrdersUrl;
        private string _InfoMessage;
        private string _ResponseURI;

        // Property AuthKey
        private string AuthKeyAM    
        {
            get
            {
                return _AuthKeyAM;
            }
            set
            {
                _AuthKeyAM = value;
            }
        }

        // Property CdaProgetto
        private string BaseUrl 
        {
            get
            {
                return _BaseUrl;
            }
            set
            {
                _BaseUrl = value;
                _LeadsUrl =  value + "/" + "exportPaginazione/codaLeads";
                _LeadsNoteUrl = value + "/" + "exportPaginazione/codaLeadNote";
                _CliforUrl = value + "/" + "exportPaginazione/codaClienti";
                _CliforNoteUrl = value + "/" + "exportPaginazione/codaClienteNote";
                _OrdersUrl = value + "/" + "exportPaginazione/codaOrdini";
                _InfoMessage = value;
                _ResponseURI = value;
            }
        }

        public GetDataAM(string AuthKeyAM, string BaseUrl)
        {
            this.AuthKeyAM = AuthKeyAM;
            this.BaseUrl = BaseUrl;
        }

        public bool exp_leads(int StartID, ref ws_rec_leads LeadsData)
        {
            try
            {
                var client = new RestClient(_LeadsUrl);

                // Seconda chiamata. Estraggo tutto gli ordini (niente paginazione)
                // ---------------------------------------------------------------
                // http://am.apexnet.it/api_appstore_ib/v1/progetti/ib.appstore/exportPaginazione/leads?authKey=AAB993AE-92B7-4E88-BC59-B231F0CDAD7C&format=json&offset=0&limit=7&count=0&lastID=0
                var request = new RestRequest(Method.GET);
                request.AddParameter("authKey", this.AuthKeyAM);
                request.AddParameter("format", "json");
                request.AddParameter("offset", 0);
                request.AddParameter("limit", 50);
                request.AddParameter("count", 0);
                request.AddParameter("lastID", StartID);
                //request.AddParameter("lastDateImport", "");       
                var response = client.Execute<ws_rec_leads>(request);

                _ResponseURI = response.ResponseUri.ToString();

#if NET20 
                var myDeserializedData = JsonConvert.DeserializeObject<ws_rec_leads>(response.Content);
#endif

#if NET35 || NET40
                var myDeserializedData = response.Data;
#endif


                // Se ci sono errori nella chiamata di recupero dei dati esco 
                if (response.ErrorException != null)
                {
                    _InfoMessage = "Error retrieving response 2.  Check inner details for more info.";
                    return false;
                }


                if (response.Data.leads.Count == 0)
                {
                    _InfoMessage = "Data not found";
                    return false;
                }

                LeadsData = myDeserializedData;

            }
            catch (Exception ex)
            {
                throw new Exception("AMHelper: [" +_ResponseURI + "]", ex);
            }
            return true;
        }

        public bool exp_leads_note(int StartID, ref ws_rec_leads_note LeadsNoteData)
        {
            try
            {
                var client = new RestClient(_LeadsNoteUrl);

                // Seconda chiamata. Estraggo tutto gli ordini (niente paginazione)
                // ---------------------------------------------------------------
                // http://am.apexnet.it/api_appstore_ib/v1/progetti/ib.appstore/exportPaginazione/notelead?authKey=AAB993AE-92B7-4E88-BC59-B231F0CDAD7C&format=json&lastID=0&count=0
                var request = new RestRequest(Method.GET);
                request.AddParameter("authKey", this.AuthKeyAM);
                request.AddParameter("format", "json");
                request.AddParameter("offset", 0);
                request.AddParameter("limit", 50);
                request.AddParameter("count", 0);
                request.AddParameter("lastID", StartID);
                //request.AddParameter("lastDateImport", "");       
                var response = client.Execute<ws_rec_leads_note>(request);

                _ResponseURI = response.ResponseUri.ToString();

#if NET20 
                var myDeserializedData = JsonConvert.DeserializeObject<ws_rec_leads_note>(response.Content);
#endif

#if NET35 || NET40
                var myDeserializedData = response.Data;
#endif
                // Se ci sono errori nella chiamata di recupero dei dati esco 
                if (response.ErrorException != null)
                {
                    _InfoMessage = "Error retrieving response 2.  Check inner details for more info.";
                    return false;
                }

                if (response.Data.note.Count == 0)
                {
                     _InfoMessage = "Data not found";
                    return false;
                }

                LeadsNoteData = myDeserializedData;

            }
            catch (Exception ex)
            {
                throw new Exception("AMHelper: [" + _ResponseURI + "]", ex);
            }
            return true;
        }

        public bool exp_clifor(int StartID, ref ws_rec_clifor CliforData)
        {
            try
            {
                var client = new RestClient(_CliforUrl);

                // Seconda chiamata. Estraggo tutto gli ordini (niente paginazione)
                // ---------------------------------------------------------------
                // http://am.apexnet.it/api_appstore_ib/v1/progetti/ib.appstore/exportPaginazione/leads?authKey=AAB993AE-92B7-4E88-BC59-B231F0CDAD7C&format=json&offset=0&limit=7&count=0&lastID=0
                var request = new RestRequest(Method.GET);
                request.AddParameter("authKey", this.AuthKeyAM);
                request.AddParameter("format", "json");
                request.AddParameter("offset", 0);
                request.AddParameter("limit", 50);
                request.AddParameter("count", 0);
                request.AddParameter("lastID", StartID);
                //request.AddParameter("lastDateImport", "");       
                var response = client.Execute<ws_rec_clifor>(request);

                _ResponseURI = response.ResponseUri.ToString();

#if NET20 
                var myDeserializedData = JsonConvert.DeserializeObject<ws_rec_clifor>(response.Content);
#endif

#if NET35 || NET40
                var myDeserializedData = response.Data;
#endif

                // Se ci sono errori nella chiamata di recupero dei dati esco 
                if (response.ErrorException != null)
                {
                    _InfoMessage = "Error retrieving response 2.  Check inner details for more info.";
                    return false;
                }

                if (response.Data.clienti.Count == 0)
                {
                    _InfoMessage = "Data not found";
                    return false;
                }
   
                // Preparo una lista in cui mettere il resultset della query linq
                CliforData = myDeserializedData;

            }
            catch (Exception ex)
            {
                throw new Exception("AMHelper: [" + _ResponseURI + "]", ex);
            }
            return true;
        }

        public bool exp_clifor_note(int StartID, ref ws_rec_clifor_note CliforNoteData)
        {
            try
            {
                var client = new RestClient(_CliforNoteUrl);

                // Seconda chiamata. Estraggo tutto gli ordini (niente paginazione)
                // ---------------------------------------------------------------
                // http://am.apexnet.it/api_appstore_ib/v1/progetti/ib.appstore/exportPaginazione/leads?authKey=AAB993AE-92B7-4E88-BC59-B231F0CDAD7C&format=json&offset=0&limit=7&count=0&lastID=0
                var request = new RestRequest(Method.GET);
                request.AddParameter("authKey", this.AuthKeyAM);
                request.AddParameter("format", "json");
                request.AddParameter("offset", 0);
                request.AddParameter("limit", 50);
                request.AddParameter("count", 0);
                request.AddParameter("lastID", StartID);
                //request.AddParameter("lastDateImport", "");       
                var response = client.Execute<ws_rec_clifor_note>(request);

                _ResponseURI = response.ResponseUri.ToString();
#if NET20 
                var myDeserializedData = JsonConvert.DeserializeObject<ws_rec_clifor_note>(response.Content);
#endif

#if NET35 || NET40
                var myDeserializedData = response.Data;
#endif

                // Se ci sono errori nella chiamata di recupero dei dati esco 
                if (response.ErrorException != null)
                {
                    _InfoMessage = "Error retrieving response 2.  Check inner details for more info.";
                    return false;
                }

                if (response.Data.note.Count == 0)
                {
                    _InfoMessage = "Data not found";
                    return false;
                }

                CliforNoteData = myDeserializedData;

            }
            catch (Exception ex)
            {
                throw new Exception("AMHelper: [" + _ResponseURI + "]", ex);
            }
            return true;
        }

        public bool exp_orders(int StartID, ref ws_rec_orders OrdersData)
        {
            try
            {
                var client = new RestClient(_OrdersUrl);

                // Estraggo gli ordini (50 alla volta)
                // ---------------------------------------------------------------
                // http://test.apexnet.it/appmanager/api/v1/progetti/iorder.test2/exportPaginazione/ordini?authKey=E24EFDA3-9878-42D8-90FE-C00F847FE434&format=json&lastID=1&count=0&limit=50
                var request = new RestRequest(Method.GET);
                request.AddParameter("authKey", this.AuthKeyAM);
                request.AddParameter("format", "json");
                request.AddParameter("offset", 0);
                request.AddParameter("limit", 50); // quanti ne elaboro al massimo ?
                request.AddParameter("count", 0);  // count = 0 ritorna i dati. Se = 1 ritorna solo alcune statistiche
                request.AddParameter("lastID", StartID);

                // request.RequestFormat = DataFormat.Json;
                // request.JsonSerializer = new RestSharpJsonNetSerializer();

                //Console.WriteLine("1" + _OrdersUrl + "-" + this.AuthKeyAM);

                //request.AddParameter("lastDateImport", "");       
                var response = client.Execute<ws_rec_orders>(request);

                
                _ResponseURI = response.ResponseUri.ToString();


                // La serializzazione di RestSharp scazza le date con il .net framework 2.0.
                // Deserializzo i dati in un altro modo

#if NET20 
                var myDeserializedData = JsonConvert.DeserializeObject<ws_rec_orders>(response.Content);
#endif

#if NET35 || NET40
                var myDeserializedData = response.Data;
#endif

                //Console.WriteLine("5");

                // Se ci sono errori nella chiamata di recupero dei dati esco 
                if (response.ErrorException != null)
                {
                    _InfoMessage = "Error retrieving response 2.  Check inner details for more info.";
                    return false;
                }

                if (response.Data.testate.Count == 0)
                {
                    _InfoMessage = "Data not found";
                    return false;
                }

                OrdersData = myDeserializedData;

            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.Message);
                //Console.WriteLine(_InfoMessage);
                throw new Exception("AMHelper: [" + _ResponseURI + "]", ex);
            }
            return true;
        }
 
    }
}
