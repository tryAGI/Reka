# Meai Mapping Response Format Json



This example assumes `using Reka;` is in scope and `apiKey` contains your Reka API key.

```csharp
var (client, capture) = CreateCapturingClient();
using var _ = client;
MeaiChatClient chatClient = client;

var schema = JsonSerializer.Deserialize<JsonElement>("""
    {
        "type": "object",
        "properties": {
            "answer": { "type": "string" }
        },
        "required": ["answer"]
    }
    """);

try
{
    await chatClient.GetResponseAsync(
        [new ChatMessage(ChatRole.User, "Hello")],
        new ChatOptions
        {
            ModelId = "reka-flash",
            ResponseFormat = ChatResponseFormat.ForJsonSchema(schema, "test_schema", "A test schema"),
        });
}
catch { }

var body = capture.LastRequestBody!.RootElement;
var rf = body.GetProperty("response_format");
```