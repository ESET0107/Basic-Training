use master
select * from Users
select * from Books
select * from orders
insert into orders values (122,7,22),(123,7,55),(124,7,44)


select B.Names,B.Users_id ,C.price,C.title, 
ROW_NUMBER() over (partition by B.users_id order by C.price desc) as popularity,
rank() over (partition by B.users_id order by C.price desc) as popularity_rank,
dense_rank() over (partition by B.users_id order by C.price desc)as popularity_dense_rank 
from orders A 
inner join Users B  on A.Users_id = B.Users_id 
inner join Books C on A.Product_id = C.Product_id 
group by B.Names,B.Users_id,C.Price,C.title 