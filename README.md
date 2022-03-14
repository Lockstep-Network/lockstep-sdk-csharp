# Lockstep SDK for C#

![Nuget](https://img.shields.io/nuget/v/LockstepSdk)

## Repository Description

This software development kit allows you to connect with the Lockstep Platform SDK using C#. This README describes the steps (mentioned in the ["Fetch Invoices" tutorial](https://developer.lockstep.io/docs/fetch-invoices)) to write a C# program that uses this SDK to fetch invoices.

Many types of products examine invoices for a customer and provide feedback on them. A typical product might analyze incoming invoices and add metadata like a credit score for each invoice. This tutorial explains how to iterate through invoices, examine them, and add metadata.

We use the [Query Invoices API](https://developer.lockstep.io/reference/get_api-v1-invoices-query) to retrieve a collection of invoices. To fetch a large number of invoices, we must use [filtering and pagination](https://developer.lockstep.io/docs/querying-with-searchlight).

## How to Write a Program Using This SDK

### Step 1: Install Lockstep SDK for C#

Before you start, make sure you [generated a valid API key](https://developer.lockstep.io/docs/api-keys) and saved it as an environment variable in your system (referred to as `LOCKSTEPAPI_SBX` in this example). That way, you'll have access to the server.

Create a new project folder with an empty `Program.cs` file inside it and add the SDK to your project:
- One way to add the SDK to your project is by using the [package manager](https://docs.microsoft.com/en-us/nuget/consume-packages/install-use-packages-dotnet-cli):

    ```
    dotnet add package LockstepSdk
    ```

- Another way is to locate the source code in the `/src/` folder of this repository and ensure that your project folder has access to it (download and add it using your IDE).

There may be some additional dependencies you have to install.

### Step 2: Declare and initialize Lockstep API

Open your `Program.cs` file. Start by listing the dependencies and creating the main method. This main method should have variables for the `client` and `apiKey`. Note that the string passed in `Environment.GetEnvironmentVariable()` matches the environment variable name you created on your system. The `Ping()` method verifies your program can access the Lockstep Platfom API, regardless of authentication status or permissions. 

```c#
using System;
using LockstepSDK;

namespace LockstepExamples
{
    public class CSharpExample
    {
        public static async Task Main(string[] args)
        { 
            var client = LockstepApi.WithEnvironment(LockstepEnv.SBX)
                .WithApiKey(Environment.GetEnvironmentVariable("LOCKSTEPAPI_SBX"));

            // Test first API call
            var result = await client.Status.Ping();
            if (!result.Success || !result.Value.LoggedIn)
            {
                Console.WriteLine("Your API key is not valid.");
                Console.WriteLine("Please set the environment variable LOCKSTEPAPI_SBX and try again.");
                return;
            }

            // Print some information about our current user
            Console.WriteLine($"Ping result: {result.Value.UserName} ({result.Value.UserStatus})");
            Console.WriteLine($"Server status: {result.Value.Environment} {result.Value.Version}");
            Console.WriteLine();
            
            // You may now use the client object to make API calls
        }
    }
}
```

### Step 3: Create API query

In the `while` loop, we can begin querying invoices by storing the results in the `invoices` variable. Using the `QueryInvoices` API, we will fetch all invoices dated from December 1st, 2021 and later. We specify a page size of 100, which gives us a small number of invoices in each query.

```c#
var invoices = await client.Invoices.QueryInvoices(
    "invoiceDate > 2021-12-01",     // filter
    "Customer",                     // include
    "invoiceDate asc",              // order
    100,                            // pageSize
    0                               // pageNumber
);
```

The results from this API call will list the first 100 invoices, since you specified a page size of 100. Your results will include a field called `totalCount`, which tells you exactly how many records that matched your filter:

```
{
    "records": [
        {
            "groupKey": "1c043d8f-ce7e-4cf6-aa8e-a08b0220d327",
            "invoiceId": "23c57f74-b643-47bf-a82b-c90984b1fc1b",
            "companyId": "dab105d3-8fa3-4c4d-990a-c00cac91a064",
            "customerId": "453060e9-393e-4584-a5f6-31d8581c3969",
            "erpKey": "58784FB2-DD9F-4CAB-B672-575922DBFE3F",
            "purchaseOrderCode": "07E9A",
            "referenceCode": "DEMOI000000010",
            ...
        }
    ],
    "totalCount": 1919,
    "pageSize": 100
}
```

The results we get back also includes information about the company that wrote the invoice, since we added `"Customer"` to the `include` parameter of the query. Thus, we can fetch invoices and companies within the same query rather than making separate API calls.

### Step 4: Iterate through query results

Looking at the previous output, notice that `records` was returned. We can access each invoice by iterating through `invoices.Value.Records`. We can print details about each invoice by accessing its fields, such as `InvoiceId` and `OutstandingBalanceAmount`. And since we added `"Customer"` to the `include` parameter, we can access that to print the `CompanyName`:

```c#
foreach (var invoice in invoices.Value.Records)
{
    Console.WriteLine($"Invoice {count++}: {invoice.InvoiceId}");
    Console.WriteLine($"Company Name: {invoice.Customer.CompanyName}");
    Console.WriteLine($"Outstanding Balance: {invoice.OutstandingBalanceAmount}");
}
```

To format the outstanding balance to print like `$0.00`, replace with `Console.WriteLine($"Outstanding Balance: {string.Format("{0:C}", invoice.OutstandingBalanceAmount)}");`.

### Step 5: Examine Results

If everything is working when you build or debug your program, you will see the query results print to the console with the following format:

```
Invoice: 00000000-0000-0000-0000-000000000000
Company Name: CompanyNameHere
Outstanding Balance: $0.00
```
