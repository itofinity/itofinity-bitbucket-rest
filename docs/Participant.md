# Itofinity.Bitbucket.Refit.Model.Participant
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** |  | 
**User** | [**User**](User.md) |  | [optional] 
**Role** | **string** |  | [optional] 
**Approved** | **bool?** |  | [optional] 
**ParticipatedOn** | **DateTime?** | The ISO8601 timestamp of the participant&#39;s action. For approvers, this is the time of their approval. For commenters and pull request reviewers who are not approvers, this is the time they last commented, or null if they have not commented. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

