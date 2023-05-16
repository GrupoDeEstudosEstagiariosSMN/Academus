
--palestrante
INSERT INTO palestrante (nome, especialidade)
                VALUES ('Thomaz Falbo', 'Inteligência Artificial'),
                       ('Lucas Alves', 'Marketing Digital')
                       ('Andreza Abrantes', 'Desenvolvimento Web'),
                       ('Andressa Abrantes', 'Gestão de Projetos'),
                       ('Gustavo Barbosa', 'Data Science'),
                       ('Gabriel Gouveia','Macacos')

-- evento
INSERT INTO evento (id_palestrante, nome, descricao, localizacao, publico_alvo, valor_ingresso, custo)
                VALUES (1, 'Conferência de Tecnologia', 'A maior conferência de tecnologia do ano, com palestras e workshops sobre inteligência artificial, blockchain e realidade virtual.', 'Centro de Convenções XYZ', 'Profissionais de TI e entusiastas de tecnologia', 50.00, 5000.00),
                       (2, 'Workshop de Marketing Digital', 'Aprenda as melhores estratégias de marketing digital para impulsionar seu negócio. Palestras práticas e estudos de caso.', 'Espaço de Eventos ABC', 'Empreendedores, profissionais de marketing', 30.00, 1500.00),
                       (1, 'Workshop de Marketing Digital', 'Aprenda as melhores estratégias de marketing digital para impulsionar seu negócio. Palestras práticas e estudos de caso.', 'Espaço de Eventos ABC', 'Empreendedores, profissionais de marketing', 30.00, 1500.00),
                       (1, 'Seminário de Liderança', 'Descubra as habilidades essenciais para se tornar um líder eficaz. Palestras inspiradoras e atividades de desenvolvimento pessoal.', 'Hotel DEF', 'Gestores,  líderes de equipe', 20.00, 800.00),

                       (5, 'Seminário de Liderança', 'Descubra as habilidades essenciais para se tornar um líder eficaz. Palestras inspiradoras e atividades de desenvolvimento pessoal.', 'Hotel DEF', 'Gestores,  líderes de equipe', 20.00, 800.00),
                       (4, 'Encontro de Empreendedores', 'Um evento dedicado ao networking e compartilhamento de experiências entre empreendedores de diversos setores.', 'Espaço de Coworking GHI', 'Empreendedores, startups', 10.00, 400.00),
                       (2, 'Encontro de Empreendedores', 'Um evento dedicado ao networking e compartilhamento de experiências entre empreendedores de diversos setores.', 'Espaço de Coworking GHI', 'Empreendedores, startups', 10.00, 400.00),
                       (5, 'Fórum de Inovação', 'Uma oportunidade para discutir as últimas tendências e práticas inovadoras no mundo dos negócios. Palestrantes renomados e painéis de debate.', 'Centro de Convenções JKL', 'Profissionais de inovação, pesquisadores', 25.00, 2500.00)
