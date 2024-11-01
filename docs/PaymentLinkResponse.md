# Org.OpenAPITools.Model.PaymentLinkResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The unique identifier for the payment link. | [optional] 
**MerchantId** | **string** | The merchant identifier associated with the payment link. | [optional] 
**Title** | **string** | The title or name of the payment link. | [optional] 
**PaymentLink** | **string** | The URL for the payment link. | [optional] 
**ShortLink** | **string** | A shortened version of the payment link. | [optional] 
**Amount** | **decimal** | The amount to be paid. | [optional] 
**PaymentDescription** | **string** | A description of the payment. | [optional] 
**ExpireIn** | **int** | The time in units after which the payment link expires. | [optional] 
**ExpireInUnit** | **string** |  | [optional] 
**ExpireOn** | **string** | The exact expiry date of the payment link (ISO 8601 format). | [optional] 
**ApplyPaymentAdjustments** | **bool** | Indicates whether payment adjustments are applied. | [optional] 
**EnablePartialPayment** | **bool** | Indicates whether partial payment is allowed. | [optional] 
**EnableMultiplePayment** | **bool** | Indicates whether multiple payments are allowed. | [optional] 
**NoOfPaymentMade** | **int** | The number of payments made. | [optional] 
**TotalPaidAmount** | **decimal** | The total amount paid so far. | [optional] 
**EnableProtection** | **bool** | Indicates whether protection is enabled. | [optional] 
**ProtectionMode** | **string** |  | [optional] 
**DisplayReceipt** | **bool** | Indicates whether a receipt should be displayed. | [optional] 
**LinkStatus** | **string** |  | [optional] 
**InvoiceNumber** | **string** | The invoice number associated with the payment link. | [optional] 
**CreatedOn** | **string** | The date and time when the payment link was created (ISO 8601 format). | [optional] 
**CreatedBy** | **string** | The identifier of the user who created the payment link. | [optional] 
**ModifiedOn** | **string** | The date and time when the payment link was last modified (ISO 8601 format). | [optional] 
**ModifiedBy** | **string** | The identifier of the user who last modified the payment link. | [optional] 
**ShortDescription** | **string** | A brief description of the payment link. | [optional] 
**ResponseType** | **string** |  | [optional] 
**CallbackParameters** | [**PaymentLinkResponseCallbackParameters**](PaymentLinkResponseCallbackParameters.md) |  | [optional] 
**DisplaySettings** | [**PaymentLinkResponseDisplaySettings**](PaymentLinkResponseDisplaySettings.md) |  | [optional] 
**Splits** | [**List&lt;PaymentLinkResponseSplitsInner&gt;**](PaymentLinkResponseSplitsInner.md) |  | [optional] 
**SaveForFuture** | **bool** |  | [optional] 
**QuoteKey** | **string** |  | [optional] 
**AccountNumber** | **string** |  | [optional] 
**ReferenceType** | **string** |  | [optional] 
**ReferenceNumber** | **string** |  | [optional] 
**ReferenceKey** | **string** |  | [optional] 
**ReferenceDataList** | [**List&lt;PaymentLinkResponseReferenceDataListInner&gt;**](PaymentLinkResponseReferenceDataListInner.md) |  | [optional] 
**EnablePremiumFinance** | **bool** |  | [optional] 
**SuppressTechnologyFee** | **bool** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

