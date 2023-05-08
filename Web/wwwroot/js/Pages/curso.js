var curso = (() => {

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
        var model = $('#cadastroCurso').serializeObject();
        $.post(configs.urls.cadastrar, model).done(() => {
            location.href = '/curso';
        });
    }

    var buscarCurso = () => {


        $.get(configs.urls.buscar).done((html) => {
            $('#mostrarCursos').html(html);
        });
    }

    return {
        init: init,
        buscarCurso: buscarCurso,
        cadastrar: cadastrar
    };
})();
