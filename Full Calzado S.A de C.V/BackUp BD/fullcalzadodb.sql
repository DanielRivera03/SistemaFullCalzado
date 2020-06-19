/*      
 *  
 *     @@@@@@   @@    @@   @@        @@         @@@@@@@  @@@@@@@@  @@       @@@@@@@  @@@@@@@@  @@@@@@       @@@@@@@
 *     @@       @@    @@   @@        @@         @@       @@    @@  @@           @@   @@    @@  @@   @@     @@     @@
 *     @@       @@    @@   @@        @@         @@       @@    @@  @@          @@    @@    @@  @@    @@   @@       @@
 *     @@@@@@   @@    @@   @@        @@         @@       @@@@@@@@  @@         @@     @@@@@@@@  @@     @@  @@       @@
 *     @@       @@    @@   @@        @@         @@       @@    @@  @@        @@      @@    @@  @@     @@   @@     @@
 *     @@       @@    @@   @@        @@         @@       @@    @@  @@       @@       @@    @@  @@    @@     @@   @@
 *     @@       @@@@@@@@   @@@@@@@   @@@@@@     @@@@@@@  @@    @@  @@@@@@  @@@@@@    @@    @@  @@@@@@@       @@@@@
 *     
 *  --------------------------------------------------------------------------
 *  |                       FULL CALZADO S.A DE C.V                          |
 *  --------------------------------------------------------------------------
 *  |  INTEGRANTES: {6}                                                      |
 *  --------------------------------------------------------------------------
 *  | -> ELIAS DANIEL MARTINEZ RIVERA          ||      27 - 0077 - 2019      |
 *  | -> FERNANDO ALBERTO SANCHEZ GARCIA       ||      17 - 0503 - 2017      |
 *  | -> CHRISTIAN ANTONIO MONGE PEÑATE        ||      27 - 1686 - 2019      |
 *  | -> KARLA STEFFANY NAVAS SANCHEZ          ||      27 - 1096 - 2019      |
 *  | -> XENIA IVONNE NAJARRO                  ||      27 - 1195 - 2019      |
 *  --------------------------------------------------------------------------
 *  |                        FULL CALZADO S.A DE C.V                         |
 *  --------------------------------------------------------------------------
 */
GO
create database FullCalzadoDB
GO
use FullCalzadoDB

/*		*		*		*		*		*		*		*		*		*		*		*		*		*		*		*		*		*		*
	*		*		*		*		*		*		*		*		*		*		*		*		*		*		*		*		*		*	*
														--->|||CREACION DE TABLAS|||<---
*		*		*		*		*		*		*		*		*		*		*		*		*		*		*		*		*		*		*
	*		*		*		*		*		*		*		*		*		*		*		*		*		*		*		*		*		*	*/
GO
-- CREACION TABLA ROLES DE USUARIOS
create table [dbo].[Roles](
	[ID_Rol] [varchar](30) Primary Key NOT NULL,
	[Nombre_Rol] [varchar](40) NOT NULL,
	[Descripcion_Corta_Rol] [varchar](75) NOT NULL,
);
GO
-- CREACION TABLA USUARIOS REGISTRADOS EN EL SISTEMA
create table [dbo].[Usuarios](
	[ID_usuario] [int] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[Nombre_Usuario] [varchar](70) NOT NULL,
	[Contrasenia] [varchar](100) NOT NULL,
	[ID_Rol] [varchar](30) NOT NULL References Roles,
);

-- CREACION TABLA CARGOS EN EL SISTEMA
create table [dbo].[Cargos](
	[Id_cargo] varchar (100) NOT NULL,
	[Nombre_cargo] varchar(100) PRIMARY KEY NOT NULL,
	[Descripcion] varchar(400) NOT NULL,
);

--CREACION TABLA GENERO EN EL SISTEMA
create table[dbo].[Genero](
	[Sexo] char(1) NOT NULL primary key
);

--CREACION TABLA ESTADO CIVIL EN EL SISTEMA
create table [dbo].[EstadoCivil](
	[Estado_Civil] varchar(25) not null primary key
);

--CREACION TABLA EMPLEADOS EN EL SISTEMA
create table [dbo].[Empleados](
	[Id_empleado] int PRIMARY KEY NOT NULL,
	[Nombre] varchar(75) NOT NULL,
	[Apellido] varchar (75) NOT NULL,
	[Sueldo_Base] decimal(8,2) NOT NULL,
	[Fecha_Nacimiento] date NOT NULL,
	[Dui] varchar(10),
	[Sexo] char(1) NOT NULL references Genero,
	[Estado_Civil] varchar(25) NOT NULL references EstadoCivil,
	[Telefono] varchar(11) NOT NULL,
	[Direccion] varchar(150) NOT NULL,
	[Nombre_cargo] varchar(100) NOT NULL foreign key references Cargos
);

-- CREACION TABLA CATEGORIA EN EL SISTEMA
create table [dbo].[Categoria](
	[ID_categoria] varchar(100)  NOT NULL,
	[Nombre_Categoria] varchar(30) PRIMARY KEY NOT NULL,
	[Descripcion_Categoria] varchar(400) NOT NULL,
);

-- CREACION TABLA Producto EN EL SISTEMA
create table [dbo].[Productos](
	[ID] int PRIMARY KEY NOT NULL,
	[Codigo] VARCHAR(100) NOT NULL,
	[Nombre] varchar(75) NOT NULL,
	[Marca] varchar(75) NOT NULL,
	[Modelo] varchar(75) NOT NULL,
	[Precio] decimal(5,2) NOT NULL,
	[Nombre_Categoria] varchar(30) NOT NULL foreign key References Categoria
);	

--CREANDO TABLA TIPO DE PAGO DE DOCUMENTO
CREATE TABLE [dbo].[tipo_pago](
	[id_tipopago] [int] Primary key IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](10) NOT NULL
);

--CREANDO TABLA FORMA DE PAGO
CREATE TABLE [dbo].[Forma_Pago](
	[id_Formapago] [int] Primary key IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](25) NOT NULL,
);

--CREANDO TABLA ENCABEZADO DE FACTURA
CREATE TABLE [dbo].[Encabezado_Fac](
	[cod_examen] [int] Primary Key IDENTITY(1,1) NOT NULL,
	[id_Empleado] [int] Foreign Key REFERENCES Empleados,
	[id_Formapago] [int] Foreign Key REFERENCES Forma_Pago,
	[fecha] [date],
	[Nit] [varchar] (15),
	[No_Registro][varchar] (10),
	[Num_Tarjeta][varchar] (20),
	[sub_total][decimal] (8,2),
	[iva][decimal] (8,2),
	[total][decimal](8,2),
	[id_tipopago][int] Foreign Key REFERENCES tipo_pago
);

