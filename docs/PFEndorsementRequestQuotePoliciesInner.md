# Org.OpenAPITools.Model.PFEndorsementRequestQuotePoliciesInner

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PolicyId** | **string** | This denotes the policy identifier. | [optional] 
**Premium** | **float** | This denotes the premium amount. | 
**Down** | **float** | This denotes the down amount. | [optional] 
**DownPercent** | **float** | This denotes the down percentage. | [optional] 
**Fee** | **float** | This denotes the fee amount. | [optional] 
**Tax** | **float** | This denotes the tax amount. | [optional] 
**PolicyNumber** | **string** | This denotes the policy number. | [optional] 
**Company** | [**PFEndorsementRequestQuotePoliciesInnerCompany**](PFEndorsementRequestQuotePoliciesInnerCompany.md) |  | [optional] 
**Ga** | [**PFEndorsementRequestQuotePoliciesInnerGa**](PFEndorsementRequestQuotePoliciesInnerGa.md) |  | [optional] 
**Broker** | [**PFEndorsementRequestQuotePoliciesInnerGa**](PFEndorsementRequestQuotePoliciesInnerGa.md) |  | [optional] 
**Coverage** | **string** | This denotes the coverage and it is required if adding new policy. | [optional] 
**EffectiveDate** | **string** | This denotes the effective date. | 
**ExpirationDate** | **string** | This denotes the expiration date and it is required if adding new policy. | 
**Term** | **float** | This denotes the number of terms. | [optional] 
**MinimumEarned** | **float** | This denotes the minimum earned amount. | [optional] 
**MinimumEarnedPercent** | **float** | This denotes the minimum earned percent. | [optional] 
**Auditable** | **bool** | This denotes the flag if it is auditable or not. | [optional] 
**CancelDays** | **string** | This denotes the cancel days. | [optional] 
**LossPayeeRequested** | **bool** | This denotes the flag of loss payee requested. | [optional] 
**MinimumLiability** | **float** | This denotes the minimum liability. | [optional] 
**MaximumLiability** | **float** | This denotes the maximum liability. | [optional] 
**TotalPayFunding** | [**List&lt;PFEndorsementRequestQuotePoliciesInnerTotalPayFundingInner&gt;**](PFEndorsementRequestQuotePoliciesInnerTotalPayFundingInner.md) |  | [optional] 
**PolicyFee** | [**List&lt;PFEndorsementRequestQuotePoliciesInnerPolicyFeeInner&gt;**](PFEndorsementRequestQuotePoliciesInnerPolicyFeeInner.md) |  | [optional] 
**InvoiceNumber** | **string** | This denotes the invoice number. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

