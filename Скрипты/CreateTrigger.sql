USE Courses
GO
CREATE TRIGGER CreateRegistrationNumber
ON ????????
AFTER INSERT
AS
update ????????
set registrationNumber = (
Select id+1000 
from inserted)
where id = (Select id from inserted)

