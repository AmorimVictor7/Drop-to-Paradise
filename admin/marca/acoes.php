<?php 
require_once '../../conexao/conecta.php';

if  (!isset($_SESSION))
{
    session_start();
}

#cadastrar marca#
if(isset($_POST['cadastrar'])&& $_POST['cadastrar'] =='cadastrar_marca')
{
    $marca=mysqli_real_escape_string($conexao, $_POST['nome_marca']);
    $observacao = mysqli_real_escape_string($conexao, $_POST ['observacao']);

    $sql = "INSERT INTO marca VALUES (0,1, '$marca', NOW(), '$observacao')";

    if(mysqli_query($conexao, $sql))
    {
        //header('location: index.php');

        $_SESSION['mensagem'] = "Marca cadastrada com sucesso!";
        header('Location: inserir.php');
    }
    else
    {
        //die("Erro:". $sql. "<br>". mysqli_error($conexao));
         $_SESSION['mensagem'] = "Erro ao cadastrar";
        header('Location: inserir.php');
    }
    
}

if(isset($_POST['atualizar'])&& $_POST['atualizar'] =='atualizar_marca')
{
    $codigo = mysqli_real_escape_string($conexao, $_POST['codigo_marca']);
    $status = mysqli_real_escape_string($conexao, $_POST['status']);
    $marca=mysqli_real_escape_string($conexao, $_POST['nome_marca']);
    $observacao = mysqli_real_escape_string($conexao, $_POST ['observacao']);

    $sql = "UPDATE marca SET status=$status, nome_marca ='$marca',  observacao ='$observacao' WHERE codigo_marca = $codigo ";

    if(mysqli_query($conexao, $sql))
    {
        //header('location: index.php');

        $_SESSION['mensagem'] = "Marca atualizada com sucesso!";
        header('Location: index.php');
    }
    else
    {
        //die("Erro:". $sql. "<br>". mysqli_error($conexao));
         $_SESSION['mensagem'] = "Erro ao atualizar";
        header('Location: index.php');
    }
    
}

if (isset($_POST['deletar_marca'])) {
    $codigo = $_POST['deletar_marca'];

    $sql_verifica = "SELECT marca.nome_marca FROM marca INNER JOIN produto ON marca.codigo_marca = produto.codigo_marca WHERE marca.codigo_marca = $codigo";

    $query = mysqli_query($conexao, $sql_verifica);
    $contagem = mysqli_num_rows($query);
    $marca = mysqli_fetch_assoc($query);


    if ($contagem > 0) {
        $_SESSION['mensagem'] = "Não é possivel excluir a marca <b> " . $marca['nome_marca'] ." </b> pois existem <b>". $contagem ."  Produto(s) </b> vinculados a ele!";
        header('Location: index.php');
    } else {
        $sql = "DELETE FROM marca WHERE codigo_marca = $codigo";

        if (mysqli_query($conexao, $sql)) {
            $_SESSION['mensagem'] = "Marca excluída com sucesso!";
            header('Location: index.php');
        } else {
            //die("Erro:". $sql. "<br>". mysqli_error($conexao));
            $_SESSION['mensagem'] = "Erro ao excluir";
            header('Location: index.php');
        }
    }
}


?>