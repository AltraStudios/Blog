create table QueuingTable (
	APIType int not null,
	APIUrl nvarchar(255),
	APIInput nvarchar(max),
	APICallResult nvarchar(max),
	Status int default 1,
	APICallStartDate datetime,
	APICallEndDate datetime
);
