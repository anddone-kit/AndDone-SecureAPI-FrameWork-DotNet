# AndDone Framework - DotNet

This project serves as a sample installation of a project utilizing **AndDone's DotNet client library** to integrate 
with our APIs.

By following the instructions below, you will be able to see our API endpoints in action quickly.

- **Base DotNet Client Library**: [AndDone-SecureAPI-ClientLibrary-DotNet](https://github.com/anddone-kit/AndDone-SecureAPI-ClientLibrary-DotNet)  
- **Developer Documentation**: [DevDocs](https://docs.anddone.com/)  
- **API Explorer**: [AndDone API Explorer](https://docs.anddone.com/explorer/)

---

## ✅ Prerequisites

- **.Net 8 SDK Runtime**
[Download .NET 8](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)

Or

- **.Net Standard2.0 Runtime**
[Download .NET Core 2.0](https://dotnet.microsoft.com/en-us/download/dotnet/2.0)

## Installation

1. Open a Powershell window
2. Create a new folder in the workspace folder of choice (ex: d:\workspace\anddone)
```sh
cd d:\workspace
mkdir anddone
```
4. Change to the new folder
```sh
cd anddone
```
5. Clone the repository
```sh
git clone https://github.com/anddone-kit/AndDone-SecureAPI-FrameWork-DotNet.git
````
6. Change to the project folder
```sh
cd anddone-dotnet-sdk-sample-installation
```
7. Restore packages and Build Solution
```sh
dotnet build APISample.sln -c Release --property WarningLevel=0
```

## Getting Started
1. Find and note your company AndDone Developer settings.
   1. Login to (UAT) https://portal.uat.anddone.com/   (Production) https://portal.anddone.com/
   2. In the left menu, click "Developer" then "API Keys"
   3. Your xApiKey will be the API Key
   4. Your xAppKey will be the App Key
2. You will need to register your Origin with us to execute API calls against our Secure endpoints.
   1. Typically, we use your domain for production or other hosted environments and IP address for local development environments.
   2. Contact AndDone support (integrations@anddone.com) or your onboarding agent to ensure all your domains or IP addresses you may use are registered for use with our secure APIs.
3. Create a settings file to contain AndDone specific settings
```sh
cd src\APISample\bin\Release\net8.0-windows
```
4. Using your favorite editor, create a file "appsettings.json"
5. COpy below into the "appsettings.json" and enter the xAPIKey, xAPPKey and Origin to the values to match your company settings.  Do not modify the BasePath or xVersion settings.  Save the settings and close the file.
```sh
{
  "Settings": {
    "BasePath": "https://api.uat.anddone.com",
    "BasePath2": "https://api2.uat.anddone.com",
    "xApiKey": "",
    "xAppKey": "",
    "xVersion": "2.3",
    "Origin": ""
  }
}
```

## Running the Sample API Application
1. In Powershell, make sure you are in the folder d:\workspace\anddone\anddone-dotnet-sdk-sample-isntallation\src\APISample\bin\Release\net8.0-windows
2. Enter the following command:
```sh
.\APISample.exe
```
3. You should see a screen similar to the following:

<img width="863" alt="Screen1" src="https://github.com/user-attachments/assets/5c7531e5-6a79-47c7-b768-d9386e0117a6">

4. Click the "Configuration" button in the bottom left menu to verify your company settings.


## Request Payloads
The API Calls are grouped into sections (menu buttons) on the left side menu.  For example, you can click on the "Payments" button to see all the Payment related API Calls.

For every API call, a Request Payload (in JSON format) is required.  All Request JSON Files are located in the "Requests" folder.  When you Click on an API section in the Left Menu, you will see a tab for each specific API Call.  Each tab will show the location and filename of the Request Payload.  In order to change the Request Payload, use an editor to modify the JSON file.  Save the file and re-run the API Call.  You do not need to stop/start the APISample application.

#### Reports Payload

The Reports Payload requires a "reportId" and "date". To obtain these values:

1. Login to (UAT) https://portal.uat.anddone.com/   (Production) https://portal.anddone.com/
2. In the left menu, click "Reporting".
3. Choose a Report and click "Generate Report"
4. Enter the date for the data you want and click "Generate"
5. This will take you to the Report List page.
6. Note the URL will be in the format of: "/merchant/reports/generate-reports/KGx1n813"
7. The final path in the URL (ex: KGx1n813) will be the "reportId" to use for the payload
8. The "date" for the payload is the "Report Date" column on the Report List page, in the format "mm-dd-yyyy"

Note that instead of generating a new report, after clicking the left menu "Reporting", you can select already generated
reports and follow the same steps for obtaining the "reportId" and "date"

## Responses
After clicking a button to execute an API Call, there will be 2 outputs displayed on the screen.  The first will be the "Response Code" returned from the API Call.  The second will be the Raw JSON returned from the API Call.

## API Call Data Dependence
Some Request Payloads for an API Call may require dependent data from a different API Call.  For example, for "Payments", click the "Payments" section in the left menu.  Then click the "Create" tab and verify your Request Payload.  After verification, click the "Create" button.  The Response JSON will contain a "transactionId".  You can see the "Details" of the payment just created by click on the "Details" tab.  Update the reuqest payload for the Payment Details with the "transactionId" returned from the "Create" API Call.  You can then click the "Payment Details" to retrieve the details of the payment just created.

When Data Dependence exists, the tab containing the API Call will point out the depenedencies.

## Updates
To update the API Sample project, do the following:

1.  Change to the root folder
```sh
cd d:\workspace\anddone\anddone-dotnet-sdk-sample-isntallation
```
2.  Pull the latest changes
```sh
git pull
```
3.  Rebuild the project
```sh
dotnet build APISample.sln -c Release --property WarningLevel=0
```

## Including the **AndDone's DotNet client library**
To include the **AndDone's DotNet client library** in your project:

1. Manually - In your .csproj file, add a package reference to:

```sh
<PackageReference Include="AndDoneSecureClientLibrary" Version="1.0.0" />
```
   
3. Within Visual Studio
    1. Open your solution in Visual Studio
    2. Select Tools -> Nuget Package Manager -> Manage NuGet Package for solution
    3. Click Gear Setting and add Package Source:  https://nuget.pkg.github.com/AndDone-kit/index.json  with any name
    4. Select same name in Package Source drop down
    5. Click Browse Tab and select "AndDoneSecureClientLibrary"
    6. Select your project and "Install"
