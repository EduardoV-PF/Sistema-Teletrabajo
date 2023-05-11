use master 
go

 
create database Merca_plus
go

use  Merca_plus
go



create table [dbo].[Personal](
ID_personal  int identity (654010,1) not null,
contraseña int,
Nombre varchar (50),
Apellido varchar(50),
sexo varchar(50),
turno_D varchar(50),
ID_cargo int,
ID_Departamento int 
);

 

create table [dbo].[Cargo](
ID_cargo int not null,
Nombre_c varchar (50)
);

 

create table [dbo].[Provedor](
ID_provedor int not null,
Empresa varchar(50)
);

 
create table [dbo].[Productos](
ID_productos int identity (87600010,1) not null,
Nombre varchar(50),
Marca varchar(50),
Precio_Uni  decimal(4,2),
Cantidad int,
ID_provedor int,
ID_Departamento int not null,
XP date
);

 

create table [dbo].[Departamento](
ID_Departamento int not null,
nombre_departamento varchar(50)
);

 


create table [dbo].[Cambios](
ID_personal int not null,
Tipo varchar(50),
tabla varchar(50),
fecha char(50)
);


create table [dbo].[Planilla](
ID_personal int not null,
hora_E time,
hora_S time
);


 
/*llaves primarias */
alter table Personal 
add constraint PK_Personal primary Key clustered
(ID_personal)

 

alter table Cargo 
add constraint PK_Cargo   primary Key clustered
(ID_cargo)

 

alter table Provedor 
add constraint PK_Provedor  primary Key clustered
(ID_provedor)

 

alter table Departamento
add constraint PK_Departamento  primary Key clustered
(ID_Departamento)

 
 alter table Planilla
add constraint PK_Planilla  primary Key clustered
(ID_personal)
 


/*llaves foraneas*/

alter table Productos
add constraint fk_Productos_Provedor foreign key(ID_provedor)
references Provedor(ID_provedor)


alter table Productos
add constraint fk_Productos_Departamento foreign key(ID_Departamento)
references Departamento (ID_Departamento)

 

alter table Cambios
add constraint fk_Cambios_Personal  foreign key(ID_personal)
references Personal (ID_personal)


alter table   Personal
add constraint fk_Personal_Cargo foreign key(ID_cargo)
references Cargo (ID_cargo)


alter table Personal
add constraint fk_Personal_Departamento foreign key(ID_Departamento)
references Departamento (ID_Departamento)



alter table Planilla
add constraint fk_Planilla_Personal foreign key(ID_personal)
references Personal (ID_personal)



/*informacion que debe estar en las tablas para el uso del aplicativo */




insert into [Cargo]
         ( 
		 ID_cargo ,
         Nombre_c
		 )
values
        (
		1,
		'Empleado'
		)

insert into [Cargo]
         ( 
		 ID_cargo ,
         Nombre_c
		 )
values
        (
		2,
		'Supervisor'
		)

insert into [Cargo]
         ( 
		 ID_cargo ,
         Nombre_c
		 )
values
        (
		3,
		'Gerenter'
		)

insert into [Departamento]
         ( 
		 ID_Departamento ,
         nombre_departamento
		 )
values
        (
		100,
		'Monitoreo'
		)


insert into [Departamento]
         ( 
		 ID_Departamento ,
         nombre_departamento
		 )
values
        (
		200,
		'Productividad'
		)
insert into [Departamento]
         ( 
		 ID_Departamento ,
         nombre_departamento
		 )
values
        (
		300,
		'Gerencia'
		)


insert into [Departamento]
         ( 
		 ID_Departamento ,
         nombre_departamento
		 )
values
        (
		400,
		'Cajero'
		)


insert into [Departamento]
         ( 
		 ID_Departamento ,
         nombre_departamento
		 )
values
        (
		500,
		'Carniceria '
		)


insert into [Departamento]
         ( 
		 ID_Departamento ,
         nombre_departamento
		 )
values
        (
		600,
		'Panaderia '
		)


insert into [Departamento]
         ( 
		 ID_Departamento ,
         nombre_departamento
		 )
values
        (
		700,
		'Ferreteria '
		)


insert into [Provedor]
         ( 
		 ID_provedor,
         Empresa 
		 )
values
        (
		355,
		'Nestle'
		)


insert into [Provedor]
         ( 
		 ID_provedor,
         Empresa 
		 )
values
        (
		650,
		'stanley'
		)


insert into [Provedor]
         ( 
		 ID_provedor,
         Empresa 
		 )
values
        (
		230,
		'Toledano'
		)



insert into [Provedor]
         ( 
		 ID_provedor,
         Empresa 
		 )
values
        (
		240,
		'Feduro'
		)

insert into [Provedor]
         ( 
		 ID_provedor,
         Empresa 
		 )
values
        (
		321,
		'Kinner'
		)


insert into [Personal]
         ( 
		 
         contraseña ,
         Nombre ,
         Apellido ,
         sexo ,
         turno_D ,
         ID_cargo ,
         ID_Departamento 
		 )
values
        (
		
		453,
		'Jack',
		'Conor',
		'Masculino',
		'Matutino',
		1,
		100
		)


insert into [Personal]
         ( 
         contraseña ,
         Nombre ,
         Apellido ,
         sexo ,
         turno_D ,
         ID_cargo ,
         ID_Departamento 
		 )
values
        (
		
		678,
		'Ellen',
		'Page',
		'Femenina',
		'Diurno',
		2,
		200
		)
		

insert into [Personal]
         ( 
		 
         contraseña,
         Nombre,
         Apellido,
         sexo,
         turno_D,
         ID_cargo ,
         ID_Departamento 
		 )
values
        (
		
		343,
		'Marco',
		'Gonzales',
		'Masculino',
		'Matutino',
		3,
		300
		)


insert into [Personal]
         ( 
		 
         contraseña,
         Nombre,
         Apellido,
         sexo,
         turno_D,
         ID_cargo ,
         ID_Departamento 
		 )
values
        (
		
		454,
		'carlos',
		'max',
		'Masculino',
		'Matutino',
		1,
		400
		)
insert into [Productos](
ID_productos ,
Nombre,
Marca,
Precio_Uni ,
Cantidad ,
ID_provedor,
ID_Departamento,

         XP 
           )
values(
      'Chicle',
	  'clorets',
	  3.7,
	  45,
	  230,
	  300,
	  '5/10/2020'

	  )



     )
