-- -----------------------------------------------------
--  criação banco integrador
-- -----------------------------------------------------

CREATE DATABASE TudoAcabaEmPizzaDB;
USE TudoAcabaEmPizzaDB;
-- drop database TudoAcabaEmPizzaDB
-- --
-- CRIAÇÃO TABELAS DO BANCO--
-- TABALE CLIENTES--
CREATE TABLE CLIENTES
(
ID INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
NOME VARCHAR(200) NOT NULL,
DATA_NASC DATETIME,
CPF CHAR(11) NOT NULL UNIQUE,
EMAIL VARCHAR(200) NOT NULL UNIQUE,
SENHA VARCHAR(20) NOT NULL,
DATA_CAD TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
ATIVO BIT(1) NOT NULL DEFAULT 1
);

-- TABALE ENDEREÇOS--
CREATE TABLE ENDERECOS
(
ID INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
CEP CHAR(8) NOT NULL,
ATIVO BIT(1) NOT NULL DEFAULT 1,
CLIENTE_ID INT NOT NULL,
TIPO_ENDERECO_ID INT NOT NULL,
LOGRADOURO VARCHAR(100) NOT NULL,
NUMERO VARCHAR(40) NOT NULL,
COMPLEMENTO VARCHAR(60) NULL,
BAIRRO VARCHAR(60) NOT NULL,
CIDADE VARCHAR(60) NOT NULL,
UF CHAR(2) NOT NULL
);

-- TABALE TIPO_ENDERECO--
CREATE TABLE TIPOS_ENDERECO
(
ID INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
SIGLA CHAR(3) NOT NULL,
DESCRICAO VARCHAR(30) NOT NULL,
ATIVO BIT(1) NOT NULL DEFAULT 1
);

-- TABELA AVALIAÇÃO --
CREATE TABLE AVALIACOES
(
ID INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
NOTA DECIMAL(3,2) NOT NULL,
COMENTARIO VARCHAR(200) NULL,
DATA_AVALIACAO TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
CLIENTE_ID INT NOT NULL,
PRODUTO_ID INT NOT NULL
);

-- TABELA TIPO_TELEFONE --
CREATE TABLE TIPOS_TELEFONE
(
ID INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
SIGLA CHAR(3) NOT NULL,
DESCRICAO VARCHAR(30) NOT NULL,
ATIVO BIT(1) NOT NULL DEFAULT 1
);

-- TABELA TELEFONE--
CREATE TABLE TELEFONES
(
ID INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
DDI VARCHAR(3) NOT NULL,
DDD CHAR(2) NOT NULL,
NUMERO CHAR(9) NOT NULL,
ATIVO BIT(1) NOT NULL DEFAULT 1,
TIPO_TELEFONE_ID INT NOT NULL,
CLIENTE_ID INT NOT NULL
);

-- TABELA PRODUTOS--
CREATE TABLE PRODUTOS 
(
ID INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
NOME VARCHAR(45) NOT NULL,
DESCRICAO VARCHAR(150) NULL,
VALOR_UNIT DECIMAL(10,2) NOT NULL,
COD_BARRAS VARCHAR(60) NULL,
LINK_IMAGEM VARCHAR(200) NULL,
DATA_CAD TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
CATEGORIA_ID INT NOT NULL, 
ATIVO BIT(1) NOT NULL DEFAULT 1
);
-- TABELA STATUS--
CREATE TABLE `STATUS`
(
ID INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
SIGLA CHAR(3) NOT NULL,
DESCRICAO VARCHAR(30) NOT NULL,
ATIVO BIT(1) NOT NULL DEFAULT 1
);

-- TABELA ADICIONAIS--
CREATE TABLE ADICIONAIS
(
ID INT  NOT NULL PRIMARY KEY AUTO_INCREMENT,
DESCRICAO VARCHAR(100) NOT NULL,
PRECO DECIMAL(10,2) NOT NULL,
ATIVO BIT(1) NOT NULL DEFAULT 1
);

-- TABELA CATEGORIAS--
CREATE TABLE CATEGORIAS
(
ID INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
NOME VARCHAR(40) NOT NULL,
SIGLA CHAR(3) NOT NULL,
ATIVO BIT(1) NOT NULL DEFAULT 1
);

-- TABELA USUARIOS --
CREATE TABLE USUARIOS
(
ID INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
NOME VARCHAR(60) NOT NULL,
EMAIL VARCHAR(60) NOT NULL,
SENHA VARCHAR(20) NOT NULL,
ATIVO BIT(1) NOT NULL DEFAULT 1,
NIVEL_ID INT NOT NULL
);

-- TABELA NIVEIS--
CREATE TABLE NIVEIS
(
ID INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
NOME VARCHAR(45) NOT NULL,
SIGLA CHAR(3) NOT NULL,
ATIVO BIT(1) NOT NULL DEFAULT(1)
); 

