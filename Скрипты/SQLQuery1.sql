select * from �����������;
select * from ����;
select * from ������������;

select a.*,r.roleName,r.id 
from ������������ u,  ���� r, ����������� a
where u.authId= a.id
and u.roleId=r.id
and a.login='admin'
and a.password='123456'
and r.roleName= '�������������';



alter table ����������� 
add login nvarchar(50) ;




delete from ����������� 
where id>=0
