``` Use This Command To Enable Service

ALTER DATABASE [YourDatabaseName] SET ENABLE_BROKER WITH ROLLBACK IMMEDIATE;

ALTER DATABASE [YourDatabaseName]
SET CHANGE_TRACKING = ON
(CHANGE_RETENTION = 1 DAYS, AUTO_CLEANUP = ON);

ALTER TABLE [YourTableName]  
ENABLE CHANGE_TRACKING  
WITH (TRACK_COLUMNS_UPDATED = ON )

```

```Table For Testing

CREATE TABLE [dbo].[Tbl_Blog](
	[BlogId] [int] IDENTITY(1,1) NOT NULL,
	[BlogTitle] [nvarchar](50) NOT NULL,
	[BlogAuthor] [nvarchar](50) NOT NULL,
	[BlogContent] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Tbl_Blog] PRIMARY KEY CLUSTERED 
(
	[BlogId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

```

``` For More Information

https://github.com/IsNemoEqualTrue/monitor-table-change-with-sqltabledependency?tab=readme-ov-file#monitor-and-receive-notifications-on-record-table-change

```