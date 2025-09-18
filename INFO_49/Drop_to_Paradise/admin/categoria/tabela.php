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
    $sql = "SELECT categoria.codigo_categoria, categoria.status, categoria.nome_categoria, categoria.data_cadastro, categoria.observacao FROM categoria WHERE 1=1";
    //FILTRO POR STATUS
    if ($status != '') {
        $sql .= " AND status = $status";
    }
    if (!empty($nome))
  {
    $sql .= " AND categoria.nome_categoria LIKE '%$nome%'";
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

            foreach ($query as $categoria) {
            ?>
                <tr>
                    <td><?php echo $categoria['codigo_categoria'] ?></td>
                    <td><?php echo $categoria['nome_categoria'] ?></td>
                    <td>
                        <?php
                        if ($categoria['status'] == 1) {
                            echo '<span class="badge badge-pill badge-success">Ativo</span>';
                        } else {
                            echo '<span class="badge badge-pill badge-danger">Inativo</span>';
                        }
                        ?></td>
                    <td><?php echo date('d/m/Y', strtotime($categoria['data_cadastro'])) ?></td>

                    <td>
                        <a href="editar.php?codigo_categoria=<?php echo $categoria['codigo_categoria'] ?>" title="Editar" Class="btn btn-outline-success btn-sm">
                            <i class="bi bi-pencil"></i>
                        </a>
                        <form action="acoes.php" method="post" class="d-inline">
                            <button type="submit"title="Excluir" Class="btn btn-outline-danger btn-sm" name="deletar_categoria" value="<?php echo $categoria['codigo_categoria'] ?>" onclick="return confirm('Tem certeza que deseja excluir?')">

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
        echo '<h5>Nenhuma categoria encontrada</h5>';
    }
    ?>
</table>