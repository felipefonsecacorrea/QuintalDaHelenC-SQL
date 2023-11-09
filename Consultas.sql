use SGR;

select * from tbl_cliente;

select*from tbl_tipo_produto

----------------------------------------------------------------------------------------------------------------------------

--Select Pedidos delivery

select id_pedido_delivery as 'Numero do Pedido' , nome_cliente as Cliente, data_pedido_delivery as Data ,
total_pedido_delivery as Total , descricao_pagamento as 'Forma de Pagamento'  
from tbl_pedido_delivery inner join tbl_cliente
on tbl_pedido_delivery.id_cliente=tbl_cliente.id_cliente
inner join tbl_forma_pagamento on tbl_pedido_delivery.id_forma_pagamento=tbl_forma_pagamento.id_forma_pagamento;

----------------------------------------------------------------------------------------------------------------------------

--itens pedido delivery

insert into tbl_pedido_delivery (id_cliente  , data_pedido_delivery , total_pedido_delivery)
values
(1 , '20191104' , 0),
(2 , '20191103' , 0);

update tbl_pedido_delivery
set total_pedido_delivery = 25.00
where id_pedido_delivery = 2;

select * from tbl_item_pedido_delivery;

insert into tbl_item_pedido_delivery(id_pedido_delivery , id_marmitex)
values (2 , 35);

insert into tbl_item_pedido_delivery(id_pedido_delivery , id_produto)
values (2 , 41);


----------------------------------------------------------------------------------------------------------------------------

--Procedimentos Pesquisa Pedidos Delivery

select*from tbl_marmitex inner join tbl_tamanho_marmitex
on tbl_marmitex.id_tamanho_marmitex = tbl_tamanho_marmitex.id_tamanho_marmitex;

select*from tbl_produto where id_tipo_produto = 2;

create procedure pr_PesquisaMarmitexPedidoDelivery
(
@id smallint
)
as
select nome_marmitex , tamanho_marmitex , preco_tamanho_marmitex from tbl_item_pedido_delivery 
inner join tbl_marmitex on tbl_item_pedido_delivery.id_marmitex=tbl_marmitex.id_marmitex
inner join tbl_tamanho_marmitex on tbl_marmitex.id_tamanho_marmitex=tbl_tamanho_marmitex.id_tamanho_marmitex
where id_pedido_delivery = @id

exec pr_PesquisaMarmitexPedidoDelivery 1;

create procedure pr_PesquisaBebidaPedidoDelivery
(
@id smallint
)
as
select nome_produto , preco_produto from tbl_item_pedido_delivery 
inner join tbl_produto on tbl_item_pedido_delivery.id_produto=tbl_produto.id_produto
where id_pedido_delivery = @id

exec pr_PesquisaBebidaPedidoDelivery 1;

----------------------------------------------------------------------------------------------------------------------------
select*from tbl_pedido_mesa

--insert pedidos mesa
insert into tbl_pedido_mesa (numero_mesa , data_pedido_mesa , total_pedido_mesa , id_forma_pagamento)
values 
(3 , '20191104' , 114.00 , 1),
(2 , '20191105' , 99.00 , 2 ),
(4 , '20191106' , 52.00 , 1);

insert into tbl_item_pedido_mesa (id_pedido_mesa , id_produto)
values (1 , 12), (1 , 45);

select*from tbl_item_pedido_mesa

select id_pedido_mesa, numero_mesa , data_pedido_mesa , total_pedido_mesa , descricao_pagamento from tbl_pedido_mesa inner join tbl_forma_pagamento on tbl_pedido_mesa.id_forma_pagamento=tbl_forma_pagamento.id_forma_pagamento

select nome_produto , preco_produto from tbl_item_pedido_mesa inner join tbl_produto on tbl_item_pedido_mesa.id_produto=tbl_produto.id_produto where id_pedido_mesa = 2

select*from tbl_entrega

insert into tbl_entrega (data_entrega) values ()

select count(id_entrega)from tbl_entrega where data_entrega = '20191107'

select CONVERT(varchar,data_entrega,103) , count (id_entrega) from tbl_entrega 

select*from tbl_tamanho_marmitex
select*from tbl_tipo_marmitex
select*from tbl_marmitex

--seletc Mamitex
select id_marmitex , nome_marmitex , nome_tipo_marmitex , tamanho_marmitex , preco_tamanho_marmitex from tbl_marmitex 
inner join tbl_tipo_marmitex on tbl_marmitex.id_tipo_marmitex=tbl_tipo_marmitex.id_tipo_marmitex
inner join tbl_tamanho_marmitex on tbl_marmitex.id_tamanho_marmitex=tbl_tamanho_marmitex.id_tamanho_marmitex;