-- TABELA CAIXA--
CREATE TABLE CAIXA
(
ID INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
DATA_ABERTURA datetime,
DATA_FECHAMENTO datetime,
SALDO_INICIAL DECIMAL(10,2),
USUARIO_ID INT NOT NULL,
STATUS_ID INT NOT NULL
);

-- TABELA TIPO_BORDA--
CREATE TABLE TIPOS_BORDA
(
ID INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
DESCRICAO VARCHAR(200) NOT NULL,
PRECO DECIMAL(10,2) NOT NULL,
ATIVO BIT(1) NOT NULL DEFAULT 1
);

-- PEDIDO_TIPO_BORDA
CREATE TABLE PEDIDO_TIPO_BORDA
(
ID INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
PEDIDO_ID INT NOT NULL,
TIPO_BORDA_ID INT NOT NULL
);

-- TABELA ITEM_PEDIDO--
CREATE TABLE ITEM_PEDIDO
(
ID INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
VALOR_UNIT DECIMAL(10,2) NOT NULL,
QUANTIDADE DECIMAL(10,2) NOT NULL,
PEDIDO_ID INT NOT NULL,
PRODUTO_ID INT NOT NULL,
TAMANHO_PIZZA_ID INT NULL
);

-- TABELA PAGAMENTO--
CREATE TABLE PAGAMENTO
(
ID INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
TIPO_PAGAMENTO_ID INT NOT  NULL,
PEDIDO_ID INT NOT NULL,
PARCELAS TINYINT(2) NOT NULL
);

-- TABELA TIPO_PAGAMENTO
CREATE TABLE TIPOS_PAGAMENTO
(
ID INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
SIGLA CHAR(3) NOT NULL,
DESCRICAO VARCHAR(30) NOT NULL
);

-- TABELA CLASSE_DESCONTO

CREATE TABLE CLASSES_DESCONTO
(
ID INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
NOME VARCHAR(45) NOT NULL,
DESCONTO DECIMAL(10,2) NOT NULL
);

-- PEDIDOS 
CREATE TABLE PEDIDOS
(
ID INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
DATA_PEDIDO TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
USUARIO_ID INT NOT NULL,
CLIENTE_ID INT NOT NULL,
STATUS_ID INT NOT NULL,
CLASSE_DESCONTO_ID INT NOT NULL
); 

-- PAGAMENTO_PEDIDO
CREATE TABLE PAGAMENTO_PEDIDO
(
ID INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
PAGAMENTO_ID INT NOT NULL,
PEDIDO_ID INT NOT NULL,
STATUS_ID INT NOT NULL,
DATA_PAG TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP
);

-- PEDIDO_ADICIONAL
CREATE TABLE PEDIDO_ADICIONAL
(
ID INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
PEDIDO_ID INT NOT NULL ,
ADICIONAL_ID INT NOT NULL
);

-- TAMANHO_PIZZA
CREATE TABLE TAMANHOS_PIZZA
-- drop TABLE TAMANHOS_PIZZA
 -- drop constraint tamanhos_pizza
(
ID INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
SIGLA varchar(3) NOT NULL,
DESCRICAO VARCHAR(60) NOT NULL,
ATIVO BIT(1) NOT NULL DEFAULT 1
);
-- -----------------------------------------------------
-- CRIAÇAO CHAVES ESTRANGEIRAS
-- -----------------------------------------------------

-- -----------------------------------------------------
-- CHAVES TABELA ENDERECOS
-- -----------------------------------------------------
ALTER TABLE ENDERECOS
ADD CONSTRAINT FK_ENDERECOS_CLIENTE FOREIGN KEY(CLIENTE_ID)
REFERENCES CLIENTES(ID);

ALTER TABLE ENDERECOS
ADD CONSTRAINT FK_ENDERECOS_TIPO_ENDERECO FOREIGN KEY (TIPO_ENDERECO_ID)
REFERENCES TIPOS_ENDERECO(ID);
-- -----------------------------------------------------
-- FIM CHAVES ENDERECO
-- -----------------------------------------------------

-- -----------------------------------------------------
-- CHAVES TABELA TELEFONE
-- -----------------------------------------------------
ALTER TABLE TELEFONES
ADD CONSTRAINT FK_TELEFONES_CLIENTE FOREIGN KEY(CLIENTE_ID)
REFERENCES CLIENTES(ID);

ALTER TABLE TELEFONES
ADD CONSTRAINT FK_TELEFONES_TIPO_TELEFONE FOREIGN KEY(TIPO_TELEFONE_ID)
REFERENCES TIPOS_TELEFONE(ID);
-- -----------------------------------------------------

-- -----------------------------------------------------
-- FIM CHAVES TELEFONE
-- -----------------------------------------------------

-- -----------------------------------------------------
-- CHAVES TABELA AVALIAÇÕES
-- -----------------------------------------------------
ALTER TABLE AVALIACOES
ADD CONSTRAINT FK_AVALIACOES_CLIENTE_ID FOREIGN KEY(CLIENTE_ID)
REFERENCES CLIENTES(ID);

