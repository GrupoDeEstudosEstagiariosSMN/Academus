var aluno = (function () {
    var configs = {
        urls: {
            mostrarViewCadastrar: '',
            cadastrar: '',
            mostrarViewBuscar: '',
            mostrarViewExcluir: '',
            excluir: '',
            mostrarViewEditar: ''
        }
    };

    var init = function ($configs) {
        configs = $configs;
    };

    var esconderViews = function () {
        $('#mostrarViewCadastrar').hide();
        $('#mostrarViewBuscar').hide();
        $('#mostrarViewExcluir').hide();
        $('#mostrarViewEditar').hide();
    };

    var mostrarViewCadastrar = function () {
        $.get(configs.urls.mostrarViewCadastrar).done((html) => {
            esconderViews();
            $('#mostrarViewCadastrar').show();
            $('#mostrarViewCadastrar').html(html);
        });
    }

    var cadastrar = function () {
        var model = $('#formCadastroAluno').serializeObject();
        $.post(configs.urls.cadastrar, model).done(() => {
            mostrarViewBuscar();
            site.toast.success('cadastro realizado com sucesso');
        }).fail((msg) => {
            site.toast.error(msg);
        });
    }

    var mostrarViewBuscar = function () {
        $.get(configs.urls.mostrarViewBuscar).done((html) => {
            esconderViews();
            $('#mostrarViewBuscar').show();
            $('#mostrarViewBuscar').html(html);
        })
    }

    var mostrarViewExcluir = function (id) {
        $.get(configs.urls.mostrarViewExcluir, {id: id}).done((html) => {
            esconderViews();
            $('#mostrarViewExcluir').show();
            $('#mostrarViewExcluir').html(html);
        });
    };

    var excluir = function (id) {
        $.post(configs.urls.excluir, {id: id}).done((msg) => {
            mostrarViewBuscar();
            site.toast.success('Aluno excluido com sucesso');
        }).fail((msg) => {
            site.toast.error(msg);
        });
    };

    var mostrarViewEditar = function (id) {
        $.get(configs.urls.mostrarViewEditar, {id: id}).done((html) => {
            esconderViews();
            $('#mostrarViewEditar').show();
            $('#mostrarViewEditar').html(html);
        }).fail((msg) => {
            site.toast.error(msg);
        });
    };

    var editar = function () {
        var model = $('#formEditarAluno').serializeObject();
        $.post(configs.urls.editar, model).done(() => {
            mostrarViewBuscar();
            site.toast.success('Aluno editado com sucesso');
        }).fail((msg) => {
            site.toast.error(msg);
        });
    };

    return {
        init: init,
        mostrarViewCadastrar: mostrarViewCadastrar,
        cadastrar: cadastrar,
        mostrarViewBuscar: mostrarViewBuscar,
        mostrarViewExcluir: mostrarViewExcluir,
        excluir: excluir,
        mostrarViewEditar: mostrarViewEditar,
        editar: editar

    }
})();
