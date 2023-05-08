-- tabela usuario
CREATE TABLE usuario (
	id int generated always as identity,
	nome varchar(64) NOT NULL,
	email varchar(128) NOT NULL,
	senha varchar(64) NOT NULL,
	CONSTRAINT pk_usuario PRIMARY KEY (id),
	CONSTRAINT uq_usuario_email UNIQUE (email)
);

CREATE TABLE turma (
	id int generated always as identity,
	nome varchar(64) NOT NULL,
	quantidade_alunos int NOT NULL,
	sala varchar(64) NOT NULL,
	turno varchar(64) NOT NULL,
	CONSTRAINT pk_turma PRIMARY KEY (id)
);