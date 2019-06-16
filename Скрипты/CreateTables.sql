use master
go
CREATE DATABASE Courses;

use Coures;
go
 Create Table ����
 (
 id integer primary key identity(1,1),
 roleName nvarchar(50)
 
 )

 go
 Create Table ��������
 (
	id integer primary key identity(1,1),
	coursName nvarchar(50)
 )

 go
 Create Table �����������
 (
	id integer primary key identity(1,1),
	login nvarchar(50),
	password nvarchar(50)
 )

 go
 Create Table �������������
 (
	id integer primary key identity(1,1),
	educationType nvarchar(20)
 );



 go
 Create Table ������������
 (
	id integer primary key identity(1,1),
	firstName nvarchar(50),
	midleName nvarchar(50),
	lastName nvarchar(50),
	dateOfBirth dateTime,
	authId int,
	roleId int,
	constraint FK_����������������������� 
	foreign key (authId) references �����������(id) 
	on delete set null 
	on update cascade,
	constraint FK_���������������� foreign key(roleId)
	references ����(id) 
	on delete set null 
	on update cascade,	
 );
   go
 Create Table �������������
 (
	id integer primary key identity(1,1),
	userId int /*foreign key references ������������(id) 
	on delete set null 
	on update cascade*/
 )

  go
 Create Table ��������
 (
	id integer primary key identity(1,1),
	teacherId int foreign key references ������������(id)
	on delete set null 
	on update cascade,
	startDate dateTime,
	endDate dateTime,
	registrationNumber int
 )

 go
 Create Table �����
 (
	id integer primary key identity(1,1),
	coursName nvarchar(100),
	coursTypeId int foreign key references ��������(id),
	courseVolume int,
	--educationId int foreign key references ��������(id),
	educationFormId int foreign key references �������������(id)
	on delete set null 
	on update cascade,
	startDate dateTime,
	endDate dateTime,
 )


 alter table ��������
 add constraint ��������_�����_Id coursId int foreign key references �����(id)
 on delete set null 
 on update cascade;
 
 
alter table ��������
add CoursePassed bit ;
 
 alter table ��������  
add constraint FK_��������_teacherId_������������ foreign key (teacherId)
references ������������(id);