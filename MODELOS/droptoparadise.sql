-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 18/09/2025 às 17:00
-- Versão do servidor: 10.4.32-MariaDB
-- Versão do PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `droptoparadise`
--
CREATE DATABASE IF NOT EXISTS `droptoparadise` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `droptoparadise`;

-- --------------------------------------------------------

--
-- Estrutura para tabela `cargo`
--

CREATE TABLE IF NOT EXISTS `cargo` (
  `codigo_cargo` int(3) NOT NULL AUTO_INCREMENT,
  `observacao` varchar(50) DEFAULT NULL,
  `status` bit(1) NOT NULL,
  `data_cadastro` datetime NOT NULL,
  `nome_cargo` varchar(30) NOT NULL,
  PRIMARY KEY (`codigo_cargo`),
  UNIQUE KEY `nome_cargo` (`nome_cargo`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `cargo`
--

INSERT INTO `cargo` (`codigo_cargo`, `observacao`, `status`, `data_cadastro`, `nome_cargo`) VALUES
(3, '', b'1', '2025-06-12 21:57:20', 'Chefe'),
(6, '', b'1', '2025-07-05 10:14:12', 'Vendedor'),
(9, '', b'1', '2025-07-31 02:02:41', 'Caixa'),
(14, '', b'1', '2025-08-13 22:55:05', 'Gerente'),
(15, '', b'1', '2025-08-13 22:55:58', 'Empacotador');

-- --------------------------------------------------------

--
-- Estrutura para tabela `categoria`
--

CREATE TABLE IF NOT EXISTS `categoria` (
  `codigo_categoria` int(3) NOT NULL AUTO_INCREMENT,
  `status` bit(1) NOT NULL,
  `nome_categoria` varchar(25) NOT NULL,
  `data_cadastro` datetime NOT NULL,
  `observacao` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`codigo_categoria`),
  UNIQUE KEY `nome_categoria` (`nome_categoria`)
) ENGINE=InnoDB AUTO_INCREMENT=27 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `categoria`
--

INSERT INTO `categoria` (`codigo_categoria`, `status`, `nome_categoria`, `data_cadastro`, `observacao`) VALUES
(8, b'1', 'montado', '2025-08-01 15:07:40', ''),
(10, b'1', 'shape', '2025-08-07 13:49:56', ''),
(11, b'1', 'truck', '2025-08-07 13:51:25', ''),
(12, b'1', 'roda', '2025-08-07 13:51:30', ''),
(13, b'1', 'rolamento', '2025-08-07 14:02:01', ''),
(14, b'1', 'lixa', '2025-08-07 14:04:18', ''),
(15, b'1', 'prancha', '2025-08-07 14:04:24', ''),
(16, b'1', 'quilha', '2025-08-07 14:04:29', ''),
(17, b'1', 'leash', '2025-08-07 14:04:40', ''),
(18, b'1', 'parafina', '2025-08-07 14:04:46', ''),
(19, b'1', 'deck', '2025-08-07 14:04:51', ''),
(20, b'1', 'roupa de borracha', '2025-08-07 14:05:14', ''),
(21, b'1', 'boné', '2025-08-07 14:07:35', ''),
(22, b'1', 'camisa', '2025-08-07 14:07:40', ''),
(23, b'1', 'blusa', '2025-08-07 14:07:44', ''),
(24, b'1', 'calça', '2025-08-07 14:07:50', ''),
(25, b'1', 'short', '2025-08-07 14:07:55', ''),
(26, b'1', 'tênis', '2025-08-07 14:08:00', '');

-- --------------------------------------------------------

--
-- Estrutura para tabela `cliente`
--

CREATE TABLE IF NOT EXISTS `cliente` (
  `codigo_cliente` int(3) NOT NULL AUTO_INCREMENT,
  `nome` varchar(50) NOT NULL,
  `nome_social` varchar(10) DEFAULT NULL,
  `sexo` char(1) NOT NULL,
  `rg` char(12) DEFAULT NULL,
  `cpf` char(14) NOT NULL,
  `telefone_residencial` char(15) DEFAULT NULL,
  `telefone_celular` char(15) DEFAULT NULL,
  `cidade` varchar(50) NOT NULL,
  `estado` varchar(2) NOT NULL,
  `bairro` varchar(30) NOT NULL,
  `cep` char(9) DEFAULT NULL,
  `endereco` varchar(50) NOT NULL,
  `numero` int(5) NOT NULL,
  `complemento` varchar(10) DEFAULT NULL,
  `email` varchar(50) DEFAULT NULL,
  `status` bit(1) NOT NULL,
  `data_cadastro` datetime NOT NULL,
  `data_nascimento` date NOT NULL,
  PRIMARY KEY (`codigo_cliente`),
  UNIQUE KEY `cpf` (`cpf`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `cliente`
--

INSERT INTO `cliente` (`codigo_cliente`, `nome`, `nome_social`, `sexo`, `rg`, `cpf`, `telefone_residencial`, `telefone_celular`, `cidade`, `estado`, `bairro`, `cep`, `endereco`, `numero`, `complemento`, `email`, `status`, `data_cadastro`, `data_nascimento`) VALUES
(1, 'felipe ', 'boladao', 'M', '54.355.656-4', '323.425.345-34', '(14)3235-3421', '(14)3235-3421', 'santos', 'RJ', 'outro bairro', '12132-131', 'rua', 10, 'c', 'boladao@hotmal.com', b'1', '2025-06-24 10:40:20', '1996-11-19');

-- --------------------------------------------------------

--
-- Estrutura para tabela `funcionario`
--

CREATE TABLE IF NOT EXISTS `funcionario` (
  `codigo_funcionario` int(3) NOT NULL AUTO_INCREMENT,
  `nome` varchar(50) NOT NULL,
  `nome_social` varchar(10) DEFAULT NULL,
  `data_nascimento` date NOT NULL,
  `sexo` char(1) NOT NULL,
  `cpf` char(14) NOT NULL,
  `rg` char(12) DEFAULT NULL,
  `estado_civil` varchar(50) DEFAULT NULL,
  `telefone_residencial` char(15) DEFAULT NULL,
  `telefone_celular` char(15) DEFAULT NULL,
  `salario` decimal(10,2) DEFAULT NULL,
  `cidade` varchar(40) NOT NULL,
  `endereco` varchar(50) NOT NULL,
  `numero` int(5) NOT NULL,
  `bairro` varchar(30) NOT NULL,
  `estado` varchar(2) NOT NULL,
  `complemento` varchar(10) DEFAULT NULL,
  `cep` char(9) DEFAULT NULL,
  `email` varchar(50) DEFAULT NULL,
  `data_cadastro` datetime NOT NULL,
  `usuario` varchar(20) NOT NULL,
  `senha` varchar(10) NOT NULL,
  `tipo_acesso` bit(1) NOT NULL,
  `foto` varchar(2) DEFAULT NULL,
  `status` bit(1) NOT NULL,
  `codigo_cargo` int(3) DEFAULT NULL,
  PRIMARY KEY (`codigo_funcionario`),
  UNIQUE KEY `cpf` (`cpf`),
  UNIQUE KEY `usuario` (`usuario`),
  KEY `codigo_cargo` (`codigo_cargo`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `funcionario`
--

INSERT INTO `funcionario` (`codigo_funcionario`, `nome`, `nome_social`, `data_nascimento`, `sexo`, `cpf`, `rg`, `estado_civil`, `telefone_residencial`, `telefone_celular`, `salario`, `cidade`, `endereco`, `numero`, `bairro`, `estado`, `complemento`, `cep`, `email`, `data_cadastro`, `usuario`, `senha`, `tipo_acesso`, `foto`, `status`, `codigo_cargo`) VALUES
(1, 'Victor Amorim', '', '2000-11-12', 'M', '124.444.444-44', '21.333.333-3', 'Solteiro(a)', '(21) 2112-2112', '(21) 21122-112', 10000.00, 'Santo Antônio de Jesus', 'Rua Via Coletora B', 112, 'Nossa Senhora das Graças', 'BA', '', '12444-44', 'amorimvictor511@gmail.com', '2025-06-16 20:56:41', 'amorim', '1234', b'1', '', b'1', 3),
(4, 'Victor Engel', '', '2021-12-27', 'N', '564.324.235-24', '43.323.324-3', 'Solteiro(a)', '(32) 1111-1111', '(21) 34444-4444', 0.00, 'Santo Antônio de Jesus', 'Rua Via Coletora B', 1, 'Nossa Senhora das Graças', 'BA', '', '44444-444', 'engel@123.com', '2025-07-31 02:01:02', 'engel', '123', b'1', '', b'1', 9),
(5, 'Vitor Acamago', '', '2025-07-07', 'M', '876.722.375-53', '45.435.453-2', 'Solteiro(a)', '(34) 3243-4545', '(34) 35454-5234', 23.44, 'Santo Antônio de Jesus', 'Rua Via Coletora B', 34, 'Nossa Senhora das Graças', 'BA', '3432', '44444-444', 'gaara@hotmail.com', '2025-07-31 02:02:20', 'garica', '123', b'0', '', b'1', 6),
(6, 'João Duarte ', 'Dasarte', '2007-07-26', 'N', '535.709.876-54', '43.456.787-6', 'Solteiro(a)', '(42) 3423-4324', '(43) 65412-3412', 3122.22, 'Santo Antônio de Jesus', 'Rua Via Coletora B', 4, 'Nossa Senhora das Graças', 'BA', '', '44444-444', 'joaodograu@3.br', '2025-08-04 13:49:22', 'joao', '123', b'0', '', b'1', 6),
(7, 'Iuri', 'Sanches', '2007-12-05', 'M', '987.654.323-45', '45.536.775-6', 'Solteiro(a)', '(43) 2423-4324', '(21) 22443-5233', 23423.42, 'Santo Antônio de Jesus', 'Rua Via Coletora B', 1, 'Nossa Senhora das Graças', 'BA', '23', '44444-444', 'Iuri667@hotmail.com', '2025-08-04 13:50:32', 'iuri', '123', b'1', '', b'1', 6);

-- --------------------------------------------------------

--
-- Estrutura para tabela `item_venda`
--

CREATE TABLE IF NOT EXISTS `item_venda` (
  `codigo_produto` int(3) DEFAULT NULL,
  `codigo_venda` int(3) DEFAULT NULL,
  `preco` decimal(10,2) DEFAULT NULL,
  `quantidade` int(3) DEFAULT NULL,
  `codigo_item_venda` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`codigo_item_venda`),
  KEY `codigo_produto` (`codigo_produto`),
  KEY `codigo_venda` (`codigo_venda`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `item_venda`
--

INSERT INTO `item_venda` (`codigo_produto`, `codigo_venda`, `preco`, `quantidade`, `codigo_item_venda`) VALUES
(57, 36, 711.42, 1, 1),
(57, 37, 711.42, 1, 2),
(57, 38, 2134.26, 3, 3),
(51, 39, 23.21, 1, 4),
(57, 40, 711.42, 1, 5),
(51, 41, 23.21, 1, 6),
(57, 42, 2134.26, 3, 7),
(51, 43, 23.21, 1, 8),
(51, 44, 23.21, 1, 9);

-- --------------------------------------------------------

--
-- Estrutura para tabela `marca`
--

CREATE TABLE IF NOT EXISTS `marca` (
  `codigo_marca` int(3) NOT NULL AUTO_INCREMENT,
  `status` bit(1) NOT NULL,
  `nome_marca` varchar(40) NOT NULL,
  `data_cadastro` datetime NOT NULL,
  `observacao` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`codigo_marca`),
  UNIQUE KEY `nome_marca` (`nome_marca`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `marca`
--

INSERT INTO `marca` (`codigo_marca`, `status`, `nome_marca`, `data_cadastro`, `observacao`) VALUES
(1, b'1', 'Oakley', '2025-06-16 20:24:38', ''),
(4, b'1', 'Onbongo', '2025-07-31 02:03:46', ''),
(5, b'1', 'Surf Wax', '2025-07-31 02:04:12', ''),
(6, b'1', 'Cb Gang', '2025-08-01 15:09:15', ''),
(7, b'1', 'Adidas', '2025-08-13 22:58:54', ''),
(8, b'1', 'Element', '2025-08-14 00:11:13', '');

-- --------------------------------------------------------

--
-- Estrutura para tabela `produto`
--

CREATE TABLE IF NOT EXISTS `produto` (
  `codigo_produto` int(3) NOT NULL AUTO_INCREMENT,
  `status` bit(1) NOT NULL,
  `nome_produto` varchar(30) DEFAULT NULL,
  `foto` varchar(50) DEFAULT NULL,
  `preco_venda` decimal(10,2) DEFAULT NULL,
  `preco_promocao` bit(1) NOT NULL,
  `observacao` varchar(50) DEFAULT NULL,
  `preco_lucro` decimal(10,2) DEFAULT NULL,
  `preco_final_promo` decimal(10,2) DEFAULT NULL,
  `preco_desconto` decimal(10,2) DEFAULT NULL,
  `preco_custo` decimal(10,2) DEFAULT NULL,
  `data_cadastro` datetime NOT NULL,
  `quantidade` int(7) DEFAULT NULL,
  `descricao` varchar(50) DEFAULT NULL,
  `codigo_marca` int(3) DEFAULT NULL,
  `codigo_categoria` int(3) DEFAULT NULL,
  PRIMARY KEY (`codigo_produto`),
  KEY `codigo_marca` (`codigo_marca`),
  KEY `codigo_categoria` (`codigo_categoria`)
) ENGINE=InnoDB AUTO_INCREMENT=71 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `produto`
--

INSERT INTO `produto` (`codigo_produto`, `status`, `nome_produto`, `foto`, `preco_venda`, `preco_promocao`, `observacao`, `preco_lucro`, `preco_final_promo`, `preco_desconto`, `preco_custo`, `data_cadastro`, `quantidade`, `descricao`, `codigo_marca`, `codigo_categoria`) VALUES
(51, b'1', 'Parafina Surf Wax', 'parafina.webp', 23.21, b'1', '11', 111.00, 21.35, 8.00, 11.00, '2025-07-28 21:46:17', 8, 'Surf Wax – aderência total nas suas ondas', 5, 18),
(52, b'1', 'Tenis Mizuno', 'tenis.webp', 550.00, b'0', '11', 10.00, 0.00, 0.00, 500.00, '2025-07-31 17:09:11', 4, 'Mizuno – conforto e performance nos seus passos', 1, 26),
(53, b'1', 'Skate Montado Susto', 'skate montado.jpg', 300.00, b'1', '', 50.00, 240.00, 20.00, 200.00, '2025-08-01 15:12:30', 7, 'Skate Montado Susto', 6, 8),
(54, b'1', 'Skate Montado  LINUX', 'linux.jpg', 300.00, b'1', '', 100.00, 240.00, 20.00, 150.00, '2025-08-01 15:14:23', 3, 'Skate da linux\r\n', 6, 8),
(55, b'0', 'shape sem foto', '', 2354.79, b'0', '534', 4343.00, 0.00, 0.00, 53.00, '2025-08-01 17:01:23', 43, '443', 1, 10),
(57, b'0', 'com promo', '', 711.42, b'1', '34', 234.00, 405.51, 43.00, 213.00, '2025-08-06 16:13:22', 40, '34', 4, 8),
(60, b'1', 'Skate Montado Windows', 'download.png', 600.00, b'0', '', 20.00, 0.00, 0.00, 500.00, '2025-08-14 00:12:16', 10, 'Skate windows', 8, 8),
(61, b'1', 'Skate Montado Bully', 'download (1).jpeg', 1847.56, b'1', '', 5334.00, 1755.18, 5.00, 34.00, '2025-08-14 00:24:05', 45, 'Skate zica pra dar um piao', 6, 8),
(62, b'1', 'Skate Montado Nirvana', 'images.png', 12.00, b'0', '', 20.00, 0.00, 0.00, 10.00, '2025-08-14 00:25:07', 23, 'skate do nirvana', 1, 8),
(63, b'1', 'Shape Maple Mike Dias', 'download (2).jpeg', 400.00, b'1', '', 300.00, 320.00, 20.00, 100.00, '2025-08-14 00:28:26', 5, 'shape pro-model de um mano famoso', 1, 10),
(64, b'1', 'Shape Amy', 'images (1).jpeg', 2569.44, b'0', '', 112.00, 0.00, 0.00, 1212.00, '2025-08-14 00:34:33', 12, 'Estilo e resistência na medida certa.', 1, 10),
(65, b'1', 'Roda Cbgang', 'bnnrtar-d3b566139ddd1db82917442865496017-480-0.jpg', 105.00, b'0', '', 5.00, 0.00, 0.00, 100.00, '2025-08-14 00:37:22', 344, 'Só mais uma roda', 1, 12),
(66, b'0', 'Prancha de fogo', 'download (3).jpeg', 126.88, b'0', '', 4.00, 0.00, 0.00, 122.00, '2025-08-14 00:38:46', 4, 'pranhca boa pra quem ja é bom 3 quilhas', 1, 15);

-- --------------------------------------------------------

--
-- Estrutura para tabela `venda`
--

CREATE TABLE IF NOT EXISTS `venda` (
  `codigo_venda` int(3) NOT NULL AUTO_INCREMENT,
  `preco_final` decimal(10,2) DEFAULT NULL,
  `data_venda` datetime NOT NULL,
  `forma_pagamento` varchar(30) DEFAULT NULL,
  `desconto` decimal(10,2) DEFAULT NULL,
  `codigo_cliente` int(3) DEFAULT NULL,
  `codigo_funcionario` int(3) DEFAULT NULL,
  PRIMARY KEY (`codigo_venda`),
  KEY `codigo_cliente` (`codigo_cliente`),
  KEY `codigo_funcionario` (`codigo_funcionario`)
) ENGINE=InnoDB AUTO_INCREMENT=45 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `venda`
--

INSERT INTO `venda` (`codigo_venda`, `preco_final`, `data_venda`, `forma_pagamento`, `desconto`, `codigo_cliente`, `codigo_funcionario`) VALUES
(1, 0.00, '2025-08-07 15:49:38', 'Dinheiro', 0.00, 1, 7),
(2, 0.00, '2025-08-07 15:49:46', 'Dinheiro', 0.00, 1, 7),
(3, 0.00, '2025-08-07 15:50:00', 'Dinheiro', 0.00, 1, 7),
(4, 0.00, '2025-08-07 15:50:59', 'Dinheiro', 0.00, 1, 7),
(5, 0.00, '2025-08-07 15:51:03', 'Dinheiro', 0.00, 1, 7),
(6, 0.00, '2025-08-07 15:51:07', 'Dinheiro', 0.00, 1, 7),
(7, 0.00, '2025-08-07 15:51:26', 'Cartão de Crédito', 0.00, 1, 6),
(8, 0.00, '2025-08-07 15:51:31', 'Cartão de Crédito', 0.00, 1, 6),
(9, 0.00, '2025-08-07 15:52:16', 'Cartão de Débito', 0.00, 1, 6),
(10, 0.00, '2025-08-07 15:52:19', 'Cartão de Débito', 0.00, 1, 6),
(11, 0.00, '2025-08-07 15:54:02', 'Cartão de Crédito', 0.00, 1, 4),
(12, 0.00, '2025-08-07 15:54:19', 'Cartão de Crédito', 0.00, 1, 4),
(13, 0.00, '2025-08-07 15:54:54', 'Dinheiro', 0.00, 1, 6),
(14, 0.00, '2025-08-07 15:54:56', 'Dinheiro', 0.00, 1, 6),
(15, 0.00, '2025-08-07 15:56:21', 'Dinheiro', 0.00, 1, 6),
(16, 0.00, '2025-08-07 15:56:33', 'Dinheiro', 0.00, 1, 6),
(17, 0.00, '2025-08-07 15:56:36', 'Dinheiro', 0.00, 1, 6),
(18, 0.00, '2025-08-07 15:57:00', 'Dinheiro', 0.00, 1, 6),
(19, 0.00, '2025-08-07 15:57:15', 'Dinheiro', 0.00, 1, 6),
(20, 0.00, '2025-08-07 15:57:51', 'Dinheiro', 0.00, 1, 6),
(21, 0.00, '2025-08-07 15:58:40', 'Dinheiro', 0.00, 1, 6),
(22, 0.00, '2025-08-07 15:59:11', 'Dinheiro', 0.00, 1, 6),
(23, 0.00, '2025-08-07 15:59:17', 'Dinheiro', 0.00, 1, 6),
(24, 0.00, '2025-08-07 15:59:18', 'Dinheiro', 0.00, 1, 6),
(25, 0.00, '2025-08-07 15:59:27', 'Dinheiro', 0.00, 1, 6),
(26, 0.00, '2025-08-07 15:59:27', 'Dinheiro', 0.00, 1, 6),
(27, 0.00, '2025-08-07 15:59:28', 'Dinheiro', 0.00, 1, 6),
(28, 0.00, '2025-08-07 15:59:28', 'Dinheiro', 0.00, 1, 6),
(29, 0.00, '2025-08-07 15:59:28', 'Dinheiro', 0.00, 1, 6),
(30, 0.00, '2025-08-07 15:59:28', 'Dinheiro', 0.00, 1, 6),
(31, 0.00, '2025-08-07 16:00:15', 'Dinheiro', 0.00, 1, 6),
(32, 0.00, '2025-08-07 16:00:43', 'Dinheiro', 0.00, 1, 6),
(33, 0.00, '2025-08-07 16:00:43', 'Dinheiro', 0.00, 1, 6),
(34, 0.00, '2025-08-07 16:00:46', 'Dinheiro', 0.00, 1, 6),
(35, 0.00, '2025-08-07 16:01:16', 'Dinheiro', 0.00, 1, 6),
(36, 0.00, '2025-08-07 16:01:34', 'Dinheiro', 0.00, 1, 6),
(37, 0.00, '2025-08-07 16:02:32', 'Dinheiro', 0.00, 1, 6),
(38, 0.00, '2025-08-07 16:31:09', 'Dinheiro', 0.00, 1, 7),
(39, 0.00, '2025-08-07 16:33:20', 'Cartão de Débito', 0.00, 1, 1),
(40, 0.00, '2025-08-07 16:34:37', 'Dinheiro', 0.00, 1, 6),
(41, 0.00, '2025-08-07 16:37:17', 'Cartão de Débito', 0.00, 1, 4),
(42, 0.00, '2025-08-07 16:38:20', 'Cartão de Débito', 0.00, 1, 6),
(43, 23.21, '2025-08-14 10:43:31', 'Dinheiro', 0.00, 1, 7),
(44, 23.21, '2025-08-14 10:47:41', 'Pix', 0.00, 1, 7);

--
-- Restrições para tabelas despejadas
--

--
-- Restrições para tabelas `funcionario`
--
ALTER TABLE `funcionario`
  ADD CONSTRAINT `funcionario_ibfk_1` FOREIGN KEY (`codigo_cargo`) REFERENCES `cargo` (`codigo_cargo`);

--
-- Restrições para tabelas `item_venda`
--
ALTER TABLE `item_venda`
  ADD CONSTRAINT `item_venda_ibfk_1` FOREIGN KEY (`codigo_produto`) REFERENCES `produto` (`codigo_produto`),
  ADD CONSTRAINT `item_venda_ibfk_2` FOREIGN KEY (`codigo_venda`) REFERENCES `venda` (`codigo_venda`);

--
-- Restrições para tabelas `produto`
--
ALTER TABLE `produto`
  ADD CONSTRAINT `produto_ibfk_1` FOREIGN KEY (`codigo_marca`) REFERENCES `marca` (`codigo_marca`),
  ADD CONSTRAINT `produto_ibfk_2` FOREIGN KEY (`codigo_categoria`) REFERENCES `categoria` (`codigo_categoria`);

--
-- Restrições para tabelas `venda`
--
ALTER TABLE `venda`
  ADD CONSTRAINT `venda_ibfk_1` FOREIGN KEY (`codigo_cliente`) REFERENCES `cliente` (`codigo_cliente`),
  ADD CONSTRAINT `venda_ibfk_2` FOREIGN KEY (`codigo_funcionario`) REFERENCES `funcionario` (`codigo_funcionario`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
