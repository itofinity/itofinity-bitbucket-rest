# Itofinity.Bitbucket.Rest.Api.SshApi

All URIs are relative to *https://api.localhost:8000/2.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**UsersUsernameSshKeysDelete**](SshApi.md#usersusernamesshkeysdelete) | **Delete** /users/{username}/ssh-keys/ | 
[**UsersUsernameSshKeysGet**](SshApi.md#usersusernamesshkeysget) | **Get** /users/{username}/ssh-keys/ | 
[**UsersUsernameSshKeysGet_0**](SshApi.md#usersusernamesshkeysget_0) | **Get** /users/{username}/ssh-keys | 
[**UsersUsernameSshKeysPost**](SshApi.md#usersusernamesshkeyspost) | **Post** /users/{username}/ssh-keys | 
[**UsersUsernameSshKeysPut**](SshApi.md#usersusernamesshkeysput) | **Put** /users/{username}/ssh-keys/ | 


<a name="usersusernamesshkeysdelete"></a>
# **UsersUsernameSshKeysDelete**
> void UsersUsernameSshKeysDelete (string username, string key_id)



Deletes a specific SSH public key from a user's account  Example: ``` $ curl -X DELETE https://api.bitbucket.org/2.0/users/markadams-atl/ssh-keys/{b15b6026-9c02-4626-b4ad-b905f99f763a} ```

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Bitbucket.Rest.Api;
using Itofinity.Bitbucket.Rest.Client;
using Itofinity.Bitbucket.Rest.Model;

namespace Example
{
    public class UsersUsernameSshKeysDeleteExample
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

            var apiInstance = new SshApi();
            var username = username_example;  // string | The account's username or UUID.
            var key_id = key_id_example;  // string | The SSH key's UUID value.

            try
            {
                apiInstance.UsersUsernameSshKeysDelete(username, key_id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SshApi.UsersUsernameSshKeysDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**| The account&#39;s username or UUID. | 
 **key_id** | **string**| The SSH key&#39;s UUID value. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key), [basic](../README.md#basic), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersusernamesshkeysget"></a>
# **UsersUsernameSshKeysGet**
> SshAccountKey UsersUsernameSshKeysGet (string username, string key_id)



Returns a specific SSH public key belonging to a user.  Example: ``` $ curl https://api.bitbucket.org/2.0/users/markadams-atl/ssh-keys/{fbe4bbab-f6f7-4dde-956b-5c58323c54b3}  {     \"comment\": \"user@myhost\",     \"created_on\": \"2018-03-14T13:17:05.196003+00:00\",     \"key\": \"ssh-ed25519 AAAAC3NzaC1lZDI1NTE5AAAAIKqP3Cr632C2dNhhgKVcon4ldUSAeKiku2yP9O9/bDtY\",     \"label\": \"\",     \"last_used\": \"2018-03-20T13:18:05.196003+00:00\",     \"links\": {         \"self\": {             \"href\": \"https://api.bitbucket.org/2.0/users/markadams-atl/ssh-keys/b15b6026-9c02-4626-b4ad-b905f99f763a\"         }     },     \"owner\": {         \"display_name\": \"Mark Adams\",         \"links\": {             \"avatar\": {                 \"href\": \"https://bitbucket.org/account/markadams-atl/avatar/32/\"             },             \"html\": {                 \"href\": \"https://bitbucket.org/markadams-atl/\"             },             \"self\": {                 \"href\": \"https://api.bitbucket.org/2.0/users/markadams-atl\"             }         },         \"type\": \"user\",         \"username\": \"markadams-atl\",         \"nickname\": \"markadams-atl\",         \"uuid\": \"{d7dd0e2d-3994-4a50-a9ee-d260b6cefdab}\"     },     \"type\": \"ssh_key\",     \"uuid\": \"{b15b6026-9c02-4626-b4ad-b905f99f763a}\" } ```

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Bitbucket.Rest.Api;
using Itofinity.Bitbucket.Rest.Client;
using Itofinity.Bitbucket.Rest.Model;

namespace Example
{
    public class UsersUsernameSshKeysGetExample
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

            var apiInstance = new SshApi();
            var username = username_example;  // string | The account's username or UUID.
            var key_id = key_id_example;  // string | The SSH key's UUID value.

            try
            {
                SshAccountKey result = apiInstance.UsersUsernameSshKeysGet(username, key_id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SshApi.UsersUsernameSshKeysGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**| The account&#39;s username or UUID. | 
 **key_id** | **string**| The SSH key&#39;s UUID value. | 

### Return type

[**SshAccountKey**](SshAccountKey.md)

### Authorization

[api_key](../README.md#api_key), [basic](../README.md#basic), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersusernamesshkeysget_0"></a>
# **UsersUsernameSshKeysGet_0**
> PaginatedSshUserKeys UsersUsernameSshKeysGet_0 (string username)



Returns a paginated list of the user's SSH public keys.  Example:  ``` $ curl https://api.bitbucket.org/2.0/users/markadams-atl/ssh-keys {     \"page\": 1,     \"pagelen\": 10,     \"size\": 1,     \"values\": [         {             \"comment\": \"user@myhost\",             \"created_on\": \"2018-03-14T13:17:05.196003+00:00\",             \"key\": \"ssh-ed25519 AAAAC3NzaC1lZDI1NTE5AAAAIKqP3Cr632C2dNhhgKVcon4ldUSAeKiku2yP9O9/bDtY\",             \"label\": \"\",             \"last_used\": \"2018-03-20T13:18:05.196003+00:00\",             \"links\": {                 \"self\": {                     \"href\": \"https://api.bitbucket.org/2.0/users/markadams-atl/ssh-keys/b15b6026-9c02-4626-b4ad-b905f99f763a\"                 }             },             \"owner\": {                 \"display_name\": \"Mark Adams\",                 \"links\": {                     \"avatar\": {                         \"href\": \"https://bitbucket.org/account/markadams-atl/avatar/32/\"                     },                     \"html\": {                         \"href\": \"https://bitbucket.org/markadams-atl/\"                     },                     \"self\": {                         \"href\": \"https://api.bitbucket.org/2.0/users/markadams-atl\"                     }                 },                 \"type\": \"user\",                 \"username\": \"markadams-atl\",                 \"nickname\": \"markadams-atl\",                 \"uuid\": \"{d7dd0e2d-3994-4a50-a9ee-d260b6cefdab}\"             },             \"type\": \"ssh_key\",             \"uuid\": \"{b15b6026-9c02-4626-b4ad-b905f99f763a}\"         }     ] } ```

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Bitbucket.Rest.Api;
using Itofinity.Bitbucket.Rest.Client;
using Itofinity.Bitbucket.Rest.Model;

namespace Example
{
    public class UsersUsernameSshKeysGet_0Example
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

            var apiInstance = new SshApi();
            var username = username_example;  // string | The account's username or UUID.

            try
            {
                PaginatedSshUserKeys result = apiInstance.UsersUsernameSshKeysGet_0(username);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SshApi.UsersUsernameSshKeysGet_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**| The account&#39;s username or UUID. | 

### Return type

[**PaginatedSshUserKeys**](PaginatedSshUserKeys.md)

### Authorization

[api_key](../README.md#api_key), [basic](../README.md#basic), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersusernamesshkeyspost"></a>
# **UsersUsernameSshKeysPost**
> SshAccountKey UsersUsernameSshKeysPost (string username, SshAccountKey _body = null)



Adds a new SSH public key to the specified user account and returns the resulting key.  Example: ``` $ curl -X POST -H \"Content-Type: application/json\" -d '{\"key\": \"ssh-ed25519 AAAAC3NzaC1lZDI1NTE5AAAAIKqP3Cr632C2dNhhgKVcon4ldUSAeKiku2yP9O9/bDtY user@myhost\"}' https://api.bitbucket.org/2.0/users/markadams-atl/ssh-keys  {     \"comment\": \"user@myhost\",     \"created_on\": \"2018-03-14T13:17:05.196003+00:00\",     \"key\": \"ssh-ed25519 AAAAC3NzaC1lZDI1NTE5AAAAIKqP3Cr632C2dNhhgKVcon4ldUSAeKiku2yP9O9/bDtY\",     \"label\": \"\",     \"last_used\": \"2018-03-20T13:18:05.196003+00:00\",     \"links\": {         \"self\": {             \"href\": \"https://api.bitbucket.org/2.0/users/markadams-atl/ssh-keys/b15b6026-9c02-4626-b4ad-b905f99f763a\"         }     },     \"owner\": {         \"display_name\": \"Mark Adams\",         \"links\": {             \"avatar\": {                 \"href\": \"https://bitbucket.org/account/markadams-atl/avatar/32/\"             },             \"html\": {                 \"href\": \"https://bitbucket.org/markadams-atl/\"             },             \"self\": {                 \"href\": \"https://api.bitbucket.org/2.0/users/markadams-atl\"             }         },         \"type\": \"user\",         \"username\": \"markadams-atl\",         \"nickname\": \"markadams-atl\",         \"uuid\": \"{d7dd0e2d-3994-4a50-a9ee-d260b6cefdab}\"     },     \"type\": \"ssh_key\",     \"uuid\": \"{b15b6026-9c02-4626-b4ad-b905f99f763a}\" } ```

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Bitbucket.Rest.Api;
using Itofinity.Bitbucket.Rest.Client;
using Itofinity.Bitbucket.Rest.Model;

namespace Example
{
    public class UsersUsernameSshKeysPostExample
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

            var apiInstance = new SshApi();
            var username = username_example;  // string | The account's username or UUID.
            var _body = new SshAccountKey(); // SshAccountKey | The new SSH key object (optional) 

            try
            {
                SshAccountKey result = apiInstance.UsersUsernameSshKeysPost(username, _body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SshApi.UsersUsernameSshKeysPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**| The account&#39;s username or UUID. | 
 **_body** | [**SshAccountKey**](SshAccountKey.md)| The new SSH key object | [optional] 

### Return type

[**SshAccountKey**](SshAccountKey.md)

### Authorization

[api_key](../README.md#api_key), [basic](../README.md#basic), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersusernamesshkeysput"></a>
# **UsersUsernameSshKeysPut**
> SshAccountKey UsersUsernameSshKeysPut (string username, string key_id, SshAccountKey _body = null)



Updates a specific SSH public key on a user's account  Note: Only the 'comment' field can be updated using this API. To modify the key or comment values, you must delete and add the key again.  Example: ``` $ curl -X PUT -H \"Content-Type: application/json\" -d '{\"label\": \"Work key\"}' https://api.bitbucket.org/2.0/users/markadams-atl/ssh-keys/{b15b6026-9c02-4626-b4ad-b905f99f763a}  {     \"comment\": \"\",     \"created_on\": \"2018-03-14T13:17:05.196003+00:00\",     \"key\": \"ssh-ed25519 AAAAC3NzaC1lZDI1NTE5AAAAIKqP3Cr632C2dNhhgKVcon4ldUSAeKiku2yP9O9/bDtY\",     \"label\": \"Work key\",     \"last_used\": \"2018-03-20T13:18:05.196003+00:00\",     \"links\": {         \"self\": {             \"href\": \"https://api.bitbucket.org/2.0/users/markadams-atl/ssh-keys/b15b6026-9c02-4626-b4ad-b905f99f763a\"         }     },     \"owner\": {         \"display_name\": \"Mark Adams\",         \"links\": {             \"avatar\": {                 \"href\": \"https://bitbucket.org/account/markadams-atl/avatar/32/\"             },             \"html\": {                 \"href\": \"https://bitbucket.org/markadams-atl/\"             },             \"self\": {                 \"href\": \"https://api.bitbucket.org/2.0/users/markadams-atl\"             }         },         \"type\": \"user\",         \"username\": \"markadams-atl\",         \"nickname\": \"markadams-atl\",         \"uuid\": \"{d7dd0e2d-3994-4a50-a9ee-d260b6cefdab}\"     },     \"type\": \"ssh_key\",     \"uuid\": \"{b15b6026-9c02-4626-b4ad-b905f99f763a}\" } ```

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Bitbucket.Rest.Api;
using Itofinity.Bitbucket.Rest.Client;
using Itofinity.Bitbucket.Rest.Model;

namespace Example
{
    public class UsersUsernameSshKeysPutExample
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

            var apiInstance = new SshApi();
            var username = username_example;  // string | The account's username or UUID.
            var key_id = key_id_example;  // string | The SSH key's UUID value.
            var _body = new SshAccountKey(); // SshAccountKey | The updated SSH key object (optional) 

            try
            {
                SshAccountKey result = apiInstance.UsersUsernameSshKeysPut(username, key_id, _body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SshApi.UsersUsernameSshKeysPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**| The account&#39;s username or UUID. | 
 **key_id** | **string**| The SSH key&#39;s UUID value. | 
 **_body** | [**SshAccountKey**](SshAccountKey.md)| The updated SSH key object | [optional] 

### Return type

[**SshAccountKey**](SshAccountKey.md)

### Authorization

[api_key](../README.md#api_key), [basic](../README.md#basic), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

