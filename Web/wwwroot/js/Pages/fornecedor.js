var fornecedor = (() => {

  var configs = {
    urls: {
      index: "",
      buscar: "",
      cadastrar: "",
      deletar: "",
      detalhes: "",
      editar: "",
      editarFornecedor: ''
    },
  };

var init = ($configs) => {
  configs = $configs;
};

var buscar = () => {
$.get(configs.urls.buscar).done((html) => {
    $("#mostrarTabela").show();
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
      })
    }
  }

  var deletarFornecedor = (id) => {
    $.post(configs.urls.deletar, { id: id }).done(() => {
       buscar();
    });
  }

  var detalhesUsuario = (id) => {
    $.get(configs.urls.detalhes, { id: id }).done((html) => {
      $("#mostrarTabela").hide();
      $("#detalhesFornecedor").html(html);
    });
  }

/*   var editarFornecedor = (id) => {
      $.get(configs.urls.editar, { id: id }).done((html) => {
        console.log(model);
        $("#mostrarTabela").hide();
        $("#editarFornecedores").html(html);
      });
    } */

    var editarFornecedor = (id) => {
      $.get(configs.urls.editar, { id: id }).done((html) => {
        $("#mostrarTabela").hide();
        $("#editarFornecedores").show();
        $("#editarFornecedores").html(html);
      });
    }

    var editarFornecedores = function (){
      var model = $("#editarFornecedor").serializeObject();
      model.Id = $("#identificadorId").data("itemid");
      $.post(configs.urls.editarFornecedor, model).done(function(){
        $("#editarFornecedores").hide();
        buscar();
      }).fail(function() {
      })
    }

  return {
    init: init,
    buscar: buscar,
    mostrarViewCadastrar: mostrarViewCadastrar,
    cadastrarFornecedor: cadastrarFornecedor,
    deletarFornecedor: deletarFornecedor,
    detalhesUsuario: detalhesUsuario,
    editarFornecedor: editarFornecedor,
    editarFornecedores: editarFornecedores
  };
})();
