# PFEndorsementRequestQuoteCommunication


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**insured_e_sign_completion_url** | **str** |  | [optional] 
**payment_portal_cancel_redirect_url** | **str** |  | [optional] 
**payment_portal_decline_offer_redirect_url** | **bool** |  | [optional] 
**return_insured_e_sign_url** | **bool** |  | [optional] 
**e_sign_auto_start** | **bool** |  | [optional] 
**e_sign_start_pick_options** | **bool** |  | [optional] 
**suppress_insured_e_sign_email** | **bool** |  | [optional] 
**has_documents_to_upload** | **bool** |  | [optional] 
**send_email_to_retail_agent** | **bool** |  | [optional] 
**send_welcome_letter_email_to_insured** | **bool** |  | [optional] 

## Example

```python
from openapi_client.models.pf_endorsement_request_quote_communication import PFEndorsementRequestQuoteCommunication

# TODO update the JSON string below
json = "{}"
# create an instance of PFEndorsementRequestQuoteCommunication from a JSON string
pf_endorsement_request_quote_communication_instance = PFEndorsementRequestQuoteCommunication.from_json(json)
# print the JSON string representation of the object
print(PFEndorsementRequestQuoteCommunication.to_json())

# convert the object into a dict
pf_endorsement_request_quote_communication_dict = pf_endorsement_request_quote_communication_instance.to_dict()
# create an instance of PFEndorsementRequestQuoteCommunication from a dict
pf_endorsement_request_quote_communication_from_dict = PFEndorsementRequestQuoteCommunication.from_dict(pf_endorsement_request_quote_communication_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


