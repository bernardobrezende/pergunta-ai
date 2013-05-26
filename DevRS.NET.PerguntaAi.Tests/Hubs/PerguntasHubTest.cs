using Microsoft.AspNet.SignalR.Hubs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SharpTestsEx;
using System;
using System.Dynamic;

namespace DevRS.NET.PerguntaAi.Tests.Hubs
{
    [TestClass]
    public class PerguntasHubTest
    {
        [TestMethod]
        public void PerguntarDeveChamarClientsAllAdicionarPergunta()
        {
            // Arrange mocks
            string pergunta = "isto é uma pergunta?";
            Mock<HubConnectionContext> clientsMock = new Mock<HubConnectionContext>();
            dynamic allMock = new ExpandoObject();
            allMock.adicionarPergunta = new Action<string>((perg) => 
            {
                // Assert
                perg.Should().Be.EqualTo(pergunta);
            });

            PerguntasHubMock perguntasHubMock = new PerguntasHubMock(clientsMock.Object, allMock);
            // Act
            perguntasHubMock.Perguntar(pergunta);
        }
    }
}
