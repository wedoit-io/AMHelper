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
    public class GetDataLM
    {        
        // Private fields
        private string _AuthKeyLM;
        private bool   _Production;

        private string _ParamUrl;

        private string _InfoMessage;
        private string _ResponseURI;

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
        public GetDataLM(string AuthKeyLM)
        {
            this.AuthKeyLM = AuthKeyLM;
            this.Production = true;
        }

        public GetDataLM(string AuthKey, bool Production)
        {
            this.AuthKeyLM = AuthKey;
            this.Production = Production;
        }

        public bool get_am_par(ref ws_rec_lmparam AMData)
        {
            string ServiceUrl = "";
            if (Production)
            {
                ServiceUrl = @"http://lm.apexnet.it/lmAPI/v1/getAMParam";
            }
            else
            {
                ServiceUrl = @"http://test.apexnet.it/licenseManagerAPI/v1/getAMParam";
            }

            try
            {
                
                var client = new RestClient(ServiceUrl);
                var request = new RestRequest("/", Method.POST);

                request.RequestFormat = DataFormat.Json;
                request.AddBody(new { AuthKeyAPI = AuthKeyLM });
                var response = client.Execute<ws_rec_lmparam>(request);

                _ResponseURI = response.ResponseUri.ToString();


#if NET20 
                var myDeserializedData = JsonConvert.DeserializeObject<ws_rec_lmparam>(response.Content);
#endif

#if NET40
                var myDeserializedData = response.Data;
#endif

                // Se ci sono errori nella chiamata di recupero dei dati esco 
                if (response.ErrorException != null)
                {
                    _InfoMessage = "Error retrieving response 2.  Check inner details for more info.";
                    return false;
                }

                if (response.StatusCode !=  HttpStatusCode.OK)
                {
                    _InfoMessage = "Data not found + Status code:" + response.StatusCode;
                    return false;
                }

                AMData = myDeserializedData;
            }
            catch (Exception ex)
            {
                throw new Exception("AMHelper:", ex);
            }
            return true;
        }
    }
}
