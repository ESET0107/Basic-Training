create database company
use company
create table Employee (ID int, Emp_name varchar(50), Dept varchar(50), Salary float)
insert into Employee (ID, Emp_name, Dept,Salary) values (1,'Sharat','HR',200000) , (2,'Akash','IT',100000), (3,'Abhishek','HR',250000) , (4,'Kunal','Marketing',400000), (5,'Sowmya','IT',100000)
select * from Employee
update Employee set Salary = Salary * 1.4 where Emp_name = 'Sowmya'
delete from Employee where ID = 3
exec sp_rename 'Employee','Friends'
select * from friends
alter table friends
add Address varchar(150)
update friends set address = 'Bangalore' where ID = 1
alter table friends
alter column salary varchar(50)
alter table friends
drop column Address
exec sp_rename 'friends.Mobile_No','Contact_No'