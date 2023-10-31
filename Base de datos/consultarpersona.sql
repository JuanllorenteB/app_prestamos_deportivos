use dbs_prestamos_deportivos
go
-- =============================================
-- Author:	<Author,,Juan Carlos Llorente Bedoya>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

create procedure SP_consultarpersona
@id varchar(10)
as begin
	declare @completo varchar (100)
	select
	select @completo = P_nombre + '' + S_nombre + '' + P_apellido + '' + S_apellido
	from
	tbl_personas
	where
	PKId = @id
end 