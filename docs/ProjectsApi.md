# Itofinity.Bitbucket.Rest.Api.ProjectsApi

All URIs are relative to *https://api.localhost:8000/2.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TeamsUsernameProjectsGet**](ProjectsApi.md#teamsusernameprojectsget) | **Get** /teams/{username}/projects/ | 
[**TeamsUsernameProjectsPost**](ProjectsApi.md#teamsusernameprojectspost) | **Post** /teams/{username}/projects/ | 
[**TeamsUsernameProjectsProjectKeyDelete**](ProjectsApi.md#teamsusernameprojectsprojectkeydelete) | **Delete** /teams/{username}/projects/{project_key} | 
[**TeamsUsernameProjectsProjectKeyGet**](ProjectsApi.md#teamsusernameprojectsprojectkeyget) | **Get** /teams/{username}/projects/{project_key} | 
[**TeamsUsernameProjectsProjectKeyPut**](ProjectsApi.md#teamsusernameprojectsprojectkeyput) | **Put** /teams/{username}/projects/{project_key} | 


<a name="teamsusernameprojectsget"></a>
# **TeamsUsernameProjectsGet**
> PaginatedProjects TeamsUsernameProjectsGet (string username)





### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Bitbucket.Rest.Api;
using Itofinity.Bitbucket.Rest.Client;
using Itofinity.Bitbucket.Rest.Model;

namespace Example
{
    public class TeamsUsernameProjectsGetExample
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

            var apiInstance = new ProjectsApi();
            var username = username_example;  // string | This can either be the username or the UUID of the account, surrounded by curly-braces, for example: `{account UUID}`. An account is either a team or user. 

            try
            {
                PaginatedProjects result = apiInstance.TeamsUsernameProjectsGet(username);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsApi.TeamsUsernameProjectsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**| This can either be the username or the UUID of the account, surrounded by curly-braces, for example: &#x60;{account UUID}&#x60;. An account is either a team or user.  | 

### Return type

[**PaginatedProjects**](PaginatedProjects.md)

### Authorization

[api_key](../README.md#api_key), [basic](../README.md#basic), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsusernameprojectspost"></a>
# **TeamsUsernameProjectsPost**
> Project TeamsUsernameProjectsPost (string username, Project _body)



Creates a new project.  Note that the avatar has to be embedded as either a data-url or a URL to an external image as shown in the examples below:  ``` $ body=$(cat << EOF {     \"name\": \"Mars Project\",     \"key\": \"MARS\",     \"description\": \"Software for colonizing mars.\",     \"links\": {         \"avatar\": {             \"href\": \"data:image/gif;base64,R0lGODlhEAAQAMQAAORHHOVSKudfOulrSOp3WOyDZu6QdvCchPGolfO0o/...\"         }     },     \"is_private\": false } EOF ) $ curl -H \"Content-Type: application/json\" \\        -X POST \\        -d \"$body\" \\        https://api.bitbucket.org/2.0/teams/teams-in-space/projects/ | jq . {   // Serialized project document } ```  or even:  ``` $ body=$(cat << EOF {     \"name\": \"Mars Project\",     \"key\": \"MARS\",     \"description\": \"Software for colonizing mars.\",     \"links\": {         \"avatar\": {             \"href\": \"http://i.imgur.com/72tRx4w.gif\"         }     },     \"is_private\": false } EOF ) $ curl -H \"Content-Type: application/json\" \\        -X POST \\        -d \"$body\" \\        https://api.bitbucket.org/2.0/teams/teams-in-space/projects/ | jq . {   // Serialized project document } ```

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Bitbucket.Rest.Api;
using Itofinity.Bitbucket.Rest.Client;
using Itofinity.Bitbucket.Rest.Model;

namespace Example
{
    public class TeamsUsernameProjectsPostExample
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

            var apiInstance = new ProjectsApi();
            var username = username_example;  // string | This can either be the username or the UUID of the account, surrounded by curly-braces, for example: `{account UUID}`. An account is either a team or user. 
            var _body = new Project(); // Project | 

            try
            {
                Project result = apiInstance.TeamsUsernameProjectsPost(username, _body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsApi.TeamsUsernameProjectsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**| This can either be the username or the UUID of the account, surrounded by curly-braces, for example: &#x60;{account UUID}&#x60;. An account is either a team or user.  | 
 **_body** | [**Project**](Project.md)|  | 

### Return type

[**Project**](Project.md)

### Authorization

[api_key](../README.md#api_key), [basic](../README.md#basic), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsusernameprojectsprojectkeydelete"></a>
# **TeamsUsernameProjectsProjectKeyDelete**
> void TeamsUsernameProjectsProjectKeyDelete (string username, string project_key)





### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Bitbucket.Rest.Api;
using Itofinity.Bitbucket.Rest.Client;
using Itofinity.Bitbucket.Rest.Model;

namespace Example
{
    public class TeamsUsernameProjectsProjectKeyDeleteExample
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

            var apiInstance = new ProjectsApi();
            var username = username_example;  // string | This can either be the username or the UUID of the account, surrounded by curly-braces, for example: `{account UUID}`. An account is either a team or user. 
            var project_key = project_key_example;  // string | The project in question. This can either be the actual `key` assigned to the project or the `UUID` (surrounded by curly-braces (`{}`)). 

            try
            {
                apiInstance.TeamsUsernameProjectsProjectKeyDelete(username, project_key);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsApi.TeamsUsernameProjectsProjectKeyDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**| This can either be the username or the UUID of the account, surrounded by curly-braces, for example: &#x60;{account UUID}&#x60;. An account is either a team or user.  | 
 **project_key** | **string**| The project in question. This can either be the actual &#x60;key&#x60; assigned to the project or the &#x60;UUID&#x60; (surrounded by curly-braces (&#x60;{}&#x60;)).  | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key), [basic](../README.md#basic), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsusernameprojectsprojectkeyget"></a>
# **TeamsUsernameProjectsProjectKeyGet**
> Project TeamsUsernameProjectsProjectKeyGet (string username, string project_key)





### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Bitbucket.Rest.Api;
using Itofinity.Bitbucket.Rest.Client;
using Itofinity.Bitbucket.Rest.Model;

namespace Example
{
    public class TeamsUsernameProjectsProjectKeyGetExample
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

            var apiInstance = new ProjectsApi();
            var username = username_example;  // string | This can either be the username or the UUID of the account, surrounded by curly-braces, for example: `{account UUID}`. An account is either a team or user. 
            var project_key = project_key_example;  // string | The project in question. This can either be the actual `key` assigned to the project or the `UUID` (surrounded by curly-braces (`{}`)). 

            try
            {
                Project result = apiInstance.TeamsUsernameProjectsProjectKeyGet(username, project_key);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsApi.TeamsUsernameProjectsProjectKeyGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**| This can either be the username or the UUID of the account, surrounded by curly-braces, for example: &#x60;{account UUID}&#x60;. An account is either a team or user.  | 
 **project_key** | **string**| The project in question. This can either be the actual &#x60;key&#x60; assigned to the project or the &#x60;UUID&#x60; (surrounded by curly-braces (&#x60;{}&#x60;)).  | 

### Return type

[**Project**](Project.md)

### Authorization

[api_key](../README.md#api_key), [basic](../README.md#basic), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsusernameprojectsprojectkeyput"></a>
# **TeamsUsernameProjectsProjectKeyPut**
> Project TeamsUsernameProjectsProjectKeyPut (string username, string project_key, Project _body)



Since this endpoint can be used to both update and to create a project, the request body depends on the intent.  ### Creation  See the POST documentation for the project collection for an example of the request body.  Note: The `key` should not be specified in the body of request (since it is already present in the URL). The `name` is required, everything else is optional.  ### Update  See the POST documentation for the project collection for an example of the request body.  Note: The key is not required in the body (since it is already in the URL). The key may be specified in the body, if the intent is to change the key itself. In such a scenario, the location of the project is changed and is returned in the `Location` header of the response.

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Bitbucket.Rest.Api;
using Itofinity.Bitbucket.Rest.Client;
using Itofinity.Bitbucket.Rest.Model;

namespace Example
{
    public class TeamsUsernameProjectsProjectKeyPutExample
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

            var apiInstance = new ProjectsApi();
            var username = username_example;  // string | This can either be the username or the UUID of the account, surrounded by curly-braces, for example: `{account UUID}`. An account is either a team or user. 
            var project_key = project_key_example;  // string | The project in question. This can either be the actual `key` assigned to the project or the `UUID` (surrounded by curly-braces (`{}`)). 
            var _body = new Project(); // Project | 

            try
            {
                Project result = apiInstance.TeamsUsernameProjectsProjectKeyPut(username, project_key, _body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsApi.TeamsUsernameProjectsProjectKeyPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**| This can either be the username or the UUID of the account, surrounded by curly-braces, for example: &#x60;{account UUID}&#x60;. An account is either a team or user.  | 
 **project_key** | **string**| The project in question. This can either be the actual &#x60;key&#x60; assigned to the project or the &#x60;UUID&#x60; (surrounded by curly-braces (&#x60;{}&#x60;)).  | 
 **_body** | [**Project**](Project.md)|  | 

### Return type

[**Project**](Project.md)

### Authorization

[api_key](../README.md#api_key), [basic](../README.md#basic), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

