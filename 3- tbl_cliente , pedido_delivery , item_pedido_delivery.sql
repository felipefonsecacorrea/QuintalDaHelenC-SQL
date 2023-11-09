--table cliente
create table tbl_cliente (
id_cliente smallint primary key identity,
nome_cliente varchar (50) not null,
tel_cliente varchar (12) not null,
bairro_endereco varchar(50) not null,
rua_endereco varchar(50) not null,
numero_endereco smallint not null,
referencia_endereco varchar (100) 
);

select*from tbl_cliente;

--table pedido delivery
create table tbl_pedido_delivery(
id_pedido_delivery smallint primary key identity,
id_cliente smallint not null,
data_pedido_delivery date not null,
total_pedido_delivery money not null
constraint fk_id_cliente foreign key (id_cliente) references tbl_cliente
);

select*from tbl_pedido_delivery;

--tabela item pedido delivery
create table tbl_item_pedido_delivery(
id_item_pedido smallint primary key identity,
id_pedido_delivery smallint not null,
id_marmitex smallint ,
id_produto smallint 
constraint fk_id_pedido_delivery foreign key (id_pedido_delivery) references tbl_pedido_delivery,
constraint fk_id_marmitex foreign key (id_marmitex) references tbl_marmitex,
constraint fk_id_produto foreign key (id_produto) references tbl_produto
);

select*from tbl_item_pedido_delivery;

drop table tbl_item_pedido_delivery
