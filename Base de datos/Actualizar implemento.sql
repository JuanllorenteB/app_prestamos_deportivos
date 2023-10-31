use dbs_prestamos_deportivos
go


-- =============================================
-- Author:	<Author,,Juan Carlos Llorente Bedoya>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

create procedure SP_Actualizar_implemento
@codigo varchar(10),@nombre varchar(80), @especificaciones varchar (5000),
@cantidad int, @valor float
as begin
	update tbl_implementos
	set
	Nombre = @nombre
	Especificaciones = @especificaciones,
	Cantidad = @cantidad,
	Valor = @valor
	where
	PKCodigo = @codigo
end