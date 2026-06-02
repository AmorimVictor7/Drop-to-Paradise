<?php

#CONEXÃO COM O BANCODE DADOS#
require_once '../conexao/conecta.php';

#INICIANDO IMA SESSÃO#

if (!isset($_SESSION)) {
    session_start();
}

#VERIFICAR USUARIO E SENHA#
if (isset($_POST['usuario']) && $_POST['usuario'] != '' && isset($_POST['senha']) && $_POST['senha'] != '') {
    $usuario = mysqli_real_escape_string($conexao, $_POST['usuario']);
    $senha = mysqli_real_escape_string($conexao, $_POST['senha']);

    $sql = "SELECT * FROM funcionario WHERE usuario = '$usuario' AND senha = '$senha'";
    $query = mysqli_query($conexao, $sql);
    $funcionario = mysqli_fetch_assoc($query);

    //    echo $funcionario['usuario'];
    //    echo '';
    //    echo $funcionario['senha'];
    //    echo '';
    //    echo $funcionario['tipo_acesso'];

    if (isset($funcionario)) {
        $_SESSION['ID'] = $funcionario['codigo_funcionario'];
        $_SESSION['USER'] = $funcionario['usuario'];
        $_SESSION['TYPE'] = $funcionario['tipo_acesso'];
        $_SESSION['NAME'] = $funcionario['nome'];

        header('location: admin.php');
    }
    else {
    $_SESSION['loginErro'] = 'Usuário ou senha inválida.';
    header('Location: index.php');
}
} 
else {
    $_SESSION['loginVazio'] = 'Informe usuário e senha.';
    header('Location: index.php');
}

?>
