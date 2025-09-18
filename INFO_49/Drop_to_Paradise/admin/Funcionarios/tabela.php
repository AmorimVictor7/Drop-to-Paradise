<?php

//CONNEXÃO COM O BANCO DE DADOS #
require_once '../../conexao/conecta.php';


# FILTROS #
$sexo = $_POST['sexo'];
$status = $_POST['status'];
$cargo = $_POST['cargo'];

# CAMPO BUSCA#
$nome =   mysqli_real_escape_string($conexao, $_POST['nome']);
?>


<table class="table">
  <?php
  $sql = "SELECT funcionario.codigo_funcionario, funcionario.nome, funcionario.nome_social, cargo.nome_cargo, funcionario.salario, funcionario.status, funcionario.data_cadastro FROM funcionario 
                INNER JOIN cargo ON funcionario.codigo_cargo = cargo.codigo_cargo    WHERE   1=1";

  //FILTRO POR SEXO
  if (!empty($sexo)) {
    $sql .= " AND funcionario.sexo = '$sexo'";
  }

  //FILTRO POR STATUS
  if ($status != '') {
    $sql .= " AND funcionario.status = $status";
  }

  //FILTRO POR CARGO
  if ($cargo != '') {
    $sql .= " AND funcionario.codigo_cargo = $cargo";
  }
  if (!empty($nome))
  {
    $sql .= " AND funcionario.nome LIKE '%$nome%'";
  }

  $query = mysqli_query($conexao, $sql);

  if (mysqli_num_rows($query) > 0) {
  ?>
    <thead>
      <tr>
        <th>#</th>
        
        <th>Nome</th>
        <th>Cargo</th>
        <th>Salário</th>
        <th>Status</th>
        <th>Data Cadastro</th>
        <th>Ações</th>
      </tr>
    </thead>

    <tbody>
      <?php

      foreach ($query as $funcionario) {
      ?>
        <tr>
          <td><?php echo $funcionario['codigo_funcionario'] ?></td>
          <td><?php

              if ($funcionario['nome_social'] != '') {
                echo $funcionario['nome_social'];
              } else {
                echo $funcionario['nome'];
              }

              ?></td>
          <td><?php echo $funcionario['nome_cargo']; ?></td>
          <td><?php echo $funcionario['salario'] ?></td>
          <td>
            <?php
            if ($funcionario['status'] == 1) {
              echo '<span class="badge badge-pill badge-success">Ativo</span>';
            } else {
              echo '<span class="badge badge-pill badge-danger">Inativo</span>';
            }
            ?></td>
          <td><?php echo date('d/m/Y', strtotime($funcionario['data_cadastro'])) ?></td>

          <td>
            <a href="editar.php?codigo_funcionario=<?php echo $funcionario['codigo_funcionario']?>" title="Editar" class="btn btn-outline-success btn-sm">
              <i class="bi bi-pencil"></i>
            </a>

            <form action="acoes.php" method="post" class="d-inline">
              <button type="submit"title="Excluir" Class="btn btn-outline-danger btn-sm" name="deletar_funcionario" value="<?php echo $funcionario['codigo_funcionario'] ?>"  onclick="return confirm('Tem certeza que deseja excluir?')">

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
    echo '<h5>Nenhum funcionario encontrado</h5>';
  }
  ?>
</table>