# Itofinity.Bitbucket.Rest.Api.TeamsApi

All URIs are relative to *https://api.localhost:8000/2.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TeamsGet**](TeamsApi.md#teamsget) | **Get** /teams | 
[**TeamsUsernameFollowersGet**](TeamsApi.md#teamsusernamefollowersget) | **Get** /teams/{username}/followers | 
[**TeamsUsernameFollowingGet**](TeamsApi.md#teamsusernamefollowingget) | **Get** /teams/{username}/following | 
[**TeamsUsernameGet**](TeamsApi.md#teamsusernameget) | **Get** /teams/{username} | 
[**TeamsUsernameHooksGet**](TeamsApi.md#teamsusernamehooksget) | **Get** /teams/{username}/hooks | 
[**TeamsUsernameHooksPost**](TeamsApi.md#teamsusernamehookspost) | **Post** /teams/{username}/hooks | 
[**TeamsUsernameHooksUidDelete**](TeamsApi.md#teamsusernamehooksuiddelete) | **Delete** /teams/{username}/hooks/{uid} | 
[**TeamsUsernameHooksUidGet**](TeamsApi.md#teamsusernamehooksuidget) | **Get** /teams/{username}/hooks/{uid} | 
[**TeamsUsernameHooksUidPut**](TeamsApi.md#teamsusernamehooksuidput) | **Put** /teams/{username}/hooks/{uid} | 
[**TeamsUsernameMembersGet**](TeamsApi.md#teamsusernamemembersget) | **Get** /teams/{username}/members | 
[**TeamsUsernameRepositoriesGet**](TeamsApi.md#teamsusernamerepositoriesget) | **Get** /teams/{username}/repositories | 
[**UsersUsernameMembersGet**](TeamsApi.md#usersusernamemembersget) | **Get** /users/{username}/members | 
[**UsersUsernameRepositoriesGet**](TeamsApi.md#usersusernamerepositoriesget) | **Get** /users/{username}/repositories | 


<a name="teamsget"></a>
# **TeamsGet**
> PaginatedTeams TeamsGet (string role = null)



Returns all the teams that the authenticated user is associated with.

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Bitbucket.Rest.Api;
using Itofinity.Bitbucket.Rest.Client;
using Itofinity.Bitbucket.Rest.Model;

namespace Example
{
    public class TeamsGetExample
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

            var apiInstance = new TeamsApi();
            var role = role_example;  // string |  Filters the teams based on the authenticated user's role on each team.  * **member**: returns a list of all the teams which the caller is a member of   at least one team group or repository owned by the team * **contributor**: returns a list of teams which the caller has write access   to at least one repository owned by the team * **admin**: returns a list teams which the caller has team administrator access  (optional) 

            try
            {
                PaginatedTeams result = apiInstance.TeamsGet(role);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **role** | **string**|  Filters the teams based on the authenticated user&#39;s role on each team.  * **member**: returns a list of all the teams which the caller is a member of   at least one team group or repository owned by the team * **contributor**: returns a list of teams which the caller has write access   to at least one repository owned by the team * **admin**: returns a list teams which the caller has team administrator access  | [optional] 

### Return type

[**PaginatedTeams**](PaginatedTeams.md)

### Authorization

[api_key](../README.md#api_key), [basic](../README.md#basic), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsusernamefollowersget"></a>
# **TeamsUsernameFollowersGet**
> PaginatedUsers TeamsUsernameFollowersGet (string username)



Returns the list of accounts that are following this team.

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Bitbucket.Rest.Api;
using Itofinity.Bitbucket.Rest.Client;
using Itofinity.Bitbucket.Rest.Model;

namespace Example
{
    public class TeamsUsernameFollowersGetExample
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

            var apiInstance = new TeamsApi();
            var username = username_example;  // string | The team's username

            try
            {
                PaginatedUsers result = apiInstance.TeamsUsernameFollowersGet(username);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsUsernameFollowersGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**| The team&#39;s username | 

### Return type

[**PaginatedUsers**](PaginatedUsers.md)

### Authorization

[api_key](../README.md#api_key), [basic](../README.md#basic), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsusernamefollowingget"></a>
# **TeamsUsernameFollowingGet**
> PaginatedUsers TeamsUsernameFollowingGet (string username)



Returns the list of accounts this team is following.

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Bitbucket.Rest.Api;
using Itofinity.Bitbucket.Rest.Client;
using Itofinity.Bitbucket.Rest.Model;

namespace Example
{
    public class TeamsUsernameFollowingGetExample
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

            var apiInstance = new TeamsApi();
            var username = username_example;  // string | The team's username

            try
            {
                PaginatedUsers result = apiInstance.TeamsUsernameFollowingGet(username);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsUsernameFollowingGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**| The team&#39;s username | 

### Return type

[**PaginatedUsers**](PaginatedUsers.md)

### Authorization

[api_key](../README.md#api_key), [basic](../README.md#basic), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsusernameget"></a>
# **TeamsUsernameGet**
> Team TeamsUsernameGet (string username)



Gets the public information associated with a team.  If the team's profile is private, `location`, `website` and `created_on` elements are omitted.

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Bitbucket.Rest.Api;
using Itofinity.Bitbucket.Rest.Client;
using Itofinity.Bitbucket.Rest.Model;

namespace Example
{
    public class TeamsUsernameGetExample
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

            var apiInstance = new TeamsApi();
            var username = username_example;  // string | The team's username or UUID.

            try
            {
                Team result = apiInstance.TeamsUsernameGet(username);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsUsernameGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**| The team&#39;s username or UUID. | 

### Return type

[**Team**](Team.md)

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

            var apiInstance = new TeamsApi();
            var username = username_example;  // string | 

            try
            {
                PaginatedWebhookSubscriptions result = apiInstance.TeamsUsernameHooksGet(username);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsUsernameHooksGet: " + e.Message );
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

            var apiInstance = new TeamsApi();
            var username = username_example;  // string | 

            try
            {
                WebhookSubscription result = apiInstance.TeamsUsernameHooksPost(username);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsUsernameHooksPost: " + e.Message );
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

            var apiInstance = new TeamsApi();
            var username = username_example;  // string | 
            var uid = uid_example;  // string | The installed webhook's id

            try
            {
                apiInstance.TeamsUsernameHooksUidDelete(username, uid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsUsernameHooksUidDelete: " + e.Message );
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

            var apiInstance = new TeamsApi();
            var username = username_example;  // string | 
            var uid = uid_example;  // string | The installed webhook's id.

            try
            {
                WebhookSubscription result = apiInstance.TeamsUsernameHooksUidGet(username, uid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsUsernameHooksUidGet: " + e.Message );
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

            var apiInstance = new TeamsApi();
            var username = username_example;  // string | 
            var uid = uid_example;  // string | The installed webhook's id

            try
            {
                WebhookSubscription result = apiInstance.TeamsUsernameHooksUidPut(username, uid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsUsernameHooksUidPut: " + e.Message );
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

<a name="teamsusernamemembersget"></a>
# **TeamsUsernameMembersGet**
> User TeamsUsernameMembersGet (string username)



All members of a team.  Returns all members of the specified team. Any member of any of the team's groups is considered a member of the team. This includes users in groups that may not actually have access to any of the team's repositories.  Note that members using the \"private profile\" feature are not included.

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Bitbucket.Rest.Api;
using Itofinity.Bitbucket.Rest.Client;
using Itofinity.Bitbucket.Rest.Model;

namespace Example
{
    public class TeamsUsernameMembersGetExample
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

            var apiInstance = new TeamsApi();
            var username = username_example;  // string | 

            try
            {
                User result = apiInstance.TeamsUsernameMembersGet(username);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsUsernameMembersGet: " + e.Message );
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

[**User**](User.md)

### Authorization

[api_key](../README.md#api_key), [basic](../README.md#basic), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsusernamerepositoriesget"></a>
# **TeamsUsernameRepositoriesGet**
> Error TeamsUsernameRepositoriesGet (string username)



All repositories owned by a user/team. This includes private repositories, but filtered down to the ones that the calling user has access to.

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Bitbucket.Rest.Api;
using Itofinity.Bitbucket.Rest.Client;
using Itofinity.Bitbucket.Rest.Model;

namespace Example
{
    public class TeamsUsernameRepositoriesGetExample
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

            var apiInstance = new TeamsApi();
            var username = username_example;  // string | 

            try
            {
                Error result = apiInstance.TeamsUsernameRepositoriesGet(username);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsUsernameRepositoriesGet: " + e.Message );
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

[**Error**](Error.md)

### Authorization

[api_key](../README.md#api_key), [basic](../README.md#basic), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersusernamemembersget"></a>
# **UsersUsernameMembersGet**
> User UsersUsernameMembersGet (string username)



All members of a team.  Returns all members of the specified team. Any member of any of the team's groups is considered a member of the team. This includes users in groups that may not actually have access to any of the team's repositories.  Note that members using the \"private profile\" feature are not included.

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Bitbucket.Rest.Api;
using Itofinity.Bitbucket.Rest.Client;
using Itofinity.Bitbucket.Rest.Model;

namespace Example
{
    public class UsersUsernameMembersGetExample
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

            var apiInstance = new TeamsApi();
            var username = username_example;  // string | 

            try
            {
                User result = apiInstance.UsersUsernameMembersGet(username);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.UsersUsernameMembersGet: " + e.Message );
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

[**User**](User.md)

### Authorization

[api_key](../README.md#api_key), [basic](../README.md#basic), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersusernamerepositoriesget"></a>
# **UsersUsernameRepositoriesGet**
> Error UsersUsernameRepositoriesGet (string username)



All repositories owned by a user/team. This includes private repositories, but filtered down to the ones that the calling user has access to.

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Bitbucket.Rest.Api;
using Itofinity.Bitbucket.Rest.Client;
using Itofinity.Bitbucket.Rest.Model;

namespace Example
{
    public class UsersUsernameRepositoriesGetExample
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

            var apiInstance = new TeamsApi();
            var username = username_example;  // string | 

            try
            {
                Error result = apiInstance.UsersUsernameRepositoriesGet(username);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.UsersUsernameRepositoriesGet: " + e.Message );
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

[**Error**](Error.md)

### Authorization

[api_key](../README.md#api_key), [basic](../README.md#basic), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