--CREANDO TABLA DETALLE DE FACTURA 
CREATE TABLE [dbo].[Detalle_Fac](
	[id_detalle_fac] [int] Primary key IDENTITY(1,1) NOT NULL,
	[cod_examen][int] Foreign key REFERENCES Encabezado_Fac,
	[id_Producto] [int] NOT NULL foreign key References Productos,
	[descripcion] [varchar](50) NOT NULL,
	[cantidad] [int] NOT NULL,
	[precio] [decimal](8, 2) NULL,
);

/*		*		*		*		*		*		*		*		*		*		*		*		*		*		*		*		*		*		*
	*		*		*		*		*		*		*		*		*		*		*		*		*		*		*		*		*		*	*
														--->|||VISTAS GENERALES|||<---
								   					--->||TODAS LAS TABLAS DISPONIBLES|||<---
*		*		*		*		*		*		*		*		*		*		*		*		*		*		*		*		*		*		*
	*		*		*		*		*		*		*		*		*		*		*		*		*		*		*		*		*		*	*/
--CREANDO VISTA PARA REGISTRAR ROLES DE USUARIOS 
create view [dbo].[vRolesSistema] AS
select ID_Rol, Nombre_Rol, Descripcion_Corta_Rol
From Roles

--CREANDO VISTA PARA REGISTRAR USUARIOS 
create view [dbo].[vUsuariosRegistrados] AS
select ID_Usuario, Nombre, Apellido, Nombre_Usuario, Contrasenia, ID_Rol
From Usuarios
GO
INSERT [dbo].[Roles] ([ID_Rol], [Nombre_Rol], [Descripcion_Corta_Rol]) VALUES (N'Administrador', N'Usuarios Nivel Administradores', N'Departamento de Sistemas TIC')
INSERT [dbo].[Roles] ([ID_Rol], [Nombre_Rol], [Descripcion_Corta_Rol]) VALUES (N'AtencionClientes', N'Atención Al Cliente', N'Departamento de Atención al Cliente, empleados generales')
INSERT [dbo].[Roles] ([ID_Rol], [Nombre_Rol], [Descripcion_Corta_Rol]) VALUES (N'CajerosFC', N'Ventas Full Calzado', N'Empleados Ventas Directas Full Calzado S.A de C.V')
INSERT [dbo].[Roles] ([ID_Rol], [Nombre_Rol], [Descripcion_Corta_Rol]) VALUES (N'Presidencia', N'Presidencia Gerencia', N'Departamento de presidencia, gerencia general')
INSERT [dbo].[Roles] ([ID_Rol], [Nombre_Rol], [Descripcion_Corta_Rol]) VALUES (N'RRHH', N'Recursos Humanos', N'Departamento de Recursos Humanos (RR.HH)')
INSERT [dbo].[Usuarios] ([ID_usuario], [Nombre], [Apellido], [Nombre_Usuario], [Contrasenia], [ID_Rol]) VALUES (1, N'Daniel', N'Rivera', N'daniel.rivera', N'eCjJ1IxK+E972SUkjnBHVwoMwM5UV5VrTqkNjoFqCJrgm3JT8PpvgtA9pSr8151X+d6KJimryyWnVUP0JKA7RA==', N'Administrador')
INSERT [dbo].[Usuarios] ([ID_usuario], [Nombre], [Apellido], [Nombre_Usuario], [Contrasenia], [ID_Rol]) VALUES (4, N'Karla', N'Navas', N'karla.navas', N'wcYTu109ZAllFyz701ZMSb3BNJE+Tcb2SSH5S0IC/xZtQuCChna9mw6iinz0qWNK1NhdIRURm4/WuWMUn8xPSg==', N'Administrador')
INSERT [dbo].[Usuarios] ([ID_usuario], [Nombre], [Apellido], [Nombre_Usuario], [Contrasenia], [ID_Rol]) VALUES (2, N'Fernando', N'Sanchez', N'fernanAsG', N'MEOqSoOwk0mClWqQgoFAy4NIaRNbXylJOIZd4S4DbeRAozDh6FKb7BXd1Z8Y0RYal7/sEQ0mImgPLHFKc31wYQ==', N'Administrador')
INSERT [dbo].[Usuarios] ([ID_usuario], [Nombre], [Apellido], [Nombre_Usuario], [Contrasenia], [ID_Rol]) VALUES (3, N'Christian', N'Monge', N'christian.monge', N'wcYTu109ZAllFyz701ZMSb3BNJE+Tcb2SSH5S0IC/xZtQuCChna9mw6iinz0qWNK1NhdIRURm4/WuWMUn8xPSg==', N'Administrador')
INSERT [dbo].[Usuarios] ([ID_usuario], [Nombre], [Apellido], [Nombre_Usuario], [Contrasenia], [ID_Rol]) VALUES (5, N'Xenia', N'Najarro', N'xenia.najarro', N'wcYTu109ZAllFyz701ZMSb3BNJE+Tcb2SSH5S0IC/xZtQuCChna9mw6iinz0qWNK1NhdIRURm4/WuWMUn8xPSg==', N'Administrador')
INSERT [dbo].[Usuarios] ([ID_usuario], [Nombre], [Apellido], [Nombre_Usuario], [Contrasenia], [ID_Rol]) VALUES (7, N'Roxana', N'Miranda', N'roxana.miranda', N'1ARVn2Auq2/WAqx2gNrL+q3RNjAzXpUfCXrzkA6d4Xa22yhRLy4AC50E+6UTPoscbo31nbOoq51gvkuXzJ6B2w==', N'Presidencia')
INSERT [dbo].[Usuarios] ([ID_usuario], [Nombre], [Apellido], [Nombre_Usuario], [Contrasenia], [ID_Rol]) VALUES (11, N'Alejandro', N'Guzman', N'alejandro.guzman', N'1ARVn2Auq2/WAqx2gNrL+q3RNjAzXpUfCXrzkA6d4Xa22yhRLy4AC50E+6UTPoscbo31nbOoq51gvkuXzJ6B2w==', N'Presidencia')
INSERT [dbo].[Usuarios] ([ID_usuario], [Nombre], [Apellido], [Nombre_Usuario], [Contrasenia], [ID_Rol]) VALUES (13, N'Manuel', N'Aguilar', N'manuel.aguilar', N'1ARVn2Auq2/WAqx2gNrL+q3RNjAzXpUfCXrzkA6d4Xa22yhRLy4AC50E+6UTPoscbo31nbOoq51gvkuXzJ6B2w==', N'RRHH')
INSERT [dbo].[Usuarios] ([ID_usuario], [Nombre], [Apellido], [Nombre_Usuario], [Contrasenia], [ID_Rol]) VALUES (14, N'Javier', N'Argueta', N'javier.argueta', N'1ARVn2Auq2/WAqx2gNrL+q3RNjAzXpUfCXrzkA6d4Xa22yhRLy4AC50E+6UTPoscbo31nbOoq51gvkuXzJ6B2w==', N'RRHH')
INSERT [dbo].[Usuarios] ([ID_usuario], [Nombre], [Apellido], [Nombre_Usuario], [Contrasenia], [ID_Rol]) VALUES (16, N'Daniela', N'Ramirez', N'daniela.ramirez', N'1ARVn2Auq2/WAqx2gNrL+q3RNjAzXpUfCXrzkA6d4Xa22yhRLy4AC50E+6UTPoscbo31nbOoq51gvkuXzJ6B2w==', N'AtencionClientes')
INSERT [dbo].[Usuarios] ([ID_usuario], [Nombre], [Apellido], [Nombre_Usuario], [Contrasenia], [ID_Rol]) VALUES (6, N'Mario', N'Lopez', N'mario.lopez', N'1ARVn2Auq2/WAqx2gNrL+q3RNjAzXpUfCXrzkA6d4Xa22yhRLy4AC50E+6UTPoscbo31nbOoq51gvkuXzJ6B2w==', N'RRHH')
INSERT [dbo].[Usuarios] ([ID_usuario], [Nombre], [Apellido], [Nombre_Usuario], [Contrasenia], [ID_Rol]) VALUES (8, N'Lourdes', N'Ramos', N'lourdes.ramos', N'1ARVn2Auq2/WAqx2gNrL+q3RNjAzXpUfCXrzkA6d4Xa22yhRLy4AC50E+6UTPoscbo31nbOoq51gvkuXzJ6B2w==', N'AtencionClientes')
INSERT [dbo].[Usuarios] ([ID_usuario], [Nombre], [Apellido], [Nombre_Usuario], [Contrasenia], [ID_Rol]) VALUES (9, N'Kenia', N'Solano', N'kenia.solano', N'1ARVn2Auq2/WAqx2gNrL+q3RNjAzXpUfCXrzkA6d4Xa22yhRLy4AC50E+6UTPoscbo31nbOoq51gvkuXzJ6B2w==', N'CajerosFC')
INSERT [dbo].[Usuarios] ([ID_usuario], [Nombre], [Apellido], [Nombre_Usuario], [Contrasenia], [ID_Rol]) VALUES (10, N'Marcos', N'Gutierrez', N'marco.gutierrez', N'1ARVn2Auq2/WAqx2gNrL+q3RNjAzXpUfCXrzkA6d4Xa22yhRLy4AC50E+6UTPoscbo31nbOoq51gvkuXzJ6B2w==', N'Presidencia')
INSERT [dbo].[Usuarios] ([ID_usuario], [Nombre], [Apellido], [Nombre_Usuario], [Contrasenia], [ID_Rol]) VALUES (12, N'Maria', N'Rodriguez', N'maria.rodriguez', N'1ARVn2Auq2/WAqx2gNrL+q3RNjAzXpUfCXrzkA6d4Xa22yhRLy4AC50E+6UTPoscbo31nbOoq51gvkuXzJ6B2w==', N'RRHH')
INSERT [dbo].[Usuarios] ([ID_usuario], [Nombre], [Apellido], [Nombre_Usuario], [Contrasenia], [ID_Rol]) VALUES (15, N'David', N'Cruz', N'david.cruz', N'1ARVn2Auq2/WAqx2gNrL+q3RNjAzXpUfCXrzkA6d4Xa22yhRLy4AC50E+6UTPoscbo31nbOoq51gvkuXzJ6B2w==', N'AtencionClientes')

