# Models



This example assumes `using Reka;` is in scope and `apiKey` contains your Reka API key.

```csharp
using var api = new RekaClient(apiKey);

var response = await api.Models.ListModelsAsync();

Console.WriteLine($"Available models: {response.Data.Count}");
foreach (var model in response.Data)
{
    Console.WriteLine($"  - {model.Id}");
}
```