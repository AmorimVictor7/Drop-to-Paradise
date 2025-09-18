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
    <title>Drop to Paradise - produto</title>

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

                    <?php
                    if (isset($_GET['codigo_produto']) && $_GET['codigo_produto'] != '') {
                        $codigo = $_GET['codigo_produto'];
                        $sql = "SELECT * FROM produto WHERE codigo_produto = $codigo";
                        $query = mysqli_query($conexao, $sql);
                        $produto = mysqli_fetch_assoc($query);
                    ?>

                        <div class="card">
                            <div class="card-header d-flex justify-content-between align-items-center">
                                <h4 class="m-0">Atualizar Produto</h4>

                                <a href="index.php" class="btn btn-primary btn-sm">
                                    <i class="bi bi-arrow-left"></i>
                                    Voltar
                                </a>
                            </div>
                            <div class="card-body">
                                <form action="acoes.php" method="post" enctype="multipart/form-data">
                                    <div class="col-12 mb-2 text-center">
                                        <?php
                                        $foto = !empty($produto['foto']) ? '../../images/' . $produto['foto'] : '../../assets/img/placeholder-produto.jpg';
                                        ?>
                                        <div class="col-12 mb-2 text-center">
                                            <img src="<?php echo $foto; ?>" id="preview-foto" alt="foto do produto" width="200" height="200"><br>
                                            <label for="foto_produto"><strong class="text-danger">*</strong>Foto do Produto</label><br>
                                            <input type="file" id="foto_produto" name="foto" accept="image/*" onchange="previewImagem(event)">
                                        </div>

                                    </div>
                                    <div class="form-row">

                                        <!-- informações do produto -->

                                        <div class="form-group col-md-6">
                                            <label for="input">Nome:</label>
                                            <input type="text" name="nome_produto" class="form-control" required value="<?php echo $produto['nome_produto'] ?>">
                                        </div>



                                        <!-- Preço custo -->
                                        <div class="form-group col-md-6">
                                            <label>Preço custo (R$):</label>
                                            <input type="number" name="preco_custo" id="preco_custo" class="form-control" required value="<?php echo $produto['preco_custo'] ?>">
                                        </div>


                                        <!-- Lucro percentual -->
                                        <div class="form-group col-md-6">
                                            <label>Lucro (%):</label>
                                            <input type="number" name="preco_lucro" id="preco_lucro" class="form-control" required value="<?php echo $produto['preco_lucro'] ?>">
                                        </div>


                                        <!-- Preço venda (calculado automaticamente) -->
                                        <div class="form-group col-md-6">
                                            <label>Preço de venda (R$):</label>
                                            <input type="text" name="preco_venda" id="preco_venda" class="form-control" readonly value="<?php echo $produto['preco_venda'] ?>">
                                        </div>



                                        <!-- Checkbox promoção -->
                                        <div class=" col-md-4">
                                            <label for="">Tem promoção?</label>
                                            <select name="preco_promocao" id="preco_promocao" class="form-control " value="<?php echo $produto['preco_promocao'] ?>">
                                                <option value="1" <?php if ($produto['preco_promocao'] == 1) echo 'selected' ?>>Com promoção</option>
                                                <option value="0" <?php if ($produto['preco_promocao'] == 0) echo 'selected' ?>>Sem promoção</option>
                                            </select>
                                        </div>

                                        <!-- Desconto -->
                                        <div class="form-group col-md-4">
                                            <label>Desconto (%):</label>
                                            <input type="number" name="preco_desconto" id="preco_desconto" class="form-control" value="<?php echo $produto['preco_desconto'] ?>">
                                        </div>

                                        <!-- Preço final com desconto -->
                                        <div class="form-group col-md-4">
                                            <label>Preço final com desconto:</label>
                                            <input type="text" name="preco_final_promo" id="preco_final_promo" class="form-control" value="<?php echo $produto['preco_final_promo'] ?>" readonly>
                                        </div>

                                        <!-- info das chaves estrangeiras -->
                                        <div class="form-group col-md-6">
                                            <label for="input">Marca:</label>
                                            <select name="codigo_marca" id="marca" class="form-control" required>
                                                <?php
                                                $sql_marca = 'SELECT codigo_marca, nome_marca FROM marca WHERE status = 1';
                                                $query_marca = mysqli_query($conexao, $sql_marca);
                                                while ($marca = mysqli_fetch_assoc($query_marca)) {
                                                ?>
                                                    <option value="<?php echo $marca['codigo_marca'] ?>" <?php if ($produto['codigo_marca'] == $marca['codigo_marca']) echo 'selected' ?>>
                                                        <?php echo $marca['nome_marca'] ?>
                                                    </option>
                                                <?php } ?>
                                            </select>
                                        </div>
                                        <div class="form-group col-md-6">
                                            <label for="input">Categoria:</label>
                                            <select name="codigo_categoria" id="categoria" class="form-control" required>
                                                <?php
                                                $sql_categoria = 'SELECT codigo_categoria, nome_categoria FROM categoria WHERE status = 1';
                                                $query_categoria = mysqli_query($conexao, $sql_categoria);
                                                while ($categoria = mysqli_fetch_assoc($query_categoria)) {
                                                ?>
                                                    <option value="<?php echo $categoria['codigo_categoria'] ?>" <?php if ($produto['codigo_categoria'] == $categoria['codigo_categoria']) echo 'selected' ?>>
                                                        <?php echo $categoria['nome_categoria'] ?>
                                                    </option>
                                                <?php } ?>
                                            </select>
                                        </div>
                                        <div class=" col-md-6 ">
                                            <label for="">Quantidade:</label>
                                            <input type="number" name="quantidade" class="form-control" required maxlength="60" value="<?php echo $produto['quantidade'] ?>">
                                        </div>
                                        <div class=" col-md-6 ">
                                            <label for="">Status:</label>
                                            <select name="status" class="form-control " value="<?php echo $produto['status'] ?>">
                                                <option value="1" <?php if ($produto['status'] == 1) echo 'selected' ?>>Ativo</option>
                                                <option value="0" <?php if ($produto['status'] == 0) echo 'selected' ?>>inativo</option>
                                            </select>
                                        </div>
                                        <div class="col-12 mt-1">
                                            <label for="">Descrição:</label>
                                            <textarea maxlength="100" class="form-control" name="descricao"><?php echo $produto['descricao'] ?></textarea>
                                        </div>

                                        <div class="col-12 mt-1">
                                            <label for="">Observação:</label>
                                            <textarea maxlength="100" class="form-control" name="observacao"><?php echo $produto['observacao'] ?></textarea>
                                        </div>

                                        <div>
                                            <input type="hidden" name="atualizar" value="atualizar_produto">
                                            <input type="hidden" name="codigo_produto" value="<?php echo $codigo ?>">
                                            <input type="submit" value="Atualizar" class="btn btn-primary btn-sm mt-2"></input>
                                        </div>

                                </form>

                            </div>
                        </div>
                     <?php
                     } else {
                        echo "<h5> Produto não encontrado! </h5>";
                    }
                    ?>
               </div>
            </main>
        </div>
    </div>


    <!-- BOOTSTRAP JS -->
    <script src="https://code.jquery.com/jquery-3.7.1.min.js" integrity="sha256-/JqT3SQfawRcv/BIHPThkBvs0OEvtFFmqPF/lYI/Cxo=" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js" integrity="sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js" integrity="sha384-ChfqqxuZUCnJSK3+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy" crossorigin="anonymous"></script>

    <!-- JQUERY MASK -->
    <script src="../../js/jquery.mask.js"></script>

    <script src="../../js/foto.js"></script>


    <script src="../../js/preco.js"></script>


</body>


</html>