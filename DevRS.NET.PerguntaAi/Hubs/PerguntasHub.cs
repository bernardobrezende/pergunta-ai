using Microsoft.AspNet.SignalR;

namespace DevRS.NET.PerguntaAi.Hubs
{
    public class PerguntasHub : Hub
    {
        public void Perguntar(string pergunta)
        {
            Clients.All.adicionarPergunta(pergunta);
        }
    }
}