------------------DIA-----------------------------DIA------------------------------DIA-----------------------------------------------
--select total Dia
select sum (total_pedido_delivery + total_pedido_mesa) from tbl_pedido_mesa 
inner join tbl_pedido_delivery on tbl_pedido_mesa.id_forma_pagamento=tbl_pedido_delivery.id_forma_pagamento 
where data_pedido_mesa = '20191104'

--select Pedidos mesa Dia
select CONVERT(varchar,data_pedido_mesa,103) , id_pedido_mesa , numero_mesa , total_pedido_mesa , descricao_pagamento from tbl_pedido_mesa 
inner join tbl_forma_pagamento on tbl_pedido_mesa.id_forma_pagamento=tbl_forma_pagamento.id_forma_pagamento
where data_pedido_mesa = '20191104'

--select Pedidos Delivery Dia
select id_pedido_delivery , CONVERT(varchar,data_pedido_delivery,103) as data_pedido_delivery, nome_cliente , total_pedido_delivery , descricao_pagamento from tbl_pedido_delivery
inner join tbl_forma_pagamento on tbl_pedido_delivery.id_forma_pagamento = tbl_forma_pagamento.id_forma_pagamento
inner join tbl_cliente on tbl_pedido_delivery.id_cliente = tbl_cliente.id_cliente
where data_pedido_delivery = '20191107'

--select total Dia cartao
select sum (total_pedido_delivery + total_pedido_mesa)  from tbl_pedido_mesa
inner join tbl_pedido_delivery on tbl_pedido_mesa.id_forma_pagamento = tbl_pedido_delivery.id_forma_pagamento 
inner join tbl_forma_pagamento on tbl_pedido_mesa.id_forma_pagamento=tbl_forma_pagamento.id_forma_pagamento
where descricao_pagamento ='cartão' and data_pedido_mesa = '20191103'   

--select total Dia Dinheiro
select sum (total_pedido_delivery + total_pedido_mesa) as totalDinheiro from tbl_pedido_mesa
inner join tbl_pedido_delivery on tbl_pedido_mesa.id_forma_pagamento = tbl_pedido_delivery.id_forma_pagamento 
inner join tbl_forma_pagamento on tbl_pedido_mesa.id_forma_pagamento=tbl_forma_pagamento.id_forma_pagamento
where descricao_pagamento ='Dinheiro' and data_pedido_mesa = '20191104'   

select*from tbl_forma_pagamento

------------------ANO----------------------ANO----------------------------ANO---------------------------ANO-----------------------------
--select total Ano
select sum (total_pedido_delivery + total_pedido_mesa) as Total from tbl_pedido_mesa 
inner join tbl_pedido_delivery on tbl_pedido_mesa.id_forma_pagamento=tbl_pedido_delivery.id_forma_pagamento 
where year(data_pedido_mesa) = '2019'

--select total ano Dinheiro
select sum (total_pedido_delivery + total_pedido_mesa) as totalDinheiro from tbl_pedido_mesa
inner join tbl_pedido_delivery on tbl_pedido_mesa.id_forma_pagamento = tbl_pedido_delivery.id_forma_pagamento 
inner join tbl_forma_pagamento on tbl_pedido_mesa.id_forma_pagamento=tbl_forma_pagamento.id_forma_pagamento
where descricao_pagamento ='Dinheiro' and year(data_pedido_mesa) = '2019'   

--select total Ano Cartao
select sum (total_pedido_delivery + total_pedido_mesa)  from tbl_pedido_mesa
inner join tbl_pedido_delivery on tbl_pedido_mesa.id_forma_pagamento = tbl_pedido_delivery.id_forma_pagamento 
inner join tbl_forma_pagamento on tbl_pedido_mesa.id_forma_pagamento=tbl_forma_pagamento.id_forma_pagamento
where descricao_pagamento ='cartão' and year(data_pedido_mesa) = '2019'   

--select Pedidos mesa ano
select CONVERT(varchar,data_pedido_mesa,103) as data_pedido_mesa , id_pedido_mesa , numero_mesa , total_pedido_mesa , descricao_pagamento from tbl_pedido_mesa 
inner join tbl_forma_pagamento on tbl_pedido_mesa.id_forma_pagamento=tbl_forma_pagamento.id_forma_pagamento
where year(data_pedido_mesa) = '2019'

