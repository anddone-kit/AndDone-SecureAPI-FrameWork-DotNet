# Org.OpenAPITools.Model.PaymentLinkRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MerchantId** | **string** |  | 
**Title** | **string** |  | 
**Amount** | **float** |  | 
**PaymentDescription** | **string** |  | [optional] 
**Customers** | [**List&lt;PaymentLinkResponseCustomersInner&gt;**](PaymentLinkResponseCustomersInner.md) |  | [optional] 
**InvoiceNumber** | **string** |  | [optional] 
**ExpireBy** | **float** |  | [optional] 
**ExpireIn** | **int** |  | 
**ExpireInUnit** | **string** |  | 
**ExpireOn** | **string** |  | [optional] 
**LineItems** | [**List&lt;PaymentLinkResponseLineItemsInner&gt;**](PaymentLinkResponseLineItemsInner.md) |  | [optional] 
**ShortDescription** | **string** |  | [optional] 
**ResponseType** | **string** |  | [optional] 
**CallbackParameters** | [**PaymentLinkResponseCallbackParameters**](PaymentLinkResponseCallbackParameters.md) |  | [optional] 
**Settings** | [**PaymentLinkRequestSettings**](PaymentLinkRequestSettings.md) |  | 
**PaymentLinkType** | **string** |  | [optional] 
**SaveForFuture** | **bool** |  | [optional] 
**Splits** | [**List&lt;PaymentIntentRequestSplitsInner&gt;**](PaymentIntentRequestSplitsInner.md) |  | [optional] 
**QuoteKey** | **string** |  | [optional] 
**AccountNumber** | **string** |  | [optional] 
**ReferenceType** | **string** |  | [optional] 
**ReferenceNumber** | **string** |  | [optional] 
**ReferenceKey** | **string** |  | [optional] 
**ReferenceDataList** | [**List&lt;PaymentLinkResponseReferenceDataListInner&gt;**](PaymentLinkResponseReferenceDataListInner.md) |  | 
**EnablePremiumFinance** | **bool** |  | [optional] 
**SuppressTechnologyFee** | **bool** |  | [optional] 
**OverrideTechnologyFee** | **float** |  | [optional] 
**PlatformSettlementStatus** | **string** |  | [optional] 
**IsPayInFull** | **bool** |  | [optional] 
**IsPremiumFinancier** | **bool** |  | [optional] 
**Pfr** | [**PaymentIntentRequestPfr**](PaymentIntentRequestPfr.md) |  | [optional] 
**PfType** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

