var aluno = (function () {
    var configs = {
        urls: {
            index: '',
            mostrarViewCadastrar: '',
            cadastrar: '',
            mostrarViewBuscar: '',
            mostrarViewExcluir: '',
            excluir: '',
            mostrarViewEditar: '',
            editar: ''
        }
    }

    var init = function ($configs) {
        configs = $configs;
    };

    var fnEsconderViews = function() {
        $('#mostrarViewCadastrar').hide();
        $('#mostrarViewBuscar').hide();
        $('#mostrarViewExcluir').hide();
        $('#mostrarViewEditar').hide();
    };

    var fnMostrarViewCadastrar = function () {
        $.get(configs.urls.mostrarViewCadastrar).done((html) => {
            fnEsconderViews();
            $('#mostrarViewCadastrar').show();
            $('#mostrarViewCadastrar').html(html);
        }).fail((msg) => {
            site.toast.error(msg);
        });
    };

    var fnCadastrar = function () {
        var model = $('#formCadastrarAluno').serializeObject();
        $.post(configs.urls.cadastrar, model).done(() => {
            fnEsconderViews();
            site.toast.success('aluno cadastrado com sucesso')
        }).fail((msg) => {
            site.toast.error(msg);
        });
    };

    var fnMostrarViewBuscar = function () {
        $.get(configs.urls.mostrarViewBuscar).done((html) => {
            fnEsconderViews();
            $('#mostrarViewBuscar').show();
            $('#mostrarViewBuscar').html(html);
        }).fail((msg) => {
            site.toast.error(msg);
        });
    };

    var fnMostrarViewExcluir = function (id) {
        var model = {id: id};
        $.get(configs.urls.mostrarViewExcluir, model).done((html) => {
            fnEsconderViews();
            $('#mostrarViewExcluir').show();
            $('#mostrarViewExcluir').html(html);
        }).fail((msg) => {
            site.toast.error(msg);
        });
    };

    var fnExcluir = function (id) {
        var model = {id: id};
        $.post(configs.urls.excluir, model).done(() => {
            fnMostrarViewBuscar();
            site.toast.success('aluno excluido com sucesso')
        }).fail((msg) => {
            site.toast.error(msg);
        });
    };

    var fnMostrarViewEditar = function(id) {
        var model = {id: id};
        $.get(configs.urls.mostrarViewEditar, model).done((html) => {
            fnEsconderViews();
            $('#mostrarViewEditar').show();
            $('#mostrarViewEditar').html(html);
        }).fail((msg) => {
            site.toast.error(msg);
        });
    };

    var fnEditar = function() {
        var model = $('#formEditarAluno').serializeObject();
        $.post(configs.urls.editar, model).done(() => {
            site.toast.success('aluno editado com sucesso');
            fnMostrarViewBuscar();
        }).fail((msg) => {
            site.toast.error(msg);
        });
    };

    return {
        init: init,
        fnMostrarViewCadastrar: fnMostrarViewCadastrar,
        fnCadastrar: fnCadastrar,
        fnMostrarViewBuscar: fnMostrarViewBuscar,
        fnMostrarViewExcluir: fnMostrarViewExcluir,
        fnExcluir: fnExcluir,
        fnMostrarViewEditar: fnMostrarViewEditar,
        fnEsconderViews: fnEsconderViews,
        fnEditar: fnEditar
    }
})();
