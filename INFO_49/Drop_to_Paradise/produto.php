<?php
require_once 'conexao/conecta.php';

// CONSULTA OS PRODUTOS DO BANCO



$sql_cont = "SELECT codigo_produto FROM  produto WHERE status = 1 ";
$query_cont = mysqli_query($conexao, $sql_cont);
$quantidade = mysqli_num_rows($query_cont);

if (isset($_GET['pagina']) && !empty($_GET['pagina'])) {
  $paginaAtual = $_GET['pagina'];
} else {
  $paginaAtual = 1;
}

$url = "?pagina=";

//QUANTIDADE DE PRODUTOS EM CADA PAGINA
$paginaQuantidade = 6;

//VALOR INICIAL PARA A CLÁUSULA LIMIT
$ValorInicial = ($paginaAtual * $paginaQuantidade) - $paginaQuantidade;

$paginaFInal = ceil($quantidade / $paginaQuantidade);

$paginaInicial = 1;


$paginaProxima = $paginaAtual + 1;

$paginaAnterior = $paginaAtual - 1;

$sql = "SELECT * FROM produto WHERE status = 1 LIMIT $ValorInicial, $paginaQuantidade";
$query = mysqli_query($conexao, $sql);
?>



<!DOCTYPE html>
<html lang="pt-br">

<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>Drop to Paradise</title>
  <link rel="stylesheet" href="style.css">
  <!-- link da fonte do google fonts -->
  <link href="https://fonts.googleapis.com/css2?family=Acme&display=swap" rel="stylesheet">
  <!-- Bootstrap CSS -->
  <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css"
    integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous">

  <link rel="stylesheet" href="style.css">

   <link rel="icon" type="image/icons8-surf-64.png" href="assets/img/favicon.png">
   
</head>

<body>
<header>

<!-- barra azul em cima de tudo -->
<div class="barra"></div>

<!-- logoloja no canto esquerdo  -->
<div>
  <img src="image/wallpaper-removebg-preview.png" alt="logo da loja" class="logoloja">
</div>

<!-- Barra de pesquisa  -->
<form class="barrapesquisa" action="busca.php" method="GET">
  <input class="form-control " type="search" name="busca" placeholder="O que você procura?" aria-label="Search">
  <button class="btn btn-btn-outline-primary text-white" type="submit"> Buscar</button>
</form>




<!-- menu de navegação -->

<nav class="navbar navbar-expand-lg" style="background-color: #284c9e;">
  <button class="navbar-toggler"  data-toggle="collapse" data-target="#conteudoNavbarSuportado" aria-controls="conteudoNavbarSuportado" aria-expanded="false" aria-label="Alterna navegação" style="background-color: #284c9e;">
    <span class="text-white">. . . </span>
  </button>

  <div class="collapse navbar-collapse" id="conteudoNavbarSuportado">
    <ul class="navbar-nav mx-auto">
      <li class="nav-item">
        <a class="nav-link" href="index.php">Home</a>
      </li>
      <li class="nav-item">
        <a class="nav-link" href="produto.php">Produto</a>
      </li>
      <li class="nav-item">
        <a class="nav-link" href="sobre.php">Sobre</a>
      </li>

      <li class="nav-item dropdown">
        <div class="dropdown-menu" aria-labelledby="navbarDropdown">
          <a class="dropdown-item" href="#">Ação</a>
          <a class="dropdown-item" href="#">Outra ação</a>
          <div class="dropdown-divider"></div>
          <a class="dropdown-item" href="#">Algo mais aqui</a>
        </div>
      </li>
    </ul>
  </div>
