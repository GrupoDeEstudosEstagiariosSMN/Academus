var usuario = (() => {

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
        console.log(model);
        $.post(configs.urls.buscar, model).done((html) => {
            $('#mostrarUsuarios').html(html);
        });
    }

    return {
        init: init,
        buscarUsuario: buscarUsuario,
        cadastrar: cadastrar
    };
})();
