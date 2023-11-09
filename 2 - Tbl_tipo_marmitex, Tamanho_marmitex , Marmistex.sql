drop table tbl_tamanho_marmitex;

create table tbl_tamanho_marmitex
(
id_tamanho_marmitex smallint primary key identity,
tamanho_marmitex varchar (2) not null,
preco_tamanho_marmitex money not null
);

select*from tbl_tamanho_marmitex;

insert into tbl_tamanho_marmitex(tamanho_marmitex , preco_tamanho_marmitex)
values
('P' , '12.50'),--pequena premium
('M' , '15.00'),--media premium
('G' , '17.00'),--grande premium
('U' , '8.90');--unico promocional

insert into tbl_tamanho_marmitex(tamanho_marmitex , preco_tamanho_marmitex)
values
('L' , '15.00');--marmita light

insert into tbl_tamanho_marmitex(tamanho_marmitex , preco_tamanho_marmitex)
values
('FP' , '15.00'),--feijodaP
('FG' , '19.00'),--feijoadaG
('V' , '16.00'),--Virado
('PS' , '7.90'),--Salada Pote
('SP' , '19.00');--salada Proteica

drop table tbl_tamanho_marmitex;
 
delete from tbl_tamanho_marmitex;

select*from tbl_tamanho_marmitex;

-----------------------------------------------------------------------------------------------------------------
drop
delete from tbl_tipo_marmitex;
where id_tipo_marmitex = 6;

create table tbl_tipo_marmitex(
id_tipo_marmitex smallint primary key identity,
nome_tipo_marmitex varchar(12) not null
);

insert into tbl_tipo_marmitex(nome_tipo_marmitex)
values
('Promocional'),
('Premium'),
('Light');

insert into tbl_tipo_marmitex(nome_tipo_marmitex)
values
('Salada');

insert into tbl_tipo_marmitex(nome_tipo_marmitex)
values
('Especial');--VIRADO E FEIJOADA

select*from tbl_tipo_marmitex;

-----------------------------------------------------------------------------------------------------------------
DROP table tbl_marmitex;

delete from tbl_marmitex;

create table tbl_marmitex(
id_marmitex smallint primary key identity,
nome_marmitex varchar (50) not null,
id_tipo_marmitex smallint not null,
id_tamanho_marmitex smallint not null
constraint fk_id_tipo_marmitex foreign key (id_tipo_marmitex) references tbl_tipo_marmitex ,
constraint fk_id_tamnho_marmitex foreign key (id_tamanho_marmitex) references tbl_tamanho_marmitex
); 

select*from tbl_marmitex;

----------------------------MARMITEX PROMOCIONAL------------------------------------
insert into tbl_marmitex(nome_marmitex , id_tipo_marmitex , id_tamanho_marmitex)
values 
('Filé de Frango Grelhado' , 1 , 4),
('Liguiça Calabresa Acebolada', 1 ,4),
('Liguiça Toscana' , 1 , 4),
('Carne Moída' , 1 , 4),
('Bisteca' , 1 , 4);

----------------------------MARMITEX PREMIUM------------------------------------
insert into tbl_marmitex(nome_marmitex , id_tipo_marmitex , id_tamanho_marmitex)
values 
('Panqueca de Carne' , 2 , 1),
('Panqueca de Carne' , 2 , 2),
('Panqueca de Carne' , 2 , 3),
('Panqueca de Frango' , 2 , 1),
('Panqueca de Frango' , 2 , 2),
('Panqueca de Frango' , 2 , 3),
('Panqueca de Brócolis' , 2 , 1),
('Panqueca de Brócolis' , 2 , 2),
('Panqueca de Brócolis' , 2 , 3),
('Filé de Meluza à Milaneza' , 2 , 1),
('Filé de Meluza à Milaneza' , 2 , 2),
('Filé de Meluza à Milaneza' , 2 , 3),
('Filé de Frango Grelhado' , 2 , 1),
('Filé de Frango Grelhado' , 2 , 2),
('Filé de Frango Grelhado' , 2 , 3),
('Contra Filé' , 2 , 1),
('Contra Filé' , 2 , 2),
('Contra Filé' , 2 , 3),
('Frango à Parmediana' , 2 , 1),
('Frango à Parmediana' , 2 , 2),
('Frango à Parmediana' , 2 , 3),
('Omelete com Presunto e Queijo' , 2 , 1),
('Omelete com Presunto e Queijo' , 2 , 2),
('Omelete com Presunto e Queijo' , 2 , 3),
('Omelete com Peito de Frango Defumado e Queijo' , 2 , 1),
('Omelete com Peito de Frango Defumado e Queijo' , 2 , 2),
('Omelete com Peito de Frango Defumado e Queijo' , 2 , 3),
('Omelete 4 Queijos' , 2 , 1),
('Omelete 4 Queijos' , 2 , 2),
('Omelete 4 Queijos' , 2 , 3);

insert into tbl_marmitex(nome_marmitex , id_tipo_marmitex , id_tamanho_marmitex)
values 
('Feijoada P' , 5 , 6),
('Feijoada G' , 5 , 7),
('Virado' , 5 , 8),
('Salada no Pote' , 5 , 9),
('Salada Proteica' , 5 , 10);

select*from tbl_tamanho_marmitex;

select*from tbl_marmitex;

select*from tbl_tipo_marmitex;

----------------------------MARMITEX LIGHT------------------------------------
insert into tbl_marmitex(nome_marmitex , id_tipo_marmitex , id_tamanho_marmitex)
values
('Omelete com Brócolis e Requeijão Light' , 3 , 5),
('Omelete com Peito de Frango Defumado' , 3 , 5),
('Filé de Frango Grelhado' , 3 , 5),
('Carne Moída' , 3 , 5),
('Frango Desfiado' , 3 , 5);


select*from tbl_tamanho_marmitex;

select*from tbl_marmitex;

select*from tbl_tipo_marmitex;