ALTER TABLE AVALIACOES
ADD CONSTRAINT FK_AVALIACOES_PRODUTO_ID FOREIGN KEY(PRODUTO_ID)
REFERENCES PRODUTOS(ID);
-- -----------------------------------------------------
-- FIM CHAVES AVALIAÇÕES 
-- -----------------------------------------------------

-- -----------------------------------------------------
-- CHAVES TABELA PRODUTOS
-- -----------------------------------------------------
ALTER TABLE PRODUTOS
ADD CONSTRAINT FK_PRODUTOS_CATEGORIA_ID FOREIGN KEY(CATEGORIA_ID)
REFERENCES CATEGORIAS(ID);
-- -----------------------------------------------------
-- FIM CHAVES PRODUTOS
-- -----------------------------------------------------

-- -----------------------------------------------------
-- CHAVES TABELA PAGAMENTO
-- -----------------------------------------------------
ALTER TABLE PAGAMENTO
ADD CONSTRAINT FK_PAGAMENTO_TIPO_PAGAMENTO FOREIGN KEY(TIPO_PAGAMENTO_ID)
REFERENCES TIPOS_PAGAMENTO(ID);
-- -----------------------------------------------------
-- FIM CHAVES PAGAMENTO
-- -----------------------------------------------------

-- -----------------------------------------------------
-- CHAVES TABELA USUARIOS
-- -----------------------------------------------------
ALTER TABLE USUARIOS
ADD CONSTRAINT FK_USUARIOS_NIVEIS_ID FOREIGN KEY (NIVEL_ID)
REFERENCES NIVEIS(ID);
-- -----------------------------------------------------
-- FIM CHAVES USUARIOS
-- -----------------------------------------------------

-- -----------------------------------------------------
-- CHAVES TABELA CAIXA
-- -----------------------------------------------------
ALTER TABLE CAIXA
ADD CONSTRAINT FK_CAIXA_USUARIOS_ID FOREIGN KEY(USUARIO_ID)
REFERENCES USUARIOS(ID);

ALTER TABLE CAIXA
ADD CONSTRAINT FK_CAIXA_STATUS_ID FOREIGN KEY(STATUS_ID)
REFERENCES `STATUS`(ID);
-- -----------------------------------------------------
-- FIM CHAVES CAIXA
-- -----------------------------------------------------

-- -----------------------------------------------------
-- CHAVES TABELA PEDIDO
-- -----------------------------------------------------
ALTER TABLE PEDIDOS
ADD CONSTRAINT FK_PEDIDO_USUARIO_ID FOREIGN KEY(USUARIO_ID)
REFERENCES USUARIOS(ID);

ALTER TABLE PEDIDOS
ADD CONSTRAINT FK_PEDIDO_CLIENTE_ID FOREIGN KEY(CLIENTE_ID)
REFERENCES CLIENTES(ID);

ALTER TABLE PEDIDOS
ADD CONSTRAINT FK_PEDIDO_CLASSE_DESCONTO FOREIGN KEY(CLASSE_DESCONTO_ID)
REFERENCES CLASSES_DESCONTO(ID);

ALTER TABLE PEDIDOS
ADD CONSTRAINT FK_PEDIDO_STATUS_ID FOREIGN KEY(STATUS_ID)
REFERENCES `STATUS`(ID);
-- -----------------------------------------------------
-- FIM CHAVES PEDIDO
-- -----------------------------------------------------

-- -----------------------------------------------------
-- CHAVES TABELA ITEM_PEDIDO
-- -----------------------------------------------------
ALTER TABLE ITEM_PEDIDO
ADD CONSTRAINT FK_ITEM_PEDIDO_PEDIDO FOREIGN KEY(PEDIDO_ID)
REFERENCES PEDIDOS(ID);

ALTER TABLE ITEM_PEDIDO
ADD CONSTRAINT FK_ITEM_PEDIDO_PRODUTO FOREIGN KEY(PRODUTO_ID)
REFERENCES PRODUTOS(ID);

ALTER TABLE ITEM_PEDIDO
ADD CONSTRAINT FK_ITEM_PEDIDO_TAMANHO_PIZZA_ID FOREIGN KEY(TAMANHO_PIZZA_ID)
REFERENCES TAMANHOS_PIZZA(ID);
-- -----------------------------------------------------
-- FIM CHAVES ITEM_PEDIDO
-- -----------------------------------------------------

-- -----------------------------------------------------
-- CHAVES TABELA PEDIDO_ADICIONAL
-- -----------------------------------------------------
ALTER TABLE PEDIDO_ADICIONAL
ADD CONSTRAINT FK_PEDIDO_ADICIONAL_PEDIDO_ID FOREIGN KEY(PEDIDO_ID)
REFERENCES PEDIDOS(ID);

ALTER TABLE PEDIDO_ADICIONAL
ADD CONSTRAINT FK_PEDIDO_ADICIONAL_ADICIONAL_ID FOREIGN KEY(ADICIONAL_ID)
REFERENCES ADICIONAIS(ID);
-- -----------------------------------------------------
-- FIM CHAVES PEDIDO_ADICIONAL
-- -----------------------------------------------------

