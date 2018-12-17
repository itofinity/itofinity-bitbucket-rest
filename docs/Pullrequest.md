# Itofinity.Bitbucket.Refit.Model.Pullrequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** |  | 
**Links** | [**PullrequestLinks**](PullrequestLinks.md) |  | [optional] 
**Id** | **int?** | The pull request&#39;s unique ID. Note that pull request IDs are only unique within their associated repository. | [optional] 
**Title** | **string** | Title of the pull request. | [optional] 
**Rendered** | [**PullrequestRendered**](PullrequestRendered.md) |  | [optional] 
**Summary** | [**CommentContent**](CommentContent.md) |  | [optional] 
**State** | **string** | The pull request&#39;s current status. | [optional] 
**Author** | [**Account**](Account.md) |  | [optional] 
**Source** | [**PullrequestEndpoint**](PullrequestEndpoint.md) |  | [optional] 
**Destination** | [**PullrequestEndpoint**](PullrequestEndpoint.md) |  | [optional] 
**MergeCommit** | [**PullrequestEndpointCommit**](PullrequestEndpointCommit.md) |  | [optional] 
**CommentCount** | **int?** | The number of comments for a specific pull request. | [optional] 
**TaskCount** | **int?** | The number of open tasks for a specific pull request. | [optional] 
**CloseSourceBranch** | **bool?** | A boolean flag indicating if merging the pull request closes the source branch. | [optional] 
**ClosedBy** | [**Account**](Account.md) |  | [optional] 
**Reason** | **string** | Explains why a pull request was declined. This field is only applicable to pull requests in rejected state. | [optional] 
**CreatedOn** | **DateTime?** | The ISO8601 timestamp the request was created. | [optional] 
**UpdatedOn** | **DateTime?** | The ISO8601 timestamp the request was last updated. | [optional] 
**Reviewers** | [**List&lt;Account&gt;**](Account.md) | The list of users that were added as reviewers on this pull request when it was created. For performance reasons, the API only includes this list on a pull request&#39;s &#x60;self&#x60; URL. | [optional] 
**Participants** | [**List&lt;Participant&gt;**](Participant.md) |         The list of users that are collaborating on this pull request.         Collaborators are user that:          * are added to the pull request as a reviewer (part of the reviewers           list)         * are not explicit reviewers, but have commented on the pull request         * are not explicit reviewers, but have approved the pull request          Each user is wrapped in an object that indicates the user&#39;s role and         whether they have approved the pull request. For performance reasons,         the API only returns this list when an API requests a pull request by         id.          | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

