-- tabela usuario
CREATE TABLE usuario (
	id INT GENERATED ALWAYS AS IDENTITY,
	nome VARCHAR(64) NOT NULL,
	email VARCHAR(128) NOT NULL,
	senha VARCHAR(64) NOT NULL,
	CONSTRAINT pk_usuario PRIMARY KEY (id),
	CONSTRAINT uq_usuario_email UNIQUE (email)
);

--tabela evento
CREATE TABLE evento (
	id INT GENERATED ALWAYS AS IDENTITY,
	id_organizador INT NOT NULL,
	nome VARCHAR(64) NOT NULL,
	descricao VARCHAR(600) NOT NULL,
	localizacao VARCHAR(100) NOT NULL,
	publico_alvo VARCHAR(60) NOT NULL,
	valor_ingresso DECIMAL(6,2) NOT NULL,
	custo DECIMAL(7,2) NOT NULL,
	CONSTRAINT pk_evento PRIMARY KEY (id),
	CONSTRAINT fk_organizador FOREIGN KEY(id_organizador)
			REFERENCES organizador(id)		 
)			

CREATE TABLE evento_palestra (
	id_evento INT NOT NULL,
	id_palestra INT NOT NULL,
	CONSTRAINT fk_palestra FOREIGN KEY(id_palestra),
			REFERENCES palestrante(id)
	CONSTRAINT fk_evento FOREIGN KEY(id_evento),
			REFERENCES evento(id)
)

CREATE TABLE palestra (
	id INT GENERATED ALWAYS AS IDENTITY,
	id_palestrante INT NOT NULL,
	id_area_atuacao INT NOT NULL,
	nome VARCHAR(100) NOT NULL,
	horas VARCHAR(100) NOT NULL,
	CONSTRAINT pk_palestra PRIMARY KEY (id),
	CONSTRAINT fk_palestrante FOREIGN KEY(id_palestrante)
			REFERENCES palestrante(id),
	CONSTRAINT fk_area_atuacao FOREIGN KEY(id_area_atuacao)
			REFERENCES area_atuacao(id) 		
)

CREATE TABLE palestrante (
	id INT GENERATED ALWAYS AS IDENTITY,
	nome VARCHAR(64) NOT NULL,
	valor_hora DECIMAL(5,2) NOT NULL,
	CONSTRAINT pk_palestrante PRIMARY KEY (id)
)

CREATE TABLE area_atuacao (
	id INT GENERATED ALWAYS AS IDENTITY,
	titulo VARCHAR(64) NOT NULL,
	CONSTRAINT area_atuacao PRIMARY KEY (id)
)

CREATE TABLE organizador (
	id INT GENERATED ALWAYS AS IDENTITY,
	nome VARCHAR(60) NOT NULL,
	cpf INT NOT NULL,
	telefone INT NOT NULL,
	CONSTRAINT organizador PRIMARY KEY (id)
)
