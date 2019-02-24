# Itofinity.Bitbucket.Rest.Api.DeployApi

All URIs are relative to *https://api.localhost:8000/2.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**RepositoriesUsernameRepoSlugDeployKeysGet**](DeployApi.md#repositoriesusernamereposlugdeploykeysget) | **Get** /repositories/{username}/{repo_slug}/deploy-keys | 
[**RepositoriesUsernameRepoSlugDeployKeysKeyIdDelete**](DeployApi.md#repositoriesusernamereposlugdeploykeyskeyiddelete) | **Delete** /repositories/{username}/{repo_slug}/deploy-keys/{key_id} | 
[**RepositoriesUsernameRepoSlugDeployKeysKeyIdGet**](DeployApi.md#repositoriesusernamereposlugdeploykeyskeyidget) | **Get** /repositories/{username}/{repo_slug}/deploy-keys/{key_id} | 
[**RepositoriesUsernameRepoSlugDeployKeysKeyIdPut**](DeployApi.md#repositoriesusernamereposlugdeploykeyskeyidput) | **Put** /repositories/{username}/{repo_slug}/deploy-keys/{key_id} | 
[**RepositoriesUsernameRepoSlugDeployKeysPost**](DeployApi.md#repositoriesusernamereposlugdeploykeyspost) | **Post** /repositories/{username}/{repo_slug}/deploy-keys | 


<a name="repositoriesusernamereposlugdeploykeysget"></a>
# **RepositoriesUsernameRepoSlugDeployKeysGet**
> DeployKey RepositoriesUsernameRepoSlugDeployKeysGet (string username, string repo_slug)



Returns all deploy-keys belonging to a repository.  Example: ``` $ curl -H \"Authorization <auth header>\" \\ https://api.bitbucket.org/2.0/repositories/mleu/test/deploy-keys  Output: {     \"comment\": \"mleu@C02W454JHTD8\",     \"last_used\": null,     \"links\": {         \"self\": {             \"href\": https://api.bitbucket.org/2.0/repositories/mleu/test/deploy-keys\"         }     },     \"repository\": \"test\",     \"label\": \"mykey\",     \"created_on\": \"2018-08-15T23:50:59.993890+00:00\",     \"key\": \"ssh-rsa AAAAB3NzaC1yc2EAAAADAQABAAABAQDAK/b1cHHDr/TEV1JGQl+WjCwStKG6Bhrv0rFpEsYlyTBm1fzN0VOJJYn4ZOPCPJwqse6fGbXntEs+BbXiptR+++HycVgl65TMR0b5ul5AgwrVdZdT7qjCOCgaSV74/9xlHDK8oqgGnfA7ZoBBU+qpVyaloSjBdJfLtPY/xqj4yHnXKYzrtn/uFc4Kp9Tb7PUg9Io3qohSTGJGVHnsVblq/rToJG7L5xIo0OxK0SJSQ5vuId93ZuFZrCNMXj8JDHZeSEtjJzpRCBEXHxpOPhAcbm4MzULgkFHhAVgp4JbkrT99/wpvZ7r9AdkTg7HGqL3rlaDrEcWfL7Lu6TnhBdq5\",     \"pk\": 1,     \"type\": \"deploy_key\" } ```

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Bitbucket.Rest.Api;
using Itofinity.Bitbucket.Rest.Client;
using Itofinity.Bitbucket.Rest.Model;

namespace Example
{
    public class RepositoriesUsernameRepoSlugDeployKeysGetExample
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

            var apiInstance = new DeployApi();
            var username = username_example;  // string | The account's username.
            var repo_slug = repo_slug_example;  // string | The name of the repository the deploy key belongs to.

            try
            {
                DeployKey result = apiInstance.RepositoriesUsernameRepoSlugDeployKeysGet(username, repo_slug);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeployApi.RepositoriesUsernameRepoSlugDeployKeysGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**| The account&#39;s username. | 
 **repo_slug** | **string**| The name of the repository the deploy key belongs to. | 

### Return type

[**DeployKey**](DeployKey.md)

### Authorization

[api_key](../README.md#api_key), [basic](../README.md#basic), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="repositoriesusernamereposlugdeploykeyskeyiddelete"></a>
# **RepositoriesUsernameRepoSlugDeployKeysKeyIdDelete**
> void RepositoriesUsernameRepoSlugDeployKeysKeyIdDelete (string username, string repo_slug, string key_id)



This deletes a deploy key from a repository.  Example: ``` $ curl -XDELETE \\ -H \"Authorization <auth header>\" \\ https://api.bitbucket.org/2.0/repositories/mleu/test/deploy-keys/1234 ```

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Bitbucket.Rest.Api;
using Itofinity.Bitbucket.Rest.Client;
using Itofinity.Bitbucket.Rest.Model;

namespace Example
{
    public class RepositoriesUsernameRepoSlugDeployKeysKeyIdDeleteExample
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

            var apiInstance = new DeployApi();
            var username = username_example;  // string | The account's username.
            var repo_slug = repo_slug_example;  // string | The name of the repository the deploy key belongs to.
            var key_id = key_id_example;  // string | The key ID matching the deploy key.

            try
            {
                apiInstance.RepositoriesUsernameRepoSlugDeployKeysKeyIdDelete(username, repo_slug, key_id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeployApi.RepositoriesUsernameRepoSlugDeployKeysKeyIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**| The account&#39;s username. | 
 **repo_slug** | **string**| The name of the repository the deploy key belongs to. | 
 **key_id** | **string**| The key ID matching the deploy key. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key), [basic](../README.md#basic), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="repositoriesusernamereposlugdeploykeyskeyidget"></a>
# **RepositoriesUsernameRepoSlugDeployKeysKeyIdGet**
> DeployKey RepositoriesUsernameRepoSlugDeployKeysKeyIdGet (string username, string repo_slug, string key_id)



Returns the deploy key belonging to a specific key.  Example: ``` $ curl -H \"Authorization <auth header>\" \\ https://api.bitbucket.org/2.0/repositories/mleu/test/deploy-key/1234  Output: {     \"comment\": \"mleu@C02W454JHTD8\",     \"last_used\": null,     \"links\": {         \"self\": {             \"href\": https://api.bitbucket.org/2.0/repositories/mleu/test/deploy-key/1234\"         }     },     \"repository\": \"test\",     \"label\": \"mykey\",     \"created_on\": \"2018-08-15T23:50:59.993890+00:00\",     \"key\": \"ssh-rsa AAAAB3NzaC1yc2EAAAADAQABAAABAQDAK/b1cHHDr/TEV1JGQl+WjCwStKG6Bhrv0rFpEsYlyTBm1fzN0VOJJYn4ZOPCPJwqse6fGbXntEs+BbXiptR+++HycVgl65TMR0b5ul5AgwrVdZdT7qjCOCgaSV74/9xlHDK8oqgGnfA7ZoBBU+qpVyaloSjBdJfLtPY/xqj4yHnXKYzrtn/uFc4Kp9Tb7PUg9Io3qohSTGJGVHnsVblq/rToJG7L5xIo0OxK0SJSQ5vuId93ZuFZrCNMXj8JDHZeSEtjJzpRCBEXHxpOPhAcbm4MzULgkFHhAVgp4JbkrT99/wpvZ7r9AdkTg7HGqL3rlaDrEcWfL7Lu6TnhBdq5\",     \"pk\": 1234,     \"type\": \"deploy_key\" } ```

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Bitbucket.Rest.Api;
using Itofinity.Bitbucket.Rest.Client;
using Itofinity.Bitbucket.Rest.Model;

namespace Example
{
    public class RepositoriesUsernameRepoSlugDeployKeysKeyIdGetExample
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

            var apiInstance = new DeployApi();
            var username = username_example;  // string | The account's username.
            var repo_slug = repo_slug_example;  // string | The name of the repository the deploy key belongs to.
            var key_id = key_id_example;  // string | The key ID matching the deploy key.

            try
            {
                DeployKey result = apiInstance.RepositoriesUsernameRepoSlugDeployKeysKeyIdGet(username, repo_slug, key_id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeployApi.RepositoriesUsernameRepoSlugDeployKeysKeyIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**| The account&#39;s username. | 
 **repo_slug** | **string**| The name of the repository the deploy key belongs to. | 
 **key_id** | **string**| The key ID matching the deploy key. | 

### Return type

[**DeployKey**](DeployKey.md)

### Authorization

[api_key](../README.md#api_key), [basic](../README.md#basic), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="repositoriesusernamereposlugdeploykeyskeyidput"></a>
# **RepositoriesUsernameRepoSlugDeployKeysKeyIdPut**
> DeployKey RepositoriesUsernameRepoSlugDeployKeysKeyIdPut (string username, string repo_slug, string key_id)



Create a new deploy key in a repository.  The same key needs to be passed in but the comment and label can change.  Example: ``` $ curl -XPUT \\ -H \"Authorization <auth header>\" \\ -H \"Content-type: application/json\" \\ https://api.bitbucket.org/2.0/repositories/mleu/test/deploy-keys/1234 -d \\ '{     \"label\": \"newlabel\",     \"key\": \"ssh-rsa AAAAB3NzaC1yc2EAAAADAQABAAABAQDAK/b1cHHDr/TEV1JGQl+WjCwStKG6Bhrv0rFpEsYlyTBm1fzN0VOJJYn4ZOPCPJwqse6fGbXntEs+BbXiptR+++HycVgl65TMR0b5ul5AgwrVdZdT7qjCOCgaSV74/9xlHDK8oqgGnfA7ZoBBU+qpVyaloSjBdJfLtPY/xqj4yHnXKYzrtn/uFc4Kp9Tb7PUg9Io3qohSTGJGVHnsVblq/rToJG7L5xIo0OxK0SJSQ5vuId93ZuFZrCNMXj8JDHZeSEtjJzpRCBEXHxpOPhAcbm4MzULgkFHhAVgp4JbkrT99/wpvZ7r9AdkTg7HGqL3rlaDrEcWfL7Lu6TnhBdq5 newcomment\", }'  Output: {     \"comment\": \"newcomment\",     \"last_used\": null,     \"links\": {         \"self\": {             \"href\": \"http://localhost:8000/!api/2.0/repositories/mleu/test/deploy-keys/1234\"         }     },     \"repository\": \"test\",     \"label\": \"newlabel\",     \"created_on\": \"2018-08-15T23:50:59.993890+00:00\",     \"key\": \"ssh-rsa AAAAB3NzaC1yc2EAAAADAQABAAABAQDAK/b1cHHDr/TEV1JGQl+WjCwStKG6Bhrv0rFpEsYlyTBm1fzN0VOJJYn4ZOPCPJwqse6fGbXntEs+BbXiptR+++HycVgl65TMR0b5ul5AgwrVdZdT7qjCOCgaSV74/9xlHDK8oqgGnfA7ZoBBU+qpVyaloSjBdJfLtPY/xqj4yHnXKYzrtn/uFc4Kp9Tb7PUg9Io3qohSTGJGVHnsVblq/rToJG7L5xIo0OxK0SJSQ5vuId93ZuFZrCNMXj8JDHZeSEtjJzpRCBEXHxpOPhAcbm4MzULgkFHhAVgp4JbkrT99/wpvZ7r9AdkTg7HGqL3rlaDrEcWfL7Lu6TnhBdq5\",     \"pk\": 1234,     \"type\": \"deploy_key\" } ```

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Bitbucket.Rest.Api;
using Itofinity.Bitbucket.Rest.Client;
using Itofinity.Bitbucket.Rest.Model;

namespace Example
{
    public class RepositoriesUsernameRepoSlugDeployKeysKeyIdPutExample
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

            var apiInstance = new DeployApi();
            var username = username_example;  // string | The account's username.
            var repo_slug = repo_slug_example;  // string | The name of the repository the deploy key belongs to.
            var key_id = key_id_example;  // string | The key ID matching the deploy key.

            try
            {
                DeployKey result = apiInstance.RepositoriesUsernameRepoSlugDeployKeysKeyIdPut(username, repo_slug, key_id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeployApi.RepositoriesUsernameRepoSlugDeployKeysKeyIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**| The account&#39;s username. | 
 **repo_slug** | **string**| The name of the repository the deploy key belongs to. | 
 **key_id** | **string**| The key ID matching the deploy key. | 

### Return type

[**DeployKey**](DeployKey.md)

### Authorization

[api_key](../README.md#api_key), [basic](../README.md#basic), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="repositoriesusernamereposlugdeploykeyspost"></a>
# **RepositoriesUsernameRepoSlugDeployKeysPost**
> DeployKey RepositoriesUsernameRepoSlugDeployKeysPost (string username, string repo_slug)



Create a new deploy key in a repository.  Example: ``` $ curl -XPOST \\ -H \"Authorization <auth header>\" \\ -H \"Content-type: application/json\" \\ https://api.bitbucket.org/2.0/repositories/mleu/test/deploy-keys -d \\ '{     \"key\": \"ssh-rsa AAAAB3NzaC1yc2EAAAADAQABAAABAQDAK/b1cHHDr/TEV1JGQl+WjCwStKG6Bhrv0rFpEsYlyTBm1fzN0VOJJYn4ZOPCPJwqse6fGbXntEs+BbXiptR+++HycVgl65TMR0b5ul5AgwrVdZdT7qjCOCgaSV74/9xlHDK8oqgGnfA7ZoBBU+qpVyaloSjBdJfLtPY/xqj4yHnXKYzrtn/uFc4Kp9Tb7PUg9Io3qohSTGJGVHnsVblq/rToJG7L5xIo0OxK0SJSQ5vuId93ZuFZrCNMXj8JDHZeSEtjJzpRCBEXHxpOPhAcbm4MzULgkFHhAVgp4JbkrT99/wpvZ7r9AdkTg7HGqL3rlaDrEcWfL7Lu6TnhBdq5 mleu@C02W454JHTD8\",     \"label\": \"mydeploykey\" }'  Output: {     \"pk\": 123,     \"key\": \"ssh-rsa AAAAB3NzaC1yc2EAAAADAQABAAABAQDAK/b1cHHDr/TEV1JGQl+WjCwStKG6Bhrv0rFpEsYlyTBm1fzN0VOJJYn4ZOPCPJwqse6fGbXntEs+BbXiptR+++HycVgl65TMR0b5ul5AgwrVdZdT7qjCOCgaSV74/9xlHDK8oqgGnfA7ZoBBU+qpVyaloSjBdJfLtPY/xqj4yHnXKYzrtn/uFc4Kp9Tb7PUg9Io3qohSTGJGVHnsVblq/rToJG7L5xIo0OxK0SJSQ5vuId93ZuFZrCNMXj8JDHZeSEtjJzpRCBEXHxpOPhAcbm4MzULgkFHhAVgp4JbkrT99/wpvZ7r9AdkTg7HGqL3rlaDrEcWfL7Lu6TnhBdq5\",     \"label\": \"mydeploykey\",     \"type\": \"deploy_key\",     \"created_on\": \"2018-08-15T23:50:59.993890+00:00\",     \"repository\": \"test\",     \"links\":{         \"self\":{             \"href\": \"https://api.bitbucket.org/2.0/repositories/mleu/test/deploy-keys/123\"         }     }     \"last_used\": null,     \"comment\": \"mleu@C02W454JHTD8\" } ```

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Bitbucket.Rest.Api;
using Itofinity.Bitbucket.Rest.Client;
using Itofinity.Bitbucket.Rest.Model;

namespace Example
{
    public class RepositoriesUsernameRepoSlugDeployKeysPostExample
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

            var apiInstance = new DeployApi();
            var username = username_example;  // string | The account's username.
            var repo_slug = repo_slug_example;  // string | The name of the repository the deploy key belongs to.

            try
            {
                DeployKey result = apiInstance.RepositoriesUsernameRepoSlugDeployKeysPost(username, repo_slug);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeployApi.RepositoriesUsernameRepoSlugDeployKeysPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**| The account&#39;s username. | 
 **repo_slug** | **string**| The name of the repository the deploy key belongs to. | 

### Return type

[**DeployKey**](DeployKey.md)

### Authorization

[api_key](../README.md#api_key), [basic](../README.md#basic), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

