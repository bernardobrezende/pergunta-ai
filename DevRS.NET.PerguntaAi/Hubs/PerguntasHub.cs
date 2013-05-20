using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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