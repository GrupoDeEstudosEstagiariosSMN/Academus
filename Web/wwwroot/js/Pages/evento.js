var evento = (() => {
    var configs = {
        urls: {
            buscar: "",
            cadastrar: "",
            viewCadastrar: "",
            editar: "",
            viewEditar: ""
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

    var mostrarTela = function () {
        location.href = configs.urls.editar
    }

    var editar = function () {
        var model = $("#editarForm").serializeObject();
        $.post(configs.urls.editar, model).done(() => {
            $(".container-editar").hide();
            $(".container-busca").show();
            $(".container-busca").html();
            buscar()
        }).fail(function () {
            console.log("deu ruim");
        })
    }

    var viewEditar = function (id) {
        $.get(configs.urls.viewEditar, { id: id }).done(function (html) {
            $(".container-busca").hide();
            $(".buttons").hide();
            $(".container-editar").html(html);
            $(".container-editar").show();
        }).fail(function () {
            console.log("deu ruim");
        })
    }

    return {
        init: init,
        buscar: buscar,
        cadastrar: cadastrar,
        viewCadastrar: viewCadastrar,
        editar: editar,
        viewEditar: viewEditar,
        mostrarTela: mostrarTela
    };
})();
