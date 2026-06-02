<?php
require_once 'conexao/conecta.php';

$id_categoria = intval($_GET['codigo_categoria'] ?? 0); // segurança: força ser número

// Buscar produtos dessa categoria
$sql = "SELECT * FROM produto WHERE status = 1 AND codigo_categoria = $id_categoria";
$query = mysqli_query($conexao, $sql);
$quantidade = mysqli_num_rows($query); // necessário para verificar se há resultados

// Buscar nome da categoria
$nome_categoria = '';
$resultCategoria = mysqli_query($conexao, "SELECT nome_categoria FROM categoria WHERE codigo_categoria = $id_categoria");
if ($row = mysqli_fetch_assoc($resultCategoria)) {
    $nome_categoria = $row['nome_categoria'];
}
?>
<!DOCTYPE html>
<html lang="pt-br">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Drop to Paradise - Categoria</title>
    <link rel="stylesheet" href="style.css">
    <!-- Fonte Google -->
    <link href="https://fonts.googleapis.com/css2?family=Acme&display=swap" rel="stylesheet">
    <!-- Bootstrap -->
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css"
        integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous">
    <link rel="stylesheet" href="style.css">

     <link rel="icon" type="image/icons8-surf-64.png" href="assets/img/favicon.png">
</head>

<body>
    <header>
        <div class="barra"></div>
        <div>
            <img src="image/wallpaper-removebg-preview.png" alt="logo da loja" class="logoloja">
        </div>
        <form class="barrapesquisa" action="busca.php" method="GET">
            <input class="form-control" type="search" name="busca" placeholder="O que você procura?" aria-label="Search">
            <button class="btn btn-btn-outline-primary text-white" type="submit">Buscar</button>
        </form>

        <nav class="navbar navbar-expand-lg" style="background-color: #284c9e;">
            <button class="navbar-toggler" data-toggle="collapse" data-target="#conteudoNavbarSuportado" aria-controls="conteudoNavbarSuportado" aria-expanded="false" aria-label="Alterna navegação" style="background-color: #284c9e;">
                <span class="text-white">. . . </span>
            </button>
            <div class="collapse navbar-collapse" id="conteudoNavbarSuportado">
                <ul class="navbar-nav mx-auto">
                    <li class="nav-item"><a class="nav-link" href="index.php">Home</a></li>
                    <li class="nav-item"><a class="nav-link" href="produto.php">Produto</a></li>
                    <li class="nav-item"><a class="nav-link" href="sobre.php">Sobre</a></li>
                </ul>
            </div>
        </nav>
    </header>

    <main class="container mt-5">
    <h2 class="mb-4">Produtos da categoria: <?php echo htmlspecialchars($nome_categoria); ?></h2>

    <div class="row">
      <?php if ($quantidade > 0): ?>
        <?php while ($produto = mysqli_fetch_assoc($query)): ?>
          <?php
            $emPromocao = $produto['preco_promocao'] == 1;
            $preco = $emPromocao ? $produto['preco_final_promo'] : $produto['preco_venda'];
          ?>
          <div class="col-md-4 mb-4 d-flex justify-content-center">
            <div class="card" style="width: 18rem; position: relative;">
              <?php
              if (!empty($produto['foto'])) {
                echo '<img class="card-img-top" src="images/' . $produto['foto'] . '" alt="Imagem do produto">';
              } else {
                echo '<img class="card-img-top" src="images/sem.webp" alt="Imagem padrão">';
              }

              if ($emPromocao) {
                echo '<span class="badge-promocao position-absolute top-0 start-0 bg-primary text-white p-1 m-2 rounded">Promoção</span>';
              }
              
              ?>
              <div class="card-body text-center">
                <h5 class="card-title"><?php echo $produto['nome_produto']; ?></h5>

                <?php if ($emPromocao): ?>
                  <p class="card-text">
                    <s>
                      <span class="preco-original text-dark text-decoration-line-through">R$
                        <?php echo number_format($produto['preco_venda'], 2, ',', '.'); ?>
                      </span>
                    </s><br>
                    <span class="preco text-primary fw-bold">R$
                      <?php echo number_format($produto['preco_final_promo'], 2, ',', '.'); ?>
                    </span>
                  </p>
                <?php else: ?>
                  <p class="card-text">
                    <span class="preco text-primary">R$ <?php echo number_format($preco, 2, ',', '.'); ?></span>
                  </p>
                <?php endif; ?>

               <a class="btn btn-primary text-white" href="compra.php?codigo_produto=<?php echo $produto['codigo_produto'] ?>">Comprar</a>
              </div>
            </div>
          </div>
        <?php endwhile; ?>
      <?php else: ?>
        <div class="col-12">
          <h5 class="text-center">Nenhum produto encontrado nesta categoria.</h5>
        </div>
      <?php endif; ?>
    </div>
  </main>

    <footer style="background-color: #284c9e; padding: 40px 20px; border-top: 3px solid #203f86;">
        <div style="display: flex; justify-content: space-between; max-width: 1000px; margin: auto; flex-wrap: wrap;">
            <div style="flex: 1; min-width: 200px;">
                <h3 style="font-size: 16px; font-weight: bold;">NAVEGAÇÃO</h3>
                <p><a href="index.php" class="text-white">Home</a></p>
                <p><a href="produto.php" class="text-white">Produtos</a></p>
                <p><a href="sobre.php" class="text-white">Sobre</a></p>
            </div>

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

            <div style="flex: 1; min-width: 200px;">
                <h3 style="font-size: 16px; font-weight: bold;">REDES SOCIAIS</h3>
                <p><a href="https://www.facebook.com/" target="_blank" class="text-white"><img src="image/icons8-facebook-30.png"> Facebook</a></p>
                <p><a href="https://www.instagram.com/" target="_blank" class="text-white"><img src="image/icons8-instagram-30.png"> Instagram</a></p>
                <p><a href="https://www.youtube.com/" target="_blank" class="text-white"><img src="image/icons8-youtube-30.png"> Youtube</a></p>
                <p><a href="https://www.tiktok.com/" target="_blank" class="text-white"><img src="image/icons8-tiktok-30.png"> Tiktok</a></p>
            </div>
        </div>
    </footer>

    <!-- Scripts Bootstrap -->
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js" crossorigin="anonymous"></script>

</body>
</html>
