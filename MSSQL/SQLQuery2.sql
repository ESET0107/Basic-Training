use society
create table bowling_scorecard (player_name varchar(30),overs int,runs_conceded int,maidens int,wickets int)
insert into bowling_scorecard(player_name,overs,runs_conceded,maidens,wickets) values ('Will Jacks',2,14,0,0);
select * from bowling_scorecard
exec sp_help bowling_scorecard
exec sp_rename 'bowling_scorecard','bowlers'
select * from bowlers
exec sp_rename 'bowlers.runs_conceded','runs','column'
update bowlers set overs = 3,runs = 30 ,wickets = 1 where player_name = 'Hardik'
alter table bowlers
alter column runs float
exec sp_help bowlers
alter table bowlers
drop column maidens
alter table bowlers
add economy float
update bowlers set economy = runs/overs
select * from bowlers