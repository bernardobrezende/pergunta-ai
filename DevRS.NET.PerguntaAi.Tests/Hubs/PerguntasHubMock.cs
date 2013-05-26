using DevRS.NET.PerguntaAi.Hubs;
using Microsoft.AspNet.SignalR.Hubs;

namespace DevRS.NET.PerguntaAi.Tests.Hubs
{
    public class PerguntasHubMock : PerguntasHub
    {
        public PerguntasHubMock(HubConnectionContext clientsMock, dynamic allMock)
        {
            this.Clients = clientsMock;
            this.Clients.All = allMock;
        }
    }
}