using Microsoft.Extensions.AI;

IChatClient chatClient = new OllamaSharp.OllamaApiClient(
        new Uri("http://127.0.0.1:11434"), "llama3.1");

var prompt = Console.ReadLine();
if (prompt is null)
{
    Console.WriteLine("No input provided.");
    return;
}

var response = await chatClient.GetResponseAsync(prompt);

Console.WriteLine(response);
