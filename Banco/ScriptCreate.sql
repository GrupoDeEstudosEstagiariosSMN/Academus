-- tabela usuario
CREATE TABLE usuario (
	id int generated always as identity,
	nome varchar(64) NOT NULL,
	email varchar(128) NOT NULL,
	senha varchar(64) NOT NULL,
	CONSTRAINT pk_usuario PRIMARY KEY (id),
	CONSTRAINT uq_usuario_email UNIQUE (email)
);
-- tabela evento
CREATE TABLE evento (
	id int generated always as identity,
	id_palestrante INT NOT NULL,
	nome varchar(64) NOT NULL,
	descricao varchar(600) NOT NULL,
	localizacao varchar(100) NOT NULL,
	publico_alvo varchar(60) NOT NULL,
	valor_ingresso DECIMAL(5,2) NOT NULL,
	custo DECIMAL(7,2) NOT NULL,
	CONSTRAINT pk_evento PRIMARY KEY (id),
	CONSTRAINT fk_palestrante FOREIGN KEY(id_palestrante)
			REFERENCES palestrante(id)		 
)
-- tabela evento
CREATE TABLE palestrante (
	id int generated always as identity,
	nome varchar(64) NOT NULL,
	especialidade varchar(64) NOT NULL,
	CONSTRAINT pk_palestrante PRIMARY KEY (id)
)