--CREANDO VISTA PARA REGISTRAR ESTADO CIVIL Y GENERO
create view [dbo].[vRegistroEstadoGenero] AS
select Sexo, Estado_Civil
from [dbo].[genero],[dbo].[EstadoCivil]
go
insert [dbo].[genero] (Sexo) values ('M')
insert [dbo].[genero] (Sexo) values ('F')
insert into [dbo].[EstadoCivil] values ('soltero')
insert into [dbo].[EstadoCivil] values ('soltera')
insert into [dbo].[EstadoCivil] values ('casado')
insert into [dbo].[EstadoCivil] values ('casada')
insert into [dbo].[EstadoCivil] values ('soltera')
insert into [dbo].[EstadoCivil] values ('viudo')
insert into [dbo].[EstadoCivil] values ('viuda')
insert into [dbo].[EstadoCivil] values ('divorciado')
insert into [dbo].[EstadoCivil] values ('divorciada')

--CREANDO VISTA PARA VISUALIZAR PRODUCTOS
create view [dbo].[vProductoSistema] AS
select ID, Codigo, Nombre, Marca, Modelo, Precio, Nombre_Categoria
From Productos

--CREANDO VISTA PARA VISUALIZAR CATEGORIA
create view [dbo].[vCategoriaSistema] AS
select  ID_categoria, Nombre_Categoria, Descripcion_Categoria
From Categoria

--CREANDO VISTA PARA VISUALIZAR CARGOS
create view [dbo].[vCargoSistema] AS
select  Id_cargo, Nombre_cargo, Descripcion
From Cargos

--CREANDO VISTA PARA VISUALIZAR EMPLEADOS
create view [dbo].[vEmpleadoSistema] AS
select Id_empleado, Nombre, Apellido, Sueldo_Base, Fecha_Nacimiento, Dui, Sexo, Estado_Civil, Telefono, Direccion, Nombre_cargo
From Empleados

--CREANDO VISTA PARA SELECCIONAR LOS DETALLES DE FACTURA
CREATE VIEW [dbo].[vsdetallesdefac]
AS
SELECT A.id_Producto,A.descripcion,A.cantidad,A.precio from Detalle_Fac A INNER JOIN Encabezado_Fac B ON A.cod_examen=B.cod_examen WHERE B.fecha=CONVERT(varchar,GETDATE(),23) 

--CREANDO VISTA PARA MOSTRAR FACTURA COMPLETA DETALLADA

