<?php 

if (!isset($_SESSION)) {
    session_start();
}

#VERIFICANDO SE EXISTE USUÁRIO LOGADO PARA PERMITIR ACESSO#
if(!$_SESSION['USER'])
{
  $_SESSION['naoAutorizado'] = "Apenas usuários cadastrados podem acessar esta área! ";
  header('Location: ../index.php');
}
?>