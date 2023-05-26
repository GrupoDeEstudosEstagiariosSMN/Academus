-- tabela usuario
CREATE TABLE usuario (
	id INT GENERATED ALWAYS AS IDENTITY,
	nome VARCHAR(64) NOT NULL,
	email VARCHAR(128) NOT NULL,
	senha VARCHAR(64) NOT NULL,
	CONSTRAINT pk_usuario PRIMARY KEY (id),
	CONSTRAINT uq_usuario_email UNIQUE (email)
);

CREATE TABLE organizador (
	id INT GENERATED ALWAYS AS IDENTITY,
	nome VARCHAR(60) NOT NULL,
	cpf INT NOT NULL,
	telefone INT NOT NULL,
	CONSTRAINT organizador PRIMARY KEY (id)
)

CREATE TABLE evento_organizador (
	id_evento INT NOT NULL,
	id_organizador INT NOT NULL,
	CONSTRAINT fk_evento_organizador_evento FOREIGN KEY(id_evento)
			REFERENCES evento(id),
	CONSTRAINT fk_evento_organizador_organizador FOREIGN KEY(id_organizador)
			REFERENCES organizador(id)
)

CREATE TABLE evento (
	id INT GENERATED ALWAYS AS IDENTITY,
	nome VARCHAR(64) NOT NULL,
	descricao VARCHAR(600) NOT NULL,
	localizacao VARCHAR(100) NOT NULL,
	publico_alvo VARCHAR(60) NOT NULL,
	valor_ingresso DECIMAL(6,2) NOT NULL,
	custo DECIMAL(7,2) NOT NULL,
	CONSTRAINT pk_evento PRIMARY KEY (id)	 
)	

CREATE TABLE evento_palestra(
	id_evento INT,
	id_palestra INT, 
	CONSTRAINT fk_evento_palestra_evento FOREIGN KEY(id_evento)
				REFERENCES evento(id),
	CONSTRAINT fk_evento_palestra_palestra FOREIGN KEY(id_palestra)
				REFERENCES palestra(id)
)

CREATE TABLE palestra (
	id INT GENERATED ALWAYS AS IDENTITY,
	id_categoria INT NOT NULL,
	nome VARCHAR(100) NOT NULL,
	horas VARCHAR(100) NOT NULL,
	CONSTRAINT pk_palestra PRIMARY KEY (id),
	CONSTRAINT fk_palestra_evento_palestra FOREIGN KEY(id_categoria)
			REFERENCES categoria(id)
)

CREATE TABLE categoria(
	id INT GENERATED ALWAYS AS IDENTITY,
	nome VARCHAR(100) NOT NULL,
	CONSTRAINT pk_categoria PRIMARY KEY(id)
)

CREATE TABLE palestra_palestrante(
	id_palestra INT ,
	id_palestrante INT ,
	CONSTRAINT fk_palestra_palestrante_palestra FOREIGN KEY(id_palestra)
			REFERENCES palestra(id),
	CONSTRAINT fk_palestra_palestrante_palestrante FOREIGN KEY(id_palestrante)
			REFERENCES palestrante(id)		
)

CREATE TABLE palestrante (
	id INT GENERATED ALWAYS AS IDENTITY,
	nome VARCHAR(64) NOT NULL,
	valor_hora DECIMAL(5,2) NOT NULL,
	CONSTRAINT pk_palestrante PRIMARY KEY (id)
)
