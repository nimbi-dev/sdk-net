using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nimbi.SDK
{
    public class NimbiClient
    {
        /// <summary>
        /// HTTP Header name for API ID.
        /// </summary>
        public const string API_ID = "ClientAPI_ID";

        /// <summary>
        /// HTTP Header name for API Key.
        /// </summary>
        public const string API_KEY = "ClientAPI_Key";

        public string apiId { get; }
        public string apiKey { get; }
        public Environments environment { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="environment">The target environment.</param>
        /// <param name="apiId">The API ID.</param>
        /// <param name="apiKey">The API Key.</param>
        public NimbiClient(Environments environment, string apiId, string apiKey)
        {
            this.apiId = apiId;
            this.apiKey = apiKey;
            this.environment = environment;
        }
    }

    public class Environments
    {
        private Environments(string host) { Value = host; }

        public string Value { get; set; }

        public static Environments QA { get { return new Environments("https://api01-qa.nimbi.net.br"); } }
        public static Environments PRODUCTION { get { return new Environments("https://api001.nimbi.com.br"); } }
    }
}
