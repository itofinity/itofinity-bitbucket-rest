# Itofinity.Bitbucket.Refit.Api.CommitstatusesApi

All URIs are relative to *https://api.localhost:8000/2.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**RepositoriesUsernameRepoSlugCommitNodeStatusesBuildKeyGet**](CommitstatusesApi.md#repositoriesusernamereposlugcommitnodestatusesbuildkeyget) | **Get** /repositories/{username}/{repo_slug}/commit/{node}/statuses/build/{key} | 
[**RepositoriesUsernameRepoSlugCommitNodeStatusesBuildKeyPut**](CommitstatusesApi.md#repositoriesusernamereposlugcommitnodestatusesbuildkeyput) | **Put** /repositories/{username}/{repo_slug}/commit/{node}/statuses/build/{key} | 
[**RepositoriesUsernameRepoSlugCommitNodeStatusesBuildPost**](CommitstatusesApi.md#repositoriesusernamereposlugcommitnodestatusesbuildpost) | **Post** /repositories/{username}/{repo_slug}/commit/{node}/statuses/build | 
[**RepositoriesUsernameRepoSlugCommitNodeStatusesGet**](CommitstatusesApi.md#repositoriesusernamereposlugcommitnodestatusesget) | **Get** /repositories/{username}/{repo_slug}/commit/{node}/statuses | 
[**RepositoriesUsernameRepoSlugPullrequestsPullRequestIdStatusesGet**](CommitstatusesApi.md#repositoriesusernamereposlugpullrequestspullrequestidstatusesget) | **Get** /repositories/{username}/{repo_slug}/pullrequests/{pull_request_id}/statuses | 


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

            var apiInstance = new CommitstatusesApi();
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
                Debug.Print("Exception when calling CommitstatusesApi.RepositoriesUsernameRepoSlugCommitNodeStatusesBuildKeyGet: " + e.Message );
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

            var apiInstance = new CommitstatusesApi();
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
                Debug.Print("Exception when calling CommitstatusesApi.RepositoriesUsernameRepoSlugCommitNodeStatusesBuildKeyPut: " + e.Message );
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

            var apiInstance = new CommitstatusesApi();
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
                Debug.Print("Exception when calling CommitstatusesApi.RepositoriesUsernameRepoSlugCommitNodeStatusesBuildPost: " + e.Message );
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

            var apiInstance = new CommitstatusesApi();
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
                Debug.Print("Exception when calling CommitstatusesApi.RepositoriesUsernameRepoSlugCommitNodeStatusesGet: " + e.Message );
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

            var apiInstance = new CommitstatusesApi();
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
                Debug.Print("Exception when calling CommitstatusesApi.RepositoriesUsernameRepoSlugPullrequestsPullRequestIdStatusesGet: " + e.Message );
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

