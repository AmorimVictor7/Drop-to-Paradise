<?php

require_once '../../conexao/conecta.php';

if  (!isset($_SESSION))
{
    session_start();
}

if (isset($_POST['cadastrar']) && $_POST['cadastrar'] == 'cadastrar_funcionario') {
    $nome = mysqli_real_escape_string($conexao, $_POST['nome']);
    $nome_social = mysqli_real_escape_string($conexao, $_POST['nome_social']);
    $data_nascimento = mysqli_real_escape_string($conexao, $_POST['data_nascimento']);
    $sexo = mysqli_real_escape_string($conexao, $_POST['sexo']);
    $estado_civil = mysqli_real_escape_string($conexao, $_POST['estado_civil']);
    $cpf = mysqli_real_escape_string($conexao, $_POST['cpf']);
    $rg = mysqli_real_escape_string($conexao, $_POST['rg']);
    $salario = str_replace(',', '.', $_POST['salario']);
    $endereco = mysqli_real_escape_string($conexao, $_POST['endereco']);
    $numero = mysqli_real_escape_string($conexao, $_POST['numero']);
    $complemento = mysqli_real_escape_string($conexao, $_POST['complemento']);
    $bairro = mysqli_real_escape_string($conexao, $_POST['bairro']);
    $cidade = mysqli_real_escape_string($conexao, $_POST['cidade']);
    $estado = mysqli_real_escape_string($conexao, $_POST['estado']);
    $cep = mysqli_real_escape_string($conexao, $_POST['cep']);
    $telefone_residencial = mysqli_real_escape_string($conexao, $_POST['telefone_residencial']);
    $telefone_celular = mysqli_real_escape_string($conexao, $_POST['telefone_celular']);
    $email = mysqli_real_escape_string($conexao, $_POST['email']);
    $usuario = mysqli_real_escape_string($conexao, $_POST['usuario']);
    $tipo_acesso = mysqli_real_escape_string($conexao, $_POST['tipo_acesso']);
    $senha = mysqli_real_escape_string($conexao, $_POST['senha']);
    //   $foto = mysqli_real_escape_string($conexao, $_POST ['foto']);
    $cargo = mysqli_real_escape_string($conexao, $_POST['codigo_cargo']);
    //enviando a foto para o servidor
    $foto = basename($_FILES['foto']['name']);
    $tmp = $_FILES['foto']['tmp_name'];
    $final = "../../images/" . $foto;
    move_uploaded_file($tmp, $final);

    $sql= "INSERT INTO funcionario VALUES (0, '$nome', '$nome_social', '$data_nascimento','$sexo', '$cpf', '$rg','$estado_civil', '$telefone_residencial','$telefone_celular','$salario', '$cidade','$endereco', '$numero', '$bairro','$estado', '$complemento', '$cep', '$email', NOW(),'$usuario', '$senha', $tipo_acesso, '$foto', 1, '$cargo')";

    if(mysqli_query($conexao, $sql))
    {
        //header('location: index.php');

        $_SESSION['mensagem'] = "Funcionario cadastrado com sucesso!";
        header('Location: inserir.php');
    }
    else
    {
        //die("Erro:". $sql. "<br>". mysqli_error($conexao));
        $_SESSION['mensagem'] = "Erro ao cadastrar";
        header('Location: inserir.php');
    }
}

