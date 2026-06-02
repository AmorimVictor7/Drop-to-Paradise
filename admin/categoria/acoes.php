<?php 
require_once '../../conexao/conecta.php';

if  (!isset($_SESSION))
{
    session_start();
}

#cadastrar categoria#
if(isset($_POST['cadastrar'])&& $_POST['cadastrar'] =='cadastrar_categoria')
{
    $categoria=mysqli_real_escape_string($conexao, $_POST['nome_categoria']);
    $observacao = mysqli_real_escape_string($conexao, $_POST ['observacao']);

    $sql = "INSERT INTO categoria VALUES (0,1, '$categoria', NOW(), '$observacao')";

    if(mysqli_query($conexao, $sql))
    {
        //header('location: index.php');

        $_SESSION['mensagem'] = "Categoria cadastrada com sucesso!";
        header('Location: inserir.php');
    }
    else
    {
        //die("Erro:". $sql. "<br>". mysqli_error($conexao));
         $_SESSION['mensagem'] = "Erro ao cadastrar";
        header('Location: inserir.php');
    }
    
}

//ATUALIZAR
if(isset($_POST['atualizar'])&& $_POST['atualizar'] =='atualizar_categoria')
{
    $codigo = mysqli_real_escape_string($conexao, $_POST['codigo_categoria']);
    $status = mysqli_real_escape_string($conexao, $_POST['status']);
    $categoria=mysqli_real_escape_string($conexao, $_POST['nome_categoria']);
    $observacao = mysqli_real_escape_string($conexao, $_POST ['observacao']);

    $sql = "UPDATE categoria SET status=$status, nome_categoria ='$categoria',  observacao ='$observacao' WHERE codigo_categoria = $codigo ";

    if(mysqli_query($conexao, $sql))
    {
        //header('location: index.php');

        $_SESSION['mensagem'] = "Categoria atualizada com sucesso!";
        header('Location: index.php');
    }
    else
    {
        //die("Erro:". $sql. "<br>". mysqli_error($conexao));
         $_SESSION['mensagem'] = "Erro ao atualizar";
       header('Location: index.php');
    }
    
}
#EXCLUIR#
if (isset($_POST['deletar_categoria'])) {
    $codigo = $_POST['deletar_categoria'];

    $sql_verifica = "SELECT categoria.nome_categoria FROM categoria INNER JOIN produto ON categoria.codigo_categoria = produto.codigo_categoria WHERE categoria.codigo_categoria = $codigo";

    $query = mysqli_query($conexao, $sql_verifica);
    $contagem = mysqli_num_rows($query);
    $categoria = mysqli_fetch_assoc($query);


    if ($contagem > 0) {
        $_SESSION['mensagem'] = "Não é possivel excluir a categoria <b> " . $categoria['nome_categoria'] ." </b> pois existem <b>". $contagem ."  Produto(s) </b> vinculados a ele!";
        header('Location: index.php');
    } else {
        $sql = "DELETE FROM categoria WHERE codigo_categoria = $codigo";

        if (mysqli_query($conexao, $sql)) {
            $_SESSION['mensagem'] = "Categoria excluída com sucesso!";
            header('Location: index.php');
        } else {
            //die("Erro:". $sql. "<br>". mysqli_error($conexao));
            $_SESSION['mensagem'] = "Erro ao excluir";
            header('Location: index.php');
        }
    }
}


?>
