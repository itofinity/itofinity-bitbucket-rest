# Itofinity.Bitbucket.Refit.Api.AddonApi

All URIs are relative to *https://api.localhost:8000/2.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddonDelete**](AddonApi.md#addondelete) | **Delete** /addon | 
[**AddonLinkersGet**](AddonApi.md#addonlinkersget) | **Get** /addon/linkers | 
[**AddonLinkersLinkerKeyGet**](AddonApi.md#addonlinkerslinkerkeyget) | **Get** /addon/linkers/{linker_key} | 
[**AddonLinkersLinkerKeyValuesDelete**](AddonApi.md#addonlinkerslinkerkeyvaluesdelete) | **Delete** /addon/linkers/{linker_key}/values | 
[**AddonLinkersLinkerKeyValuesDelete_0**](AddonApi.md#addonlinkerslinkerkeyvaluesdelete_0) | **Delete** /addon/linkers/{linker_key}/values/ | 
[**AddonLinkersLinkerKeyValuesGet**](AddonApi.md#addonlinkerslinkerkeyvaluesget) | **Get** /addon/linkers/{linker_key}/values | 
[**AddonLinkersLinkerKeyValuesGet_0**](AddonApi.md#addonlinkerslinkerkeyvaluesget_0) | **Get** /addon/linkers/{linker_key}/values/ | 
[**AddonLinkersLinkerKeyValuesPost**](AddonApi.md#addonlinkerslinkerkeyvaluespost) | **Post** /addon/linkers/{linker_key}/values | 
[**AddonLinkersLinkerKeyValuesPut**](AddonApi.md#addonlinkerslinkerkeyvaluesput) | **Put** /addon/linkers/{linker_key}/values | 
[**AddonPut**](AddonApi.md#addonput) | **Put** /addon | 
[**AddonUsersTargetUserEventsEventKeyPost**](AddonApi.md#addonuserstargetusereventseventkeypost) | **Post** /addon/users/{target_user}/events/{event_key} | 


<a name="addondelete"></a>
# **AddonDelete**
> Error AddonDelete ()





### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Bitbucket.Refit.Api;
using Itofinity.Bitbucket.Refit.Client;
using Itofinity.Bitbucket.Refit.Model;

namespace Example
{
    public class AddonDeleteExample
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

            var apiInstance = new AddonApi();

            try
            {
                Error result = apiInstance.AddonDelete();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddonApi.AddonDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**Error**](Error.md)

### Authorization

[api_key](../README.md#api_key), [basic](../README.md#basic), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addonlinkersget"></a>
# **AddonLinkersGet**
> Error AddonLinkersGet ()





### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Bitbucket.Refit.Api;
using Itofinity.Bitbucket.Refit.Client;
using Itofinity.Bitbucket.Refit.Model;

namespace Example
{
    public class AddonLinkersGetExample
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

            var apiInstance = new AddonApi();

            try
            {
                Error result = apiInstance.AddonLinkersGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddonApi.AddonLinkersGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**Error**](Error.md)

### Authorization

[api_key](../README.md#api_key), [basic](../README.md#basic), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addonlinkerslinkerkeyget"></a>
# **AddonLinkersLinkerKeyGet**
> Error AddonLinkersLinkerKeyGet (string linker_key)





### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Bitbucket.Refit.Api;
using Itofinity.Bitbucket.Refit.Client;
using Itofinity.Bitbucket.Refit.Model;

namespace Example
{
    public class AddonLinkersLinkerKeyGetExample
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

            var apiInstance = new AddonApi();
            var linker_key = linker_key_example;  // string | 

            try
            {
                Error result = apiInstance.AddonLinkersLinkerKeyGet(linker_key);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddonApi.AddonLinkersLinkerKeyGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **linker_key** | **string**|  | 

### Return type

[**Error**](Error.md)

### Authorization

[api_key](../README.md#api_key), [basic](../README.md#basic), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addonlinkerslinkerkeyvaluesdelete"></a>
# **AddonLinkersLinkerKeyValuesDelete**
> Error AddonLinkersLinkerKeyValuesDelete (string linker_key)





### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Bitbucket.Refit.Api;
using Itofinity.Bitbucket.Refit.Client;
using Itofinity.Bitbucket.Refit.Model;

namespace Example
{
    public class AddonLinkersLinkerKeyValuesDeleteExample
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

            var apiInstance = new AddonApi();
            var linker_key = linker_key_example;  // string | 

            try
            {
                Error result = apiInstance.AddonLinkersLinkerKeyValuesDelete(linker_key);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddonApi.AddonLinkersLinkerKeyValuesDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **linker_key** | **string**|  | 

### Return type

[**Error**](Error.md)

### Authorization

[api_key](../README.md#api_key), [basic](../README.md#basic), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addonlinkerslinkerkeyvaluesdelete_0"></a>
# **AddonLinkersLinkerKeyValuesDelete_0**
> Error AddonLinkersLinkerKeyValuesDelete_0 (string linker_key)





### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Bitbucket.Refit.Api;
using Itofinity.Bitbucket.Refit.Client;
using Itofinity.Bitbucket.Refit.Model;

namespace Example
{
    public class AddonLinkersLinkerKeyValuesDelete_0Example
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

            var apiInstance = new AddonApi();
            var linker_key = linker_key_example;  // string | 

            try
            {
                Error result = apiInstance.AddonLinkersLinkerKeyValuesDelete_0(linker_key);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddonApi.AddonLinkersLinkerKeyValuesDelete_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **linker_key** | **string**|  | 

### Return type

[**Error**](Error.md)

### Authorization

[api_key](../README.md#api_key), [basic](../README.md#basic), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addonlinkerslinkerkeyvaluesget"></a>
# **AddonLinkersLinkerKeyValuesGet**
> Error AddonLinkersLinkerKeyValuesGet (string linker_key)





### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Bitbucket.Refit.Api;
using Itofinity.Bitbucket.Refit.Client;
using Itofinity.Bitbucket.Refit.Model;

namespace Example
{
    public class AddonLinkersLinkerKeyValuesGetExample
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

            var apiInstance = new AddonApi();
            var linker_key = linker_key_example;  // string | 

            try
            {
                Error result = apiInstance.AddonLinkersLinkerKeyValuesGet(linker_key);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddonApi.AddonLinkersLinkerKeyValuesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **linker_key** | **string**|  | 

### Return type

[**Error**](Error.md)

### Authorization

[api_key](../README.md#api_key), [basic](../README.md#basic), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addonlinkerslinkerkeyvaluesget_0"></a>
# **AddonLinkersLinkerKeyValuesGet_0**
> Error AddonLinkersLinkerKeyValuesGet_0 (string linker_key)





### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Bitbucket.Refit.Api;
using Itofinity.Bitbucket.Refit.Client;
using Itofinity.Bitbucket.Refit.Model;

namespace Example
{
    public class AddonLinkersLinkerKeyValuesGet_0Example
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

            var apiInstance = new AddonApi();
            var linker_key = linker_key_example;  // string | 

            try
            {
                Error result = apiInstance.AddonLinkersLinkerKeyValuesGet_0(linker_key);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddonApi.AddonLinkersLinkerKeyValuesGet_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **linker_key** | **string**|  | 

### Return type

[**Error**](Error.md)

### Authorization

[api_key](../README.md#api_key), [basic](../README.md#basic), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addonlinkerslinkerkeyvaluespost"></a>
# **AddonLinkersLinkerKeyValuesPost**
> Error AddonLinkersLinkerKeyValuesPost (string linker_key)





### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Bitbucket.Refit.Api;
using Itofinity.Bitbucket.Refit.Client;
using Itofinity.Bitbucket.Refit.Model;

namespace Example
{
    public class AddonLinkersLinkerKeyValuesPostExample
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

            var apiInstance = new AddonApi();
            var linker_key = linker_key_example;  // string | 

            try
            {
                Error result = apiInstance.AddonLinkersLinkerKeyValuesPost(linker_key);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddonApi.AddonLinkersLinkerKeyValuesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **linker_key** | **string**|  | 

### Return type

[**Error**](Error.md)

### Authorization

[api_key](../README.md#api_key), [basic](../README.md#basic), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addonlinkerslinkerkeyvaluesput"></a>
# **AddonLinkersLinkerKeyValuesPut**
> Error AddonLinkersLinkerKeyValuesPut (string linker_key)





### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Bitbucket.Refit.Api;
using Itofinity.Bitbucket.Refit.Client;
using Itofinity.Bitbucket.Refit.Model;

namespace Example
{
    public class AddonLinkersLinkerKeyValuesPutExample
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

            var apiInstance = new AddonApi();
            var linker_key = linker_key_example;  // string | 

            try
            {
                Error result = apiInstance.AddonLinkersLinkerKeyValuesPut(linker_key);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddonApi.AddonLinkersLinkerKeyValuesPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **linker_key** | **string**|  | 

### Return type

[**Error**](Error.md)

### Authorization

[api_key](../README.md#api_key), [basic](../README.md#basic), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addonput"></a>
# **AddonPut**
> Error AddonPut ()





### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Bitbucket.Refit.Api;
using Itofinity.Bitbucket.Refit.Client;
using Itofinity.Bitbucket.Refit.Model;

namespace Example
{
    public class AddonPutExample
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

            var apiInstance = new AddonApi();

            try
            {
                Error result = apiInstance.AddonPut();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddonApi.AddonPut: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**Error**](Error.md)

### Authorization

[api_key](../README.md#api_key), [basic](../README.md#basic), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addonuserstargetusereventseventkeypost"></a>
# **AddonUsersTargetUserEventsEventKeyPost**
> void AddonUsersTargetUserEventsEventKeyPost (string target_user, string event_key)



POST a new custom event.  The data within the event body will be hydrated by Bitbucket. For example, the following event submission would result in subscribers for the event receiving the full repository object corresponding to the UUID.  ``` $ curl -X POST -H \"Content-Type: application/json\" -d '{     \"mynumdata\": \"12345\",     \"repository\": {         \"type\": \"repository\",         \"uuid\": \"{be95aa1f-c0b2-47f6-99d1-bf5d3a0f850f}\" }}' https://api.bitbucket.org/2.0/addon/users/myuser/events/com.example.app%3Amyevent ```  Use the optional `fields` property of the custom event Connect module where the event is defined to add additional fields to the expanded payload sent to listeners.  For example, the `customEvents` module in the app descriptor for the previous example would look like this:  ``` 'modules': {     'customEvents': {         'com.example.app:myevent': {             'schema': {                 'properties': {                     'mynumdata': {'type': 'number'},                     'repository': {'$ref': '#/definitions/repository'}                 }             },             'fields': ['repository.owner']         }     } } ```  By specifying fields as above, the repository owner will also be sent to subscribers of the event.

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Bitbucket.Refit.Api;
using Itofinity.Bitbucket.Refit.Client;
using Itofinity.Bitbucket.Refit.Model;

namespace Example
{
    public class AddonUsersTargetUserEventsEventKeyPostExample
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

            var apiInstance = new AddonApi();
            var target_user = target_user_example;  // string | The account the app is installed in.  This can either be the username or the UUID of the account, surrounded by curly-braces, for example: `{account UUID}`. An account is either a team or user. 
            var event_key = event_key_example;  // string | The key of the event, which corresponds to an event defined in the connect app descriptor. 

            try
            {
                apiInstance.AddonUsersTargetUserEventsEventKeyPost(target_user, event_key);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddonApi.AddonUsersTargetUserEventsEventKeyPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **target_user** | **string**| The account the app is installed in.  This can either be the username or the UUID of the account, surrounded by curly-braces, for example: &#x60;{account UUID}&#x60;. An account is either a team or user.  | 
 **event_key** | **string**| The key of the event, which corresponds to an event defined in the connect app descriptor.  | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key), [basic](../README.md#basic), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

