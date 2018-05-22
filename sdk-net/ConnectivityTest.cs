using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace Nimbi.SDK.API
{
    public class ConnectivityTest
    {
        public IRestResponse testConnectivity(NimbiClient nimbi)
        {
            var client = new RestClient(nimbi.environment.Value + "/API/rest/ConnectivityTest/v1/TestConnectivity");
            var request = new RestRequest(Method.GET);
            request.AddHeader(NimbiClient.API_ID, nimbi.apiId);
            request.AddHeader(NimbiClient.API_KEY, nimbi.apiKey);
            IRestResponse response = client.Execute(request);
            return response;
        }
    }
}
