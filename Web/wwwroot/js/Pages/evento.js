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

    var buscarEvento = () => {
        model = $("#buscarEventoPorNome").serializeObject();
        $.post(configs.urls.buscar, model).done(function (html) {
            $(".container-busca").html(html);
            $("#buscarEventoPorNome").show();
            $(".container-busca").show();
        }).fail(function (msg) {
            site.toast.error(msg);
        })
    };

    var cadastrar = () => {
        var model = $('#eventoForm').serializeObject();

        if (!model.isEmpty) {
            $.post(configs.urls.cadastrar, model).done(function () {
                $(".container-cadastra").hide();
                buscarEvento();
            }).fail(function () {
                console.log("deu ruim");
            })
        }
    };

    var viewCadastrar = () => {
        $.get(configs.urls.cadastrar).done(function (html) {
            $(".container-busca").hide();
            $("#buscarEventoPorNome").hide();
            $(".container-cadastra").html(html);
            $(".container-cadastra").show();
        }).fail(function () {
            console.log("deu ruim");

        })
    }

    var editar = () => {
        var model = $("#editarForm").serializeObject();
        $.post(configs.urls.editar, model).done(() => {
            $(".container-editar").hide();
            buscarEvento();
        }).fail(function (msg) {
            site.toast.error(msg)
        })
    }

    var viewEditar = (id) => {
        $.get(configs.urls.editar, { id: id }).done(function (html) {
            $("#buscarEventoPorNome").hide();
            $(".container-busca").hide();
            $(".container-editar").html(html);
            $(".container-editar").show();
        }).fail(function () {
            console.log("deu ruim");
        })
    }

    var excluir = (id) => {
        var model = { id: id };
        $.post(configs.urls.excluir, model).done(() => {
            buscarEvento();
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
