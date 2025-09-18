<?php
require_once 'conexao/conecta.php';

if (!isset($_GET['codigo_produto']) || !is_numeric($_GET['codigo_produto'])) {
    // Poderia adicionar tratamento de erro aqui
}

$id = intval($_GET['codigo_produto']);

$sql = "SELECT produto.codigo_produto, produto.nome_produto, produto.foto, categoria.nome_categoria, produto.preco_venda, produto.status, produto.preco_promocao, produto.preco_final_promo, produto.descricao, produto.codigo_categoria FROM produto INNER JOIN categoria ON produto.codigo_categoria = categoria.codigo_categoria WHERE produto.status = 1 AND produto.codigo_produto = $id";
$query = mysqli_query($conexao, $sql);

$produto = mysqli_fetch_assoc($query);

$codigo_categoria = $produto['codigo_categoria'];

$sqlRelacionados = "SELECT * FROM produto WHERE codigo_categoria = $codigo_categoria AND status = 1 AND codigo_produto != $id LIMIT 4";

$resultRelacionados = mysqli_query($conexao, $sqlRelacionados);

// Converte resultado para array associativo
$produtosRelacionados = mysqli_fetch_all($resultRelacionados, MYSQLI_ASSOC);

$emPromocao = $produto['preco_promocao'] == 1;
$preco = $emPromocao ? $produto['preco_final_promo'] : $produto['preco_venda'];

?>

<!DOCTYPE html>
<html lang="pt-br">

<head>
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <title>Drop to Paradise - compra</title>
    <link rel="stylesheet" href="style.css" />
    <!-- Fonte Google -->
    <link href="https://fonts.googleapis.com/css2?family=Acme&display=swap" rel="stylesheet" />
    <!-- Bootstrap -->
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css"
        integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous" />
    <link rel="stylesheet" href="style.css" />

    <link rel="icon" type="image/icons8-surf-64.png" href="assets/img/favicon.png" />
</head>

