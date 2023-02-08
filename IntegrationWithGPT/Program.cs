using IntegrationWithGPT.ApiDrivers;
using IntegrationWithGPT.TrelloDriver;

Console.WriteLine("Start Trello Work");

TrelloDriver trelloDriver = new TrelloDriver();
GPTDriver gptDriver = new GPTDriver();

//trelloDriver.SendRequest();

gptDriver.SendRequest();
