/*
Скрипт развертывания для silverha_vpn06

Этот код был создан программным средством.
Изменения, внесенные в этот файл, могут привести к неверному выполнению кода и будут потеряны
в случае его повторного формирования.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "silverha_vpn06"
:setvar DefaultFilePrefix "silverha_vpn06"
:setvar DefaultDataPath "D:\SQL_Data\"
:setvar DefaultLogPath "D:\SQL_Data\"

GO
:on error exit
GO
/*
Проверьте режим SQLCMD и отключите выполнение скрипта, если режим SQLCMD не поддерживается.
Чтобы повторно включить скрипт после включения режима SQLCMD выполните следующую инструкцию:
SET NOEXEC OFF; 
*/
:setvar __IsSqlCmdEnabled "True"
GO
IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'Для успешного выполнения этого скрипта должен быть включен режим SQLCMD.';
        SET NOEXEC ON;
    END


GO
USE [$(DatabaseName)];


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET AUTO_CLOSE ON 
            WITH ROLLBACK IMMEDIATE;
    END


GO
ALTER DATABASE [$(DatabaseName)]
    SET TARGET_RECOVERY_TIME = 60 SECONDS 
    WITH ROLLBACK IMMEDIATE;


GO
PRINT N'Выполняется создание [dbo].[Авторизация]...';


GO
CREATE TABLE [dbo].[Авторизация] (
    [id]       INT           IDENTITY (1, 1) NOT NULL,
    [login]    NVARCHAR (50) NULL,
    [password] NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);


GO
PRINT N'Выполняется создание [dbo].[ВидКурса]...';


GO
CREATE TABLE [dbo].[ВидКурса] (
    [id]        INT           IDENTITY (1, 1) NOT NULL,
    [coursName] NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);


GO
PRINT N'Выполняется создание [dbo].[Курсы]...';


GO
CREATE TABLE [dbo].[Курсы] (
    [id]              INT            IDENTITY (1, 1) NOT NULL,
    [coursName]       NVARCHAR (100) NULL,
    [coursTypeId]     INT            NULL,
    [courseVolume]    INT            NULL,
    [educationFormId] INT            NULL,
    [startDate]       DATETIME       NULL,
    [endDate]         DATETIME       NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);


GO
PRINT N'Выполняется создание [dbo].[Обучение]...';


GO
CREATE TABLE [dbo].[Обучение] (
    [id]                 INT      IDENTITY (1, 1) NOT NULL,
    [teacherId]          INT      NULL,
    [startDate]          DATETIME NULL,
    [endDate]            DATETIME NULL,
    [registrationNumber] INT      NULL,
    [coursId]            INT      NULL,
    [CoursePassed]       BIT      NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);


GO
PRINT N'Выполняется создание [dbo].[Пользователи]...';


GO
CREATE TABLE [dbo].[Пользователи] (
    [id]          INT           IDENTITY (1, 1) NOT NULL,
    [firstName]   NVARCHAR (50) NULL,
    [midleName]   NVARCHAR (50) NULL,
    [lastName]    NVARCHAR (50) NULL,
    [dateOfBirth] DATETIME      NULL,
    [authId]      INT           NULL,
    [roleId]      INT           NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);


GO
PRINT N'Выполняется создание [dbo].[Преподаватели]...';


GO
CREATE TABLE [dbo].[Преподаватели] (
    [id]     INT IDENTITY (1, 1) NOT NULL,
    [userId] INT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);


GO
PRINT N'Выполняется создание [dbo].[Роли]...';


GO
CREATE TABLE [dbo].[Роли] (
    [id]       INT           IDENTITY (1, 1) NOT NULL,
    [roleName] NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);


GO
PRINT N'Выполняется создание [dbo].[ФормаОбучения]...';


GO
CREATE TABLE [dbo].[ФормаОбучения] (
    [id]            INT           IDENTITY (1, 1) NOT NULL,
    [educationType] NVARCHAR (20) NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);


GO
PRINT N'Выполняется создание ограничение без названия для [dbo].[Курсы]...';


GO
ALTER TABLE [dbo].[Курсы] WITH NOCHECK
    ADD FOREIGN KEY ([coursTypeId]) REFERENCES [dbo].[ВидКурса] ([id]);


