var aluno = (function () {
    var configs = {
        urls: {
            index: '',
            mostrarViewCadastrar: '',
            cadastrar: '',
            mostrarViewBuscar: '',
            mostrarViewExcluir: '',
            excluir: ''
        }
    }

    var init = function ($configs) {
        configs = $configs;
    };

    var fnEsconderViews = function() {
        $('#mostrarViewCadastrar').hide();
        $('#mostrarViewBuscar').hide();
        $('#mostrarViewExcluir').hide();
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

    var fnMostrarViewExcluir = function () {
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

    return {
        init: init,
        fnMostrarViewCadastrar: fnMostrarViewCadastrar,
        fnCadastrar: fnCadastrar,
        fnMostrarViewBuscar: fnMostrarViewBuscar,
        fnMostrarViewExcluir: fnMostrarViewExcluir,
        fnExcluir: fnExcluir
    }
})();
