use dbs_prestamos_deportivos
go
-- =============================================
-- Author:	<Author,,Juan Carlos Llorente Bedoya>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

create procedure SP_GenerarPrestamo
@id_persona varchar(10), @user varchar(100)
as begin
    insert into tbl_prestamos
	(FKId_tblpersonas,FKUsuario_tbl_usuarios,Fecha_registro,Hora_registro)
	values
	(@id_persona,@user,GETDATE(),CURRENT_TIMESTAMP)
end