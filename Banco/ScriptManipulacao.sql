DROP TABLE dbo.evento;
DROP TABLE dbo.palestrante;

CREATE TABLE dbo.evento (
	id int generated always as identity,
	id_palestrante INT NOT NULL,
	nome varchar(64) NOT NULL,
	descricao varchar(600) NOT NULL,
	localizacao varchar(100) NOT NULL,
	publico_alvo varchar(60) NOT NULL,
	valor_ingresso DECIMAL(6,2) NOT NULL,
	custo DECIMAL(7,2) NOT NULL,
	CONSTRAINT pk_evento PRIMARY KEY (id),
	CONSTRAINT fk_palestrante FOREIGN KEY(id_palestrante)
			REFERENCES palestrante(id)		 
)

CREATE TABLE dbo.palestrante (
	id int generated always as identity,
	nomeCompleto varchar(120) NOT NULL,
	especialidade varchar(100) NOT NULL,
	valorMinimo DECIMAL(6,2) NOT NULL,
	CONSTRAINT pk_palestrante PRIMARY KEY (id)
)
