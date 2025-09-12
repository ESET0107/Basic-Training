use company
create table student (id int primary key, names varchar(50))
select * from student
insert into student values (1, 'shivam',null)
alter table student
add number int unique

create table teacherss(id int,subjects varchar(50),
foreign key(id) references student(id))
insert into teacherss values (1,'Math')
select * from teacherss
delete from student where id = 1 
delete from teacherss where id = 1

create table Users(Users_id int primary key,Email varchar(50), Names varchar(50))
create table Books(Product_id int primary key,Title varchar(150), Price float)
insert into Users values (7,'namaz@gmail.com','shreyansh')
update Users set Email = 'gopal@touchmenot.com' where Users_id = 2
insert into Books values (55,'Manusmriti',50) , (66,'How to quit smoking',6000) , (77, 'Bhagvad Gita' ,1800)

create table orders(order_no int primary key,Users_id int, Product_id int,
foreign key(Users_id) references Users(Users_id),
foreign key(Product_id) references Books(Product_id)) 
use master
select * from Users
select * from Books
select * from orders
insert into orders values (106,7,77) 

create table employee1 (id int primary key,names varchar(50), branch varchar(50), salary float)
insert into employee1(id,names,branch) values (6,'virat','Manager')

select count(*) from employee1 where salary between 150000 and 300000
select * from employee1 order by names

select * from orders
select * from Users
select * from orders A inner join Users B  on A.Users_id = B.Users_id 

select * from orders A full outer join Users B  on A.Users_id = B.Users_id 
full outer join Books C on A.Product_id = C.Product_id

select * from orders A inner join Users B  on A.Users_id = B.Users_id 
full outer join Books C on A.Product_id = C.Product_id

select * from orders A full outer join Users B  on A.Users_id = B.Users_id 
inner join Books C on A.Product_id = C.Product_id

select * from orders A inner join Users B  on A.Users_id = B.Users_id 
inner join Books C on A.Product_id = C.Product_id

--task 1
select * from orders A full outer join Users B  on A.Users_id = B.Users_id 
full outer join Books C on A.Product_id = C.Product_id
--task 2
select * from orders A left join Books C on A.Product_id = C.Product_id
--task 3
select C.Title,B.Names,C.Price from Books C inner join orders A on A.Product_id = C.Product_id
inner join Users B on b.Users_id = A.Users_id where (C.Product_id in (77,66,22))
--task 4
select C.Title,B.Names,C.Price from Books C inner join orders A on A.Product_id = C.Product_id
inner join Users B on b.Users_id = A.Users_id
--task 5

