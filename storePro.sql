create proc [dbo].[loguear_usuario]
@usuario varchar(50),@pass varchar(50)
as
begin
select id_user , usuario,puntos,partidas_jugadas 
from usuario
where usuario=@usuario and password=@pass
end

