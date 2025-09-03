use society
create table bowling_scorecard (player_name varchar(30),overs int,runs_conceded int,maidens int,wickets int)
insert into bowling_scorecard(player_name,overs,runs_conceded,maidens,wickets) values ('Santner',4,32,0,1);
select * from bowling_scorecard where runs_conceded/overs > 10 and wickets = 0