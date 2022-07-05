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
#endif


//using RestSharp.Serializers;

namespace AMHelper.WS
{
    /*
    public class GetDataLMException : Exception
    {

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

    public class GetDataLM
    {



        // private string _ParamUrl;
        // private string _InfoMessage;
        private string _ResponseURI;
        private string _CodProgetto;

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

        // Private fields
        private string _AuthKeyLM;
        private bool _Production;

        // Property AuthKey
        private string AuthKeyLM
        {
            get
            {
                return _AuthKeyLM;
            }
            set
            {
                _AuthKeyLM = value;
            }
        }

        private bool Production
        {
            get
            {
                return _Production;
            }
            set
            {
                _Production = value;
            }
        }

        public void HttpProxyAutentication(string ProxyUser, string ProxyPassword, string ProxyHost, int ProxyPort)
        {
            this._ProxyUser = ProxyUser;
            this._ProxyPassword = ProxyPassword;
            this._ProxyHost = ProxyHost;
            this._ProxyPort = ProxyPort;
        }

        public GetDataLM(string AuthKeyLM)
        {

            this.AuthKeyLM = AuthKeyLM;
            this.Production = true;
            Certificates.IgnoreBadCertificates();
        }

        public GetDataLM(string AuthKey, bool Production)
        {
            this.AuthKeyLM = AuthKey;
            this.Production = Production;
            Certificates.IgnoreBadCertificates();

        }

        public bool get_am_par(ref ws_rec_lmparam AMData, string url = "")
        {
            string ServiceUrl =url;


            //if (string.IsNullOrEmpty(url))
            //{
            //    if (Production)
            //    {
            //        ServiceUrl = @"http://lm.giessedati.it/lmAPI/v1/getAMParam";
            //    }
            //    else
            //    {
            //        ServiceUrl = @"http://test.giessedati.it/licenseManagerAPI/v1/getAMParam";
            //    }
            //}
            //else
            //{
            //    ServiceUrl = url;
            //}

            try
            {


                var client = new RestClient(ServiceUrl);

                if (!String.IsNullOrEmpty(this._ProxyUser))
                {
                    client.Proxy = new WebProxy(_ProxyHost, _ProxyPort);
                    client.Proxy.Credentials = new NetworkCredential(_ProxyUser, _ProxyPassword);
                }


                var request = new RestRequest("/", Method.POST);

                request.RequestFormat = DataFormat.Json;
                request.AddBody(new { AuthKeyAPI = AuthKeyLM });
                var response = client.Execute<ws_rec_lmparam>(request);

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
                var myDeserializedData = JsonConvert.DeserializeObject<ws_rec_lmparam>(response.Content);
#endif

#if NET35 || NET40
                var myDeserializedData = response.Data;
#endif

                _ResponseURI = response.ResponseUri.ToString();

                AMData = myDeserializedData;

                if (AMData != null)
                {
                    _CodProgetto = AMData.cod_prog;
                    AMData.url_am = AMData.url_am;
                }


            }
            catch (Exception ex)
            {
                throw new Exception("get_am_par: " + ex.Message, ex);
            }
            return true;
        }


        public bool send_release(string Release)
        {
            string ServiceUrl;

            if (Production)
            {
                ServiceUrl = @"http://lm.giessedati.it/lmAPI/v1/update_versione_connettore";
            }
            else
            {
                ServiceUrl = @"http://test.giessedati.it/licenseManagerAPI/v1/update_versione_connettore";
            }

            try
            {
                var client = new RestClient(ServiceUrl);

                if (!String.IsNullOrEmpty(this._ProxyUser))
                {
                    client.Proxy = new WebProxy(_ProxyHost, _ProxyPort);
                    client.Proxy.Credentials = new NetworkCredential(_ProxyUser, _ProxyPassword);
                }


                var request = new RestRequest("/", Method.POST);

                request.RequestFormat = DataFormat.Json;
                request.AddBody(new { CodiceProgetto = _CodProgetto, Versione = Release });
                var response = client.Execute(request);
            }
            catch (Exception ex)
            {
                throw new Exception("send_release: " + ex.Message, ex);
            }

            return true;
        }


        public bool send_push_notification_by_agent(string pCodAgente, string pMessaggio)
        {
            string ServiceUrl;

            if (Production)
            {
                ServiceUrl = @"http://lm.giessedati.it/lmAPI/v1/notifica_push_send";
            }
            else
            {
                ServiceUrl = @"http://test.giessedati.it/licenseManagerAPI/v1/notifica_push_send";
            }

            try
            {
                var client = new RestClient(ServiceUrl);

                if (!String.IsNullOrEmpty(this._ProxyUser))
                {
                    client.Proxy = new WebProxy(_ProxyHost, _ProxyPort);
                    client.Proxy.Credentials = new NetworkCredential(_ProxyUser, _ProxyPassword);
                }


                var request = new RestRequest("/", Method.POST);

                request.RequestFormat = DataFormat.Json;
                request.AddBody(new { CodiceProgetto = _CodProgetto, CodiceAgente = pCodAgente, Messaggio = pMessaggio });
                var response = client.Execute(request);
            }
            catch (Exception ex)
            {
                throw new Exception("send_push_notification: " + ex.Message, ex);
            }

            return true;
        }

        public bool send_push_notification_by_username(string pUsername, string pMessaggio)
        {
            string ServiceUrl;

            if (Production)
            {
                ServiceUrl = @"http://lm.giessedati.it/lmAPI/v1/notifica_push_send_by_username";
            }
            else
            {
                ServiceUrl = @"http://test.giessedati.it/licenseManagerAPI/v1/notifica_push_send_by_username";
            }

            try
            {
                var client = new RestClient(ServiceUrl);

                if (!String.IsNullOrEmpty(this._ProxyUser))
                {
                    client.Proxy = new WebProxy(_ProxyHost, _ProxyPort);
                    client.Proxy.Credentials = new NetworkCredential(_ProxyUser, _ProxyPassword);
                }


                var request = new RestRequest("/", Method.POST);

                request.RequestFormat = DataFormat.Json;
                request.AddBody(new { CodiceProgetto = _CodProgetto, Username = pUsername, Messaggio = pMessaggio });
                var response = client.Execute(request);
            }
            catch (Exception ex)
            {
                throw new Exception("notifica_push_send_by_username: " + ex.Message, ex);
            }

            return true;
        }
    }
}
