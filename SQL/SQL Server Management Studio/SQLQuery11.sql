create table Test2(id int identity primary key, title varchar(120))
create table Test3(id int identity primary key, title varchar(120), test_id int)
alter table Test3 add constraint fk_test2_test3 foreign key (test_id) references Test2(id)
select * from Test2
select * from Test3
