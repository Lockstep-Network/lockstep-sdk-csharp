/***
 * Lockstep Software Development Kit for C#
 *
 * (c) 2021-2022 Lockstep, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * @author     Ted Spence <tspence@lockstep.io>
 * @copyright  2021-2022 Lockstep, Inc.
 * @version    2022.11.55
 * @link       https://github.com/Lockstep-Network/lockstep-sdk-csharp
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Web;


namespace LockstepSDK 
{
    /// <summary>
    /// A client object that connects to the Lockstep Platform API
    /// </summary>
    public class LockstepApi
    {
        // The URL of the environment we will use
        private readonly string _serverUrl;
        private const string _version = "2022.11.55";
        private readonly HttpClient _client;
        private string _appName;
        private string _bearerToken;
        private string _apiKey;
    
        /// <summary>
        /// Lockstep Platform methods related to {cat}
        /// </summary>
        public ActivitiesClient Activities { get; set; }
        /// <summary>
        /// Lockstep Platform methods related to {cat}
        /// </summary>
        public ApiKeysClient ApiKeys { get; set; }
        /// <summary>
        /// Lockstep Platform methods related to {cat}
        /// </summary>
        public AppEnrollmentsClient AppEnrollments { get; set; }
        /// <summary>
        /// Lockstep Platform methods related to {cat}
        /// </summary>
        public ApplicationsClient Applications { get; set; }
        /// <summary>
        /// Lockstep Platform methods related to {cat}
        /// </summary>
        public AttachmentsClient Attachments { get; set; }
        /// <summary>
        /// Lockstep Platform methods related to {cat}
        /// </summary>
        public CodeDefinitionsClient CodeDefinitions { get; set; }
        /// <summary>
        /// Lockstep Platform methods related to {cat}
        /// </summary>
        public CompaniesClient Companies { get; set; }
        /// <summary>
        /// Lockstep Platform methods related to {cat}
        /// </summary>
        public ContactsClient Contacts { get; set; }
        /// <summary>
        /// Lockstep Platform methods related to {cat}
        /// </summary>
        public CreditMemoAppliedClient CreditMemoApplied { get; set; }
        /// <summary>
        /// Lockstep Platform methods related to {cat}
        /// </summary>
        public CurrenciesClient Currencies { get; set; }
        /// <summary>
        /// Lockstep Platform methods related to {cat}
        /// </summary>
        public CustomFieldDefinitionsClient CustomFieldDefinitions { get; set; }
        /// <summary>
        /// Lockstep Platform methods related to {cat}
        /// </summary>
        public CustomFieldValuesClient CustomFieldValues { get; set; }
        /// <summary>
        /// Lockstep Platform methods related to {cat}
        /// </summary>
        public DefinitionsClient Definitions { get; set; }
        /// <summary>
        /// Lockstep Platform methods related to {cat}
        /// </summary>
        public EmailsClient Emails { get; set; }
        /// <summary>
        /// Lockstep Platform methods related to {cat}
        /// </summary>
        public FinancialAccountClient FinancialAccount { get; set; }
        /// <summary>
        /// Lockstep Platform methods related to {cat}
        /// </summary>
        public FinancialAccountBalanceHistoryClient FinancialAccountBalanceHistory { get; set; }
        /// <summary>
        /// Lockstep Platform methods related to {cat}
        /// </summary>
        public FinancialYearSettingsClient FinancialYearSettings { get; set; }
        /// <summary>
        /// Lockstep Platform methods related to {cat}
        /// </summary>
        public InvoiceHistoryClient InvoiceHistory { get; set; }
        /// <summary>
        /// Lockstep Platform methods related to {cat}
        /// </summary>
        public InvoicesClient Invoices { get; set; }
        /// <summary>
        /// Lockstep Platform methods related to {cat}
        /// </summary>
        public LeadsClient Leads { get; set; }
        /// <summary>
        /// Lockstep Platform methods related to {cat}
        /// </summary>
        public NotesClient Notes { get; set; }
        /// <summary>
        /// Lockstep Platform methods related to {cat}
        /// </summary>
        public PaymentApplicationsClient PaymentApplications { get; set; }
        /// <summary>
        /// Lockstep Platform methods related to {cat}
        /// </summary>
        public PaymentsClient Payments { get; set; }
        /// <summary>
        /// Lockstep Platform methods related to {cat}
        /// </summary>
        public ProvisioningClient Provisioning { get; set; }
        /// <summary>
        /// Lockstep Platform methods related to {cat}
        /// </summary>
        public ReportsClient Reports { get; set; }
        /// <summary>
        /// Lockstep Platform methods related to {cat}
        /// </summary>
        public StatusClient Status { get; set; }
        /// <summary>
        /// Lockstep Platform methods related to {cat}
        /// </summary>
        public SyncClient Sync { get; set; }
        /// <summary>
        /// Lockstep Platform methods related to {cat}
        /// </summary>
        public UserAccountsClient UserAccounts { get; set; }
        /// <summary>
        /// Lockstep Platform methods related to {cat}
        /// </summary>
        public UserRolesClient UserRoles { get; set; }
        /// <summary>
        /// Lockstep Platform methods related to {cat}
        /// </summary>
        public WebhooksClient Webhooks { get; set; }
    
        /// <summary>
        /// Internal constructor for the client.  You should always begin with `withEnvironment()`.
        /// </summary>
        /// <param name="customUrl"></param>
        private LockstepApi(string customUrl)
        {
            // Add support for HTTP compression
            var handler = new HttpClientHandler();
            handler.AutomaticDecompression = DecompressionMethods.GZip;
            // We intentionally use a single HttpClient object for the lifetime of this API connection.
            // Best practices: https://bytedev.medium.com/net-core-httpclient-best-practices-4c1b20e32c6
            this._client = new HttpClient(handler);
            this._serverUrl = customUrl;
            this.Activities = new ActivitiesClient(this);
            this.ApiKeys = new ApiKeysClient(this);
            this.AppEnrollments = new AppEnrollmentsClient(this);
            this.Applications = new ApplicationsClient(this);
            this.Attachments = new AttachmentsClient(this);
            this.CodeDefinitions = new CodeDefinitionsClient(this);
            this.Companies = new CompaniesClient(this);
            this.Contacts = new ContactsClient(this);
            this.CreditMemoApplied = new CreditMemoAppliedClient(this);
            this.Currencies = new CurrenciesClient(this);
            this.CustomFieldDefinitions = new CustomFieldDefinitionsClient(this);
            this.CustomFieldValues = new CustomFieldValuesClient(this);
            this.Definitions = new DefinitionsClient(this);
            this.Emails = new EmailsClient(this);
            this.FinancialAccount = new FinancialAccountClient(this);
            this.FinancialAccountBalanceHistory = new FinancialAccountBalanceHistoryClient(this);
            this.FinancialYearSettings = new FinancialYearSettingsClient(this);
            this.InvoiceHistory = new InvoiceHistoryClient(this);
            this.Invoices = new InvoicesClient(this);
            this.Leads = new LeadsClient(this);
            this.Notes = new NotesClient(this);
            this.PaymentApplications = new PaymentApplicationsClient(this);
            this.Payments = new PaymentsClient(this);
            this.Provisioning = new ProvisioningClient(this);
            this.Reports = new ReportsClient(this);
            this.Status = new StatusClient(this);
            this.Sync = new SyncClient(this);
            this.UserAccounts = new UserAccountsClient(this);
            this.UserRoles = new UserRolesClient(this);
            this.Webhooks = new WebhooksClient(this);
        }
    
        /// <summary>
        /// Construct a new Lockstep API client to target the specific environment.
        /// </summary>
        /// <param name="env">The environment to use, either "prd" for production or "sbx" for sandbox.</param>
        /// <returns>The Lockstep API client to use</returns>
        public static LockstepApi WithEnvironment(LockstepEnv env)
        {
            switch (env)
            {
                case LockstepEnv.PRD:
                    return new LockstepApi("https://api.lockstep.io");
                case LockstepEnv.SBX:
                    return new LockstepApi("https://api.sbx.lockstep.io");
            }
    
            throw new NotImplementedException("Unknown environment");
        }
    
        /// <summary>
        /// Set the application name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public LockstepApi WithAppName(string name)
        {
            this._appName = name;
            return this;
        }
    
        /// <summary>
        /// Construct an unsafe client that uses a non-standard server; this can be necessary
        /// when using proxy servers or an API gateway.  Please be careful when using this
        /// mode.  You should prefer to use `WithEnvironment()` instead wherever possible.
        /// </summary>
        /// <param name="unsafeUrl">The non-Lockstep URL to use for this client</param>
        /// <returns>The Lockstep API client to use</returns>
        public static LockstepApi WithCustomEnvironment(string unsafeUrl)
        {
            return new LockstepApi(unsafeUrl);
        }
    
        /// <summary>
        /// Configure this Lockstep API client to use a JWT bearer token.
        /// More documentation is available on [JWT Bearer Tokens](https://developer.lockstep.io/docs/jwt-bearer-tokens).
        /// </summary>
        /// <param name="token">The JWT bearer token to use for this API session</param>
        /// <returns></returns>
        public LockstepApi WithBearerToken(string token)
        {
            this._bearerToken = token;
            this._apiKey = null;
            return this;
        }
    
        /// <summary>
        /// Configures this Lockstep API client to use an API Key.
        /// More documentation is available on [API Keys](https://developer.lockstep.io/docs/api-keys).
        /// </summary>
        /// <param name="apiKey">The API key to use for this API session</param>
        /// <returns></returns>
        public LockstepApi WithApiKey(string apiKey)
        {
            this._apiKey = apiKey;
            this._bearerToken = null;
            return this;
        }
    
        /// <summary>
        /// Make a request using this API client
        /// </summary>
        /// <param name="method">The HTTP method to send</param>
        /// <param name="path">The URL path fragment relative to this environment</param>
        /// <param name="query">The list of parameters and options to send</param>
        /// <param name="body">The request body to send</param>
        /// <param name="filename">The filename of a file attachment to upload</param>
        /// <typeparam name="T">The type of the expected response</typeparam>
        /// <returns>The response object including success/failure codes and error messages as appropriate</returns>
        public async Task<LockstepResponse<T>> Request<T>(HttpMethod method, string path,
            Dictionary<string, object> query, object body, string filename) where T: class
        {
            var sw = new Stopwatch();
            sw.Start();
            var request = new HttpRequestMessage();
            request.Method = method;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("SdkName", "DotNet");
            request.Headers.Add("SdkVersion", _version);
            request.Headers.Add("MachineName", Environment.MachineName);
            if (_appName != null)
            {
                request.Headers.Add("ApplicationName", _appName);
            }
    
            // Add authentication headers, if any
            if (!string.IsNullOrWhiteSpace(this._bearerToken))
            {
                request.Headers.Add("Authorization", "Bearer " + this._bearerToken);
            }
            else if (!string.IsNullOrWhiteSpace(this._apiKey))
            {
                request.Headers.Add("Api-Key", this._apiKey);
            }
    
            // Construct the request URI and query string
            var uriBuilder = new UriBuilder(this._serverUrl)
            {
                Path = path
            };
            var sb = new StringBuilder();
            if (query != null)
            {
                foreach (var kvp in query)
                {
                    if (kvp.Value != null)
                    {
                        sb.Append($"{kvp.Key}={HttpUtility.UrlEncode(kvp.Value.ToString())}&");
                    }
                }
            }
            uriBuilder.Query = sb.ToString();
            request.RequestUri = uriBuilder.Uri;
    
            // Add request body content, if any
            if (body != null)
            {
                var content = JsonSerializer.Serialize(body);
                request.Content = new StringContent(content);
            }
            else if (filename != null)
            {
                var bytesFile = File.ReadAllBytes(filename);
                var fileContent = new ByteArrayContent(bytesFile);
                var form = new MultipartFormDataContent(Guid.NewGuid().ToString());
                form.Add(fileContent, "file", Path.GetFileName(filename));
                request.Content = form;
            }
            
            // Send the request and convert the response into a success or failure
            using (var response = await _client.SendAsync(request))
            {
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };
                var result = new LockstepResponse<T>
                {
                    Success = response.IsSuccessStatusCode,
                    Status = response.StatusCode,
                };
                if (response.Headers.TryGetValues("ServerDuration", out var durations))
                {
                    var durationStr = durations.FirstOrDefault();
                    if (int.TryParse(durationStr, out var duration))
                    {
                        result.ServerDuration = duration;
                    }
                }
                if (result.Success)
                {
                    // Handle file downloads
                    if (typeof(T) == typeof(byte[]))
                    {
                        result.FileData = await response.Content.ReadAsByteArrayAsync();
                    }
                    else
                    {
                        // Successful API responses can be very large, so let's stream them
                        using (var stream = await response.Content.ReadAsStreamAsync())
                        {
                            result.Value = await JsonSerializer.DeserializeAsync<T>(stream, options);
                        }
                    }
                }
                else
                {
                    // Error responses tend to be very short, and issues such as proxy errors
                    // or "server down" can fail to provide valid JSON in the response.  If
                    // we fail to parse the response as JSON, just create a simulated error
                    // object with as much information as is available.
                    var errorContent = await response.Content.ReadAsStringAsync();
                    if (!string.IsNullOrEmpty(errorContent))
                    {
                        try
                        {
                            result.Error = JsonSerializer.Deserialize<ErrorResult>(errorContent, options);
                            if (result.Error != null) result.Error.Content = errorContent;
                        }
                        catch
                        {
                            // ignored
                        }
                    }

                    if (result.Error == null)
                    {
                        result.Error = new ErrorResult()
                        {
                            Title = $"{(int)response.StatusCode} {response.StatusCode}",
                            Content = errorContent
                        };
                    }
                }

                // Calculate length of time it took including JSON processing
                sw.Stop();
                result.TotalRoundtrip = sw.ElapsedMilliseconds;
                return result;
            }
        }
    }
}