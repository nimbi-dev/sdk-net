using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nimbi.SDK.API;
using RestSharp;

namespace Nimbi.SDK.Test
{
    [TestClass]
    public class NimbiSDKTest
    {
        [TestMethod]
        public void basicTest()
        {
            NimbiClient client = new NimbiClient(Environments.QA, "[some_api_id]", "[some_api_key]");
            ConnectivityTest connectivityTest = new ConnectivityTest();
            IRestResponse response = connectivityTest.testConnectivity(client);
            Assert.IsTrue($"{{\"Errors\":[\"Invalid API Key. ([some_api_key])\"],\"StatusCode\":400}}".Equals(response.Content));
        }
    }
}
