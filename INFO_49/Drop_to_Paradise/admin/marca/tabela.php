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
    $sql = "SELECT marca.codigo_marca, marca.status, marca.nome_marca, marca.data_cadastro, marca.observacao FROM marca WHERE 1=1";
    //FILTRO POR STATUS
    if ($status != '') {
        $sql .= " AND status = $status";
    }
    if (!empty($nome)) {
        $sql .= " AND marca.nome_marca LIKE '%$nome%'";
    }

    $query = mysqli_query($conexao, $sql);


    if (mysqli_num_rows($query) > 0) {
    ?>
        <thead>
            <tr>
                <th>#</th>
                <th>Nome</th>
                <th>Status</th>
                <th>Data Cadastro</th>
                <th>Observação</th>
            </tr>
        </thead>

        <tbody>
            <?php

            foreach ($query as $marca) {
            ?>
                <tr>
                    <td><?php echo $marca['codigo_marca'] ?></td>

                    <td><?php echo $marca['nome_marca'] ?></td>
                    <td>
                        <?php
                        if ($marca['status'] == 1) {
                            echo '<span class="badge badge-pill badge-success">Ativo</span>';
                        } else {
                            echo '<span class="badge badge-pill badge-danger">Inativo</span>';
                        }
                        ?></td>
                    <td><?php echo date('d/m/Y', strtotime($marca['data_cadastro'])) ?></td>

                    <td>
                        <a href="editar.php?codigo_marca=<?php echo $marca['codigo_marca'] ?>" title="Editar" Class="btn btn-outline-success btn-sm">
                            <i class="bi bi-pencil"></i>
                        </a>
                        <form action="acoes.php" method="post" class="d-inline">
                            <button type="submit" title="Excluir" Class="btn btn-outline-danger btn-sm" name="deletar_marca" value="<?php echo $marca['codigo_marca'] ?>" onclick="return confirm('Tem certeza que deseja excluir?')">

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
        echo '<h5>Nenhuma marca encontrada</h5>';
    }
    ?>
</table>