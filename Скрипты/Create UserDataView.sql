USE Courses;
go
create view UserData
as 
select u.*,a.login,a.password
from [Courses].[dbo].[Пользователи] u
left join [Courses].[dbo].[Авторизация]  a
on u.authId = a.id;