# Org.OpenAPITools.Model.PFEndorsementRequestQuotePoliciesInner

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PolicyId** | **string** | This denotes the policy identifier. | 
**Premium** | **decimal** | This denotes the premium amount. | 
**Down** | **decimal** | This denotes the down amount. | [optional] 
**DownPercent** | **decimal** | This denotes the down amount. | [optional] 
**Fee** | **decimal** | This denotes the fee amount. | [optional] 
**Tax** | **decimal** | This denotes the tax amount. | [optional] 
**Number** | **string** | This denotes the policy number. | [optional] 
**Company** | [**PFEndorsementRequestQuotePoliciesInnerCompany**](PFEndorsementRequestQuotePoliciesInnerCompany.md) |  | [optional] 
**Ga** | [**PFEndorsementRequestQuotePoliciesInnerGa**](PFEndorsementRequestQuotePoliciesInnerGa.md) |  | [optional] 
**Broker** | [**PFEndorsementRequestQuotePoliciesInnerGa**](PFEndorsementRequestQuotePoliciesInnerGa.md) |  | [optional] 
**Coverage** | **string** | This denotes the coverage and it is required if adding new policy. | [optional] 
**EffectiveDate** | **string** | This denotes the effective date. | 
**ExpirationDate** | **string** | This denotes the expiration date and it is required if adding new policy. | 
**Term** | **decimal** | This denotes the number of term. | 
**MinimumEarned** | **decimal** | This denotes the minimum Earned amount. | [optional] 
**MinimumEarnedPercent** | **decimal** | This denotes the minimum Earned percent. | [optional] 
**Auditable** | **bool** | This denotes the flag if its auditable or not. | [optional] 
**CancelDays** | **string** | This denotes the cancel days. | [optional] 
**LossPayeeRequested** | **bool** | This denotes the flag of loss payee requested. | [optional] 
**MinimumLiability** | **decimal** | This denotes the minimum laibility. | [optional] 
**MaximumLiability** | **decimal** | This denotes the maximum laibility. | [optional] 
**TotalPayFunding** | [**List&lt;PFEndorsementRequestQuotePoliciesInnerTotalPayFundingInner&gt;**](PFEndorsementRequestQuotePoliciesInnerTotalPayFundingInner.md) |  | [optional] 
**PolicyFee** | [**List&lt;PFEndorsementRequestQuotePoliciesInnerPolicyFeeInner&gt;**](PFEndorsementRequestQuotePoliciesInnerPolicyFeeInner.md) |  | [optional] 
**InvoiceNumber** | **string** | This denotes the invoice number. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

