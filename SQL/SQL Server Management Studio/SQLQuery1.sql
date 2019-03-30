begin tran 
insert into City(country_id,name,id)
values(1,'sss',12)
--rollback
commit