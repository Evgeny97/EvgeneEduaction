create table car_models(
id int identity primary key
,model_name varchar(50)
,model_date date
,model_body int
,warranty_run dec(6,2)
);

--���������� � ������--
create table cars(
win varchar(20) primary key
,car_date date
,color varchar(20)
,model int references car_models
);

--�������--
create table clients(
phone varchar(12) primary key
,fio varchar(50)
,dob date
);

--������� �����������--
create table sales(
car varchar(20) primary key references cars
,client varchar(12) references clients
,buy_date date
);
go
--���������� �� ����������--
create view car_info
as
select win
,model_name 
,case model_body when 0 then '�����' when 1 then '���������' when 2 then '�������' else '������' end body
,model_date
,car_date
,color
from car_models cm join cars c on cm.id=c.model;
go

--���������� �������--
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
--�������--
create trigger sale_date on sales
for insert
as
update sales set buy_date=current_timestamp
where car in(select car from inserted)
;

go
--������--
Insert into car_models(model_name,model_date,model_body,warranty_run)
values('Audi A4','2019-01-01',1,1234.23);
insert into cars values('AW-1234','2019-02-15','�������',1);
insert into clients values('+79089384765','������ �.�.','1987-02-23');
insert into sales(car,client) values('AW-1234','+79089384765');
select * from sales;
select * from client_car;    
select * from car_info;
