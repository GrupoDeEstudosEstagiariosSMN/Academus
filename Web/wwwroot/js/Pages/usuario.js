var usuario = (() => {

    var configs = {
        urls: {
            index: '',
            cadastrar: ''
        }
    };

    var init = ($configs) => {
        configs = $configs;
    };

    var cadastrar = () => {
            var model = $('#cadastroUsuario').serializeObject();
             $.post(configs.urls.cadastrar, model).done(() => {
            });
        }

    return {
        init: init, 
        cadastrar: cadastrar
    };
})();
