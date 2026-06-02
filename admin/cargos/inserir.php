<?php
include_once '../usuario_admin.php';
?>

<!doctype html>
<html lang="pt-br">

<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta name="description" content="">
    <meta name="author" content="">
    <title>Drop to Paradise - Cargos</title>

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
                 <?php include '../mensagem.php'?>  
                    <div class="card">

                        <div class="card-header d-flex justify-content-between align-items-center">
                            <h4 class="m-0">Novo cargo</h4>

                            <a href="index.php" class="btn btn-primary btn-sm">
                                <i class="bi bi-arrow-left"></i>
                                Voltar
                            </a>
                        </div>
                        <div class="card-body">

                            <form action="acoes.php" method="post">
                                <div class="form-row">
                                    <div class="form-group col-md-6">
                                        <label for="input">*Cargo:</label>
                                        <input type="text" name="nome_cargo" class="form-control" required>
                                    </div>
                                    <div class=" col-md-6">
                                        <label for="">*Status:</label>
                                        <select name="status" class="form-control" disabled>
                                            <option value="1" selected>Ativo</option>
                                            <option value="0">Inativo</option>
                                        </select>
                                    </div>

                                    <div class="col-12 mt-1">
                                        <label for="">Observação</label>
                                        <textarea maxlength="100" class="form-control" name="observacao"></textarea>
                                    </div>
             
                                    <input type="hidden" name="cadastrar" value="cadastrar_cargo">
                                    <input type="submit" value="Cadastrar" class="btn btn-primary btn-sm mt-2">

                            </form>

                        </div>
                    </div>
            </main>
        </div>
    </div>

    <script src="https://code.jquery.com/jquery-3.7.1.min.js" integrity="sha256-/JqT3SQfawRcv/BIHPThkBvs0OEvtFFmqPF/lYI/Cxo=" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js" integrity="sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js" integrity="sha384-ChfqqxuZUCnJSK3+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy" crossorigin="anonymous"></script>

</body>

</html>