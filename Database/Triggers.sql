IF EXISTS (SELECT name
			FROM sysobjects
			WHERE name = 'CelsiusToFahrenheit' 
			AND type = 'TR')
		DROP TRIGGER CelsiusToFahrenheit
GO

CREATE TRIGGER CelsiusToFahrenheit ON measurement
FOR INSERT
AS

DECLARE
@tag_id float,
@measurement_value float,
@measurement_timestamp datetime

select @tag_id = tag_id from INSERTED
select @measurement_value = (measurement_value*1.8)+32 from INSERTED
select @measurement_timestamp = timestamp from INSERTED

IF @tag_id LIKE 1
	INSERT INTO [dbo].[measurement]
			   ([tag_id]
			   ,[timestamp]
			   ,[measurement_value])
		 VALUES
			   (2
			   ,@measurement_timestamp
			   ,@measurement_value)
GO

IF EXISTS (SELECT name
			FROM sysobjects
			WHERE name = 'FahrenheitToCelsius' 
			AND type = 'TR')
		DROP TRIGGER FahrenheitToCelsius
GO

CREATE TRIGGER FahrenheitToCelsius ON measurement
FOR INSERT
AS

DECLARE
@tag_id float,
@measurement_value float,
@measurement_timestamp datetime

select @tag_id = tag_id from INSERTED
select @measurement_value = (measurement_value-32)/1.8 from INSERTED
select @measurement_timestamp = timestamp from INSERTED

IF @tag_id LIKE 2
	INSERT INTO [dbo].[measurement]
			   ([tag_id]
			   ,[timestamp]
			   ,[measurement_value])
		 VALUES
			   (1
			   ,@measurement_timestamp
			   ,@measurement_value)
GO

IF EXISTS (SELECT name
			FROM sysobjects
			WHERE name = 'AverageTemperatureC' 
			AND type = 'TR')
		DROP TRIGGER AverageTemperatureC
GO

CREATE TRIGGER AverageTemperatureC ON measurement
AFTER INSERT
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE
	@average_temperature float,
	@calculation_timestamp datetime

	select @calculation_timestamp = timestamp from INSERTED
	select @average_temperature = avg(measurement_value) 
								from measurement 
								where tag_id like 1 
								and timestamp 
									between DATEADD(hour, -1, @calculation_timestamp)
									and @calculation_timestamp

	IF NOT EXISTS (SELECT timestamp FROM [dbo].[calculation]
					WHERE [timestamp] = @calculation_timestamp)
		INSERT INTO [dbo].[calculation]
					([statistic_id]
					,[timestamp]
					,[calculation_value])
				VALUES
					(1
					,@calculation_timestamp
					,@average_temperature)
END
GO


