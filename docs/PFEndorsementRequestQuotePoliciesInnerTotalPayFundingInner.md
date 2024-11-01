# PFEndorsementRequestQuotePoliciesInnerTotalPayFundingInner


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**pay_to** | **str** |  | [optional] 
**payment_method** | **str** |  | [optional] 
**funding_type** | **str** |  | [optional] 
**bank_routing_number** | **str** |  | [optional] 
**bank_acct_number** | **str** |  | [optional] 
**is_checking_account** | **bool** |  | [optional] 
**amount** | **float** |  | [optional] 
**funding_date** | **str** |  | [optional] 

## Example

```python
from openapi_client.models.pf_endorsement_request_quote_policies_inner_total_pay_funding_inner import PFEndorsementRequestQuotePoliciesInnerTotalPayFundingInner

# TODO update the JSON string below
json = "{}"
# create an instance of PFEndorsementRequestQuotePoliciesInnerTotalPayFundingInner from a JSON string
pf_endorsement_request_quote_policies_inner_total_pay_funding_inner_instance = PFEndorsementRequestQuotePoliciesInnerTotalPayFundingInner.from_json(json)
# print the JSON string representation of the object
print(PFEndorsementRequestQuotePoliciesInnerTotalPayFundingInner.to_json())

# convert the object into a dict
pf_endorsement_request_quote_policies_inner_total_pay_funding_inner_dict = pf_endorsement_request_quote_policies_inner_total_pay_funding_inner_instance.to_dict()
# create an instance of PFEndorsementRequestQuotePoliciesInnerTotalPayFundingInner from a dict
pf_endorsement_request_quote_policies_inner_total_pay_funding_inner_from_dict = PFEndorsementRequestQuotePoliciesInnerTotalPayFundingInner.from_dict(pf_endorsement_request_quote_policies_inner_total_pay_funding_inner_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


