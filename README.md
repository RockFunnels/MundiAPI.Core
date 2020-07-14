# Getting started

Mundipagg API para .net Core

Este é um cliente não oficial para integrar com a API da MundiPagg com .net Core.

## Initialization

### Authentication
In order to setup authentication and initialization of the API client, you need the following information.

| Parameter | Description |
|-----------|-------------|
| basicAuthUserName | The username to use with basic authentication |
| basicAuthPassword | The password to use with basic authentication |

API client can be initialized as following.

```csharp
// Configuration parameters and credentials
string basicAuthUserName = "basicAuthUserName"; // The username to use with basic authentication
string basicAuthPassword = "basicAuthPassword"; // The password to use with basic authentication

MundiAPIClient client = new MundiAPIClient(basicAuthUserName, basicAuthPassword);
```