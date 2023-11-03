use dbs_prestamos_deportivos
go
-- =============================================
-- Author:	<Author,,Juan Carlos Llorente Bedoya>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

create procedure SP_Generardetprestamo
 @cod_implemento varchar(10), @cantidad int
as begin 
	declare @existencias_imp int
	declare @numero_prestamo begint
	select @numero_prestamo = (select max(PKNumero) (from tbl_prestamos)
	select @existencias_imp = (select Cantidad from tbl_implementos where PKCodigo = @cod_implemento)
	Insert into tbl_det_prestamos
	(FKNumero_tbl_prestamos,FKCodigo_tbl_implemento,@cantidad)

	Update tbl_implementos
	set Cantidad = (@existencias_imp - @cantidad) where PKCodigo = @cod_implemento
end