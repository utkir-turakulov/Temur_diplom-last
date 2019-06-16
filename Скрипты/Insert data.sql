USE Courses 
GO 
INSERT INTO Роли
(roleName) 
VALUES 
(N'администратор'), 
(N'преподаватель'),
(N'методист'),
(N'кадровик') ;

GO
Insert ФормаОбучения
(educationType)
values
(N'очная'),
(N'заочная');

GO
Insert ВидКурса
(coursName)
values
(N'повышение квалификации'),
(N'курс переподготовки'),
(N'курс стажироки');


insert Авторизация(login,password)
values
	 (N'admin','123456'),
	 (N'prepod','123456'),
	 (N'metodist','123456'),
	 (N'kadrovik','123456');


 insert Пользователи(firstname,midleName,lastName,dateOfBirth,authId,roleId)
 values
	 (N'admin',N'admin',N'admin','01.05.1995',1,1),
	 (N'prepod',N'prepod',N'prepod','01.06.1989',2,2),
	 (N'metodist',N'metodist',N'metodist','01.02.1978',3,3),
	 (N'kadrovik',N'kadrovik',N'kadrovik','01.04.1975',4,4)