-- -----------------------------------------------------
-- CHAVES TABELA PEDIDO_TIPO_BORDA
-- -----------------------------------------------------
ALTER TABLE PEDIDO_TIPO_BORDA
ADD CONSTRAINT FK_PEDIDO_TIPO_BORDA_PEDIDO_ID FOREIGN KEY(PEDIDO_ID)
REFERENCES PEDIDOS(ID);

ALTER TABLE PEDIDO_TIPO_BORDA
ADD CONSTRAINT FK_PEDIDO_TIPO_BORDA_TIPO_BORDA_ID FOREIGN KEY(TIPO_BORDA_ID)
REFERENCES TIPOS_BORDA(ID);
-- -----------------------------------------------------
-- FIM CHAVES PEDIDO_TIPO_BORDA
-- -----------------------------------------------------

-- -----------------------------------------------------
-- FIM CRIAÇÃO DE CHAVES ESTRANGEIRAS
-- -----------------------------------------------------

-- -----------------------------------------------------
-- INICIO INSERÇÃO DAS PROCEDURES
-- -----------------------------------------------------

-- -----------------------------------------------------
-- procedure sp_avaliacoes_insert
-- -----------------------------------------------------

DELIMITER $$
USE `TudoAcabaEmPizzaDB`$$
CREATE PROCEDURE `sp_avaliacoes_insert` (
	-- parametros da procedure
	spnota decimal(3,2),
    spcomentario varchar(200),
    spcliente_id int,
    spprodutos_id int
)
BEGIN
	insert into avaliacoes values (0,spnota, spcomentario, default, spcliente_id, spprodutos_id);
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_avaliacoes_update
-- -----------------------------------------------------

DELIMITER $$
USE `TudoAcabaEmPizzaDB`$$
CREATE PROCEDURE `sp_avaliacoes_update` (
	spid int,
	spnota decimal(3,2),
    spcomentario varchar(200),
    spcliente_id int,
    spprodutos_id int
)
BEGIN
	update avaliacoes set nota = spnota, comentario = spcomentario where id = spid;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_pedido_insert
-- -----------------------------------------------------

DELIMITER $$
USE `TudoAcabaEmPizzaDB`$$
CREATE PROCEDURE `sp_pedido_insert` (
	spusuario_id int,
    spcliente_id int,
    spclasse_desconto_id int,
	spstatus_id int
)
BEGIN
	insert into pedidos values (0,default,spusuario_id,spcliente_id,spclasse_desconto_id,spstatus_id);
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_pedido_update
-- -----------------------------------------------------

DELIMITER $$
USE `TudoAcabaEmPizzaDB`$$
CREATE PROCEDURE `sp_pedido_update` (
	spid int,
    spstatus_id int,
    spclasse_desconto_id int
)
BEGIN
	update pedidos set status_id = spstatus_id, classe_desconto_id = spclasse_desconto_id where id = spid;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_pedido_cancelado
-- -----------------------------------------------------

DELIMITER $$
USE `TudoAcabaEmPizzaDB`$$
CREATE PROCEDURE `sp_pedido_cancelado` (
	spid int,
    spstatus_id int
)
BEGIN
	update pedidos set status_id = 1 where id = 1;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- drop procedure sp_itempedido_insert
-- -----------------------------------------------------

DELIMITER $$
USE `TudoAcabaEmPizzaDB`$$
CREATE PROCEDURE `sp_itempedido_insert` (
	spquantidade decimal(10,2),
    sppedido_id int,
    spprodutos_id int,
    sptamanho_pizza_id int
)
BEGIN
	insert into item_pedido values (0, (select valor_unit from produtos where id = spprodutos_id),spquantidade, sppedido_id, spprodutos_id,sptamanho_pizza_id);
END$$

DELIMITER ;

-- -----------------------------------------------------
-- drop procedure sp_itempedido_delete
-- -----------------------------------------------------

DELIMITER $$
USE `TudoAcabaEmPizzaDB`$$
CREATE PROCEDURE `sp_itempedido_delete` (
	spid int
)
BEGIN
	delete from item_pedido where id = spid;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_itempedido_update
-- -----------------------------------------------------

DELIMITER $$
USE `TudoAcabaEmPizzaDB`$$
CREATE PROCEDURE `sp_itempedido_update` (
	spid int,
    spquantidade decimal(10,2)
)
BEGIN
	update item_pedido set quantidade = spquantidade where id = spid;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_produto_insert
-- -----------------------------------------------------

DELIMITER $$
USE `TudoAcabaEmPizzaDB`$$
CREATE PROCEDURE `sp_produto_insert` (
	spnome varchar(45),
    spdescricao varchar(150),
    spvalor_unit decimal(10,2),
    spcod_barras varchar(60),
    splink_imagem varchar(200),
    spcategorias_id int
)
BEGIN
	insert into Produtos values (0,spnome,spdescricao,spvalor_unit,spcod_barras,splink_imagem,default,spcategorias_id,default);
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_produto_delete
-- -----------------------------------------------------

