# Itofinity.Bitbucket.Rest.Api.BranchrestrictionsApi

All URIs are relative to *https://api.localhost:8000/2.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**RepositoriesUsernameRepoSlugBranchRestrictionsGet**](BranchrestrictionsApi.md#repositoriesusernamereposlugbranchrestrictionsget) | **Get** /repositories/{username}/{repo_slug}/branch-restrictions | 
[**RepositoriesUsernameRepoSlugBranchRestrictionsIdDelete**](BranchrestrictionsApi.md#repositoriesusernamereposlugbranchrestrictionsiddelete) | **Delete** /repositories/{username}/{repo_slug}/branch-restrictions/{id} | 
[**RepositoriesUsernameRepoSlugBranchRestrictionsIdGet**](BranchrestrictionsApi.md#repositoriesusernamereposlugbranchrestrictionsidget) | **Get** /repositories/{username}/{repo_slug}/branch-restrictions/{id} | 
[**RepositoriesUsernameRepoSlugBranchRestrictionsIdPut**](BranchrestrictionsApi.md#repositoriesusernamereposlugbranchrestrictionsidput) | **Put** /repositories/{username}/{repo_slug}/branch-restrictions/{id} | 
[**RepositoriesUsernameRepoSlugBranchRestrictionsPost**](BranchrestrictionsApi.md#repositoriesusernamereposlugbranchrestrictionspost) | **Post** /repositories/{username}/{repo_slug}/branch-restrictions | 


<a name="repositoriesusernamereposlugbranchrestrictionsget"></a>
# **RepositoriesUsernameRepoSlugBranchRestrictionsGet**
> PaginatedBranchrestrictions RepositoriesUsernameRepoSlugBranchRestrictionsGet (string username, string repo_slug)



Returns a paginated list of all branch restrictions on the repository.

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Bitbucket.Rest.Api;
using Itofinity.Bitbucket.Rest.Client;
using Itofinity.Bitbucket.Rest.Model;

namespace Example
{
    public class RepositoriesUsernameRepoSlugBranchRestrictionsGetExample
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

            var apiInstance = new BranchrestrictionsApi();
            var username = username_example;  // string | This can either be the username or the UUID of the account, surrounded by curly-braces, for example: `{account UUID}`. An account is either a team or user. 
            var repo_slug = repo_slug_example;  // string | This can either be the repository slug or the UUID of the repository, surrounded by curly-braces, for example: `{repository UUID}`. 

            try
            {
                PaginatedBranchrestrictions result = apiInstance.RepositoriesUsernameRepoSlugBranchRestrictionsGet(username, repo_slug);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BranchrestrictionsApi.RepositoriesUsernameRepoSlugBranchRestrictionsGet: " + e.Message );
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

[**PaginatedBranchrestrictions**](PaginatedBranchrestrictions.md)

### Authorization

[api_key](../README.md#api_key), [basic](../README.md#basic), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="repositoriesusernamereposlugbranchrestrictionsiddelete"></a>
# **RepositoriesUsernameRepoSlugBranchRestrictionsIdDelete**
> void RepositoriesUsernameRepoSlugBranchRestrictionsIdDelete (string username, string repo_slug, string id)



Deletes an existing branch restriction rule.

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Bitbucket.Rest.Api;
using Itofinity.Bitbucket.Rest.Client;
using Itofinity.Bitbucket.Rest.Model;

namespace Example
{
    public class RepositoriesUsernameRepoSlugBranchRestrictionsIdDeleteExample
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

            var apiInstance = new BranchrestrictionsApi();
            var username = username_example;  // string | This can either be the username or the UUID of the account, surrounded by curly-braces, for example: `{account UUID}`. An account is either a team or user. 
            var repo_slug = repo_slug_example;  // string | This can either be the repository slug or the UUID of the repository, surrounded by curly-braces, for example: `{repository UUID}`. 
            var id = id_example;  // string | The restriction rule's id

            try
            {
                apiInstance.RepositoriesUsernameRepoSlugBranchRestrictionsIdDelete(username, repo_slug, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BranchrestrictionsApi.RepositoriesUsernameRepoSlugBranchRestrictionsIdDelete: " + e.Message );
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
 **id** | **string**| The restriction rule&#39;s id | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key), [basic](../README.md#basic), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="repositoriesusernamereposlugbranchrestrictionsidget"></a>
# **RepositoriesUsernameRepoSlugBranchRestrictionsIdGet**
> Branchrestriction RepositoriesUsernameRepoSlugBranchRestrictionsIdGet (string username, string repo_slug, string id)



Returns a specific branch restriction rule.

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Bitbucket.Rest.Api;
using Itofinity.Bitbucket.Rest.Client;
using Itofinity.Bitbucket.Rest.Model;

namespace Example
{
    public class RepositoriesUsernameRepoSlugBranchRestrictionsIdGetExample
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

            var apiInstance = new BranchrestrictionsApi();
            var username = username_example;  // string | This can either be the username or the UUID of the account, surrounded by curly-braces, for example: `{account UUID}`. An account is either a team or user. 
            var repo_slug = repo_slug_example;  // string | This can either be the repository slug or the UUID of the repository, surrounded by curly-braces, for example: `{repository UUID}`. 
            var id = id_example;  // string | The restriction rule's id

            try
            {
                Branchrestriction result = apiInstance.RepositoriesUsernameRepoSlugBranchRestrictionsIdGet(username, repo_slug, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BranchrestrictionsApi.RepositoriesUsernameRepoSlugBranchRestrictionsIdGet: " + e.Message );
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
 **id** | **string**| The restriction rule&#39;s id | 

### Return type

[**Branchrestriction**](Branchrestriction.md)

### Authorization

[api_key](../README.md#api_key), [basic](../README.md#basic), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="repositoriesusernamereposlugbranchrestrictionsidput"></a>
# **RepositoriesUsernameRepoSlugBranchRestrictionsIdPut**
> Branchrestriction RepositoriesUsernameRepoSlugBranchRestrictionsIdPut (string username, string repo_slug, string id, Branchrestriction _body)



Updates an existing branch restriction rule.  Fields not present in the request body are ignored.  See [`POST`](../../branch-restrictions#post) for details.

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Bitbucket.Rest.Api;
using Itofinity.Bitbucket.Rest.Client;
using Itofinity.Bitbucket.Rest.Model;

namespace Example
{
    public class RepositoriesUsernameRepoSlugBranchRestrictionsIdPutExample
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

            var apiInstance = new BranchrestrictionsApi();
            var username = username_example;  // string | This can either be the username or the UUID of the account, surrounded by curly-braces, for example: `{account UUID}`. An account is either a team or user. 
            var repo_slug = repo_slug_example;  // string | This can either be the repository slug or the UUID of the repository, surrounded by curly-braces, for example: `{repository UUID}`. 
            var id = id_example;  // string | The restriction rule's id
            var _body = new Branchrestriction(); // Branchrestriction | The new version of the existing rule

            try
            {
                Branchrestriction result = apiInstance.RepositoriesUsernameRepoSlugBranchRestrictionsIdPut(username, repo_slug, id, _body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BranchrestrictionsApi.RepositoriesUsernameRepoSlugBranchRestrictionsIdPut: " + e.Message );
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
 **id** | **string**| The restriction rule&#39;s id | 
 **_body** | [**Branchrestriction**](Branchrestriction.md)| The new version of the existing rule | 

### Return type

[**Branchrestriction**](Branchrestriction.md)

### Authorization

[api_key](../README.md#api_key), [basic](../README.md#basic), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="repositoriesusernamereposlugbranchrestrictionspost"></a>
# **RepositoriesUsernameRepoSlugBranchRestrictionsPost**
> Branchrestriction RepositoriesUsernameRepoSlugBranchRestrictionsPost (string username, string repo_slug, Branchrestriction _body)



Creates a new branch restriction rule for a repository.  `kind` describes what will be restricted. Allowed values are: `push`, `force`, `delete`, and `restrict_merges`.  Different kinds of branch restrictions have different requirements:  * `push` and `restrict_merges` require `users` and `groups` to be   specified. Empty lists are allowed, in which case permission is   denied for everybody. * `force` can not be specified in a Mercurial repository.  `pattern` is used to determine which branches will be restricted.  A `'*'` in `pattern` will expand to match zero or more characters, and every other character matches itself. For example, `'foo*'` will match `'foo'` and `'foobar'`, but not `'barfoo'`. `'*'` will match all branches.  `users` and `groups` are lists of user names and group names.  `kind` and `pattern` must be unique within a repository; adding new users or groups to an existing restriction should be done via `PUT`.  Note that branch restrictions with overlapping patterns are allowed, but the resulting behavior may be surprising.

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Bitbucket.Rest.Api;
using Itofinity.Bitbucket.Rest.Client;
using Itofinity.Bitbucket.Rest.Model;

namespace Example
{
    public class RepositoriesUsernameRepoSlugBranchRestrictionsPostExample
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

            var apiInstance = new BranchrestrictionsApi();
            var username = username_example;  // string | This can either be the username or the UUID of the account, surrounded by curly-braces, for example: `{account UUID}`. An account is either a team or user. 
            var repo_slug = repo_slug_example;  // string | This can either be the repository slug or the UUID of the repository, surrounded by curly-braces, for example: `{repository UUID}`. 
            var _body = new Branchrestriction(); // Branchrestriction | The new rule

            try
            {
                Branchrestriction result = apiInstance.RepositoriesUsernameRepoSlugBranchRestrictionsPost(username, repo_slug, _body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BranchrestrictionsApi.RepositoriesUsernameRepoSlugBranchRestrictionsPost: " + e.Message );
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
 **_body** | [**Branchrestriction**](Branchrestriction.md)| The new rule | 

### Return type

[**Branchrestriction**](Branchrestriction.md)

### Authorization

[api_key](../README.md#api_key), [basic](../README.md#basic), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

