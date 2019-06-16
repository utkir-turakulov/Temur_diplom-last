/*USE [master]
GO
/****** Object:  Database [Courses]    Script Date: 30.05.2019 23:23:25 ******/
/*CREATE DATABASE [Courses]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Courses', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Courses.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Courses_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Courses_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
*/

ALTER DATABASE [Courses] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Courses].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Courses] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Courses] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Courses] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Courses] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Courses] SET ARITHABORT OFF 
GO
ALTER DATABASE [Courses] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Courses] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Courses] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Courses] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Courses] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Courses] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Courses] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Courses] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Courses] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Courses] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Courses] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Courses] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Courses] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Courses] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Courses] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Courses] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Courses] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Courses] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Courses] SET  MULTI_USER 
GO
ALTER DATABASE [Courses] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Courses] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Courses] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Courses] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Courses] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Courses] SET QUERY_STORE = OFF
GO
USE [Courses]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [Courses]
GO
/****** Object:  Table [dbo].[Пользователи]    Script Date: 30.05.2019 23:23:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Пользователи](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[firstName] [nvarchar](50) NULL,
	[midleName] [nvarchar](50) NULL,
	[lastName] [nvarchar](50) NULL,
	[dateOfBirth] [datetime] NULL,
	[authId] [int] NULL,
	[roleId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Обучение]    Script Date: 30.05.2019 23:23:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Обучение](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[teacherId] [int] NULL,
	[startDate] [datetime] NULL,
	[endDate] [datetime] NULL,
	[registrationNumber] [int] NULL,
	[coursId] [int] NULL,
	[CoursePassed] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Курсы]    Script Date: 30.05.2019 23:23:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Курсы](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[coursName] [nvarchar](100) NULL,
	[coursTypeId] [int] NULL,
	[courseVolume] [int] NULL,
	[educationFormId] [int] NULL,
	[startDate] [datetime] NULL,
	[endDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[CourseNotPassedView]    Script Date: 30.05.2019 23:23:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[CourseNotPassedView] as
select o.id,u.firstName,u.midleName,u.lastName,k.coursName,k.courseVolume,k.startDate,k.endDate from Обучение o
left join Пользователи u
on o.teacherId = u.id
left join Курсы k
on k.id = o.coursId
where o.coursePassed = 0;
GO
/****** Object:  View [dbo].[CoursePassedView]    Script Date: 30.05.2019 23:23:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[CoursePassedView] as
select o.id,u.firstName,u.midleName,u.lastName,k.coursName,k.startDate,k.endDate,k.courseVolume from Обучение o
left join Пользователи u
on o.teacherId = u.id
left join Курсы k
on k.id = o.coursId
where o.coursePassed = 1;
GO
/****** Object:  Table [dbo].[ВидКурса]    Script Date: 30.05.2019 23:23:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ВидКурса](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[coursName] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ФормаОбучения]    Script Date: 30.05.2019 23:23:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ФормаОбучения](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[educationType] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[TeacherCoursesView]    Script Date: 30.05.2019 23:23:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create View [dbo].[TeacherCoursesView] as
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
/****** Object:  Table [dbo].[Роли]    Script Date: 30.05.2019 23:23:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Роли](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[roleName] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Авторизация]    Script Date: 30.05.2019 23:23:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Авторизация](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[login] [nvarchar](50) NULL,
	[password] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[UserData]    Script Date: 30.05.2019 23:23:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create  view [dbo].[UserData]
as 
select u.id,u.firstName,u.midleName,u.lastName,u.dateOfBirth,a.login,a.password,r.roleName
from Пользователи u
left join Авторизация  a
on u.authId = a.id
left join Роли r
on u.roleId = r.id;
GO
/****** Object:  View [dbo].[CoursesView]    Script Date: 30.05.2019 23:23:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create View [dbo].[CoursesView] as
select k.id,k.coursName, k.courseVolume, f.educationType,v.coursName as 'courseTypeName',k.startDate, k.endDate 
from Курсы k
left join ФормаОбучения f
on k.educationFormId = f.id
left join ВидКурса v
on k.coursTypeId = v.id;
GO
/****** Object:  Table [dbo].[Преподаватели]    Script Date: 30.05.2019 23:23:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Преподаватели](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[userId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Курсы]  WITH CHECK ADD FOREIGN KEY([coursTypeId])
REFERENCES [dbo].[ВидКурса] ([id])
GO
ALTER TABLE [dbo].[Курсы]  WITH CHECK ADD FOREIGN KEY([educationFormId])
REFERENCES [dbo].[ФормаОбучения] ([id])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Обучение]  WITH CHECK ADD FOREIGN KEY([coursId])
REFERENCES [dbo].[Курсы] ([id])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Обучение]  WITH CHECK ADD  CONSTRAINT [FK_Обучение_teacherId_Пользователи] FOREIGN KEY([teacherId])
REFERENCES [dbo].[Пользователи] ([id])
GO
ALTER TABLE [dbo].[Обучение] CHECK CONSTRAINT [FK_Обучение_teacherId_Пользователи]
GO
ALTER TABLE [dbo].[Пользователи]  WITH CHECK ADD  CONSTRAINT [FK_ПользователиАвторизация] FOREIGN KEY([authId])
REFERENCES [dbo].[Авторизация] ([id])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Пользователи] CHECK CONSTRAINT [FK_ПользователиАвторизация]
GO
ALTER TABLE [dbo].[Пользователи]  WITH CHECK ADD  CONSTRAINT [FK_ПользователиРоли] FOREIGN KEY([roleId])
REFERENCES [dbo].[Роли] ([id])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Пользователи] CHECK CONSTRAINT [FK_ПользователиРоли]
GO
USE [master]
GO
ALTER DATABASE [Courses] SET  READ_WRITE 
GO
