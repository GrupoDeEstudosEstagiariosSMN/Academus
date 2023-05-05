-- tabela usuario
CREATE TABLE usuario (
	id int generated always as identity,
	nome varchar(64) NOT NULL,
	email varchar(128) NOT NULL,
	senha varchar(64) NOT NULL,
	CONSTRAINT pk_usuario PRIMARY KEY (id),
	CONSTRAINT uq_usuario_email UNIQUE (email)
);

CREATE TABLE usuario (
    id int identity(1,1),
    nome varchar(64) NOT NULL,
    email varchar(128) NOT NULL,
    senha varchar(64) NOT NULL,
    CONSTRAINT pk_usuario PRIMARY KEY CLUSTERED (id),
	CONSTRAINT uq_usuario_email UNIQUE (email)
);
