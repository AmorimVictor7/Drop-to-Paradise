<?php 

if (!isset($_SESSION)) {
    session_start();
}

  #VERIFICANDO SE O USUÁRIO LOGADO É ADMINSTRADOR#
  if($_SESSION['TYPE'] !='1')
  {
    $_SESSION ['naoAdm'] = "Apenas usuários administradores podem acessar esta área!";
    header('Location: ../admin.php');
  }
?>

