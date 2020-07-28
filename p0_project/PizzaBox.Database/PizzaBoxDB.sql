use master;
go

create database PizzaBoxDb1;
go

use PizzaBoxDB1;
go

create schema Pizza;
go

create table Pizza.Pizza
(
    PizzaId int not null,
    CrustId int not null,
    SizeId int not null,
    [Name] nvarchar(200) not null
);

create table Pizza.Crust
(
    CrustId int not null,
    [Name] nvarchar(200) not null
);

create table Pizza.Size 
(
    SizeId int not null,
    [Name] nvarchar(200) not null
);

create table Pizza.Topping 
(
    ToppingId int not null,
    [Name] nvarchar(200)
);
go

alter table Pizza.Pizza
  add constraint PK_Pizza_PizzaId primary key (PizzaId)

alter table Pizza.Pizza
  add constraint PK_Pizza_CrustId foreign key (CrustId) references Pizza.Crust(CrustId)

alter table Pizza.Pizza
  add constraint PK_Pizza_SizeId foreign key (SizeId) references Pizza.Size(SizeId)

  alter table Pizza.Crust
  add constraint PK_Crust_CrustId primary key (CrustId)

  alter table Pizza.Size
  add constraint PK_Size_SizeId primary key (SizeId)

  alter table Pizza.Topping
  add constraint PK_Topping_ToppingId primary key (ToppingId)

  create schema [Order];
  go

  create table [Order].[Order]
  (
      OrderId int not null,
      UserId int not null,
      StoreId int not null
  );

  alter table [Order].[Order]
  add constraint PK_Order_Order primary key (OrderId)

  alter table [Order].[Order]
  add constraint PK_Order_UserId foreign key (UserId) references Users.Users(UserId)

  alter table [Order].[Order]
  add constraint PK_Order_StoreId foreign key (StoreId) references Store.Store(StoreId)

  create schema Users;
  go

  create table Users.Users
  (
      UserId int not null primary key,
      [Name] nvarchar(200) not null
  )

  create schema Store;
  go

  create table Store.Store
  (
      StoreId int primary key,
      [Name] nvarchar(200)
  );
  go

  //Junction 

  create table Store.[Order]
  (
      StoreOrderId int not null primary key,
      StoreId int not null foreign key references Store.Store(StoreId),
      OrderId int foreign key references [Order].[Order](OrderId)
  );
  go

  create table [Order].Pizza
  (

  PizzaOrderID int primary key,
  OrderID int foreign key references [Order].[Order](OrderID),
  PizzaID int foreign key references Pizza.Pizza(PizzaID)

);
go

create table Pizza.PizzaTopping(

  PizzaToppingID int primary key,
  PizzaID int foreign key references Pizza.Pizza(PizzaID),
  ToppingID int foreign key references Pizza.Topping(ToppingID)

);
go