CREATE view [dbo].[VFactura]
as
select A.cod_examen, B.Nombre,C.nombre as FormaPago ,D.nombre as TipoDoc,A.fecha,A.sub_total, A.iva, A.total from Encabezado_Fac A inner join Empleados B on A.id_Empleado=B.Id_empleado inner join 
Forma_Pago C on A.id_Formapago=C.id_Formapago inner join tipo_pago D on A.id_tipopago=D.id_tipopago 

/*		*		*		*		*		*		*		*		*		*		*		*		*		*		*		*		*		*		*
	*		*		*		*		*		*		*		*		*		*		*		*		*		*		*		*		*		*	*
														--->|||PROCEDIMIENTOS ALMACENADOS|||<---
														--->|TODAS  LAS  TABLAS DISPONIBLES|<---
*		*		*		*		*		*		*		*		*		*		*		*		*		*		*		*		*		*		*
	*		*		*		*		*		*		*		*		*		*		*		*		*		*		*		*		*		*	*/
--INSERTAR ROLES DE USUARIOS EN EL SISTEMA
CREATE PROCEDURE [dbo].[sp_InsertarRolesUsuarios]
	@ID_Rol varchar(30),
	@Nombre_Rol varchar(40),
	@Descripcion_Corta_Rol varchar(75)
AS 
BEGIN
	INSERT INTO Roles(ID_Rol,Nombre_Rol,Descripcion_Corta_Rol)
	VALUES (@ID_Rol,@Nombre_Rol,@Descripcion_Corta_Rol);
END

--MODIFICAR ROLES DE USUARIOS EN EL SISTEMA
CREATE PROCEDURE [dbo].[sp_ModificarRolesUsuarios]
	@ID_Rol varchar(30),
	@Nombre_Rol varchar(40),
	@Descripcion_Corta_Rol varchar(75)
AS 
BEGIN
	UPDATE Roles SET ID_Rol = @ID_Rol, Nombre_Rol = @Nombre_Rol, Descripcion_Corta_Rol = @Descripcion_Corta_Rol WHERE ID_Rol = @ID_Rol;
END

--ELIMINAR ROLES DE USUARIOS EN EL SISTEMA
CREATE PROCEDURE [dbo].[sp_EliminarRolesUsuarios]
	@ID_Rol varchar(30)
AS 
BEGIN
	DELETE FROM Roles WHERE ID_Rol = @ID_Rol;
END

--MODIFICAR USUARIOS EN EL SISTEMA
CREATE PROCEDURE [dbo].[sp_ModificarUsuarios]
	@ID_usuario int,
	@Nombre varchar(50),
	@Apellido varchar(50),
	@Nombre_Usuario varchar(70),
	@Contrasenia varchar(100),
	@ID_Rol varchar(30)
AS 
BEGIN
	UPDATE Usuarios SET Nombre = @Nombre, Apellido = @Apellido, Nombre_Usuario = @Nombre_Usuario, Contrasenia = @Contrasenia, ID_Rol = @ID_Rol WHERE ID_usuario = @ID_usuario;
END

--ELIMINAR USUARIOS EN EL SISTEMA
CREATE PROCEDURE [dbo].[sp_EliminarUsuarios]
	@ID_usuario int
AS 
BEGIN
	DELETE FROM Usuarios WHERE ID_Usuario = @ID_usuario;
END

--MODIFICAR ID DE USUARIOS EN EL SISTEMA
CREATE PROCEDURE [dbo].[sp_ModificarIDUsuarios]
	@ID_usuario int,
	@NuevoID_Usuario int
AS 
BEGIN
	UPDATE Usuarios SET ID_usuario = @NuevoID_Usuario WHERE ID_usuario = @ID_usuario;
END

--INSERTAR USUARIOS EN EL SISTEMA
CREATE PROCEDURE [dbo].[sp_InsertarUsuarios]
	@ID_usuario int,
	@Nombre varchar(50),
	@Apellido varchar(50),
	@Nombre_Usuario varchar(70),
	@Contrasenia varchar(100),
	@ID_Rol varchar(30)
AS 
BEGIN
	INSERT INTO Usuarios(ID_usuario,Nombre,Apellido,Nombre_Usuario,Contrasenia,ID_Rol)
	VALUES (@ID_usuario,@Nombre,@Apellido,@Nombre_Usuario,@Contrasenia,@ID_Rol);
END

-- SP PARA LISTADO PRODUCTO
create procedure [dbo].[ListadProductos]
as 
begin
SELECT        Codigo, Nombre, Marca, Modelo, Precio, Nombre_Categoria
FROM            Productos
ORDER BY Codigo, Nombre
end

-- SP PARA MOSTAR LOS PRODUCTOS DAÑADOS
create procedure [dbo].[ProductosDañados]
as
begin
SELECT  Productos.Nombre, Productos.Marca, Detalle_Fac.cantidad, Detalle_Fac.precio, Encabezado_Fac.total
FROM    Productos INNER JOIN
        Detalle_Fac ON Productos.ID = Detalle_Fac.id_Producto AND Productos.ID = Detalle_Fac.id_Producto INNER JOIN
        Encabezado_Fac ON Detalle_Fac.cod_examen = Encabezado_Fac.cod_examen AND Detalle_Fac.cod_examen = Encabezado_Fac.cod_examen
ORDER BY Productos.Nombre
end

-- INSERTAR PRODUCTOS EN EL SISTEMA
CREATE PROCEDURE [dbo].[sp_InsertarProductos]
	@ID int,
	@Codigo VARCHAR(100),
	@Nombre varchar(75),
	@Marca varchar(75),
	@Modelo varchar(75),
	@Precio decimal(5,2),
	@Nombre_Categoria varchar(30)
AS
BEGIN
INSERT INTO Productos(ID,Codigo, Nombre, Marca, Modelo, Precio, Nombre_Categoria)
VALUES (@ID,@Codigo, @Nombre, @Marca, @Modelo, @Precio, @Nombre_Categoria)
END

-- MODIFICAR CATEGORIA EN EL SISTEMA
create procedure [dbo].[sp_ModificarProductos]
@ID AS int,
@Codigo VARCHAR(100),
@Nombre varchar(75),
@Marca varchar(75),
@Modelo varchar(75),
@Precio decimal(5,2),
@Nombre_Categoria varchar(30)
as
begin
update Productos set
Codigo=@Codigo,
 Nombre=@Nombre, Marca=@Marca, Modelo=@Modelo, Precio=@Precio, Nombre_Categoria = @Nombre_Categoria
where ID=@ID	
end

--MODIFICAR ID PRODUCTOS EN EL SISTEMA 
CREATE PROCEDURE [dbo].[sp_ModificarIDProductos]
	@ID int,
	@NuevoID_Productos int
