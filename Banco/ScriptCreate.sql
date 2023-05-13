-- tabela usuario
CREATE TABLE usuario (
	id int generated always as identity,
	nome varchar(64) NOT NULL,
	email varchar(128) NOT NULL,
	senha varchar(64) NOT NULL,
	CONSTRAINT pk_usuario PRIMARY KEY (id),
	CONSTRAINT uq_usuario_email UNIQUE (email)
);

CREATE TABLE aluno (
	id int generated always as identity,
	nome varchar(64) NOT NULL,
	turma varchar(64) NOT NULL,
	email varchar(128) NOT NULL,
	matricula varchar(64) NOT NULL,
	CONSTRAINT pk_aluno PRIMARY KEY (id),
	CONSTRAINT uq_aluno_email UNIQUE (email)
);

CREATE TABLE projeto (
	id int generated always as identity,
	titulo varchar(128) NOT NULL,
	descricao varchar(512) NOT NULL,
	autor varchar(128) NOT NULL,
	disciplina varchar(64) NOT NULL,
	prazo_inicial timestamp NOT NULL,
	prazo_final timestamp NOT NULL,
	nota decimal(4,2) NOT NULL,
	CONSTRAINT pk_projeto PRIMARY KEY (id),
	CONSTRAINT uq_projeto_titulo UNIQUE (titulo)
);
