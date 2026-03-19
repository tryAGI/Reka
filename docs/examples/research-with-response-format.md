# Research With Response Format



This example assumes `using Reka;` is in scope and `apiKey` contains your Reka API key.

```csharp
using var api = new RekaClient(apiKey);

var response = await api.Chat.CreateChatCompletionAsync(new CreateChatCompletionRequest
{
    Model = "reka-flash-research",
    Messages =
    [
        new ChatMessageInput
        {
            Role = ChatMessageInputRole.User,
            Content = "List 3 famous scientists and their main contribution",
        },
    ],
    MaxTokens = 512,
    ResponseFormat = new ResponseFormat
    {
        Type = ResponseFormatType.JsonSchema,
        JsonSchema = new JsonSchemaConfig
        {
            Name = "scientists",
            Description = "A list of scientists",
            Schema = System.Text.Json.JsonSerializer.Deserialize<object>("""
                {
                    "type": "object",
                    "properties": {
                        "scientists": {
                            "type": "array",
                            "items": {
                                "type": "object",
                                "properties": {
                                    "name": { "type": "string" },
                                    "contribution": { "type": "string" }
                                },
                                "required": ["name", "contribution"]
                            }
                        }
                    },
                    "required": ["scientists"]
                }
                """)!,
        },
    },
});

Console.WriteLine($"Content: {response.Choices[0].Message.Content}");

// Verify it's valid JSON
var action = () => System.Text.Json.JsonDocument.Parse(response.Choices[0].Message.Content!);
```