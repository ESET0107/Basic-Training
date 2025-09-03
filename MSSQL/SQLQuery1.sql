create database society
use society
create table scorecard (player_name varchar(30),player_score int)
insert into scorecard(player_name,player_score) values ('K L Rahul',12);
update scorecard set player_name = 'Gayle' where player_score = 82
select * from scorecard