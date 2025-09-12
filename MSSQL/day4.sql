use master
select * from Users
select * from Books
select * from orders

select B.Names,B.Users_id,count(*) as No_of_books_bought from orders A inner join Users B  on A.Users_id = B.Users_id 
inner join Books C on A.Product_id = C.Product_id group by B.Users_id,B.Names having count(*)>1

use Employee
select * from Employee
update Employee set salary = 69000 where first_name = 'toby'
select dept_id,first_name,last_name, salary,
ROW_NUMBER() over (order by salary desc) as popularity,
rank() over (order by salary desc) as popularity_rank,
dense_rank() over (order by salary desc)as popularity_dense_rank
from Employee

select dept_id,first_name,last_name, salary,
ROW_NUMBER() over (partition by dept_id order by salary desc) as popularity 
from Employee