DELIMITER $$
USE `TudoAcabaEmPizzaDB`$$
CREATE PROCEDURE `sp_produto_delete` (
	spid int,
    spativo bit(1)
)
BEGIN
	update produtos set ativo = spativo where id = spid;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- drop procedure sp_produto_update
-- -----------------------------------------------------

DELIMITER $$
USE `TudoAcabaEmPizzaDB`$$
CREATE PROCEDURE `sp_produto_update` (
	spid int,
    spnome varchar(45),
    spdescricao varchar(150),
    spvalor_unit decimal(10,2),
    spcod_barras varchar(60),
    splink_imagem varchar(200),
    spcategorias_id int
)
BEGIN
	update produtos set nome = spnome,descricao = spdescricao, valor_unit = spvalor_unit, cod_barras = spcod_barras, link_imagem = splink_imagem, categoria_id = spcategorias_id where id = spid;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_usuario_insert
-- -----------------------------------------------------

DELIMITER $$
USE `TudoAcabaEmPizzaDB`$$
CREATE PROCEDURE `sp_usuario_insert` (
	spnome varchar(60),
    spemail varchar(60),
    spsenha varchar(20),
    spniveis_id int
)
BEGIN
	insert into usuarios values (0,spnome,spemail,aes_encrypt(spsenha,'NewTech@123'),default,spniveis_id);
END$$

DELIMITER ;

-- -----------------------------------------------------
-- drop procedure sp_usuario_update
-- -----------------------------------------------------

DELIMITER $$
USE `TudoAcabaEmPizzaDB`$$
CREATE PROCEDURE `sp_usuario_update` (
	spid int,
    spnome varchar(60),
    spsenha varchar(20),
    spniveis_id int
)
BEGIN
	update usuarios set nome = spnome, senha = aes_encrypt(spsenha,'NewTech@123'), nivel_id = spniveis_id where id = spid;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_usuario_delete
-- -----------------------------------------------------

DELIMITER $$
USE `TudoAcabaEmPizzaDB`$$
CREATE PROCEDURE `sp_usuario_delete` (
	spid int,
    spativo bit(1)
)
BEGIN
	update usuarios set ativo = spativo where id = spid;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_cliente_insert
-- -----------------------------------------------------

DELIMITER $$
USE `TudoAcabaEmPizzaDB`$$
CREATE PROCEDURE `sp_cliente_insert` (
    spnome varchar(200),
    spdata_nasc timestamp,
    spcpf char(11),
    spemail varchar(200),
    spsenha varchar(20)
)
BEGIN
	insert into clientes values (0, spnome, spdata_nasc, spcpf, spemail, aes_encrypt(spsenha,'NewTech@123'),default, default);
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_cliente_update
-- -----------------------------------------------------

DELIMITER $$
USE `TudoAcabaEmPizzaDB`$$
CREATE PROCEDURE `sp_cliente_update` (
	spid int,
    spnome varchar(200),
	spsenha varchar(20)
)
BEGIN
	update clientes set nome = spnome, senha = spsenha where id = spid;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_cliente_delete
-- -----------------------------------------------------

DELIMITER $$
USE `TudoAcabaEmPizzaDB`$$
CREATE PROCEDURE `sp_cliente_delete` (
	spid int,
    spativo bit(1)
)
BEGIN
	update clientes set ativo = spativo where id = spid;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- drop procedure sp_enderecos_insert
-- -----------------------------------------------------

DELIMITER $$
USE `TudoAcabaEmPizzaDB`$$
CREATE PROCEDURE `sp_enderecos_insert` (	
    -- parametros da procedure
   
    spcep char(8),
    spcliente_id int,
    sptipo_endereco_id int,
    splogradouro varchar(100),
    spnumero varchar(40),
    spcomplemento varchar(60),
    spbairro varchar(60),
    spcidade varchar(60),
    spuf char(2)
) 
BEGIN 
	insert enderecos values (0,spcep,default,spcliente_id,sp_tipoendereco_id,splogradouro,spnumero,spcomplemento,spbairro,spcidade,spuf);
	select * from enderecos where id = last_insert_id();
END$$

DELIMITER ;

-- -----------------------------------------------------
-- drop procedure sp_enderecos_update
-- -----------------------------------------------------

DELIMITER $$
USE `TudoAcabaEmPizzaDB`$$
CREATE PROCEDURE `sp_enderecos_update` (
	-- parametros da procedure
	spid int,
    spcliente_id int,
    sptipo_endereco_id int,
	spcep char(8),
    splogradouro varchar(100),
    spnumero varchar(40),
    spcomplemento varchar(60),
    spbairro varchar(60),
    spcidade varchar(60),
    spuf char(2)
)
BEGIN
	update enderecos set 
						id = spid,
                        cliente_id = spcliente_id,
                        tipo_endereco_id = sptipo_endereco_id,
						cep = spcep,
                        logradouro = splogradouro,
                        numero = spnumero,
                        complemento = spcomplemento,
                        bairro = spbairro,
                        cidade = spcidade,
                        uf = spuf    
    where id = spid;
    select * from enderecos where id = last_insert_id();
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_enderecos_delete
-- -----------------------------------------------------

