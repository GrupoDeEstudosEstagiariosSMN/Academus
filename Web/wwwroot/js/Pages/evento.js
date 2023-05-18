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
        console.log(model);
        $.get(configs.urls.buscar, model).done(function (html) {
            $("#buscarEventoPorNome").show();
            $(".container-busca").show();
            $(".container-busca").html(html);
        }).fail(function (msg) {
            site.toast.error(msg);
        })
    };

    var cadastrar = () => {
        var model = $('#eventoForm').serializeObject();
        console.log(model);
        if (!model.isEmpty) {
            $.post(configs.urls.cadastrar, model).done(function () {
                $(".container-cadastra").hide();
                buscarEvento();
            }).fail(function (error) {
                console.log(error);

            })
        }
    };

    var viewCadastrar = () => {
        console.log(configs.urls.cadastrar);
        $.get(configs.urls.cadastrar)
            .done(function (html) {
                $(".container-busca").hide();
                $("#buscarEventoPorNome").hide();
                $(".container-cadastra").html(html);
                $(".container-cadastra").show();
            }).fail(function () {
                console.log("burro dms");
            })
    }

    var editar = () => {
        var model = $("#editarForm").serializeObject();
        console.log(model);
        $.post(configs.urls.editar, model).done(() => {
            $(".container-editar").hide();
            buscarEvento();
        }).fail(function (msg) {
            site.toast.error(msg)
        })
    }

    var viewEditar = (id) => {
        $.get(configs.urls.editar, { id: id })
            .done(function (html) {
                $("#buscarEventoPorNome").hide();
                $(".container-busca").hide();
                $(".container-editar").show();
                $(".container-editar").html(html);
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
