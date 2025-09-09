create database SmartMeters
use SmartMeters
--Task 0
create table Customers(CustomerId int primary key ,Customer_name varchar(50),
Address varchar(150),Region varchar(50))

create table SmartMeterReadings (MeterId int, CustomerId int,
Locations varchar(50),InstalledDate date, ReadingDateTime datetime, EnergyConsumed int)
alter table smartmeterreadings
alter column energyconsumed float

insert into Customers values (1,'Vivek','Chennai','South'),(2,'Abhinav','Kolkata','East'),
(3,'Rahul','Mumbai','West') ,(4,'Yash','Delhi','North')

insert into SmartMeterReadings values (1001,1,'rooftop','2020-10-21','2025-03-15 14:39:54',74),
(1002,2,'basement','2024-07-09','2025-06-09 15:26:21',42),
(1003,3,'store room','2017-01-09','2025-08-28 09:01:08',61),
(1004,4,'rooftop','2025-04-13','2025-08-08 18:00:59',49)
update SmartMeterReadings set ReadingDateTime = '2024-05-09 15:26:21' where EnergyConsumed = 28

select * from Customers
select * from SmartMeterReadings

--Task 1
--energy consumed between 10 and 50 kWh
--reading datetime between 2024-01-01 and 2024-12-31
--meters installed before 2024-06-30
select * from SmartMeterReadings where EnergyConsumed between 10 and 50 and 
ReadingDateTime between '2024-01-01' and '2024-12-31' and
InstalledDate <= '2024-06-30'

--Task 2
-- for each customer average energy and max energy consumed in present year is calculated
select CustomerId ,avg(EnergyConsumed) as AvgEnergyConsumed, max(EnergyConsumed) as MaxEnergyConsumed 
from SmartMeterReadings where ReadingDateTime >= 2025-01-01 group by CustomerId

