use sgr;

create table tbl_forma_pagamento(
id_forma_pagamento smallint primary key identity,
descricao_pagamento varchar (12) not null
);

insert into tbl_forma_pagamento(descricao_pagamento)
values('Dinheiro'),('Cartão');

select*from tbl_forma_pagamento;

------------------------------------------------------------------------------

select*from tbl_pedido_delivery;

alter table tbl_pedido_delivery add id_forma_pagamento smallint;

alter table tbl_pedido_delivery add constraint fk_id_forma_pagamento foreign key (id_forma_pagamento) references tbl_forma_pagamento;

------------------------------------------------------------------------------

select*from tbl_pedido_mesa;

alter table tbl_pedido_mesa add id_forma_pagamento smallint;

alter table tbl_pedido_mesa add constraint fk_id_forma_pagamento2 foreign key (id_forma_pagamento) references tbl_forma_pagamento;

------------------------------------------------------------------------------
alter table tbl_item_pedido_mesa DROP COLUMN id_forma_pagamento;

alter table tbl_item_pedido_mesa DROP constraint fk_id_forma_pagamento2 ;
