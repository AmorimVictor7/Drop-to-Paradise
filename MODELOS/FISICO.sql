-- Geração de Modelo físico
-- Sql ANSI 2003 - brModelo.



CREATE TABLE cargo (
codigo_cargo INT(03)  auto_increment PRIMARY KEY,
observacao VARCHAR(50),
status BIT NOT NULL,
data_cadastro DATETIME NOT NULL,
nome_cargo VARCHAR(30)  unique not null
)

CREATE TABLE funcionario (
codigo_funcionario INT(03) auto_increment PRIMARY KEY,
nome VARCHAR(50) NOT NULL,
nome_social VARCHAR(10),
data_nascimento DATE NOT NULL,
sexo CHAR(01) NOT NULL,
cpf CHAR(14) UNIQUE NOT NULL,
rg CHAR(12),
estado_civil VARCHAR(50),
telefone_residencial CHAR(15),
telefone_celular CHAR(15),
salario DECIMAL(10,2),
cidade VARCHAR(40) NOT NULL,
endereco VARCHAR(50) NOT NULL,
numero INT(05) NOT NULL,
bairro VARCHAR(30) NOT NULL,
estado VARCHAR(02) NOT NULL,
complemento VARCHAR(10),
cep CHAR(09),
email VARCHAR(50),
data_cadastro DATETIME NOT NULL,
usuario VARCHAR(20)  UNIQUE NOT NULL,
senha VARCHAR(10) NOT NULL,
tipo_acesso BIT NOT NULL,
foto VARCHAR(02),
status BIT NOT NULL,
codigo_cargo INT(03) ,
FOREIGN KEY(codigo_cargo) REFERENCES cargo (codigo_cargo)
)

CREATE TABLE cliente (
codigo_cliente INT(03) auto_increment PRIMARY KEY,
nome VARCHAR(50) NOT NULL,
nome_social VARCHAR(10),
sexo CHAR(01) NOT NULL,
rg CHAR(12),
cpf CHAR(14) UNIQUE NOT NULL,
telefone_residencial CHAR(15),
telefone_celular CHAR(15),
cidade VARCHAR(50) NOT NULL,
estado VARCHAR(02) NOT NULL,
bairro VARCHAR(30) NOT NULL,
cep CHAR(09),
endereco VARCHAR(50) NOT NULL,
numero INT(05) NOT NULL,
complemento VARCHAR(10),
email VARCHAR NOT NULL,
status BIT NOT NULL,
data_cadastro DATETIME NOT NULL,
data_nascimento DATETIME NOT NULL
)

CREATE TABLE categoria (
codigo_categoria INT(03) auto_increment PRIMARY KEY,
status BIT NOT NULL,
nome_categoria VARCHAR(25),
data_cadastro DATETIME NOT NULL,
observacao VARCHAR(50)
)

CREATE TABLE marca (
codigo_marca INT(03) auto_increment PRIMARY KEY,
status BIT NOT NULL,
nome_marca VARCHAR(40)  unique not null,
data_cadastro DATETIME NOT NULL,
observacao VARCHAR(50)
)

CREATE TABLE produto (
codigo_produto INT(03)  auto_increment PRIMARY KEY,
status BIT NOT NULL,
nome_produto VARCHAR(30),
foto VARCHAR(50),
preco_venda DECIMAL(10,2),
preco_promocao BIT NOT NULL,
observacao VARCHAR(50),
preco_lucro DECIMAL(10,2),
preco_final_promo DECIMAL(10,2),
preco_desconto DECIMAL(10,2),
preco_custo DECIMAL(10,2),
data_cadastro DATETIME NOT NULL,
quantidade INT(07),
descricao VARCHAR(100),
codigo_marca INT(03),
codigo_categoria INT(03),
FOREIGN KEY(codigo_marca) REFERENCES marca (codigo_marca),
FOREIGN KEY(codigo_categoria) REFERENCES categoria (codigo_categoria)
)

CREATE TABLE venda (
codigo_venda INT(03) auto_increment PRIMARY KEY,
preco_final DECIMAL(10,2),
data_venda DATETIME NOT NULL,
forma_pagamento VARCHAR(30),
desconto DECIMAL(10,2),
codigo_cliente INT(03),
codigo_funcionario INT(03),
FOREIGN KEY(codigo_cliente) REFERENCES cliente (codigo_cliente),
FOREIGN KEY(codigo_funcionario) REFERENCES funcionario (codigo_funcionario)
)

CREATE TABLE item_venda (
codigo_produto INT(03) ,
codigo_venda INT(03),
preco DECIMAL(10,2),
quantidade INT(03) ,
codigo_item_venda INT(11) auto_increment PRIMARY KEY,
FOREIGN KEY(codigo_produto) REFERENCES produto (codigo_produto),
FOREIGN KEY(codigo_venda) REFERENCES venda (codigo_venda)
)

