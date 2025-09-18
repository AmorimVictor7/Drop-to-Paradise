<?php

//CONNEXÃO COM O BANCO DE DADOS #
require_once '../../conexao/conecta.php';

# FILTROS #
$status = $_POST['status'];
$categoria = $_POST['categoria'];
$marca = $_POST['marca'];

# CAMPO BUSCA#
$nome =   mysqli_real_escape_string($conexao, $_POST['nome']);
?>

<table class="table">
  <?php
  $sql = "SELECT produto.codigo_produto, produto.nome_produto,  marca.nome_marca, categoria.nome_categoria, produto.status, produto.data_cadastro FROM produto INNER JOIN marca ON produto.codigo_marca = marca.codigo_marca INNER JOIN categoria ON produto.codigo_categoria = categoria.codigo_categoria WHERE 1=1";
  
    //FILTRO POR STATUS
    if ($status != '') {
      $sql .= " AND produto.status = $status";
    }
  
  //FILTRO POR CATRGORIA
  if ($categoria != '') {
    $sql .= " AND produto.codigo_categoria = $categoria";
  }

  //FILTRO POR marca
  if ($marca != '') {
    $sql .= " AND produto.codigo_marca = $marca";
  }
  if (!empty($nome))
  {
    $sql .= " AND produto.nome_produto LIKE '%$nome%'";
  }

  $query = mysqli_query($conexao, $sql);

  if (mysqli_num_rows($query) > 0) {
  ?>
    <thead>
      <tr>
        <th>#</th>
        <th>Nome</th>
        <th>Marca</th>
        <th>Categoria</th>
        <th>status</th>
        <th>Data Cadastro</th>
        <th>Ações</th>
      </tr>
    </thead>

    <tbody>
      <?php

      foreach ($query as $produto) {
      ?>
        <tr>
          <td><?php echo $produto['codigo_produto'] ?></td>
          <td><?php echo $produto['nome_produto'] ?></td>
          <td><?php echo $produto['nome_marca']; ?></td>
          <td><?php echo $produto['nome_categoria'] ?></td>
          <td>
            <?php
            if ($produto['status'] == 1) {
              echo '<span class="badge badge-pill badge-success">Ativo</span>';
            } else {
              echo '<span class="badge badge-pill badge-danger">Inativo</span>';
            }
            ?></td>
          <td><?php echo date('d/m/Y', strtotime($produto['data_cadastro'])) ?></td>

          <td>
            <a href="editar.php?codigo_produto=<?php echo $produto['codigo_produto'] ?>" title="Editar" class="btn btn-outline-success btn-sm">
              <i class="bi bi-pencil"></i>
            </a>

            <form action="acoes.php" method="post" class="d-inline">
                            <button type="submit" title="Excluir" Class="btn btn-outline-danger btn-sm" name="deletar_produto" value="<?php echo $produto['codigo_produto'] ?>" onclick="return confirm('Tem certeza que deseja excluir?')">

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
    echo '<h5>Nenhum Produto encontrado</h5>';
  }
  ?>
</table>