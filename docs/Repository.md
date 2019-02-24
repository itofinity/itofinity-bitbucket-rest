# Itofinity.Bitbucket.Rest.Model.Repository
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** |  | 
**Links** | [**RepositoryLinks**](RepositoryLinks.md) |  | [optional] 
**Uuid** | **string** | The repository&#39;s immutable id. This can be used as a substitute for the slug segment in URLs. Doing this guarantees your URLs will survive renaming of the repository by its owner, or even transfer of the repository to a different user. | [optional] 
**FullName** | **string** | The concatenation of the repository owner&#39;s username and the slugified name, e.g. \&quot;evzijst/interruptingcow\&quot;. This is the same string used in Bitbucket URLs. | [optional] 
**IsPrivate** | **bool?** |  | [optional] 
**Parent** | [**Repository**](Repository.md) |  | [optional] 
**Scm** | **string** |  | [optional] 
**Owner** | [**Account**](Account.md) |  | [optional] 
**Name** | **string** |  | [optional] 
**Description** | **string** |  | [optional] 
**CreatedOn** | **DateTime?** |  | [optional] 
**UpdatedOn** | **DateTime?** |  | [optional] 
**Size** | **int?** |  | [optional] 
**Language** | **string** |  | [optional] 
**HasIssues** | **bool?** |  | [optional] 
**HasWiki** | **bool?** |  | [optional] 
**ForkPolicy** | **string** |  Controls the rules for forking this repository.  * **allow_forks**: unrestricted forking * **no_public_forks**: restrict forking to private forks (forks cannot   be made public later) * **no_forks**: deny all forking  | [optional] 
**Project** | [**Project**](Project.md) |  | [optional] 
**Mainbranch** | [**Branch**](Branch.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

