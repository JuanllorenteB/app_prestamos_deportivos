use dbs_prestamos_deportivos
go
-- =============================================
-- Author:	<Author,,Juan Carlos Llorente Bedoya>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

create procedure SP_ConsultarPrestamos
@id_persona varchar(10)
as begin
	select
	tbl_det_prestamos.FKNumero_tbl_prestamos as 'Prestamo No.'.
	tbl_implementos. Nombre + '' Especificaciones as 'Implemento',
	tbl_det_prestamos.Cantidad as ' Cantidad,
	tbl_prestamos.Fecha_registro as 'Fecha devolucion',
	tbl_det_prestamo.Hora_devolucion as 'Hora devolucion',
	tbl_det_prestamo.Observaciones as 'Observaciones'

	from
	tbl_det_prestamos,tbl prestamos
	where
	tbl_prestamos.PKNumero = tbl_det_prestamos.FKNumero_tbl_prestamos and
	tbl_personas.PKId = tbl_prestamos.FKId_tbl_personas and
	tbl_personas.PKId = @id_persona