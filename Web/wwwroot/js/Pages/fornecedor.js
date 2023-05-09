var fornecedor = (() => {
  var configs = {
    urls: {
      index: "",
      buscar: "",
    },
  };

  var init = ($configs) => {
    configs = $configs;
  };

  var buscar = () => {
    $.get(configs.urls.buscar).done((html) => {
      $("#mostrarTabela").html(html);
    });
  };

  return {
    init: init,
    buscar: buscar,
  };
})();
