use [master]
go

create database [SSP_base]
on primary 
( name = N'SSP_base', filename = N'D:\MSSQL\SSP_base.mdf')
go

use [SSP_base]
go

create table Debtors (
	id_debtor int identity(100, 1) not null,
	name_debtor nvarchar(150),
	INN nvarchar(50)
	constraint con_Debtors_PK
	primary key (id_debtor)
)
go

create table Doc (
	id_Doc int identity(10, 1) not null,
	id_debtor int,
	name_doc nvarchar(50),
	number_doc nvarchar(50),
	date_doc date
	constraint con_Doc_PK
	primary key (id_Doc)
	constraint con_Doc_FK_Debtors
	foreign key (id_debtor) references Debtors (id_debtor)
	on delete no action on update cascade
)
go

create table SSP (
	id_SSP int identity(1, 1) not null,
	id_doc int,
	number_SSP nvarchar(50),
	date_SSP date
	constraint con_SSP_PK
	primary key (id_SSP)
	constraint con_SSP_FK_Doc
	foreign key (id_doc) references Doc (id_Doc)
	on delete no action on update cascade
)
go

--Заполнение


set identity_insert Debtors on
insert into Debtors(id_debtor, name_debtor, INN)
values(101, 'ООО Алькор', 761001234),
	  (102, 'ООО Алькор', 761367982),
	  (103, 'Иванов Сергей Петрович', 76100234571)
set identity_insert Debtors off
go

set identity_insert Doc on
insert into Doc(id_Doc, id_debtor, name_doc, number_doc, date_doc)
values(11, 101, 'Судебный приказ', '5-196/2022', '23.02.2022'),
	  (12, 102, 'Судебный приказ', '5-98/2021', '17.03.2021'),
	  (13, 103, 'Исполнительный лист', 'А82-96/2019', '22.01.2019')
set identity_insert Doc off
go

set identity_insert SSP on
insert into SSP(id_SSP, id_doc, number_SSP, date_SSP)
values(1, 11, '7602-5-196-2022', '05.03.2022'),
	  (2, 12, '7602-5-98-2021', '05.03.2022'),
	  (3, 13, null, null)
set identity_insert SSP off
go
