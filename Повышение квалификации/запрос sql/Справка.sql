select 
	U.firstName
	,U.midleName
	,U.lastName
	,L.registrationNumber, 
	L.[startDate], 
	L.[endDate]
	,c.coursName as '�������� �����'
	,c.courseVolume as '����� �����'
	,CT.coursName
	--,ET.educationType
from  ����� as C
Left Join �������� as L
on C.id = L.coursId
left Join �������� CT
on CT.id = C.coursTypeId
left join ������������� as ET
on ET.id = C.educationFormId
left join (select T.id, U.firstName,U.midleName,U.lastName,U.roleId from ������������ U 
			Left join ������������� T
			on t.userId = U.id
			
		   ) as U
on U.id= L.teacherId
where L.id is not null
and U.roleId = (select id from ���� where roleName like '%�������������%')