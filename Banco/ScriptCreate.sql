-- tabela usuario
-- CREATE TABLE usuario (
-- 	id int generated always as identity,
-- 	nome varchar(64) NOT NULL,
-- 	email varchar(128) NOT NULL,
-- 	senha varchar(64) NOT NULL,
-- 	CONSTRAINT pk_usuario PRIMARY KEY (id),
-- 	CONSTRAINT uq_usuario_email UNIQUE (email)
-- );


--tabela categoria_curso
CREATE TABLE categoria_curso (
	id smallint generated always as identity,
	nome varchar(100) NOT NULL,	
	CONSTRAINT pk_categoria_curso PRIMARY KEY (id)
);

-- tabela curso
CREATE TABLE curso (
	id smallint generated always as identity,
	id_categoria_curso smallint NOT NULL,
	nome varchar(100) NOT NULL,
	carga_horaria varchar(20) NOT NULL,
	descricao varchar(100) NOT NULL,
	CONSTRAINT pk_curso PRIMARY KEY (id),
	CONSTRAINT fk_categoria_curso FOREIGN KEY (id_categoria_curso) 
	REFERENCES categoria_curso(id)
);

-- tabela trilha
CREATE TABLE trilha (
	id smallint generated always as identity,
	nome varchar(100) NOT NULL,
	descricao varchar(200) NOT NULL,
	CONSTRAINT pk_trilha PRIMARY KEY (id)
);

-- tabela instrutor
CREATE TABLE instrutor (
	id smallint generated always as identity,
	nome varchar(100) NOT NULL,
	especialidade varchar(100),
	area varchar(100) NOT NULL,
	CONSTRAINT pk_instrutor PRIMARY KEY (id)
);

-- tabela aluno
CREATE TABLE aluno (
	id int generated always as identity,
	id_trilha smallint NOT NULL,
	nome varchar(100) NOT NULL,
	apelido varchar(50),
	matricula int NOT NULL,
	cpf bigint NOT NULL,
	celular bigint NOT NULL,
	email varchar(200) NOT NULL,
	CONSTRAINT pk_aluno PRIMARY KEY (id),
	CONSTRAINT fk_trilha FOREIGN KEY(id_trilha) 
	REFERENCES trilha(id)
);

-- tabela curso_trilha
CREATE TABLE trilha_curso (
	id_curso smallint,
	id_trilha smallint,
	CONSTRAINT pk_trilha_curso PRIMARY KEY (id_trilha, id_curso),
	CONSTRAINT fk_curso_trilha_curso FOREIGN KEY(id_curso) 
	REFERENCES curso(id),
	CONSTRAINT fk_curso_trilha_trilha FOREIGN KEY(id_trilha) 
	REFERENCES trilha(id)
);

-- tabela curso_instrutor
CREATE TABLE curso_instrutor (
	id_curso smallint,
	id_instrutor smallint,
	CONSTRAINT pk_curso_instrutor PRIMARY KEY (id_curso, id_instrutor),
	CONSTRAINT fk_curso_trilha_curso FOREIGN KEY(id_curso) 
	REFERENCES curso(id),
	CONSTRAINT fk_curso_trilha_trilha FOREIGN KEY(id_trilha) 
	REFERENCES trilha(id)
);
