var usuario = (() => {

    var configs = {
        urls: {
            buscar: '',
        }
    };

    var init = ($configs) => {
        configs = $configs;
    };

    var buscar = function () {
        $.get(configs.urls.buscar).done(function (html) {
            $(".container-busca").html(html);
            $(".container-busca").show();
        }).fail(function () {
            console.log("deu ruim");
        })
    };

    return {
        init: init,
        buscar: buscar

    };
})();