if (isset($_POST['atualizar']) && $_POST['atualizar'] == 'atualizar_funcionario') {
   $codigo = mysqli_real_escape_string($conexao, $_POST['codigo_funcionario']);
   $status = mysqli_real_escape_string($conexao, $_POST['status']);
    $nome = mysqli_real_escape_string($conexao, $_POST['nome']);
    $nome_social = mysqli_real_escape_string($conexao, $_POST['nome_social']);
    $data_nascimento = mysqli_real_escape_string($conexao, $_POST['data_nascimento']);
    $sexo = mysqli_real_escape_string($conexao, $_POST['sexo']);
    $estado_civil = mysqli_real_escape_string($conexao, $_POST['estado_civil']);
    $cpf = mysqli_real_escape_string($conexao, $_POST['cpf']);
    $rg = mysqli_real_escape_string($conexao, $_POST['rg']);
    $salario = str_replace(',', '.', $_POST['salario']);
    $endereco = mysqli_real_escape_string($conexao, $_POST['endereco']);
    $numero = mysqli_real_escape_string($conexao, $_POST['numero']);
    $complemento = mysqli_real_escape_string($conexao, $_POST['complemento']);
    $bairro = mysqli_real_escape_string($conexao, $_POST['bairro']);
    $cidade = mysqli_real_escape_string($conexao, $_POST['cidade']);
    $estado = mysqli_real_escape_string($conexao, $_POST['estado']);
    $cep = mysqli_real_escape_string($conexao, $_POST['cep']);
    $telefone_residencial = mysqli_real_escape_string($conexao, $_POST['telefone_residencial']);
    $telefone_celular = mysqli_real_escape_string($conexao, $_POST['telefone_celular']);
    $email = mysqli_real_escape_string($conexao, $_POST['email']);
    $usuario = mysqli_real_escape_string($conexao, $_POST['usuario']);
    $tipo_acesso = mysqli_real_escape_string($conexao, $_POST['tipo_acesso']);
    $senha = mysqli_real_escape_string($conexao, $_POST['senha']);
    //   $foto = mysqli_real_escape_string($conexao, $_POST ['foto']);
    $cargo = mysqli_real_escape_string($conexao, $_POST['codigo_cargo']);
    //enviando a foto para o servidor
    $foto = basename($_FILES['foto']['name']);
    $tmp = $_FILES['foto']['tmp_name'];
    $final = "../../images/" . $foto;
    move_uploaded_file($tmp, $final);

    $sql= "UPDATE funcionario SET nome = '$nome', nome_social='$nome_social', data_nascimento ='$data_nascimento', sexo ='$sexo', cpf='$cpf', rg ='$rg', estado_civil ='$estado_civil', telefone_residencial ='$telefone_residencial', telefone_celular ='$telefone_celular', salario ='$salario',  cidade ='$cidade', endereco= '$endereco', numero = '$numero', bairro = '$bairro', estado ='$estado', complemento ='$complemento', cep ='$cep', email = '$email', usuario ='$usuario', senha = '$senha', tipo_acesso = $tipo_acesso,  status = $status,  codigo_cargo = $cargo";

    if(!empty($foto))
    {
        $sql .= ", foto = '$foto'";
    }

    $sql .= " WHERE codigo_funcionario = $codigo";
    
    if(mysqli_query($conexao, $sql))
    {
        //header('location: index.php');

        $_SESSION['mensagem'] = "Funcionario atualizado com sucesso!";
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
if(isset($_POST['deletar_funcionario']))
{
    $codigo = $_POST['deletar_funcionario'];

    $sql_verifica = "SELECT funcionario.nome FROM funcionario INNER JOIN venda ON funcionario.codigo_funcionario = venda.codigo_funcionario WHERE funcionario.codigo_funcionario = $codigo";

    $query = mysqli_query($conexao, $sql_verifica);
    $contagem = mysqli_num_rows($query);
    $categoria = mysqli_fetch_assoc($query);


    if ($contagem > 0) {
        $_SESSION['mensagem'] = "Não é possivel excluir o funcionário <b> " . $categoria['nome'] ." </b> pois existem <b>". $contagem ."  venda(s) </b> vinculadas a ele!";
        header('Location: index.php');
    }
    else{
        $sql = "DELETE FROM funcionario WHERE codigo_funcionario = $codigo";

        if(mysqli_query($conexao, $sql))
        {
        $_SESSION['mensagem'] = "Funcionario excluído com sucesso!";
        header('Location: index.php');
        }
        else{
            //die("Erro:". $sql. "<br>". mysqli_error($conexao));
        $_SESSION['mensagem'] = "Erro ao excluir";
        header('Location: index.php');
        }
    }
}
?>


