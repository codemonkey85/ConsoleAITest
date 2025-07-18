using Microsoft.Extensions.AI;

IChatClient chatClient = new OllamaSharp.OllamaApiClient(
        new Uri("http://127.0.0.1:11434"), "llama3.1");

var prompt = Console.ReadLine();

var response = await chatClient.GetResponseAsync(prompt);

Console.WriteLine(response);