--select Pedidos Delivery ano
select id_pedido_delivery , CONVERT(varchar,data_pedido_delivery,103) as data_pedido_delivery, nome_cliente , total_pedido_delivery , descricao_pagamento from tbl_pedido_delivery
inner join tbl_forma_pagamento on tbl_pedido_delivery.id_forma_pagamento = tbl_forma_pagamento.id_forma_pagamento
inner join tbl_cliente on tbl_pedido_delivery.id_cliente = tbl_cliente.id_cliente
where year(data_pedido_delivery) = '2019'

--------------------MES-------------------------MES----------------------MES-----------------------------------MES-----------------------

--select total Mes
select sum (total_pedido_delivery + total_pedido_mesa) as Total from tbl_pedido_mesa 
inner join tbl_pedido_delivery on tbl_pedido_mesa.id_forma_pagamento=tbl_pedido_delivery.id_forma_pagamento 
where month(data_pedido_mesa) = '11' and year(data_pedido_mesa) = 2019

--select total Mes Dinheiro
select sum (total_pedido_delivery + total_pedido_mesa) as totalDinheiro from tbl_pedido_mesa
inner join tbl_pedido_delivery on tbl_pedido_mesa.id_forma_pagamento = tbl_pedido_delivery.id_forma_pagamento 
inner join tbl_forma_pagamento on tbl_pedido_mesa.id_forma_pagamento=tbl_forma_pagamento.id_forma_pagamento
where descricao_pagamento ='Dinheiro' and month(data_pedido_mesa) = '02' and year(data_pedido_mesa) = '2019'   

--select total Mes Cartao
select sum (total_pedido_delivery + total_pedido_mesa)  from tbl_pedido_mesa
inner join tbl_pedido_delivery on tbl_pedido_mesa.id_forma_pagamento = tbl_pedido_delivery.id_forma_pagamento 
inner join tbl_forma_pagamento on tbl_pedido_mesa.id_forma_pagamento=tbl_forma_pagamento.id_forma_pagamento
where descricao_pagamento ='cartão' and month(data_pedido_mesa) = '02' and year(data_pedido_mesa) = '2019'   

--select Pedidos mesa Mes
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             
--select Pedidos Delivery ano
select id_pedido_delivery , CONVERT(varchar,data_pedido_delivery,103) as data_pedido_delivery, nome_cliente , total_pedido_delivery , descricao_pagamento from tbl_pedido_delivery
inner join tbl_forma_pagamento on tbl_pedido_delivery.id_forma_pagamento = tbl_forma_pagamento.id_forma_pagamento
inner join tbl_cliente on tbl_pedido_delivery.id_cliente = tbl_cliente.id_cliente
where month(data_pedido_delivery) = '02' and year(data_pedido_delivery) = '2019'

--criando item cardapio
INSERT INTO tbl_produto (nome_produto,id_tipo_produto,preco_produto) Values('Halls', 3 , 15.00)

--criando pedido mesa
insert into tbl_pedido_mesa (numero_mesa , data_pedido_mesa , total_pedido_mesa , id_forma_pagamento) values ()

--select itens pedido mesa
select*from tbl_item_pedido_mesa where id_pedido_mesa = 22 

--add itens pedido mesa
insert into tbl_item_pedido_mesa (id_pedido_mesa , id_produto) values (2 , 100)

--select pedido mesa
select count(id_pedido_mesa) as idUltimoPedido from tbl_pedido_mesa

--total pedido mesa
select Sum(preco_produto)as TOTAL from tbl_item_pedido_mesa inner join tbl_produto on tbl_item_pedido_mesa.id_produto=tbl_produto.id_produto where id_pedido_mesa = 22

--select marmitex
select id_marmitex , nome_marmitex , nome_marmitex , tamanho_marmitex , preco_tamanho_marmitex from tbl_marmitex inner join tbl_tamanho_marmitex on tbl_marmitex.id_tamanho_marmitex=tbl_tamanho_marmitex.id_tamanho_marmitex inner join tbl_tipo_marmitex on tbl_marmitex.id_tipo_marmitex= tbl_tipo_marmitex.id_tipo_marmitex where tbl_tipo_marmitex.id_tipo_marmitex = 4

--pesquisa id pedido delivery
select max(id_pedido_delivery + 1) as id_pedido from tbl_pedido_delivery

--criando pedido delivery
insert into tbl_pedido_delivery (id_cliente , data_pedido_delivery , total_pedido_delivery , id_forma_pagamento)values( , '' , 0 , )

select*from tbl_item_pedido_delivery

insert into tbl_item_pedido_delivery (id_pedido_delivery , id_marmitex) values ( , )

select sum(preco_tamanho_marmitex) from tbl_item_pedido_delivery 
inner join tbl_marmitex on tbl_item_pedido_delivery.id_marmitex=tbl_marmitex.id_marmitex
inner join tbl_tamanho_marmitex on tbl_marmitex.id_tamanho_marmitex=tbl_tamanho_marmitex.id_tamanho_marmitex
where id_pedido_delivery = 20

