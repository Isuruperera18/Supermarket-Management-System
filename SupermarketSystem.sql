create database SupermarketSystem
use SupermarketSystem

create table Product
(
ProID int primary key,
ProName varchar (50),
ProQuantity int,
ProPrice int,
ProCategory varchar (50)
)

select * from Product
truncate table Product
insert into Product values('1','Beef','1','1000','Meat')
insert into Product values('2','Chicken','1','750','Meat')
insert into Product values('3','Lion Strong beer 500ml','1','350','Beer')


create table Category
(
CatID int primary key,
CatName varchar (50),
CatDescription varchar (100)
)

select * from Category
insert into Category values('1','Meat','All Meat & Seafood')
insert into Category values('2','Beverages','tea, coffee, soda, juice, Kool-Aid, hot chocolate, water, etc')
insert into Category values('3','Beer','Beer, Wine & Spirits')
insert into Category values('4','Diary','Dairy, Eggs & Cheese')
insert into Category values('5','Snacks','Cookies, Snacks & Candy')

create table Seller
(
SellID int primary key,
SellName varchar (50),
SellAddress varchar (100),
SellAge int,
SellPhonenumber varchar (50),
SellPassword varchar (50)
)

select * from Seller
truncate table Seller
insert into Seller values('1','Isuru Perera','15/2,1st Rd, Rawathawatte, Moratuwa','21','0764567894','wweseth')

create table Bill
(
BillID int primary key,
SellerName varchar (50),
BillDate varchar (50),
TotalAmount int
)

select * from Bill
truncate table Bill
