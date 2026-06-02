<?php
require_once 'conexao/conecta.php';


$sql = "SELECT * FROM produto WHERE status = 1";
$query = mysqli_query($conexao, $sql);
?>

<!DOCTYPE html>
<html lang="pt-br">

<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>Drop to Paradise</title>

  <!-- link da fonte do google fonts -->
  <link href="https://fonts.googleapis.com/css2?family=Acme&display=swap" rel="stylesheet">
  <!-- Bootstrap CSS -->
  <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css"
    integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous">

  <link rel="stylesheet" href="style.css">

  <link rel="stylesheet" href="owlcarousel/css/owl.carousel.min.css">
  <link rel="stylesheet" href="owlcarousel/css/owl.theme.default.min.css">

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
      <button class="navbar-toggler" data-toggle="collapse" data-target="#conteudoNavbarSuportado" aria-controls="conteudoNavbarSuportado" aria-expanded="false" aria-label="Alterna navegação" style="background-color: #284c9e;">
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



  <!-- inicio carousel -->
  <main>
    <div id="carouselExampleIndicators" class="carousel slide" data-ride="carousel">
      <ol class="carousel-indicators">
        <li data-target="#carouselExampleIndicators" data-slide-to="0" class="active"></li>
        <li data-target="#carouselExampleIndicators" data-slide-to="1"></li>
        <li data-target="#carouselExampleIndicators" data-slide-to="2"></li>
      </ol>
      <div class="carousel-inner">
        <div class="carousel-item active">
          <img class="d-block w-100" src="image/banner adidas.png" alt="Primeiro Slide">
        </div>
        <div class="carousel-item">
          <img class="d-block w-100" src="image/banner_lançamentos.png" alt="Segundo Slide">
        </div>
        <div class="carousel-item">
          <img class="d-block w-100" src="image/produtos drop.png" alt="Terceiro Slide">
        </div>
      </div>
      <a class="carousel-control-prev" href="#carouselExampleIndicators" role="button" data-slide="prev">
        <span class="carousel-control-prev-icon" aria-hidden="true"></span>
        <span class="sr-only">Anterior</span>
      </a>
      <a class="carousel-control-next" href="#carouselExampleIndicators" role="button" data-slide="next">
        <span class="carousel-control-next-icon" aria-hidden="true"></span>
        <span class="sr-only">Próximo</span>
      </a>
    </div><br><br>
    <!-- final do carousel -->

    <!-- produtos  -->
    <p class="textos"> Promoções</p><br><br>

    <section class="menu">
      <div class="container">
        <div class="row">
          <div class="owl-carousel owl-theme">
            <?php
            foreach ($query as $produto) {
              // SÓ PRODUTOS COM PROMO
              if ($produto['preco_promocao'] == 1) {
                $preco = $produto['preco_final_promo'];
            ?>
                <div class="item">
                  <div class="card" style="position: relative; ">
                    <?php
                    if (!empty($produto['foto'])) {
                      echo '<img class="card-img-top" src="images/' . $produto['foto'] . '" alt="Imagem do produto">';
                    } else {
                      echo '<img class="card-img-top" src="images/sem.webp" alt="Imagem padrão">';
                    }

                    echo '<span class="badge-promocao position-absolute top-0 start-0 bg-primary text-white p-1 m-2 rounded">Promoção</span>';
                    ?>
                    <div class="card-body d-flex flex-column justify-content-center align-items-center text-center" style="height: 100%;">
                      <h5 class="card-title" style="height: 25px; overflow: hidden;"><?php echo $produto['nome_produto']; ?></h5>

                      <p class="card-text">
                        <s>
                          <span class="preco-original text-dark text-decoration-line-through">R$
                            <?php echo number_format($produto['preco_venda'], 2, ',', '.'); ?>
                          </span>
                        </s>
                        <span class="preco text-primary fw-bold">R$
                          <?php echo number_format($produto['preco_final_promo'], 2, ',', '.'); ?>
                        </span>
                      </p>

                      <a class="btn btn-primary text-white" href="compra.php?codigo_produto=<?php echo $produto['codigo_produto'] ?>">Comprar</a>
                    </div>

                  </div>
                </div>
            <?php
              }
            }
            ?>
          </div>
        </div>
      </div>
    </section>




    <!-- categoria de skate -->
    <br><br>
    <p class="textos">Categoria sk8</p><br><br>




