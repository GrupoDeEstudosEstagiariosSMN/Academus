var fornecedor = (() => {
  var configs = {
    urls: {
      index: "",
      buscar: "",
      cadastrar: "",
      deletar: ""
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

    var cadastrarFornecedor = () => {
      var model = $("#createTable2").serializeObject();

      if (!model.isEmpty) {
        $.post(configs.urls.cadastrar, model).done(function(){
          $("#createTable2").hide();
          buscar();
          $("#mostrarTabela").show();
        }).fail(function() {
          console.log("DEU RUIM, VIU!");
        })
      }
    }

    var deletarFornecedor = (id) => {
      $.post(configs.urls.deletar, { id: id }).done(() => {
        buscar();
      });
    }

  return {
    init: init,
    buscar: buscar,
    mostrarViewCadastrar: mostrarViewCadastrar,
    cadastrarFornecedor: cadastrarFornecedor,
    deletarFornecedor: deletarFornecedor
  };
})();
