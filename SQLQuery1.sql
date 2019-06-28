create table car_models(
id int identity primary key
,model_name varchar(50)
,model_date date
,model_body int
,warranty_run dec(6,2)
);

--Автомобили в салоне--
create table cars(
win varchar(20) primary key
,car_date date
,color varchar(20)
,model int references car_models
);

--Клиенты--
create table clients(
phone varchar(12) primary key
,fio varchar(50)
,dob date
);

--Продажи автомобилей--
create table sales(
car varchar(20) primary key references cars
,client varchar(12) references clients
,buy_date date
);
go
--Информация об автомобиле--
create view car_info
as
select win
,model_name 
,case model_body when 0 then 'седан' when 1 then 'универсал' when 2 then 'хэтчбек' else 'другой' end body
,model_date
,car_date
,color
from car_models cm join cars c on cm.id=c.model;
go

--Автомобили клиента--
create view client_car
as
select fio
,win
,model_name
,body
,color
from clients c join 
	sales s on c.phone=s.client join
	car_info ci on ci.win=s.car;
go
--Триггер--
create trigger sale_date on sales
for insert
as
update sales set buy_date=current_timestamp
where car in(select car from inserted)
;

go
--Данные--
Insert into car_models(model_name,model_date,model_body,warranty_run)
values('Audi A4','2019-01-01',1,1234.23);
insert into cars values('AW-1234','2019-02-15','красный',1);
insert into clients values('+79089384765','Иванов И.И.','1987-02-23');
insert into sales(car,client) values('AW-1234','+79089384765');
select * from sales;
select * from client_car;    
select * from car_info;