AS 
BEGIN
	UPDATE Productos SET ID = @NuevoID_Productos WHERE ID = @ID;
END
 
-- ELIMINAR PRODUCTOS EN EL SISTEMA
create procedure [dbo].[sp_EliminarProductos]
@ID AS int
as
begin
delete from  Productos where ID=@ID	
end 

-- INSERTAR CATEGORIA EN EL SISTEMA
create procedure [dbo].[sp_InsertarCategoria]
	@ID_categoria INT,
	@Nombre_Categoria varchar(30),
	@Descripcion_Categoria varchar(400)
as
begin
insert into Categoria(ID_categoria,Nombre_Categoria,Descripcion_Categoria) values(@ID_categoria,@Nombre_Categoria, @Descripcion_Categoria)
end

-- MODIFICAR CATEGORIA EN EL SISTEMA
create procedure [dbo].[sp_ModificarCategoria]
	@ID_categoria INT,
	@Nombre_Categoria varchar(30),
	@Descripcion_Categoria varchar(400)
as
begin
update Categoria set  Nombre_Categoria=@Nombre_Categoria, Descripcion_Categoria=@Descripcion_Categoria
where ID_categoria=@ID_categoria	
end

--ELIMINAR CATEGORIA EN EL SISTEMA
create procedure [dbo].[sp_EliminarCategoria]
@ID_categoria Varchar(100)
as
begin
delete from  Categoria where ID_categoria = @ID_categoria
end

-- INSERTAR CARGOS EN EL SISTEMA
create procedure [dbo].[sp_InsertarCargos]
	@Id_cargo varchar (100),
	@Nombre_cargo varchar(100),
	@Descripcion varchar(400)
	as
begin
insert into Cargos(Id_cargo,Nombre_cargo,Descripcion) values(@Id_cargo,@Nombre_cargo, @Descripcion)
end

-- MODIFICAR CARGOS EN EL SISTEMA
create procedure [dbo].[sp_ModificarCargos]
	@Id_cargo varchar (100),
	@Nombre_cargo varchar(100),
	@Descripcion varchar(400)
as
begin
update cargos set  Nombre_cargo=@Nombre_cargo, Descripcion=@Descripcion
where Id_cargo=@Id_cargo	
end 

-- ELIMINAR CARGOS EN EL SISTEMA
create procedure [dbo].[sp_EliminarCargos]
@Id_cargo AS int
as
begin
delete from  cargos where Id_cargo=@Id_cargo
end

-- SP PARA EL REPORTE DE LISTADO EMPLEADOS
create procedure MostrarEmpleado
as 
begin
SELECT Id_empleado, Nombre, Apellido, Sueldo_Base, Fecha_Nacimiento, Dui, Sexo, Estado_Civil, Telefono, Direccion, Nombre_cargo 
FROM dbo.Empleados
end

-- SP PAR EL REPORTE DE VENTAS POR EMPLEADO 
CREATE procedure [dbo].[ReporteVentasEmpleado]
 as begin
select e.Nombre,e.Apellido,fecha,sum (en.total)
from Empleados  as e inner join Encabezado_Fac as en
on en.Id_empleado = e.Id_empleado
group by e.Nombre,en.fecha,e.Apellido
end

-- SP PARA EL REPORTE DE EMPLEADO 
create procedure [dbo].[REPORTEEMPLEADO]
as begin
SELECT        e.Nombre, e.Nombre_cargo, SUM(e.Sueldo_Base) 
FROM          Empleados AS e 
GROUP BY e.Nombre_cargo, e.Nombre
end

-- SP PARA MONTO TOTAL DE PRODUCTOS
create procedure [dbo].[MontosTotalProductos]
as begin 
select p.Codigo,p.Nombre,sum(p.Precio*d.Cantidad) 
from productos  as p inner join Detalle_Fac as d
on p.ID=d.id_Producto 
group by p.Codigo, p.Nombre
order by sum(p.Precio*d.Cantidad)  asc
end

-- INSERTAR EMPLEADOS EN EL SISTEMA
create procedure [dbo].[sp_InsertarEmpleados]
@Id_empleado int,
@Nombre varchar(75),
@Apellido varchar (75),
@Sueldo_Base decimal(8,2),
@Fecha_Nacimiento date,
@Dui varchar(10),
@Sexo char(1),
@Estado_Civil varchar(25),
@Telefono varchar(11),
@Direccion varchar(150),
@Nombre_cargo varchar(100)
as
begin
insert into Empleados(Id_empleado, Nombre, Apellido , Sueldo_Base, Fecha_Nacimiento, Dui,Sexo, Estado_Civil,Telefono,Direccion,Nombre_cargo) values
(@Id_empleado,@Nombre, @Apellido,@Sueldo_Base,@Fecha_Nacimiento,@Dui,@Sexo,@Estado_Civil,@Telefono,@Direccion,@Nombre_cargo)
end

-- MODIFICAR EMPLEADO EN EL SISTEMA
create procedure [dbo].[sp_ModificarEmpleado]
@Id_empleado int,
@Nombre varchar(75),
@Apellido varchar (75),
@Sueldo_Base decimal(8,2),
@Fecha_Nacimiento date,
@Dui varchar(10),
@Sexo char(1),
@Estado_Civil varchar(25),
@Telefono varchar(11),
@Direccion varchar(150),
@Nombre_cargo varchar(100)
as
begin
update Empleados set  Id_empleado = @Id_empleado, Nombre = @Nombre, Apellido = @Apellido, Sueldo_Base = @Sueldo_Base, Fecha_Nacimiento = @Fecha_Nacimiento, Dui = @Dui, Sexo = @Sexo, Estado_Civil = @Estado_Civil, Telefono = @Telefono, Direccion = @Direccion
where Id_empleado = @Id_empleado
end

-- ELIMINAR EMPLEADOS EN EL SISTEMA
create procedure [dbo].[sp_EliminarEmpleados]
@Id_empleado AS int
as
begin
delete from  Empleados where Id_empleado=@Id_empleado
end 
go

--CREANDO PROCEDIMIENTO ALMACENADO PARA INSERTAR EL ENCABEZADO DE LA FACTURA
CREATE PROCEDURE INSER_FAC
@id_Empleado INT, @id_Formapago INT, @fecha date, @Nit varchar(15), @No_Registro varchar(10), @Num_tarjeta varchar(20),
@sub_total decimal(8,2), @iva decimal(8,2), @total decimal(8,2), @id_tipopago int
AS
BEGIN
INSERT INTO Encabezado_Fac(id_Empleado,id_Formapago,fecha,Nit,No_Registro,Num_tarjeta,sub_total,iva,total,id_tipopago)
 VALUES (@id_Empleado,@id_Formapago,@fecha,@Nit,@No_Registro,@Num_tarjeta,@sub_total,@iva,@total,@id_tipopago)
