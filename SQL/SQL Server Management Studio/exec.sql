create procedure test1(@countryID int)
as 
begin 
select * from city where country_id = @countryID
end
drop procedure test1
exec test1 5
