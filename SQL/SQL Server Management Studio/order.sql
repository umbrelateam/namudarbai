

select city.name,country.name,people.FirstName + ' ' + people.LastName as human  
from city,country,people
where country_id = country.id and city_id = city.id
order by country.name

select country.name as country_name,
	count(*)  
from city join country on country_id = country.id 
join people on city_id = city.id
group by country.name

select Community.name,count (*) as PlotCount, SUM(squareMeters) as MeterSUM
 from Plot  join Community on community_id = Community.id
 group by Community.name

select SUM(squareMeters) as Community2 from Plot
where community_id =2
order by country.name

drop table aaa
create table aaa(id int identity primary key, 
name varchar(128), 
r_date datetime default getdate(),
amount decimal(10,2) default 0)

select * from aaa

insert into aaa(name)
values('Vilnius')


