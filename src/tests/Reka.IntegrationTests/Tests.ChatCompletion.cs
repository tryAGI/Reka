namespace Reka.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ChatCompletion()
    {
        using var api = GetAuthenticatedClient();

        var response = await api.Chat.CreateChatCompletionAsync(new CreateChatCompletionRequest
        {
            Model = "reka-flash",
            Messages =
            [
                new ChatMessageInput
                {
                    Role = ChatMessageInputRole.User,
                    Content = "Say hello in 5 words",
                },
            ],
            MaxTokens = 64,
        });

        Console.WriteLine(response.Choices[0].Message.Content);

        response.Choices.Should().NotBeEmpty();
        response.Choices[0].Message.Content.Should().NotBeNullOrEmpty();
    }
}