GO
PRINT N'Выполняется создание ограничение без названия для [dbo].[Курсы]...';


GO
ALTER TABLE [dbo].[Курсы] WITH NOCHECK
    ADD FOREIGN KEY ([educationFormId]) REFERENCES [dbo].[ФормаОбучения] ([id]) ON DELETE SET NULL ON UPDATE CASCADE;


GO
PRINT N'Выполняется создание ограничение без названия для [dbo].[Обучение]...';


GO
ALTER TABLE [dbo].[Обучение] WITH NOCHECK
    ADD FOREIGN KEY ([coursId]) REFERENCES [dbo].[Курсы] ([id]) ON DELETE SET NULL ON UPDATE CASCADE;


GO
PRINT N'Выполняется создание [dbo].[FK_Обучение_teacherId_Пользователи]...';


GO
ALTER TABLE [dbo].[Обучение] WITH NOCHECK
    ADD CONSTRAINT [FK_Обучение_teacherId_Пользователи] FOREIGN KEY ([teacherId]) REFERENCES [dbo].[Пользователи] ([id]);


GO
PRINT N'Выполняется создание [dbo].[FK_ПользователиАвторизация]...';


GO
ALTER TABLE [dbo].[Пользователи] WITH NOCHECK
    ADD CONSTRAINT [FK_ПользователиАвторизация] FOREIGN KEY ([authId]) REFERENCES [dbo].[Авторизация] ([id]) ON DELETE SET NULL ON UPDATE CASCADE;


GO
PRINT N'Выполняется создание [dbo].[FK_ПользователиРоли]...';


GO
ALTER TABLE [dbo].[Пользователи] WITH NOCHECK
    ADD CONSTRAINT [FK_ПользователиРоли] FOREIGN KEY ([roleId]) REFERENCES [dbo].[Роли] ([id]) ON DELETE SET NULL ON UPDATE CASCADE;


GO
PRINT N'Выполняется создание [dbo].[CreateRegistrationNumber]...';


GO
CREATE TRIGGER CreateRegistrationNumber
ON Обучение
AFTER INSERT
AS
update Обучение
set registrationNumber = (
Select id+1000 
from inserted)
where id = (Select id from inserted)
GO
PRINT N'Выполняется создание [dbo].[CourseNotPassedView]...';


GO
create view CourseNotPassedView as
select o.id,u.firstName,u.midleName,u.lastName,k.coursName,k.courseVolume,k.startDate,k.endDate from Обучение o
left join Пользователи u
on o.teacherId = u.id
left join Курсы k
on k.id = o.coursId
where o.coursePassed = 0;
GO
PRINT N'Выполняется создание [dbo].[CoursePassedView]...';


GO
create view CoursePassedView as
select o.id,u.firstName,u.midleName,u.lastName,k.coursName,k.startDate,k.endDate,k.courseVolume from Обучение o
left join Пользователи u
on o.teacherId = u.id
left join Курсы k
on k.id = o.coursId
where o.coursePassed = 1;
GO
PRINT N'Выполняется создание [dbo].[CoursesView]...';


GO
Create View CoursesView as
select k.id,k.coursName, k.courseVolume, f.educationType,v.coursName as 'courseTypeName',k.startDate, k.endDate 
from Курсы k
left join ФормаОбучения f
on k.educationFormId = f.id
left join ВидКурса v
on k.coursTypeId = v.id;
GO
PRINT N'Выполняется создание [dbo].[TeacherCoursesView]...';


GO
Create View TeacherCoursesView as
select k.id,k.coursName, k.courseVolume, f.educationType,v.coursName as 'courseTypeName',o.teacherId 
from Курсы k
left join ФормаОбучения f
on k.educationFormId = f.id
left join ВидКурса v
on k.coursTypeId = v.id
left join Обучение o
on o.coursId = k.id
where o.teacherId is null;
GO
PRINT N'Выполняется создание [dbo].[UserData]...';


GO
create  view UserData
as 
select u.id,u.firstName,u.midleName,u.lastName,u.dateOfBirth,a.login,a.password,r.roleName
from Пользователи u
left join Авторизация  a
on u.authId = a.id
left join Роли r
on u.roleId = r.id;
GO
PRINT N'Выполняется создание Разрешение...';