<div class="categoria">

    <!-- Montado -->
    <div>
        <a href="categoria.php?codigo_categoria=8">
            <img class="rounded-circle" src="image/SkateMontado.webp" alt="Montado" width="200" height="200"><br><br>
            <p class="text-dark">Montado</p>
        </a>
    </div>

    <!-- Shape -->
    <div>
        <a href="categoria.php?codigo_categoria=10">
            <img class="rounded-circle" src="image/ShapeJimi.webp" alt="Shape" width="200" height="200"><br><br>
            <p class="text-dark">Shape</p>
        </a>
    </div>

    <!-- Truck -->
    <div>
        <a href="categoria.php?codigo_categoria=11">
            <img class="rounded-circle" src="image/truck.webp" alt="Truck" width="200" height="200"><br><br>
            <p class="text-dark">Truck</p>
        </a>
    </div>

    <!-- Roda -->
    <div>
        <a href="categoria.php?codigo_categoria=12">
            <img class="rounded-circle" src="image/Roda.webp" alt="Roda" width="200" height="200"><br><br>
            <p class="text-dark">Roda</p>
        </a>
    </div>

    <!-- Rolamento -->
    <div>
        <a href="categoria.php?codigo_categoria=13">
            <img class="rounded-circle" src="image/rol.webp" alt="Rolamento" width="200" height="200"><br><br>
            <p class="text-dark">Rolamento</p>
        </a>
    </div>

    <!-- Lixa -->
    <div>
        <a href="categoria.php?codigo_categoria=14">
            <img class="rounded-circle" src="image/Lixa.jpg" alt="Lixa" width="200" height="200"><br><br>
            <p class="text-dark">Lixa</p>
        </a>
    </div>

