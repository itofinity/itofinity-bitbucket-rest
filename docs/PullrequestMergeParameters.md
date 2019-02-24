# Itofinity.Bitbucket.Rest.Model.PullrequestMergeParameters
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** |  | 
**Message** | **string** | The commit message that will be used on the resulting commit. | [optional] 
**CloseSourceBranch** | **bool?** | Whether the source branch should be deleted. If this is not provided, we fallback to the value used when the pull request was created, which defaults to False | [optional] 
**MergeStrategy** | **string** | The merge strategy that will be used to merge the pull request. | [optional] [default to MergeStrategyEnum.Mergecommit]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

