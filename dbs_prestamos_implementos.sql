use dbs_prestamos_deportivos
go
-- =============================================
-- Author:	<Author,,Juan Carlos Llorente Bedoya>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

Create procedure SP_ConsultarImplemento
@codigo varchar(10)
as begin
	select
	Nombre,
	Especificaciones,
	Cantidad,
	Valor
	from tbl_implementos
	where
	PKCodigo = @codigo
end