# Itofinity.Bitbucket.Refit.Api.CommitsApi

All URIs are relative to *https://api.localhost:8000/2.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**RepositoriesUsernameRepoSlugCommitNodeApproveDelete**](CommitsApi.md#repositoriesusernamereposlugcommitnodeapprovedelete) | **Delete** /repositories/{username}/{repo_slug}/commit/{node}/approve | 
[**RepositoriesUsernameRepoSlugCommitNodeApprovePost**](CommitsApi.md#repositoriesusernamereposlugcommitnodeapprovepost) | **Post** /repositories/{username}/{repo_slug}/commit/{node}/approve | 
[**RepositoriesUsernameRepoSlugCommitNodeCommentsCommentIdGet**](CommitsApi.md#repositoriesusernamereposlugcommitnodecommentscommentidget) | **Get** /repositories/{username}/{repo_slug}/commit/{node}/comments/{comment_id} | 
[**RepositoriesUsernameRepoSlugCommitNodeCommentsGet**](CommitsApi.md#repositoriesusernamereposlugcommitnodecommentsget) | **Get** /repositories/{username}/{repo_slug}/commit/{node}/comments | 
[**RepositoriesUsernameRepoSlugCommitNodeCommentsPost**](CommitsApi.md#repositoriesusernamereposlugcommitnodecommentspost) | **Post** /repositories/{username}/{repo_slug}/commit/{node}/comments | 
[**RepositoriesUsernameRepoSlugCommitNodeGet**](CommitsApi.md#repositoriesusernamereposlugcommitnodeget) | **Get** /repositories/{username}/{repo_slug}/commit/{node} | 
[**RepositoriesUsernameRepoSlugCommitsGet**](CommitsApi.md#repositoriesusernamereposlugcommitsget) | **Get** /repositories/{username}/{repo_slug}/commits | 
[**RepositoriesUsernameRepoSlugCommitsPost**](CommitsApi.md#repositoriesusernamereposlugcommitspost) | **Post** /repositories/{username}/{repo_slug}/commits | 
[**RepositoriesUsernameRepoSlugCommitsRevisionGet**](CommitsApi.md#repositoriesusernamereposlugcommitsrevisionget) | **Get** /repositories/{username}/{repo_slug}/commits/{revision} | 
[**RepositoriesUsernameRepoSlugCommitsRevisionPost**](CommitsApi.md#repositoriesusernamereposlugcommitsrevisionpost) | **Post** /repositories/{username}/{repo_slug}/commits/{revision} | 
[**RepositoriesUsernameRepoSlugDiffSpecGet**](CommitsApi.md#repositoriesusernamereposlugdiffspecget) | **Get** /repositories/{username}/{repo_slug}/diff/{spec} | 
[**RepositoriesUsernameRepoSlugPatchSpecGet**](CommitsApi.md#repositoriesusernamereposlugpatchspecget) | **Get** /repositories/{username}/{repo_slug}/patch/{spec} | 


<a name="repositoriesusernamereposlugcommitnodeapprovedelete"></a>
# **RepositoriesUsernameRepoSlugCommitNodeApproveDelete**
> void RepositoriesUsernameRepoSlugCommitNodeApproveDelete (string username, string node, string repo_slug)



Redact the authenticated user's approval of the specified commit.  This operation is only available to users that have explicit access to the repository. In contrast, just the fact that a repository is publicly accessible to users does not give them the ability to approve commits.

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Bitbucket.Refit.Api;
using Itofinity.Bitbucket.Refit.Client;
using Itofinity.Bitbucket.Refit.Model;

namespace Example
{
    public class RepositoriesUsernameRepoSlugCommitNodeApproveDeleteExample
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

            var apiInstance = new CommitsApi();
            var username = username_example;  // string | This can either be the username or the UUID of the account, surrounded by curly-braces, for example: `{account UUID}`. An account is either a team or user. 
            var node = node_example;  // string | The commit's SHA1.
            var repo_slug = repo_slug_example;  // string | This can either be the repository slug or the UUID of the repository, surrounded by curly-braces, for example: `{repository UUID}`. 

            try
            {
                apiInstance.RepositoriesUsernameRepoSlugCommitNodeApproveDelete(username, node, repo_slug);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CommitsApi.RepositoriesUsernameRepoSlugCommitNodeApproveDelete: " + e.Message );
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

void (empty response body)

### Authorization

[api_key](../README.md#api_key), [basic](../README.md#basic), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="repositoriesusernamereposlugcommitnodeapprovepost"></a>
# **RepositoriesUsernameRepoSlugCommitNodeApprovePost**
> Participant RepositoriesUsernameRepoSlugCommitNodeApprovePost (string username, string node, string repo_slug)



Approve the specified commit as the authenticated user.  This operation is only available to users that have explicit access to the repository. In contrast, just the fact that a repository is publicly accessible to users does not give them the ability to approve commits.

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Bitbucket.Refit.Api;
using Itofinity.Bitbucket.Refit.Client;
using Itofinity.Bitbucket.Refit.Model;

namespace Example
{
    public class RepositoriesUsernameRepoSlugCommitNodeApprovePostExample
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

            var apiInstance = new CommitsApi();
            var username = username_example;  // string | This can either be the username or the UUID of the account, surrounded by curly-braces, for example: `{account UUID}`. An account is either a team or user. 
            var node = node_example;  // string | The commit's SHA1.
            var repo_slug = repo_slug_example;  // string | This can either be the repository slug or the UUID of the repository, surrounded by curly-braces, for example: `{repository UUID}`. 

            try
            {
                Participant result = apiInstance.RepositoriesUsernameRepoSlugCommitNodeApprovePost(username, node, repo_slug);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CommitsApi.RepositoriesUsernameRepoSlugCommitNodeApprovePost: " + e.Message );
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

[**Participant**](Participant.md)

### Authorization

[api_key](../README.md#api_key), [basic](../README.md#basic), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="repositoriesusernamereposlugcommitnodecommentscommentidget"></a>
# **RepositoriesUsernameRepoSlugCommitNodeCommentsCommentIdGet**
> CommitComment RepositoriesUsernameRepoSlugCommitNodeCommentsCommentIdGet (string username, string node, int? comment_id, string repo_slug)



Returns the specified commit comment.

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Bitbucket.Refit.Api;
using Itofinity.Bitbucket.Refit.Client;
using Itofinity.Bitbucket.Refit.Model;

namespace Example
{
    public class RepositoriesUsernameRepoSlugCommitNodeCommentsCommentIdGetExample
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

            var apiInstance = new CommitsApi();
            var username = username_example;  // string | This can either be the username or the UUID of the account, surrounded by curly-braces, for example: `{account UUID}`. An account is either a team or user. 
            var node = node_example;  // string | The commit's SHA1.
            var comment_id = 56;  // int? | The id of the comment.
            var repo_slug = repo_slug_example;  // string | This can either be the repository slug or the UUID of the repository, surrounded by curly-braces, for example: `{repository UUID}`. 

            try
            {
                CommitComment result = apiInstance.RepositoriesUsernameRepoSlugCommitNodeCommentsCommentIdGet(username, node, comment_id, repo_slug);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CommitsApi.RepositoriesUsernameRepoSlugCommitNodeCommentsCommentIdGet: " + e.Message );
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
 **comment_id** | **int?**| The id of the comment. | 
 **repo_slug** | **string**| This can either be the repository slug or the UUID of the repository, surrounded by curly-braces, for example: &#x60;{repository UUID}&#x60;.  | 

### Return type

[**CommitComment**](CommitComment.md)

### Authorization

[api_key](../README.md#api_key), [basic](../README.md#basic), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="repositoriesusernamereposlugcommitnodecommentsget"></a>
# **RepositoriesUsernameRepoSlugCommitNodeCommentsGet**
> PaginatedCommitComments RepositoriesUsernameRepoSlugCommitNodeCommentsGet (string username, string node, string repo_slug)



Returns the commit's comments.  This includes both global and inline comments.  The default sorting is oldest to newest and can be overridden with the `sort` query parameter.

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Bitbucket.Refit.Api;
using Itofinity.Bitbucket.Refit.Client;
using Itofinity.Bitbucket.Refit.Model;

namespace Example
{
    public class RepositoriesUsernameRepoSlugCommitNodeCommentsGetExample
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

            var apiInstance = new CommitsApi();
            var username = username_example;  // string | This can either be the username or the UUID of the account, surrounded by curly-braces, for example: `{account UUID}`. An account is either a team or user. 
            var node = node_example;  // string | The commit's SHA1.
            var repo_slug = repo_slug_example;  // string | This can either be the repository slug or the UUID of the repository, surrounded by curly-braces, for example: `{repository UUID}`. 

            try
            {
                PaginatedCommitComments result = apiInstance.RepositoriesUsernameRepoSlugCommitNodeCommentsGet(username, node, repo_slug);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CommitsApi.RepositoriesUsernameRepoSlugCommitNodeCommentsGet: " + e.Message );
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

[**PaginatedCommitComments**](PaginatedCommitComments.md)

### Authorization

[api_key](../README.md#api_key), [basic](../README.md#basic), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="repositoriesusernamereposlugcommitnodecommentspost"></a>
# **RepositoriesUsernameRepoSlugCommitNodeCommentsPost**
> void RepositoriesUsernameRepoSlugCommitNodeCommentsPost (string node, string username, string repo_slug, CommitComment _body)



Creates new comment on the specified commit.  To post a reply to an existing comment, include the `parent.id` field:  ``` $ curl https://api.bitbucket.org/2.0/repositories/atlassian/prlinks/commit/db9ba1e031d07a02603eae0e559a7adc010257fc/comments/ \\   -X POST -u evzijst \\   -H 'Content-Type: application/json' \\   -d '{\"content\": {\"raw\": \"One more thing!\"},        \"parent\": {\"id\": 5728901}}' ```

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Bitbucket.Refit.Api;
using Itofinity.Bitbucket.Refit.Client;
using Itofinity.Bitbucket.Refit.Model;

namespace Example
{
    public class RepositoriesUsernameRepoSlugCommitNodeCommentsPostExample
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

            var apiInstance = new CommitsApi();
            var node = node_example;  // string | The commit's SHA1.
            var username = username_example;  // string | This can either be the username or the UUID of the user, surrounded by curly-braces, for example: `{user UUID}`. 
            var repo_slug = repo_slug_example;  // string | This can either be the repository slug or the UUID of the repository, surrounded by curly-braces, for example: `{repository UUID}`. 
            var _body = new CommitComment(); // CommitComment | The specified comment.

            try
            {
                apiInstance.RepositoriesUsernameRepoSlugCommitNodeCommentsPost(node, username, repo_slug, _body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CommitsApi.RepositoriesUsernameRepoSlugCommitNodeCommentsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **node** | **string**| The commit&#39;s SHA1. | 
 **username** | **string**| This can either be the username or the UUID of the user, surrounded by curly-braces, for example: &#x60;{user UUID}&#x60;.  | 
 **repo_slug** | **string**| This can either be the repository slug or the UUID of the repository, surrounded by curly-braces, for example: &#x60;{repository UUID}&#x60;.  | 
 **_body** | [**CommitComment**](CommitComment.md)| The specified comment. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key), [basic](../README.md#basic), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="repositoriesusernamereposlugcommitnodeget"></a>
# **RepositoriesUsernameRepoSlugCommitNodeGet**
> Commit RepositoriesUsernameRepoSlugCommitNodeGet (string username, string node, string repo_slug)



Returns the specified commit.

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Bitbucket.Refit.Api;
using Itofinity.Bitbucket.Refit.Client;
using Itofinity.Bitbucket.Refit.Model;

namespace Example
{
    public class RepositoriesUsernameRepoSlugCommitNodeGetExample
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

            var apiInstance = new CommitsApi();
            var username = username_example;  // string | This can either be the username or the UUID of the account, surrounded by curly-braces, for example: `{account UUID}`. An account is either a team or user. 
            var node = node_example;  // string | The commit's SHA1.
            var repo_slug = repo_slug_example;  // string | This can either be the repository slug or the UUID of the repository, surrounded by curly-braces, for example: `{repository UUID}`. 

            try
            {
                Commit result = apiInstance.RepositoriesUsernameRepoSlugCommitNodeGet(username, node, repo_slug);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CommitsApi.RepositoriesUsernameRepoSlugCommitNodeGet: " + e.Message );
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

[**Commit**](Commit.md)

### Authorization

[api_key](../README.md#api_key), [basic](../README.md#basic), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="repositoriesusernamereposlugcommitsget"></a>
# **RepositoriesUsernameRepoSlugCommitsGet**
> Error RepositoriesUsernameRepoSlugCommitsGet (string username, string repo_slug)



These are the repository's commits. They are paginated and returned in reverse chronological order, similar to the output of `git log` and `hg log`. Like these tools, the DAG can be filtered.  ## GET /repositories/{username}/{repo_slug}/commits/  Returns all commits in the repo in topological order (newest commit first). All branches and tags are included (similar to `git log - -all` and `hg log`).  ## GET /repositories/{username}/{repo_slug}/commits/master  Returns all commits on rev `master` (similar to `git log master`, `hg log master`).  ## GET /repositories/{username}/{repo_slug}/commits/dev?exclude=master  Returns all commits on ref `dev`, except those that are reachable on `master` (similar to `git log dev ^master`).  ## GET /repositories/{username}/{repo_slug}/commits/?exclude=master  Returns all commits in the repo that are not on master (similar to `git log - -all ^master`).  ## GET /repositories/{username}/{repo_slug}/commits/?include=foo&include=bar&exclude=fu&exclude=fubar  Returns all commits that are on refs `foo` or `bar`, but not on `fu` or `fubar` (similar to `git log foo bar ^fu ^fubar`).  Because the response could include a very large number of commits, it is paginated. Follow the 'next' link in the response to navigate to the next page of commits. As with other paginated resources, do not construct your own links.  When the include and exclude parameters are more than can fit in a query string, clients can use a `x-www-form-urlencoded` POST instead.

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Bitbucket.Refit.Api;
using Itofinity.Bitbucket.Refit.Client;
using Itofinity.Bitbucket.Refit.Model;

namespace Example
{
    public class RepositoriesUsernameRepoSlugCommitsGetExample
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

            var apiInstance = new CommitsApi();
            var username = username_example;  // string | This can either be the username or the UUID of the account, surrounded by curly-braces, for example: `{account UUID}`. An account is either a team or user. 
            var repo_slug = repo_slug_example;  // string | This can either be the repository slug or the UUID of the repository, surrounded by curly-braces, for example: `{repository UUID}`. 

            try
            {
                Error result = apiInstance.RepositoriesUsernameRepoSlugCommitsGet(username, repo_slug);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CommitsApi.RepositoriesUsernameRepoSlugCommitsGet: " + e.Message );
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

[**Error**](Error.md)

### Authorization

[api_key](../README.md#api_key), [basic](../README.md#basic), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="repositoriesusernamereposlugcommitspost"></a>
# **RepositoriesUsernameRepoSlugCommitsPost**
> Error RepositoriesUsernameRepoSlugCommitsPost (string username, string repo_slug)



Identical to `GET /repositories/{username}/{repo_slug}/commits`, except that POST allows clients to place the include and exclude parameters in the request body to avoid URL length issues.  **Note that this resource does NOT support new commit creation.**

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Bitbucket.Refit.Api;
using Itofinity.Bitbucket.Refit.Client;
using Itofinity.Bitbucket.Refit.Model;

namespace Example
{
    public class RepositoriesUsernameRepoSlugCommitsPostExample
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

            var apiInstance = new CommitsApi();
            var username = username_example;  // string | This can either be the username or the UUID of the account, surrounded by curly-braces, for example: `{account UUID}`. An account is either a team or user. 
            var repo_slug = repo_slug_example;  // string | This can either be the repository slug or the UUID of the repository, surrounded by curly-braces, for example: `{repository UUID}`. 

            try
            {
                Error result = apiInstance.RepositoriesUsernameRepoSlugCommitsPost(username, repo_slug);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CommitsApi.RepositoriesUsernameRepoSlugCommitsPost: " + e.Message );
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

[**Error**](Error.md)

### Authorization

[api_key](../README.md#api_key), [basic](../README.md#basic), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="repositoriesusernamereposlugcommitsrevisionget"></a>
# **RepositoriesUsernameRepoSlugCommitsRevisionGet**
> Error RepositoriesUsernameRepoSlugCommitsRevisionGet (string username, string revision, string repo_slug)



These are the repository's commits. They are paginated and returned in reverse chronological order, similar to the output of `git log` and `hg log`. Like these tools, the DAG can be filtered.  ## GET /repositories/{username}/{repo_slug}/commits/  Returns all commits in the repo in topological order (newest commit first). All branches and tags are included (similar to `git log - -all` and `hg log`).  ## GET /repositories/{username}/{repo_slug}/commits/master  Returns all commits on rev `master` (similar to `git log master`, `hg log master`).  ## GET /repositories/{username}/{repo_slug}/commits/dev?exclude=master  Returns all commits on ref `dev`, except those that are reachable on `master` (similar to `git log dev ^master`).  ## GET /repositories/{username}/{repo_slug}/commits/?exclude=master  Returns all commits in the repo that are not on master (similar to `git log - -all ^master`).  ## GET /repositories/{username}/{repo_slug}/commits/?include=foo&include=bar&exclude=fu&exclude=fubar  Returns all commits that are on refs `foo` or `bar`, but not on `fu` or `fubar` (similar to `git log foo bar ^fu ^fubar`).  Because the response could include a very large number of commits, it is paginated. Follow the 'next' link in the response to navigate to the next page of commits. As with other paginated resources, do not construct your own links.  When the include and exclude parameters are more than can fit in a query string, clients can use a `x-www-form-urlencoded` POST instead.

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Bitbucket.Refit.Api;
using Itofinity.Bitbucket.Refit.Client;
using Itofinity.Bitbucket.Refit.Model;

namespace Example
{
    public class RepositoriesUsernameRepoSlugCommitsRevisionGetExample
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

            var apiInstance = new CommitsApi();
            var username = username_example;  // string | This can either be the username or the UUID of the account, surrounded by curly-braces, for example: `{account UUID}`. An account is either a team or user. 
            var revision = revision_example;  // string | 
            var repo_slug = repo_slug_example;  // string | This can either be the repository slug or the UUID of the repository, surrounded by curly-braces, for example: `{repository UUID}`. 

            try
            {
                Error result = apiInstance.RepositoriesUsernameRepoSlugCommitsRevisionGet(username, revision, repo_slug);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CommitsApi.RepositoriesUsernameRepoSlugCommitsRevisionGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**| This can either be the username or the UUID of the account, surrounded by curly-braces, for example: &#x60;{account UUID}&#x60;. An account is either a team or user.  | 
 **revision** | **string**|  | 
 **repo_slug** | **string**| This can either be the repository slug or the UUID of the repository, surrounded by curly-braces, for example: &#x60;{repository UUID}&#x60;.  | 

### Return type

[**Error**](Error.md)

### Authorization

[api_key](../README.md#api_key), [basic](../README.md#basic), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="repositoriesusernamereposlugcommitsrevisionpost"></a>
# **RepositoriesUsernameRepoSlugCommitsRevisionPost**
> Error RepositoriesUsernameRepoSlugCommitsRevisionPost (string username, string revision, string repo_slug)



Identical to `GET /repositories/{username}/{repo_slug}/commits`, except that POST allows clients to place the include and exclude parameters in the request body to avoid URL length issues.  **Note that this resource does NOT support new commit creation.**

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Bitbucket.Refit.Api;
using Itofinity.Bitbucket.Refit.Client;
using Itofinity.Bitbucket.Refit.Model;

namespace Example
{
    public class RepositoriesUsernameRepoSlugCommitsRevisionPostExample
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

            var apiInstance = new CommitsApi();
            var username = username_example;  // string | This can either be the username or the UUID of the account, surrounded by curly-braces, for example: `{account UUID}`. An account is either a team or user. 
            var revision = revision_example;  // string | 
            var repo_slug = repo_slug_example;  // string | This can either be the repository slug or the UUID of the repository, surrounded by curly-braces, for example: `{repository UUID}`. 

            try
            {
                Error result = apiInstance.RepositoriesUsernameRepoSlugCommitsRevisionPost(username, revision, repo_slug);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CommitsApi.RepositoriesUsernameRepoSlugCommitsRevisionPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**| This can either be the username or the UUID of the account, surrounded by curly-braces, for example: &#x60;{account UUID}&#x60;. An account is either a team or user.  | 
 **revision** | **string**|  | 
 **repo_slug** | **string**| This can either be the repository slug or the UUID of the repository, surrounded by curly-braces, for example: &#x60;{repository UUID}&#x60;.  | 

### Return type

[**Error**](Error.md)

### Authorization

[api_key](../README.md#api_key), [basic](../README.md#basic), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="repositoriesusernamereposlugdiffspecget"></a>
# **RepositoriesUsernameRepoSlugDiffSpecGet**
> void RepositoriesUsernameRepoSlugDiffSpecGet (string username, string spec, string repo_slug, int? context = null, string path = null, bool? ignore_whitespace = null, bool? binary = null)



Produces a raw, git-style diff for either a single commit (diffed against its first parent), or a revspec of 2 commits (e.g. `3a8b42..9ff173` where the first commit represents the source and the second commit the destination).  In case of the latter (diffing a revspec), a 3-way diff, or merge diff, is computed. This shows the changes introduced by the left branch (`3a8b42` in our example) as compared againt the right branch (`9ff173`).  This is equivalent to merging the left branch into the right branch and then computing the diff of the merge commit against its first parent (the right branch). This follows the same behavior as pull requests that also show this style of 3-way, or merge diff.  While similar to patches, diffs:  * Don't have a commit header (username, commit message, etc) * Support the optional `path=foo/bar.py` query param to filter   the diff to just that one file diff  The raw diff is returned as-is, in whatever encoding the files in the repository use. It is not decoded into unicode. As such, the content-type is `text/plain`.

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Bitbucket.Refit.Api;
using Itofinity.Bitbucket.Refit.Client;
using Itofinity.Bitbucket.Refit.Model;

namespace Example
{
    public class RepositoriesUsernameRepoSlugDiffSpecGetExample
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

            var apiInstance = new CommitsApi();
            var username = username_example;  // string | 
            var spec = spec_example;  // string | 
            var repo_slug = repo_slug_example;  // string | 
            var context = 56;  // int? | Generate diffs with <n> lines of context instead of the usual three (optional) 
            var path = path_example;  // string | Limit the diff to a particular file (this parameter can be repeated for multiple paths) (optional) 
            var ignore_whitespace = true;  // bool? | Generate diffs that ignore whitespace (optional) 
            var binary = true;  // bool? | Generate diffs that include binary files,true if omitted. (optional) 

            try
            {
                apiInstance.RepositoriesUsernameRepoSlugDiffSpecGet(username, spec, repo_slug, context, path, ignore_whitespace, binary);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CommitsApi.RepositoriesUsernameRepoSlugDiffSpecGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**|  | 
 **spec** | **string**|  | 
 **repo_slug** | **string**|  | 
 **context** | **int?**| Generate diffs with &lt;n&gt; lines of context instead of the usual three | [optional] 
 **path** | **string**| Limit the diff to a particular file (this parameter can be repeated for multiple paths) | [optional] 
 **ignore_whitespace** | **bool?**| Generate diffs that ignore whitespace | [optional] 
 **binary** | **bool?**| Generate diffs that include binary files,true if omitted. | [optional] 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key), [basic](../README.md#basic), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="repositoriesusernamereposlugpatchspecget"></a>
# **RepositoriesUsernameRepoSlugPatchSpecGet**
> void RepositoriesUsernameRepoSlugPatchSpecGet (string username, string spec, string repo_slug)



Produces a raw patch for a single commit (diffed against its first parent), or a patch-series for a revspec of 2 commits (e.g. `3a8b42..9ff173` where the first commit represents the source and the second commit the destination).  In case of the latter (diffing a revspec), a patch series is returned for the commits on the source branch (`3a8b42` and its ancestors in our example). For Mercurial, a single patch is returned that combines the changes of all commits on the source branch.  While similar to diffs, patches:  * Have a commit header (username, commit message, etc) * Do not support the `path=foo/bar.py` query parameter  The raw patch is returned as-is, in whatever encoding the files in the repository use. It is not decoded into unicode. As such, the content-type is `text/plain`.

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Bitbucket.Refit.Api;
using Itofinity.Bitbucket.Refit.Client;
using Itofinity.Bitbucket.Refit.Model;

namespace Example
{
    public class RepositoriesUsernameRepoSlugPatchSpecGetExample
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

            var apiInstance = new CommitsApi();
            var username = username_example;  // string | 
            var spec = spec_example;  // string | 
            var repo_slug = repo_slug_example;  // string | 

            try
            {
                apiInstance.RepositoriesUsernameRepoSlugPatchSpecGet(username, spec, repo_slug);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CommitsApi.RepositoriesUsernameRepoSlugPatchSpecGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**|  | 
 **spec** | **string**|  | 
 **repo_slug** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key), [basic](../README.md#basic), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

