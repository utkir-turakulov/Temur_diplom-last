/*use Courses
go
Create View CoursesView as
select k.id,k.coursName, k.courseVolume, f.educationType,v.coursName as 'courseTypeName' 
from Курсы k
left join ФормаОбучения f
on k.educationFormId = f.id
left join ВидКурса v
on k.coursTypeId = v.id;
*/
use Courses
go
Create View CoursesView as
select k.id,k.coursName, k.courseVolume, f.educationType,v.coursName as 'courseTypeName',o.startDate, o.endDate 
from Курсы k
left join ФормаОбучения f
on k.educationFormId = f.id
left join ВидКурса v
on k.coursTypeId = v.id
left join Обучение o
on o.coursId = k.id;

use Courses
go
create view CoursePassedView as
select o.id,u.firstName,u.midleName,u.lastName,k.coursName,k.startDate,k.endDate,k.courseVolume,v.coursName as 'coursTypeName', f.educationType from Обучение o
left join Пользователи u
on o.teacherId = u.id
left join Курсы k
on k.id = o.coursId
left join ВидКурса v
on k.coursTypeId = v.id
left join ФормаОбучения f
on f.id = k.educationFormId
where o.coursePassed = 1;


use Courses
go
create view CourseNotPassedView as
select o.id,u.firstName,u.midleName,u.lastName,k.coursName,k.courseVolume,k.startDate,k.endDate,v.coursName as 'coursTypeName', f.educationType from Обучение o
left join Пользователи u
on o.teacherId = u.id
left join Курсы k
on k.id = o.coursId
left join ВидКурса v
on k.coursTypeId = v.id
left join ФормаОбучения f
on f.id = k.educationFormId
where o.coursePassed = 0;

use Courses
go
Create View TeacherCoursesView as
select k.id,k.coursName, k.courseVolume, f.educationType,v.coursName as 'courseTypeName'--,o.teacherId 
from Курсы k
left join ФормаОбучения f
on k.educationFormId = f.id
left join ВидКурса v
on k.coursTypeId = v.id
left join Обучение o
on o.coursId = k.id
where o.teacherId is null;


USE Courses
go
create  view UserData
as 
select u.id,u.firstName,u.midleName,u.lastName,u.dateOfBirth,a.login,a.password,r.roleName
from Пользователи u
left join Авторизация  a
on u.authId = a.id
left join Роли r
on u.roleId = r.id;


create view TeachersView
as 
select id, firstName, midleName, lastName, dateOfBirth  from Пользователи where roleId = 2;