# PaymentLinkResponseCallbackParameters


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**callback_success_url** | **str** |  | [optional] 
**callback_failure_url** | **str** |  | [optional] 
**access_key** | **str** |  | [optional] 
**secret_key** | **str** |  | [optional] 
**reference_no** | **str** |  | [optional] 
**reference_type** | **str** |  | [optional] 
**transaction_id** | **str** |  | [optional] 
**callback_api_url** | **str** |  | [optional] 
**callback_message** | **str** |  | [optional] 
**redirection_time** | **int** |  | [optional] 

## Example

```python
from openapi_client.models.payment_link_response_callback_parameters import PaymentLinkResponseCallbackParameters

# TODO update the JSON string below
json = "{}"
# create an instance of PaymentLinkResponseCallbackParameters from a JSON string
payment_link_response_callback_parameters_instance = PaymentLinkResponseCallbackParameters.from_json(json)
# print the JSON string representation of the object
print(PaymentLinkResponseCallbackParameters.to_json())

# convert the object into a dict
payment_link_response_callback_parameters_dict = payment_link_response_callback_parameters_instance.to_dict()
# create an instance of PaymentLinkResponseCallbackParameters from a dict
payment_link_response_callback_parameters_from_dict = PaymentLinkResponseCallbackParameters.from_dict(payment_link_response_callback_parameters_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


