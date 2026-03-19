# Chat Client Get Service Metadata



This example assumes `using Reka;` is in scope and `apiKey` contains your Reka API key.

```csharp
// These tests don't need a real API key — metadata is local-only
using var api = new RekaClient("dummy-key");
MeaiChatClient chatClient = api;

var metadata = chatClient.GetService<ChatClientMetadata>();
```