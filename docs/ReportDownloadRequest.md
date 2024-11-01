# ReportDownloadRequest


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**report_id** | **str** |  | [optional] 
**report_generation_log_id** | **str** |  | [optional] 
**file_compress** | **bool** |  | [optional] 
**var_date** | **str** |  | [optional] 

## Example

```python
from openapi_client.models.report_download_request import ReportDownloadRequest

# TODO update the JSON string below
json = "{}"
# create an instance of ReportDownloadRequest from a JSON string
report_download_request_instance = ReportDownloadRequest.from_json(json)
# print the JSON string representation of the object
print(ReportDownloadRequest.to_json())

# convert the object into a dict
report_download_request_dict = report_download_request_instance.to_dict()
# create an instance of ReportDownloadRequest from a dict
report_download_request_from_dict = ReportDownloadRequest.from_dict(report_download_request_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


