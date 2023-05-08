var turma = (() => {

    var configs = {
        urls: {
            index: '',
            cadastrar: '',
            buscarTturma: ''
        }
    };

    var init = ($configs) => {
        configs = $configs;
    };

    var cadastrar = () => {
        var model = $('#cadastroTurma').serializeObject();
        $.post(configs.urls.cadastrar, model).done((html) => {
            $('#mostrarTurma').html(html);
        });
    }

    var buscarTturma = () => {
        var model = $('#buscarTurma').serializeObject();
        console.log(model);
        $.post(configs.urls.buscar, model).done((html) => {
            $('#mostrarUsuarios').html(html);
        });
    }

    return {
        init: init,
        cadastrar: cadastrar
    };
})();
