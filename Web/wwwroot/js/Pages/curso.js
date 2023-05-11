var curso = (() => {

    var configs = {
        urls: {
            index: '',
            cadastrar: '',
            buscar: '',
            deletar: '',
            editar: '',
            salvar: ''
        }
    };

    var init = ($configs) => {
        configs = $configs;
    };

    var cadastrar = () => {
        var model = $('#cadastroCurso').serializeObject();
        console.log(model);
        $.post(configs.urls.cadastrar, model).done(() => {
            location.href = '/curso'
        });
    }

    var buscarCurso = () => {
        $.get(configs.urls.buscar).done((html) => {
            $('#mostrarCursos').html(html);
            $('#editarCurso').hide();
            $('#mostrarCursos').show('slow');
        });
    }

    var deletarCurso = (id) => {
        $.post(configs.urls.deletar, { id: id }).done(() => {
            location.reload();
        });
    }

    var editarCurso = (id) => {
        var model = $(`#lucas_${id}`).serializeObject();
        console.log(model)
        $.get(configs.urls.editar, model).done((html) => {
            $('#mostrarCursos').hide();
            $('#editarCurso').html(html);
            $('#editarCurso').show('slow');

        });
    }

    var salvarCurso = () => {
        var model = $('#editaCurso').serializeObject();
        console.log(model)
        $.post(configs.urls.salvar, model).done(() => {
            $('#editarCurso').hide();
            buscarCurso();
        });
    }


    return {
        init: init,
        buscarCurso: buscarCurso,
        cadastrar: cadastrar,
        deletarCurso: deletarCurso,
        editarCurso: editarCurso,
        salvarCurso: salvarCurso
    };
})();
