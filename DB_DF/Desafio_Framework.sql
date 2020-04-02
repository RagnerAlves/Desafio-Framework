SELECT * FROM desafio_framework.paciente;

SELECT * FROM desafio_framework.cidade;

 

SELECT * FROM desafio_framework.pais;

INSERT INTO `paciente` (`id`, `nome`, `CPF`, `Pais`, `Estado`, `Cidade`) VALUES
(1, 'Ragner', '80545229677', 'Brasil', 'Minas Gerais', 'Belo Horizonte'),
(2, 'Lucas', '41847494617','Brasil', 'Alagoas', 'Maceió'),
(3, 'Marcela','48498459087', 'Brasil', 'São Paulo', 'Barueri'),
(4, 'Gustavo' ,'16842520088', 'Brasil', 'Rondonia', 'Porto Velho'),
(5, 'Leticia','18727961095', 'Brasil', 'Bahia', 'Salvador'),
(6, 'Joyce','01099870046', 'Brasil', 'Minas Gerais', 'Contagem'),
(7, 'Felipe','30879264004', 'Brasil', 'Rio de Janeiro', 'Cabo Frio');


INSERT INTO `pais` (`id`, `descricao`) VALUES
(1, 'Brazil'),
(107, 'Italy'),
(109, 'Japan'),
(140, 'Mexico'),
(155, 'New Zealand'),
(173, 'Portugal'),
(225, 'United States');


INSERT INTO `estado` (`id`,  `descricao`, `pais`) VALUES
(1, 'Acre', 'Brasil'),
(2, 'Alagoas', 'Brasil'),
(3, 'Amazonas', 'Brasil'),
(11, 'Minas Gerais', 'Brasil'),
(26, 'Sao Paulo', 'Brasil');

INSERT INTO `cidade` (`id`,  `descricao`, `estado`) VALUES
(1, 'Belo Horizonte', 'Minas Gerais'),
(2, 'São Paulo' , 'São Paulo'),
(3, 'Bahia' , 'Salvador');
