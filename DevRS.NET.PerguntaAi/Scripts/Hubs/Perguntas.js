$.connection.hub.logging = true;
$.connection.hub.start()
    .done(function () {
        console.log(">>>> connection started");
    })
    .fail(function () {
        console.log(">>>> connection error");
    });

$.connection.perguntasHub.client.adicionarPergunta = function (pergunta) {
    index.viewModel.adicionarPergunta(pergunta);
};