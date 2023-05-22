set search_path to dbo;

DROP TABLE dbo.evento;
DROP TABLE dbo.palestrante;

SELECT * FROM dbo.evento;
SELECT * FROM dbo.palestrante;

CREATE TABLE palestrante (
	id INT GENERATED ALWAYS AS IDENTITY,
	nome VARCHAR(64) NOT NULL,
	valor_hora DECIMAL(5,2) NOT NULL,
	CONSTRAINT pk_palestrante PRIMARY KEY (id)
)

INSERT INTO palestrante (nome, valor_hora) VALUES ('John Doe', 50.00),
												  ('Jane Smith', 20.00),
												  ('Robert Johnson', 100.00);

CREATE TABLE area_atuacao (
	id INT GENERATED ALWAYS AS IDENTITY,
	titulo VARCHAR(64) NOT NULL,
	CONSTRAINT area_atuacao PRIMARY KEY (id)
)

INSERT INTO area_atuacao (titulo) VALUES ('Tecnologia da Informação'),
                                        ('Marketing Digital'),
                                        ('Gestão de Projetos');

CREATE TABLE organizador (
	id INT GENERATED ALWAYS AS IDENTITY,
	nome VARCHAR(60) NOT NULL,
	cpf INT NOT NULL,
	telefone INT NOT NULL,
	CONSTRAINT organizador PRIMARY KEY (id)
)

INSERT INTO organizador (nome, cpf, telefone) VALUES ('João Silva', 12345678901, 996765975),
													 ('Maria Oliveira', 98765432109, 940028922),
													 ('Pedro Santos', 45678912304, 932312375);

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

INSERT INTO palestra (id_palestrante, id_area_atuacao, nome, horas)
						VALUES (1, 1, 'Introdução à Programação', '2 horas'),
							   (2, 2, 'Estratégias de Marketing Digital', '1.5 horas'),
							   (3, 3, 'Gestão Ágil de Projetos', '3 horas');

-- PEGAR O VALOR DE HORAS E MULTIPLICAR POR VALOR_HORA, SE HORAS ESTIVER EM STRING COMO FAZER ISSO?							 

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

INSERT INTO evento (id_organizador, nome, descricao, localizacao, publico_alvo, valor_ingresso, custo)
					VALUES (1, 'Conferência de Tecnologia', 'Uma conferência sobre as últimas tendências tecnológicas.', 'Centro de Convenções', 'Profissionais de TI', 50.00, 10000.00),
						   (2, 'Workshop de Marketing Digital', 'Um workshop prático sobre estratégias de marketing digital.', 'Sala de Treinamento A', 'Empreendedores e profissionais de marketing', 30.00, 5000.00),
						   (3, 'Seminário de Gestão de Projetos', 'Um seminário para discutir as melhores práticas em gestão de projetos.', 'Auditório Principal', 'Gestores de projetos e profissionais interessados', 20.00, 8000.00);




