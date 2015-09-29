About
=====

This is the .NET Client for accessing the IBM Connections API.

Installation
-------

The client library requires .NET Framework 4.5 or higher and [RestSharp](https://www.nuget.org/packages/RestSharp) as its dependency.

This package is available on NuGet Gallery. To install the [Package](http://www.nuget.org/packages/IBMConnectionsClient) run the following command in the [Package Manager Console](http://docs.nuget.org/docs/start-here/using-the-package-manager-console)

    PM> Install-Package IBMConnectionsClient

This will install the client library and the required dependency.

Constructing API client instance
-------------

Before you can make any API calls you must initialize the ConnectionsAPIClient class with the url and the credentials.

    using IBM.Connections.Net.Api;
    var connectionsApiService = new ConnectionsApiService("https://<url>", "<username>", "<password");

We will use this initialized connectionsApiService object for all further operations.


Basic Usage
-----------

After constructing ConnectionsApiService object  you can use all of the wrapper functions to make API requests. The functions are organized into services, each service corresponds to an Area in official [API documentation](http://www-10.lotus.com/ldd/lcwiki.nsf/xpAPIViewer.xsp?lookupName=IBM+Connections+5.0+API+Documentation#action=openDocument&content=catcontent&ct=api). You can access the services right from ConnectionsApiService class. For example:

```csharp

// Getting the list of documents
 IBM.Connections.Net.Api.Models.Request.Files request = new IBM.Connections.Net.Api.Models.Request.Files();
 request.page = 1; //the current page we want to see
 request.pageSize = 10; //the total of items needed for pagination
 
 //perform the call to retrieve the list of files
 var response = connectionsApiService.FilesService.GetMyFiles(request);

```

All the wrapped methods either return a strongly typed model.

Error Handling
--------------

All unsuccessful responses returned by the API (everything that has a 4xx or 5xx HTTP status code) will throw exceptions. All exceptions are of type `IBM.Connections.Net.Api.Exception` and it has an `Error` property that represents the strongly typed version of response from the API:

```csharp
try
{
	IBM.Connections.Net.Api.Models.Request.Files request = new IBM.Connections.Net.Api.Models.Request.Files();
    connectionsApiService.FilesService.GetMyFiles(request)
	
}
catch (IBM.Connections.Net.Api.Exception.ConnectionsException exception)
{
    Response.Write(exception.Error.Status); // Status code of the response
    Response.Write(exception.Error.Description); // Error description
    Response.Write(exception.Error.Details); // Error details
    Response.Write(exception.Error.FailedRequest.Url); // Url requested
	Response.Write(exception.Error.FailedRequest.Method); // Method requested
	foreach (var item in exception.Error.FailedRequest.Parameters)
	{
		Response.Write(item.Key+":"+item.Value); //Parameter passed
	}	
}
```


For more documentation and examples see [Documentation](https://github.com/carlosmartinsrodrigues/IBMConnections-API-Wrapper)

Contribution guideline
-----------------

Your contribution to IBM Connections .NET client would be very welcome. If you find a bug, please raise it as an issue. Even better fix it and send us a pull request. If you want to contribute, fork the repo, fix an issue and send a pull request.

Pull requests are code reviewed. Here is what we look for in your pull request:

- Clean implementation
- Comment the code if you are writing anything complex.
- Xml documentation for new methods or updating the existing documentation when you make a change.
- Adherence to the existing coding styles.
- Also please link to the issue(s) you're fixing from your PR description.