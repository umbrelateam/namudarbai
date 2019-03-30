create table people (id int primary key, FirstName varchar(70), LastName varchar(70), city_id int) 
go

insert into people(id, FirstName, LastName, city_id)
values(1,'James','Bond',1),
(2,'Jason','Voorhees',1),
(3,'Peter','Parker',4),
(4,'Dexter','Morgan',3),
(5,'Van','Helsing',2)

select * from people

create table city(id int primary key, name varchar(128), country_id int)
go

insert into city(id, name, country_id)
values(1, 'Vilnius',1),
(2,'Moscow',2),
(3,'Riga',3),
(4,'Kaunas',1),
(5,'Talin',4)	

select * from city

create table country(id int primary key, name varchar(128))
go

insert into country(id, name)
values(1,'Lithuania'),
(2,'Russia'),
(3,'Latvia'),
(4,'Estonia')

select * from country



ALTER table people add constraint fk_people_city
foreign key(city_id) references city(id)
go

select * from people,city 
where people.city_id = city.id

AlTer table city add constraint fk_city_country
foreign key(country_id) references country(id)
go

select * from city, country
where city.country_id = country.id

select * from people,city,country
where city.country_id = country.id and people.city_id = city.id 