DELIMITER $$
USE `TudoAcabaEmPizzaDB`$$
CREATE PROCEDURE `sp_enderecos_delete` (	
	-- parametros da procedure
	spid int,
    spativo bit(1)
)
BEGIN 
	update enderecos set ativo = spativo where spid = id;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- drop procedure sp_telefone_insert
-- -----------------------------------------------------

DELIMITER $$
USE `TudoAcabaEmPizzaDB`$$
CREATE PROCEDURE `sp_telefone_insert` (
	spddi varchar(3),
    spddd char(2),
    spnumero char(9),
    sptipo_telefone_id int,
    spcliente_id int
)
BEGIN
	insert into telefones values (0,spddi,spddd,spnumero,default,sptipo_telefone_id,spcliente_id);
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_telefone_update
-- -----------------------------------------------------

DELIMITER $$
USE `TudoAcabaEmPizzaDB`$$
CREATE PROCEDURE `sp_telefone_update` (
	spid int,
    spddi varchar(3),
    spddd char(2),
    spnumero char(9),
    sptipo_telefone_id int
)
BEGIN
	update telefones set ddi = spddi, ddd = spddd, numero = spnumero,tipo_telefone_id = sptipo_telefone_id where id = spid;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_telefone_delete
-- -----------------------------------------------------

DELIMITER $$
USE `TudoAcabaEmPizzaDB`$$
CREATE PROCEDURE `sp_telefone_delete` (
	spid int,
    spativo bit(1)
)
BEGIN
	update telefones set ativo = spativo where id = spid;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_tipotelefone_insert
-- -----------------------------------------------------

DELIMITER $$
USE `TudoAcabaEmPizzaDB`$$
CREATE PROCEDURE `sp_tipotelefone_insert` (
	spsigla char(3),
    spdescricao varchar(30)
)
BEGIN
	insert into tipos_telefone values (0, spsigla, spdescricao, default);
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_tipotelefone_update
-- -----------------------------------------------------

DELIMITER $$
USE `TudoAcabaEmPizzaDB`$$
CREATE PROCEDURE `sp_tipotelefone_update` (
	spid int,
    spsigla char(3),
    spdescricao varchar(30)
)
BEGIN
	update tipos_telefone set sigla = spsigla, descricao = spdescricao where id = spid;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_tipotelefone_delete
-- -----------------------------------------------------

DELIMITER $$
USE `TudoAcabaEmPizzaDB`$$
CREATE PROCEDURE `sp_tipotelefone_delete` (
	spid int,
    spativo bit(1)
)
BEGIN
	update tipos_telefone set ativo = spativo where id = spid;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_tipoendereco_insert
-- -----------------------------------------------------

DELIMITER $$
USE `TudoAcabaEmPizzaDB`$$
CREATE PROCEDURE `sp_tipoendereco_insert` (
    spsigla char(3),
    spdescricao varchar(30)
)
BEGIN
	insert into tipos_endereco values (0,spsigla,spdescricao,default);
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_tipoendereco_update
-- -----------------------------------------------------

DELIMITER $$
USE `TudoAcabaEmPizzaDB`$$
CREATE PROCEDURE `sp_tipoendereco_update` (
	spid int,
    spsigla char(3),
    spdescricao varchar(30)
)
BEGIN
	update tipos_endereco set id = spid, sigla = spsigla, descricao = spdescricao where id = spid;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_tipoendereco_delete
-- -----------------------------------------------------

DELIMITER $$
USE `TudoAcabaEmPizzaDB`$$
CREATE PROCEDURE `sp_tipoendereco_delete` (
	spid int,
    spativo bit(1)
)
BEGIN
	update tipos_endereco set ativo = spativo where id = spid;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_tipopagamento_insert
-- -----------------------------------------------------

DELIMITER $$
USE `TudoAcabaEmPizzaDB`$$
CREATE PROCEDURE `sp_tipopagamento_insert` (
	spsigla char(3),
    spdescricao varchar(30)
)
BEGIN
	insert into tipos_pagamento values (0,spsigla,spdescricao);
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_categoria_update
-- -----------------------------------------------------

DELIMITER $$
USE `TudoAcabaEmPizzaDB`$$
CREATE PROCEDURE `sp_categoria_update` (
	spid int,
    spnome varchar(40),
    spsigla char(3)
)
BEGIN
	update categorias set nome = spnome, sigla = spsigla where id = spid;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_categoria_insert
-- -----------------------------------------------------

DELIMITER $$
USE `TudoAcabaEmPizzaDB`$$
CREATE PROCEDURE `sp_categoria_insert` (
	spnome varchar(40),
    spsigla char(3)
)
BEGIN
	insert into categorias values (0,spnome,spsigla,default);
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_categoria_delete
-- -----------------------------------------------------

DELIMITER $$
USE `TudoAcabaEmPizzaDB`$$
CREATE PROCEDURE `sp_categoria_delete` (
	spid int,
    spativo bit(1)
)
BEGIN
	update categorias set ativo = spativo where id = spid;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_niveis_insert
