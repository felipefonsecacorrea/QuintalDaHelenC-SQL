--tabela mesa
create table tbl_mesa(
numero_mesa smallint primary key
);

drop table tbl_pedido_mesa;

--tabela Pedido mesa
create table tbl_pedido_mesa(
id_pedido_mesa smallint primary key identity,
numero_mesa smallint not null,
data_pedido_mesa date not null,
total_pedido_mesa money not null
constraint fk_numero_mesa foreign key (numero_mesa) references tbl_mesa
);
drop table tbl_pedido_mesa

--item pedido mesa
create table tbl_item_pedido_mesa(
id_item_mesa smallint primary key identity,
id_pedido_mesa smallint not null,
id_produto smallint not null
constraint fk_id_pedido_mesa foreign key (id_pedido_mesa) references tbl_pedido_mesa,
constraint fk_id_produto_cardapio foreign key (id_produto) references tbl_produto
);

drop table tbl_item_pedido_mesa
