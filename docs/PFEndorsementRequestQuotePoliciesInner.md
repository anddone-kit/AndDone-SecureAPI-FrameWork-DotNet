# PFEndorsementRequestQuotePoliciesInner


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**policy_id** | **str** | This denotes the policy identifier. | 
**premium** | **float** | This denotes the premium amount. | 
**down** | **float** | This denotes the down amount. | [optional] 
**down_percent** | **float** | This denotes the down percentage. | [optional] 
**fee** | **float** | This denotes the fee amount. | [optional] 
**tax** | **float** | This denotes the tax amount. | [optional] 
**number** | **str** | This denotes the policy number. | [optional] 
**company** | [**PFEndorsementRequestQuotePoliciesInnerCompany**](PFEndorsementRequestQuotePoliciesInnerCompany.md) |  | [optional] 
**ga** | [**PFEndorsementRequestQuotePoliciesInnerGa**](PFEndorsementRequestQuotePoliciesInnerGa.md) |  | [optional] 
**broker** | [**PFEndorsementRequestQuotePoliciesInnerGa**](PFEndorsementRequestQuotePoliciesInnerGa.md) |  | [optional] 
**coverage** | **str** | This denotes the coverage and it is required if adding new policy. | [optional] 
**effective_date** | **str** | This denotes the effective date. | 
**expiration_date** | **str** | This denotes the expiration date and it is required if adding new policy. | 
**term** | **float** | This denotes the number of terms. | 
**minimum_earned** | **float** | This denotes the minimum earned amount. | [optional] 
**minimum_earned_percent** | **float** | This denotes the minimum earned percent. | [optional] 
**auditable** | **bool** | This denotes the flag if it is auditable or not. | [optional] 
**cancel_days** | **str** | This denotes the cancel days. | [optional] 
**loss_payee_requested** | **bool** | This denotes the flag of loss payee requested. | [optional] 
**minimum_liability** | **float** | This denotes the minimum liability. | [optional] 
**maximum_liability** | **float** | This denotes the maximum liability. | [optional] 
**total_pay_funding** | [**List[PFEndorsementRequestQuotePoliciesInnerTotalPayFundingInner]**](PFEndorsementRequestQuotePoliciesInnerTotalPayFundingInner.md) |  | [optional] 
**policy_fee** | [**List[QuoteRequestPoliciesInnerPolicyFeesInner]**](QuoteRequestPoliciesInnerPolicyFeesInner.md) |  | [optional] 
**invoice_number** | **str** | This denotes the invoice number. | [optional] 

## Example

```python
from openapi_client.models.pf_endorsement_request_quote_policies_inner import PFEndorsementRequestQuotePoliciesInner

# TODO update the JSON string below
json = "{}"
# create an instance of PFEndorsementRequestQuotePoliciesInner from a JSON string
pf_endorsement_request_quote_policies_inner_instance = PFEndorsementRequestQuotePoliciesInner.from_json(json)
# print the JSON string representation of the object
print(PFEndorsementRequestQuotePoliciesInner.to_json())

# convert the object into a dict
pf_endorsement_request_quote_policies_inner_dict = pf_endorsement_request_quote_policies_inner_instance.to_dict()
# create an instance of PFEndorsementRequestQuotePoliciesInner from a dict
pf_endorsement_request_quote_policies_inner_from_dict = PFEndorsementRequestQuotePoliciesInner.from_dict(pf_endorsement_request_quote_policies_inner_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


