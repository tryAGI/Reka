/*
order: 170
title: Chat Client Tool Calling Required Mode
slug: chat-client-tool-calling-required-mode
*/

using Microsoft.Extensions.AI;
using MeaiChatClient = Microsoft.Extensions.AI.IChatClient;
using ChatMessage = Microsoft.Extensions.AI.ChatMessage;

namespace Reka.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ChatClient_ToolCalling_RequiredMode()
    {
        using var api = GetAuthenticatedClient();
        MeaiChatClient chatClient = api;

        var getTimeTool = AIFunctionFactory.Create(
            (string timezone) => $"The current time in {timezone} is 2:30 PM.",
            "get_time",
            "Gets the current time in a timezone");

        var response = await chatClient.GetResponseAsync(
            [new ChatMessage(ChatRole.User, "Hello!")],
            new ChatOptions
            {
                ModelId = "reka-flash",
                MaxOutputTokens = 256,
                Tools = [getTimeTool],
                ToolMode = ChatToolMode.RequireAny,
            });

        Console.WriteLine($"Finish reason: {response.FinishReason}");

        // With required tool mode, the model should always produce a tool call
        response.FinishReason.Should().Be(ChatFinishReason.ToolCalls);

        var functionCalls = response.Messages
            .SelectMany(m => m.Contents)
            .OfType<FunctionCallContent>()
            .ToList();

        functionCalls.Should().NotBeEmpty();
    }
}
