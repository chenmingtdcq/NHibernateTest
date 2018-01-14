
    drop table if exists T_Product

    create table T_Product (
        ID BINARY(16) not null,
       Code VARCHAR(50),
       Name VARCHAR(50),
       QuantityPerUnit VARCHAR(50),
       Unit VARCHAR(50),
       SellPrice NUMERIC(14, 2),
       BuyPrice NUMERIC(14, 2),
       Remark VARCHAR(200),
       primary key (ID)
    )
