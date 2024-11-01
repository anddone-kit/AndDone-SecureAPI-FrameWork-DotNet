# SecureTokenLinkByIdResponseTimeLineInner


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**id** | **str** |  | [optional] 
**token_link_id** | **str** |  | [optional] 
**merchant_id** | **str** |  | [optional] 
**payment_link_type** | **str** |  | [optional] 
**link_status** | **str** |  | [optional] 
**token_link_status** | **str** |  | [optional] 
**event_date** | **str** |  | [optional] 

## Example

```python
from openapi_client.models.secure_token_link_by_id_response_time_line_inner import SecureTokenLinkByIdResponseTimeLineInner

# TODO update the JSON string below
json = "{}"
# create an instance of SecureTokenLinkByIdResponseTimeLineInner from a JSON string
secure_token_link_by_id_response_time_line_inner_instance = SecureTokenLinkByIdResponseTimeLineInner.from_json(json)
# print the JSON string representation of the object
print(SecureTokenLinkByIdResponseTimeLineInner.to_json())

# convert the object into a dict
secure_token_link_by_id_response_time_line_inner_dict = secure_token_link_by_id_response_time_line_inner_instance.to_dict()
# create an instance of SecureTokenLinkByIdResponseTimeLineInner from a dict
secure_token_link_by_id_response_time_line_inner_from_dict = SecureTokenLinkByIdResponseTimeLineInner.from_dict(secure_token_link_by_id_response_time_line_inner_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


