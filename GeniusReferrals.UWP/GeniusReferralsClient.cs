/*
 * GeniusReferrals.UWP
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ) on 02/17/2017
 */
using System;
using GeniusReferrals.UWP.Controllers;
using GeniusReferrals.UWP.Http.Client;

namespace GeniusReferrals.UWP
{
    public partial class GeniusReferralsClient
    {

        /// <summary>
        /// Singleton access to Roots controller
        /// </summary>
        public RootsController Roots
        {
            get
            {
                return RootsController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Authentications controller
        /// </summary>
        public AuthenticationsController Authentications
        {
            get
            {
                return AuthenticationsController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Advocates controller
        /// </summary>
        public AdvocatesController Advocates
        {
            get
            {
                return AdvocatesController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Accounts controller
        /// </summary>
        public AccountsController Accounts
        {
            get
            {
                return AccountsController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Reports controller
        /// </summary>
        public ReportsController Reports
        {
            get
            {
                return ReportsController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Referrals controller
        /// </summary>
        public ReferralsController Referrals
        {
            get
            {
                return ReferralsController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to RedemptionRequests controller
        /// </summary>
        public RedemptionRequestsController RedemptionRequests
        {
            get
            {
                return RedemptionRequestsController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Bonuses controller
        /// </summary>
        public BonusesController Bonuses
        {
            get
            {
                return BonusesController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Campaigns controller
        /// </summary>
        public CampaignsController Campaigns
        {
            get
            {
                return CampaignsController.Instance;
            }
        }
        /// <summary>
        /// The shared http client to use for all API calls
        /// </summary>
        public IHttpClient SharedHttpClient
        {
            get
            {
                return BaseController.ClientInstance;
            }
            set
            {
                BaseController.ClientInstance = value;
            }        
        }
        
        /// <summary>
        /// Default constructor
        /// </summary>
        public GeniusReferralsClient() { }

        /// <summary>
        /// Client initialization constructor
        /// </summary>
        public GeniusReferralsClient(string contentType = "application/json", string xAuthToken = "3b9d11374b602fb47b987dff90f1c5940a1f377f")
        {
            Configuration.ContentType = contentType;
            Configuration.XAuthToken = xAuthToken;
        }
    }
}