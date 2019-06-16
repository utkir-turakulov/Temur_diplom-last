
IF OBJECT_ID ( 'Insert_Education', 'P' ) IS NOT NULL   
    DROP PROCEDURE Insert_Education;  
GO  
create procedure Insert_Education
@teacherId int,
@coursId int,
@coursPassed bit
AS
BEGIN
	insert Обучение(teacherId,coursId,coursePassed)
	values(@teacherId,@coursId,@coursPassed); 
	select scope_identity() as 'id';
END