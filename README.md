# Cloudmersive.APIClient.NET.Barcode - the C# library for the barcodeapi

Barcode APIs let you generate barcode images, and recognize values from images of barcodes.

This C# SDK is for the [Cloudmersive Barcode API](https://www.cloudmersive.com/barcode-api):

- API version: v1
- SDK version: 3.2.0
- Build package: io.swagger.codegen.languages.CSharpClientCodegen

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

<a name="dependencies"></a>
## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using Cloudmersive.APIClient.NET.Barcode.Api;
using Cloudmersive.APIClient.NET.Barcode.Client;
using Cloudmersive.APIClient.NET.Barcode.Model;
```
<a name="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out Cloudmersive.APIClient.NET.Barcode.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.Barcode.Api;
using Cloudmersive.APIClient.NET.Barcode.Client;
using Cloudmersive.APIClient.NET.Barcode.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {

            // Configure API key authorization: Apikey
            Configuration.Default.ApiKey.Add("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Apikey", "Bearer");

            var apiInstance = new BarcodeLookupApi();
            var value = value_example;  // string | Barcode value

            try
            {
                // Lookup EAN barcode value, return product data
                BarcodeLookupResponse result = apiInstance.BarcodeLookupEanLookup(value);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BarcodeLookupApi.BarcodeLookupEanLookup: " + e.Message );
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api.cloudmersive.com*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*BarcodeLookupApi* | [**BarcodeLookupEanLookup**](docs/BarcodeLookupApi.md#barcodelookupeanlookup) | **POST** /barcode/lookup/ean | Lookup EAN barcode value, return product data
*BarcodeScanApi* | [**BarcodeScanImage**](docs/BarcodeScanApi.md#barcodescanimage) | **POST** /barcode/scan/image | Scan and recognize an image of a barcode
*BarcodeScanApi* | [**BarcodeScanImageAdvanced**](docs/BarcodeScanApi.md#barcodescanimageadvanced) | **POST** /barcode/scan/image/advanced | Advanced AI scan and recognition of an image of one or more barcodes of any type
*BarcodeScanApi* | [**BarcodeScanImageAdvancedQR**](docs/BarcodeScanApi.md#barcodescanimageadvancedqr) | **POST** /barcode/scan/image/advanced/qr | Advanced AI scan and recognition of an image of one or more QR barcodes
*GenerateBarcodeApi* | [**GenerateBarcodeCode128**](docs/GenerateBarcodeApi.md#generatebarcodecode128) | **POST** /barcode/generate/code-128 | Generate a EAN-13 code barcode as PNG file
*GenerateBarcodeApi* | [**GenerateBarcodeEAN13**](docs/GenerateBarcodeApi.md#generatebarcodeean13) | **POST** /barcode/generate/ean-13 | Generate a EAN-13 code barcode as PNG file
*GenerateBarcodeApi* | [**GenerateBarcodeEAN8**](docs/GenerateBarcodeApi.md#generatebarcodeean8) | **POST** /barcode/generate/ean-8 | Generate a EAN-8 code barcode as PNG file
*GenerateBarcodeApi* | [**GenerateBarcodeQRCode**](docs/GenerateBarcodeApi.md#generatebarcodeqrcode) | **POST** /barcode/generate/qrcode | Generate a QR code barcode as PNG file
*GenerateBarcodeApi* | [**GenerateBarcodeUPCA**](docs/GenerateBarcodeApi.md#generatebarcodeupca) | **POST** /barcode/generate/upc-a | Generate a UPC-A code barcode as PNG file
*GenerateBarcodeApi* | [**GenerateBarcodeUPCE**](docs/GenerateBarcodeApi.md#generatebarcodeupce) | **POST** /barcode/generate/upc-e | Generate a UPC-E code barcode as PNG file


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.BarcodeAdvancedResultItem](docs/BarcodeAdvancedResultItem.md)
 - [Model.BarcodeAdvancedScanResult](docs/BarcodeAdvancedScanResult.md)
 - [Model.BarcodeLookupResponse](docs/BarcodeLookupResponse.md)
 - [Model.BarcodeQRResultItem](docs/BarcodeQRResultItem.md)
 - [Model.BarcodeScanQRAdvancedResult](docs/BarcodeScanQRAdvancedResult.md)
 - [Model.BarcodeScanResult](docs/BarcodeScanResult.md)
 - [Model.ProductMatch](docs/ProductMatch.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="Apikey"></a>
### Apikey

- **Type**: API key
- **API key parameter name**: Apikey
- **Location**: HTTP header

