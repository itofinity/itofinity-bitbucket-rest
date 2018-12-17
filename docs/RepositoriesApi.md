# Itofinity.Bitbucket.Refit.Api.RepositoriesApi

All URIs are relative to *https://api.localhost:8000/2.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**RepositoriesGet**](RepositoriesApi.md#repositoriesget) | **Get** /repositories | 
[**RepositoriesUsernameGet**](RepositoriesApi.md#repositoriesusernameget) | **Get** /repositories/{username} | 
[**RepositoriesUsernameRepoSlugCommitNodeStatusesBuildKeyGet**](RepositoriesApi.md#repositoriesusernamereposlugcommitnodestatusesbuildkeyget) | **Get** /repositories/{username}/{repo_slug}/commit/{node}/statuses/build/{key} | 
[**RepositoriesUsernameRepoSlugCommitNodeStatusesBuildKeyPut**](RepositoriesApi.md#repositoriesusernamereposlugcommitnodestatusesbuildkeyput) | **Put** /repositories/{username}/{repo_slug}/commit/{node}/statuses/build/{key} | 
[**RepositoriesUsernameRepoSlugCommitNodeStatusesBuildPost**](RepositoriesApi.md#repositoriesusernamereposlugcommitnodestatusesbuildpost) | **Post** /repositories/{username}/{repo_slug}/commit/{node}/statuses/build | 
[**RepositoriesUsernameRepoSlugCommitNodeStatusesGet**](RepositoriesApi.md#repositoriesusernamereposlugcommitnodestatusesget) | **Get** /repositories/{username}/{repo_slug}/commit/{node}/statuses | 
[**RepositoriesUsernameRepoSlugDelete**](RepositoriesApi.md#repositoriesusernamereposlugdelete) | **Delete** /repositories/{username}/{repo_slug} | 
[**RepositoriesUsernameRepoSlugFilehistoryNodePathGet**](RepositoriesApi.md#repositoriesusernamereposlugfilehistorynodepathget) | **Get** /repositories/{username}/{repo_slug}/filehistory/{node}/{path} | 
[**RepositoriesUsernameRepoSlugForksGet**](RepositoriesApi.md#repositoriesusernamereposlugforksget) | **Get** /repositories/{username}/{repo_slug}/forks | 
[**RepositoriesUsernameRepoSlugForksPost**](RepositoriesApi.md#repositoriesusernamereposlugforkspost) | **Post** /repositories/{username}/{repo_slug}/forks | 
[**RepositoriesUsernameRepoSlugGet**](RepositoriesApi.md#repositoriesusernamereposlugget) | **Get** /repositories/{username}/{repo_slug} | 
[**RepositoriesUsernameRepoSlugHooksGet**](RepositoriesApi.md#repositoriesusernamereposlughooksget) | **Get** /repositories/{username}/{repo_slug}/hooks | 
[**RepositoriesUsernameRepoSlugHooksPost**](RepositoriesApi.md#repositoriesusernamereposlughookspost) | **Post** /repositories/{username}/{repo_slug}/hooks | 
[**RepositoriesUsernameRepoSlugHooksUidDelete**](RepositoriesApi.md#repositoriesusernamereposlughooksuiddelete) | **Delete** /repositories/{username}/{repo_slug}/hooks/{uid} | 
[**RepositoriesUsernameRepoSlugHooksUidGet**](RepositoriesApi.md#repositoriesusernamereposlughooksuidget) | **Get** /repositories/{username}/{repo_slug}/hooks/{uid} | 
[**RepositoriesUsernameRepoSlugHooksUidPut**](RepositoriesApi.md#repositoriesusernamereposlughooksuidput) | **Put** /repositories/{username}/{repo_slug}/hooks/{uid} | 
[**RepositoriesUsernameRepoSlugPost**](RepositoriesApi.md#repositoriesusernamereposlugpost) | **Post** /repositories/{username}/{repo_slug} | 
[**RepositoriesUsernameRepoSlugPullrequestsPullRequestIdStatusesGet**](RepositoriesApi.md#repositoriesusernamereposlugpullrequestspullrequestidstatusesget) | **Get** /repositories/{username}/{repo_slug}/pullrequests/{pull_request_id}/statuses | 
[**RepositoriesUsernameRepoSlugPut**](RepositoriesApi.md#repositoriesusernamereposlugput) | **Put** /repositories/{username}/{repo_slug} | 
[**RepositoriesUsernameRepoSlugSrcGet**](RepositoriesApi.md#repositoriesusernamereposlugsrcget) | **Get** /repositories/{username}/{repo_slug}/src | 
[**RepositoriesUsernameRepoSlugSrcNodePathGet**](RepositoriesApi.md#repositoriesusernamereposlugsrcnodepathget) | **Get** /repositories/{username}/{repo_slug}/src/{node}/{path} | 
[**RepositoriesUsernameRepoSlugSrcPost**](RepositoriesApi.md#repositoriesusernamereposlugsrcpost) | **Post** /repositories/{username}/{repo_slug}/src | 
[**RepositoriesUsernameRepoSlugWatchersGet**](RepositoriesApi.md#repositoriesusernamereposlugwatchersget) | **Get** /repositories/{username}/{repo_slug}/watchers | 
[**UserPermissionsRepositoriesGet**](RepositoriesApi.md#userpermissionsrepositoriesget) | **Get** /user/permissions/repositories | 


<a name="repositoriesget"></a>
# **RepositoriesGet**
> PaginatedRepositories RepositoriesGet (string after = null)



Returns a paginated list of all public repositories.  This endpoint also supports filtering and sorting of the results. See [filtering and sorting](../meta/filtering) for more details.

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Bitbucket.Refit.Api;
using Itofinity.Bitbucket.Refit.Client;
using Itofinity.Bitbucket.Refit.Model;

namespace Example
{
    public class RepositoriesGetExample
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

            var apiInstance = new RepositoriesApi();
            var after = after_example;  // string | Filter the results to include only repositories create on or after this [ISO-8601](https://en.wikipedia.org/wiki/ISO_8601)  timestamp. Example: `YYYY-MM-DDTHH:mm:ss.sssZ` (optional) 

            try
            {
                PaginatedRepositories result = apiInstance.RepositoriesGet(after);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoriesApi.RepositoriesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **after** | **string**| Filter the results to include only repositories create on or after this [ISO-8601](https://en.wikipedia.org/wiki/ISO_8601)  timestamp. Example: &#x60;YYYY-MM-DDTHH:mm:ss.sssZ&#x60; | [optional] 

### Return type

[**PaginatedRepositories**](PaginatedRepositories.md)

### Authorization

[api_key](../README.md#api_key), [basic](../README.md#basic), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="repositoriesusernameget"></a>
# **RepositoriesUsernameGet**
> PaginatedRepositories RepositoriesUsernameGet (string username, string role = null)



Returns a paginated list of all repositories owned by the specified account or UUID.  The result can be narrowed down based on the authenticated user's role.  E.g. with `?role=contributor`, only those repositories that the authenticated user has write access to are returned (this includes any repo the user is an admin on, as that implies write access).  This endpoint also supports filtering and sorting of the results. See [filtering and sorting](../../meta/filtering) for more details.

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Bitbucket.Refit.Api;
using Itofinity.Bitbucket.Refit.Client;
using Itofinity.Bitbucket.Refit.Model;

namespace Example
{
    public class RepositoriesUsernameGetExample
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

            var apiInstance = new RepositoriesApi();
            var username = username_example;  // string | This can either be the username or the UUID of the account, surrounded by curly-braces, for example: `{account UUID}`. An account is either a team or user. 
            var role = role_example;  // string |  Filters the result based on the authenticated user's role on each repository.  * **member**: returns repositories to which the user has explicit read access * **contributor**: returns repositories to which the user has explicit write access * **admin**: returns repositories to which the user has explicit administrator access * **owner**: returns all repositories owned by the current user  (optional) 

            try
            {
                PaginatedRepositories result = apiInstance.RepositoriesUsernameGet(username, role);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoriesApi.RepositoriesUsernameGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**| This can either be the username or the UUID of the account, surrounded by curly-braces, for example: &#x60;{account UUID}&#x60;. An account is either a team or user.  | 
 **role** | **string**|  Filters the result based on the authenticated user&#39;s role on each repository.  * **member**: returns repositories to which the user has explicit read access * **contributor**: returns repositories to which the user has explicit write access * **admin**: returns repositories to which the user has explicit administrator access * **owner**: returns all repositories owned by the current user  | [optional] 

### Return type

[**PaginatedRepositories**](PaginatedRepositories.md)

### Authorization

[api_key](../README.md#api_key), [basic](../README.md#basic), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="repositoriesusernamereposlugcommitnodestatusesbuildkeyget"></a>
# **RepositoriesUsernameRepoSlugCommitNodeStatusesBuildKeyGet**
> Commitstatus RepositoriesUsernameRepoSlugCommitNodeStatusesBuildKeyGet (string username, string node, string key, string repo_slug)



Returns the specified build status for a commit.

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Bitbucket.Refit.Api;
using Itofinity.Bitbucket.Refit.Client;
using Itofinity.Bitbucket.Refit.Model;

namespace Example
{
    public class RepositoriesUsernameRepoSlugCommitNodeStatusesBuildKeyGetExample
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

            var apiInstance = new RepositoriesApi();
            var username = username_example;  // string | This can either be the username or the UUID of the account, surrounded by curly-braces, for example: `{account UUID}`. An account is either a team or user. 
            var node = node_example;  // string | The commit's SHA1.
            var key = key_example;  // string | The build status' unique key
            var repo_slug = repo_slug_example;  // string | This can either be the repository slug or the UUID of the repository, surrounded by curly-braces, for example: `{repository UUID}`. 

            try
            {
                Commitstatus result = apiInstance.RepositoriesUsernameRepoSlugCommitNodeStatusesBuildKeyGet(username, node, key, repo_slug);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoriesApi.RepositoriesUsernameRepoSlugCommitNodeStatusesBuildKeyGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**| This can either be the username or the UUID of the account, surrounded by curly-braces, for example: &#x60;{account UUID}&#x60;. An account is either a team or user.  | 
 **node** | **string**| The commit&#39;s SHA1. | 
 **key** | **string**| The build status&#39; unique key | 
 **repo_slug** | **string**| This can either be the repository slug or the UUID of the repository, surrounded by curly-braces, for example: &#x60;{repository UUID}&#x60;.  | 

### Return type

[**Commitstatus**](Commitstatus.md)

### Authorization

[api_key](../README.md#api_key), [basic](../README.md#basic), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="repositoriesusernamereposlugcommitnodestatusesbuildkeyput"></a>
# **RepositoriesUsernameRepoSlugCommitNodeStatusesBuildKeyPut**
> Commitstatus RepositoriesUsernameRepoSlugCommitNodeStatusesBuildKeyPut (string username, string node, string key, string repo_slug, Commitstatus _body = null)



Used to update the current status of a build status object on the specific commit.  This operation can also be used to change other properties of the build status:  * `state` * `name` * `description` * `url` * `refname`  The `key` cannot be changed.

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Bitbucket.Refit.Api;
using Itofinity.Bitbucket.Refit.Client;
using Itofinity.Bitbucket.Refit.Model;

namespace Example
{
    public class RepositoriesUsernameRepoSlugCommitNodeStatusesBuildKeyPutExample
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

            var apiInstance = new RepositoriesApi();
            var username = username_example;  // string | This can either be the username or the UUID of the account, surrounded by curly-braces, for example: `{account UUID}`. An account is either a team or user. 
            var node = node_example;  // string | The commit's SHA1.
            var key = key_example;  // string | The build status' unique key
            var repo_slug = repo_slug_example;  // string | This can either be the repository slug or the UUID of the repository, surrounded by curly-braces, for example: `{repository UUID}`. 
            var _body = new Commitstatus(); // Commitstatus | The updated build status object (optional) 

            try
            {
                Commitstatus result = apiInstance.RepositoriesUsernameRepoSlugCommitNodeStatusesBuildKeyPut(username, node, key, repo_slug, _body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoriesApi.RepositoriesUsernameRepoSlugCommitNodeStatusesBuildKeyPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**| This can either be the username or the UUID of the account, surrounded by curly-braces, for example: &#x60;{account UUID}&#x60;. An account is either a team or user.  | 
 **node** | **string**| The commit&#39;s SHA1. | 
 **key** | **string**| The build status&#39; unique key | 
 **repo_slug** | **string**| This can either be the repository slug or the UUID of the repository, surrounded by curly-braces, for example: &#x60;{repository UUID}&#x60;.  | 
 **_body** | [**Commitstatus**](Commitstatus.md)| The updated build status object | [optional] 

### Return type

[**Commitstatus**](Commitstatus.md)

### Authorization

[api_key](../README.md#api_key), [basic](../README.md#basic), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="repositoriesusernamereposlugcommitnodestatusesbuildpost"></a>
# **RepositoriesUsernameRepoSlugCommitNodeStatusesBuildPost**
> Commitstatus RepositoriesUsernameRepoSlugCommitNodeStatusesBuildPost (string username, string node, string repo_slug, Commitstatus _body = null)



Creates a new build status against the specified commit.  If the specified key already exists, the existing status object will be overwritten.  When creating a new commit status, you can use a URI template for the URL. Templates are URLs that contain variable names that Bitbucket will evaluate at runtime whenever the URL is displayed anywhere similar to parameter substitution in [Bitbucket Connect](https://developer.atlassian.com/bitbucket/concepts/context-parameters.html). For example, one could use `https://foo.com/builds/{repository.full_name}` which Bitbucket will turn into `https://foo.com/builds/foo/bar` at render time. The context variables available are `repository` and `commit`.

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Bitbucket.Refit.Api;
using Itofinity.Bitbucket.Refit.Client;
using Itofinity.Bitbucket.Refit.Model;

namespace Example
{
    public class RepositoriesUsernameRepoSlugCommitNodeStatusesBuildPostExample
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

            var apiInstance = new RepositoriesApi();
            var username = username_example;  // string | This can either be the username or the UUID of the account, surrounded by curly-braces, for example: `{account UUID}`. An account is either a team or user. 
            var node = node_example;  // string | The commit's SHA1.
            var repo_slug = repo_slug_example;  // string | This can either be the repository slug or the UUID of the repository, surrounded by curly-braces, for example: `{repository UUID}`. 
            var _body = new Commitstatus(); // Commitstatus | The new commit status object. (optional) 

            try
            {
                Commitstatus result = apiInstance.RepositoriesUsernameRepoSlugCommitNodeStatusesBuildPost(username, node, repo_slug, _body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoriesApi.RepositoriesUsernameRepoSlugCommitNodeStatusesBuildPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**| This can either be the username or the UUID of the account, surrounded by curly-braces, for example: &#x60;{account UUID}&#x60;. An account is either a team or user.  | 
 **node** | **string**| The commit&#39;s SHA1. | 
 **repo_slug** | **string**| This can either be the repository slug or the UUID of the repository, surrounded by curly-braces, for example: &#x60;{repository UUID}&#x60;.  | 
 **_body** | [**Commitstatus**](Commitstatus.md)| The new commit status object. | [optional] 

### Return type

[**Commitstatus**](Commitstatus.md)

### Authorization

[api_key](../README.md#api_key), [basic](../README.md#basic), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="repositoriesusernamereposlugcommitnodestatusesget"></a>
# **RepositoriesUsernameRepoSlugCommitNodeStatusesGet**
> PaginatedCommitstatuses RepositoriesUsernameRepoSlugCommitNodeStatusesGet (string username, string node, string repo_slug)



Returns all statuses (e.g. build results) for a specific commit.

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Bitbucket.Refit.Api;
using Itofinity.Bitbucket.Refit.Client;
using Itofinity.Bitbucket.Refit.Model;

namespace Example
{
    public class RepositoriesUsernameRepoSlugCommitNodeStatusesGetExample
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

            var apiInstance = new RepositoriesApi();
            var username = username_example;  // string | This can either be the username or the UUID of the account, surrounded by curly-braces, for example: `{account UUID}`. An account is either a team or user. 
            var node = node_example;  // string | The commit's SHA1.
            var repo_slug = repo_slug_example;  // string | This can either be the repository slug or the UUID of the repository, surrounded by curly-braces, for example: `{repository UUID}`. 

            try
            {
                PaginatedCommitstatuses result = apiInstance.RepositoriesUsernameRepoSlugCommitNodeStatusesGet(username, node, repo_slug);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoriesApi.RepositoriesUsernameRepoSlugCommitNodeStatusesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**| This can either be the username or the UUID of the account, surrounded by curly-braces, for example: &#x60;{account UUID}&#x60;. An account is either a team or user.  | 
 **node** | **string**| The commit&#39;s SHA1. | 
 **repo_slug** | **string**| This can either be the repository slug or the UUID of the repository, surrounded by curly-braces, for example: &#x60;{repository UUID}&#x60;.  | 

### Return type

[**PaginatedCommitstatuses**](PaginatedCommitstatuses.md)

### Authorization

[api_key](../README.md#api_key), [basic](../README.md#basic), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="repositoriesusernamereposlugdelete"></a>
# **RepositoriesUsernameRepoSlugDelete**
> void RepositoriesUsernameRepoSlugDelete (string username, string repo_slug, string redirect_to = null)



Deletes the repository. This is an irreversible operation.  This does not affect its forks.

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Bitbucket.Refit.Api;
using Itofinity.Bitbucket.Refit.Client;
using Itofinity.Bitbucket.Refit.Model;

namespace Example
{
    public class RepositoriesUsernameRepoSlugDeleteExample
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

            var apiInstance = new RepositoriesApi();
            var username = username_example;  // string | This can either be the username or the UUID of the account, surrounded by curly-braces, for example: `{account UUID}`. An account is either a team or user. 
            var repo_slug = repo_slug_example;  // string | This can either be the repository slug or the UUID of the repository, surrounded by curly-braces, for example: `{repository UUID}`. 
            var redirect_to = redirect_to_example;  // string | If a repository has been moved to a new location, use this parameter to show users a friendly message in the Bitbucket UI that the repository has moved to a new location. However, a GET to this endpoint will still return a 404.  (optional) 

            try
            {
                apiInstance.RepositoriesUsernameRepoSlugDelete(username, repo_slug, redirect_to);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoriesApi.RepositoriesUsernameRepoSlugDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**| This can either be the username or the UUID of the account, surrounded by curly-braces, for example: &#x60;{account UUID}&#x60;. An account is either a team or user.  | 
 **repo_slug** | **string**| This can either be the repository slug or the UUID of the repository, surrounded by curly-braces, for example: &#x60;{repository UUID}&#x60;.  | 
 **redirect_to** | **string**| If a repository has been moved to a new location, use this parameter to show users a friendly message in the Bitbucket UI that the repository has moved to a new location. However, a GET to this endpoint will still return a 404.  | [optional] 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key), [basic](../README.md#basic), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="repositoriesusernamereposlugfilehistorynodepathget"></a>
# **RepositoriesUsernameRepoSlugFilehistoryNodePathGet**
> PaginatedFiles RepositoriesUsernameRepoSlugFilehistoryNodePathGet (string username, string node, string path, string repo_slug, string renames = null, string q = null, string sort = null)



Returns a paginated list of commits that modified the specified file.  Commits are returned in reverse chronological order. This is roughly equivalent to the following commands:      $ git log - -follow - -date-order <sha> <path>      $ hg log - -follow <path>  By default, Bitbucket will follow renames and the path name in the returned entries reflects that. This can be turned off using the `?renames=false` query parameter.  Results are returned in descending chronological order by default, and like most endpoints you can [filter and sort](../../../../../../meta/filtering) the response to only provide exactly the data you want.  For example, if you wanted to find commits made before 2011-05-18 against a file named `README.rst`, but you only wanted the path and date, your query would look like this:  ``` $ curl 'https://api.bitbucket.org/2.0/repositories/evzijst/dogslow/filehistory/master/README.rst'\\   '?fields=values.next,values.path,values.commit.date&q=commit.date<=2011-05-18' {   \"values\": [     {       \"commit\": {         \"date\": \"2011-05-17T07:32:09+00:00\"       },       \"path\": \"README.rst\"     },     {       \"commit\": {         \"date\": \"2011-05-16T06:33:28+00:00\"       },       \"path\": \"README.txt\"     },     {       \"commit\": {         \"date\": \"2011-05-16T06:15:39+00:00\"       },       \"path\": \"README.txt\"     }   ] } ```  In the response you can see that the file was renamed to `README.rst` by the commit made on 2011-05-16, and was previously named `README.txt`.

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Bitbucket.Refit.Api;
using Itofinity.Bitbucket.Refit.Client;
using Itofinity.Bitbucket.Refit.Model;

namespace Example
{
    public class RepositoriesUsernameRepoSlugFilehistoryNodePathGetExample
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

            var apiInstance = new RepositoriesApi();
            var username = username_example;  // string | 
            var node = node_example;  // string | 
            var path = path_example;  // string | 
            var repo_slug = repo_slug_example;  // string | 
            var renames = renames_example;  // string |  When `true`, Bitbucket will follow the history of the file across renames (this is the default behavior). This can be turned off by specifying `false`. (optional) 
            var q = q_example;  // string |  Query string to narrow down the response as per [filtering and sorting](../../../../../../meta/filtering). (optional) 
            var sort = sort_example;  // string |  Name of a response property sort the result by as per [filtering and sorting](../../../../../../meta/filtering#query-sort).  (optional) 

            try
            {
                PaginatedFiles result = apiInstance.RepositoriesUsernameRepoSlugFilehistoryNodePathGet(username, node, path, repo_slug, renames, q, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoriesApi.RepositoriesUsernameRepoSlugFilehistoryNodePathGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**|  | 
 **node** | **string**|  | 
 **path** | **string**|  | 
 **repo_slug** | **string**|  | 
 **renames** | **string**|  When &#x60;true&#x60;, Bitbucket will follow the history of the file across renames (this is the default behavior). This can be turned off by specifying &#x60;false&#x60;. | [optional] 
 **q** | **string**|  Query string to narrow down the response as per [filtering and sorting](../../../../../../meta/filtering). | [optional] 
 **sort** | **string**|  Name of a response property sort the result by as per [filtering and sorting](../../../../../../meta/filtering#query-sort).  | [optional] 

### Return type

[**PaginatedFiles**](PaginatedFiles.md)

### Authorization

[api_key](../README.md#api_key), [basic](../README.md#basic), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="repositoriesusernamereposlugforksget"></a>
# **RepositoriesUsernameRepoSlugForksGet**
> PaginatedRepositories RepositoriesUsernameRepoSlugForksGet (string username, string repo_slug)



Returns a paginated list of all the forks of the specified repository.

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Bitbucket.Refit.Api;
using Itofinity.Bitbucket.Refit.Client;
using Itofinity.Bitbucket.Refit.Model;

namespace Example
{
    public class RepositoriesUsernameRepoSlugForksGetExample
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

            var apiInstance = new RepositoriesApi();
            var username = username_example;  // string | This can either be the username or the UUID of the account, surrounded by curly-braces, for example: `{account UUID}`. An account is either a team or user. 
            var repo_slug = repo_slug_example;  // string | This can either be the repository slug or the UUID of the repository, surrounded by curly-braces, for example: `{repository UUID}`. 

            try
            {
                PaginatedRepositories result = apiInstance.RepositoriesUsernameRepoSlugForksGet(username, repo_slug);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoriesApi.RepositoriesUsernameRepoSlugForksGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**| This can either be the username or the UUID of the account, surrounded by curly-braces, for example: &#x60;{account UUID}&#x60;. An account is either a team or user.  | 
 **repo_slug** | **string**| This can either be the repository slug or the UUID of the repository, surrounded by curly-braces, for example: &#x60;{repository UUID}&#x60;.  | 

### Return type

[**PaginatedRepositories**](PaginatedRepositories.md)

### Authorization

[api_key](../README.md#api_key), [basic](../README.md#basic), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="repositoriesusernamereposlugforkspost"></a>
# **RepositoriesUsernameRepoSlugForksPost**
> Repository RepositoriesUsernameRepoSlugForksPost (string username, string repo_slug, Repository _body = null)



Creates a new fork of the specified repository.  By default, forks are created under the authenticated user's account with the same name and slug of the original repository.  ``` $ curl -X POST -u jdoe https://api.bitbucket.org/2.0/repositories/evzijst/dogslow/forks  {   \"scm\": \"git\",   \"full_name\": \"jdoe/dogslow\",   \"parent\": {     \"full_name\": \"evzijst/dogslow\",     ...   },   ... } ```  If you already have a repo with that name, then a 400 is returned and you'll need to specify a custom name for the new fork:  ``` $ curl -X POST -u jdoe https://api.bitbucket.org/2.0/repositories/evzijst/dogslow/forks \\   -H 'Content-Type: application/json' -d '{     \"name\": \"dogslow_fork\" }' ```  When you specify a value for `name`, it will also affect the `slug`. The `slug` is reflected in the repository URL of the new fork. It is derived from `name` by substituting non-ASCII characters, removes whitespace, and changes characters to lower case. For example, `My repo` would turn into `my_repo`.  ## Forking a repository into a team account  To create a fork into a team account, specify the new owner's account explicitly as part of the request body. This prevents forked repositories from being owned by the authenticated user submitting the request:  ``` $ curl -X POST -u jdoe https://api.bitbucket.org/2.0/repositories/atlassian/bbql/forks \\   -H 'Content-Type: application/json' -d '{     \"name\": \"bbql_fork\",     \"owner\": {       \"username\": \"atlassian\"     } }' ```  To fork a repository into the same team, also specify a new `name`.  You need contributor access to create new forks within a team account.   ## Change the properties of a new fork  By default the fork inherits most of its properties from the parent. However, since the optional POST body document follows the normal `repository` JSON schema and you can override the new fork's properties.  Properties that can be overridden include:  * description * fork_policy * language * mainbranch * is_private (note that a private repo's fork_policy might prohibit   the creation of public forks, in which `is_private=False` would fail) * has_issues (to initialize or disable the new repo's issue tracker - -   note that the actual contents of the parent repository's issue   tracker are not copied during forking) * has_wiki (to initialize or disable the new repo's wiki - -   note that the actual contents of the parent repository's wiki are not   copied during forking) * project (only teams have projects and when forking into a private   project, the fork's `is_private` must be `true`)  Properties that cannot be modified include:  * scm * parent * full_name

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Bitbucket.Refit.Api;
using Itofinity.Bitbucket.Refit.Client;
using Itofinity.Bitbucket.Refit.Model;

namespace Example
{
    public class RepositoriesUsernameRepoSlugForksPostExample
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

            var apiInstance = new RepositoriesApi();
            var username = username_example;  // string | This can either be the username or the UUID of the account, surrounded by curly-braces, for example: `{account UUID}`. An account is either a team or user. 
            var repo_slug = repo_slug_example;  // string | This can either be the repository slug or the UUID of the repository, surrounded by curly-braces, for example: `{repository UUID}`. 
            var _body = new Repository(); // Repository | A repository object. This can be left blank. (optional) 

            try
            {
                Repository result = apiInstance.RepositoriesUsernameRepoSlugForksPost(username, repo_slug, _body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoriesApi.RepositoriesUsernameRepoSlugForksPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**| This can either be the username or the UUID of the account, surrounded by curly-braces, for example: &#x60;{account UUID}&#x60;. An account is either a team or user.  | 
 **repo_slug** | **string**| This can either be the repository slug or the UUID of the repository, surrounded by curly-braces, for example: &#x60;{repository UUID}&#x60;.  | 
 **_body** | [**Repository**](Repository.md)| A repository object. This can be left blank. | [optional] 

### Return type

[**Repository**](Repository.md)

### Authorization

[api_key](../README.md#api_key), [basic](../README.md#basic), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="repositoriesusernamereposlugget"></a>
# **RepositoriesUsernameRepoSlugGet**
> Repository RepositoriesUsernameRepoSlugGet (string username, string repo_slug)



Returns the object describing this repository.

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Bitbucket.Refit.Api;
using Itofinity.Bitbucket.Refit.Client;
using Itofinity.Bitbucket.Refit.Model;

namespace Example
{
    public class RepositoriesUsernameRepoSlugGetExample
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

            var apiInstance = new RepositoriesApi();
            var username = username_example;  // string | This can either be the username or the UUID of the account, surrounded by curly-braces, for example: `{account UUID}`. An account is either a team or user. 
            var repo_slug = repo_slug_example;  // string | This can either be the repository slug or the UUID of the repository, surrounded by curly-braces, for example: `{repository UUID}`. 

            try
            {
                Repository result = apiInstance.RepositoriesUsernameRepoSlugGet(username, repo_slug);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoriesApi.RepositoriesUsernameRepoSlugGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**| This can either be the username or the UUID of the account, surrounded by curly-braces, for example: &#x60;{account UUID}&#x60;. An account is either a team or user.  | 
 **repo_slug** | **string**| This can either be the repository slug or the UUID of the repository, surrounded by curly-braces, for example: &#x60;{repository UUID}&#x60;.  | 

### Return type

[**Repository**](Repository.md)

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
using Itofinity.Bitbucket.Refit.Api;
using Itofinity.Bitbucket.Refit.Client;
using Itofinity.Bitbucket.Refit.Model;

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

            var apiInstance = new RepositoriesApi();
            var username = username_example;  // string | 
            var repo_slug = repo_slug_example;  // string | 

            try
            {
                PaginatedWebhookSubscriptions result = apiInstance.RepositoriesUsernameRepoSlugHooksGet(username, repo_slug);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoriesApi.RepositoriesUsernameRepoSlugHooksGet: " + e.Message );
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
using Itofinity.Bitbucket.Refit.Api;
using Itofinity.Bitbucket.Refit.Client;
using Itofinity.Bitbucket.Refit.Model;

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

            var apiInstance = new RepositoriesApi();
            var username = username_example;  // string | 
            var repo_slug = repo_slug_example;  // string | 

            try
            {
                WebhookSubscription result = apiInstance.RepositoriesUsernameRepoSlugHooksPost(username, repo_slug);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoriesApi.RepositoriesUsernameRepoSlugHooksPost: " + e.Message );
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
using Itofinity.Bitbucket.Refit.Api;
using Itofinity.Bitbucket.Refit.Client;
using Itofinity.Bitbucket.Refit.Model;

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

            var apiInstance = new RepositoriesApi();
            var username = username_example;  // string | 
            var repo_slug = repo_slug_example;  // string | 
            var uid = uid_example;  // string | The installed webhook's id

            try
            {
                apiInstance.RepositoriesUsernameRepoSlugHooksUidDelete(username, repo_slug, uid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoriesApi.RepositoriesUsernameRepoSlugHooksUidDelete: " + e.Message );
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
using Itofinity.Bitbucket.Refit.Api;
using Itofinity.Bitbucket.Refit.Client;
using Itofinity.Bitbucket.Refit.Model;

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

            var apiInstance = new RepositoriesApi();
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
                Debug.Print("Exception when calling RepositoriesApi.RepositoriesUsernameRepoSlugHooksUidGet: " + e.Message );
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
using Itofinity.Bitbucket.Refit.Api;
using Itofinity.Bitbucket.Refit.Client;
using Itofinity.Bitbucket.Refit.Model;

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

            var apiInstance = new RepositoriesApi();
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
                Debug.Print("Exception when calling RepositoriesApi.RepositoriesUsernameRepoSlugHooksUidPut: " + e.Message );
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

<a name="repositoriesusernamereposlugpost"></a>
# **RepositoriesUsernameRepoSlugPost**
> Repository RepositoriesUsernameRepoSlugPost (string username, string repo_slug, Repository _body = null)



Creates a new repository.  Note: In order to set the project for the newly created repository, pass in either the project key or the project UUID as part of the request body as shown in the examples below:  ``` $ curl -X POST -H \"Content-Type: application/json\" -d '{     \"scm\": \"git\",     \"project\": {         \"key\": \"MARS\"     } }' https://api.bitbucket.org/2.0/repositories/teamsinspace/hablanding ```  or  ``` $ curl -X POST -H \"Content-Type: application/json\" -d '{     \"scm\": \"git\",     \"project\": {         \"key\": \"{ba516952-992a-4c2d-acbd-17d502922f96}\"     } }' https://api.bitbucket.org/2.0/repositories/teamsinspace/hablanding ```  The project must only be assigned for repositories belonging to a team. If the repository owner is a team and the project is not provided, the repository is automatically assigned to the oldest project in the team.  Note: In the examples above, the username `teamsinspace`, and/or the repository name `hablanding` can be replaced by UUIDs.

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Bitbucket.Refit.Api;
using Itofinity.Bitbucket.Refit.Client;
using Itofinity.Bitbucket.Refit.Model;

namespace Example
{
    public class RepositoriesUsernameRepoSlugPostExample
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

            var apiInstance = new RepositoriesApi();
            var username = username_example;  // string | This can either be the username or the UUID of the account, surrounded by curly-braces, for example: `{account UUID}`. An account is either a team or user. 
            var repo_slug = repo_slug_example;  // string | This can either be the repository slug or the UUID of the repository, surrounded by curly-braces, for example: `{repository UUID}`. 
            var _body = new Repository(); // Repository | The repository that is to be created. Note that most object elements are optional. Elements \"owner\" and \"full_name\" are ignored as the URL implies them. (optional) 

            try
            {
                Repository result = apiInstance.RepositoriesUsernameRepoSlugPost(username, repo_slug, _body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoriesApi.RepositoriesUsernameRepoSlugPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**| This can either be the username or the UUID of the account, surrounded by curly-braces, for example: &#x60;{account UUID}&#x60;. An account is either a team or user.  | 
 **repo_slug** | **string**| This can either be the repository slug or the UUID of the repository, surrounded by curly-braces, for example: &#x60;{repository UUID}&#x60;.  | 
 **_body** | [**Repository**](Repository.md)| The repository that is to be created. Note that most object elements are optional. Elements \&quot;owner\&quot; and \&quot;full_name\&quot; are ignored as the URL implies them. | [optional] 

### Return type

[**Repository**](Repository.md)

### Authorization

[api_key](../README.md#api_key), [basic](../README.md#basic), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="repositoriesusernamereposlugpullrequestspullrequestidstatusesget"></a>
# **RepositoriesUsernameRepoSlugPullrequestsPullRequestIdStatusesGet**
> PaginatedCommitstatuses RepositoriesUsernameRepoSlugPullrequestsPullRequestIdStatusesGet (string username, int? pull_request_id, string repo_slug)



Returns all statuses (e.g. build results) for the given pull request.

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Bitbucket.Refit.Api;
using Itofinity.Bitbucket.Refit.Client;
using Itofinity.Bitbucket.Refit.Model;

namespace Example
{
    public class RepositoriesUsernameRepoSlugPullrequestsPullRequestIdStatusesGetExample
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

            var apiInstance = new RepositoriesApi();
            var username = username_example;  // string | This can either be the username or the UUID of the account, surrounded by curly-braces, for example: `{account UUID}`. An account is either a team or user. 
            var pull_request_id = 56;  // int? | The id of the pull request.
            var repo_slug = repo_slug_example;  // string | This can either be the repository slug or the UUID of the repository, surrounded by curly-braces, for example: `{repository UUID}`. 

            try
            {
                PaginatedCommitstatuses result = apiInstance.RepositoriesUsernameRepoSlugPullrequestsPullRequestIdStatusesGet(username, pull_request_id, repo_slug);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoriesApi.RepositoriesUsernameRepoSlugPullrequestsPullRequestIdStatusesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**| This can either be the username or the UUID of the account, surrounded by curly-braces, for example: &#x60;{account UUID}&#x60;. An account is either a team or user.  | 
 **pull_request_id** | **int?**| The id of the pull request. | 
 **repo_slug** | **string**| This can either be the repository slug or the UUID of the repository, surrounded by curly-braces, for example: &#x60;{repository UUID}&#x60;.  | 

### Return type

[**PaginatedCommitstatuses**](PaginatedCommitstatuses.md)

### Authorization

[api_key](../README.md#api_key), [basic](../README.md#basic), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="repositoriesusernamereposlugput"></a>
# **RepositoriesUsernameRepoSlugPut**
> Repository RepositoriesUsernameRepoSlugPut (string username, string repo_slug, Repository _body = null)



Since this endpoint can be used to both update and to create a repository, the request body depends on the intent.  ### Creation  See the POST documentation for the repository endpoint for an example of the request body.  ### Update  Note: Changing the `name` of the repository will cause the location to be changed. This is because the URL of the repo is derived from the name (a process called slugification). In such a scenario, it is possible for the request to fail if the newly created slug conflicts with an existing repository's slug. But if there is no conflict, the new location will be returned in the `Location` header of the response.

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Bitbucket.Refit.Api;
using Itofinity.Bitbucket.Refit.Client;
using Itofinity.Bitbucket.Refit.Model;

namespace Example
{
    public class RepositoriesUsernameRepoSlugPutExample
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

            var apiInstance = new RepositoriesApi();
            var username = username_example;  // string | This can either be the username or the UUID of the account, surrounded by curly-braces, for example: `{account UUID}`. An account is either a team or user. 
            var repo_slug = repo_slug_example;  // string | This can either be the repository slug or the UUID of the repository, surrounded by curly-braces, for example: `{repository UUID}`. 
            var _body = new Repository(); // Repository | The repository that is to be updated.  Note that the elements \"owner\" and \"full_name\" are ignored since the URL implies them.  (optional) 

            try
            {
                Repository result = apiInstance.RepositoriesUsernameRepoSlugPut(username, repo_slug, _body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoriesApi.RepositoriesUsernameRepoSlugPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**| This can either be the username or the UUID of the account, surrounded by curly-braces, for example: &#x60;{account UUID}&#x60;. An account is either a team or user.  | 
 **repo_slug** | **string**| This can either be the repository slug or the UUID of the repository, surrounded by curly-braces, for example: &#x60;{repository UUID}&#x60;.  | 
 **_body** | [**Repository**](Repository.md)| The repository that is to be updated.  Note that the elements \&quot;owner\&quot; and \&quot;full_name\&quot; are ignored since the URL implies them.  | [optional] 

### Return type

[**Repository**](Repository.md)

### Authorization

[api_key](../README.md#api_key), [basic](../README.md#basic), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="repositoriesusernamereposlugsrcget"></a>
# **RepositoriesUsernameRepoSlugSrcGet**
> PaginatedTreeentries RepositoriesUsernameRepoSlugSrcGet (string username, string repo_slug, string format = null)



This endpoint redirects the client to the directory listing of the root directory on the main branch.  This is equivalent to directly hitting [/2.0/repositories/{username}/{repo_slug}/src/{node}/{path}](src/%7Bnode%7D/%7Bpath%7D) without having to know the name or SHA1 of the repo's main branch.  To create new commits, [POST to this endpoint](#post)

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Bitbucket.Refit.Api;
using Itofinity.Bitbucket.Refit.Client;
using Itofinity.Bitbucket.Refit.Model;

namespace Example
{
    public class RepositoriesUsernameRepoSlugSrcGetExample
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

            var apiInstance = new RepositoriesApi();
            var username = username_example;  // string | 
            var repo_slug = repo_slug_example;  // string | 
            var format = format_example;  // string | Instead of returning the file's contents, return the (json) meta data for it. (optional) 

            try
            {
                PaginatedTreeentries result = apiInstance.RepositoriesUsernameRepoSlugSrcGet(username, repo_slug, format);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoriesApi.RepositoriesUsernameRepoSlugSrcGet: " + e.Message );
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
 **format** | **string**| Instead of returning the file&#39;s contents, return the (json) meta data for it. | [optional] 

### Return type

[**PaginatedTreeentries**](PaginatedTreeentries.md)

### Authorization

[api_key](../README.md#api_key), [basic](../README.md#basic), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="repositoriesusernamereposlugsrcnodepathget"></a>
# **RepositoriesUsernameRepoSlugSrcNodePathGet**
> PaginatedTreeentries RepositoriesUsernameRepoSlugSrcNodePathGet (string username, string node, string path, string repo_slug, string format = null, string q = null, string sort = null)



This endpoints is used to retrieve the contents of a single file, or the contents of a directory at a specified revision.  ## Raw file contents  When `path` points to a file, this endpoint returns the raw contents. The response's Content-Type is derived from the filename extension (not from the contents). The file contents are not processed and no character encoding/recoding is performed and as a result no character encoding is included as part of the Content-Type.  The `Content-Disposition` header will be \"attachment\" to prevent browsers from running executable files.  If the file is managed by LFS, then a 301 redirect pointing to Atlassian's media services platform is returned.  The response includes an ETag that is based on the contents of the file and its attributes. This means that an empty `__init__.py` always returns the same ETag, regardless on the directory it lives in, or the commit it is on.  ## File meta data  When the request for a file path includes the query parameter `?format=meta`, instead of returning the file's raw contents, Bitbucket instead returns the JSON object describing the file's properties:  ```javascript $ curl https://api.bitbucket.org/2.0/repositories/atlassian/bbql/src/eefd5ef/tests/__init__.py?format=meta {   \"links\": {     \"self\": {       \"href\": \"https://api.bitbucket.org/2.0/repositories/atlassian/bbql/src/eefd5ef5d3df01aed629f650959d6706d54cd335/tests/__init__.py\"     },     \"meta\": {       \"href\": \"https://api.bitbucket.org/2.0/repositories/atlassian/bbql/src/eefd5ef5d3df01aed629f650959d6706d54cd335/tests/__init__.py?format=meta\"     }   },   \"path\": \"tests/__init__.py\",   \"commit\": {     \"type\": \"commit\",     \"hash\": \"eefd5ef5d3df01aed629f650959d6706d54cd335\",     \"links\": {       \"self\": {         \"href\": \"https://api.bitbucket.org/2.0/repositories/atlassian/bbql/commit/eefd5ef5d3df01aed629f650959d6706d54cd335\"       },       \"html\": {         \"href\": \"https://bitbucket.org/atlassian/bbql/commits/eefd5ef5d3df01aed629f650959d6706d54cd335\"       }     }   },   \"attributes\": [],   \"type\": \"commit_file\",   \"size\": 0 } ```  File objects contain an `attributes` element that contains a list of possible modifiers. Currently defined values are:  * `link` - - indicates that the entry is a symbolic link. The contents     of the file represent the path the link points to. * `executable` - - indicates that the file has the executable bit set. * `subrepository` - - indicates that the entry points to a submodule or     subrepo. The contents of the file is the SHA1 of the repository     pointed to. * `binary` - - indicates whether Bitbucket thinks the file is binary.  This endpoint can provide an alternative to how a HEAD request can be used to check for the existence of a file, or a file's size without incurring the overhead of receiving its full contents.   ## Directory listings  When `path` points to a directory instead of a file, the response is a paginated list of directory and file objects in the same order as the underlying SCM system would return them.  For example:  ```javascript $ curl https://api.bitbucket.org/2.0/repositories/atlassian/bbql/src/eefd5ef/tests {   \"pagelen\": 10,   \"values\": [     {       \"path\": \"tests/test_project\",       \"type\": \"commit_directory\",       \"links\": {         \"self\": {           \"href\": \"https://api.bitbucket.org/2.0/repositories/atlassian/bbql/src/eefd5ef5d3df01aed629f650959d6706d54cd335/tests/test_project/\"         },         \"meta\": {           \"href\": \"https://api.bitbucket.org/2.0/repositories/atlassian/bbql/src/eefd5ef5d3df01aed629f650959d6706d54cd335/tests/test_project/?format=meta\"         }       },       \"commit\": {         \"type\": \"commit\",         \"hash\": \"eefd5ef5d3df01aed629f650959d6706d54cd335\",         \"links\": {           \"self\": {             \"href\": \"https://api.bitbucket.org/2.0/repositories/atlassian/bbql/commit/eefd5ef5d3df01aed629f650959d6706d54cd335\"           },           \"html\": {             \"href\": \"https://bitbucket.org/atlassian/bbql/commits/eefd5ef5d3df01aed629f650959d6706d54cd335\"           }         }       }     },     {       \"links\": {         \"self\": {           \"href\": \"https://api.bitbucket.org/2.0/repositories/atlassian/bbql/src/eefd5ef5d3df01aed629f650959d6706d54cd335/tests/__init__.py\"         },         \"meta\": {           \"href\": \"https://api.bitbucket.org/2.0/repositories/atlassian/bbql/src/eefd5ef5d3df01aed629f650959d6706d54cd335/tests/__init__.py?format=meta\"         }       },       \"path\": \"tests/__init__.py\",       \"commit\": {         \"type\": \"commit\",         \"hash\": \"eefd5ef5d3df01aed629f650959d6706d54cd335\",         \"links\": {           \"self\": {             \"href\": \"https://api.bitbucket.org/2.0/repositories/atlassian/bbql/commit/eefd5ef5d3df01aed629f650959d6706d54cd335\"           },           \"html\": {             \"href\": \"https://bitbucket.org/atlassian/bbql/commits/eefd5ef5d3df01aed629f650959d6706d54cd335\"           }         }       },       \"attributes\": [],       \"type\": \"commit_file\",       \"size\": 0     }   ],   \"page\": 1,   \"size\": 2 } ```  When listing the contents of the repo's root directory, the use of a trailing slash at the end of the URL is required.  The response is not recursive, meaning that only the direct contents of a path are returned. The response does not recurse down into subdirectories. In order to \"walk\" the entire directory tree, the client needs to parse each response and follow the `self` links of each `commit_directory` object.  Each returned object is either a `commit_file`, or a `commit_directory`, both of which contain a `path` element. This path is the absolute path from the root of the repository. Each object also contains a `commit` object which embeds the commit the file is on. Note that this is merely the commit that was used in the URL. It is *not* the commit that last modified the file.  Directory objects have 2 representations. Their `self` link returns the paginated contents of the directory. The `meta` link on the other hand returns the actual `directory` object itself, e.g.:  ```javascript {   \"path\": \"tests/test_project\",   \"type\": \"commit_directory\",   \"links\": {     \"self\": {       \"href\": \"https://api.bitbucket.org/2.0/repositories/atlassian/bbql/src/eefd5ef5d3df01aed629f650959d6706d54cd335/tests/test_project/\"     },     \"meta\": {       \"href\": \"https://api.bitbucket.org/2.0/repositories/atlassian/bbql/src/eefd5ef5d3df01aed629f650959d6706d54cd335/tests/test_project/?format=meta\"     }   },   \"commit\": { ... } } ```  ## Querying, filtering and sorting  Like most API endpoints, this API supports the Bitbucket querying/filtering syntax and so you could filter a directory listing to only include entries that match certain criteria. For instance, to list all binary files over 1kb use the expression:  `size > 1024 and attributes = \"binary\"`  which after urlencoding yields the query string:  `?q=size%3E1024+and+attributes%3D%22binary%22`  To change the ordering of the response, use the `?sort` parameter:  `.../src/eefd5ef/?sort=-size`  See [filtering and sorting](../../../../../../meta/filtering) for more details.

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Bitbucket.Refit.Api;
using Itofinity.Bitbucket.Refit.Client;
using Itofinity.Bitbucket.Refit.Model;

namespace Example
{
    public class RepositoriesUsernameRepoSlugSrcNodePathGetExample
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

            var apiInstance = new RepositoriesApi();
            var username = username_example;  // string | 
            var node = node_example;  // string | 
            var path = path_example;  // string | 
            var repo_slug = repo_slug_example;  // string | 
            var format = format_example;  // string | If 'meta' is provided, returns the (json) meta data for the contents of the file.  If 'rendered' is provided, returns the contents of a non-binary file in HTML-formatted rendered markup. Since Git and Mercurial do not generally track what text encoding scheme is used, this endpoint attempts to detect the most appropriate character encoding. While usually correct, determining the character encoding can be ambiguous which in exceptional cases can lead to misinterpretation of the characters. As such, the raw element in the response object should not be treated as equivalent to the file's actual contents. (optional) 
            var q = q_example;  // string | Optional filter expression as per [filtering and sorting](../../../../../../meta/filtering). (optional) 
            var sort = sort_example;  // string | Optional sorting parameter as per [filtering and sorting](../../../../../../meta/filtering#query-sort). (optional) 

            try
            {
                PaginatedTreeentries result = apiInstance.RepositoriesUsernameRepoSlugSrcNodePathGet(username, node, path, repo_slug, format, q, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoriesApi.RepositoriesUsernameRepoSlugSrcNodePathGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**|  | 
 **node** | **string**|  | 
 **path** | **string**|  | 
 **repo_slug** | **string**|  | 
 **format** | **string**| If &#39;meta&#39; is provided, returns the (json) meta data for the contents of the file.  If &#39;rendered&#39; is provided, returns the contents of a non-binary file in HTML-formatted rendered markup. Since Git and Mercurial do not generally track what text encoding scheme is used, this endpoint attempts to detect the most appropriate character encoding. While usually correct, determining the character encoding can be ambiguous which in exceptional cases can lead to misinterpretation of the characters. As such, the raw element in the response object should not be treated as equivalent to the file&#39;s actual contents. | [optional] 
 **q** | **string**| Optional filter expression as per [filtering and sorting](../../../../../../meta/filtering). | [optional] 
 **sort** | **string**| Optional sorting parameter as per [filtering and sorting](../../../../../../meta/filtering#query-sort). | [optional] 

### Return type

[**PaginatedTreeentries**](PaginatedTreeentries.md)

### Authorization

[api_key](../README.md#api_key), [basic](../README.md#basic), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="repositoriesusernamereposlugsrcpost"></a>
# **RepositoriesUsernameRepoSlugSrcPost**
> void RepositoriesUsernameRepoSlugSrcPost (string username, string repo_slug, string message = null, string author = null, string parents = null, string files = null, string files2 = null, string branch = null)



This endpoint is used to create new commits in the repository by uploading files.  To add a new file to a repository:  ``` $ curl https://api.bitbucket.org/2.0/repositories/username/slug/src \\   -F /repo/path/to/image.png=@image.png ```  This will create a new commit on top of the main branch, inheriting the contents of the main branch, but adding (or overwriting) the `image.png` file to the repository in the `/repo/path/to` directory.  To create a commit that deletes files, use the `files` parameter:  ``` $ curl https://api.bitbucket.org/2.0/repositories/username/slug/src \\   -F files=/file/to/delete/1.txt \\   -F files=/file/to/delete/2.txt ```  You can add/modify/delete multiple files in a request. Rename/move a file by deleting the old path and adding the content at the new path.  This endpoint accepts `multipart/form-data` (as in the examples above), as well as `application/x-www-form-urlencoded`.  ## multipart/form-data  A `multipart/form-data` post contains a series of \"form fields\" that identify both the individual files that are being uploaded, as well as additional, optional meta data.  Files are uploaded in file form fields (those that have a `Content-Disposition` parameter) whose field names point to the remote path in the repository where the file should be stored. Path field names are always interpreted to be absolute from the root of the repository, regardless whether the client uses a leading slash (as the above `curl` example did).  File contents are treated as bytes and are not decoded as text.  The commit message, as well as other non-file meta data for the request, is sent along as normal form field elements. Meta data fields share the same namespace as the file objects. For `multipart/form-data` bodies that should not lead to any ambiguity, as the `Content-Disposition` header will contain the `filename` parameter to distinguish between a file named \"message\" and the commit message field.  ## application/x-www-form-urlencoded  It is also possible to upload new files using a simple `application/x-www-form-urlencoded` POST. This can be convenient when uploading pure text files:  ``` $ curl https://api.bitbucket.org/2.0/repositories/atlassian/bbql/src \\   - -data-urlencode \"/path/to/me.txt=Lorem ipsum.\" \\   - -data-urlencode \"message=Initial commit\" \\   - -data-urlencode \"author=Erik van Zijst <erik.van.zijst@gmail.com>\" ```  There could be a field name clash if a client were to upload a file named \"message\", as this filename clashes with the meta data property for the commit message. To avoid this and to upload files whose names clash with the meta data properties, use a leading slash for the files, e.g. `curl - -data-urlencode \"/message=file contents\"`.  When an explicit slash is omitted for a file whose path matches that of a meta data parameter, then it is interpreted as meta data, not as a file.  ## Executables and links  While this API aims to facilitate the most common use cases, it is possible to perform some more advanced operations like creating a new symlink in the repository, or creating an executable file.  Files can be supplied with a `x-attributes` value in the `Content-Disposition` header. For example, to upload an executable file, as well as create a symlink from `README.txt` to `README`:  ``` - -===============1438169132528273974== Content-Type: text/plain; charset=\"us-ascii\" MIME-Version: 1.0 Content-Transfer-Encoding: 7bit Content-ID: \"bin/shutdown.sh\" Content-Disposition: attachment; filename=\"shutdown.sh\"; x-attributes:\"executable\"  #!/bin/sh halt  - -===============1438169132528273974== Content-Type: text/plain; charset=\"us-ascii\" MIME-Version: 1.0 Content-Transfer-Encoding: 7bit Content-ID: \"/README.txt\" Content-Disposition: attachment; filename=\"README.txt\"; x-attributes:\"link\"  README - -===============1438169132528273974==- - ```  Links are files that contain the target path and have `x-attributes:\"link\"` set.  When overwriting links with files, or vice versa, the newly uploaded file determines both the new contents, as well as the attributes. That means uploading a file without specifying `x-attributes=\"link\"` will create a regular file, even if the parent commit hosted a symlink at the same path.  The same applies to executables. When modifying an existing executable file, the form-data file element must include `x-attributes=\"executable\"` in order to preserve the executable status of the file.  Note that this API does not support the creation or manipulation of subrepos / submodules.

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Bitbucket.Refit.Api;
using Itofinity.Bitbucket.Refit.Client;
using Itofinity.Bitbucket.Refit.Model;

namespace Example
{
    public class RepositoriesUsernameRepoSlugSrcPostExample
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

            var apiInstance = new RepositoriesApi();
            var username = username_example;  // string | 
            var repo_slug = repo_slug_example;  // string | 
            var message = message_example;  // string | The commit message. When omitted, Bitbucket uses a canned string. (optional) 
            var author = author_example;  // string |  The raw string to be used as the new commit's author. This string follows the format `Erik van Zijst <evzijst@atlassian.com>`.  When omitted, Bitbucket uses the authenticated user's full/display name and primary email address. Commits cannot be created anonymously. (optional) 
            var parents = parents_example;  // string |  A comma-separated list of SHA1s of the commits that should be the parents of the newly created commit.  When omitted, the new commit will inherit from and become a child of the main branch's tip/HEAD commit.  When more than one SHA1 is provided, the first SHA1 identifies the commit from which the content will be inherited.  When more than 2 parents are provided on a Mercurial repo, a 400 is returned as Mercurial does not support \"octopus merges\". (optional) 
            var files = files_example;  // string |  Optional field that declares the files that the request is manipulating. When adding a new file to a repo, or when overwriting an existing file, the client can just upload the full contents of the file in a normal form field and the use of this `files` meta data field is redundant. However, when the `files` field contains a file path that does not have a corresponding, identically-named form field, then Bitbucket interprets that as the client wanting to replace the named file with the null set and the file is deleted instead.  Paths in the repo that are referenced in neither files nor an individual file field, remain unchanged and carry over from the parent to the new commit.  This API does not support renaming as an explicit feature. To rename a file, simply delete it and recreate it under the new name in the same commit.  (optional) 
            var files2 = files_example;  // string |  The name of the branch that the new commit should be created on. When omitted, the commit will be created on top of the main branch and will become the main branch's new HEAD/tip.  When a branch name is provided that already exists in the repo, then the commit will be created on top of that branch. In this case, if a parent SHA1 was also provided, then it is asserted that the parent is the branch's tip/HEAD at the time the request is made. When this is not the case, a 409 is returned.  This API cannot be used to create new anonymous heads in Mercurial repos.  When a new branch name is specified (that does not already exist in the repo), and no parent SHA1s are provided, then the new commit will inherit from the current main branch's tip/HEAD commit, but not advance the main branch. The new commit will be the new branch. When the request also specifies a parent SHA1, then the new commit and branch are created directly on top of the parent commit, regardless of the state of the main branch.  When a branch name is not specified, but a parent SHA1 is provided, then Bitbucket asserts that it represents the main branch's current HEAD/tip, or a 409 is returned.  When a branch name is not specified and the repo is empty, the new commit will become the repo's root commit and will be on the main branch.  When a branch name is specified and the repo is empty, the new commit will become the repo's root commit and also define the repo's main branch going forward.  This API cannot be used to create additional root commits in non-empty repos.  The branch field cannot be repeated.  As a side effect, this API can be used to create a new branch without modifying any files, by specifying a new branch name in this field, together with parents, but omitting the files fields, while not sending any files. This will create a new commit and branch with the same contents as the first parent. The diff of this commit against its first parent will be empty.  (optional) 
            var branch = branch_example;  // string |  The name of the branch that the new commit should be created on. When omitted, the commit will be created on top of the main branch and will become the main branch's new head.  When a branch name is provided that already exists in the repo, then the commit will be created on top of that branch. In this case, *if* a parent SHA1 was also provided, then it is asserted that the parent is the branch's tip/HEAD at the time the request is made. When this is not the case, a 409 is returned.  This API cannot be used to create new anonymous heads in Mercurial repositories.  When a new branch name is specified (that does not already exist in the repo), and no parent SHA1s are provided, then the new commit will inherit from the current main branch's tip/HEAD commit, but not advance the main branch. The new commit will be the new branch. When the request *also* specifies a parent SHA1, then the new commit and branch are created directly on top of the parent commit, regardless of the state of the main branch.  When a branch name is not specified, but a parent SHA1 is provided, then Bitbucket asserts that it represents the main branch's current HEAD/tip, or a 409 is returned.  When a branch name is not specified and the repo is empty, the new commit will become the repo's root commit and will be on the main branch.  When a branch name is specified and the repo is empty, the new commit will become the repo's root commit and also define the repo's main branch going forward.  This API cannot be used to create additional root commits in non-empty repos.  The branch field cannot be repeated.  As a side effect, this API can be used to create a new branch without modifying any files, by specifying a new branch name in this field, together with `parents`, but omitting the `files` fields, while not sending any files. This will create a new commit and branch with the same contents as the first parent. The diff of this commit against its first parent will be empty.  (optional) 

            try
            {
                apiInstance.RepositoriesUsernameRepoSlugSrcPost(username, repo_slug, message, author, parents, files, files2, branch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoriesApi.RepositoriesUsernameRepoSlugSrcPost: " + e.Message );
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
 **message** | **string**| The commit message. When omitted, Bitbucket uses a canned string. | [optional] 
 **author** | **string**|  The raw string to be used as the new commit&#39;s author. This string follows the format &#x60;Erik van Zijst &lt;evzijst@atlassian.com&gt;&#x60;.  When omitted, Bitbucket uses the authenticated user&#39;s full/display name and primary email address. Commits cannot be created anonymously. | [optional] 
 **parents** | **string**|  A comma-separated list of SHA1s of the commits that should be the parents of the newly created commit.  When omitted, the new commit will inherit from and become a child of the main branch&#39;s tip/HEAD commit.  When more than one SHA1 is provided, the first SHA1 identifies the commit from which the content will be inherited.  When more than 2 parents are provided on a Mercurial repo, a 400 is returned as Mercurial does not support \&quot;octopus merges\&quot;. | [optional] 
 **files** | **string**|  Optional field that declares the files that the request is manipulating. When adding a new file to a repo, or when overwriting an existing file, the client can just upload the full contents of the file in a normal form field and the use of this &#x60;files&#x60; meta data field is redundant. However, when the &#x60;files&#x60; field contains a file path that does not have a corresponding, identically-named form field, then Bitbucket interprets that as the client wanting to replace the named file with the null set and the file is deleted instead.  Paths in the repo that are referenced in neither files nor an individual file field, remain unchanged and carry over from the parent to the new commit.  This API does not support renaming as an explicit feature. To rename a file, simply delete it and recreate it under the new name in the same commit.  | [optional] 
 **files2** | **string**|  The name of the branch that the new commit should be created on. When omitted, the commit will be created on top of the main branch and will become the main branch&#39;s new HEAD/tip.  When a branch name is provided that already exists in the repo, then the commit will be created on top of that branch. In this case, if a parent SHA1 was also provided, then it is asserted that the parent is the branch&#39;s tip/HEAD at the time the request is made. When this is not the case, a 409 is returned.  This API cannot be used to create new anonymous heads in Mercurial repos.  When a new branch name is specified (that does not already exist in the repo), and no parent SHA1s are provided, then the new commit will inherit from the current main branch&#39;s tip/HEAD commit, but not advance the main branch. The new commit will be the new branch. When the request also specifies a parent SHA1, then the new commit and branch are created directly on top of the parent commit, regardless of the state of the main branch.  When a branch name is not specified, but a parent SHA1 is provided, then Bitbucket asserts that it represents the main branch&#39;s current HEAD/tip, or a 409 is returned.  When a branch name is not specified and the repo is empty, the new commit will become the repo&#39;s root commit and will be on the main branch.  When a branch name is specified and the repo is empty, the new commit will become the repo&#39;s root commit and also define the repo&#39;s main branch going forward.  This API cannot be used to create additional root commits in non-empty repos.  The branch field cannot be repeated.  As a side effect, this API can be used to create a new branch without modifying any files, by specifying a new branch name in this field, together with parents, but omitting the files fields, while not sending any files. This will create a new commit and branch with the same contents as the first parent. The diff of this commit against its first parent will be empty.  | [optional] 
 **branch** | **string**|  The name of the branch that the new commit should be created on. When omitted, the commit will be created on top of the main branch and will become the main branch&#39;s new head.  When a branch name is provided that already exists in the repo, then the commit will be created on top of that branch. In this case, *if* a parent SHA1 was also provided, then it is asserted that the parent is the branch&#39;s tip/HEAD at the time the request is made. When this is not the case, a 409 is returned.  This API cannot be used to create new anonymous heads in Mercurial repositories.  When a new branch name is specified (that does not already exist in the repo), and no parent SHA1s are provided, then the new commit will inherit from the current main branch&#39;s tip/HEAD commit, but not advance the main branch. The new commit will be the new branch. When the request *also* specifies a parent SHA1, then the new commit and branch are created directly on top of the parent commit, regardless of the state of the main branch.  When a branch name is not specified, but a parent SHA1 is provided, then Bitbucket asserts that it represents the main branch&#39;s current HEAD/tip, or a 409 is returned.  When a branch name is not specified and the repo is empty, the new commit will become the repo&#39;s root commit and will be on the main branch.  When a branch name is specified and the repo is empty, the new commit will become the repo&#39;s root commit and also define the repo&#39;s main branch going forward.  This API cannot be used to create additional root commits in non-empty repos.  The branch field cannot be repeated.  As a side effect, this API can be used to create a new branch without modifying any files, by specifying a new branch name in this field, together with &#x60;parents&#x60;, but omitting the &#x60;files&#x60; fields, while not sending any files. This will create a new commit and branch with the same contents as the first parent. The diff of this commit against its first parent will be empty.  | [optional] 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key), [basic](../README.md#basic), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="repositoriesusernamereposlugwatchersget"></a>
# **RepositoriesUsernameRepoSlugWatchersGet**
> void RepositoriesUsernameRepoSlugWatchersGet (string username, string repo_slug)



Returns a paginated list of all the watchers on the specified repository.

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Bitbucket.Refit.Api;
using Itofinity.Bitbucket.Refit.Client;
using Itofinity.Bitbucket.Refit.Model;

namespace Example
{
    public class RepositoriesUsernameRepoSlugWatchersGetExample
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

            var apiInstance = new RepositoriesApi();
            var username = username_example;  // string | This can either be the username or the UUID of the account, surrounded by curly-braces, for example: `{account UUID}`. An account is either a team or user. 
            var repo_slug = repo_slug_example;  // string | This can either be the repository slug or the UUID of the repository, surrounded by curly-braces, for example: `{repository UUID}`. 

            try
            {
                apiInstance.RepositoriesUsernameRepoSlugWatchersGet(username, repo_slug);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoriesApi.RepositoriesUsernameRepoSlugWatchersGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**| This can either be the username or the UUID of the account, surrounded by curly-braces, for example: &#x60;{account UUID}&#x60;. An account is either a team or user.  | 
 **repo_slug** | **string**| This can either be the repository slug or the UUID of the repository, surrounded by curly-braces, for example: &#x60;{repository UUID}&#x60;.  | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key), [basic](../README.md#basic), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userpermissionsrepositoriesget"></a>
# **UserPermissionsRepositoriesGet**
> PaginatedRepositoryPermissions UserPermissionsRepositoriesGet (string q = null, string sort = null)



Returns an object for each repository the caller has explicit access to and their effective permission — the highest level of permission the caller has. This does not return public repositories that the user was not granted any specific permission in, and does not distinguish between direct and indirect privileges.  Permissions can be:  * `admin` * `write` * `read`  Example:  ``` $ curl https://api.bitbucket.org/2.0/user/permissions/repositories  {   \"pagelen\": 10,   \"values\": [     {       \"type\": \"repository_permission\",       \"user\": {         \"type\": \"user\",         \"username\": \"evzijst\",         \"nickname\": \"evzijst\",         \"display_name\": \"Erik van Zijst\",         \"uuid\": \"{d301aafa-d676-4ee0-88be-962be7417567}\"       },       \"repository\": {         \"type\": \"repository\",         \"name\": \"geordi\",         \"full_name\": \"bitbucket/geordi\",         \"uuid\": \"{85d08b4e-571d-44e9-a507-fa476535aa98}\"       },       \"permission\": \"admin\"     }   ],   \"page\": 1,   \"size\": 1 } ```  Results may be further [filtered or sorted](../../../meta/filtering) by repository or permission by adding the following query string parameters:  * `q=repository.name=\"geordi\"` or `q=permission>\"read\"` * `sort=repository.name`  Note that the query parameter values need to be URL escaped so that `=` would become `%3D`.

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Bitbucket.Refit.Api;
using Itofinity.Bitbucket.Refit.Client;
using Itofinity.Bitbucket.Refit.Model;

namespace Example
{
    public class UserPermissionsRepositoriesGetExample
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

            var apiInstance = new RepositoriesApi();
            var q = q_example;  // string |  Query string to narrow down the response as per [filtering and sorting](../../../meta/filtering). (optional) 
            var sort = sort_example;  // string |  Name of a response property sort the result by as per [filtering and sorting](../../../meta/filtering#query-sort).  (optional) 

            try
            {
                PaginatedRepositoryPermissions result = apiInstance.UserPermissionsRepositoriesGet(q, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoriesApi.UserPermissionsRepositoriesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **q** | **string**|  Query string to narrow down the response as per [filtering and sorting](../../../meta/filtering). | [optional] 
 **sort** | **string**|  Name of a response property sort the result by as per [filtering and sorting](../../../meta/filtering#query-sort).  | [optional] 

### Return type

[**PaginatedRepositoryPermissions**](PaginatedRepositoryPermissions.md)

### Authorization

[api_key](../README.md#api_key), [basic](../README.md#basic), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

