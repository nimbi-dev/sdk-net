# Nimbi's C# SDK
A simple Java SDK to access Nimbi APIs.

## How to use it
You can copy the code and use directly on your code.
```csharp
NimbiClient client = new NimbiClient(Environments.QA, "[some_api_id]", "[some_api_key]");
ConnectivityTest connectivityTest = new ConnectivityTest();
IRestResponse response = connectivityTest.testConnectivity(client);
```

## Community
You can contact us if you have questions using the standard communication channels described in the developer's site.

## I want to contribute!
That is great! Just fork the project in github. Create a topic branch, write some code, and add some tests for your new code.

Thanks for helping!
