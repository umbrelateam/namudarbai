create table People(id int primary key, firstName varchar(70), lastName varchar(70),constraint uc_FullName unique (firstName, lastName) , city_id int, adress varchar (128), phoneNo varchar(128), email varchar(128))
go
--view
drop table People
insert into People(id, firstName, lastName, city_id, adress, phoneNo, email)
values(1,'James','Bond',3, 'aaa', '+123456', 'a@gmail.com'),--12469,357810
(2,'Jason','Voorhees',1, 'bbb', '+789101', 'b@gmail.com'),
(3,'Peter','Parker',5, 'ccc', '+112131', 'c@gmail.com'),
(4,'Dexter','Morgan',2, 'ddd', '+415161', 'd@gmail.com'),
(5,'Van','Helsing',4, 'eee', '+718192', 'e@gmail.com'),
(6,'Bruce','Wayne',9, 'fff', '+021222', 'f@gmail.com'),
(7,'Dick','Grayson',7, 'ggg', '+324252', 'g@gmail.com'),
(8,'Todd','Howard',10, 'hhh', '+627282', 'h@gmail.com'),
(9,'Stan','Lee',6, 'iii', '+930313', 'i@gmail.com'),
(10,'John','Stephens',8, 'jjj', '+233343', 'j@gmail.com')

create table city(id int primary key, name varchar(128), country_id int)
go
delete from City where id = 15
select * from city
insert into city(id,name,country_id)
values(15,'COK',1)
values(14,'London',7)
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

update City set name ='CoC' where id =15

create table country(id int primary key, name varchar(128))
go
insert into country(id,name)
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

create table Plot(id int primary key, community_id int, squareMeters int, owner_id int, plotNo varchar(128), adress varchar(128))
go
drop table Plot
insert into Plot(id,community_id,squareMeters,owner_id,plotNo,adress)
values(1,1,35,4,'PlotNo 1','Albrechtstrasse 96'),
(2,1,26,2,'PlotNo 2','Motzstr. 97'),
(3,1,21,1,'PlotNo 3','Amsinckstrasse 46'),
(4,1,30,6,'PlotNo 4','Boxhagener Str. 87'),
(5,1,19,9,'PlotNo 5','Guentzelstrasse 60'),
(6,2,13,3,'PlotNo 1','Yakovleva pr 1'),
(7,2,19,5,'PlotNo 2',	'Engelsa str 36'),
(8,2,17,8,'PlotNo 3','Lermontova str 257'),
(9,2,15,7,'PlotNo 4','Vzletnaya Str 5'),
(10,2,14,10,'PlotNo 5','Podgornaya str. 92')

alter table people add constraint fk_people_city
foreign key(city_id) references city(id)
go

alter table city add constraint fk_city_country
foreign key(country_id) references country(id)
go

alter table community add constraint fk_community_people
foreign key(manager_id) references people(id)
go

alter table community add constraint fk_community_city
foreign key(city_id) references city(id)
go

alter table plot add constraint fk_plot_people
foreign key(owner_id) references people(id)
go

alter table plot add constraint fk_plot_community
foreign key(community_id) references community(id)

select community.name,count (*) as PlotCount, SUM(squareMeters) as MeterSUM
 from plot  join community on community_id = community.id
 group by community.name

create table Payment (id int primary key, plot_id int, paidAmount decimal(12,2),constraint check_paidAmount Check (paidAmount > 0), r_date datetime default GETDATE())
drop table Payment


alter table Payment add constraint fk_payment_plot
foreign key(plot_id) references Plot(id)


insert into Payment(id, plot_id, paidAmount)
values(1, 3, 1)
select * from Payment

create table TableA(id int primary key, name varchar(70), tableB_id int)
drop table TableA
insert into TableA(id, name, tableB_id)
values(4, 'D', 4),
(5, 'E', 4),
(6, 'F', 4)
(1, 'A', 2),
(2, 'B', 3),
(3, 'C', 4)

alter table TableA add constraint fk_TableA_TableB
foreign key (tableB_id) references TableB(id) on delete cascade

create table TableB(id int primary key, name varchar(70))
drop table TableB
insert into TableB(id, name)
values(3, 'A'),
(4, 'T'),
(5, 'B'),
(6, 'C')
values(2, 'D')
values(1, 'B')

delete from TableB where id = 4

Select * from TableA
Select * from TableB

Create view vWTableAByTableB
as
select tableA.id, tableA.name, tableB.name as TableB_name
from TableA tableA 
left outer join TableB tableB on tableA.tableB_id = tableB.id

 select * from vWTableAByTableB
 Update vWTableAByTableB
 set name = 'Dominyk' where id = 1
 Delete from vWTableAByTableB where id = 1
 Insert into vWTableAByTableB values (4, 'D', 'E')
 --virtual table, select statement
 --защищенность данных
 --не надо все время прописывать query (join) 
 --можно убирать ненужные для юзера данные
 --если view состоит из 2 и более таблиц, нельзя удалять или вставлять записи в нее. 
  sp_helptext vWTableAByTableB

  select * from plot
  select * from payment
  select PlotNo, sum(paidAmount) as PaidAmount
  from Plot, Payment
  where Plot.id = plot_id
  and r_date between '2018-01-01' and '2018-12-31'
  Group by r_date, PlotNo
  having sum(paidAmount) > 0


  drop trigger tr_cityTable_update
  create trigger tr_cityTable_update
  on City
  for Update
  as
  begin
      select * from deleted
      select * from inserted
  end

