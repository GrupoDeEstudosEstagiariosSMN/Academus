var usuario = (() => {

    var configs = {
        urls: {
            index: '',
            cadastrar: '',
            buscar: '',
            deletar: ''
        }
    };

    var init = ($configs) => {
        configs = $configs;
    };

    var cadastrar = () => {
            var model = $('#cadastroUsuario').serializeObject();
             $.post(configs.urls.cadastrar, model).done(() => {
                location.href = '/usuario';
            });
        }

    var buscarUsuario = () => {
        var model = $('#buscarUsuario').serializeObject();
        console.log(model);
        $.post(configs.urls.buscar, model).done((html) => {
            $('#mostrarUsuarios').html(html);
        });
    }

    var deletarUsuario = (id) => {
        $.post(configs.urls.deletar, { id: id }).done(() => {
            location.reload();
        });
    }

    return {
        init: init,
        buscarUsuario: buscarUsuario,
        cadastrar: cadastrar,
        deletarUsuario: deletarUsuario
    };
})();