</div>




    <!-- produtos lancamentos -->
    <br><br>
    <p class="textos">Laçamentos</p><br><br>

    <section class="menu">
      <div class="container">
        <div class="row">

          <div class="owl-carousel owl-theme">
            <?php
            foreach ($query as $produto) {
              $ComPromocao = $produto['preco_promocao'] == 1;
              $preco = $ComPromocao ? $produto['preco_final_promo'] : $produto['preco_venda'];

            ?>
              <div class="item">
                <div class="card" style=" position: relative;">
                  <?php
                  if ($produto['foto'] != '') {
                    echo '<img class="card-img-top" src="images/' . $produto['foto'] . '" alt="Imagem do produto">';
                  } else {
                    echo '<img class="card-img-top" src="images/sem.webp" alt="Imagem padrão">';
                  }

                  if ($ComPromocao) {
                    echo '<span class="badge-promocao position-absolute top-0 start-0 bg-primary text-white p-1 m-2 rounded">Promoção</span>';
                  }
                  ?>
                  <div class="card-body d-flex flex-column justify-content-center align-items-center text-center" style="height: 100%;">
                    <h5 class="card-title" style="height: 25px; overflow: hidden;"><?php echo $produto['nome_produto']; ?></h5>

                    <?php if ($ComPromocao): ?>
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
      </div>
    </section>


    <!-- categoria surf -->

    <br><br>
    <p class="textos">Categoria surf</p><br><br>

    <div class="categoria">

      <!-- prancha -->
      <div>
      <a href="categoria.php?codigo_categoria=15">
          <img class="rounded-circle" src="image/Prancha.webp" alt="" width="200" height="200"><br><br>
          <p class="text-dark">Prancha</p>
        </a>
      </div>

      <!-- quilha -->
      <div>
      <a href="categoria.php?codigo_categoria=16">
          <img class="rounded-circle" src="image/quilha.jpg" alt="" width="200" height="200"><br><br>
          <p class="text-dark">Quilha</p>
        </a>
      </div>

      <!-- leash=cordinha -->
      <div>
      <a href="categoria.php?codigo_categoria=17">
          <img class="rounded-circle" src="image/leash.webp" alt="" width="200" height="200"><br><br>
          <p class="text-dark">Leash</p>
        </a>
      </div>

      <!-- parafaina -->
      <div>
      <a href="categoria.php?codigo_categoria=18">
          <img class="rounded-circle" src="image/parafina.webp" alt="" width="200" height="200"><br><br>
          <p class="text-dark">Parafina</p>
        </a>
      </div>

      <!-- deck -->
      <div>
      <a href="categoria.php?codigo_categoria=19">
          <img class="rounded-circle" src="image/deck.webp" alt="" width="200" height="200"><br><br>
          <p class="text-dark">Deck</p>
        </a>
      </div>

      <!-- roupa de borracha -->
      <div>
      <a href="categoria.php?codigo_categoria=20">
          <img class="rounded-circle" src="image/roupaBorracha.webp" alt="" width="200" height="200"><br><br>
          <p class="text-dark">Roupa de borracha</p>
        </a>
      </div>

    </div><br><br>


    <!-- ofertas -->
    <style>
      .parallax {
        /* The image used */
        background-image: url("image/jao2.jpeg");

        /* Set a specific height */
        min-height: 00px;

        /* Create the parallax scrolling effect */
        background-attachment: fixed;
        background-position: center;
        background-repeat: no-repeat;
        background-size: cover;
        padding: 100px 0;

        background-size: cover;
        background-blend-mode: overlay;
        width: 100%;

        box-shadow: 3px 10px 25px #ccc;


      }
    </style>

    <!-- Container element -->
    <div class="parallax">
      <div class="container">
        <div class="row">
          <div class="col-12">
            <h2 class="text-white"><br>Saiba mais sobre a Drop!</h2><br>
            <a href="sobre.php" class="btn btn-outline-light py-3 px-4">Clique Aqui</a>

          </div>
        </div>
      </div>
    </div>



    </div>
    </div>
    </div>

    <!-- categoria roupas -->
    <br><br>
    <p class="textos">Categoria roupas</p><br><br>
    <div class="categoria">

      <!-- bone -->
      <div>
      <a href="categoria.php?codigo_categoria=21">
          <img class="rounded-circle" src="image/bone.webp" alt="" width="200" height="200"><br><br>
          <p class="text-dark">Boné</p>
        </a>
      </div>

      <!-- camisa -->
      <div>
      <a href="categoria.php?codigo_categoria=22">
          <img class="rounded-circle" src="image/camisa.webp" alt="" width="200" height="200"><br><br>
          <p class="text-dark">Camisa</p>
        </a>
      </div>

      <!-- moletom -->
      <div>
      <a href="categoria.php?codigo_categoria=23">
          <img class="rounded-circle" src="image/blusa.webp" alt="" width="200" height="200"><br><br>
          <p class="text-dark">Blusa</p>
        </a>
      </div>

      <!-- calça -->
      <div>
      <a href="categoria.php?codigo_categoria=24">
          <img class="rounded-circle" src="image/calsa.png" alt="" width="200" height="200"><br><br>
          <p class="text-dark">Calça</p>
        </a>
      </div>

      <!-- short -->
      <div>
      <a href="categoria.php?codigo_categoria=25">
          <img class="rounded-circle" src="image/bermuda.webp" alt="" width="200" height="200"><br><br>
          <p class="text-dark">Short</p>
        </a>
      </div>

      <!-- tenis -->
      <div>
      <a href="categoria.php?codigo_categoria=26">
          <img class="rounded-circle" src="image/tenis.webp" alt="" width="200" height="200"><br><br>
          <p class="text-dark">Tênis</p>
        </a>
      </div>

    </div>
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


  <!-- OWL CAROUSEL JS -->
  <script src="owlcarousel/js/jquery.min.js"></script>
  <script src="owlcarousel/js/owl.carousel.min.js"></script>



  <script>
    $('.owl-carousel').owlCarousel({
      loop: false,
      margin: 50,
      nav: true,
      responsive: {
        0: {
          items: 1
        },
        600: {
          items: 3
        },
        1000: {
          items: 5
        }
      }
    })
  </script>
</body>

</html>