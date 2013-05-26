index = { viewModel: new Index() };

function Index() {
    self = this;
    self.textoPergunta = ko.observable("");
    self.textoErro     = ko.observable("");
    self.perguntas     = ko.observableArray();

    self.deveExibirBotao = ko.computed(function () {
        return self.textoPergunta().length > 0;
    }, this);

    self.deveExibirErro = ko.computed(function () {
        return self.textoErro().length > 0;
    }, this);

    self.perguntar = function () {
        var perguntaRepetida = ko.utils.arrayFirst(self.perguntas(), function (p) { return p === self.textoPergunta(); });
        if (perguntaRepetida)
            self.textoErro("Ops.. Pergunta já foi feita!");
        else {
            self.textoErro("");
            $.connection.perguntasHub.server.perguntar(self.textoPergunta());
        }
    };

    self.adicionarPergunta = function (pergunta) {
        self.perguntas.push(pergunta);
    };
}