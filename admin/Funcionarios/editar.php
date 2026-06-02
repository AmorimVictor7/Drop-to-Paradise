<?php

//CONNEXÃO COM O BANCO DE DADOS #
require_once '../../conexao/conecta.php';

# RESTRINGINDO ACESS A USUÁRIOS ADMINISTRADORES#
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
                  

                    <?php
                    if (isset($_GET['codigo_funcionario']) && $_GET['codigo_funcionario'] != '') {
                        $codigo = $_GET['codigo_funcionario'];
                        $sql = "SELECT * FROM funcionario WHERE codigo_funcionario = $codigo";
                        $query = mysqli_query($conexao, $sql);
                        $funcionario = mysqli_fetch_assoc($query);
                    ?>
                        <div class="card">
                            <div class="card-header d-flex justify-content-between align-items-center">
                                <h4 class="m-0">Atualizar Funcionário</h4>

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
                                            <input type="text" name="nome" class="form-control" required maxlength="60" value="<?php echo $funcionario['nome'] ?>">
                                        </div>
                                        <div class="form-group col-md-6">
                                            <label for="input">Nome Social:</label>
                                            <input type="text" name="nome_social" class="form-control" maxlength="60" value="<?php echo $funcionario['nome_social'] ?>">
                                        </div>
                                        <div class="form-group col-md-6">
                                            <label for="input">Data Nascimento:</label>
                                            <input type="date" name="data_nascimento" class="form-control" required value="<?php echo $funcionario['data_nascimento'] ?>">
                                        </div>
                                        <div class=" col-md-6">
                                            <label for="">Sexo:</label>
                                            <select name="sexo" class="form-control" value="<?php echo $funcionario['sexo'] ?>">
                                                <option value="M" <?php if ($funcionario['sexo'] == 'M') echo 'selected' ?>>Masculino</option>
                                                <option value="F" <?php if ($funcionario['sexo'] == 'F') echo 'selected' ?>>Feminino</option>
                                                <option value="N" <?php if ($funcionario['sexo'] == 'N') echo 'selected' ?>>Não informado</option>
                                            </select>
                                        </div>
                                        <div class="form-group col-md-6">
                                            <label for="input">CPF:</label>
                                            <input type="text" name="cpf" class="form-control" required maxlength="14" data-mask="000.000.000-00" value="<?php echo $funcionario['cpf'] ?>">
                                        </div>
                                        <div class="form-group col-md-6">
                                            <label for="input">RG:</label>
                                            <input type="text" name="rg" class="form-control" maxlength="12" data-mask="00.000.000-A" value="<?php echo $funcionario['rg'] ?>">
                                        </div>
                                        <div class="form-group col-md-6">
                                            <label for="input">Estado Civil: </label>
                                            <select name="estado_civil" id="estado_civil" class="form-control">
                                                <option value="Solteiro(a)" <?php if ($funcionario['estado_civil'] == 'solteiro') echo 'selected' ?>>Solteiro(a)</option>
                                                <option value="Casado(a)" <?php if ($funcionario['estado_civil'] == 'casado') echo 'selected' ?>>Casado(a)</option>
                                                <option value="Separado(a)" <?php if ($funcionario['estado_civil'] == 'separado') echo 'selected' ?>>Separado(a)</option>
                                                <option value="Divorciado(a)" <?php if ($funcionario['estado_civil'] == 'divorciado') echo 'selected' ?>>Divorciado(a)</option>
                                                <option value="Viúvo(a)" <?php if ($funcionario['estado_civil'] == 'viuvo') echo 'selected' ?>>Viúvo(a)</option>
                                            </select>
                                        </div>

                                        <!-- contato do funcionario -->
                                        <div class="form-group col-md-6">
                                            <label for="input">E-mail:</label>
                                            <input type="text" name="email" class="form-control" maxlength="50" value="<?php echo $funcionario['email'] ?>">
                                        </div>
                                        <div class="form-group col-md-6">
                                            <label for="input">Telefone celular:</label>
                                            <input type="text" name="telefone_celular" class="form-control" maxlength="14" data-mask="(00) 00000-0000" value="<?php echo $funcionario['telefone_celular'] ?>">
                                        </div>
                                        <div class="form-group col-md-6">
                                            <label for="input">Telefone Residencial:</label>
                                            <input type="text" name="telefone_residencial" class="form-control" maxlength="13" data-mask="(00) 0000-0000" value="<?php echo $funcionario['telefone_residencial'] ?>">
                                        </div>

                                        <!-- endereço do funcionario -->
                                        <div class="form-group col-md-6">
                                            <label for="input">CEP:</label>
                                            <input type="text" name="cep" id="cep" class="form-control" maxlength="9" data-mask="00000-000" required value="<?php echo $funcionario['cep'] ?>">
                                        </div>
                                        <div class="form-group col-md-6">
                                            <label for="input">Endereço:</label>
                                            <input type="text" name="endereco" id="endereco" class="form-control" maxlength="70" value="<?php echo $funcionario['endereco'] ?>">
                                        </div>
                                        <div class="form-group col-md-6">
                                            <label for="input">Bairro:</label>
                                            <input type="text" name="bairro" id="bairro" class="form-control" maxlength="30" value="<?php echo $funcionario['bairro'] ?>">
                                        </div>
                                        <div class="form-group col-md-6">
                                            <label for="input">Número:</label>
                                            <input type="number" name="numero" class="form-control" value="<?php echo $funcionario['numero'] ?>">
                                        </div>

                                        <div class="form-group col-md-6">
                                            <label for="input">Cidade:</label>
                                            <input type="text" name="cidade" id="cidade" class="form-control" maxlength="40" value="<?php echo $funcionario['cidade'] ?>">
                                        </div>
                                        <div class="col-6">
                                            <label for="estado"><strong class="text-danger">*</strong>Estado: </label>
                                            <select class="form-control" name="estado" id="estado" required>
                                                <option value="AC" <?php if ($funcionario['estado'] == 'AC') echo 'selected' ?>>AC</option>
                                                <option value="AL" <?php if ($funcionario['estado'] == 'AL') echo 'selected' ?>>AL</option>
                                                <option value="AP" <?php if ($funcionario['estado'] == 'AP') echo 'selected' ?>>AP</option>
                                                <option value="AM" <?php if ($funcionario['estado'] == 'AM') echo 'selected' ?>>AM</option>
                                                <option value="BA" <?php if ($funcionario['estado'] == 'BA') echo 'selected' ?>>BA</option>
                                                <option value="CE" <?php if ($funcionario['estado'] == 'CE') echo 'selected' ?>>CE</option>
                                                <option value="DF" <?php if ($funcionario['estado'] == 'DF') echo 'selected' ?>>DF</option>
                                                <option value="ES" <?php if ($funcionario['estado'] == 'ES') echo 'selected' ?>>ES</option>
                                                <option value="GO" <?php if ($funcionario['estado'] == 'GO') echo 'selected' ?>>GO</option>
                                                <option value="MA" <?php if ($funcionario['estado'] == 'MA') echo 'selected' ?>>MA</option>
                                                <option value="MT" <?php if ($funcionario['estado'] == 'MT') echo 'selected' ?>>MT</option>
                                                <option value="MS" <?php if ($funcionario['estado'] == 'MS') echo 'selected' ?>>MS</option>
                                                <option value="MG" <?php if ($funcionario['estado'] == 'MG') echo 'selected' ?>>MG</option>
                                                <option value="PA" <?php if ($funcionario['estado'] == 'PA') echo 'selected' ?>>PA</option>
                                                <option value="PB" <?php if ($funcionario['estado'] == 'PB') echo 'selected' ?>>PB</option>
                                                <option value="PR" <?php if ($funcionario['estado'] == 'PR') echo 'selected' ?>>PR</option>
                                                <option value="PE" <?php if ($funcionario['estado'] == 'PE') echo 'selected' ?>>PE</option>
                                                <option value="PI" <?php if ($funcionario['estado'] == 'PI') echo 'selected' ?>>PI</option>
                                                <option value="RJ" <?php if ($funcionario['estado'] == 'RJ') echo 'selected' ?>>RJ</option>
                                                <option value="RN" <?php if ($funcionario['estado'] == 'RN') echo 'selected' ?>>RN</option>
                                                <option value="RS" <?php if ($funcionario['estado'] == 'RS') echo 'selected' ?>>RS</option>
                                                <option value="RO" <?php if ($funcionario['estado'] == 'RO') echo 'selected' ?>>RO</option>
                                                <option value="RR" <?php if ($funcionario['estado'] == 'RR') echo 'selected' ?>>RR</option>
                                                <option value="SC" <?php if ($funcionario['estado'] == 'SC') echo 'selected' ?>>SC</option>
                                                <option value="SP" <?php if ($funcionario['estado'] == 'SP') echo 'selected' ?>>SP</option>
                                                <option value="SE" <?php if ($funcionario['estado'] == 'SE') echo 'selected' ?>>SE</option>
                                                <option value="TO" <?php if ($funcionario['estado'] == 'TO') echo 'selected' ?>>TO</option>
                                            </select>
                                        </div>
                                        <div class="form-group col-md-6">
                                            <label for="input">Complemento:</label>
                                            <input type="text" name="complemento" class="form-control" maxlength="40" value="<?php echo $funcionario['complemento'] ?>">
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
                                                ?>
                                                    <option value="<?php echo $cargo['codigo_cargo'] ?>" <?php
                                                 if ($funcionario['codigo_cargo'] == $cargo['codigo_cargo']) echo 'selected' ?>><?php echo $cargo['nome_cargo'] ?></option>
                                                <?php
                                                } while ($cargo = mysqli_fetch_assoc($query_cargo));

                                                ?>
                                            </select>
                                        </div>
                                        <div class="form-group col-md-6">
                                            <label for="input">Salário:</label>
                                            <input type="text" name="salario" id="salario" class="form-control" required data-mask="00000,00" data-mask-reverse="true" value="<?php echo $funcionario['salario'] ?>">
                                        </div>
                                        <div class=" col-md-6">
                                            <label for="">Status:</label>
                                            <select name="status" class="form-control " value="<?php echo $funcionario['status'] ?>">
                                                <option value="1" <?php if ($funcionario['status'] == 1) echo 'selected' ?>>Ativo</option>
                                                <option value="0" <?php if ($funcionario['status'] == 0) echo 'selected' ?>>inativo</option>
                                            </select>
                                        </div>

                                        <div class="form-group col-md-6">
                                            <label for="input">Usuário:</label>
                                            <input type="text" name="usuario" class="form-control" maxlength="20" required value="<?php echo $funcionario['usuario'] ?>">
                                        </div>
                                        <div class="form-group col-md-6">
                                            <label for="input">Senha:</label>
                                            <input type="password" name="senha" class="form-control" maxlength="8" value="<?php echo $funcionario['senha'] ?>">
                                        </div>
                                        <div class="form-group col-md-6">
                                            <label for="input">Tipo acesso:</label>
                                            <select name="tipo_acesso" class="form-control" value="<?php echo $funcionario['tipo_acesso'] ?>">
                                            <option value="1" <?php if ($funcionario['tipo_acesso'] == 1) echo 'selected' ?>>Administrador</option>
                                            <option value="0" <?php if ($funcionario['tipo_acesso'] == 0) echo 'selected' ?>>Comum</option>
                                            </select>
                                        </div>


                                        <div class="col-12 mt-1">
                                            <label for="">Observação</label>
                                            <textarea maxlength="100" class="form-control" name="observacao" value="<?php echo $funcionario['observacao'] ?>"></textarea>
                                        </div>

                                        <div>
                                            <input type="hidden" name="atualizar" value="atualizar_funcionario">
                                            <input type="hidden" name="codigo_funcionario" value="<?php echo $codigo ?>">
                                            <input type="submit" value="Atualizar" class="btn btn-primary btn-sm mt-2"></input>
                                        </div>


                                </form>

                            </div>
                        </div>
                    <?php
                    } else {
                        echo "<h5> Funcionário não encontrado! </h5>";
                    }
                    ?>
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