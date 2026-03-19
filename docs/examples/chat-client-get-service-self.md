# Chat Client Get Service Self



This example assumes `using Reka;` is in scope and `apiKey` contains your Reka API key.

```csharp
using var api = new RekaClient("dummy-key");
MeaiChatClient chatClient = api;

var self = chatClient.GetService<RekaClient>();
```