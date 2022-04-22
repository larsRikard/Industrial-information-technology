
CREATE TABLE [calculation]
( 
	[statistic_id]       integer  NOT NULL ,
	[calculation_value]  float  NULL ,
	[timestamp]          smalldatetime  NOT NULL 
)
go

CREATE TABLE [measurement]
( 
	[tag_id]             integer  NOT NULL ,
	[measurement_value]  float  NULL ,
	[timestamp]          smalldatetime  NOT NULL 
)
go

CREATE TABLE [plant]
( 
	[plant_id]           integer  NOT NULL ,
	[plant_name]         varchar(50)  NULL 
)
go

CREATE TABLE [station]
( 
	[station_id]         integer  NOT NULL ,
	[plant_id]           integer  NOT NULL ,
	[station_name]       varchar(30)  NULL ,
	[station_acronym]    varchar(20)  NULL 
)
go

CREATE TABLE [statistic_data]
( 
	[statistic_id]       integer  NOT NULL ,
	[station_id]         integer  NULL ,
	[statistic_unit]     varchar(30)  NULL ,
	[statistic_description] varchar(256)  NULL 
)
go

CREATE TABLE [tag]
( 
	[station_id]         integer  NULL ,
	[measurement_unit]   varchar(30)  NULL ,
	[tag_name]           varchar(30)  NULL ,
	[tag_description]    varchar(256)  NULL ,
	[measurement_interval] smallint  NULL ,
	[measurement_interval_unit] varchar(20)  NULL ,
	[tag_id]             integer  NOT NULL 
)
go

CREATE TABLE [time]
( 
	[timestamp]          smalldatetime  NOT NULL 
)
go

ALTER TABLE [calculation]
	ADD CONSTRAINT [XPKcalculation] PRIMARY KEY  CLUSTERED ([statistic_id] ASC,[timestamp] ASC)
go

ALTER TABLE [measurement]
	ADD CONSTRAINT [XPKmeasurement] PRIMARY KEY  CLUSTERED ([tag_id] ASC,[timestamp] ASC)
go

ALTER TABLE [plant]
	ADD CONSTRAINT [XPKplant] PRIMARY KEY  CLUSTERED ([plant_id] ASC)
go

ALTER TABLE [station]
	ADD CONSTRAINT [XPKstation] PRIMARY KEY  CLUSTERED ([station_id] ASC)
go

ALTER TABLE [statistic_data]
	ADD CONSTRAINT [XPKstatistic_data] PRIMARY KEY  CLUSTERED ([statistic_id] ASC)
go

ALTER TABLE [tag]
	ADD CONSTRAINT [XPKtag] PRIMARY KEY  CLUSTERED ([tag_id] ASC)
go

ALTER TABLE [time]
	ADD CONSTRAINT [XPKTimestamp] PRIMARY KEY  CLUSTERED ([timestamp] ASC)
go


ALTER TABLE [calculation]
	ADD CONSTRAINT [R_7] FOREIGN KEY ([statistic_id]) REFERENCES [statistic_data]([statistic_id])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE [calculation]
	ADD CONSTRAINT [R_15] FOREIGN KEY ([timestamp]) REFERENCES [time]([timestamp])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go


ALTER TABLE [measurement]
	ADD CONSTRAINT [R_1] FOREIGN KEY ([tag_id]) REFERENCES [tag]([tag_id])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE [measurement]
	ADD CONSTRAINT [R_14] FOREIGN KEY ([timestamp]) REFERENCES [time]([timestamp])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go


ALTER TABLE [station]
	ADD CONSTRAINT [R_4] FOREIGN KEY ([plant_id]) REFERENCES [plant]([plant_id])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go


ALTER TABLE [statistic_data]
	ADD CONSTRAINT [R_6] FOREIGN KEY ([station_id]) REFERENCES [station]([station_id])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go


ALTER TABLE [tag]
	ADD CONSTRAINT [R_5] FOREIGN KEY ([station_id]) REFERENCES [station]([station_id])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go
