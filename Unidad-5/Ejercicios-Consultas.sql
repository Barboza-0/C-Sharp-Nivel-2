select D.Titulo, D.FechaLanzamiento, E.Descripcion from DISCOS D, ESTILOS E
-- #1

select * from ESTILOS
insert into ESTILOS values ('R&B')
insert into ESTILOS values ('Hip Hop')

select * from TIPOSEDICION
insert into TIPOSEDICION values ('Digital')
-- #2

select * from DISCOS
insert into DISCOS values ('Vida', GETDATE(), 17, 'https://www.youtube.com/channel/UC-Gh7ndBnNZvGRjCzlt2Ecw', 7, 6)
insert into DISCOS values ('Muerte', GETDATE(), 17, 'https://www.youtube.com/channel/UC-Gh7ndBnNZvGRjCzlt2Ecw', 7, 6)
-- #3

select * from DISCOS
update DISCOS set CantidadCanciones = '17' where id = 5
update DISCOS set CantidadCanciones = '14', FechaLanzamiento = '2023-12-31' where id = 5
-- #4

select * from DISCOS
delete from DISCOS where id = 1
-- #5

select * from DISCOS
select E.Descripcion from DISCOS D, ESTILOS E where D.IdEstilo != 0
-- #6

select * from DISCOS
select D.Titulo, E.Descripcion, T.Descripcion from DISCOS D, ESTILOS E, TIPOSEDICION T
-- #7

select * from DISCOS
select D.Titulo from DISCOS D where Titulo LIKE '%ho%'
-- #8