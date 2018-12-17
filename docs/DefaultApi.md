# Itofinity.Bitbucket.Refit.Api.DefaultApi

All URIs are relative to *https://api.localhost:8000/2.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**RepositoriesUsernameRepoSlugDiffstatSpecGet**](DefaultApi.md#repositoriesusernamereposlugdiffstatspecget) | **Get** /repositories/{username}/{repo_slug}/diffstat/{spec} | 
[**TeamsUsernamePermissionsGet**](DefaultApi.md#teamsusernamepermissionsget) | **Get** /teams/{username}/permissions | 
[**TeamsUsernamePermissionsRepositoriesGet**](DefaultApi.md#teamsusernamepermissionsrepositoriesget) | **Get** /teams/{username}/permissions/repositories | 
[**UserPermissionsTeamsGet**](DefaultApi.md#userpermissionsteamsget) | **Get** /user/permissions/teams | 


<a name="repositoriesusernamereposlugdiffstatspecget"></a>
# **RepositoriesUsernameRepoSlugDiffstatSpecGet**
> PaginatedDiffstats RepositoriesUsernameRepoSlugDiffstatSpecGet (string username, string repo_slug, string spec, bool? ignore_whitespace = null)



Returns the diff stat for the specified commit.  Diff stat responses contain a record for every path modified by the commit and lists the number of lines added and removed for each file.   Example: ``` curl https://api.bitbucket.org/2.0/repositories/bitbucket/geordi/diffstat/d222fa2..e174964 {     \"pagelen\": 500,     \"values\": [         {             \"type\": \"diffstat\",             \"status\": \"modified\",             \"lines_removed\": 1,             \"lines_added\": 2,             \"old\": {                 \"path\": \"setup.py\",                 \"type\": \"commit_file\",                 \"links\": {                     \"self\": {                         \"href\": \"https://api.bitbucket.org/2.0/repositories/bitbucket/geordi/src/e1749643d655d7c7014001a6c0f58abaf42ad850/setup.py\"                     }                 }             },             \"new\": {                 \"path\": \"setup.py\",                 \"type\": \"commit_file\",                 \"links\": {                     \"self\": {                         \"href\": \"https://api.bitbucket.org/2.0/repositories/bitbucket/geordi/src/d222fa235229c55dad20b190b0b571adf737d5a6/setup.py\"                     }                 }             }         }     ],     \"page\": 1,     \"size\": 1 } ```

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Bitbucket.Refit.Api;
using Itofinity.Bitbucket.Refit.Client;
using Itofinity.Bitbucket.Refit.Model;

namespace Example
{
    public class RepositoriesUsernameRepoSlugDiffstatSpecGetExample
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

            var apiInstance = new DefaultApi();
            var username = username_example;  // string | This can either be the username or the UUID of the account, surrounded by curly-braces, for example: `{account UUID}`. An account is either a team or user. 
            var repo_slug = repo_slug_example;  // string | This can either be the repository slug or the UUID of the repository, surrounded by curly-braces, for example: `{repository UUID}`. 
            var spec = spec_example;  // string | A commit SHA (e.g. `3a8b42`) or a commit range using double dot notation (e.g. `3a8b42..9ff173`). 
            var ignore_whitespace = true;  // bool? | Generate diffs that ignore whitespace (optional) 

            try
            {
                PaginatedDiffstats result = apiInstance.RepositoriesUsernameRepoSlugDiffstatSpecGet(username, repo_slug, spec, ignore_whitespace);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.RepositoriesUsernameRepoSlugDiffstatSpecGet: " + e.Message );
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
 **spec** | **string**| A commit SHA (e.g. &#x60;3a8b42&#x60;) or a commit range using double dot notation (e.g. &#x60;3a8b42..9ff173&#x60;).  | 
 **ignore_whitespace** | **bool?**| Generate diffs that ignore whitespace | [optional] 

### Return type

[**PaginatedDiffstats**](PaginatedDiffstats.md)

### Authorization

[api_key](../README.md#api_key), [basic](../README.md#basic), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsusernamepermissionsget"></a>
# **TeamsUsernamePermissionsGet**
> PaginatedTeamPermissions TeamsUsernamePermissionsGet (string username, string q = null, string sort = null)



Returns an object for each team permission a user on the team has.  Permissions returned are effective permissions — if a user is a member of multiple groups with distinct roles, only the highest level is returned.  Permissions can be:  * `admin` * `collaborator`  Only users with admin permission for the team may access this resource.  Example:  ``` $ curl https://api.bitbucket.org/2.0/teams/atlassian_tutorial/permissions  {   \"pagelen\": 10,   \"values\": [     {       \"permission\": \"admin\",       \"type\": \"team_permission\",       \"user\": {         \"type\": \"user\",         \"username\": \"evzijst\",         \"nickname\": \"evzijst\",         \"display_name\": \"Erik van Zijst\",         \"uuid\": \"{d301aafa-d676-4ee0-88be-962be7417567}\"       },       \"team\": {         \"username\": \"bitbucket\",         \"display_name\": \"Atlassian Bitbucket\",         \"uuid\": \"{4cc6108a-a241-4db0-96a5-64347ac04f87}\"       }     },     {       \"permission\": \"collaborator\",       \"type\": \"team_permission\",       \"user\": {         \"type\": \"user\",         \"username\": \"seanaty\",         \"nickname\": \"seanaty\",         \"display_name\": \"Sean Conaty\",         \"uuid\": \"{504c3b62-8120-4f0c-a7bc-87800b9d6f70}\"       },       \"team\": {         \"username\": \"bitbucket\",         \"display_name\": \"Atlassian Bitbucket\",         \"uuid\": \"{4cc6108a-a241-4db0-96a5-64347ac04f87}\"       }     }   ],   \"page\": 1,   \"size\": 2 } ```  Results may be further [filtered or sorted](../../../meta/filtering) by team, user, or permission by adding the following query string parameters:  * `q=user.username=\"evzijst\"` or `q=permission=\"admin\"` * `sort=team.display_name`  Note that the query parameter values need to be URL escaped so that `=` would become `%3D`.

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Bitbucket.Refit.Api;
using Itofinity.Bitbucket.Refit.Client;
using Itofinity.Bitbucket.Refit.Model;

namespace Example
{
    public class TeamsUsernamePermissionsGetExample
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

            var apiInstance = new DefaultApi();
            var username = username_example;  // string | This can either be the username or the UUID of the account, surrounded by curly-braces, for example: `{account UUID}`. An account is either a team or user. 
            var q = q_example;  // string |  Query string to narrow down the response as per [filtering and sorting](../../../meta/filtering). (optional) 
            var sort = sort_example;  // string |  Name of a response property sort the result by as per [filtering and sorting](../../../meta/filtering#query-sort).  (optional) 

            try
            {
                PaginatedTeamPermissions result = apiInstance.TeamsUsernamePermissionsGet(username, q, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.TeamsUsernamePermissionsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**| This can either be the username or the UUID of the account, surrounded by curly-braces, for example: &#x60;{account UUID}&#x60;. An account is either a team or user.  | 
 **q** | **string**|  Query string to narrow down the response as per [filtering and sorting](../../../meta/filtering). | [optional] 
 **sort** | **string**|  Name of a response property sort the result by as per [filtering and sorting](../../../meta/filtering#query-sort).  | [optional] 

### Return type

[**PaginatedTeamPermissions**](PaginatedTeamPermissions.md)

### Authorization

[api_key](../README.md#api_key), [basic](../README.md#basic), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsusernamepermissionsrepositoriesget"></a>
# **TeamsUsernamePermissionsRepositoriesGet**
> PaginatedRepositoryPermissions TeamsUsernamePermissionsRepositoriesGet (string username, string q = null, string sort = null)



Returns an object for each repository permission for all of a team’s repositories.  If the username URL parameter refers to a user account instead of a team account, an object containing the repository permissions of all the username's repositories will be returned.  Permissions returned are effective permissions — the highest level of permission the user has. This does not include public repositories that users are not granted any specific permission in, and does not distinguish between direct and indirect privileges.  Only users with admin permission for the team may access this resource.  Permissions can be:  * `admin` * `write` * `read`  Example:  ``` $ curl https://api.bitbucket.org/2.0/teams/atlassian_tutorial/permissions/repositories  {   \"pagelen\": 10,   \"values\": [     {       \"type\": \"repository_permission\",       \"user\": {         \"type\": \"user\",         \"username\": \"evzijst\",         \"display_name\": \"Erik van Zijst\",         \"uuid\": \"{d301aafa-d676-4ee0-88be-962be7417567}\"       },       \"repository\": {         \"type\": \"repository\",         \"name\": \"geordi\",         \"full_name\": \"bitbucket/geordi\",         \"uuid\": \"{85d08b4e-571d-44e9-a507-fa476535aa98}\"       },       \"permission\": \"admin\"     },     {       \"type\": \"repository_permission\",       \"user\": {         \"type\": \"user\",         \"username\": \"seanaty\",         \"display_name\": \"Sean Conaty\",         \"uuid\": \"{504c3b62-8120-4f0c-a7bc-87800b9d6f70}\"       },       \"repository\": {         \"type\": \"repository\",         \"name\": \"geordi\",         \"full_name\": \"bitbucket/geordi\",         \"uuid\": \"{85d08b4e-571d-44e9-a507-fa476535aa98}\"       },       \"permission\": \"write\"     }   ],   \"page\": 1,   \"size\": 2 } ```  Results may be further [filtered or sorted](../../../../meta/filtering) by repository, user, or permission by adding the following query string parameters:  * `q=repository.name=\"geordi\"` or `q=permission>\"read\"` * `sort=user.display_name`  Note that the query parameter values need to be URL escaped so that `=` would become `%3D`.

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Bitbucket.Refit.Api;
using Itofinity.Bitbucket.Refit.Client;
using Itofinity.Bitbucket.Refit.Model;

namespace Example
{
    public class TeamsUsernamePermissionsRepositoriesGetExample
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

            var apiInstance = new DefaultApi();
            var username = username_example;  // string | This can either be the username or the UUID of the account, surrounded by curly-braces, for example: `{account UUID}`. An account is either a team or user. 
            var q = q_example;  // string |  Query string to narrow down the response as per [filtering and sorting](../../../../meta/filtering). (optional) 
            var sort = sort_example;  // string |  Name of a response property sort the result by as per [filtering and sorting](../../../../meta/filtering#query-sort).  (optional) 

            try
            {
                PaginatedRepositoryPermissions result = apiInstance.TeamsUsernamePermissionsRepositoriesGet(username, q, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.TeamsUsernamePermissionsRepositoriesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**| This can either be the username or the UUID of the account, surrounded by curly-braces, for example: &#x60;{account UUID}&#x60;. An account is either a team or user.  | 
 **q** | **string**|  Query string to narrow down the response as per [filtering and sorting](../../../../meta/filtering). | [optional] 
 **sort** | **string**|  Name of a response property sort the result by as per [filtering and sorting](../../../../meta/filtering#query-sort).  | [optional] 

### Return type

[**PaginatedRepositoryPermissions**](PaginatedRepositoryPermissions.md)

### Authorization

[api_key](../README.md#api_key), [basic](../README.md#basic), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userpermissionsteamsget"></a>
# **UserPermissionsTeamsGet**
> PaginatedTeamPermissions UserPermissionsTeamsGet (string q = null, string sort = null)



Returns an object for each team the caller is a member of, and their effective role — the highest level of privilege the caller has. If a user is a member of multiple groups with distinct roles, only the highest level is returned.  Permissions can be:  * `admin` * `collaborator`  Example:  ``` $ curl https://api.bitbucket.org/2.0/user/permissions/teams  {   \"pagelen\": 10,   \"values\": [     {       \"permission\": \"admin\",       \"type\": \"team_permission\",       \"user\": {         \"type\": \"user\",         \"username\": \"evzijst\",         \"nickname\": \"evzijst\",         \"display_name\": \"Erik van Zijst\",         \"uuid\": \"{d301aafa-d676-4ee0-88be-962be7417567}\"       },       \"team\": {         \"username\": \"bitbucket\",         \"display_name\": \"Atlassian Bitbucket\",         \"uuid\": \"{4cc6108a-a241-4db0-96a5-64347ac04f87}\"       }     }   ],   \"page\": 1,   \"size\": 1 } ```  Results may be further [filtered or sorted](../../../meta/filtering) by team or permission by adding the following query string parameters:  * `q=team.username=\"bitbucket\"` or `q=permission=\"admin\"` * `sort=team.display_name`  Note that the query parameter values need to be URL escaped so that `=` would become `%3D`.

### Example
```csharp
using System;
using System.Diagnostics;
using Itofinity.Bitbucket.Refit.Api;
using Itofinity.Bitbucket.Refit.Client;
using Itofinity.Bitbucket.Refit.Model;

namespace Example
{
    public class UserPermissionsTeamsGetExample
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

            var apiInstance = new DefaultApi();
            var q = q_example;  // string |  Query string to narrow down the response as per [filtering and sorting](../../../meta/filtering). (optional) 
            var sort = sort_example;  // string |  Name of a response property sort the result by as per [filtering and sorting](../../../meta/filtering#query-sort).  (optional) 

            try
            {
                PaginatedTeamPermissions result = apiInstance.UserPermissionsTeamsGet(q, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.UserPermissionsTeamsGet: " + e.Message );
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

[**PaginatedTeamPermissions**](PaginatedTeamPermissions.md)

### Authorization

[api_key](../README.md#api_key), [basic](../README.md#basic), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