END
GO
--CREANDO PROCEDIMIENTO ALMACENADO PARA INSERTAR EL EL DETALLE DE FACTURA
CREATE PROCEDURE INSER_DET_FAC
@id_Producto int, 
@descripcion varchar(50), 
@cantidad int,
@precio decimal(8,2)
AS
BEGIN
DECLARE @id_detalle_fac int
SET @id_detalle_fac= (SELECT MAX(cod_examen) from Encabezado_Fac)
INSERT INTO Detalle_Fac(cod_examen,id_Producto,descripcion,cantidad,precio) VALUES(@id_detalle_fac,@id_Producto,@descripcion,@cantidad,@precio)
END
GO

--CREANDO PROCEDIMIENTO ALMACENADO PARA ELIMINAR FACTURAS
CREATE PROCEDURE SP_eliminar_factura
@ID_FACTURA INT
AS
BEGIN
DELETE FROM Detalle_Fac where cod_examen=@ID_FACTURA;
DELETE FROM Encabezado_Fac where cod_examen=@ID_FACTURA;
END
GO

--CREANDO SP PARA INSERTAR FORMA DE PAGO
CREATE PROCEDURE sp_insertarfpago
@nombre varchar(25)
AS
BEGIN
INSERT INTO Forma_Pago (nombre) Values(@nombre)
END
GO

--CREANDO PROCEDIMIENTO ALMACENADO PARA AGREGAR TIPO DE DOCUMENTO
CREATE PROCEDURE sp_insertar_tipodoc
@nombre varchar(10)
AS
BEGIN
INSERT INTO tipo_pago (nombre) VALUES(@nombre)
END
GO

/*		*		*		*		*		*		*		*		*		*		*		*		*		*		*		*		*		*		*
	*		*		*		*		*		*		*		*		*		*		*		*		*		*		*		*		*		*	*
														--->|||CONSULTAS GENERALES|||<---
								   					--->||TODAS LAS TABLAS DISPONIBLES|||<---
*		*		*		*		*		*		*		*		*		*		*		*		*		*		*		*		*		*		*
	*		*		*		*		*		*		*		*		*		*		*		*		*		*		*		*		*		*	*/
select * from Roles					-- USUARIOS DEL SISTEMA
select * from Usuarios				-- OLES DE USUARIOS DEL SISTEMA
select * from Productos				-- PRODUCTOS DEL SISTEMA
select * from Categoria				-- CATEGORIA DE PRODUCTO DEL SISTEMA
select * from Cargos				-- CARGOS DEL EMPLEADO DEL SISTEMA
select * from Empleados				-- EMPLEADOS DEL SISTEMA
select * from Genero				-- GENERO DE EMPLEADO DEL SISTEMA
select * from EstadoCivil			-- ESTADO CIVIL DE EMPLEADO DEL SISTEMA
select * from tipo_pago				-- TIPO DE PAGO DEL SISTEMA
select * from Detalle_Fac			-- TIPO DE PAGO DETALLE DE FACTURA
select * from vProductoSistema		-- VISTA PRODUCTO DEL SISTEMA
select * from vCategoriaSistema		-- VISTA CATEGOGIA DEL SISTEMA
select * from vUsuariosRegistrados  -- VISTA DE USUARIOS RESGISTRADOS
select * from vRolesSistema			-- VISTA DE ROLES DEL SISTEMA
/*		*		*		*		*		*		*		*		*		*		*		*		*		*		*		*		*		*		*
	*		*		*		*		*		*		*		*		*		*		*		*		*		*		*		*		*		*	*
														--->|||AREA RESTRINGIDA|||<---
									--->|||DEPURACION DE TODAS LAS TABLAS EXISTENTES EN LA BASE DE DATOS|||<---
*		*		*		*		*		*		*		*		*		*		*		*		*		*		*		*		*		*		*
	*		*		*		*		*		*		*		*		*		*		*		*		*		*		*		*		*		*	*/
drop table Usuarios		-- USUARIOS DEL SISTEMA
drop table Roles		-- ROLES DE USUARIOS DEL SISTEMA
drop table Productos	-- PRODUCTOS DEL SISTEMA
drop table Categoria	-- CATEGORIA DE PRODUCTO DEL SISTEMA
drop table Cargos		-- CARGOS DEL EMPLEADOS DEL SISTEMA
drop table Empleados	-- EMPLEADOS DEL SISTEMA
drop table tipo_pago	-- TIPO DE PAGO DEL SISTEMA
drop table Detalle_Fac	-- DETALLE DE FACTURA DEL SISTEMA
drop table Encabezado_Fac
/*		*		*		*		*		*		*		*		*		*		*		*		*		*		*		*		*		*		*
	*		*		*		*		*		*		*		*		*		*		*		*		*		*		*		*		*		*	*
														--->|||AREA DE INSERCIONES|||<---
									--->|||LAS 30 INSERCIONES POR TABLAS {TODAS LAS TABLAS} DE LA BASE DE DATOS|||<---
*		*		*		*		*		*		*		*		*		*		*		*		*		*		*		*		*		*		*
	*		*		*		*		*		*		*		*		*		*		*		*		*		*		*		*		*		*	*/
