# Itofinity.Bitbucket.Rest.Model.Branchrestriction
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** |  | 
**Links** | [**EmailAddressLinks**](EmailAddressLinks.md) |  | [optional] 
**Id** | **int?** | The branch restriction status&#39; id. | [optional] 
**Kind** | **string** | The type of restriction that is being applied | [optional] 
**Users** | [**List&lt;Account&gt;**](Account.md) |  | [optional] 
**Groups** | [**List&lt;Group&gt;**](Group.md) |  | [optional] 
**Value** | **int?** | Value with kind-specific semantics: \&quot;require_approvals_to_merge\&quot; uses it to require a minimum number of approvals on a PR; \&quot;require_passing_builds_to_merge\&quot; uses it to require a minimum number of passing builds. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

