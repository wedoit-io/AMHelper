﻿using System;
using System.Collections.Generic;
using System.Net;
//using System.Collections.IEnumerable;
using System.Text;
using System.IO;


#if NET20
  using RestSharpApex;
  using NewtonsoftApex.Json;
#endif

#if NET35 || NET40
  using RestSharp;
using RestSharp.Deserializers;
#endif

//using RestSharp.Serializers;

namespace AMHelper.WS
{
    /*
    public class GetDataAMException : Exception
    {

         *
         * base(message, this.InnerException)
         *
        public EmployeeListNotFoundException()
        {
        }

        public EmployeeListNotFoundException(string message)
            : base(message)
        {
        }

        public EmployeeListNotFoundException(string message, Exception inner)
            : base(message, inner)
        {
        }

    }
     */

    public class GetDataAM
    {
        // Private fields
        private string _LeadsUrl;
        private string _LeadsNoteUrl;
        private string _AttivitaUrl;
        private string _CliforUrl;
        private string _CliforNoteUrl;
        private string _OrdersUrl;
        private string _InfoMessage;
        private string _ResponseURI;

        // Proxy fields
        private string _ProxyUser;
        private string _ProxyPassword;
        private string _ProxyHost;
        private int _ProxyPort;

        // Proxy properties

        private string ProxyHost
        {
            get
            {
                return _ProxyHost;
            }
            set
            {
                _ProxyHost = value;
            }
        }

        private int ProxyPort
        {
            get
            {
                return _ProxyPort;
            }
            set
            {
                _ProxyPort = value;
            }
        }
        private string ProxyUser
        {
            get
            {
                return _ProxyUser;
            }
            set
            {
                _ProxyUser = value;
            }
        }
        private string ProxyPassword
        {
            get
            {
                return _ProxyPassword;
            }
            set
            {
                _ProxyPassword = value;
            }
        }


        public void HttpProxyAutentication(string ProxyUser, string ProxyPassword, string ProxyHost, int ProxyPort)
        {
            this._ProxyUser = ProxyUser;
            this._ProxyPassword = ProxyPassword;
            this._ProxyHost = ProxyHost;
            this._ProxyPort = ProxyPort;
        }