-- INSERCIONES PARA CATEGORIA Y PRODUCTOS
Insert into Categoria 
	values (1,'Tipos de zapatos para hombre','zapato formal'),
		   (2,'Oxford Lisos','Las botas también tienen diferentes estilos algunos de ellos más formales como los que te mostramos'),
		   (3,'Botas o botines de vestir','Un calzado cómodo que además, pega con todo. Esta revolución llega para traernos modelos que creíamos ya olvidados'),
		   (4,'Zapatillas o Tenis Blancos','Las zapatillas blancas tipo sport son el complemento perfecto para looks informales'),
		   (5,'Zapatos Brogue','Estos tipos de zapatos para hombre con cordones posee una costura y una puntera con un ala extendida a todo el zapato'),
		   (6,'Mocasines','son muy socorridos para cualquier ocasión, no son tan formales y elegante'),
		   (7,'Zapatos Monk','Zapatos de vestir formales con cierre en forma de hebilla, pueden tener una o dos hebillas'),
		   (8,'Zapatos casual', 'Los zapatos casual los puedes combinar con unos jeans'),
		   (9,'Derbi ','son otro tipos de zapatos para hombre elegantes y normalmente de cordones'),
		   (10,'Náuticos','Son ligeros y sencillos y los puedes utilizar para ocasiones informales'),
		   (11,'Sandalias o Alpargatas','Imprescindibles para el verano y para no pasar calor en los pies, pero eso sí, debemos combinarlas con cuidado'),
		   (12,'Zapatillas','el vestir bien incluso con zapatillas'),
		   (13,'Karlo','modelos selectivos, sofisticados y propositivos en tendencias de moda, que ofrezcan originalidad y la oportunidad de lucir un outfit auténtico.'),
		   (14,'Nike Air Max','ancho cojinete de aire puesto sobre el talón y visible a lado de la intersuola para la mayoría de los modelos'),
		   (15,'Insolia','reduce el dolor asociado con el uso de zapatos de tacón alto. '),
		   (16,'stripper','es un tipo de zapato de tacón que se elabora con materiales transparentes'),
		   (17,'tacones','son un tipo de calzado que se caracteriza por elevar el talón sobre la altura de los dedos de los pies'),
		   (18,'Francesitas','Aunque tengas estas pequeñas diferentes, normalmente llamamos a todos estos zapatos bailarinas.'),
		   (19,'Bailarinas lace up','es la que va atada en el empeine o tobillo con cinta o cordón'),
		   (20,'Slippers','En las últimas temporadas, se han puesto muy de moda, y los podemos encontrar en una gran variedad de colores, pieles y estampados.'),
		   (21,'Slip-on','Normalmente son zapatillas de lona, aunque también las podemos encontrar de pie'),
		   (22,'Stiletto','Zapato de mujer con tacón alto y fino, lo que se llama también tacón de aguja'),
		   (23,'Scarpin','Se caracterizan por tener la suela fina, y es un zapato totalmente atemporal'),
		   (24,'Cowboy Boots','on botines de estilo cowboy o campero, que hoy en día podemos encontrar de muchas formas'),
		   (25,'Biker Boots','Botas de estilo motero, normalmente con hebillas, siendo el adorno más característicos de estas botas'),
		   (26,'Thigh High Boots','Estas son las botas por encima de la rodilla hasta los muslos, con caña elásticas y tacón'),
		   (27,'Botas cuissard','Estas también son botas mosqueteras, pero sin llegar a ser tan altas como las Thigh High Boots'),
		   (28,'Knee High Boots','Estas botas son altas, aunque sin llegar a la altura de las anteriores'),
		   (29,'Wellington boots','Botas de agua, también llamadas katiuskas'),
		   (30,'Manoletinas','Es una variedad de las bailarinas, que se diferencian por la suela, siendo las manoletinas las que tienen un poco más de suela');

INSERT INTO PRODUCTOS 
	VALUES (1,'pro1','Botas Dr. Marten','adidas','cuero',25,'Zapatillas o Tenis Blancos'),
		   (2,'pro2','zapato tenis casual','adidas Originals','sharol',75,'Zapatillas o Tenis Blancos'),
		   (3,'pro3','Botas australianas','Antea','Lona',40,'Mocasines'),
		   (4,'pro4','Desert Boots','Buffalo','cuero',35,'Mocasines'),
		   (5,'pro5','Lita Boots','Victoria','cuero',65,'Oxford Lisos'),
		   (6,'pro6','Zapatos Planos ','Fioni','cuero',85,'Oxford Lisos'),
		   (7,'pro7','Sandalias de Tacón Florales Azules Hanna para mujer', 'Brash ','cuero',75,'Mocasines'),
		   (8,'pro8','Derby','Zendra Basic','cuero',85,'Zapatos Monk'),
		   (9,'pro9','Sandalias de Tacón  Cognac Nadine para mujer','Brash','cuero',85,'Oxford Lisos'),
		   (10,'pro10','Derby','gucci','lona',15.99,'Oxford Lisos'),
		   (11,'pro11','Monk','Nike','cuero',150.99,'Oxford Lisos'),
		   (12,'pro12','Mocasín','Adidas','lona',154.99,'Oxford Lisos'),
		   (13,'pro13','Dockside o náutico','Adidas','cuero',153.99,'Oxford Lisos'),
		   (14,'pro14','Sneakers','Adidas','cuero',154.99,'Mocasines'),
		   (15,'pro15','Scarpin','gucci','lona',156.99,'Oxford Lisos'),
		   (16,'pro16','Peep-toe','Adidas','lona',157.99,'Mocasines'),
		   (17,'pro17','Pumps','Nike','sharol',158.99,'Mocasines'),
		   (18,'pro17','High Heels','gucci',' sharol',151.99,'Mocasines'),
		   (19,'pro19','Stiletto','Nike','lona',152.99,'Oxford Lisos'),
		   (20,'pro20','Kitten Heel','gucci','lona',153.99,'Oxford Lisos'),
		   (21,'pro21','Tenis  Grises Negros y Rosas Concur Sport para mujer',' lona','cuero',50,'Oxford Lisos'),
		   (22,'pro22','Tenis Champion Navy Concur ','Champion','lona',85,'Mocasines'),
		   (23,'pro23','Derby','Botas de Cuña American Eagle Oro Madrid para niñas','cuero',65,'Zapatos Brogue'),
		   (24,'pro24','Sandalias Airwalk Negras ','Airwalk Basic','cuero',50,'Mocasines'),
		   (25,'pro25','Sandalias Cafés','American Eagle ','cuero',75,'Mocasines'),
		   (26,'pro26','Sandalias para mujer',' Brash Navy Print Janie','cuero',54,'Zapatos Brogue'),
		   (27,'pro27','Zapatos de Tacón ','Christian Siriano','cuero',45,'Zapatos Monk'),
		   (28,'pro28','Tenis  Tan Recreate para mujer Planos  Nude y Amarillos Audra para mujer','Champion','lona',85,'Zapatos Brogue'),
		   (29,'pro29','Tenis  Grises Loren para mujer','American Eagle','lona',55,'Zapatos Monk'),
		   (30,'pro30','Zapatos de Tacón  Navy Lucy Pleat para mujer',' Fioni','cuero',85,'Zapatos Monk');


