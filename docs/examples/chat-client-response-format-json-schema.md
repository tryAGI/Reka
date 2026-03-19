# Chat Client Response Format Json Schema



This example assumes `using Reka;` is in scope and `apiKey` contains your Reka API key.

```csharp
using var api = new RekaClient(apiKey);
MeaiChatClient chatClient = api;

var schema = JsonSerializer.Deserialize<JsonElement>("""
    {
        "type": "object",
        "properties": {
            "scientists": {
                "type": "array",
                "items": {
                    "type": "object",
                    "properties": {
                        "name": { "type": "string" },
                        "field": { "type": "string" }
                    },
                    "required": ["name", "field"]
                }
            }
        },
        "required": ["scientists"]
    }
    """);

var response = await chatClient.GetResponseAsync(
    [new ChatMessage(ChatRole.User, "List 2 famous scientists and their field")],
    new ChatOptions
    {
        ModelId = "reka-flash-research",
        MaxOutputTokens = 256,
        ResponseFormat = ChatResponseFormat.ForJsonSchema(schema, "scientists_list", "A list of scientists"),
    });

Console.WriteLine($"Response: {response.Text}");

// Verify it's valid JSON matching the schema
var doc = JsonDocument.Parse(response.Text!);
```