var turma = (() => {

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
        var model = $('#cadastroTurma').serializeObject();
        $.post(configs.urls.cadastrar, model).done(() => {
            site.toast.success('Turma cadastrada com sucesso!');
        }).fail((msg) => {
            site.toast.error(msg);
        });
    }

    var buscarTurma = () => {
        var model = $('#buscarTurma').serializeObject();
        console.log(model);
        $.post(configs.urls.buscar, model).done((html) => {
            $('#mostrarTurma').html(html);
        });
    }

    var deletarTurma = (id) => {
        $.post(configs.urls.deletar, { id: id }).done(() => {
            location.reload();
        });
    }

    $(document).ready(() => {
        $('.inputEditar').hide();
        $('#editar-button').click(() => {
            $('.inputEditar').toggle();
        });
    });

    var editarTurma = (id) => {
        var model = $(`#formEditar-${id}` ).serializeObject();
        console.log(model)
        $.post(configs.urls.editar, model).done(() => {
            location.reload();   
        });
    }

    return {
        init: init,
        cadastrar: cadastrar,
        buscarTurma: buscarTurma,
        deletarTurma: deletarTurma,
        editarTurma: editarTurma
    };
})();
