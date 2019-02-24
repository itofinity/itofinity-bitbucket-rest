# Itofinity.Bitbucket.Rest.Api.WebhooksApi

All URIs are relative to *https://api.localhost:8000/2.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**HookEventsGet**](WebhooksApi.md#hookeventsget) | **Get** /hook_events | 
[**HookEventsSubjectTypeGet**](WebhooksApi.md#hookeventssubjecttypeget) | **Get** /hook_events/{subject_type} | 
[**RepositoriesUsernameRepoSlugHooksGet**](WebhooksApi.md#repositoriesusernamereposlughooksget) | **Get** /repositories/{username}/{repo_slug}/hooks | 
[**RepositoriesUsernameRepoSlugHooksPost**](WebhooksApi.md#repositoriesusernamereposlughookspost) | **Post** /repositories/{username}/{repo_slug}/hooks | 
[**RepositoriesUsernameRepoSlugHooksUidDelete**](WebhooksApi.md#repositoriesusernamereposlughooksuiddelete) | **Delete** /repositories/{username}/{repo_slug}/hooks/{uid} | 
[**RepositoriesUsernameRepoSlugHooksUidGet**](WebhooksApi.md#repositoriesusernamereposlughooksuidget) | **Get** /repositories/{username}/{repo_slug}/hooks/{uid} | 
[**RepositoriesUsernameRepoSlugHooksUidPut**](WebhooksApi.md#repositoriesusernamereposlughooksuidput) | **Put** /repositories/{username}/{repo_slug}/hooks/{uid} | 
[**TeamsUsernameHooksGet**](WebhooksApi.md#teamsusernamehooksget) | **Get** /teams/{username}/hooks | 
[**TeamsUsernameHooksPost**](WebhooksApi.md#teamsusernamehookspost) | **Post** /teams/{username}/hooks | 
[**TeamsUsernameHooksUidDelete**](WebhooksApi.md#teamsusernamehooksuiddelete) | **Delete** /teams/{username}/hooks/{uid} | 
[**TeamsUsernameHooksUidGet**](WebhooksApi.md#teamsusernamehooksuidget) | **Get** /teams/{username}/hooks/{uid} | 
[**TeamsUsernameHooksUidPut**](WebhooksApi.md#teamsusernamehooksuidput) | **Put** /teams/{username}/hooks/{uid} | 
[**UsersUsernameHooksGet**](WebhooksApi.md#usersusernamehooksget) | **Get** /users/{username}/hooks | 
[**UsersUsernameHooksPost**](WebhooksApi.md#usersusernamehookspost) | **Post** /users/{username}/hooks | 
[**UsersUsernameHooksUidDelete**](WebhooksApi.md#usersusernamehooksuiddelete) | **Delete** /users/{username}/hooks/{uid} | 
[**UsersUsernameHooksUidGet**](WebhooksApi.md#usersusernamehooksuidget) | **Get** /users/{username}/hooks/{uid} | 
[**UsersUsernameHooksUidPut**](WebhooksApi.md#usersusernamehooksuidput) | **Put** /users/{username}/hooks/{uid} | 


<a name="hookeventsget"></a>
# **HookEventsGet**
> SubjectTypes HookEventsGet ()



Returns the webhook resource or subject types on which webhooks can be registered.  Each resource/subject type contains an `events` link that returns the paginated list of specific events each individual subject type can emit.  This endpoint is publicly accessible and does not require authentication or scopes.  Example:  ``` $ curl https://api.bitbucket.org/2.0/hook_events  {     \"repository\": {         \"links\": {             \"events\": {                 \"href\": \"https://api.bitbucket.org/2.0/hook_events/repository\"             }         }     },     \"team\": {         \"links\": {             \"events\": {                 \"href\": \"https://api.bitbucket.org/2.0/hook_events/team\"             }         }     },     \"user\": {         \"links\": {             \"events\": {                 \"href\": \"https://api.bitbucket.org/2.0/hook_events/user\"             }         }     } } ```

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Bitbucket.Rest.Api;
using Itofinity.Bitbucket.Rest.Client;
using Itofinity.Bitbucket.Rest.Model;

namespace Example
{
    public class HookEventsGetExample
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

            var apiInstance = new WebhooksApi();

            try
            {
                SubjectTypes result = apiInstance.HookEventsGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhooksApi.HookEventsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**SubjectTypes**](SubjectTypes.md)

### Authorization

[api_key](../README.md#api_key), [basic](../README.md#basic), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="hookeventssubjecttypeget"></a>
# **HookEventsSubjectTypeGet**
> PaginatedHookEvents HookEventsSubjectTypeGet (string subject_type)



Returns a paginated list of all valid webhook events for the specified entity.  This is public data that does not require any scopes or authentication.  Example:  NOTE: The following example is a truncated response object for the `team` `subject_type`. We return the same structure for the other `subject_type` objects.  ``` $ curl https://api.bitbucket.org/2.0/hook_events/team {     \"page\": 1,     \"pagelen\": 30,     \"size\": 21,     \"values\": [         {             \"category\": \"Repository\",             \"description\": \"Whenever a repository push occurs\",             \"event\": \"repo:push\",             \"label\": \"Push\"         },         {             \"category\": \"Repository\",             \"description\": \"Whenever a repository fork occurs\",             \"event\": \"repo:fork\",             \"label\": \"Fork\"         },         ...         {             \"category\": \"Repository\",             \"description\": \"Whenever a repository import occurs\",             \"event\": \"repo:imported\",             \"label\": \"Import\"         }     ] } ```

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Bitbucket.Rest.Api;
using Itofinity.Bitbucket.Rest.Client;
using Itofinity.Bitbucket.Rest.Model;

namespace Example
{
    public class HookEventsSubjectTypeGetExample
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

            var apiInstance = new WebhooksApi();
            var subject_type = subject_type_example;  // string | A resource or subject type.

            try
            {
                PaginatedHookEvents result = apiInstance.HookEventsSubjectTypeGet(subject_type);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhooksApi.HookEventsSubjectTypeGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **subject_type** | **string**| A resource or subject type. | 

### Return type

[**PaginatedHookEvents**](PaginatedHookEvents.md)

### Authorization

[api_key](../README.md#api_key), [basic](../README.md#basic), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="repositoriesusernamereposlughooksget"></a>
# **RepositoriesUsernameRepoSlugHooksGet**
> PaginatedWebhookSubscriptions RepositoriesUsernameRepoSlugHooksGet (string username, string repo_slug)



Returns a paginated list of webhooks installed on this repository.

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Bitbucket.Rest.Api;
using Itofinity.Bitbucket.Rest.Client;
using Itofinity.Bitbucket.Rest.Model;

namespace Example
{
    public class RepositoriesUsernameRepoSlugHooksGetExample
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

            var apiInstance = new WebhooksApi();
            var username = username_example;  // string | 
            var repo_slug = repo_slug_example;  // string | 

            try
            {
                PaginatedWebhookSubscriptions result = apiInstance.RepositoriesUsernameRepoSlugHooksGet(username, repo_slug);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhooksApi.RepositoriesUsernameRepoSlugHooksGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**|  | 
 **repo_slug** | **string**|  | 

### Return type

[**PaginatedWebhookSubscriptions**](PaginatedWebhookSubscriptions.md)

### Authorization

[api_key](../README.md#api_key), [basic](../README.md#basic), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="repositoriesusernamereposlughookspost"></a>
# **RepositoriesUsernameRepoSlugHooksPost**
> WebhookSubscription RepositoriesUsernameRepoSlugHooksPost (string username, string repo_slug)



Creates a new webhook on the specified repository.  Example:  ``` $ curl -X POST -u credentials -H 'Content-Type: application/json'           https://api.bitbucket.org/2.0/repositories/username/slug/hooks           -d '     {       \"description\": \"Webhook Description\",       \"url\": \"https://example.com/\",       \"active\": true,       \"events\": [         \"repo:push\",         \"issue:created\",         \"issue:updated\"       ]     }' ```  Note that this call requires the webhook scope, as well as any scope that applies to the events that the webhook subscribes to. In the example above that means: `webhook`, `repository` and `issue`.  Also note that the `url` must properly resolve and cannot be an internal, non-routed address.

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Bitbucket.Rest.Api;
using Itofinity.Bitbucket.Rest.Client;
using Itofinity.Bitbucket.Rest.Model;

namespace Example
{
    public class RepositoriesUsernameRepoSlugHooksPostExample
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

            var apiInstance = new WebhooksApi();
            var username = username_example;  // string | 
            var repo_slug = repo_slug_example;  // string | 

            try
            {
                WebhookSubscription result = apiInstance.RepositoriesUsernameRepoSlugHooksPost(username, repo_slug);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhooksApi.RepositoriesUsernameRepoSlugHooksPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**|  | 
 **repo_slug** | **string**|  | 

### Return type

[**WebhookSubscription**](WebhookSubscription.md)

### Authorization

[api_key](../README.md#api_key), [basic](../README.md#basic), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="repositoriesusernamereposlughooksuiddelete"></a>
# **RepositoriesUsernameRepoSlugHooksUidDelete**
> void RepositoriesUsernameRepoSlugHooksUidDelete (string username, string repo_slug, string uid)



Deletes the specified webhook subscription from the given repository.

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Bitbucket.Rest.Api;
using Itofinity.Bitbucket.Rest.Client;
using Itofinity.Bitbucket.Rest.Model;

namespace Example
{
    public class RepositoriesUsernameRepoSlugHooksUidDeleteExample
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

            var apiInstance = new WebhooksApi();
            var username = username_example;  // string | 
            var repo_slug = repo_slug_example;  // string | 
            var uid = uid_example;  // string | The installed webhook's id

            try
            {
                apiInstance.RepositoriesUsernameRepoSlugHooksUidDelete(username, repo_slug, uid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhooksApi.RepositoriesUsernameRepoSlugHooksUidDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**|  | 
 **repo_slug** | **string**|  | 
 **uid** | **string**| The installed webhook&#39;s id | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key), [basic](../README.md#basic), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="repositoriesusernamereposlughooksuidget"></a>
# **RepositoriesUsernameRepoSlugHooksUidGet**
> WebhookSubscription RepositoriesUsernameRepoSlugHooksUidGet (string username, string repo_slug, string uid)



Returns the webhook with the specified id installed on the specified repository.

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Bitbucket.Rest.Api;
using Itofinity.Bitbucket.Rest.Client;
using Itofinity.Bitbucket.Rest.Model;

namespace Example
{
    public class RepositoriesUsernameRepoSlugHooksUidGetExample
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

            var apiInstance = new WebhooksApi();
            var username = username_example;  // string | 
            var repo_slug = repo_slug_example;  // string | 
            var uid = uid_example;  // string | The installed webhook's id.

            try
            {
                WebhookSubscription result = apiInstance.RepositoriesUsernameRepoSlugHooksUidGet(username, repo_slug, uid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhooksApi.RepositoriesUsernameRepoSlugHooksUidGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**|  | 
 **repo_slug** | **string**|  | 
 **uid** | **string**| The installed webhook&#39;s id. | 

### Return type

[**WebhookSubscription**](WebhookSubscription.md)

### Authorization

[api_key](../README.md#api_key), [basic](../README.md#basic), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="repositoriesusernamereposlughooksuidput"></a>
# **RepositoriesUsernameRepoSlugHooksUidPut**
> WebhookSubscription RepositoriesUsernameRepoSlugHooksUidPut (string username, string repo_slug, string uid)



Updates the specified webhook subscription.  The following properties can be mutated:  * `description` * `url` * `active` * `events`

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Bitbucket.Rest.Api;
using Itofinity.Bitbucket.Rest.Client;
using Itofinity.Bitbucket.Rest.Model;

namespace Example
{
    public class RepositoriesUsernameRepoSlugHooksUidPutExample
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

            var apiInstance = new WebhooksApi();
            var username = username_example;  // string | 
            var repo_slug = repo_slug_example;  // string | 
            var uid = uid_example;  // string | The installed webhook's id

            try
            {
                WebhookSubscription result = apiInstance.RepositoriesUsernameRepoSlugHooksUidPut(username, repo_slug, uid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhooksApi.RepositoriesUsernameRepoSlugHooksUidPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**|  | 
 **repo_slug** | **string**|  | 
 **uid** | **string**| The installed webhook&#39;s id | 

### Return type

[**WebhookSubscription**](WebhookSubscription.md)

### Authorization

[api_key](../README.md#api_key), [basic](../README.md#basic), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsusernamehooksget"></a>
# **TeamsUsernameHooksGet**
> PaginatedWebhookSubscriptions TeamsUsernameHooksGet (string username)



Returns a paginated list of webhooks installed on this team.

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Bitbucket.Rest.Api;
using Itofinity.Bitbucket.Rest.Client;
using Itofinity.Bitbucket.Rest.Model;

namespace Example
{
    public class TeamsUsernameHooksGetExample
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

            var apiInstance = new WebhooksApi();
            var username = username_example;  // string | 

            try
            {
                PaginatedWebhookSubscriptions result = apiInstance.TeamsUsernameHooksGet(username);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhooksApi.TeamsUsernameHooksGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**|  | 

### Return type

[**PaginatedWebhookSubscriptions**](PaginatedWebhookSubscriptions.md)

### Authorization

[api_key](../README.md#api_key), [basic](../README.md#basic), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsusernamehookspost"></a>
# **TeamsUsernameHooksPost**
> WebhookSubscription TeamsUsernameHooksPost (string username)



Creates a new webhook on the specified team.  Team webhooks are fired for events from all repositories belonging to that team account.  Note that only admins can install webhooks on teams.

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Bitbucket.Rest.Api;
using Itofinity.Bitbucket.Rest.Client;
using Itofinity.Bitbucket.Rest.Model;

namespace Example
{
    public class TeamsUsernameHooksPostExample
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

            var apiInstance = new WebhooksApi();
            var username = username_example;  // string | 

            try
            {
                WebhookSubscription result = apiInstance.TeamsUsernameHooksPost(username);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhooksApi.TeamsUsernameHooksPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**|  | 

### Return type

[**WebhookSubscription**](WebhookSubscription.md)

### Authorization

[api_key](../README.md#api_key), [basic](../README.md#basic), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsusernamehooksuiddelete"></a>
# **TeamsUsernameHooksUidDelete**
> void TeamsUsernameHooksUidDelete (string username, string uid)



Deletes the specified webhook subscription from the given team account.

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Bitbucket.Rest.Api;
using Itofinity.Bitbucket.Rest.Client;
using Itofinity.Bitbucket.Rest.Model;

namespace Example
{
    public class TeamsUsernameHooksUidDeleteExample
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

            var apiInstance = new WebhooksApi();
            var username = username_example;  // string | 
            var uid = uid_example;  // string | The installed webhook's id

            try
            {
                apiInstance.TeamsUsernameHooksUidDelete(username, uid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhooksApi.TeamsUsernameHooksUidDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**|  | 
 **uid** | **string**| The installed webhook&#39;s id | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key), [basic](../README.md#basic), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsusernamehooksuidget"></a>
# **TeamsUsernameHooksUidGet**
> WebhookSubscription TeamsUsernameHooksUidGet (string username, string uid)



Returns the webhook with the specified id installed on the given team account.

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Bitbucket.Rest.Api;
using Itofinity.Bitbucket.Rest.Client;
using Itofinity.Bitbucket.Rest.Model;

namespace Example
{
    public class TeamsUsernameHooksUidGetExample
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

            var apiInstance = new WebhooksApi();
            var username = username_example;  // string | 
            var uid = uid_example;  // string | The installed webhook's id.

            try
            {
                WebhookSubscription result = apiInstance.TeamsUsernameHooksUidGet(username, uid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhooksApi.TeamsUsernameHooksUidGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**|  | 
 **uid** | **string**| The installed webhook&#39;s id. | 

### Return type

[**WebhookSubscription**](WebhookSubscription.md)

### Authorization

[api_key](../README.md#api_key), [basic](../README.md#basic), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsusernamehooksuidput"></a>
# **TeamsUsernameHooksUidPut**
> WebhookSubscription TeamsUsernameHooksUidPut (string username, string uid)



Updates the specified webhook subscription.  The following properties can be mutated:  * `description` * `url` * `active` * `events`

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Bitbucket.Rest.Api;
using Itofinity.Bitbucket.Rest.Client;
using Itofinity.Bitbucket.Rest.Model;

namespace Example
{
    public class TeamsUsernameHooksUidPutExample
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

            var apiInstance = new WebhooksApi();
            var username = username_example;  // string | 
            var uid = uid_example;  // string | The installed webhook's id

            try
            {
                WebhookSubscription result = apiInstance.TeamsUsernameHooksUidPut(username, uid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhooksApi.TeamsUsernameHooksUidPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**|  | 
 **uid** | **string**| The installed webhook&#39;s id | 

### Return type

[**WebhookSubscription**](WebhookSubscription.md)

### Authorization

[api_key](../README.md#api_key), [basic](../README.md#basic), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersusernamehooksget"></a>
# **UsersUsernameHooksGet**
> PaginatedWebhookSubscriptions UsersUsernameHooksGet (string username)



Returns a paginated list of webhooks installed on this user account.

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Bitbucket.Rest.Api;
using Itofinity.Bitbucket.Rest.Client;
using Itofinity.Bitbucket.Rest.Model;

namespace Example
{
    public class UsersUsernameHooksGetExample
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

            var apiInstance = new WebhooksApi();
            var username = username_example;  // string | 

            try
            {
                PaginatedWebhookSubscriptions result = apiInstance.UsersUsernameHooksGet(username);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhooksApi.UsersUsernameHooksGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**|  | 

### Return type

[**PaginatedWebhookSubscriptions**](PaginatedWebhookSubscriptions.md)

### Authorization

[api_key](../README.md#api_key), [basic](../README.md#basic), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersusernamehookspost"></a>
# **UsersUsernameHooksPost**
> WebhookSubscription UsersUsernameHooksPost (string username)



Creates a new webhook on the specified user account.  Account-level webhooks are fired for events from all repositories belonging to that account.  Note that one can only register webhooks on one's own account, not that of others.

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Bitbucket.Rest.Api;
using Itofinity.Bitbucket.Rest.Client;
using Itofinity.Bitbucket.Rest.Model;

namespace Example
{
    public class UsersUsernameHooksPostExample
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

            var apiInstance = new WebhooksApi();
            var username = username_example;  // string | 

            try
            {
                WebhookSubscription result = apiInstance.UsersUsernameHooksPost(username);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhooksApi.UsersUsernameHooksPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**|  | 

### Return type

[**WebhookSubscription**](WebhookSubscription.md)

### Authorization

[api_key](../README.md#api_key), [basic](../README.md#basic), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersusernamehooksuiddelete"></a>
# **UsersUsernameHooksUidDelete**
> void UsersUsernameHooksUidDelete (string username, string uid)



Deletes the specified webhook subscription from the given user account.

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Bitbucket.Rest.Api;
using Itofinity.Bitbucket.Rest.Client;
using Itofinity.Bitbucket.Rest.Model;

namespace Example
{
    public class UsersUsernameHooksUidDeleteExample
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

            var apiInstance = new WebhooksApi();
            var username = username_example;  // string | 
            var uid = uid_example;  // string | The installed webhook's id

            try
            {
                apiInstance.UsersUsernameHooksUidDelete(username, uid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhooksApi.UsersUsernameHooksUidDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**|  | 
 **uid** | **string**| The installed webhook&#39;s id | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key), [basic](../README.md#basic), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersusernamehooksuidget"></a>
# **UsersUsernameHooksUidGet**
> WebhookSubscription UsersUsernameHooksUidGet (string username, string uid)



Returns the webhook with the specified id installed on the given user account.

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Bitbucket.Rest.Api;
using Itofinity.Bitbucket.Rest.Client;
using Itofinity.Bitbucket.Rest.Model;

namespace Example
{
    public class UsersUsernameHooksUidGetExample
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

            var apiInstance = new WebhooksApi();
            var username = username_example;  // string | 
            var uid = uid_example;  // string | The installed webhook's id.

            try
            {
                WebhookSubscription result = apiInstance.UsersUsernameHooksUidGet(username, uid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhooksApi.UsersUsernameHooksUidGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**|  | 
 **uid** | **string**| The installed webhook&#39;s id. | 

### Return type

[**WebhookSubscription**](WebhookSubscription.md)

### Authorization

[api_key](../README.md#api_key), [basic](../README.md#basic), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersusernamehooksuidput"></a>
# **UsersUsernameHooksUidPut**
> WebhookSubscription UsersUsernameHooksUidPut (string username, string uid)



Updates the specified webhook subscription.  The following properties can be mutated:  * `description` * `url` * `active` * `events`

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Bitbucket.Rest.Api;
using Itofinity.Bitbucket.Rest.Client;
using Itofinity.Bitbucket.Rest.Model;

namespace Example
{
    public class UsersUsernameHooksUidPutExample
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

            var apiInstance = new WebhooksApi();
            var username = username_example;  // string | 
            var uid = uid_example;  // string | The installed webhook's id

            try
            {
                WebhookSubscription result = apiInstance.UsersUsernameHooksUidPut(username, uid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhooksApi.UsersUsernameHooksUidPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**|  | 
 **uid** | **string**| The installed webhook&#39;s id | 

### Return type

[**WebhookSubscription**](WebhookSubscription.md)

### Authorization

[api_key](../README.md#api_key), [basic](../README.md#basic), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

