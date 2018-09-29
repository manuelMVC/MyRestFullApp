/*
Plantilla de script posterior a la implementación							
--------------------------------------------------------------------------------------
 Este archivo contiene instrucciones de SQL que se anexarán al script de compilación.		
 Use la sintaxis de SQLCMD para incluir un archivo en el script posterior a la implementación.			
 Ejemplo:      :r .\miArchivo.sql								
 Use la sintaxis de SQLCMD para hacer referencia a una variable en el script posterior a la implementación.		
 Ejemplo:      :setvar TableName miTabla							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
INSERT INTO dbo.[User]([Nombre],[Apellido],[Email],[Password]) VALUES ('Pedro','Perez','pperez@hotmail.com','1111')
INSERT INTO dbo.[User]([Nombre],[Apellido],[Email],[Password]) VALUES ('Isabel','Torres','itorres@hotmail.com','1111')
INSERT INTO dbo.[User]([Nombre],[Apellido],[Email],[Password]) VALUES ('Juan','Martinez','jmartinez@hotmail.com','1111')
INSERT INTO dbo.[User]([Nombre],[Apellido],[Email],[Password]) VALUES ('Jose','Canseco','jcanseco@hotmail.com','1111')
INSERT INTO dbo.[User]([Nombre],[Apellido],[Email],[Password]) VALUES ('Bruno','Diaz','bdiaz@hotmail.com','1111')
INSERT INTO dbo.[User]([Nombre],[Apellido],[Email],[Password]) VALUES ('Clark','Kent','ckent@hotmail.com','1111')
GO