-- TABLAS ESTADO CIVIL, CARGOS, GENERO Y EMPLEADOS
insert into Cargos values (1,'Gerente General RR.HH','descripcion de gerente');
insert into Cargos values(2,'Resp De Produccion','descripcion de produccion');
insert into Cargos values(3,'Resp De Finanzas','descripcion de reportes de finanzas');
insert into Cargos values(4,'Vendedor','descripcion de vendedor');
insert into Cargos values(5,'Precidencia','descripcion de precidencia');
insert into Cargos values(6,'Atencion al cliente','descripcion de atencion al cliente');
insert into Cargos values(7,'Cajero','descripcion de cajero');
insert into Cargos values(8,'Gerente Administrativo ','descripcion de gerente administrativo');
insert into Cargos values(9,'Gerente Comercial','descripcion de gerente comercial');


insert into Empleados values (1,'Ariel','Melgar',400,'02-02-1993','147896548','M','soltero','7176-8652','san bartolome perulapia','Gerente General RR.HH')
insert into Empleados values (3,'Alberto','Sanchez',500,'02-02-1995','123456789','f','soltero','7156-8622','san vicente santa clara','Resp De Produccion')
insert into Empleados values (2,'xenia','Alvarado',500,'02-02-1997','123456789','F','soltero','7123-6722','San salvador,soyapango','Resp De Finanzas')
insert into Empleados values (4,'Romeo','Valles',600,'02-02-1994','123456789','M','soltero','7123-9822','santa ana,san juan','Vendedor')
insert into Empleados values (5,'Julio','Fuentes',500,'02-02-1998','123456789','M','casado','7123-5422','san salvador,soyapango','Precidencia')
insert into Empleados values (6,'Celia','Argumedo',600,'02-02-1991','123456789','F','divorciada','7123-8634','san migel,san jorge','Resp De Finanzas')
insert into Empleados values (7,'Georgina','Rivera',300,'02-02-1981','123456789','F','soltero','7123-8634','san migel,santa elena','Atencion al cliente')
insert into Empleados values (8,'Steffany','Trinidad',500,'02-02-1984','123456789','F','casado','7123-8624','soyapango','Cajero')
insert into Empleados values (9,'Guadalupe','Carranza',600,'02-02-1987','123456789','F','soltera','7123-8657','Usulutan,jiquilisco','Gerente Administrativo ')
insert into Empleados values (10,'Jese','Parada',400,'02-02-1975','123456789','M','divorciado','7123-8665','Morazan,trompina','Gerente Administrativo')
insert into Empleados values (11,'Lucia','Antonio',300,'02-02-1984','123456789','F','soltera','7123-8646','cabañas,jutiapa','Resp De Finanzas')
insert into Empleados values (12,'Herbert','Novoa',500,'02-02-1977','123456789','M','viudo','7123-8656','chalatenango, san isidro','Gerente Comercial')
insert into Empleados values (13,'Carlos','Antonio',300,'02-02-1974','123456789','M','viudo','7123-8660','san salvador,san marcos','Resp De Finanzas')
insert into Empleados values (14,'Alvaro','Sanchez',400,'02-02-1984','123456789','M','casado','7123-8656','san vicente santa clara','Gerente Comercial')
insert into Empleados values (15,'Vilma','Lopez',500,'02-02-1986','123456789','F','soltera','7123-8622','soyapango','Gerente Administrativo')
insert into Empleados values (16,'Rosa','Funes',400,'02-02-1977','123456789','F','soltera','7123-8726','chalatenango caserios los amates','Resp De Finanzas')
insert into Empleados values (17,'Ana','Orellana',500,'02-02-1978','123456789','F','casada','7123-8622','san salvador mejicanos','Resp De Finanzas')
insert into Empleados values (18,'Judith','Membreño',600,'02-02-1975','123456789','F','soltera','7323-8622','san salvador nejapa','Gerente Administrativo')
insert into Empleados values (19,'Marta','Guardado',400,'02-02-1984','123456789','F','soltera','7123-8622','cabañas cinquera','Atencion al cliente')
insert into Empleados values (20,'Juana','Genovez',500,'02-02-1987','123456789','F','divorciada','7523-8622','soyapango',4)
insert into Empleados values (21,'Carolina','Archila',200,'02-02-1986','123456789','F','soltera','7123-8622','cabañas tenancingo','Atencion al cliente')
insert into Empleados values (22,'Beatriz','Marroquin',500,'02-02-1982','123456789','F','soltera','8123-8622','cuscatlan Recidencial  los almendros','Vendedor')
insert into Empleados values (23,'Catalina','Coreas',600,'02-02-1985','123456789','F','soltera','7123-8622','soyapango','Atencion al cliente')
insert into Empleados values (24,'Rafael','Merino',500,'02-02-1987','123456789','M','casado','7723-8622','soyapango','Vendedor')
insert into Empleados values (25,'Rocio','Rosales',400,'02-02-1984','123456789','F','soltera','7423-8622','cuscatlan suchitoto','Gerente Administrativo')
insert into Empleados values (26,'Obed','Juarez',300,'02-02-1986','123456789','M','casado','75123-8622','la paz,verapaz ','Vendedor')
insert into Empleados values (27,'Jaime','Linares',500,'02-02-1985','123456789','M','soltero','7153-8622','Santo tomas la paz','Vendedor')
insert into Empleados values (28,'Rebeca','Webb',500,'02-02-1986','123456789','F','casada','7623-8622','santa teresa la union','Gerente Administrativo')
insert into Empleados values (29,'Amilcar','Aguila',00,'02-02-1995','12345679','M','soltero','7823-8622','san salvador,soyapango','Vendedor')
insert into Empleados values (30,'Sonia','Hernandez',00,'02-02-1999','123456789','F','divorciada','7888-8622','san salvador,soyapango','Gerente Administrativo')


-- parte de Christian
INSERT INTO Forma_Pago (nombre) VALUES('Efectivo'),('Tarjeta'),('Cheque')

INSERT INTO tipo_pago (nombre) VALUES('Credito F'),('Ticket'),('Factura')

INSERT INTO Encabezado_Fac
VALUES(1,2,'2020/05/10','01012145874','061458745','00000000321',200.00,26.00,226.00,1)

INSERT INTO Detalle_Fac(cod_examen,id_Producto,descripcion,cantidad,precio)
VALUES(1,1,'Nike 360',1,100.00),(1,1,'Adidas yessy',1,100.00)

 

INSERT INTO Encabezado_Fac(id_Empleado,id_Formapago,fecha,Nit,No_Registro,Num_tarjeta,sub_total,iva,id_tipopago)
VALUES(1,2,'2020/05/10','33534545874','745315455','00001236545',113.00,13.00,126.00,1)

 

INSERT INTO Detalle_Fac(cod_examen,id_Producto,descripcion,cantidad,precio)
VALUES(2,1,'New Balance 567',1,56.50),(2,1,'Gucci style',1,56.50)

