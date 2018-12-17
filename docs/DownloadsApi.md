# Itofinity.Bitbucket.Refit.Api.DownloadsApi

All URIs are relative to *https://api.localhost:8000/2.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**RepositoriesUsernameRepoSlugDownloadsFilenameDelete**](DownloadsApi.md#repositoriesusernamereposlugdownloadsfilenamedelete) | **Delete** /repositories/{username}/{repo_slug}/downloads/{filename} | 
[**RepositoriesUsernameRepoSlugDownloadsFilenameGet**](DownloadsApi.md#repositoriesusernamereposlugdownloadsfilenameget) | **Get** /repositories/{username}/{repo_slug}/downloads/{filename} | 
[**RepositoriesUsernameRepoSlugDownloadsGet**](DownloadsApi.md#repositoriesusernamereposlugdownloadsget) | **Get** /repositories/{username}/{repo_slug}/downloads | 
[**RepositoriesUsernameRepoSlugDownloadsPost**](DownloadsApi.md#repositoriesusernamereposlugdownloadspost) | **Post** /repositories/{username}/{repo_slug}/downloads | 


<a name="repositoriesusernamereposlugdownloadsfilenamedelete"></a>
# **RepositoriesUsernameRepoSlugDownloadsFilenameDelete**
> Error RepositoriesUsernameRepoSlugDownloadsFilenameDelete (string username, string filename, string repo_slug)



Deletes the specified download artifact from the repository.

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Bitbucket.Refit.Api;
using Itofinity.Bitbucket.Refit.Client;
using Itofinity.Bitbucket.Refit.Model;

namespace Example
{
    public class RepositoriesUsernameRepoSlugDownloadsFilenameDeleteExample
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

            var apiInstance = new DownloadsApi();
            var username = username_example;  // string | 
            var filename = filename_example;  // string | 
            var repo_slug = repo_slug_example;  // string | 

            try
            {
                Error result = apiInstance.RepositoriesUsernameRepoSlugDownloadsFilenameDelete(username, filename, repo_slug);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DownloadsApi.RepositoriesUsernameRepoSlugDownloadsFilenameDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**|  | 
 **filename** | **string**|  | 
 **repo_slug** | **string**|  | 

### Return type

[**Error**](Error.md)

### Authorization

[api_key](../README.md#api_key), [basic](../README.md#basic), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="repositoriesusernamereposlugdownloadsfilenameget"></a>
# **RepositoriesUsernameRepoSlugDownloadsFilenameGet**
> Error RepositoriesUsernameRepoSlugDownloadsFilenameGet (string username, string filename, string repo_slug)



Return a redirect to the contents of a download artifact.  This endpoint returns the actual file contents and not the artifact's metadata.      $ curl -s -L https://api.bitbucket.org/2.0/repositories/evzijst/git-tests/downloads/hello.txt     Hello World

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Bitbucket.Refit.Api;
using Itofinity.Bitbucket.Refit.Client;
using Itofinity.Bitbucket.Refit.Model;

namespace Example
{
    public class RepositoriesUsernameRepoSlugDownloadsFilenameGetExample
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

            var apiInstance = new DownloadsApi();
            var username = username_example;  // string | 
            var filename = filename_example;  // string | 
            var repo_slug = repo_slug_example;  // string | 

            try
            {
                Error result = apiInstance.RepositoriesUsernameRepoSlugDownloadsFilenameGet(username, filename, repo_slug);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DownloadsApi.RepositoriesUsernameRepoSlugDownloadsFilenameGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**|  | 
 **filename** | **string**|  | 
 **repo_slug** | **string**|  | 

### Return type

[**Error**](Error.md)

### Authorization

[api_key](../README.md#api_key), [basic](../README.md#basic), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="repositoriesusernamereposlugdownloadsget"></a>
# **RepositoriesUsernameRepoSlugDownloadsGet**
> Error RepositoriesUsernameRepoSlugDownloadsGet (string username, string repo_slug)



Returns a list of download links associated with the repository.

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Bitbucket.Refit.Api;
using Itofinity.Bitbucket.Refit.Client;
using Itofinity.Bitbucket.Refit.Model;

namespace Example
{
    public class RepositoriesUsernameRepoSlugDownloadsGetExample
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

            var apiInstance = new DownloadsApi();
            var username = username_example;  // string | 
            var repo_slug = repo_slug_example;  // string | 

            try
            {
                Error result = apiInstance.RepositoriesUsernameRepoSlugDownloadsGet(username, repo_slug);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DownloadsApi.RepositoriesUsernameRepoSlugDownloadsGet: " + e.Message );
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

[**Error**](Error.md)

### Authorization

[api_key](../README.md#api_key), [basic](../README.md#basic), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="repositoriesusernamereposlugdownloadspost"></a>
# **RepositoriesUsernameRepoSlugDownloadsPost**
> Error RepositoriesUsernameRepoSlugDownloadsPost (string username, string repo_slug)



Upload new download artifacts.  To upload files, perform a `multipart/form-data` POST containing one or more `files` fields:      $ echo Hello World > hello.txt     $ curl -s -u evzijst -X POST https://api.bitbucket.org/2.0/repositories/evzijst/git-tests/downloads -F files=@hello.txt  When a file is uploaded with the same name as an existing artifact, then the existing file will be replaced.

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Bitbucket.Refit.Api;
using Itofinity.Bitbucket.Refit.Client;
using Itofinity.Bitbucket.Refit.Model;

namespace Example
{
    public class RepositoriesUsernameRepoSlugDownloadsPostExample
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

            var apiInstance = new DownloadsApi();
            var username = username_example;  // string | 
            var repo_slug = repo_slug_example;  // string | 

            try
            {
                Error result = apiInstance.RepositoriesUsernameRepoSlugDownloadsPost(username, repo_slug);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DownloadsApi.RepositoriesUsernameRepoSlugDownloadsPost: " + e.Message );
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

[**Error**](Error.md)

### Authorization

[api_key](../README.md#api_key), [basic](../README.md#basic), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

