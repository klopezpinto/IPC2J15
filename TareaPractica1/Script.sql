CREATE DATABASE Biblioteca;
Use Biblioteca;

Create table Cliente(
carnet int constraint pk_cliente primary key,
nombre nvarchar(45) constraint nn_nombre not null,
dpi int constraint nn_dpi not null, CONSTRAINT AK_DPI UNIQUE (dpi),
direccion nvarchar(60) constraint nn_direccion not null,
telefono int constraint nn_telefono not null, CONSTRAINT AK_Telefono UNIQUE (telefono),
Prestamo int constraint nn_prestamo not null
);

Create table Tipo(
idTipo int constraint pk_tipo primary key,
tdes nvarchar(45) constraint nn_tdes not null,
);

Create table Libro(
idLibro int constraint pk_libro primary key,
Nombre nvarchar(60) constraint nn_nombre not null, constraint AK_Nombre UNIQUE (Nombre),
Existencias int constraint nn_existencias not null,
lpaginas int constraint nn_paginas not null,
Autor nvarchar(45) constraint nn_autor not null,
ltema nvarchar(45) constraint nn_tema not null,
Disponibles int constraint nn_disponibles not null,
Reservados int constraint nn_reservados not null,
Prestados int constraint nn_prestados not null
);

Create table Transaccion(
idTransaccion int IDENTITY constraint pk_transaccion primary key,
Cliente_carnet int REFERENCES Cliente (carnet), 
Tipo_idTipo int REFERENCES Tipo (idTipo),
Libro_idLibro int REFERENCES Libro (idLibro)
);

insert into Tipo values(1, 'Prestamo')
insert into Tipo values (2, 'Devolucion')
insert into Tipo values (3, 'Reservar')
