# Org.OpenAPITools.Model.PaymentRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Token** | **string** |  | [optional] 
**Type** | **string** |  | 
**TransactionCode** | **string** |  | 
**BillingContact** | [**TransactionPaymentResponseBillingContact**](TransactionPaymentResponseBillingContact.md) |  | [optional] 
**PhoneCountryCode** | **string** |  | [optional] 
**ChannelType** | **string** |  | 
**ProcessMethod** | **string** |  | [optional] 
**TenderInfo** | [**PaymentRequestTenderInfo**](PaymentRequestTenderInfo.md) |  | 
**InvoiceNo** | **string** |  | [optional] 
**ReferenceNo** | **string** |  | [optional] 
**PaymentReference** | **string** |  | [optional] 
**Remarks** | **string** |  | [optional] 
**SaveCustomer** | **bool** |  | [optional] 
**CaptchaToken** | **string** |  | [optional] 
**ActionName** | **string** |  | [optional] 
**AdditionalFields** | **Dictionary&lt;string, string&gt;** |  | [optional] 
**Issuer** | **string** |  | [optional] 
**Splits** | [**List&lt;PaymentIntentRequestSplitsInner&gt;**](PaymentIntentRequestSplitsInner.md) |  | [optional] 
**OperationType** | **string** |  | [optional] 
**SuppressTechnologyFee** | **bool** |  | [optional] 
**OverrideTechnologyFee** | **float** |  | [optional] 
**IsPremiumFinancier** | **bool** |  | [optional] 
**Pfr** | [**PaymentIntentRequestPfr**](PaymentIntentRequestPfr.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

