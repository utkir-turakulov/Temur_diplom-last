use master
go
CREATE DATABASE Courses;

use Coures;
go
 Create Table Роли
 (
 id integer primary key identity(1,1),
 roleName nvarchar(50)
 
 )

 go
 Create Table ВидКурса
 (
	id integer primary key identity(1,1),
	coursName nvarchar(50)
 )

 go
 Create Table Авторизация
 (
	id integer primary key identity(1,1),
	login nvarchar(50),
	password nvarchar(50)
 )

 go
 Create Table ФормаОбучения
 (
	id integer primary key identity(1,1),
	educationType nvarchar(20)
 );



 go
 Create Table Пользователи
 (
	id integer primary key identity(1,1),
	firstName nvarchar(50),
	midleName nvarchar(50),
	lastName nvarchar(50),
	dateOfBirth dateTime,
	authId int,
	roleId int,
	constraint FK_ПользователиАвторизация 
	foreign key (authId) references Авторизация(id) 
	on delete set null 
	on update cascade,
	constraint FK_ПользователиРоли foreign key(roleId)
	references Роли(id) 
	on delete set null 
	on update cascade,	
 );
   go
 Create Table Преподаватели
 (
	id integer primary key identity(1,1),
	userId int /*foreign key references Пользователи(id) 
	on delete set null 
	on update cascade*/
 )

  go
 Create Table Обучение
 (
	id integer primary key identity(1,1),
	teacherId int foreign key references Пользователи(id)
	on delete set null 
	on update cascade,
	startDate dateTime,
	endDate dateTime,
	registrationNumber int
 )

 go
 Create Table Курсы
 (
	id integer primary key identity(1,1),
	coursName nvarchar(100),
	coursTypeId int foreign key references ВидКурса(id),
	courseVolume int,
	--educationId int foreign key references Обучение(id),
	educationFormId int foreign key references ФормаОбучения(id)
	on delete set null 
	on update cascade,
	startDate dateTime,
	endDate dateTime,
 )


 alter table Обучение
 add constraint Обучение_Курсы_Id coursId int foreign key references Курсы(id)
 on delete set null 
 on update cascade;
 
 
alter table Обучение
add CoursePassed bit ;
 
 alter table Обучение  
add constraint FK_Обучение_teacherId_Пользователи foreign key (teacherId)
references Пользователи(id);