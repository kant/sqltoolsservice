USE [master]
GO
Exec sp_configure 'show advanced option', '1'; RECONFIGURE;
go
EXEC sp_configure 'clr strict security', 0; RECONFIGURE;
go
