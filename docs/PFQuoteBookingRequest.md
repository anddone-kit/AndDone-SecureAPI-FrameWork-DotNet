# PFQuoteBookingRequest


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**quote_key** | **float** |  | [optional] 
**merchant_token** | **str** |  | [optional] 

## Example

```python
from openapi_client.models.pf_quote_booking_request import PFQuoteBookingRequest

# TODO update the JSON string below
json = "{}"
# create an instance of PFQuoteBookingRequest from a JSON string
pf_quote_booking_request_instance = PFQuoteBookingRequest.from_json(json)
# print the JSON string representation of the object
print(PFQuoteBookingRequest.to_json())

# convert the object into a dict
pf_quote_booking_request_dict = pf_quote_booking_request_instance.to_dict()
# create an instance of PFQuoteBookingRequest from a dict
pf_quote_booking_request_from_dict = PFQuoteBookingRequest.from_dict(pf_quote_booking_request_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


