namespace Reka.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ListModels()
    {
        using var api = GetAuthenticatedClient();

        var response = await api.Models.ListModelsAsync();

        Console.WriteLine($"Available models: {response.Data.Count}");
        foreach (var model in response.Data)
        {
            Console.WriteLine($"  - {model.Id}");
        }

        response.Data.Should().NotBeEmpty();
    }
}
