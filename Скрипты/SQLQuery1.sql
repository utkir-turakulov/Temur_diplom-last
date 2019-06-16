select * from Авторизация;
select * from Роли;
select * from Пользователи;

select a.*,r.roleName,r.id 
from Пользователи u,  Роли r, Авторизация a
where u.authId= a.id
and u.roleId=r.id
and a.login='admin'
and a.password='123456'
and r.roleName= 'администратор';



alter table Авторизация 
add login nvarchar(50) ;




delete from Авторизация 
where id>=0
