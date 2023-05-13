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
