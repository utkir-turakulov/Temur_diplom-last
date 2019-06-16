use �����_�������;
go
---����������� ��� �������������
create procedure registration(	@log nvarchar(50), 
								@pass nvarchar(50), 
								@firstName nvarchar(50),
								@middleName nvarchar(50),
								@lastName nvarchar(50),
								@dateOfBirth datetime)
as
begin
declare @id int;--id ����������� ������
set @id = ((select id from ����������� where login = @log))	
	if(@id < 0)
		begin

			begin
				insert �����������(login,password)
				values(@log, @pass);
			end;		
		set @id = (SELECT SCOPE_IDENTITY());

		begin
			insert ������������(firstName,midleName,lastName,dateOfBirth,authId,roleId)
			values(@firstName,@middleName,@lastName,@dateOfBirth,@id,2);
		end;
	end
	else 
		begin
			RAISERROR('������ ��� ���� � �������',10,10);
			
		end;

end;

---����� ��������� ��������
begin 
declare @time datetime;
set @time = (select convert(datetime , '01.01.1989') );

execute registration @log = 'bilbo',
					@pass = '123456',
					@firstName = 'Bilbo',
					@middleName = 'Baggins',
					@lastName = 'Longfoot',  
					@dateOfBirth = @time;
end;


---------����������� ��� ��������������
create procedure registrationByAdmin(@log nvarchar(50), 
								@pass nvarchar(50), 
								@firstName nvarchar(50),
								@middleName nvarchar(50),
								@lastName nvarchar(50),
								@dateOfBirth datetime,
								@role int)
as
begin
declare @id int;--id ����������� ������
set @id = ((select id from ����������� where login = @log))	
	if(@id < 0)
		begin

			begin
				insert �����������(login,password)
				values(@log, @pass);
			end;		
		set @id = (SELECT SCOPE_IDENTITY());

		begin
			insert ������������(firstName,midleName,lastName,dateOfBirth,authId,roleId)
			values(@firstName,@middleName,@lastName,@dateOfBirth,@id,@role);
		end;
	end
	else
		RAISERROR('������ ��� ���� � �������',10,10);
end;


---����� ��������� �������
begin 
declare @time datetime;
set @time = (select convert(datetime , '01.01.1989') );

execute registrationByAdmin @log = 'admin2',
					@pass = '123456',
					@firstName = 'Marry',
					@middleName = 'Pippin',
					@lastName = 'Carrotson',  
					@dateOfBirth = @time,
					@role = 3;
end;




begin
declare @id int;
set @id = (select id from ����������� where login = 'admin')
set @id = @id+1;
print(@id);
end ;




begin
declare @id int;
insert �����������(login,password)
values(@log, @pass);		
set @id = (SELECT SCOPE_IDENTITY());
insert ������������(firstName,midleName,lastName,dateOfBirth,authId,roleId)
end;



begin
                                declare @id int;
                                insert �����������(login,password)
                                values('1', '1');		
                                set @id = (SELECT SCOPE_IDENTITY());
                                insert ������������(firstName,midleName,lastName,dateOfBirth,authId,roleId)
                                values('1','1','1','01.02.2015 01:12 ',@id,2);        
                                end;