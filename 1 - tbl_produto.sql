------------------------tabela Tipo Produto----------------------------------

create table tbl_tipo_produto (
id_tipo_produto smallint primary key identity,
nome_tipo_produto varchar (20) not null);

insert into tbl_tipo_produto(nome_tipo_produto)
values
('Prato'),
('Bebida'),
('Sobremesa'),
('Porções'),
('KIT');

select*from tbl_tipo_produto;

drop table tbl_tipo_produto

------------------------tabela Produto----------------------------------

select*from tbl_produto

drop table tbl_produto

create table tbl_produto(
id_produto smallint primary key identity(100,1),
nome_produto varchar (50) not null,
id_tipo_produto smallint not null,
preco_produto money not null
constraint fk_id_tipo_produto foreign key (id_tipo_produto) references tbl_tipo_produto (id_tipo_produto)
);

--insert pratos
insert into tbl_produto(nome_produto , id_tipo_produto , preco_produto)
values 
('Panqueca de Carne' , 1 , 22.00),
('Panqueca de Frango com Queijo' , 1 , 22.00),
('Panqueca de Brócolis' , 1 , 22.00),
('Parmediana de Carne' , 1 , 33.00),
('Parmediana de Frango' , 1 , 25.00),
('Contra Filé' , 1 , 29.00),
('Costelinha Suína' , 1 , 29.00),
('Filé de Frango Grelhado' , 1 , 19.00),
('Filé Mignon' , 1 , 33.00),
('Cupim Assado' , 1 , 27.00),
('Filé de Merluza Empanado' , 1 , 23.00),
('Salmão Grelhado' , 1 , 37.00),
('Omelete Brócolis c/ Requeijão' , 1 , 19.00),
('Omelete Frango c/ Requeijão' , 1 , 19.00),
('Feijoada Individual' , 1 , 25.00),
('Feijoada 2 Pessoas' , 1 , 45.00),
('Feijoada 3 Pessoas' , 1 , 70.00),
('Salada Mista Completa' , 1 , 10.00),
('Salada Mista Com Frango' , 1 , '15.00'),
('Salada Proteica' , 1 ,'19.00'),
('Acréscimo', 1 , 2.00),
('Embalagem' ,1 , 1.00);

--insert bebibdas
insert into tbl_produto(nome_produto , id_tipo_produto , preco_produto)
values 
('Skol Cerveja' , 2 , 9.00),
('BudWeiser Cerveja' , 2 , 13.00),
('Stella Cerveja' , 2 , 13.00),
('Estrela Galicia Cerveja' , 2 , 9.00),
('Original Cerveja' , 2 , 13.00),
('Itapipava Cerveja' , 2 , 5.00),
('Heineken Cerveja' , 2 , 13.00),
('Eisenbahn Cereveja' , 2 , 13.00),
('Cerveja' , 2 , 9.00),
('Cerveja' , 2 , 13.00),
('Suco' , 2 , 10.00),
('Água' , 2 , 3.50),
('Água com Gás' , 2 , 4.50),
('Caipirinha' , 2 , 12.00),
('Caipirosca' , 2 , 16.00),
('Coca-Cola 2L' , 2 , 12.00),
('Fanta 2L' , 2 , 12.00),
('Coca-Cola 1L' , 2 , 8.00),
('Coca_cola 600ml' , 2 , 8.00),
('H2oh' , 2 , 6.00),
('Refrigerante Lata' , 2 , 5.00),
('Guaraná Antartica 600ml' , 2 , 8.00),
('Vinho Seco/Tinto Dose' , 2 , 15.00);

--insert sobremesa
insert into tbl_produto(nome_produto , id_tipo_produto , preco_produto)
values 
('Banana Caramelizada com Sorvete e Farofa Crocante' , 3 , 15.00 ),
('Pudim' , 3 , 7.00),
('Sorvete' , 3 , 8.00);

--insert porçoes
insert into tbl_produto(nome_produto , id_tipo_produto , preco_produto)
values 
('Batata Frita' , 4 , 15.00),
('Isca de Frango' , 4 , 19.00),
('Linguiça Toscana' , 4 , 19.00),
('Linguiça Calabresa' , 4 , 19.00),
('Contra Filé' , 4 , 25.00),
('Mista' , 4 , 29.00);

--insert kit 
insert into tbl_produto(nome_produto , id_tipo_produto , preco_produto)
values 
('KIT FIT Almoço' , 5 , 124.90),
('KIT FIT Janta' , 5 ,124.90),
('KIT SOPA' , 5 , 56.90),
('KIT LOW CARB' , 5 , 66.00);

select*from tbl_produto;

-------------------------------------------------------------------------------

