/*
 * GeniusReferrals.UWP
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ) on 02/18/2017
 */
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Converters;
using GeniusReferrals.UWP;
using GeniusReferrals.UWP.Utilities;
using GeniusReferrals.UWP.Http.Request;
using GeniusReferrals.UWP.Http.Response;
using GeniusReferrals.UWP.Http.Client;
using GeniusReferrals.UWP.Exceptions;
using GeniusReferrals.UWP.Models;

namespace GeniusReferrals.UWP.Controllers
{
    public partial class RootsController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static RootsController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static RootsController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new RootsController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// The root of the API
        /// </summary>
        /// <return>Returns the dynamic response from the API call</return>
        public dynamic GetRoot()
        {
            Task<dynamic> t = GetRootAsync();
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// The root of the API
        /// </summary>
        /// <return>Returns the dynamic response from the API call</return>
        public async Task<dynamic> GetRootAsync()
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/");


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" }
            };
            _headers.Add("Content-Type", Configuration.ContentType);
            _headers.Add("X-Auth-Token", Configuration.XAuthToken);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<dynamic>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

    }
} 