INSERT INTO [dbo].[plant]
           ([plant_id]
           ,[plant_name])
     VALUES
           (1
           ,'Test plant')
GO

INSERT INTO [dbo].[station]
           ([station_id]
           ,[plant_id]
           ,[station_name]
           ,[station_acronym])
     VALUES
           (1
           ,1
           ,'Test station for temperature'
           ,'TSFT')
GO

INSERT INTO [dbo].[tag]
           ([station_id]
           ,[measurement_unit]
           ,[tag_name]
           ,[tag_description]
           ,[measurement_interval]
           ,[measurement_interval_unit]
           ,[tag_id])
     VALUES
           (1
           ,'Celsius'
           ,'Temperature sensor'
           ,'Original measurement'
           ,500
           ,'ms'
           ,1)
GO

INSERT INTO [dbo].[tag]
           ([station_id]
           ,[measurement_unit]
           ,[tag_name]
           ,[tag_description]
           ,[measurement_interval]
           ,[measurement_interval_unit]
           ,[tag_id])
     VALUES
           (1
           ,'Fahrenheit'
           ,'Temperature sensor'
           ,'Converted measurement'
           ,500
           ,'ms'
           ,2)
GO

INSERT INTO [dbo].[statistic_data]
           ([statistic_id]
           ,[station_id]
           ,[statistic_unit]
           ,[statistic_description])
     VALUES
           (1
           ,1
           ,'Celsius'
           ,'Average temperature last 30 minutes')
GO

