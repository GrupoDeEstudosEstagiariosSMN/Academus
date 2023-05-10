var fornecedor = (() => {
  var configs = {
    urls: {
      index: "",
      buscar: "",
      cadastrar: ""
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

  var mostrarViewCadastrar = () => {
    $.get(configs.urls.cadastrar).done((html) => {
      $("#mostrarTabela").hide();
      $("#createTable").show();
      $("#createTable").html(html);
    })}

  return {
    init: init,
    buscar: buscar,
    mostrarViewCadastrar: mostrarViewCadastrar
  };
  
})();
