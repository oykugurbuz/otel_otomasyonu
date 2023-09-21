USE [GURBUZHOTEL]
GO

INSERT INTO [dbo].[Customer]
           ([full_name]
           ,[identy_number]
           ,[email]
           ,[phone]
           ,[gender]
           ,[birthdate]
           ,[room_number]
           ,[price]
           ,[check_in]
           ,[check_out])
     VALUES
           (<full_name, nvarchar(50),>
           ,<identy_number, nvarchar(50),>
           ,<email, nvarchar(50),>
           ,<phone, nvarchar(50),>
           ,<gender, nvarchar(50),>
           ,<birthdate, datetime,>
           ,<room_number, nvarchar(50),>
           ,<price, int,>
           ,<check_in, datetime,>
           ,<check_out, datetime,>)
GO