-- -----------------------------------------------------

DELIMITER $$
USE `TudoAcabaEmPizzaDB`$$
CREATE PROCEDURE `sp_niveis_insert` (
	spnome varchar(45), 
    spsigla char(3)
)
BEGIN
	insert into niveis values (0,spnome,spsigla,default);
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_niveis_update
-- -----------------------------------------------------

DELIMITER $$
USE `TudoAcabaEmPizzaDB`$$
CREATE PROCEDURE `sp_niveis_update` (
	spid int,
    spnome varchar(45),
    spsigla char(3)
)
BEGIN
	update niveis set nome = spnome, sigla = spsigla where id = spid;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_niveis_delete
-- -----------------------------------------------------

DELIMITER $$
USE `TudoAcabaEmPizzaDB`$$
CREATE PROCEDURE `sp_niveis_delete` (
	spid int,
    spativo bit(1)
)
BEGIN
	update niveis set ativo = spativo where id = spid;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_status_insert
-- -----------------------------------------------------

DELIMITER $$
USE `TudoAcabaEmPizzaDB`$$
CREATE PROCEDURE `sp_status_insert` (
	spsigla char(3),
    spdescricao varchar(30)
)
BEGIN
	insert into `status` values (0,spsigla,spdescricao,default); 
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_status_delete
-- -----------------------------------------------------

DELIMITER $$
USE `TudoAcabaEmPizzaDB`$$
CREATE PROCEDURE `sp_status_delete` (
	spid int,
    spativo bit(1)
)
BEGIN
	update `status` set ativo = spativo where id = spid;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_status_update
-- -----------------------------------------------------

DELIMITER $$
USE `TudoAcabaEmPizzaDB`$$
CREATE PROCEDURE `sp_status_update` (
	spid int,
    spsigla char(3),
    spdescricao varchar(30)
)
BEGIN
	update `status` set sigla = spsigla, descricao = spdescricao where id = spid;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- drop procedure sp_pagamento_insert
-- -----------------------------------------------------

DELIMITER $$
USE `TudoAcabaEmPizzaDB`$$
CREATE PROCEDURE `sp_pagamento_insert` (
	sptipo_pagamento_id int,
    sppedido_id int,
    spparcelas tinyint(2)
)
BEGIN
	insert into pagamento values (0,sptipo_pagamento_id,sppedido_id,spparcelas);
END$$

DELIMITER ;

-- -----------------------------------------------------
-- drop procedure sp_pagamento_update
-- -----------------------------------------------------

DELIMITER $$
USE `TudoAcabaEmPizzaDB`$$
CREATE PROCEDURE `sp_pagamento_update` (
	spid int,
    sptipo_pagamento_id int,
    spparcelas tinyint(2)
)
BEGIN
	update pagamento set tipo_pagamento_id = sptipo_pagamento_id, parcelas = spparcelas where id = spid;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_caixa_insert
-- -----------------------------------------------------

DELIMITER $$
USE `TudoAcabaEmPizzaDB`$$
CREATE PROCEDURE `sp_caixa_insert` ()
BEGIN

END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_caixa_update
-- -----------------------------------------------------

DELIMITER $$
USE `TudoAcabaEmPizzaDB`$$
CREATE PROCEDURE `sp_caixa_update` ()
BEGIN

END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_tipoborda_insert
-- -----------------------------------------------------

DELIMITER $$
USE `TudoAcabaEmPizzaDB`$$
CREATE PROCEDURE `sp_tipoborda_insert` (
	spdescricao varchar(200),
    sppreco decimal(10,2)
)
BEGIN
	insert into tipos_borda values (0,spdescricao,sppreco,default);
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_tipoborda_update
-- -----------------------------------------------------

DELIMITER $$
USE `TudoAcabaEmPizzaDB`$$
CREATE PROCEDURE `sp_tipoborda_update` (
	spid int,
    spdescricao varchar(200),
    sppreco decimal(10,2)
)
BEGIN
	update tipos_borda set descricao = spdescricao, preco = sppreco where id = spid;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_tipoborda_delete
-- -----------------------------------------------------

DELIMITER $$
USE `TudoAcabaEmPizzaDB`$$
CREATE PROCEDURE `sp_tipoborda_delete` (
	spid int,
    spativo bit(1)
)
BEGIN
	update tipos_borda set ativo = spativo where id = spid;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- drop procedure sp_pedidoadicional_insert
-- -----------------------------------------------------

DELIMITER $$
USE `TudoAcabaEmPizzaDB`$$
CREATE PROCEDURE `sp_pedidoadicional_insert` (
	sppedido_id int,
    spadicionais_id int
)
BEGIN
	insert into pedido_adicional values(0,sppedido_id,spadicionais_id);
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_pedidoadicional_delete
-- -----------------------------------------------------

DELIMITER $$
USE `TudoAcabaEmPizzaDB`$$
CREATE PROCEDURE `sp_pedidoadicional_delete` (
	spid int
)
BEGIN
	delete from pedido_adicional where id = spid;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_adicionais_delete
