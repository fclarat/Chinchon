create proc [dbo].[loguear_usuario]
@usuario varchar(50),@pass varchar(50)
as
begin
select id_user , usuario,puntos,partidas_jugadas 
from usuario
where usuario=@usuario and password=@pass
end


create proc [dbo].[actualizar_puntos_partidas]
	@id int, @puntos int
as
begin
declare @puntosAux int;
declare @partidasJugadas int;
	set @puntosAux = (select puntos from usuario where id_user=@id);
	set @puntosAux = @puntosAux + @puntos;

	set @partidasJugadas = (select partidas_jugadas from usuario where id_user=@id);
	set @partidasJugadas = @partidasJugadas  + 1;

	update usuario set puntos=@puntosAux, partidas_jugadas=@partidasJugadas where id_user=@id;
end	


create proc [dbo].[listarCartas]

as
begin
select carta.id , carta.numero , paloCarta.paloNombre from carta join paloCarta on paloCarta.id = carta.palo 
end
