/***
 * Lockstep Platform SDK for C#
 *
 * (c) 2021-2023 Lockstep, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * @author     Lockstep Network <support@lockstep.io>
 * @copyright  2021-2023 Lockstep, Inc.
 * @link       https://github.com/Lockstep-Network/lockstep-sdk-csharp
 */



using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using LockstepSDK.Models;


namespace LockstepSDK.Clients
{
    /// <summary>
    /// API methods related to ProfilesCompanies
    /// </summary>
    public class ProfilesCompaniesClient
    {
        private readonly LockstepApi _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public ProfilesCompaniesClient(LockstepApi client)
        {
            _client = client;
        }

        /// <summary>
        /// Retrieves the Public Company Profile specified by the public url slug.
        ///
        /// A Public Company Profile makes available the following information: &lt;ul&gt;&lt;li&gt;Company Name&lt;/li&gt;&lt;li&gt;Company Logo Url&lt;/li&gt;&lt;li&gt;Description&lt;/li&gt;&lt;li&gt;Website&lt;/li&gt;&lt;/ul&gt;
        ///
        /// </summary>
        /// <param name="urlSlug"></param>
        public async Task<LockstepResponse<PublicCompanyProfileModel>> RetrievePublicCompanyProfile(string urlSlug)
        {
            var url = $"/api/v1/profiles/companies/{urlSlug}";
            return await _client.Request<PublicCompanyProfileModel>(HttpMethod.Get, url, null, null, null);
        }

        /// <summary>
        /// Queries Public Company Profiles
        ///
        /// More information on querying can be found on the [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight) page on the Lockstep Developer website.
        ///
        /// A Public Company Profile makes available the following information:
        ///
        /// &lt;ul&gt;&lt;li&gt;Company Name&lt;/li&gt;&lt;li&gt;Company Logo Url&lt;/li&gt;&lt;li&gt;Description&lt;/li&gt;&lt;li&gt;Website&lt;/li&gt;&lt;/ul&gt;
        ///
        /// </summary>
        /// <param name="filter">The filter for this query. See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        /// <param name="order">The sort order for the results, in the [Searchlight order syntax](https://github.com/tspence/csharp-searchlight).</param>
        /// <param name="pageSize">The page size for results (default 250, maximum of 500)</param>
        /// <param name="pageNumber">The page number for results (default 0)</param>
        public async Task<LockstepResponse<FetchResult<PublicCompanyProfileModel>>> QueryPublicCompanyProfiles(string filter = null, string order = null, int? pageSize = null, int? pageNumber = null)
        {
            var url = $"/api/v1/profiles/companies/query";
            var options = new Dictionary<string, object>();
            if (filter != null) { options["filter"] = filter; }
            if (order != null) { options["order"] = order; }
            if (pageSize != null) { options["pageSize"] = pageSize; }
            if (pageNumber != null) { options["pageNumber"] = pageNumber; }
            return await _client.Request<FetchResult<PublicCompanyProfileModel>>(HttpMethod.Get, url, options, null, null);
        }
    }
}