-- -----------------------------------------------------

DELIMITER $$
USE `TudoAcabaEmPizzaDB`$$
CREATE PROCEDURE `sp_adicionais_delete` (
	spid int,
    spativo bit(1)
)
BEGIN
	update adicionais set ativo = spativo where id = spid;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_adicionais_update
-- -----------------------------------------------------

DELIMITER $$
USE `TudoAcabaEmPizzaDB`$$
CREATE PROCEDURE `sp_adicionais_update` (
	spid int,
    spdescricao varchar(100),
    sppreco decimal(10,2)
)
BEGIN
	update adicionais set descricao = spdescricao, preco = sppreco where id = spid;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_adicionais_insert
-- -----------------------------------------------------

DELIMITER $$
USE `TudoAcabaEmPizzaDB`$$
CREATE PROCEDURE `sp_adicionais_insert` (
    spdescricao varchar(100),
    sppreco decimal(10,2)
)
BEGIN
	insert into adicionais values(0,spdescricao,sppreco,default);
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_classedesconto_update
-- -----------------------------------------------------

DELIMITER $$
USE `TudoAcabaEmPizzaDB`$$
CREATE PROCEDURE `sp_classedesconto_update` (
	spid int,
    spnome varchar(45),
    spdesconto decimal(10,2)
)
BEGIN
	update Classes_Desconto set nome = spnome, desconto = spdesconto where id = spid;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- drop procedure sp_classedesconto_insert
-- -----------------------------------------------------

DELIMITER $$
USE `TudoAcabaEmPizzaDB`$$
CREATE PROCEDURE `sp_classedesconto_insert` (
    spnome varchar(45),
    spdesconto decimal(10,2)
)
BEGIN
	insert into classes_desconto values (0,spnome,spdesconto);
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_classedesconto_delete
-- -----------------------------------------------------

DELIMITER $$
USE `TudoAcabaEmPizzaDB`$$
CREATE PROCEDURE `sp_classedesconto_delete` (
	spid int,
    spativo bit(1)
)
BEGIN
	update Classes_desconto set ativo = spativo where id = spid;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_pedidotipoborda_delete
-- -----------------------------------------------------

DELIMITER $$
USE `TudoAcabaEmPizzaDB`$$
CREATE PROCEDURE `sp_pedidotipoborda_delete` (
	spid int
)
BEGIN
	delete from pedido_tipo_borda where id = spid;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- drop procedure sp_pedidotipoborda_insert
-- -----------------------------------------------------

DELIMITER $$
USE `TudoAcabaEmPizzaDB`$$
CREATE PROCEDURE `sp_pedidotipoborda_insert` (
	sppedido_id int,
    sptipoborda_id int
)
BEGIN
	insert into pedido_tipo_borda values (0,sppedido_id,sptipoborda_id);
END$$

DELIMITER ;

-- -----------------------------------------------------
-- drop procedure sp_tamanhopizza_insert
-- -----------------------------------------------------

DELIMITER $$
USE `TudoAcabaEmPizzaDB`$$
CREATE PROCEDURE `sp_tamanhopizza_insert` (
	spsigla varchar(3),
    spdescricao varchar(60)
)
BEGIN
	insert into tamanhos_pizza values (0,spsigla,spdescricao,default);
END$$

DELIMITER ;

-- -----------------------------------------------------
-- drop procedure sp_tamanhopizza_update
-- -----------------------------------------------------

DELIMITER $$
USE `TudoAcabaEmPizzaDB`$$
CREATE PROCEDURE `sp_tamanhopizza_update` (
	spid int,
    spsigla varchar(3),
    spdescricao varchar(60)
)
BEGIN
	update tamanhos_pizza set sigla = spsigla, descricao = spdescricao where id = spid;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_tamanhopizza_delete
-- -----------------------------------------------------

DELIMITER $$
USE `TudoAcabaEmPizzaDB`$$
CREATE PROCEDURE `sp_tamanhopizza_delete` (
	spid int,
    spativo bit(1)
)
BEGIN
	update tamanhos_pizza set ativo = spativo where id = spid;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_pagamentopedido_insert
-- -----------------------------------------------------

DELIMITER $$
USE `TudoAcabaEmPizzaDB`$$
CREATE PROCEDURE `sp_pagamentopedido_insert` (
	sppagamento_id int,
    sppedido_id int,
    spstatus_id int
)
BEGIN
	insert into pagamento_pedido values(0,sppagamento_id,sppedido_id,spstatus_id,default);
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_pagamentopedido_update
-- -----------------------------------------------------

DELIMITER $$
USE `TudoAcabaEmPizzaDB`$$
CREATE PROCEDURE `sp_pagamentopedido_update` (
    spid int,
    spstatus_id int
)
BEGIN
	update pagamento_pedido set status_id = spstatus_id where id = spid;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- FIM INSERÇÃO PROCEDURES
-- -----------------------------------------------------
-- FIM BANCO 
-- -----------------------------------------------------