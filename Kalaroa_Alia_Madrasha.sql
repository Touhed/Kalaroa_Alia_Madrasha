USE [master]
GO
/****** Object:  Database [Kalaroa_Alia_Madrasha]    Script Date: 5/29/2019 11:12:31 AM ******/
CREATE DATABASE [Kalaroa_Alia_Madrasha]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Kalaroa_Alia_Madrasha', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\Kalaroa_Alia_Madrasha.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Kalaroa_Alia_Madrasha_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\Kalaroa_Alia_Madrasha_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Kalaroa_Alia_Madrasha] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Kalaroa_Alia_Madrasha].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Kalaroa_Alia_Madrasha] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Kalaroa_Alia_Madrasha] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Kalaroa_Alia_Madrasha] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Kalaroa_Alia_Madrasha] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Kalaroa_Alia_Madrasha] SET ARITHABORT OFF 
GO
ALTER DATABASE [Kalaroa_Alia_Madrasha] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Kalaroa_Alia_Madrasha] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [Kalaroa_Alia_Madrasha] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Kalaroa_Alia_Madrasha] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Kalaroa_Alia_Madrasha] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Kalaroa_Alia_Madrasha] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Kalaroa_Alia_Madrasha] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Kalaroa_Alia_Madrasha] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Kalaroa_Alia_Madrasha] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Kalaroa_Alia_Madrasha] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Kalaroa_Alia_Madrasha] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Kalaroa_Alia_Madrasha] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Kalaroa_Alia_Madrasha] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Kalaroa_Alia_Madrasha] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Kalaroa_Alia_Madrasha] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Kalaroa_Alia_Madrasha] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Kalaroa_Alia_Madrasha] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Kalaroa_Alia_Madrasha] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Kalaroa_Alia_Madrasha] SET RECOVERY FULL 
GO
ALTER DATABASE [Kalaroa_Alia_Madrasha] SET  MULTI_USER 
GO
ALTER DATABASE [Kalaroa_Alia_Madrasha] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Kalaroa_Alia_Madrasha] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Kalaroa_Alia_Madrasha] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Kalaroa_Alia_Madrasha] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
USE [Kalaroa_Alia_Madrasha]
GO
/****** Object:  User [touhed]    Script Date: 5/29/2019 11:12:31 AM ******/
CREATE USER [touhed] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [touhed]
GO
/****** Object:  Table [dbo].[Actor]    Script Date: 5/29/2019 11:12:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Actor](
	[UserId] [bigint] IDENTITY(1,1) NOT NULL,
	[UserType] [nvarchar](50) NULL,
 CONSTRAINT [PK_Actor] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Admin]    Script Date: 5/29/2019 11:12:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin](
	[AdminId] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Contact] [nvarchar](50) NOT NULL,
	[Photo] [nvarchar](50) NULL,
 CONSTRAINT [PK_Admins] PRIMARY KEY CLUSTERED 
(
	[AdminId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Admission]    Script Date: 5/29/2019 11:12:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admission](
	[AdmissionId] [bigint] IDENTITY(1,1) NOT NULL,
	[AdmissionFees] [bigint] NULL,
	[LibraryFee] [bigint] NULL,
	[LaboratoryFee] [bigint] NULL,
	[FixedAmount] [bigint] NOT NULL,
	[PayAmount] [bigint] NULL,
	[StudentId] [bigint] NULL,
	[PaymentStatus] [bigint] NULL,
 CONSTRAINT [PK_Admission] PRIMARY KEY CLUSTERED 
(
	[AdmissionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Result]    Script Date: 5/29/2019 11:12:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Result](
	[SN] [bigint] IDENTITY(1,1) NOT NULL,
	[StudentId] [bigint] NOT NULL,
	[StudentName] [nvarchar](50) NOT NULL,
	[ExamType] [nvarchar](50) NOT NULL,
	[Subject] [nvarchar](50) NOT NULL,
	[Marks] [bigint] NOT NULL,
	[SDepartment] [nvarchar](50) NULL,
	[StSession] [nvarchar](50) NULL,
	[SClass] [nvarchar](50) NULL,
 CONSTRAINT [PK_Result] PRIMARY KEY CLUSTERED 
(
	[SN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Student]    Script Date: 5/29/2019 11:12:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[StudentId] [bigint] IDENTITY(1,1) NOT NULL,
	[StudentName] [nvarchar](50) NOT NULL,
	[FatherName] [nvarchar](50) NOT NULL,
	[MotherName] [nvarchar](50) NOT NULL,
	[Department] [nvarchar](50) NOT NULL,
	[Class] [nvarchar](50) NOT NULL,
	[Section] [nvarchar](50) NULL,
	[Scholarship] [nvarchar](50) NULL,
	[Session] [nvarchar](50) NOT NULL,
	[Nationality] [nvarchar](50) NULL,
	[DOB] [date] NULL,
	[Gender] [text] NULL,
	[PresentAddress] [nvarchar](50) NULL,
	[PermanentAddress] [nvarchar](50) NOT NULL,
	[Contact] [bigint] NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Photo] [nvarchar](50) NULL,
 CONSTRAINT [PK_StudentInfo1] PRIMARY KEY CLUSTERED 
(
	[StudentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[StudentAccount]    Script Date: 5/29/2019 11:12:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentAccount](
	[StudentId] [bigint] IDENTITY(1,1) NOT NULL,
	[StudentName] [nvarchar](50) NOT NULL,
	[PaymentStatus] [bigint] NULL,
 CONSTRAINT [PK_StudentAccount] PRIMARY KEY CLUSTERED 
(
	[StudentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[StudentPayment]    Script Date: 5/29/2019 11:12:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentPayment](
	[PaymentId] [bigint] IDENTITY(1,1) NOT NULL,
	[StudentId] [bigint] NULL,
	[Month] [nvarchar](50) NOT NULL,
	[Year] [nvarchar](50) NOT NULL,
	[TuitionFee] [bigint] NULL,
	[ExtraFeeCategory] [nvarchar](50) NULL,
	[ExtraFee] [bigint] NULL,
	[PaymentDate] [date] NULL,
	[TotalAmount] [bigint] NOT NULL,
	[SPayAmount] [bigint] NULL,
	[PaymentStatus] [bigint] NULL,
 CONSTRAINT [PK_Payment] PRIMARY KEY CLUSTERED 
(
	[PaymentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Teacher]    Script Date: 5/29/2019 11:12:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teacher](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Designation] [nvarchar](50) NOT NULL,
	[Contact] [nvarchar](50) NOT NULL,
	[Address] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Photo] [nvarchar](50) NULL,
 CONSTRAINT [PK_Facultys] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TeacherAccount]    Script Date: 5/29/2019 11:12:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TeacherAccount](
	[AccNo] [bigint] IDENTITY(1,1) NOT NULL,
	[TeacherId] [bigint] NOT NULL,
	[TeacherName] [nvarchar](50) NOT NULL,
	[TeacherType] [nvarchar](50) NOT NULL,
	[TeacherGread] [nvarchar](50) NOT NULL,
	[BasicSalary] [nvarchar](50) NOT NULL,
	[Month] [nvarchar](50) NOT NULL,
	[Year] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Faculty_Account_1] PRIMARY KEY CLUSTERED 
(
	[AccNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Users]    Script Date: 5/29/2019 11:12:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[LoginId] [bigint] IDENTITY(1,1) NOT NULL,
	[UserId] [bigint] NOT NULL,
	[UserType] [nvarchar](50) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[LoginId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Actor] ON 

INSERT [dbo].[Actor] ([UserId], [UserType]) VALUES (1, N'Admin')
INSERT [dbo].[Actor] ([UserId], [UserType]) VALUES (2, N'Teacher')
INSERT [dbo].[Actor] ([UserId], [UserType]) VALUES (3, N'Student')
INSERT [dbo].[Actor] ([UserId], [UserType]) VALUES (4, N'Account')
SET IDENTITY_INSERT [dbo].[Actor] OFF
SET IDENTITY_INSERT [dbo].[Admin] ON 

INSERT [dbo].[Admin] ([AdminId], [Name], [Email], [Contact], [Photo]) VALUES (1, N'Touhedur Rahman', N'touhedurrahman7@gmail.com', N'01775396637', N'alone-with-his-thoughts-1080x720.jpg')
SET IDENTITY_INSERT [dbo].[Admin] OFF
SET IDENTITY_INSERT [dbo].[Admission] ON 

INSERT [dbo].[Admission] ([AdmissionId], [AdmissionFees], [LibraryFee], [LaboratoryFee], [FixedAmount], [PayAmount], [StudentId], [PaymentStatus]) VALUES (12, 5000, 2000, 2000, 9000, 9000, 2, 0)
INSERT [dbo].[Admission] ([AdmissionId], [AdmissionFees], [LibraryFee], [LaboratoryFee], [FixedAmount], [PayAmount], [StudentId], [PaymentStatus]) VALUES (13, 5000, 2000, 2000, 9000, 9000, 3, 0)
INSERT [dbo].[Admission] ([AdmissionId], [AdmissionFees], [LibraryFee], [LaboratoryFee], [FixedAmount], [PayAmount], [StudentId], [PaymentStatus]) VALUES (14, 5000, 2000, 2000, 9000, 9000, 4, 0)
SET IDENTITY_INSERT [dbo].[Admission] OFF
SET IDENTITY_INSERT [dbo].[Student] ON 

INSERT [dbo].[Student] ([StudentId], [StudentName], [FatherName], [MotherName], [Department], [Class], [Section], [Scholarship], [Session], [Nationality], [DOB], [Gender], [PresentAddress], [PermanentAddress], [Contact], [Email], [Photo]) VALUES (1, N'afd', N'asd', N'dsf', N'Arts', N'2', N'a', N'0%', N'2019', N'BD', CAST(0x9B3F0B00 AS Date), N'Male', N'afafdfggg', N'fgsgfgdsgs', 1234568987, N'student1@gmail.com', NULL)
SET IDENTITY_INSERT [dbo].[Student] OFF
SET IDENTITY_INSERT [dbo].[Teacher] ON 

INSERT [dbo].[Teacher] ([Id], [Name], [Designation], [Contact], [Address], [Email], [Photo]) VALUES (2, N'ab', N'Lecturer', N'21321351113131', N'uttara', N'ab@gmail.com', NULL)
SET IDENTITY_INSERT [dbo].[Teacher] OFF
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([LoginId], [UserId], [UserType], [FirstName], [LastName], [Email], [Password]) VALUES (1, 1, N'Admin', N'Touhedur', N'Rahman', N'rtouhedur@gmail.com', N'17103081')
INSERT [dbo].[Users] ([LoginId], [UserId], [UserType], [FirstName], [LastName], [Email], [Password]) VALUES (2, 2, N'Teacher', N'a', N'b', N'ab@gmail.com', N't')
INSERT [dbo].[Users] ([LoginId], [UserId], [UserType], [FirstName], [LastName], [Email], [Password]) VALUES (3, 3, N'Student', N'aa', N'bb', N'aabb@gmail.com', N's')
INSERT [dbo].[Users] ([LoginId], [UserId], [UserType], [FirstName], [LastName], [Email], [Password]) VALUES (4, 4, N'Account', N'acc', N'ount', N'Accountant@gmail.com', N'acc')
SET IDENTITY_INSERT [dbo].[Users] OFF
ALTER TABLE [dbo].[Result]  WITH CHECK ADD  CONSTRAINT [FK_Result_Student] FOREIGN KEY([StudentId])
REFERENCES [dbo].[Student] ([StudentId])
GO
ALTER TABLE [dbo].[Result] CHECK CONSTRAINT [FK_Result_Student]
GO
ALTER TABLE [dbo].[StudentPayment]  WITH CHECK ADD  CONSTRAINT [FK_StudentPayment_StudentAccount] FOREIGN KEY([StudentId])
REFERENCES [dbo].[StudentAccount] ([StudentId])
GO
ALTER TABLE [dbo].[StudentPayment] CHECK CONSTRAINT [FK_StudentPayment_StudentAccount]
GO
ALTER TABLE [dbo].[TeacherAccount]  WITH CHECK ADD  CONSTRAINT [FK_TeacherAccount_Teacher] FOREIGN KEY([TeacherId])
REFERENCES [dbo].[Teacher] ([Id])
GO
ALTER TABLE [dbo].[TeacherAccount] CHECK CONSTRAINT [FK_TeacherAccount_Teacher]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Actor] FOREIGN KEY([UserId])
REFERENCES [dbo].[Actor] ([UserId])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Actor]
GO
USE [master]
GO
ALTER DATABASE [Kalaroa_Alia_Madrasha] SET  READ_WRITE 
GO
