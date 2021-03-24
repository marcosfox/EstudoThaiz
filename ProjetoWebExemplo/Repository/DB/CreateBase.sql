DROP TABLE tbAluno
CREATE TABLE tbAluno
(
	id int primary key identity(1,1),
	nome varchar(200),
	telefone varchar(200),
	CPF varchar(11),
	email varchar(200)
 )