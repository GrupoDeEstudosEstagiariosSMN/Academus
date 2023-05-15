var aluno = (function () {
    var configs = {
        urls: {
            index: '',
            mostrarViewCadastrar: ''
        }
    }

    var init = function ($configs) {
        configs = $configs;
    };

    var fnMostrarViewCadastrar = function () {
        $.get(configs.urls.mostrarViewCadastrar).done((html) => {
            $('#mostrarViewCadastrar').html(html);
        }).fail((msg) => {
            site.toast.error(msg);
        });
    };

    return {
        init: init,
        fnMostrarViewCadastrar: fnMostrarViewCadastrar
    }
})();
