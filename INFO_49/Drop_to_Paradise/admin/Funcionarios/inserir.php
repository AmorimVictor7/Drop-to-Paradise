<?php

//CONNEXÃO COM O BANCO DE DADOS #
require_once '../../conexao/conecta.php';

include_once '../usuario_admin.php';

?>

<!doctype html>
<html lang="pt-br">

<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta name="description" content="">
    <meta name="author" content="">
    <title>Drop to Paradise - Funcionario</title>

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
                            <h4 class="m-0">Novo Funcionário</h4>

                            <a href="index.php" class="btn btn-primary btn-sm">
                                <i class="bi bi-arrow-left"></i>
                                Voltar
                            </a>
                        </div>
                        <div class="card-body">
                            <form action="acoes.php" method="post" enctype="multipart/form-data">
                                <div>
                                    <div class="col-12 mb-2 text-center">
                                        <input type="image" src="../../assets/img/placeholder-produto.jpg" id="preview-foto" name="foto" alt="foto" width="200" height="200"><br>
                                        <label for="image"><strong class="text-danger">*</strong>Foto do Funcionario</label><br>
                                        <input type="file" id="foto_produto" name="foto" accept="image/*" onchange="previewImagem(event)">
                                    </div>
                                </div>
                                <div class="form-row">

                                    <!-- informações do funcionario -->

                                    <div class="form-group col-md-6">
                                        <label for="input">Nome:</label>
                                        <input type="text" name="nome" class="form-control" required maxlength="60">
                                    </div>
                                    <div class="form-group col-md-6">
                                        <label for="input">Nome Social:</label>
                                        <input type="text" name="nome_social" class="form-control" maxlength="60">
                                    </div>
                                    <div class="form-group col-md-6">
                                        <label for="input">Data Nascimento:</label>
                                        <input type="date" name="data_nascimento" class="form-control" required>
                                    </div>
                                    <div class=" col-md-6">
                                        <label for="">Sexo:</label>
                                        <select name="sexo" class="form-control">
                                            <option value="M" selected>Masculino</option>
                                            <option value="F">Feminino</option>
                                            <option value="N">Não informado</option>
                                        </select>
                                    </div>
                                    <div class="form-group col-md-6">
                                        <label for="input">CPF:</label>
                                        <input type="text" name="cpf" class="form-control" required maxlength="14" data-mask="000.000.000-00">
                                    </div>
                                    <div class="form-group col-md-6">
                                        <label for="input">RG:</label>
                                        <input type="text" name="rg" class="form-control" maxlength="12" data-mask="00.000.000-A">
                                    </div>
                                    <div class="form-group col-md-6">
                                        <label for="input">Estado Civil: </label>
                                        <select name="estado_civil" id="estado_civil" class="form-control">
                                            <option value="Solteiro(a)" selected>Solteiro(a)</option>
                                            <option value="Casado(a)">Casado(a)</option>
                                            <option value="Separado(a)">Separado(a)</option>
                                            <option value="Divorciado(a)">Divorciado(a)</option>
                                            <option value="Viúvo(a)">Viúvo(a)</option>
                                        </select>
                                    </div>

                                    <!-- contato do funcionario -->
                                    <div class="form-group col-md-6">
                                        <label for="input">E-mail:</label>
                                        <input type="text" name="email" class="form-control" maxlength="50">
                                    </div>
                                    <div class="form-group col-md-6">
                                        <label for="input">Telefone celular:</label>
                                        <input type="text" name="telefone_celular" class="form-control" maxlength="14" data-mask="(00)00000-0000">
                                    </div>
                                    <div class="form-group col-md-6">
                                        <label for="input">Telefone Residencial:</label>
                                        <input type="text" name="telefone_residencial" class="form-control" maxlength="13" data-mask="(00)0000-0000">
                                    </div>

                                    <!-- endereço do funcionario -->
                                    <div class="form-group col-md-6">
                                        <label for="input">CEP:</label>
                                        <input type="text" name="cep" id="cep" class="form-control" maxlength="9" data-mask="00000-000" required>
                                    </div>
                                    <div class="form-group col-md-6">
                                        <label for="input">Endereço:</label>
                                        <input type="text" name="endereco" id="endereco" class="form-control" maxlength="70">
                                    </div>
                                    <div class="form-group col-md-6">
                                        <label for="input">Bairro:</label>
                                        <input type="text" name="bairro" id="bairro" class="form-control" maxlength="30">
                                    </div>
                                    <div class="form-group col-md-6">
                                        <label for="input">Número:</label>
                                        <input type="number" name="numero" class="form-control">
                                    </div>

                                    <div class="form-group col-md-6">
                                        <label for="input">Cidade:</label>
                                        <input type="text" name="cidade" id="cidade" class="form-control" maxlength="40">
                                    </div>
                                    <div class="col-6">
                                        <label for="estado"><strong class="text-danger">*</strong>Estado: </label>
                                        <select class="form-control" name="estado" id="estado" required>
                                            <option value="AC">AC</option>
                                            <option value="AL">AL</option>
                                            <option value="AP">AP</option>
                                            <option value="AM">AM</option>
                                            <option value="BA">BA</option>
                                            <option value="CE">CE</option>
                                            <option value="DF">DF</option>
                                            <option value="ES">ES</option>
                                            <option value="GO">GO</option>
                                            <option value="MA">MA</option>
                                            <option value="MT">MT</option>
                                            <option value="MS">MS</option>
                                            <option value="MG">MG</option>
                                            <option value="PA">PA</option>
                                            <option value="PB">PB</option>
                                            <option value="PR">PR</option>
                                            <option value="PE">PE</option>
                                            <option value="PI">PI</option>
                                            <option value="RJ">RJ</option>
                                            <option value="RN">RN</option>
                                            <option value="RS">RS</option>
                                            <option value="RO">RO</option>
                                            <option value="RR">RR</option>
                                            <option value="SC">SC</option>
                                            <option value="SP" selected>SP</option>
                                            <option value="SE">SE</option>
                                            <option value="TO">TO</option>
                                        </select>
                                    </div>
                                    <div class="form-group col-md-6">
                                        <label for="input">Complemento:</label>
                                        <input type="text" name="complemento" class="form-control" maxlength="40">
                                    </div>

                                    <!-- info do funcionario -->
                                    <div class="form-group col-md-6">
                                        <label for="input">Cargo:</label>
                                        <select name="codigo_cargo" id="cargo" class="form-control" required>


                                            <?php
                                            $sql_cargo = 'SELECT codigo_cargo, nome_cargo FROM cargo WHERE status = 1'; //CRIA O CÓDIGO PARA MOSTRAR OS CARGO QUE ESTÃO ATIVOS
                                            $query_cargo = mysqli_query($conexao, $sql_cargo); //CONECTA COM O BANCO E EXECUTA O CÓDIGO
                                            $cargo = mysqli_fetch_assoc($query_cargo); //ARREY ASSOCIATIVO QUE POSSIBILITA CHAMAR AS FUNÇÕES PELO NOME EM VEZ DO ID

                                            do {
                                                echo '<option value="' . $cargo['codigo_cargo'] . '">' . $cargo['nome_cargo'] . '</option>';
                                            } while ($cargo = mysqli_fetch_assoc($query_cargo));

                                            ?>
                                        </select>
                                    </div>
                                    <div class="form-group col-md-6">
                                        <label for="input">Salário:</label>
                                        <input type="text" name="salario" id="salario" class="form-control" required data-mask="00000,00" data-mask-reverse="true">
                                    </div>
                                    <div class=" col-md-6">
                                        <label for="">Status:</label>
                                        <select name="status" class="form-control" disabled>
                                            <option value="1" selected>Ativo</option>
                                            <option value="0">inativo</option>
                                        </select>
                                    </div>

                                    <div class="form-group col-md-6">
                                        <label for="input">Usuário:</label>
                                        <input type="text" name="usuario" class="form-control" maxlength="20" required>
                                    </div>
                                    <div class="form-group col-md-6">
                                        <label for="input">Senha:</label>
                                        <input type="password" name="senha" class="form-control" maxlength="8">
                                    </div>
                                    <div class="form-group col-md-6">
                                        <label for="input">Tipo acesso:</label>
                                        <select name="tipo_acesso" class="form-control">
                                            <option value="1">Administrador</option>
                                            <option value="0" selected>Comum</option>
                                        </select>
                                    </div>


                                    <div class="col-12 mt-1">
                                        <label for="">Observação</label>
                                        <textarea maxlength="100" class="form-control" name="observacao"></textarea>
                                    </div>

                                    <div>
                                        <input type="hidden" name="cadastrar" value="cadastrar_funcionario">
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



    <!-- CEP MASK -->
    <script src="../../js/cep.js"></script>

    <script src="../../js/foto.js"></script>


</body>

</html>