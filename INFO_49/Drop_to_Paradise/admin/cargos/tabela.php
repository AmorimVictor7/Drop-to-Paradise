<?php

//CONNEXÃO COM O BANCO DE DADOS #
require_once '../../conexao/conecta.php';


# FILTROS #
$status = $_POST['status'];

# CAMPO BUSCA#
$nome =   mysqli_real_escape_string($conexao, $_POST['nome']);
?>

<table class="table">
    <?php
    $sql = "SELECT * FROM cargo WHERE 1=1";
    //FILTRO POR STATUS
    if ($status != '') {
        $sql .= " AND status = $status";
    }
    if (!empty($nome))
  {
    $sql .= " AND cargo.nome_cargo LIKE '%$nome%'";
  }

    $query = mysqli_query($conexao, $sql);

    if (mysqli_num_rows($query) > 0) {

    ?>
        <thead>
            <tr>
                <th>#</th>
                <th>Cargo</th>
                <th>Observação</th>
                <th>Status</th>
                <th>Data cadastro</th>
                <th>Ações</th>
            </tr>
        </thead>
        <tbody>
            <?php
            foreach ($query as $cargo) {
            ?>
                <tr>
                    <td><?php echo $cargo['codigo_cargo'] ?></td>
                    <td><?php echo $cargo['nome_cargo'] ?></td>
                    <td><?php echo $cargo['observacao'] ?></td>
                    <td>
                        <?php
                        if ($cargo['status'] == 1) {
                            echo '<span class="badge badge-pill badge-success">Ativo</span>';
                        } else {
                            echo '<span class="badge badge-pill badge-danger">Inativo</span>';
                        }
                        ?></td>
                    <td><?php echo date('d/m/Y', strtotime($cargo['data_cadastro'])) ?></td>

                    <td>
                        <a href="editar.php?codigo_cargo=<?php echo $cargo['codigo_cargo'] ?>" title="Editar" Class="btn btn-outline-success btn-sm">
                            <i class="bi bi-pencil"></i>
                        </a>
                       <!-- <a href="excluir.php?codigo_cargo=" title="Excluir" Class="btn btn-outline-danger btn-sm">
                            <i class="bi bi-trash"></i>
                        </a> -->

                        <form action="acoes.php" method="post" class="d-inline">
                            <button type="submit"title="Excluir" Class="btn btn-outline-danger btn-sm" name="deletar_cargo" value="<?php echo $cargo['codigo_cargo'] ?>" onclick="return confirm('Tem certeza que deseja excluir?')">

                            <i class="bi bi-trash"></i>
                        </button>
                        </form>
                    </td>
                </tr>
            <?php
            }
            ?>
        </tbody>
    <?php
    } else {
        echo '<h5>Nenhum registro encontrado!<h5>';
    }
    ?>
</table>