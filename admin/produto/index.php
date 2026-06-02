<?php

//CONNEXÃO COM O BANCO DE DADOS #
require_once '../../conexao/conecta.php';

include_once '../usuario_comum.php';
?>

<!doctype html>
<html lang="pt-br">

<head>
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <meta name="description" content="">
  <meta name="author" content="">
  <title>Drop to Paradise - Produtos</title>

  <!-- BOOTSTRAP CSS -->
  <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous">

  <!-- BOOTSTRAP ICONS -->
  <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.11.3/font/bootstrap-icons.min.css">

  <!-- CUSTOMIZAÇÃO DO TEMPLATE -->
  <link href="../../css/dashboard.css" rel="stylesheet">

  <!-- FAVICON -->
 <link rel="icon" type="image/icons8-surf-64.png" href="../assets/img/favicon.png">

  <link rel="stylesheet" href="../../css/style.css">
  
</head>

<body>

  <?php
  #Início TOPO
  include('../topo.php');
  #Final TOPO
  ?>

  <div class="container-fluid">
    <div class="row">
      <?php
      #Início MENU
      include('../navegacao.php');
      #Final MENU
      ?>

      <main class="ml-auto col-lg-10 px-md-4">

        <div class="container mt-5">
            <!-- mensagem -->
            <?php include '../mensagem.php' ?>
          <div class="card">
            <div class="card-header d-flex justify-content-between align-items-center">
              <h4 class="m-0">Produto</h4>

              <a href="inserir.php" class="btn btn-primary btn-sm">Adicionar</a>
            </div>

            <div class="card-body">
              <div class="row p-3">

                <!-- FILTRO POR STATUS -->
                <div class="col-lg-2">
                  <select name="status" id="status" class="form-control" onchange="buscar()">
                    <option value="">Status</option>
                    <option value="1">Ativo</option>
                    <option value="0">Inativo</option>
                  </select>
                </div>
                <!-- FILTRO POR CATEGORIA -->
                <div class="col-lg-3">
                  <select name="categoria" id="categoria" class="form-control" onchange="buscar()">
                    <option value="">Categoria</option>

                    <?php
                    $sql_categoria = "SELECT codigo_categoria, nome_categoria FROM categoria WHERE status = 1";
                    $query_categoria = mysqli_query($conexao, $sql_categoria);
                    foreach ($query_categoria as $categoria) {
                      echo '<option value= "' . $categoria['codigo_categoria'] . '">' . $categoria['nome_categoria'] . '</option>';
                    }
                    ?>

                  </select>
                </div>
                <!-- FILTRO POR MARCA -->
                <div class="col-lg-3">
                  <select name="marca" id="marca" class="form-control" onchange="buscar()">
                    <option value="">Marca</option>

                    <?php
                    $sql_marca = "SELECT codigo_marca, nome_marca FROM marca WHERE status = 1";
                    $query_marca = mysqli_query($conexao, $sql_marca);
                    foreach ($query_marca as $marca) {
                      echo '<option value= "' . $marca['codigo_marca'] . '">' . $marca['nome_marca']. '</option>';
                    }
                    ?>

                  </select>
                </div>
                <!-- CAMPO DE BUSCA -->
                <div class="col-lg-4">
                  <input type="search" name="pesquisa" id="pesquisa" class="form-control" placeholder="Pesquise por nome...">

                </div>
                
              </div>
              <!-- TABELA DE REGISTROS -->
              <div id="listar"></div>
            </div>
          </div>
        </div>
      </main>
    </div>
  </div>

  <?php

  mysqli_close($conexao);

  ?>

  <!-- BOOTSTRAP JS -->
  <script src="https://code.jquery.com/jquery-3.7.1.min.js" integrity="sha256-/JqT3SQfawRcv/BIHPThkBvs0OEvtFFmqPF/lYI/Cxo=" crossorigin="anonymous"></script>
  <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js" integrity="sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49" crossorigin="anonymous"></script>
  <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js" integrity="sha384-ChfqqxuZUCnJSK3+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy" crossorigin="anonymous"></script>

<!-- FILTROS -->
<script>
  // FUNCAO PARA LISTAR FUNCIONÁRIOS
  function listar(status, categoria, marca, nome) {
    $('#listar').text('Carregando...');
    $.ajax({
      url: 'tabela.php',
      method: 'POST',
      data: {
        status,
        categoria,
        marca,
        nome
      },
      dataType: 'html',

      success: function(res) {
        $('#listar').html(res);
      }
    })
  }
  //FUNÇÃO PARA BUSCAR COM OD FILTROS
  function buscar() {
    var stts = $('#status').val();
    var cat = $('#categoria').val();
    var mar = $('#marca').val();

    listar(stts, cat, mar);
  }

  $(document).ready(function() {
     listar();

     $('#pesquisa').keyup(function(){
       var pesquisa = $(this).val();
       listar('', '', '', pesquisa);
     })
  })
</script>
</body>

</html>