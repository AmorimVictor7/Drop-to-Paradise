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
                               <!-- mensagem -->
                <?php include '../mensagem.php' ?>
                    <div class="card">
                        <div class="card-header d-flex justify-content-between align-items-center">
                            <h4 class="m-0">Novo Produto</h4>

                            <a href="index.php" class="btn btn-primary btn-sm">
                                <i class="bi bi-arrow-left"></i>
                                Voltar
                            </a>
                        </div>
                        <div class="card-body">
                            <form action="acoes.php" method="post" enctype="multipart/form-data">
                                <div class="col-12 mb-2 text-center">
                                    <input type="image" src="../../assets/img/placeholder-produto.jpg" id="preview-foto" name="foto" alt="foto" width="200" height="200"><br>
                                    <label for="image"><strong class="text-danger">*</strong>Foto do Produto</label><br>
                                    <input type="file" id="foto_produto" name="foto" accept="image/*" onchange="previewImagem(event)">
                                </div>
                                <div class="form-row">

                                    <!-- informações do produto -->

                                    <div class="form-group col-md-6">
                                        <label for="input">Nome:</label>
                                        <input type="text" name="nome_produto" class="form-control" required maxlength="60">
                                    </div>


                                    <!-- Preço custo -->
                                    <div class="form-group col-md-6">
                                        <label>Preço custo (R$):</label>
                                        <input type="number" name="preco_custo" id="preco_custo" class="form-control" required>
                                    </div>

                                    <!-- Lucro percentual -->
                                    <div class="form-group col-md-6">
                                        <label>Lucro (%):</label>
                                        <input type="number" name="preco_lucro" id="preco_lucro" class="form-control" required>
                                    </div>

                                    <!-- Preço venda (calculado automaticamente) -->
                                    <div class="form-group col-md-6">
                                        <label>Preço de venda (R$):</label>
                                        <input type="text" name="preco_venda" id="preco_venda" class="form-control" readonly>
                                    </div>


                                    <!-- Checkbox promoção -->
                                      <div class=" col-md-4 ">
                                        <label for="">Tem promoção?</label>
                                        <select name="preco_promocao" id="preco_promocao" class="form-control">
                                              <option value="0">Sem promoção</option>
                                              <option value="1">Com promoção</option>
                                        </select>
                                    </div>

                                    <!-- Desconto -->
                                    <div class="form-group col-md-4">
                                        <label>Desconto (%):</label>
                                        <input type="number" name="preco_desconto" id="preco_desconto" class="form-control" required>
                                    </div>

                                    <!-- Preço final com desconto -->
                                    <div class="form-group col-md-4">
                                        <label>Preço final com desconto:</label>
                                        <input type="text" name="preco_final_promo" id="preco_final_promo" class="form-control" readonly>
                                    </div>



                                    <!-- info das chaves estrangeiras -->
                                    <div class="form-group col-md-6">
                                        <label for="input">Marca:</label>
                                        <select name="nome_marca" id="marca" class="form-control" required>


                                            <?php
                                            $sql_marca = 'SELECT codigo_marca, nome_marca FROM marca WHERE status = 1'; //CRIA O CÓDIGO PARA MOSTRAR OS CARGO QUE ESTÃO ATIVOS
                                            $query_marca = mysqli_query($conexao, $sql_marca); //CONECTA COM O BANCO E EXECUTA O CÓDIGO
                                            $marca = mysqli_fetch_assoc($query_marca); //ARREY ASSOCIATIVO QUE POSSIBILITA CHAMAR AS FUNÇÕES PELO NOME EM VEZ DO ID

                                            do {
                                                echo '<option value="' . $marca['codigo_marca'] . '">' . $marca['nome_marca'] . '</option>';
                                            } while ($marca = mysqli_fetch_assoc($query_marca));

                                            ?>
                                        </select>
                                    </div>
                                    <div class="form-group col-md-6">
                                        <label for="input">Categoria:</label>
                                        <select name="nome_categoria" id="categoria" class="form-control" required>


                                            <?php
                                            $sql_categoria = 'SELECT codigo_categoria, nome_categoria FROM categoria WHERE status = 1'; //CRIA O CÓDIGO PARA MOSTRAR OS CARGO QUE ESTÃO ATIVOS
                                            $query_categoria = mysqli_query($conexao, $sql_categoria); //CONECTA COM O BANCO E EXECUTA O CÓDIGO
                                            $categoria = mysqli_fetch_assoc($query_categoria); //ARREY ASSOCIATIVO QUE POSSIBILITA CHAMAR AS FUNÇÕES PELO NOME EM VEZ DO ID

                                            do {
                                                echo '<option value="' . $categoria['codigo_categoria'] . '">' . $categoria['nome_categoria'] . '</option>';
                                            } while ($categoria = mysqli_fetch_assoc($query_categoria));

                                            ?>
                                        </select>
                                    </div>
                                    <div class=" col-md-6 ">
                                        <label for="">Quantidade:</label>
                                        <input type="number" name="quantidade" class="form-control" required maxlength="60">
                                    </div>
                                    <div class=" col-md-6 ">
                                        <label for="">Status:</label>
                                        <select name="status" class="form-control" disabled>
                                            <option value="1" selected>Ativo</option>
                                            <option value="0">inativo</option>
                                        </select>
                                    </div>
                                    <div class="col-12 mt-1">
                                        <label for="">Descrição:</label>
                                        <textarea maxlength="100" class="form-control" name="descricao"></textarea>
                                    </div>
                                    <div class="col-12 mt-1">
                                        <label for="">Observação:</label>
                                        <textarea maxlength="100" class="form-control" name="observacao"></textarea>
                                    </div>

                                    <div>
                                        <input type="hidden" name="cadastrar" value="cadastrar_produto">
                                        <input type="submit" value="Cadastrar" class="btn btn-primary btn-sm mt-2"></input>
                                    </div>

                            </form>

                        </div>
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