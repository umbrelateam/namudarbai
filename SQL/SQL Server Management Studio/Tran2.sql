Begin Tran
update TableB set name ='A Transaction 2'
where id = 1

update TableA set name ='B Transaction 2'
where id = 1

Commit Transaction