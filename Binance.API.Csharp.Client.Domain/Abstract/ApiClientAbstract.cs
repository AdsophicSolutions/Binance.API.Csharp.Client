using System;
using System.Collections.Generic;
using System.Net.Http;
using WebSocketSharp;

namespace Binance.API.Csharp.Client.Domain.Abstract
{
    public abstract class ApiClientAbstract
    {
        /// <summary>
        /// Secret used to authenticate within the API.
        /// </summary>
        protected string APIUrl { get; }

        /// <summary>
        /// Key used to authenticate within the API.
        /// </summary>
        protected string APIKey { get; }

        /// <summary>
        /// API secret used to signed API calls.
        /// </summary>
        protected string APISecret { get; }

        /// <summary>
        /// HttpClient to be used to call the API.
        /// </summary>
        protected HttpClient ConnectionClient { get; }

        /// <summary>
        /// URL of the WebSocket Endpoint
        /// </summary>
        protected string WebSocketEndPoint { get; }

        /// <summary>
        /// Used to store all the opened web sockets.
        /// </summary>
        protected List<WebSocket> OpenSockets { get; }
        
        /// <summary>
        /// Defines the constructor of the Api Client.
        /// </summary>
        /// <param name="apiKey">Key used to authenticate within the API.</param>
        /// <param name="apiSecret">API secret used to signed API calls.</param>
        /// <param name="apiUrl">API based url.</param>
        public ApiClientAbstract(string apiKey, 
            string apiSecret, 
            string apiUrl = @"https://www.binance.com", 
            string webSocketEndpoint = @"wss://stream.binance.com:9443/ws/", 
            bool addDefaultHeaders = true)
        {
            APIUrl = apiUrl;
            APIKey = apiKey;
            APISecret = apiSecret;
            WebSocketEndPoint = webSocketEndpoint;
            OpenSockets = new List<WebSocket>();
            ConnectionClient = new HttpClient
            {
                BaseAddress = new Uri(APIUrl)
            };

            if (addDefaultHeaders)
            {
                ConfigureHttpClient();
            }
        }

        /// <summary>
        /// Configures the HTTPClient.
        /// </summary>
        private void ConfigureHttpClient()
        {
            ConnectionClient.DefaultRequestHeaders
                 .Add("X-MBX-APIKEY", APIKey);

            ConnectionClient.DefaultRequestHeaders
                    .Accept
                    .Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
