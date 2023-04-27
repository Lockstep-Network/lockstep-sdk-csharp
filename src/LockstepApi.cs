/***
 * Lockstep Platform SDK for C#
 *
 * (c) 2021-2023 Lockstep, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * @author     Lockstep Network <support@lockstep.io>
 *             
 * @copyright  2021-2023 Lockstep, Inc.
 * @version    2023.17.21
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
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Web;
using LockstepSDK.Clients;
using LockstepSDK.Models;


namespace LockstepSDK 
{
    /// <summary>
    /// A client object that connects to the Lockstep Platform SDK
    /// </summary>
    public class LockstepApi
    {
        /// <summary>
        /// The version of the SDK
        /// </summary>
        public const string SdkVersion = "2023.17.21";
        
        private readonly string _apiUrl;
        private readonly HttpClient _client;
        private readonly JsonSerializerOptions _options;
        
        private string _appName;
        private string _bearerToken;
        private string _apiKey;
    
        /// <summary>
        /// API methods related to ApiKeys
        /// </summary>
        public ApiKeysClient ApiKeys { get; }

        /// <summary>
        /// API methods related to AppEnrollments
        /// </summary>
        public AppEnrollmentsClient AppEnrollments { get; }

        /// <summary>
        /// API methods related to Applications
        /// </summary>
        public ApplicationsClient Applications { get; }

        /// <summary>
        /// API methods related to AttachmentLinks
        /// </summary>
        public AttachmentLinksClient AttachmentLinks { get; }

        /// <summary>
        /// API methods related to Attachments
        /// </summary>
        public AttachmentsClient Attachments { get; }

        /// <summary>
        /// API methods related to CodeDefinitions
        /// </summary>
        public CodeDefinitionsClient CodeDefinitions { get; }

        /// <summary>
        /// API methods related to Companies
        /// </summary>
        public CompaniesClient Companies { get; }

        /// <summary>
        /// API methods related to Contacts
        /// </summary>
        public ContactsClient Contacts { get; }

        /// <summary>
        /// API methods related to CreditMemosApplied
        /// </summary>
        public CreditMemosAppliedClient CreditMemosApplied { get; }

        /// <summary>
        /// API methods related to Currencies
        /// </summary>
        public CurrenciesClient Currencies { get; }

        /// <summary>
        /// API methods related to CustomFieldDefinitions
        /// </summary>
        public CustomFieldDefinitionsClient CustomFieldDefinitions { get; }

        /// <summary>
        /// API methods related to CustomFieldValues
        /// </summary>
        public CustomFieldValuesClient CustomFieldValues { get; }

        /// <summary>
        /// API methods related to Definitions
        /// </summary>
        public DefinitionsClient Definitions { get; }

        /// <summary>
        /// API methods related to FeatureFlags
        /// </summary>
        public FeatureFlagsClient FeatureFlags { get; }

        /// <summary>
        /// API methods related to FinancialAccount
        /// </summary>
        public FinancialAccountClient FinancialAccount { get; }

        /// <summary>
        /// API methods related to FinancialAccountBalanceHistory
        /// </summary>
        public FinancialAccountBalanceHistoryClient FinancialAccountBalanceHistory { get; }

        /// <summary>
        /// API methods related to FinancialYearSettings
        /// </summary>
        public FinancialYearSettingsClient FinancialYearSettings { get; }

        /// <summary>
        /// API methods related to GroupAccounts
        /// </summary>
        public GroupAccountsClient GroupAccounts { get; }

        /// <summary>
        /// API methods related to InvoiceAddresses
        /// </summary>
        public InvoiceAddressesClient InvoiceAddresses { get; }

        /// <summary>
        /// API methods related to InvoiceLines
        /// </summary>
        public InvoiceLinesClient InvoiceLines { get; }

        /// <summary>
        /// API methods related to Invoices
        /// </summary>
        public InvoicesClient Invoices { get; }

        /// <summary>
        /// API methods related to Leads
        /// </summary>
        public LeadsClient Leads { get; }

        /// <summary>
        /// API methods related to MagicLinks
        /// </summary>
        public MagicLinksClient MagicLinks { get; }

        /// <summary>
        /// API methods related to Notes
        /// </summary>
        public NotesClient Notes { get; }

        /// <summary>
        /// API methods related to Payments
        /// </summary>
        public PaymentsClient Payments { get; }

        /// <summary>
        /// API methods related to PaymentsApplied
        /// </summary>
        public PaymentsAppliedClient PaymentsApplied { get; }

        /// <summary>
        /// API methods related to ProfilesAccounting
        /// </summary>
        public ProfilesAccountingClient ProfilesAccounting { get; }

        /// <summary>
        /// API methods related to ProfilesAccountingContacts
        /// </summary>
        public ProfilesAccountingContactsClient ProfilesAccountingContacts { get; }

        /// <summary>
        /// API methods related to ProfilesCompanies
        /// </summary>
        public ProfilesCompaniesClient ProfilesCompanies { get; }

        /// <summary>
        /// API methods related to Provisioning
        /// </summary>
        public ProvisioningClient Provisioning { get; }

        /// <summary>
        /// API methods related to Reports
        /// </summary>
        public ReportsClient Reports { get; }

        /// <summary>
        /// API methods related to Status
        /// </summary>
        public StatusClient Status { get; }

        /// <summary>
        /// API methods related to Sync
        /// </summary>
        public SyncClient Sync { get; }

        /// <summary>
        /// API methods related to Transactions
        /// </summary>
        public TransactionsClient Transactions { get; }

        /// <summary>
        /// API methods related to Transcriptions
        /// </summary>
        public TranscriptionsClient Transcriptions { get; }

        /// <summary>
        /// API methods related to UserAccounts
        /// </summary>
        public UserAccountsClient UserAccounts { get; }

        /// <summary>
        /// API methods related to UserRoles
        /// </summary>
        public UserRolesClient UserRoles { get; }

        /// <summary>
        /// API methods related to WebhookRules
        /// </summary>
        public WebhookRulesClient WebhookRules { get; }

        /// <summary>
        /// API methods related to Webhooks
        /// </summary>
        public WebhooksClient Webhooks { get; }


        /// <summary>
        /// Internal constructor for the client. You should always begin with `WithEnvironment()` or `WithCustomEnvironment`.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="clientHandler">Handler for the HTTP client, when null the default handler will be used</param>
        private LockstepApi(string url, HttpClientHandler clientHandler)
        {
            // Add support for HTTP compression
            var handler = clientHandler ?? new HttpClientHandler();
            handler.AutomaticDecompression = DecompressionMethods.GZip;
            
            // We intentionally use a single HttpClient object for the lifetime of this API connection.
            // Best practices: https://bytedev.medium.com/net-core-httpclient-best-practices-4c1b20e32c6
            _client = new HttpClient(handler);
            
            _apiUrl = url;
            ApiKeys = new ApiKeysClient(this);
            AppEnrollments = new AppEnrollmentsClient(this);
            Applications = new ApplicationsClient(this);
            AttachmentLinks = new AttachmentLinksClient(this);
            Attachments = new AttachmentsClient(this);
            CodeDefinitions = new CodeDefinitionsClient(this);
            Companies = new CompaniesClient(this);
            Contacts = new ContactsClient(this);
            CreditMemosApplied = new CreditMemosAppliedClient(this);
            Currencies = new CurrenciesClient(this);
            CustomFieldDefinitions = new CustomFieldDefinitionsClient(this);
            CustomFieldValues = new CustomFieldValuesClient(this);
            Definitions = new DefinitionsClient(this);
            FeatureFlags = new FeatureFlagsClient(this);
            FinancialAccount = new FinancialAccountClient(this);
            FinancialAccountBalanceHistory = new FinancialAccountBalanceHistoryClient(this);
            FinancialYearSettings = new FinancialYearSettingsClient(this);
            GroupAccounts = new GroupAccountsClient(this);
            InvoiceAddresses = new InvoiceAddressesClient(this);
            InvoiceLines = new InvoiceLinesClient(this);
            Invoices = new InvoicesClient(this);
            Leads = new LeadsClient(this);
            MagicLinks = new MagicLinksClient(this);
            Notes = new NotesClient(this);
            Payments = new PaymentsClient(this);
            PaymentsApplied = new PaymentsAppliedClient(this);
            ProfilesAccounting = new ProfilesAccountingClient(this);
            ProfilesAccountingContacts = new ProfilesAccountingContactsClient(this);
            ProfilesCompanies = new ProfilesCompaniesClient(this);
            Provisioning = new ProvisioningClient(this);
            Reports = new ReportsClient(this);
            Status = new StatusClient(this);
            Sync = new SyncClient(this);
            Transactions = new TransactionsClient(this);
            Transcriptions = new TranscriptionsClient(this);
            UserAccounts = new UserAccountsClient(this);
            UserRoles = new UserRolesClient(this);
            WebhookRules = new WebhookRulesClient(this);
            Webhooks = new WebhooksClient(this);
                
            // Configure JSON serializer options
            _options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull, 
            };
        }
    
        /// <summary>
        /// Construct a new API client to target the specific environment.
        /// </summary>
        /// <param name="env">The environment to use, either "prd" for production or "sbx" for sandbox.</param>
        /// <param name="clientHandler">Optional handler for the HTTP client</param>
        /// <returns>The API client to use</returns>
        public static LockstepApi WithEnvironment(string env, HttpClientHandler clientHandler = null)
        {
            switch (env)
            {
                case "sbx":
                    return new LockstepApi("https://api.sbx.lockstep.io/", clientHandler);
                case "prd":
                    return new LockstepApi("https://api.lockstep.io/", clientHandler);
            }
    
            throw new InvalidOperationException($"Unknown environment: {env}");
        }
    
        /// <summary>
        /// Construct a client that uses a non-standard environment; this can be necessary when using proxy servers or
        /// an API gateway.  Please be careful when using this mode.
        /// You should prefer to use `WithEnvironment()` instead wherever possible.
        /// </summary>
        /// <param name="url">The custom URL to use for this client</param>
        /// <param name="clientHandler">Optional handler to set specific settings for the HTTP client</param>
        /// <returns>The API client to use</returns>
        public static LockstepApi WithCustomEnvironment(string url, HttpClientHandler clientHandler = null)
        {
            return new LockstepApi(url, clientHandler);
        }
        
        /// <summary>
        /// Set the application name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public LockstepApi WithAppName(string name)
        {
            _appName = name;
            return this;
        }
    
        /// <summary>
        /// Configure this API client to use a JWT bearer token.
        ///
        /// Authentication is either via [Lockstep Platform API key](https://developer.lockstep.io/docs/api-keys) or [JWT Bearer Token](https://developer.lockstep.io/docs/jwt-bearer-tokens)
        /// </summary>
        /// <param name="token">The JWT bearer token to use for this API session</param>
        /// <returns></returns>
        public LockstepApi WithBearerToken(string token)
        {
            _bearerToken = token;
            _apiKey = null;
            return this;
        }
    
        /// <summary>
        /// Configures this API client to use an API Key.
        ///
        /// Authentication is either via [Lockstep Platform API key](https://developer.lockstep.io/docs/api-keys) or [JWT Bearer Token](https://developer.lockstep.io/docs/jwt-bearer-tokens)
        /// </summary>
        /// <param name="apiKey">The API key to use for this API session</param>
        /// <returns></returns>
        public LockstepApi WithApiKey(string apiKey)
        {
            _apiKey = apiKey;
            _bearerToken = null;
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
            Dictionary<string, object> query, object body, string filename) where T : class
        {
            var sw = Stopwatch.StartNew();
            var request = new HttpRequestMessage();
            request.Method = method;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("SdkName", "DotNet");
            request.Headers.Add("SdkVersion", SdkVersion);
            request.Headers.Add("MachineName", Environment.MachineName);
            if (_appName != null)
            {
                request.Headers.Add("ApplicationName", _appName);
            }
    
            // Add authentication headers, if any
            if (!string.IsNullOrWhiteSpace(_bearerToken))
            {
                request.Headers.Add("Authorization", "Bearer " + _bearerToken);
            }
            else if (!string.IsNullOrWhiteSpace(_apiKey))
            {
                request.Headers.Add("Api-Key", _apiKey);
            }
    
            // Construct the request URI and query string
            var uriBuilder = new UriBuilder(_apiUrl)
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
                var content = JsonSerializer.Serialize(body, _options);
                request.Content = new StringContent(content, Encoding.UTF8, "application/json");
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
                var result = new LockstepResponse<T>
                {
                    Success = response.IsSuccessStatusCode,
                    Status = response.StatusCode,
                };
                if (response.Headers.TryGetValues("Server-Duration", out var durations))
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
                            result.Value = await JsonSerializer.DeserializeAsync<T>(stream, _options);
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
                            result.Error = JsonSerializer.Deserialize<ErrorResult>(errorContent, _options);
                            if (result.Error != null)
                            {
                                result.Error.Content = errorContent;
                            }
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
                            Status = (int)response.StatusCode,
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