        private string _AuthKeyAM;
        private string _BaseUrl;

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
                _AttivitaUrl = value + "/" + "exportPaginazione/codaAttivita";
                _CliforUrl = value + "/" + "exportPaginazione/codaClienti";
                _CliforNoteUrl = value + "/" + "exportPaginazione/codaClienteNote";
                _OrdersUrl = value + "/" + "exportPaginazione/codaOrdini";
                _InfoMessage = value;
                _ResponseURI = value;
            }
        }

        /// <summary>
        /// Istanzia l'oggetto per la chiamata alle api
        /// </summary>
        /// <param name="AuthKeyAM">Chiave di autenticazione AM (AuthKeyAM)</param>
        /// <param name="BaseUrl">Base url del servizio</param>
        public GetDataAM(string AuthKeyAM, string BaseUrl)
        {
            this.AuthKeyAM = AuthKeyAM;
            this.BaseUrl = BaseUrl;
            Certificates.IgnoreBadCertificates();
        }

        public bool exp_leads(int StartID, ref ws_rec_leads LeadsData)
        {
            try
            {
                var client = new RestClient(_LeadsUrl);

                if (!String.IsNullOrEmpty(this._ProxyUser))
                {
                    client.Proxy = new WebProxy(_ProxyHost, _ProxyPort);
                    client.Proxy.Credentials = new NetworkCredential(_ProxyUser, _ProxyPassword);
                }

                // Seconda chiamata. Estraggo tutto gli ordini (niente paginazione)
                // ---------------------------------------------------------------
                // http://am.giessedati.it/api_appstore_ib/v1/progetti/ib.appstore/exportPaginazione/leads?authKey=AAB993AE-92B7-4E88-BC59-B231F0CDAD7C&format=json&offset=0&limit=7&count=0&lastID=0
                var request = new RestRequest(Method.GET);
                request.AddParameter("authKey", this.AuthKeyAM);
                request.AddParameter("format", "json");
                request.AddParameter("offset", 0);
                request.AddParameter("limit", 50);
                request.AddParameter("count", 0);
                request.AddParameter("lastID", StartID);
                //request.AddParameter("lastDateImport", "");

                var response = client.Execute<ws_rec_leads>(request);

                if (response.ResponseStatus != ResponseStatus.Completed)
                {
                    throw new Exception("ResponseStatus: " + response.ErrorMessage);
                }

                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new Exception("StatusCode: " + response.StatusCode);
                }

                if (response.ErrorException != null)
                {
                    throw new Exception("Error retrieving response 2.  Check inner details for more info.");
                }

#if NET20
                var myDeserializedData = JsonConvert.DeserializeObject<ws_rec_leads>(response.Content);
#endif

#if NET35 || NET40
                var myDeserializedData = response.Data;
#endif

                _ResponseURI = response.ResponseUri.ToString();

                if (response.Data.leads.Count == 0)
                {
                    _InfoMessage = "Data not found";
                    return false;
                }

                LeadsData = myDeserializedData;

            }
            catch (Exception ex)
            {
                throw new Exception("exp_leads: Uri:" + _ResponseURI + ", Message:" + ex.Message, ex);
            }
            return true;
        }

        public bool exp_leads_note(int StartID, ref ws_rec_leads_note LeadsNoteData)
        {
            try
            {
                var client = new RestClient(_LeadsNoteUrl);

                if (!String.IsNullOrEmpty(this._ProxyUser))
                {
                    client.Proxy = new WebProxy(_ProxyHost, _ProxyPort);
                    client.Proxy.Credentials = new NetworkCredential(_ProxyUser, _ProxyPassword);
                }


                // Seconda chiamata. Estraggo tutto gli ordini (niente paginazione)
                // ---------------------------------------------------------------
                // http://am.giessedati.it/api_appstore_ib/v1/progetti/ib.appstore/exportPaginazione/notelead?authKey=AAB993AE-92B7-4E88-BC59-B231F0CDAD7C&format=json&lastID=0&count=0
                var request = new RestRequest(Method.GET);
                request.AddParameter("authKey", this.AuthKeyAM);
                request.AddParameter("format", "json");
                request.AddParameter("offset", 0);
                request.AddParameter("limit", 50);
                request.AddParameter("count", 0);
                request.AddParameter("lastID", StartID);
                //request.AddParameter("lastDateImport", "");
                var response = client.Execute<ws_rec_leads_note>(request);

                if (response.ResponseStatus != ResponseStatus.Completed)
                {
                    throw new Exception("ResponseStatus: " + response.ErrorMessage);
                }

                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new Exception("StatusCode: " + response.StatusCode);
                }

                if (response.ErrorException != null)
                {
                    throw new Exception("Error retrieving response 2.  Check inner details for more info.");
                }

#if NET20
                var myDeserializedData = JsonConvert.DeserializeObject<ws_rec_leads_note>(response.Content);
#endif

#if NET35 || NET40
                var myDeserializedData = response.Data;
#endif

                _ResponseURI = response.ResponseUri.ToString();

                if (response.Data.note.Count == 0)
                {
                     _InfoMessage = "Data not found";
                    return false;
                }

                LeadsNoteData = myDeserializedData;

            }
            catch (Exception ex)
            {
                throw new Exception("exp_leads_note: Uri:" + _ResponseURI + ", Message:" + ex.Message, ex);
            }
            return true;
        }

        public bool exp_attivita(int StartID, ref ws_rec_attivita AttivitaData)
        {
            try
            {
                var client = new RestClient(_AttivitaUrl);

                if (!String.IsNullOrEmpty(this._ProxyUser))
                {
                    client.Proxy = new WebProxy(_ProxyHost, _ProxyPort);
                    client.Proxy.Credentials = new NetworkCredential(_ProxyUser, _ProxyPassword);
                }


                // Seconda chiamata. Estraggo tutto gli ordini (niente paginazione)
                // ---------------------------------------------------------------
                // http://am.giessedati.it/api_appstore_ib/v1/progetti/ib.appstore/exportPaginazione/notelead?authKey=AAB993AE-92B7-4E88-BC59-B231F0CDAD7C&format=json&lastID=0&count=0
                var request = new RestRequest(Method.GET);
                request.AddParameter("authKey", this.AuthKeyAM);
                request.AddParameter("format", "json");
                request.AddParameter("offset", 0);
                request.AddParameter("limit", 50);
                request.AddParameter("count", 0);
                request.AddParameter("lastID", StartID);
                //request.AddParameter("lastDateImport", "");
                var response = client.Execute<ws_rec_attivita>(request);

                if (response.ResponseStatus != ResponseStatus.Completed)
                {
                    throw new Exception("ResponseStatus: " + response.ErrorMessage);
                }

                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new Exception("StatusCode: " + response.StatusCode);
                }

                if (response.ErrorException != null)
                {
                    throw new Exception("Error retrieving response 2.  Check inner details for more info.");
                }

#if NET20
                var myDeserializedData = JsonConvert.DeserializeObject<ws_rec_attivita>(response.Content);
#endif

#if NET35 || NET40
                var myDeserializedData = response.Data;
#endif

                _ResponseURI = response.ResponseUri.ToString();

                if (response.Data.attivita.Count == 0)
                {
                    _InfoMessage = "Data not found";
                    return false;
                }

                AttivitaData = myDeserializedData;

            }
            catch (Exception ex)
            {
                throw new Exception("exp_attivita: Uri:" + _ResponseURI + ", Message:" + ex.Message, ex);
            }
            return true;
        }

        public bool exp_clifor(int StartID, ref ws_rec_clifor CliforData)
        {
            try
            {
                var client = new RestClient(_CliforUrl);

                if (!String.IsNullOrEmpty(this._ProxyUser))
                {
                    client.Proxy = new WebProxy(_ProxyHost, _ProxyPort);
                    client.Proxy.Credentials = new NetworkCredential(_ProxyUser, _ProxyPassword);
                }


                // Seconda chiamata. Estraggo tutto gli ordini (niente paginazione)
                // ---------------------------------------------------------------
                // http://am.giessedati.it/api_appstore_ib/v1/progetti/ib.appstore/exportPaginazione/leads?authKey=AAB993AE-92B7-4E88-BC59-B231F0CDAD7C&format=json&offset=0&limit=7&count=0&lastID=0
                var request = new RestRequest(Method.GET);
                request.AddParameter("authKey", this.AuthKeyAM);
                request.AddParameter("format", "json");
                request.AddParameter("offset", 0);
                request.AddParameter("limit", 50);
                request.AddParameter("count", 0);
                request.AddParameter("lastID", StartID);
                //request.AddParameter("lastDateImport", "");
                var response = client.Execute<ws_rec_clifor>(request);

                if (response.ResponseStatus != ResponseStatus.Completed)
                {
                    throw new Exception("ResponseStatus: " + response.ErrorMessage);
                }

                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new Exception("StatusCode: " + response.StatusCode);
                }

                if (response.ErrorException != null)
                {
                    throw new Exception("Error retrieving response 2.  Check inner details for more info.");
                }

#if NET20
                var myDeserializedData = JsonConvert.DeserializeObject<ws_rec_clifor>(response.Content);
#endif

#if NET35 || NET40
                var myDeserializedData = response.Data;
#endif

                _ResponseURI = response.ResponseUri.ToString();

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
                throw new Exception("exp_clifor: Uri:" + _ResponseURI + ", Message:" + ex.Message, ex);
            }
            return true;
        }

        public bool exp_clifor_note(int StartID, ref ws_rec_clifor_note CliforNoteData)
        {
            try
            {
                var client = new RestClient(_CliforNoteUrl);

                if (!String.IsNullOrEmpty(this._ProxyUser))
                {
                    client.Proxy = new WebProxy(_ProxyHost, _ProxyPort);
                    client.Proxy.Credentials = new NetworkCredential(_ProxyUser, _ProxyPassword);
                }


                // Seconda chiamata. Estraggo tutto gli ordini (niente paginazione)
                // ---------------------------------------------------------------
                // http://am.giessedati.it/api_appstore_ib/v1/progetti/ib.appstore/exportPaginazione/leads?authKey=AAB993AE-92B7-4E88-BC59-B231F0CDAD7C&format=json&offset=0&limit=7&count=0&lastID=0
                var request = new RestRequest(Method.GET);
                request.AddParameter("authKey", this.AuthKeyAM);
                request.AddParameter("format", "json");
                request.AddParameter("offset", 0);
                request.AddParameter("limit", 50); // quanti ne elaboro al massimo ?
                request.AddParameter("lastDateImport", null);  // count = 0 ritorna i dati. Se = 1 ritorna solo alcune statistiche
                request.AddParameter("count", 0);  // count = 0 ritorna i dati. Se = 1 ritorna solo alcune statistiche
                request.AddParameter("lastID", StartID);


                //request.AddParameter("lastDateImport", "");
                var response = client.Execute<ws_rec_clifor_note>(request);

                if (response.ResponseStatus != ResponseStatus.Completed)
                {
                    throw new Exception("ResponseStatus: " + response.ErrorMessage);
                }

                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new Exception("StatusCode: " + response.StatusCode);
                }

                if (response.ErrorException != null)
                {
                    throw new Exception("Error retrieving response 2.  Check inner details for more info.");
                }

#if NET20
                var myDeserializedData = JsonConvert.DeserializeObject<ws_rec_clifor_note>(response.Content);
#endif

#if NET35 || NET40
                var myDeserializedData = response.Data;
#endif

                _ResponseURI = response.ResponseUri.ToString();

                if (response.Data.note.Count == 0)
                {
                    _InfoMessage = "Data not found";
                    return false;
                }

                CliforNoteData = myDeserializedData;

            }
            catch (Exception ex)
            {
                throw new Exception("exp_clifor_note: Uri:" + _ResponseURI + ", Message:" + ex.Message, ex);
            }
            return true;
        }

        public bool exp_orders(int StartID, ref ws_rec_orders OrdersData, int count = 0, int offset = 0, int? limit = null)
        {
            try
            {
                var client = new RestClient(_OrdersUrl);

                if (!String.IsNullOrEmpty(this._ProxyUser))
                {
                    client.Proxy = new WebProxy(_ProxyHost, _ProxyPort);
                    client.Proxy.Credentials = new NetworkCredential(_ProxyUser, _ProxyPassword);
                }

                // Estraggo gli ordini (50 alla volta)
                // ---------------------------------------------------------------
                // http://test.giessedati.it/appmanager/api/v1/progetti/iorder.test2/exportPaginazione/ordini?authKey=E24EFDA3-9878-42D8-90FE-C00F847FE434&format=json&lastID=1&count=0&limit=50
                var request = new RestRequest(Method.GET);
                request.AddParameter("authKey", this.AuthKeyAM);
                request.AddParameter("format", "json");
                request.AddParameter("offset", offset);
                if (limit.HasValue)
                {
                    request.AddParameter("limit", limit.Value); // quanti ne elaboro al massimo ?
                }
                request.AddParameter("lastDateImport", null);  // count = 0 ritorna i dati. Se = 1 ritorna solo alcune statistiche
                request.AddParameter("count", count);  // count = 0 ritorna i dati. Se = 1 ritorna solo alcune statistiche
                request.AddParameter("lastID", StartID);
                request.AddParameter("statusExport", null);

                // request.RequestFormat = DataFormat.Json;
                // request.JsonSerializer = new RestSharpJsonNetSerializer();

                //Console.WriteLine("1" + _OrdersUrl + "-" + this.AuthKeyAM);

                //request.AddParameter("lastDateImport", "");
               // var response = client.Execute<ws_rec_orders>(request);
                var response = client.Execute(request);

                if (response.ResponseStatus != ResponseStatus.Completed)
                {
                    throw new Exception("ResponseStatus: " + response.ErrorMessage);
                }

                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new Exception("StatusCode: " + response.StatusCode + ", Content: " + response.Content);
                }

                if (response.ErrorException != null)
                {
                    throw new Exception("Error retrieving response 2.  Check inner details for more info.");
                }

                // La serializzazione di RestSharp scazza le date con il .net framework 2.0.
                // Faccio la deserializzazione in 2 modi diversi.
                // Nel primo caso uso JsonConvert della vecchia libreria RestShar compilata col framework 2.0
                // (in cui ho rinominato i namespace per un conflitto con l'installazione su Business)
                // Nel secondo caso uso il deserializzatore di RestSharp

#if NET20
                var myDeserializedData = JsonConvert.DeserializeObject<ws_rec_orders>(response.Content);
#endif

#if NET35 || NET40

                 JsonDeserializer deserial = new JsonDeserializer();
                 var myDeserializedData = deserial.Deserialize<ws_rec_orders>(response);
#endif

                _ResponseURI = response.ResponseUri.ToString();

                if (myDeserializedData.testate != null && count == 0)
                {
                    if (myDeserializedData.testate.Count == 0)
                    {
                        _InfoMessage = "Data not found";
                        return false;
                    }
                }

                OrdersData = myDeserializedData;

            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.Message);
                //Console.WriteLine(_InfoMessage);
                throw new Exception("exp_orders: Uri:" + _ResponseURI + ", Message:" + ex.Message, ex);
            }
            return true;
        }

    }
}