GO
GRANT VIEW ANY COLUMN ENCRYPTION KEY DEFINITION TO PUBLIC;


GO
PRINT N'Выполняется создание Разрешение...';


GO
GRANT VIEW ANY COLUMN MASTER KEY DEFINITION TO PUBLIC;


GO
PRINT N'Существующие данные проверяются относительно вновь созданных ограничений';


GO
USE [$(DatabaseName)];


GO
ALTER TABLE [dbo].[Пользователи] WITH CHECK CHECK CONSTRAINT [FK_ПользователиАвторизация];

ALTER TABLE [dbo].[Пользователи] WITH CHECK CHECK CONSTRAINT [FK_ПользователиРоли];


GO
CREATE TABLE [#__checkStatus] (
    id           INT            IDENTITY (1, 1) PRIMARY KEY CLUSTERED,
    [Schema]     NVARCHAR (256),
    [Table]      NVARCHAR (256),
    [Constraint] NVARCHAR (256)
);

SET NOCOUNT ON;

DECLARE tableconstraintnames CURSOR LOCAL FORWARD_ONLY
    FOR SELECT SCHEMA_NAME([schema_id]),
               OBJECT_NAME([parent_object_id]),
               [name],
               0
        FROM   [sys].[objects]
        WHERE  [parent_object_id] IN (OBJECT_ID(N'dbo.Курсы'), OBJECT_ID(N'dbo.Обучение'))
               AND [type] IN (N'F', N'C')
                   AND [object_id] IN (SELECT [object_id]
                                       FROM   [sys].[check_constraints]
                                       WHERE  [is_not_trusted] <> 0
                                              AND [is_disabled] = 0
                                       UNION
                                       SELECT [object_id]
                                       FROM   [sys].[foreign_keys]
                                       WHERE  [is_not_trusted] <> 0
                                              AND [is_disabled] = 0);

DECLARE @schemaname AS NVARCHAR (256);

DECLARE @tablename AS NVARCHAR (256);

DECLARE @checkname AS NVARCHAR (256);

DECLARE @is_not_trusted AS INT;

DECLARE @statement AS NVARCHAR (1024);

BEGIN TRY
    OPEN tableconstraintnames;
    FETCH tableconstraintnames INTO @schemaname, @tablename, @checkname, @is_not_trusted;
    WHILE @@fetch_status = 0
        BEGIN
            PRINT N'Проверка ограничения: ' + @checkname + N' [' + @schemaname + N'].[' + @tablename + N']';
            SET @statement = N'ALTER TABLE [' + @schemaname + N'].[' + @tablename + N'] WITH ' + CASE @is_not_trusted WHEN 0 THEN N'CHECK' ELSE N'NOCHECK' END + N' CHECK CONSTRAINT [' + @checkname + N']';
            BEGIN TRY
                EXECUTE [sp_executesql] @statement;
            END TRY
            BEGIN CATCH
                INSERT  [#__checkStatus] ([Schema], [Table], [Constraint])
                VALUES                  (@schemaname, @tablename, @checkname);
            END CATCH
            FETCH tableconstraintnames INTO @schemaname, @tablename, @checkname, @is_not_trusted;
        END
END TRY
BEGIN CATCH
    PRINT ERROR_MESSAGE();
END CATCH

IF CURSOR_STATUS(N'LOCAL', N'tableconstraintnames') >= 0
    CLOSE tableconstraintnames;

IF CURSOR_STATUS(N'LOCAL', N'tableconstraintnames') = -1
    DEALLOCATE tableconstraintnames;

SELECT N'Ошибка при проверке ограничения:' + [Schema] + N'.' + [Table] + N',' + [Constraint]
FROM   [#__checkStatus];

IF @@ROWCOUNT > 0
    BEGIN
        DROP TABLE [#__checkStatus];
        RAISERROR (N'Произошла ошибка при проверке ограничений', 16, 127);
    END

SET NOCOUNT OFF;

DROP TABLE [#__checkStatus];


GO
PRINT N'Обновление завершено.';


GO
