var evento = (() => {
    var configs = {
        urls: {
            buscar: "",
            cadastrar: "",
            viewCadastrar: ""
        },
    };

    var init = ($configs) => {
        configs = $configs;
    };

    var buscar = function () {
        $.get(configs.urls.buscar).done(function (html) {
            $(".container-busca").html(html);
            $(".container-busca").show();
        }).fail(function () {
            console.log("deu ruim");
        })
    };

    var cadastrar = function () {
        var model = $('#eventoForm').serializeObject();

        if (!model.isEmpty) {
            $.post(configs.urls.cadastrar, model).done(function () {
                location.href = configs.urls.buscar
            }).fail(function () {
                console.log("deu ruim");
            })
        }
    };

    var viewCadastrar = function () {
        $.get(configs.urls.viewCadastrar).done(function (html) {
            $(".container-busca").hide();
            $(".container-cadastra").html(html);
            $(".container-cadastra").show();
        }).fail(function () {
            console.log("deu ruim");

        })
    }

    return {
        init: init,
        buscar: buscar,
        cadastrar: cadastrar,
        viewCadastrar: viewCadastrar
    };
})();
