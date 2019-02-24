# Itofinity.Bitbucket.Rest.Api.SnippetApi

All URIs are relative to *https://api.localhost:8000/2.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SnippetsUsernameEncodedIdFilesPathGet**](SnippetApi.md#snippetsusernameencodedidfilespathget) | **Get** /snippets/{username}/{encoded_id}/files/{path} | 


<a name="snippetsusernameencodedidfilespathget"></a>
# **SnippetsUsernameEncodedIdFilesPathGet**
> void SnippetsUsernameEncodedIdFilesPathGet (string username, string path, string encoded_id)



Convenience resource for getting to a snippet's raw files without the need for first having to retrieve the snippet itself and having to pull out the versioned file links.

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Bitbucket.Rest.Api;
using Itofinity.Bitbucket.Rest.Client;
using Itofinity.Bitbucket.Rest.Model;

namespace Example
{
    public class SnippetsUsernameEncodedIdFilesPathGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");
            // Configure HTTP basic authorization: basic
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SnippetApi();
            var username = username_example;  // string | 
            var path = path_example;  // string | 
            var encoded_id = encoded_id_example;  // string | 

            try
            {
                apiInstance.SnippetsUsernameEncodedIdFilesPathGet(username, path, encoded_id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SnippetApi.SnippetsUsernameEncodedIdFilesPathGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**|  | 
 **path** | **string**|  | 
 **encoded_id** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key), [basic](../README.md#basic), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

