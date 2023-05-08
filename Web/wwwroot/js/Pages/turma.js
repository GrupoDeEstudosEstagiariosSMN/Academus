var turma = (() => {

    var configs = {
        urls: {
            index: '',
            cadastrar: '',
            buscar: ''
        }
    };

    var init = ($configs) => {
        configs = $configs;
    };

    var cadastrar = () => {
        var model = $('#cadastroTurma').serializeObject();
        $.post(configs.urls.cadastrar, model).done((html) => {
            location.href = '/turma';
        });
    }

    var buscarTurma = () => {
        var model = $('#buscarTurma').serializeObject();
        console.log(model);
        $.post(configs.urls.buscar, model).done((html) => {
            $('#mostrarTurma').html(html);
        });
    }

    return {
        init: init,
        cadastrar: cadastrar,
        buscarTurma: buscarTurma
    };
})();
