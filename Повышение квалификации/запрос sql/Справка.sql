select 
	U.firstName
	,U.midleName
	,U.lastName
	,L.registrationNumber, 
	L.[startDate], 
	L.[endDate]
	,c.coursName as 'Название курса'
	,c.courseVolume as 'Объем курса'
	,CT.coursName
	--,ET.educationType
from  Курсы as C
Left Join Обучение as L
on C.id = L.coursId
left Join ВидКурса CT
on CT.id = C.coursTypeId
left join ФормаОбучения as ET
on ET.id = C.educationFormId
left join (select T.id, U.firstName,U.midleName,U.lastName,U.roleId from Пользователи U 
			Left join Преподаватели T
			on t.userId = U.id
			
		   ) as U
on U.id= L.teacherId
where L.id is not null
and U.roleId = (select id from Роли where roleName like '%преподаватель%')