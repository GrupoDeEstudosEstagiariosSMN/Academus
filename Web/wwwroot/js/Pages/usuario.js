var usuario = (() => {

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
        var model = $('#cadastroUsuario').serializeObject();
        $.post(configs.urls.cadastrar, model).done(() => {
            site.toast.success("cadastrado com sucesso.")
            setTimeout(function(){ location.reload(); }, 2000);
        }).fail((msg) => {
            site.toast.error(msg);
        });
    }

    var buscarUsuario = () => {
        var model = $('#buscarUsuario').serializeObject();
        $.post(configs.urls.buscar, model).done((html) => {
            $('#mostrarUsuarios').html(html);
        });
    }

    var deletarUsuario = (id) => {
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

    var editarUsuario = () => {
        var model = $('#formEditar').serializeObject();
        $.post(configs.urls.editar, model).done(() => {
            location.reload();
        });
    }

    return {
        init: init,
        buscarUsuario: buscarUsuario,
        cadastrar: cadastrar,
        deletarUsuario: deletarUsuario,
        editarUsuario: editarUsuario
    };
})();
