<?php
require_once '../../conexao/conecta.php';

if (!isset($_SESSION)) {
    session_start();
}

# CADASTRAR PRODUTO
if (isset($_POST['cadastrar']) && $_POST['cadastrar'] == 'cadastrar_produto') {
    $nome = mysqli_real_escape_string($conexao, $_POST['nome_produto']);
    $preco_venda = str_replace(',', '.', $_POST['preco_venda']);
    $preco_promocao = $_POST['preco_promocao'];
    $observacao = mysqli_real_escape_string($conexao, $_POST['observacao']);
    $preco_lucro = str_replace(',', '.', $_POST['preco_lucro']);
    $preco_final_promo = str_replace(',', '.', $_POST['preco_final_promo']);
    $preco_desconto = str_replace(',', '.', $_POST['preco_desconto']);
    $preco_custo = str_replace(',', '.', $_POST['preco_custo']);
    $quantidade = mysqli_real_escape_string($conexao, $_POST['quantidade']);
    $marca = mysqli_real_escape_string($conexao, $_POST['nome_marca']);
    $categoria = mysqli_real_escape_string($conexao, $_POST['nome_categoria']);
    $descricao = mysqli_real_escape_string($conexao, $_POST['descricao']);

    // Upload da imagem
    $foto = basename($_FILES['foto']['name']);
    $tmp = $_FILES['foto']['tmp_name'];
    $final = "../../images/" . $foto;
    move_uploaded_file($tmp, $final);

    $sql = "INSERT INTO produto VALUES (0, 1, '$nome', '$foto', '$preco_venda', $preco_promocao, '$observacao', '$preco_lucro', 
        '$preco_final_promo', '$preco_desconto', '$preco_custo', NOW(), '$quantidade', '$descricao', '$marca', '$categoria')";

    if (mysqli_query($conexao, $sql)) {
        $_SESSION['mensagem'] = "Produto cadastrado com sucesso!";
        header('Location: inserir.php');
    } else {
        $_SESSION['mensagem'] = "Erro ao cadastrar";
        header('Location: inserir.php');
    }
}

# ATUALIZAR PRODUTO
if (isset($_POST['atualizar']) && $_POST['atualizar'] == 'atualizar_produto') {
    $codigo = mysqli_real_escape_string($conexao, $_POST['codigo_produto']);
    $nome = mysqli_real_escape_string($conexao, $_POST['nome_produto']);
    $status = mysqli_real_escape_string($conexao, $_POST['status']);
    $preco_venda = str_replace(',', '.', $_POST['preco_venda']);
    $observacao = mysqli_real_escape_string($conexao, $_POST['observacao']);
    $preco_lucro = str_replace(',', '.', $_POST['preco_lucro']);
    $preco_final_promo = str_replace(',', '.', $_POST['preco_final_promo']);
    $preco_desconto = str_replace(',', '.', $_POST['preco_desconto']);
    $preco_custo = str_replace(',', '.', $_POST['preco_custo']);
    $preco_promocao = $_POST['preco_promocao'];
    $quantidade = mysqli_real_escape_string($conexao, $_POST['quantidade']);
    $marca = mysqli_real_escape_string($conexao, $_POST['codigo_marca']);
    $categoria = mysqli_real_escape_string($conexao, $_POST['codigo_categoria']);
    $descricao = mysqli_real_escape_string($conexao, $_POST['descricao']);

   
      $foto = basename($_FILES['foto']['name']);
    $tmp = $_FILES['foto']['tmp_name'];
    $final = "../../images/" . $foto;
    move_uploaded_file($tmp, $final);


    // Monta a query UPDATE
    $sql = "UPDATE produto SET status = $status, nome_produto = '$nome', preco_venda = '$preco_venda',
 preco_promocao = $preco_promocao, observacao = '$observacao', preco_lucro = '$preco_lucro', preco_final_promo = '$preco_final_promo', preco_desconto = '$preco_desconto', preco_custo = '$preco_custo',  quantidade = '$quantidade', descricao = '$descricao', codigo_marca = '$marca',
 codigo_categoria = '$categoria'";

    // Se tiver foto nova, atualiza também
    if (!empty($foto)) {
        $sql .= ", foto = '$foto'";
    }

    $sql .= " WHERE codigo_produto = $codigo";

    if (mysqli_query($conexao, $sql)) {
        $_SESSION['mensagem'] = "Produto atualizado com sucesso!";
        header('Location: index.php');
    } else {
        $_SESSION['mensagem'] = "Erro ao atualizar";
        header('Location: index.php');
    }
}

# DELETAR PRODUTO
if(isset($_POST['deletar_produto']))
{
    $codigo = $_POST['deletar_produto'];

    $sql_verifica = "SELECT produto.nome_produto FROM produto INNER JOIN item_venda ON produto.codigo_produto = item_venda.codigo_produto WHERE produto.codigo_produto = $codigo";

    $query = mysqli_query($conexao, $sql_verifica);
    $contagem = mysqli_num_rows($query);
    $categoria = mysqli_fetch_assoc($query);


    if ($contagem > 0) {
        $_SESSION['mensagem'] = "Não é possivel excluir o produto <b> " . $categoria['nome_produto'] ." </b> pois existem <b>". $contagem ."  venda(s) </b> vinculadas a ele!";
        header('Location: index.php');
    }
    else{
        $sql = "DELETE FROM produto WHERE codigo_produto = $codigo";

        if(mysqli_query($conexao, $sql))
        {
        $_SESSION['mensagem'] = "Produto excluído com sucesso!";
        header('Location: index.php');
        }
        else{
            //die("Erro:". $sql. "<br>". mysqli_error($conexao));
        $_SESSION['mensagem'] = "Erro ao excluir";
        header('Location: index.php');
        }
    }
}
