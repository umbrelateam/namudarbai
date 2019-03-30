create table People(id int primary key, FirstName varchar(70), LastName varchar(70), city_id int)
go
drop table people
insert into People(id, FirstName, LastName, city_id)
values(1,'James','Bond',3),--12469,357810
(2,'Jason','Voorhees',1),
(3,'Peter','Parker',5),
(4,'Dexter','Morgan',2),
(5,'Van','Helsing',4),
(6,'Bruce','Wayne',9),
(7,'Dick','Grayson',7),
(8,'Todd','Howard',10),
(9,'Stan','Lee',6),
(10,'John','Stephens',8)

create table City(id int primary key, name varchar(128), country_id int)
go
drop table city
insert into City(id,name,country_id)
values(1,'Vilnius',4),
(2,'Moscow',2),
(3,'Riga',5),
(4,'Berlin',1),
(5,'Talin',3),
(6,'Kaunas',4),
(7,'Yekaterinburg',2),
(8,'Jūrmala',5),
(9,'Magdeburg',1),
(10,'Viljandi',3)



create table Country(id int primary key, name varchar(128))
go
drop table country
insert into Country(id,name)
values(1,'Germany'),
(2,'Russia'),
(3,'Estonia'),
(4,'Lithuania'),
(5,'Latvia')


create table Community(id int primary key, name varchar(128), adress varchar(128), manager_id int, city_id int, regNo varchar(128),priceForSquareMeter Decimal (12,2))
go
drop table Community
insert into Community(id,name,adress,manager_id,city_id,regNo, priceForSquareMeter)
values(1,'Umbrella','Bissingzeile 26',5,9,'5724', 16.7),
(2,'Bioshock','Gelsingforsskaya 2A',7,7,'9981', 25.3)

create table Plot(id int primary key, community_id int, squareMeters int, owner_id int, name varchar(128), adress varchar(128))
go
drop table Plot
insert into Plot(id,community_id,squareMeters,owner_id,name,adress)
values(1,1,35,4,'Dexter"s Plot','Albrechtstrasse 96'),
(2,1,26,2,'Jason"s Plot','Motzstr. 97'),
(3,1,21,1,'James"s Plot','Amsinckstrasse 46'),
(4,1,30,6,'Bruce"s Plot','Boxhagener Str. 87'),
(5,1,19,9,'Stan"s Plot','Guentzelstrasse 60'),
(6,2,13,3,'Peter"s Plot','Yakovleva pr 1'),
(7,2,19,5,'Van"s Plot',	'Engelsa str 36'),
(8,2,17,8,'Todd"s Plot','Lermontova str 257'),
(9,2,15,7,'Dick"s Plot','Vzletnaya Str 5'),
(10,2,14,10,'John"s Plot','Podgornaya str. 92')
--zakoncit
select  Community.regNo,
Community.name as communityName,
Community.adress + ',' + CommunityCity.name + ',' +
CommunityCountry.name as communityAdress,
manager.firstName + ' ' + manager.lastName as managerName,
Plot.plotNo,
Plot.Adress + ',' + plotCity.name + ',' + PlotCountry.name as PlotAdress,
own.firstName + ' ' + own.lastName as ownerName,
Plot.squareMeters 
from Community,Plot,People manager,People own ,City plotCity,City communityCity,Country CommunityCountry,Country PlotCountry 
where  CommunityCountry.country_id=country.id
and PlotCountry.country_id=country.id
and plotCity.city_id = city.id
and communityCity.city_id = city.id
and community_id=Community.id 
and owner_id=own.id
and Community.city_id=communityCity.id 
and manager_id=manager.id

alter table People add constraint fk_people_city
foreign key(city_id) references City(id)
go

alter table City add constraint fk_city_country
foreign key(country_id) references Country(id)
go

alter table Community add constraint fk_community_people
foreign key(manager_id) references People(id)
go

alter table Community add constraint fk_community_city
foreign key(city_id) references City(id)
go

alter table Plot add constraint fk_plot_people
foreign key(owner_id) references People(id)
go

create table Payment (id int primary key, plot_id int, dateData datetime, paidAmount decimal(12,2))
drop table Payment

alter table Payment add constraint fk_payment_plot
foreign key(plot_id) references Plot(id)
