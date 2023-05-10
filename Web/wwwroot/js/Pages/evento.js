var evento = (() => {
    var configs = {
        urls: {
            buscar: "",
            cadastrar: "",
            editar: "",
            excluir: "",
        },
    };

    var init = ($configs) => {
        configs = $configs;
    };

    var buscarEvento = function () {
        model = $("#buscarEventoPorNome").serializeObject();
        $.post(configs.urls.buscar, model).done(function (html) {
            $(".container-cadastra").hide();
            $(".container-busca").html(html);
            $(".container-busca").show();
        }).fail(function (msg) {
            site.toast.error(msg);
        })
    };

    var cadastrar = function () {
        var model = $('#eventoForm').serializeObject();

        if (!model.isEmpty) {
            $.post(configs.urls.cadastrar, model).done(function () {
                buscar();
            }).fail(function () {
                console.log("deu ruim");
            })
        }
    };

    var viewCadastrar = function () {
        $.get(configs.urls.cadastrar).done(function (html) {
            $(".container-busca").hide();
            $(".container-cadastra").html(html);
            $(".container-cadastra").show();
        }).fail(function () {
            console.log("deu ruim");

        })
    }

    var editar = function () {
        var model = $("#editarForm").serializeObject();
        $.post(configs.urls.editar, model).done(() => {
            $(".container-editar").hide();
            $(".container-busca").show();
            $(".container-busca").html();
            buscar()
        }).fail(function (msg) {
            site.toast.error(msg)
        })
    }

    var viewEditar = function (id) {
        $.get(configs.urls.editar, { id: id }).done(function (html) {
            $(".container-busca").hide();
            $(".buttons").hide();
            $(".container-editar").html(html);
            $(".container-editar").show();
        }).fail(function () {
            console.log("deu ruim");
        })
    }

    var excluir = function (id) {
        var model = { id: id };
        $.post(configs.urls.excluir, model).done(() => {
            buscar();
        }).fail(function () {
            console.log("deu merda kkk");
        })
    }

    return {
        init: init,
        cadastrar: cadastrar,
        viewCadastrar: viewCadastrar,
        editar: editar,
        viewEditar: viewEditar,
        excluir: excluir,
        buscarEvento: buscarEvento
    };
})();