</nav>
</header>
  <main>

    <p class="textos">Produtos</p><br>
    <section class="menu">
      <div class="container">
        <div class="row">

          <?php
          while ($produto = mysqli_fetch_assoc($query)) {
            $emPromocao = $produto['preco_promocao'] == 1;
            $preco = $emPromocao ? $produto['preco_fina_promo'] : $produto['preco_venda'];
          ?>
            <div class="col-md-4 mb-4 d-flex justify-content-center">
              <div class="card" style="width: 18rem; position: relative;">
                <?php
                if ($produto['foto'] != '') {
                  echo '<img class="card-img-top" src="images/' . $produto['foto'] . '" alt="Imagem do produto">';
                } else {
                  echo '<img class="card-img-top" src="images/sem.webp" alt="Imagem padrão">';
                }

                if ($emPromocao) {
                  echo '<span class="badge-promocao position-absolute top-0 start-0 bg-primary text-white p-1 m-2 rounded">Promoção</span>';
                }
                ?>
                <div class="card-body">
                  <h5 class="card-title"><?php echo $produto['nome_produto']; ?></h5>

                  <?php if ($emPromocao): ?>
                    <p class="card-text">
                      <s><span class="preco-original text-dark text-decoration-line-through">R$
                          <?php echo number_format($produto['preco_venda'], 2, ',', '.'); ?></span></s>
                      <span class="preco text-primary fw-bold">R$
                        <?php echo number_format($produto['preco_final_promo'], 2, ',', '.'); ?></span>
                    </p>
                  <?php else: ?>
                    <p class="card-text">
                      <span class="preco text-primary text-decoration-line-through">R$ <?php echo number_format($preco, 2, ',', '.'); ?></span>
                    </p>
                  <?php endif; ?>

                  <a class="btn btn-primary text-white" href="compra.php?codigo_produto=<?php echo $produto['codigo_produto'] ?>">Comprar</a>
                </div>
              </div>
            </div>
          <?php } ?>

        </div>
      </div>
    </section>


    <nav aria-label="paginacao">
      <ul class="pagination justify-content-center">

        <?php if ($paginaAtual != $paginaInicial) { ?>
          <li class="page-item">
            <a class="page-link" href="<?php echo $url . $paginaInicial ?>">Início</a>
          </li>
        <?php } ?>

        <?php if ($paginaAtual >= 2) { ?>
          <li class="page-item">
            <a class="page-link" href="<?php echo $url . $paginaAnterior ?>" aria-label="Previous">
              <span aria-hidden="true">&laquo;</span>
            </a>
          </li>
        <?php } ?>

        <?php if ($paginaAtual != $paginaFInal) { ?>
          <li class="page-item">
            <a class="page-link" href="<?php echo $url . $paginaProxima ?>" aria-label="Next">
              <span aria-hidden="true">&raquo;</span>
            </a>
          </li>

          <li class="page-item">
            <a class="page-link" href="<?php echo $url . $paginaFInal ?>">Final</a>
          </li>
        <?php } ?>

      </ul>
    </nav>


  </main>

  <footer style="background-color: #284c9e; padding: 40px 20px; border-top: 3px solid #203f86;">
    <div style="display: flex; justify-content: space-between; max-width: 1000px; margin: auto; flex-wrap: wrap;">

      <!-- PARTE DA NAVEGAÇÃO -->
      <div style="flex: 1; min-width: 200px;">
        <h3 style="font-size: 16px; font-weight: bold;">NAVEGAÇÃO</h3>
        <p><a href="index.php" class="text-white">Home</a></p>
        <p><a href="produto.php" class="text-white">Produtos</a></p>
        <p><a href="sobre.php" class="text-white">Sobre</a></p>
      </div>

      <!-- PARTE DO ATENDIMENTO -->
      <div style="flex: 1; min-width: 200px;">
        <h3 style="font-size: 16px; font-weight: bold;">ATENDIMENTO</h3>
        <p>
          <a href="https://wa.me/5519999604327" target="_blank" class="text-white">
            <img src="image/icons8-whatsapp-30.png" alt="WhatsApp"> 19 99960-9734
          </a>
        </p>
        <p>
          <a href="mailto:droptoparadise@157.com.br" class="text-white">
            <img src="image/icons8-gmail-novo-30.png" alt="Email"> droptoparadise@511.com.br
          </a>
        </p>
        <p>
          <img src="image/icons8-relógio-30.png" alt="Relógio">
          Horários de Funcionamento<br>
          <span style="font-size: 14px;">Segunda à sexta das 05:30 às 17:30</span>
        </p>
      </div>

      <!-- PARTE DAS REDES SOCIAIS -->
      <div style="flex: 1; min-width: 200px;">
        <h3 style="font-size: 16px; font-weight: bold;">REDES SOCIAIS</h3>
        <p>
          <a href="https://www.facebook.com/" target="_blank" class="text-white">
            <img src="image/icons8-facebook-30.png" alt="Facebook" style="vertical-align: middle;"> Facebook
          </a>
        </p>
        <p>
          <a href="https://www.instagram.com/" target="_blank" class="text-white">
            <img src="image/icons8-instagram-30.png" alt="Instagram" style="vertical-align: middle;"> Instagram
          </a>
        </p>
        <p>
          <a href="https://www.youtube.com/" target="_blank" class="text-white">
            <img src="image/icons8-youtube-30.png" alt="Youtube" style="vertical-align: middle;"> Youtube
          </a>
        </p>
        <p>
          <a href="https://www.tiktok.com/" target="_blank" class="text-white">
            <img src="image/icons8-tiktok-30.png" alt="Tiktok" style="vertical-align: middle;"> Tiktok
          </a>
        </p>
      </div>

    </div>
  </footer>
  <!-- jQuery primeiro, depois Popper.js, depois Bootstrap JS -->


  <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js"
    integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
  <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js"
    integrity="sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49" crossorigin="anonymous"></script>
  <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js"
    integrity="sha384-ChfqqxuZUCnJSK3+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy" crossorigin="anonymous"></script>



</body>

</html>