<body>
    <header>
        <div class="barra"></div>
        <div>
            <img src="image/wallpaper-removebg-preview.png" alt="logo da loja" class="logoloja" />
        </div>
        <form class="barrapesquisa" action="busca.php" method="GET">
            <input class="form-control" type="search" name="busca" placeholder="O que você procura?" aria-label="Search" />
            <button class="btn btn-btn-outline-primary text-white" type="submit">Buscar</button>
        </form>

        <nav class="navbar navbar-expand-lg" style="background-color: #284c9e;">
            <button class="navbar-toggler" data-toggle="collapse" data-target="#conteudoNavbarSuportado"
                aria-controls="conteudoNavbarSuportado" aria-expanded="false" aria-label="Alterna navegação"
                style="background-color: #284c9e;">
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

    <main class="container mt-3">
        <div class="container produto-detalhe">
            <div class="produto-img">
                <?php
                if (!empty($produto['foto'])) {
                    echo '<img class="card-img-top" src="images/' . $produto['foto'] . '" alt="Imagem do produto">';
                } else {
                    echo '<img class="card-img-top" src="images/sem.webp" alt="Imagem padrão">';
                }
                ?>
            </div>

            <div class="col-md-6 col-12 d-flex flex-column justify-content-center align-items-start text-start custom-produto">

                <h2><?php echo $produto['nome_produto']; ?></h2>
                <p><?php echo ($produto['descricao']); ?></p>

                <div class="preco">
                    <?php if ($emPromocao): ?>
                        <s>R$ <?php echo number_format($produto['preco_venda'], 2, ',', '.'); ?></s>
                        <strong>R$ <?php echo number_format($produto['preco_final_promo'], 2, ',', '.'); ?></strong>
                    <?php else: ?>
                        <strong>R$ <?php echo number_format($produto['preco_venda'], 2, ',', '.'); ?></strong>
                    <?php endif; ?>
                </div>

                <button class="btn btn-pedido">Comprar</button>
            </div>
        </div>

        <div class="result" style="display: flex; justify-content: center; align-items: center;">
            <h2 style="color: #284c9e;">Produtos Relacionados:</h2>
        </div>

        <div class="row mt-4">
            <?php foreach ($produtosRelacionados as $rel):
                $ComPromocao = $rel['preco_promocao'] == 1;
                $preco = $ComPromocao ? $rel['preco_final_promo'] : $rel['preco_venda'];
            ?>
                <div class="col-md-3 col-sm-6 mb-4">
                    <div class="card h-100" style="position: relative;">
                        <?php
                        if (!empty($rel['foto'])) {
                            echo '<img class="card-img-top" src="images/' . $rel['foto'] . '" alt="Imagem do produto">';
                        } else {
                            echo '<img class="card-img-top" src="images/sem.webp" alt="Imagem padrão">';
                        }
                        if ($ComPromocao) {
                            echo '<span class="badge-promocao position-absolute top-0 start-0 bg-primary text-white p-1 m-2 rounded">Promoção</span>';
                        }
                        ?>
                        <div class="card-body d-flex flex-column justify-content-center align-items-center text-center" style="height: 100%;">
                            <h5 class="card-title" style="height: 25px; overflow: hidden;"><?php echo $rel['nome_produto']; ?></h5>
                            <?php if ($ComPromocao): ?>
                                <p class="card-text">
                                    <s><span class="preco-original text-dark text-decoration-line-through">R$ <?php echo number_format($rel['preco_venda'], 2, ',', '.'); ?></span></s><br>
                                    <span class="preco text-primary fw-bold">R$ <?php echo number_format($rel['preco_final_promo'], 2, ',', '.'); ?></span>
                                </p>
                            <?php else: ?>
                                <p class="card-text">
                                    <span class="preco text-primary">R$ <?php echo number_format($preco, 2, ',', '.'); ?></span>
                                </p>
                            <?php endif; ?>
                            <a class="btn btn-primary text-white" href="compra.php?codigo_produto=<?php echo $rel['codigo_produto']; ?>">Comprar</a>
                        </div>
                    </div>
                </div>
            <?php endforeach; ?>
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
                        <img src="image/icons8-whatsapp-30.png" alt="WhatsApp" /> 19 99960-9734
                    </a>
                </p>
                <p>
                    <a href="mailto:droptoparadise@157.com.br" class="text-white">
                        <img src="image/icons8-gmail-novo-30.png" alt="Email" /> droptoparadise@511.com.br
                    </a>
                </p>
                <p>
                    <img src="image/icons8-relógio-30.png" alt="Relógio" />
                    Horários de Funcionamento<br />
                    <span style="font-size: 14px;">Segunda à sexta das 05:30 às 17:30</span>
                </p>
            </div>

            <div style="flex: 1; min-width: 200px;">
                <h3 style="font-size: 16px; font-weight: bold;">REDES SOCIAIS</h3>
                <p><a href="https://www.facebook.com/" target="_blank" class="text-white"><img src="image/icons8-facebook-30.png" /> Facebook</a></p>
                <p><a href="https://www.instagram.com/" target="_blank" class="text-white"><img src="image/icons8-instagram-30.png" /> Instagram</a></p>
                <p><a href="https://www.youtube.com/" target="_blank" class="text-white"><img src="image/icons8-youtube-30.png" /> Youtube</a></p>
                <p><a href="https://www.tiktok.com/" target="_blank" class="text-white"><img src="image/icons8-tiktok-30.png" /> Tiktok</a></p>
            </div>
        </div>
    </footer>

    <style>
        .custom-produto {
            min-height: 500px;
            /* altura padrão para desktop */
            padding: 20px;
        }

        @media (max-width: 768px) {
            .custom-produto {
                min-height: auto;
                /* remove altura fixa em mobile */
                align-items: center !important;
                text-align: center !important;
            }
        }

        .produto-detalhe {
            display: flex;
            flex-wrap: wrap;
            align-items: flex-start;
            justify-content: center;
            padding: 40px;
            background: white;
            box-shadow: 0px 2px 10px rgba(0, 0, 0, 0.05);
            margin: 30px auto;
            max-width: 1100px;
            border-radius: 10px;
        }

        .produto-img {
            flex: 1 1 300px;
            text-align: center;
            padding: 20px;
        }

        .produto-img img {
            max-width: 100%;
            border-radius: 10px;
            box-shadow: 0px 2px 8px rgba(0, 0, 0, 0.1);
        }

        .produto-info {
            flex: 1 1 500px;
            padding: 20px;
        }

        .produto-info h2 {
            font-size: 2rem;
            font-weight: 700;
        }

        .produto-info p {
            font-size: 1rem;
            margin-top: 10px;
        }

        .preco {
            font-size: 1.5rem;
            margin-top: 20px;
        }

        .preco s {
            color: #777;
            margin-right: 10px;
        }

        .preco strong {
            color: #284c9e;
        }

        .btn-pedido {
            background-color: #284c9e;
            color: white;
            font-weight: bold;
            border: none;
            padding: 12px 24px;
            border-radius: 5px;
            font-size: 16px;
            margin-top: 25px;
            cursor: pointer;
            transition: background 0.3s ease;
        }

        .btn-pedido:hover {
            background-color: #0e2763ff;
        }

        .info-adicional {
            margin-top: 40px;
        }

        .info-adicional h4 {
            font-weight: bold;
            cursor: pointer;
            margin-top: 20px;
        }

        .info-adicional-content {
            display: none;
            margin-top: 10px;
            font-size: 0.95rem;
        }

        @media (max-width: 768px) {
            .produto-detalhe {
                flex-direction: column;
            }
        }
    </style>

    <!-- Scripts Bootstrap -->
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js" crossorigin="anonymous"></script>
</body>

</html>