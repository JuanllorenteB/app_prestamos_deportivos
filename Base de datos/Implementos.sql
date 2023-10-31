use dbs_prestamos_deportivos
go
 
-- =============================================
-- Author:	<Author,,Juan Carlos Llorente Bedoya>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================


create procedure SP_AgregarImplementos
@codigo varchar(10), @nombre varchar(80),@especificaciones varchar(5000),
@cantidad int, @valor float
as begin
	insert into tbl_implementos
	(PKCodigo,Nombre,Especificaciones,Cantidad,Valor,Fecha)
	values
	(@codigo,@nombre,@especificaciones,@cantidad,@valor,GETDATE())
end