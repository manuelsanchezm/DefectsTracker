USE [defects_tracker]
GO

INSERT INTO [dbo].[defect]
           ([defect_title]
           ,[description]
           ,[defect_type]
           ,[defect_priority]
           ,[assigned_user]
           ,[reported_user]
           ,[created_date]
           ,[modified_date])
     VALUES
           ('Creating defect does not work', NULL, 1, 1, NULL, 1, '2018-01-01T11:50:00AM', '2018-01-01T11:50:00AM');

INSERT INTO [dbo].[defect]
           ([defect_title]
           ,[description]
           ,[defect_type]
           ,[defect_priority]
           ,[assigned_user]
           ,[reported_user]
           ,[created_date]
           ,[modified_date])
     VALUES
           ('Saving new defect does not work', NULL, 1, 1, NULL, 1, '2018-10-11T09:20:00AM', '2018-10-11T09:20:00AM');
GO

