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
 * @version    2021.39
 * @link       https://github.com/Lockstep-Network/lockstep-sdk-csharp
 */

namespace LockstepSDK;

using System.Text.Json;
using RestSharp;

public class LockstepApi
{
    // The URL of the environment we will use
    private readonly string _serverUrl;
    private readonly string _version = "2021.39";
    private string? _bearerToken;
    private string? _apiKey;

    public ActivitiesClient Activities { get; set; }
    public ApiKeysClient ApiKeys { get; set; }
    public AppEnrollmentsClient AppEnrollments { get; set; }
    public ApplicationsClient Applications { get; set; }
    public AttachmentsClient Attachments { get; set; }
    public CodeDefinitionsClient CodeDefinitions { get; set; }
    public CompaniesClient Companies { get; set; }
    public ContactsClient Contacts { get; set; }
    public CreditMemoAppliedClient CreditMemoApplied { get; set; }
    public CurrenciesClient Currencies { get; set; }
    public CustomFieldDefinitionsClient CustomFieldDefinitions { get; set; }
    public CustomFieldValuesClient CustomFieldValues { get; set; }
    public DefinitionsClient Definitions { get; set; }
    public EmailsClient Emails { get; set; }
    public InvoiceHistoryClient InvoiceHistory { get; set; }
    public InvoicesClient Invoices { get; set; }
    public LeadsClient Leads { get; set; }
    public MigrationClient Migration { get; set; }
    public NotesClient Notes { get; set; }
    public PaymentApplicationsClient PaymentApplications { get; set; }
    public PaymentsClient Payments { get; set; }
    public ProvisioningClient Provisioning { get; set; }
    public ReportsClient Reports { get; set; }
    public StatusClient Status { get; set; }
    public SyncClient Sync { get; set; }
    public UserAccountsClient UserAccounts { get; set; }
    public UserRolesClient UserRoles { get; set; }

    /// <summary>
    /// Internal constructor for the client.  You should always begin with `withEnvironment()`.
    /// </summary>
    /// <param name="customUrl"></param>
    private LockstepApi(string customUrl)
    {
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
        this.InvoiceHistory = new InvoiceHistoryClient(this);
        this.Invoices = new InvoicesClient(this);
        this.Leads = new LeadsClient(this);
        this.Migration = new MigrationClient(this);
        this.Notes = new NotesClient(this);
        this.PaymentApplications = new PaymentApplicationsClient(this);
        this.Payments = new PaymentsClient(this);
        this.Provisioning = new ProvisioningClient(this);
        this.Reports = new ReportsClient(this);
        this.Status = new StatusClient(this);
        this.Sync = new SyncClient(this);
        this.UserAccounts = new UserAccountsClient(this);
        this.UserRoles = new UserRolesClient(this);
    }

    /// <summary>
    /// Construct a new Lockstep API client to target the specific environment.
    /// </summary>
    /// <param name="env">The environment to use, either "prd" for production or "sbx" for sandbox.</param>
    /// <returns>The Lockstep API client to use</returns>
    public static LockstepApi withEnvironment(LockstepEnv env)
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
    /// Construct an unsafe client that uses a non-standard server; this can be necessary
    /// when using proxy servers or an API gateway.  Please be careful when using this
    /// mode.  You should prefer to use `withEnvironment()` instead wherever possible.
    /// </summary>
    /// <param name="unsafeUrl">The non-Lockstep URL to use for this client</param>
    /// <returns>The Lockstep API client to use</returns>
    public static LockstepApi withCustomEnvironment(string unsafeUrl)
    {
        return new LockstepApi(unsafeUrl);
    }

    /// <summary>
    /// Configure this Lockstep API client to use a JWT bearer token.
    /// More documentation is available on [JWT Bearer Tokens](https://developer.lockstep.io/docs/jwt-bearer-tokens).
    /// </summary>
    /// <param name="token">The JWT bearer token to use for this API session</param>
    /// <returns></returns>
    public LockstepApi withBearerToken(string token)
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
    public LockstepApi withApiKey(string apiKey)
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
    /// <param name="options">The list of parameters and options to send</param>
    /// <param name="body">The request body to send</param>
    /// <typeparam name="T">The type of the expected response</typeparam>
    /// <returns>The response object including success/failure codes and error messages as appropriate</returns>
    public async Task<LockstepResponse<T>> Request<T>(Method method, string path, Dictionary<string, object>? options, object? body)
    {
        var url = new Uri(new Uri(this._serverUrl), path).ToString();
        var client = new RestClient(url);
        var request = new RestRequest(method);
        request.AddHeader("Accept", "application/json");

        // Add authentication headers, if any
        if (!string.IsNullOrWhiteSpace(this._bearerToken))
        {
            request.AddHeader("Authorization", "Bearer " + this._bearerToken);
        }
        else if (!string.IsNullOrWhiteSpace(this._apiKey))
        {
            request.AddHeader("Api-Key", this._apiKey);
        }

        // Add query parameters, if any
        if (options != null)
        {
            foreach (var kvp in options)
            {
                request.AddQueryParameter(kvp.Key, kvp.Value.ToString());
            }
        }

        // Add request body content, if any
        if (body != null)
        {
            request.AddBody(JsonSerializer.Serialize(body));
        }

        // Send the request and convert the response into a success or failure
        var response = await client.ExecuteAsync(request);
        var status = (int)response.StatusCode;
        if (status is >= 200 and < 300)
        {
            var value = JsonSerializer.Deserialize<T>(response.Content);
            return new LockstepResponse<T>()
            {
                Success = true,
                Value = value,
                Error = null,
            };
        }
        else
        {
            var error = JsonSerializer.Deserialize<ErrorResult>(response.Content);
            return new LockstepResponse<T>()
            {
                Success = true,
                Value = default(T),
                Error = error,
            };
        }
    }
}