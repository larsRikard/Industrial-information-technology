USE [DATA_VAULT5]
GO

IF EXISTS (SELECT name
FROM sysobjects
WHERE name = 'SaveLoggingInterval'
	AND type = 'P')
			DROP PROCEDURE SaveLoggingInterval
GO

CREATE PROCEDURE SaveLoggingInterval
	@tag_id integer,
	@measurement_interval as integer,
	@measurement_interval_unit as varchar(30)
AS
BEGIN
	IF EXISTS (SELECT 1
	FROM tag
	WHERE tag_id = @tag_id)
	BEGIN
		UPDATE tag
		SET measurement_interval = @measurement_interval, measurement_interval_unit = @measurement_interval_unit
		WHERE tag_id = @tag_id
	END
ELSE
	BEGIN
		INSERT INTO tag
			(tag_id, measurement_interval, measurement_interval_unit)
		VALUES(@tag_id, @measurement_interval, @measurement_interval_unit)
	END
END
GO

IF EXISTS (SELECT name
FROM sysobjects
WHERE name = 'SaveLoggingUnit'
	AND type = 'P')
			DROP PROCEDURE SaveLoggingUnit
GO

CREATE PROCEDURE SaveLoggingUnit
	@tag_id integer,
	@measurement_unit as varchar(30)
AS
BEGIN
	IF EXISTS (SELECT 1
	FROM tag
	WHERE tag_id = @tag_id)
	BEGIN
		UPDATE tag
		SET measurement_unit = @measurement_unit
		WHERE tag_id = @tag_id
	END
ELSE
	BEGIN
		INSERT INTO tag
			(tag_id, measurement_unit)
		VALUES(@tag_id, @measurement_unit)
	END
END
GO

IF EXISTS (SELECT name
FROM sysobjects
WHERE name = 'SaveMeasurement'
	AND type = 'P')
			DROP PROCEDURE SaveMeasurement
GO

CREATE PROCEDURE SaveMeasurement
	@tag_id integer,
	@timestamp as datetime,
	@measurement_value as float
AS
BEGIN
	IF NOT EXISTS (SELECT 1
	FROM time
	WHERE timestamp = @timestamp)
	BEGIN
		INSERT into time
		VALUES(@timestamp)
	END
	IF EXISTS (SELECT 1
	FROM measurement
	where tag_id = @tag_id
		and timestamp = @timestamp)
	BEGIN
		UPDATE measurement
		set measurement_value = @measurement_value
		where  tag_id = @tag_id
			and timestamp = @timestamp
	END
ELSE
	BEGIN
		INSERT INTO measurement(tag_id,[timestamp],measurement_value)
		VALUES(@tag_id, @timestamp, @measurement_value)
	END
END
GO



