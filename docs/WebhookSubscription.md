# Itofinity.Bitbucket.Rest.Model.WebhookSubscription
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** |  | 
**Uuid** | **string** | The webhook&#39;s id | [optional] 
**Url** | **string** | The URL events get delivered to. | [optional] 
**Description** | **string** | A user-defined description of the webhook. | [optional] 
**SubjectType** | **string** | The type of entity, which is &#x60;repository&#x60; in the case of webhook subscriptions on repositories. | [optional] 
**Subject** | **Object** |  | [optional] 
**Active** | **bool?** |  | [optional] 
**CreatedAt** | **DateTime?** |  | [optional] 
**Events** | **List&lt;string&gt;** | The events this webhook is subscribed to. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

