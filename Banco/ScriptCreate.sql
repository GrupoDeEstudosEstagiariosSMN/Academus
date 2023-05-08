-- tabela usuario
CREATE TABLE usuario (
	id int generated always as identity,
	nome varchar(64) NOT NULL,
	email varchar(128) NOT NULL,
	senha varchar(64) NOT NULL,
	CONSTRAINT pk_usuario PRIMARY KEY (id),
	CONSTRAINT uq_usuario_email UNIQUE (email)
);

CREATE TABLE curso (
	id int generated always as identity,
	nome varchar(100) NOT NULL,
	carga_horaria varchar(20) NOT NULL,
	professor varchar(100) NOT NULL,
	trilha varchar(100) NOT NULL,
	CONSTRAINT pk_curso PRIMARY KEY (id)
);
