<?php
require_once '../../conexao/conecta.php';

if (!isset($_SESSION)) {
    session_start();
}


#cadastrar cargo#
if (isset($_POST['cadastrar']) && $_POST['cadastrar'] == 'cadastrar_cargo') {
    $cargo = mysqli_real_escape_string($conexao, $_POST['nome_cargo']);
    $observacao = mysqli_real_escape_string($conexao, $_POST['observacao']);

    $sql = "INSERT INTO cargo VALUES (0, '$observacao', 1, NOW(), '$cargo')";

    if (mysqli_query($conexao, $sql)) {
        //header('location: index.php');

        $_SESSION['mensagem'] = "Cargo cadastrado com sucesso!";
        header('Location: inserir.php');
    } else 
    {
        //die("Erro:". $sql. "<br>". mysqli_error($conexao));
        $_SESSION['mensagem'] = "Erro ao cadastrar";
        header('Location: inserir.php');
    }
}
//ATUALIZAR 
if (isset($_POST['atualizar']) && $_POST['atualizar'] == 'atualizar_cargo') {
    $codigo = mysqli_real_escape_string($conexao, $_POST['codigo_cargo']);
    $status = mysqli_real_escape_string($conexao, $_POST['status']);
    $nome = mysqli_real_escape_string($conexao, $_POST['nome_cargo']);
    $observacao = mysqli_real_escape_string($conexao, $_POST['observacao']);

    $sql = "UPDATE cargo SET observacao = '$observacao' , status = $status, nome_cargo = '$nome' WHERE codigo_cargo = $codigo ";


    if (mysqli_query($conexao, $sql)) {
        //header('location: index.php');

        $_SESSION['mensagem'] = "Cargo atualizado com sucesso!";
        header('Location: index.php');
    } else {
        //die("Erro:". $sql. "<br>". mysqli_error($conexao));
        $_SESSION['mensagem'] = "Erro ao atualizar";
        header('Location: index.php');
    }
}

#EXCLUIR CARGO#
if (isset($_POST['deletar_cargo'])) {
    $codigo = $_POST['deletar_cargo'];

    $sql_verifica = "SELECT cargo.nome_cargo FROM cargo INNER JOIN funcionario ON cargo.codigo_cargo = funcionario.codigo_cargo WHERE cargo.codigo_cargo = $codigo";

    $query = mysqli_query($conexao, $sql_verifica);
    $contagem = mysqli_num_rows($query);
    $cargo = mysqli_fetch_assoc($query);


    if ($contagem > 0) {
        $_SESSION['mensagem'] = "Não é possivel excluir o cargo <b> " . $cargo['nome_cargo'] ." </b> pois existem <b>". $contagem ."  funcionário(s) </b> vinculados a ele!";
        header('Location: index.php');
    } else {
        $sql = "DELETE FROM cargo WHERE codigo_cargo = $codigo";

        if (mysqli_query($conexao, $sql)) {
            $_SESSION['mensagem'] = "Cargo excluído com sucesso!";
            header('Location: index.php');
        } else {
            //die("Erro:". $sql. "<br>". mysqli_error($conexao));
            $_SESSION['mensagem'] = "Erro ao excluir";
            header('Location: index.php');
        }
    }
}

?>