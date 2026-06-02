<?php
if (!isset($_SESSION)) {
  session_start();
}

if (!isset($_SESSION['USER']) || !$_SESSION['USER']) {
  $_SESSION['naoAutorizado'] = "Apenas usuários cadastrados podem acessar esta área!";
  header('Location: index.php');
  // exit();  // conforme seu pedido, sem exit
}

require_once '../conexao/conecta.php';

// Produtos no estoque
// Total de produtos em estoque (com status 1)
$sql = "SELECT SUM(produto.quantidade) AS total_produtos_estoque FROM produto WHERE produto.status = 1";
$result = mysqli_query($conexao, $sql);
$produtos = mysqli_fetch_assoc($result);

// Total de funcionários ativos (status 1)
$sql = "SELECT COUNT(funcionario.codigo_funcionario) AS total_funcionarios FROM funcionario WHERE funcionario.status = 1";
$result = mysqli_query($conexao, $sql);
$funcionarios = mysqli_fetch_assoc($result);


// Cliente que mais comprou
$sql = "
  SELECT cliente.nome, SUM(venda.preco_final) AS total_gasto
  FROM venda
  JOIN cliente ON venda.codigo_cliente = cliente.codigo_cliente
  GROUP BY cliente.codigo_cliente
  ORDER BY total_gasto DESC
  LIMIT 1
";
$result = mysqli_query($conexao, $sql);
$cliente_top = mysqli_fetch_assoc($result);

// Funcionário que mais vendeu
$sql = "
  SELECT funcionario.nome, COUNT(venda.codigo_venda) AS total_vendas
  FROM venda
  JOIN funcionario ON venda.codigo_funcionario = funcionario.codigo_funcionario
  GROUP BY funcionario.codigo_funcionario
  ORDER BY total_vendas DESC
  LIMIT 1
";
$result = mysqli_query($conexao, $sql);
$funcionario_top = mysqli_fetch_assoc($result);


?>



<!doctype html>
<html lang="pt-br">

<head>
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <meta name="description" content="">
  <meta name="author" content="">
  <title>Drop to paradise - Painel</title>

  <!-- BOOTSTRAP CSS -->
  <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous">

  <!-- BOOTSTRAP ICONS -->
  <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.11.3/font/bootstrap-icons.min.css">

  <!-- CUSTOMIZAÇÃO DO TEMPLATE -->
  <link href="../css/dashboard.css" rel="stylesheet">

  <link rel="stylesheet" href="../../css/style.css">

  <!-- FAVICON -->
  <link rel="icon" type="image/icons8-surf-64.png" href="../assets/img/favicon.png">
</head>

<body>

  <?php
  #Início TOPO
  include('topo.php');
  #Final TOPO
  ?>

  <div class="container-fluid">
    <div class="row">
      <?php
      #Início MENU
      include('navegacao.php');
      #Final MENU
      ?>

      <main class="ml-auto col-lg-10 px-md-4">
        <div class="d-flex justify-content-between flex-wrap flex-md-nowrap align-items-center pt-3 pb-2 mb-3 border-bottom">
          <h1 class="h2">Painel Administrativo</h1>
          <h2 class="h3">Olá, <?php echo $_SESSION['NAME'] ?></h2>
        </div>

        <div>
          <?php
          if (isset($_SESSION['naoAdm'])) {

            echo ' <div class="alert alert-danger alert-dismissible fade show" role="alert">';
            echo $_SESSION['naoAdm'];
            echo '<button type="button" class="close" data-dismiss="alert" aria-label="Close">
                   <span aria-hidden="true">&times;</span>
                  </button>
                </div>';

            unset($_SESSION['naoAdm']);
          }

          ?>
        </div>


              <!-- DASHBOARD CARDS -->
           <div class="row">
          <div class="col-md-6">
            <div class="card text-white bg-primary mb-3">
              <div class="card-header"><i class="bi bi-box"></i> Produtos em Estoque</div>
              <div class="card-body">
                <h5 class="card-title"><?= $produtos['total_produtos_estoque'] ?? 0 ?></h5>
              </div>
            </div>
          </div>

          <div class="col-md-6">
            <div class="card text-white bg-primary mb-3">
              <div class="card-header"><i class="bi bi-person-badge"></i> Funcionários Ativos</div>
              <div class="card-body">
                <h5 class="card-title"><?= $funcionarios['total_funcionarios'] ?? 0 ?></h5>
              </div>
            </div>
          </div>

          <div class="col-md-6">
            <div class="card text-white bg-primary mb-3">
              <div class="card-header"><i class="bi bi-star"></i> Cliente Top Comprador</div>
              <div class="card-body">
                <h5 class="card-title"><?= $cliente_top['nome'] ?? 'Nenhum' ?></h5>
                <p class="card-text">Total gasto: R$ <?= number_format($cliente_top['total_gasto'] ?? 0, 2, ',', '.') ?></p>
              </div>
            </div>
          </div>

          <div class="col-md-6">
    <div class="card text-white bg-primary mb-3">
      <div class="card-header"><i class="bi bi-person-check"></i> Funcionário Top Vendedor</div>
      <div class="card-body">
        <h5 class="card-title"><?= $funcionario_top['nome'] ?? 'Nenhum' ?></h5>
        <p class="card-text">Total de vendas: <?= $funcionario_top['total_vendas'] ?? 0 ?></p>
      </div>
    </div>
  </div>
</div>

        </div>

       


        

      </main>
    </div>
  </div>

  <!-- BOOTSTRAP JS -->
  <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
  <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js" integrity="sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49" crossorigin="anonymous"></script>
  <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js" integrity="sha384-ChfqqxuZUCnJSK3+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy" crossorigin="anonymous"></script>
</body>

</html>