select nome_marmitex , tamanho_marmitex , preco_tamanho_marmitex from  
inner join tbl_marmitex on tbl_item_pedido_delivery.id_marmitex=tbl_marmitex.id_marmitex
inner join tbl_tamanho_marmitex on tbl_marmitex.id_tamanho_marmitex=tbl_tamanho_marmitex.id_tamanho_marmitex
where id_pedido_delivery = 17

select nome_produto , preco_produto from tbl_item_pedido_delivery 
inner join tbl_produto on tbl_item_pedido_delivery.id_produto=tbl_produto.id_produto
where id_pedido_delivery = 17

select sum(preco_produto) from tbl_item_pedido_delivery 
inner join tbl_produto on tbl_item_pedido_delivery.id_produto=tbl_produto.id_produto
where id_pedido_delivery = 17

UPDATE tbl_pedido_delivery set total_pedido_delivery = {}  WHERE id_pedido_delivery = {IDPEDIDO}

select * from tbl_pedido_delivery

select sum(preco_tamanho_marmitex) as TotalMarmitex from tbl_item_pedido_delivery inner join tbl_marmitex on tbl_item_pedido_delivery.id_marmitex = tbl_marmitex.id_marmitex inner join tbl_tamanho_marmitex on tbl_marmitex.id_tamanho_marmitex = tbl_tamanho_marmitex.id_tamanho_marmitex where id_pedido_delivery = 21

delete tbl_pedido_delivery;
delete tbl_item_pedido_delivery where id_item_pedido = 137  

delete tbl_pedido_mesa
delete tbl_item_pedido_mesa

select max(id_pedido_mesa) as idUltimoPedido from tbl_pedido_mesa

select count(id_pedido_mesa) as idUltimoPedido from tbl_pedido_mesa

select max(id_pedido_mesa) as idUltimoPedido from tbl_pedido_mesa

select max(id_pedido_mesa) as idUltimoPedido from tbl_pedido_mesa

select*from tbl_pedido_mesa

select*from tbl_pedido_delivery

select*from tbl_item_pedido_delivery where id_pedido_delivery = 138

select * from tbl_tipo_marmitex

select * from tbl_tamanho_marmitex

select*from tbl_marmitex

insert into tbl_tamanho_marmitex(tamanho_marmitex , preco_tamanho_marmitex) values('SG' , 8.00)

insert into tbl_marmitex (nome_marmitex , id_tipo_marmitex , id_tamanho_marmitex) values ('Salada Grande' , 4 , 11)

select * from tbl_marmitex

select id_pedido_delivery , CONVERT(varchar,data_pedido_delivery,103) as data_pedido_delivery, nome_cliente , total_pedido_delivery , descricao_pagamento from tbl_pedido_delivery inner join tbl_forma_pagamento on tbl_pedido_delivery.id_forma_pagamento = tbl_forma_pagamento.id_forma_pagamento inner join tbl_cliente on tbl_pedido_delivery.id_cliente = tbl_cliente.id_cliente where data_pedido_delivery = ;

select tbl_item_pedido_delivery.id_pedido_delivery , tbl_marmitex.nome_marmitex ,tbl_tamanho_marmitex.preco_tamanho_marmitex from tbl_item_pedido_delivery 
inner join tbl_marmitex on tbl_item_pedido_delivery.id_marmitex=tbl_marmitex.id_marmitex
inner join tbl_tamanho_marmitex on tbl_marmitex.id_tamanho_marmitex=tbl_tamanho_marmitex.tamanho_marmitex

select sum (total_pedido_delivery + total_pedido_mesa) as totaldinheiro from tbl_pedido_mesa 
inner join tbl_pedido_delivery on tbl_pedido_mesa.id_forma_pagamento = tbl_pedido_delivery.id_forma_pagamento 
inner join tbl_forma_pagamento on tbl_pedido_mesa.id_forma_pagamento = tbl_forma_pagamento.id_forma_pagamento 
where descricao_pagamento = 'Dinheiro' and data_pedido_mesa = '20191116'

create procedure pr_Pesquisatotal
(
@Totaldelivery int,
@Totalmesa int
)
as
select @Totaldelivery = SUM(total_pedido_delivery) from tbl_pedido_delivery

select @Totalmesa = sum(total_pedido_mesa) from tbl_pedido_mesa

exec pr_Pesquisatotal 0, 0

select SUM(total_pedido_delivery) from tbl_pedido_delivery
select sum(total_pedido_mesa) from tbl_pedido_mesa
