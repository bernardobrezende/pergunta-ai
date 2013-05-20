index = { viewModel: new Index() };

function Index() {
    self = this;
    self.textoPergunta = ko.observable("");
    self.perguntas = ko.observableArray();

    self.deveExibirBotao = ko.computed(function () {
        return self.textoPergunta().length > 0;
    }, this);

    self.perguntar = function () {
        $.connection.perguntasHub.server.perguntar(self.textoPergunta());
    };

    self.adicionarPergunta = function (pergunta) {
        self.perguntas.push(pergunta);
    };
}