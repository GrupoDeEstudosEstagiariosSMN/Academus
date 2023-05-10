var curso = (() => {

    var configs = {
        urls: {
            index: '',
            cadastrar: '',
            buscar: '',
            deletar: '',
            editar: ''
        }
    };

    var init = ($configs) => {
        configs = $configs;
    };

    var cadastrar = () => {
        var model = $('#cadastroCurso').serializeObject();
        console.log(model);
        $.post(configs.urls.cadastrar, model).done(() => {
            location.href = '/curso';
        });
    }

    var buscarCurso = () => {
        $.get(configs.urls.buscar).done((html) => {
            $('#mostrarCursos').html(html);
        });
    }

    var deletarCurso = (id) => {
        $.post(configs.urls.deletar, { id: id }).done(() => {
            location.reload();
        });
    }

    var editarCurso = (id) => {
        var model = $(`#lucas_${id}`).serializeObject();
        console.log(model);
        $.post(configs.urls.editar, model).done((html) => {
            console.log(model);
            $('#editarCurso').html(html);
                
        });
    }


    return {
        init: init,
        buscarCurso: buscarCurso,
        cadastrar: cadastrar,
        deletarCurso: deletarCurso,
        editarCurso: editarCurso
    };
})();
