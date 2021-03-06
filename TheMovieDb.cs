﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TmdbWrapper;
using TmdbWrapper.Search;
using TmdbWrapper.Utilities;
using Windows.Data.Json;

namespace TmdbWrapper
{
    /// <summary>
    /// The static that wraps The movie database service.
    /// It should be initilised with your API_KEY.
    /// You can apply for an API_KEY at www.TheMovieDb.org
    /// </summary>
    public static partial class TheMovieDb
    {
        /// <summary>
        /// The apikey that is used in all requests.
        /// </summary>
        public static string ApiKey { get; private set; }
        /// <summary>
        /// Language all the request uses if entered.
        /// </summary>
        public static string Language { get; private set; }

        /// <summary>
        /// Initialises the wrapper.
        /// </summary>
        /// <param name="apiKey">The apikey the requests will use.</param>       
        public static void Initialise(string apiKey) 
        {
            ApiKey = apiKey;
        }

        /// <summary>
        /// Initialises the wrapper.
        /// </summary>
        /// <param name="apiKey">The apikey the request will use.</param>       
        /// <param name="language">The language the requests will use.</param>
        public static void Initialise(string apiKey, string language)
        {
            ApiKey = apiKey;
            Language = language;
        }        

        
    }
}
