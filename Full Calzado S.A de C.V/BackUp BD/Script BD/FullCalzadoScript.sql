USE [master]
GO
/****** Object:  Database [FullCalzadoDB]    Script Date: 19/06/2020 15:57:15 ******/
CREATE DATABASE [FullCalzadoDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'FullCalzadoDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLDR\MSSQL\DATA\FullCalzadoDB.mdf' , SIZE = 4160KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'FullCalzadoDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLDR\MSSQL\DATA\FullCalzadoDB_log.ldf' , SIZE = 1040KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [FullCalzadoDB] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [FullCalzadoDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [FullCalzadoDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [FullCalzadoDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [FullCalzadoDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [FullCalzadoDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [FullCalzadoDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [FullCalzadoDB] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [FullCalzadoDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [FullCalzadoDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [FullCalzadoDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [FullCalzadoDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [FullCalzadoDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [FullCalzadoDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [FullCalzadoDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [FullCalzadoDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [FullCalzadoDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [FullCalzadoDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [FullCalzadoDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [FullCalzadoDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [FullCalzadoDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [FullCalzadoDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [FullCalzadoDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [FullCalzadoDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [FullCalzadoDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [FullCalzadoDB] SET  MULTI_USER 
GO
ALTER DATABASE [FullCalzadoDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [FullCalzadoDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [FullCalzadoDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [FullCalzadoDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [FullCalzadoDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER AUTHORIZATION ON DATABASE::[FullCalzadoDB] TO [sa]
GO
USE [FullCalzadoDB]
GO
/****** Object:  Table [dbo].[Cargos]    Script Date: 19/06/2020 15:57:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cargos](
	[Id_cargo] [varchar](100) NOT NULL,
	[Nombre_cargo] [varchar](100) NOT NULL,
	[Descripcion] [varchar](400) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Nombre_cargo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER AUTHORIZATION ON [dbo].[Cargos] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[Categoria]    Script Date: 19/06/2020 15:57:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Categoria](
	[ID_categoria] [varchar](100) NOT NULL,
	[Nombre_Categoria] [varchar](30) NOT NULL,
	[Descripcion_Categoria] [varchar](400) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Nombre_Categoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER AUTHORIZATION ON [dbo].[Categoria] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[Detalle_Fac]    Script Date: 19/06/2020 15:57:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Detalle_Fac](
	[id_detalle_fac] [int] IDENTITY(1,1) NOT NULL,
	[cod_examen] [int] NULL,
	[id_Producto] [int] NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
	[cantidad] [int] NOT NULL,
	[precio] [decimal](8, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_detalle_fac] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER AUTHORIZATION ON [dbo].[Detalle_Fac] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[Empleados]    Script Date: 19/06/2020 15:57:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Empleados](
	[Id_empleado] [int] NOT NULL,
	[Nombre] [varchar](75) NOT NULL,
	[Apellido] [varchar](75) NOT NULL,
	[Sueldo_Base] [decimal](8, 2) NOT NULL,
	[Fecha_Nacimiento] [date] NOT NULL,
	[Dui] [varchar](10) NULL,
	[Sexo] [char](1) NOT NULL,
	[Estado_Civil] [varchar](25) NOT NULL,
	[Telefono] [varchar](11) NOT NULL,
	[Direccion] [varchar](150) NOT NULL,
	[Nombre_cargo] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_empleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER AUTHORIZATION ON [dbo].[Empleados] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[Encabezado_Fac]    Script Date: 19/06/2020 15:57:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Encabezado_Fac](
	[cod_examen] [int] IDENTITY(1,1) NOT NULL,
	[id_Empleado] [int] NULL,
	[id_Formapago] [int] NULL,
	[fecha] [date] NULL,
	[Nit] [varchar](15) NULL,
	[No_Registro] [varchar](10) NULL,
	[Num_Tarjeta] [varchar](20) NULL,
	[sub_total] [decimal](8, 2) NULL,
	[iva] [decimal](8, 2) NULL,
	[total] [decimal](8, 2) NULL,
	[id_tipopago] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[cod_examen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER AUTHORIZATION ON [dbo].[Encabezado_Fac] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[EstadoCivil]    Script Date: 19/06/2020 15:57:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[EstadoCivil](
	[Estado_Civil] [varchar](25) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Estado_Civil] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER AUTHORIZATION ON [dbo].[EstadoCivil] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[Forma_Pago]    Script Date: 19/06/2020 15:57:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Forma_Pago](
	[id_Formapago] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](25) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_Formapago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER AUTHORIZATION ON [dbo].[Forma_Pago] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[Genero]    Script Date: 19/06/2020 15:57:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Genero](
	[Sexo] [char](1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Sexo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER AUTHORIZATION ON [dbo].[Genero] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[Productos]    Script Date: 19/06/2020 15:57:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Productos](
	[ID] [int] NOT NULL,
	[Codigo] [varchar](100) NOT NULL,
	[Nombre] [varchar](75) NOT NULL,
	[Marca] [varchar](75) NOT NULL,
	[Modelo] [varchar](75) NOT NULL,
	[Precio] [decimal](5, 2) NOT NULL,
	[Nombre_Categoria] [varchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER AUTHORIZATION ON [dbo].[Productos] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 19/06/2020 15:57:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Roles](
	[ID_Rol] [varchar](30) NOT NULL,
	[Nombre_Rol] [varchar](40) NOT NULL,
	[Descripcion_Corta_Rol] [varchar](75) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Rol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER AUTHORIZATION ON [dbo].[Roles] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[tipo_pago]    Script Date: 19/06/2020 15:57:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tipo_pago](
	[id_tipopago] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_tipopago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER AUTHORIZATION ON [dbo].[tipo_pago] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 19/06/2020 15:57:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuarios](
	[ID_usuario] [int] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[Nombre_Usuario] [varchar](70) NOT NULL,
	[Contrasenia] [varchar](100) NOT NULL,
	[ID_Rol] [varchar](30) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER AUTHORIZATION ON [dbo].[Usuarios] TO  SCHEMA OWNER 
GO
/****** Object:  View [dbo].[vCargoSistema]    Script Date: 19/06/2020 15:57:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[vCargoSistema] AS
select  Id_cargo, Nombre_cargo, Descripcion
From Cargos

GO
ALTER AUTHORIZATION ON [dbo].[vCargoSistema] TO  SCHEMA OWNER 
GO
/****** Object:  View [dbo].[vCategoriaSistema]    Script Date: 19/06/2020 15:57:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[vCategoriaSistema] AS
select  ID_categoria, Nombre_Categoria, Descripcion_Categoria
From Categoria

GO
ALTER AUTHORIZATION ON [dbo].[vCategoriaSistema] TO  SCHEMA OWNER 
GO
/****** Object:  View [dbo].[vEmpleadoSistema]    Script Date: 19/06/2020 15:57:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[vEmpleadoSistema] AS
select Id_empleado, Nombre, Apellido, Sueldo_Base, Fecha_Nacimiento, Dui, Sexo, Estado_Civil, Telefono, Direccion, Nombre_cargo
From Empleados

GO
ALTER AUTHORIZATION ON [dbo].[vEmpleadoSistema] TO  SCHEMA OWNER 
GO
/****** Object:  View [dbo].[VFactura]    Script Date: 19/06/2020 15:57:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [dbo].[VFactura]
as
select A.cod_examen, B.Nombre,C.nombre as FormaPago ,D.nombre as TipoDoc,A.fecha,A.sub_total, A.iva, A.total from Encabezado_Fac A inner join Empleados B on A.id_Empleado=B.Id_empleado inner join 
Forma_Pago C on A.id_Formapago=C.id_Formapago inner join tipo_pago D on A.id_tipopago=D.id_tipopago 

GO
ALTER AUTHORIZATION ON [dbo].[VFactura] TO  SCHEMA OWNER 
GO
/****** Object:  View [dbo].[vProductoSistema]    Script Date: 19/06/2020 15:57:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[vProductoSistema] AS
select ID, Codigo, Nombre, Marca, Modelo, Precio, Nombre_Categoria
From Productos
GO
ALTER AUTHORIZATION ON [dbo].[vProductoSistema] TO  SCHEMA OWNER 
GO
/****** Object:  View [dbo].[vRegistroEstadoGenero]    Script Date: 19/06/2020 15:57:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[vRegistroEstadoGenero] AS
select Sexo, Estado_Civil
from [dbo].[genero],[dbo].[EstadoCivil]

GO
ALTER AUTHORIZATION ON [dbo].[vRegistroEstadoGenero] TO  SCHEMA OWNER 
GO
/****** Object:  View [dbo].[vRolesSistema]    Script Date: 19/06/2020 15:57:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[vRolesSistema] AS
select ID_Rol, Nombre_Rol, Descripcion_Corta_Rol
From Roles
GO
ALTER AUTHORIZATION ON [dbo].[vRolesSistema] TO  SCHEMA OWNER 
GO
/****** Object:  View [dbo].[vsdetallesdefac]    Script Date: 19/06/2020 15:57:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vsdetallesdefac]
AS
SELECT A.id_Producto,A.descripcion,A.cantidad,A.precio from Detalle_Fac A INNER JOIN Encabezado_Fac B ON A.cod_examen=B.cod_examen WHERE B.fecha=CONVERT(varchar,GETDATE(),23) 

GO
ALTER AUTHORIZATION ON [dbo].[vsdetallesdefac] TO  SCHEMA OWNER 
GO
/****** Object:  View [dbo].[vUsuariosRegistrados]    Script Date: 19/06/2020 15:57:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[vUsuariosRegistrados] AS
select ID_Usuario, Nombre, Apellido, Nombre_Usuario, Contrasenia, ID_Rol
From Usuarios

GO
ALTER AUTHORIZATION ON [dbo].[vUsuariosRegistrados] TO  SCHEMA OWNER 
GO
INSERT [dbo].[Cargos] ([Id_cargo], [Nombre_cargo], [Descripcion]) VALUES (N'6', N'Atencion al cliente', N'descripcion de atencion al cliente')
INSERT [dbo].[Cargos] ([Id_cargo], [Nombre_cargo], [Descripcion]) VALUES (N'7', N'Cajero', N'descripcion de cajero')
INSERT [dbo].[Cargos] ([Id_cargo], [Nombre_cargo], [Descripcion]) VALUES (N'8', N'Gerente Administrativo ', N'descripcion de gerente administrativo')
INSERT [dbo].[Cargos] ([Id_cargo], [Nombre_cargo], [Descripcion]) VALUES (N'9', N'Gerente Comercial', N'descripcion de gerente comercial')
INSERT [dbo].[Cargos] ([Id_cargo], [Nombre_cargo], [Descripcion]) VALUES (N'1', N'Gerente General RR.HH', N'descripcion de gerente')
INSERT [dbo].[Cargos] ([Id_cargo], [Nombre_cargo], [Descripcion]) VALUES (N'5', N'Precidencia', N'descripcion de precidencia')
INSERT [dbo].[Cargos] ([Id_cargo], [Nombre_cargo], [Descripcion]) VALUES (N'3', N'Resp De Finanzas', N'descripcion de reportes de finanzas')
INSERT [dbo].[Cargos] ([Id_cargo], [Nombre_cargo], [Descripcion]) VALUES (N'2', N'Resp De Produccion', N'descripcion de produccion')
INSERT [dbo].[Cargos] ([Id_cargo], [Nombre_cargo], [Descripcion]) VALUES (N'4', N'Vendedor', N'descripcion de vendedor')
INSERT [dbo].[Categoria] ([ID_categoria], [Nombre_Categoria], [Descripcion_Categoria]) VALUES (N'19', N'Bailarinas lace up', N'es la que va atada en el empeine o tobillo con cinta o cordón')
INSERT [dbo].[Categoria] ([ID_categoria], [Nombre_Categoria], [Descripcion_Categoria]) VALUES (N'25', N'Biker Boots', N'Botas de estilo motero, normalmente con hebillas, siendo el adorno más característicos de estas botas')
INSERT [dbo].[Categoria] ([ID_categoria], [Nombre_Categoria], [Descripcion_Categoria]) VALUES (N'27', N'Botas cuissard', N'Estas también son botas mosqueteras, pero sin llegar a ser tan altas como las Thigh High Boots')
INSERT [dbo].[Categoria] ([ID_categoria], [Nombre_Categoria], [Descripcion_Categoria]) VALUES (N'3', N'Botas o botines de vestir', N'Un calzado cómodo que además, pega con todo. Esta revolución llega para traernos modelos que creíamos ya olvidados')
INSERT [dbo].[Categoria] ([ID_categoria], [Nombre_Categoria], [Descripcion_Categoria]) VALUES (N'24', N'Cowboy Boots', N'on botines de estilo cowboy o campero, que hoy en día podemos encontrar de muchas formas')
INSERT [dbo].[Categoria] ([ID_categoria], [Nombre_Categoria], [Descripcion_Categoria]) VALUES (N'9', N'Derbi ', N'son otro tipos de zapatos para hombre elegantes y normalmente de cordones')
INSERT [dbo].[Categoria] ([ID_categoria], [Nombre_Categoria], [Descripcion_Categoria]) VALUES (N'18', N'Francesitas', N'Aunque tengas estas pequeñas diferentes, normalmente llamamos a todos estos zapatos bailarinas.')
INSERT [dbo].[Categoria] ([ID_categoria], [Nombre_Categoria], [Descripcion_Categoria]) VALUES (N'15', N'Insolia', N'reduce el dolor asociado con el uso de zapatos de tacón alto. ')
INSERT [dbo].[Categoria] ([ID_categoria], [Nombre_Categoria], [Descripcion_Categoria]) VALUES (N'13', N'Karlo', N'modelos selectivos, sofisticados y propositivos en tendencias de moda, que ofrezcan originalidad y la oportunidad de lucir un outfit auténtico.')
INSERT [dbo].[Categoria] ([ID_categoria], [Nombre_Categoria], [Descripcion_Categoria]) VALUES (N'28', N'Knee High Boots', N'Estas botas son altas, aunque sin llegar a la altura de las anteriores')
INSERT [dbo].[Categoria] ([ID_categoria], [Nombre_Categoria], [Descripcion_Categoria]) VALUES (N'30', N'Manoletinas', N'Es una variedad de las bailarinas, que se diferencian por la suela, siendo las manoletinas las que tienen un poco más de suela')
INSERT [dbo].[Categoria] ([ID_categoria], [Nombre_Categoria], [Descripcion_Categoria]) VALUES (N'6', N'Mocasines', N'son muy socorridos para cualquier ocasión, no son tan formales y elegante')
INSERT [dbo].[Categoria] ([ID_categoria], [Nombre_Categoria], [Descripcion_Categoria]) VALUES (N'10', N'Náuticos', N'Son ligeros y sencillos y los puedes utilizar para ocasiones informales')
INSERT [dbo].[Categoria] ([ID_categoria], [Nombre_Categoria], [Descripcion_Categoria]) VALUES (N'14', N'Nike Air Max', N'ancho cojinete de aire puesto sobre el talón y visible a lado de la intersuola para la mayoría de los modelos')
INSERT [dbo].[Categoria] ([ID_categoria], [Nombre_Categoria], [Descripcion_Categoria]) VALUES (N'2', N'Oxford Lisos', N'Las botas también tienen diferentes estilos algunos de ellos más formales como los que te mostramos')
INSERT [dbo].[Categoria] ([ID_categoria], [Nombre_Categoria], [Descripcion_Categoria]) VALUES (N'11', N'Sandalias o Alpargatas', N'Imprescindibles para el verano y para no pasar calor en los pies, pero eso sí, debemos combinarlas con cuidado')
INSERT [dbo].[Categoria] ([ID_categoria], [Nombre_Categoria], [Descripcion_Categoria]) VALUES (N'23', N'Scarpin', N'Se caracterizan por tener la suela fina, y es un zapato totalmente atemporal')
INSERT [dbo].[Categoria] ([ID_categoria], [Nombre_Categoria], [Descripcion_Categoria]) VALUES (N'21', N'Slip-on', N'Normalmente son zapatillas de lona, aunque también las podemos encontrar de pie')
INSERT [dbo].[Categoria] ([ID_categoria], [Nombre_Categoria], [Descripcion_Categoria]) VALUES (N'20', N'Slippers', N'En las últimas temporadas, se han puesto muy de moda, y los podemos encontrar en una gran variedad de colores, pieles y estampados.')
INSERT [dbo].[Categoria] ([ID_categoria], [Nombre_Categoria], [Descripcion_Categoria]) VALUES (N'22', N'Stiletto', N'Zapato de mujer con tacón alto y fino, lo que se llama también tacón de aguja')
INSERT [dbo].[Categoria] ([ID_categoria], [Nombre_Categoria], [Descripcion_Categoria]) VALUES (N'16', N'stripper', N'es un tipo de zapato de tacón que se elabora con materiales transparentes')
INSERT [dbo].[Categoria] ([ID_categoria], [Nombre_Categoria], [Descripcion_Categoria]) VALUES (N'17', N'tacones', N'son un tipo de calzado que se caracteriza por elevar el talón sobre la altura de los dedos de los pies')
INSERT [dbo].[Categoria] ([ID_categoria], [Nombre_Categoria], [Descripcion_Categoria]) VALUES (N'26', N'Thigh High Boots', N'Estas son las botas por encima de la rodilla hasta los muslos, con caña elásticas y tacón')
INSERT [dbo].[Categoria] ([ID_categoria], [Nombre_Categoria], [Descripcion_Categoria]) VALUES (N'1', N'Tipos de zapatos para hombre', N'zapato formal')
INSERT [dbo].[Categoria] ([ID_categoria], [Nombre_Categoria], [Descripcion_Categoria]) VALUES (N'29', N'Wellington boots', N'Botas de agua, también llamadas katiuskas')
INSERT [dbo].[Categoria] ([ID_categoria], [Nombre_Categoria], [Descripcion_Categoria]) VALUES (N'12', N'Zapatillas', N'el vestir bien incluso con zapatillas')
INSERT [dbo].[Categoria] ([ID_categoria], [Nombre_Categoria], [Descripcion_Categoria]) VALUES (N'4', N'Zapatillas o Tenis Blancos', N'Las zapatillas blancas tipo sport son el complemento perfecto para looks informales')
INSERT [dbo].[Categoria] ([ID_categoria], [Nombre_Categoria], [Descripcion_Categoria]) VALUES (N'5', N'Zapatos Brogue', N'Estos tipos de zapatos para hombre con cordones posee una costura y una puntera con un ala extendida a todo el zapato')
INSERT [dbo].[Categoria] ([ID_categoria], [Nombre_Categoria], [Descripcion_Categoria]) VALUES (N'8', N'Zapatos casual', N'Los zapatos casual los puedes combinar con unos jeans')
INSERT [dbo].[Categoria] ([ID_categoria], [Nombre_Categoria], [Descripcion_Categoria]) VALUES (N'7', N'Zapatos Monk', N'Zapatos de vestir formales con cierre en forma de hebilla, pueden tener una o dos hebillas')
SET IDENTITY_INSERT [dbo].[Detalle_Fac] ON 

INSERT [dbo].[Detalle_Fac] ([id_detalle_fac], [cod_examen], [id_Producto], [descripcion], [cantidad], [precio]) VALUES (3, 2, 1, N'New Balance 567', 1, CAST(56.50 AS Decimal(8, 2)))
INSERT [dbo].[Detalle_Fac] ([id_detalle_fac], [cod_examen], [id_Producto], [descripcion], [cantidad], [precio]) VALUES (4, 2, 1, N'Gucci style', 1, CAST(56.50 AS Decimal(8, 2)))
INSERT [dbo].[Detalle_Fac] ([id_detalle_fac], [cod_examen], [id_Producto], [descripcion], [cantidad], [precio]) VALUES (5, 3, 2, N'zapato tenis casual', 5, CAST(9000.00 AS Decimal(8, 2)))
INSERT [dbo].[Detalle_Fac] ([id_detalle_fac], [cod_examen], [id_Producto], [descripcion], [cantidad], [precio]) VALUES (6, 3, 1, N'Botas Dr. Marten', 4, CAST(3.00 AS Decimal(8, 2)))
INSERT [dbo].[Detalle_Fac] ([id_detalle_fac], [cod_examen], [id_Producto], [descripcion], [cantidad], [precio]) VALUES (7, 4, 1, N'Botas Dr. Marten', 2, CAST(20.00 AS Decimal(8, 2)))
INSERT [dbo].[Detalle_Fac] ([id_detalle_fac], [cod_examen], [id_Producto], [descripcion], [cantidad], [precio]) VALUES (10, 9, 8, N'Derby', 33, CAST(43.00 AS Decimal(8, 2)))
INSERT [dbo].[Detalle_Fac] ([id_detalle_fac], [cod_examen], [id_Producto], [descripcion], [cantidad], [precio]) VALUES (11, 10, 6, N'Zapatos Planos ', 8, CAST(85.00 AS Decimal(8, 2)))
INSERT [dbo].[Detalle_Fac] ([id_detalle_fac], [cod_examen], [id_Producto], [descripcion], [cantidad], [precio]) VALUES (12, 11, 4, N'Desert Boots', 20, CAST(35.00 AS Decimal(8, 2)))
SET IDENTITY_INSERT [dbo].[Detalle_Fac] OFF
INSERT [dbo].[Empleados] ([Id_empleado], [Nombre], [Apellido], [Sueldo_Base], [Fecha_Nacimiento], [Dui], [Sexo], [Estado_Civil], [Telefono], [Direccion], [Nombre_cargo]) VALUES (1, N'Alexandra', N'Melgar', CAST(400.00 AS Decimal(8, 2)), CAST(N'1993-02-02' AS Date), N'147896548', N'M', N'soltero', N'7176-8652', N'san bartolome perulapia', N'Gerente General RR.HH')
INSERT [dbo].[Empleados] ([Id_empleado], [Nombre], [Apellido], [Sueldo_Base], [Fecha_Nacimiento], [Dui], [Sexo], [Estado_Civil], [Telefono], [Direccion], [Nombre_cargo]) VALUES (2, N'xenia', N'Alvarado', CAST(500.00 AS Decimal(8, 2)), CAST(N'1997-02-02' AS Date), N'123456789', N'F', N'soltero', N'7123-6722', N'San salvador,soyapango', N'Resp De Finanzas')
INSERT [dbo].[Empleados] ([Id_empleado], [Nombre], [Apellido], [Sueldo_Base], [Fecha_Nacimiento], [Dui], [Sexo], [Estado_Civil], [Telefono], [Direccion], [Nombre_cargo]) VALUES (3, N'Alberto', N'Sanchez', CAST(500.00 AS Decimal(8, 2)), CAST(N'1995-02-02' AS Date), N'123456789', N'f', N'soltero', N'7156-8622', N'san vicente santa clara', N'Resp De Produccion')
INSERT [dbo].[Empleados] ([Id_empleado], [Nombre], [Apellido], [Sueldo_Base], [Fecha_Nacimiento], [Dui], [Sexo], [Estado_Civil], [Telefono], [Direccion], [Nombre_cargo]) VALUES (4, N'Romeo', N'Valles', CAST(600.00 AS Decimal(8, 2)), CAST(N'1994-02-02' AS Date), N'123456789', N'M', N'soltero', N'7123-9822', N'santa ana,san juan', N'Vendedor')
INSERT [dbo].[Empleados] ([Id_empleado], [Nombre], [Apellido], [Sueldo_Base], [Fecha_Nacimiento], [Dui], [Sexo], [Estado_Civil], [Telefono], [Direccion], [Nombre_cargo]) VALUES (5, N'Julio', N'Fuentes', CAST(500.00 AS Decimal(8, 2)), CAST(N'1998-02-02' AS Date), N'123456789', N'M', N'casado', N'7123-5422', N'san salvador,soyapango', N'Precidencia')
INSERT [dbo].[Empleados] ([Id_empleado], [Nombre], [Apellido], [Sueldo_Base], [Fecha_Nacimiento], [Dui], [Sexo], [Estado_Civil], [Telefono], [Direccion], [Nombre_cargo]) VALUES (6, N'Celia', N'Argumedo', CAST(600.00 AS Decimal(8, 2)), CAST(N'1991-02-02' AS Date), N'123456789', N'F', N'divorciada', N'7123-8634', N'san migel,san jorge', N'Resp De Finanzas')
INSERT [dbo].[Empleados] ([Id_empleado], [Nombre], [Apellido], [Sueldo_Base], [Fecha_Nacimiento], [Dui], [Sexo], [Estado_Civil], [Telefono], [Direccion], [Nombre_cargo]) VALUES (7, N'Georgina', N'Rivera', CAST(300.00 AS Decimal(8, 2)), CAST(N'1981-02-02' AS Date), N'123456789', N'F', N'soltero', N'7123-8634', N'san migel,santa elena', N'Atencion al cliente')
INSERT [dbo].[Empleados] ([Id_empleado], [Nombre], [Apellido], [Sueldo_Base], [Fecha_Nacimiento], [Dui], [Sexo], [Estado_Civil], [Telefono], [Direccion], [Nombre_cargo]) VALUES (8, N'Steffany', N'Trinidad', CAST(500.00 AS Decimal(8, 2)), CAST(N'1984-02-02' AS Date), N'123456789', N'F', N'casado', N'7123-8624', N'soyapango', N'Cajero')
INSERT [dbo].[Empleados] ([Id_empleado], [Nombre], [Apellido], [Sueldo_Base], [Fecha_Nacimiento], [Dui], [Sexo], [Estado_Civil], [Telefono], [Direccion], [Nombre_cargo]) VALUES (9, N'Guadalupe', N'Carranza', CAST(600.00 AS Decimal(8, 2)), CAST(N'1987-02-02' AS Date), N'123456789', N'F', N'soltera', N'7123-8657', N'Usulutan,jiquilisco', N'Gerente Administrativo ')
INSERT [dbo].[Empleados] ([Id_empleado], [Nombre], [Apellido], [Sueldo_Base], [Fecha_Nacimiento], [Dui], [Sexo], [Estado_Civil], [Telefono], [Direccion], [Nombre_cargo]) VALUES (10, N'Jese', N'Parada', CAST(400.00 AS Decimal(8, 2)), CAST(N'1975-02-02' AS Date), N'123456789', N'M', N'divorciado', N'7123-8665', N'Morazan,trompina', N'Gerente Administrativo')
INSERT [dbo].[Empleados] ([Id_empleado], [Nombre], [Apellido], [Sueldo_Base], [Fecha_Nacimiento], [Dui], [Sexo], [Estado_Civil], [Telefono], [Direccion], [Nombre_cargo]) VALUES (11, N'Lucia', N'Antonio', CAST(300.00 AS Decimal(8, 2)), CAST(N'1984-02-02' AS Date), N'123456789', N'F', N'soltera', N'7123-8646', N'cabañas,jutiapa', N'Resp De Finanzas')
INSERT [dbo].[Empleados] ([Id_empleado], [Nombre], [Apellido], [Sueldo_Base], [Fecha_Nacimiento], [Dui], [Sexo], [Estado_Civil], [Telefono], [Direccion], [Nombre_cargo]) VALUES (12, N'Herbert', N'Novoa', CAST(500.00 AS Decimal(8, 2)), CAST(N'1977-02-02' AS Date), N'123456789', N'M', N'viudo', N'7123-8656', N'chalatenango, san isidro', N'Gerente Comercial')
INSERT [dbo].[Empleados] ([Id_empleado], [Nombre], [Apellido], [Sueldo_Base], [Fecha_Nacimiento], [Dui], [Sexo], [Estado_Civil], [Telefono], [Direccion], [Nombre_cargo]) VALUES (13, N'Carlos', N'Antonio', CAST(300.00 AS Decimal(8, 2)), CAST(N'1974-02-02' AS Date), N'123456789', N'M', N'viudo', N'7123-8660', N'san salvador,san marcos', N'Resp De Finanzas')
INSERT [dbo].[Empleados] ([Id_empleado], [Nombre], [Apellido], [Sueldo_Base], [Fecha_Nacimiento], [Dui], [Sexo], [Estado_Civil], [Telefono], [Direccion], [Nombre_cargo]) VALUES (14, N'Alvaro', N'Sanchez', CAST(400.00 AS Decimal(8, 2)), CAST(N'1984-02-02' AS Date), N'123456789', N'M', N'casado', N'7123-8656', N'san vicente santa clara', N'Gerente Comercial')
INSERT [dbo].[Empleados] ([Id_empleado], [Nombre], [Apellido], [Sueldo_Base], [Fecha_Nacimiento], [Dui], [Sexo], [Estado_Civil], [Telefono], [Direccion], [Nombre_cargo]) VALUES (15, N'Vilma', N'Lopez', CAST(500.00 AS Decimal(8, 2)), CAST(N'1986-02-02' AS Date), N'123456789', N'F', N'soltera', N'7123-8622', N'soyapango', N'Gerente Administrativo')
INSERT [dbo].[Empleados] ([Id_empleado], [Nombre], [Apellido], [Sueldo_Base], [Fecha_Nacimiento], [Dui], [Sexo], [Estado_Civil], [Telefono], [Direccion], [Nombre_cargo]) VALUES (16, N'Rosa', N'Funes', CAST(400.00 AS Decimal(8, 2)), CAST(N'1977-02-02' AS Date), N'123456789', N'F', N'soltera', N'7123-8726', N'chalatenango caserios los amates', N'Resp De Finanzas')
INSERT [dbo].[Empleados] ([Id_empleado], [Nombre], [Apellido], [Sueldo_Base], [Fecha_Nacimiento], [Dui], [Sexo], [Estado_Civil], [Telefono], [Direccion], [Nombre_cargo]) VALUES (17, N'Ana', N'Orellana', CAST(500.00 AS Decimal(8, 2)), CAST(N'1978-02-02' AS Date), N'123456789', N'F', N'casada', N'7123-8622', N'san salvador mejicanos', N'Resp De Finanzas')
INSERT [dbo].[Empleados] ([Id_empleado], [Nombre], [Apellido], [Sueldo_Base], [Fecha_Nacimiento], [Dui], [Sexo], [Estado_Civil], [Telefono], [Direccion], [Nombre_cargo]) VALUES (18, N'Judith', N'Membreño', CAST(600.00 AS Decimal(8, 2)), CAST(N'1975-02-02' AS Date), N'123456789', N'F', N'soltera', N'7323-8622', N'san salvador nejapa', N'Gerente Administrativo')
INSERT [dbo].[Empleados] ([Id_empleado], [Nombre], [Apellido], [Sueldo_Base], [Fecha_Nacimiento], [Dui], [Sexo], [Estado_Civil], [Telefono], [Direccion], [Nombre_cargo]) VALUES (19, N'Marta', N'Guardado', CAST(400.00 AS Decimal(8, 2)), CAST(N'1984-02-02' AS Date), N'123456789', N'F', N'soltera', N'7123-8622', N'cabañas cinquera', N'Atencion al cliente')
INSERT [dbo].[Empleados] ([Id_empleado], [Nombre], [Apellido], [Sueldo_Base], [Fecha_Nacimiento], [Dui], [Sexo], [Estado_Civil], [Telefono], [Direccion], [Nombre_cargo]) VALUES (21, N'Carolina', N'Archila', CAST(200.00 AS Decimal(8, 2)), CAST(N'1986-02-02' AS Date), N'123456789', N'F', N'soltera', N'7123-8622', N'cabañas tenancingo', N'Atencion al cliente')
INSERT [dbo].[Empleados] ([Id_empleado], [Nombre], [Apellido], [Sueldo_Base], [Fecha_Nacimiento], [Dui], [Sexo], [Estado_Civil], [Telefono], [Direccion], [Nombre_cargo]) VALUES (22, N'Beatriz', N'Marroquin', CAST(500.00 AS Decimal(8, 2)), CAST(N'1982-02-02' AS Date), N'123456789', N'F', N'soltera', N'8123-8622', N'cuscatlan Recidencial  los almendros', N'Vendedor')
INSERT [dbo].[Empleados] ([Id_empleado], [Nombre], [Apellido], [Sueldo_Base], [Fecha_Nacimiento], [Dui], [Sexo], [Estado_Civil], [Telefono], [Direccion], [Nombre_cargo]) VALUES (23, N'Catalina', N'Coreas', CAST(600.00 AS Decimal(8, 2)), CAST(N'1985-02-02' AS Date), N'123456789', N'F', N'soltera', N'7123-8622', N'soyapango', N'Atencion al cliente')
INSERT [dbo].[Empleados] ([Id_empleado], [Nombre], [Apellido], [Sueldo_Base], [Fecha_Nacimiento], [Dui], [Sexo], [Estado_Civil], [Telefono], [Direccion], [Nombre_cargo]) VALUES (24, N'Rafael', N'Merino', CAST(500.00 AS Decimal(8, 2)), CAST(N'1987-02-02' AS Date), N'123456789', N'M', N'casado', N'7723-8622', N'soyapango', N'Vendedor')
INSERT [dbo].[Empleados] ([Id_empleado], [Nombre], [Apellido], [Sueldo_Base], [Fecha_Nacimiento], [Dui], [Sexo], [Estado_Civil], [Telefono], [Direccion], [Nombre_cargo]) VALUES (25, N'Rocio', N'Rosales', CAST(400.00 AS Decimal(8, 2)), CAST(N'1984-02-02' AS Date), N'123456789', N'F', N'soltera', N'7423-8622', N'cuscatlan suchitoto', N'Gerente Administrativo')
INSERT [dbo].[Empleados] ([Id_empleado], [Nombre], [Apellido], [Sueldo_Base], [Fecha_Nacimiento], [Dui], [Sexo], [Estado_Civil], [Telefono], [Direccion], [Nombre_cargo]) VALUES (26, N'Obed', N'Juarez', CAST(300.00 AS Decimal(8, 2)), CAST(N'1986-02-02' AS Date), N'123456789', N'M', N'casado', N'75123-8622', N'la paz,verapaz ', N'Vendedor')
INSERT [dbo].[Empleados] ([Id_empleado], [Nombre], [Apellido], [Sueldo_Base], [Fecha_Nacimiento], [Dui], [Sexo], [Estado_Civil], [Telefono], [Direccion], [Nombre_cargo]) VALUES (27, N'Jaime', N'Linares', CAST(500.00 AS Decimal(8, 2)), CAST(N'1985-02-02' AS Date), N'123456789', N'M', N'soltero', N'7153-8622', N'Santo tomas la paz', N'Vendedor')
INSERT [dbo].[Empleados] ([Id_empleado], [Nombre], [Apellido], [Sueldo_Base], [Fecha_Nacimiento], [Dui], [Sexo], [Estado_Civil], [Telefono], [Direccion], [Nombre_cargo]) VALUES (28, N'Rebeca', N'Webb', CAST(500.00 AS Decimal(8, 2)), CAST(N'1986-02-02' AS Date), N'123456789', N'F', N'casada', N'7623-8622', N'santa teresa la union', N'Gerente Administrativo')
INSERT [dbo].[Empleados] ([Id_empleado], [Nombre], [Apellido], [Sueldo_Base], [Fecha_Nacimiento], [Dui], [Sexo], [Estado_Civil], [Telefono], [Direccion], [Nombre_cargo]) VALUES (29, N'Amilcar', N'Aguila', CAST(0.00 AS Decimal(8, 2)), CAST(N'1995-02-02' AS Date), N'12345679', N'M', N'soltero', N'7823-8622', N'san salvador,soyapango', N'Vendedor')
INSERT [dbo].[Empleados] ([Id_empleado], [Nombre], [Apellido], [Sueldo_Base], [Fecha_Nacimiento], [Dui], [Sexo], [Estado_Civil], [Telefono], [Direccion], [Nombre_cargo]) VALUES (30, N'Sonia', N'Hernandez', CAST(0.00 AS Decimal(8, 2)), CAST(N'1999-02-02' AS Date), N'123456789', N'F', N'divorciada', N'7888-8622', N'san salvador,soyapango', N'Gerente Administrativo')
INSERT [dbo].[Empleados] ([Id_empleado], [Nombre], [Apellido], [Sueldo_Base], [Fecha_Nacimiento], [Dui], [Sexo], [Estado_Civil], [Telefono], [Direccion], [Nombre_cargo]) VALUES (31, N'Lorem', N'Ipsum', CAST(100.00 AS Decimal(8, 2)), CAST(N'1999-12-12' AS Date), N'11234566-7', N'F', N'casada', N'1234-5678', N'Lorem de Ipsum', N'Gerente Administrativo ')
SET IDENTITY_INSERT [dbo].[Encabezado_Fac] ON 

INSERT [dbo].[Encabezado_Fac] ([cod_examen], [id_Empleado], [id_Formapago], [fecha], [Nit], [No_Registro], [Num_Tarjeta], [sub_total], [iva], [total], [id_tipopago]) VALUES (2, 1, 2, CAST(N'2020-05-10' AS Date), N'01012145874', N'061458745', N'00000000321', CAST(200.00 AS Decimal(8, 2)), CAST(26.00 AS Decimal(8, 2)), CAST(226.00 AS Decimal(8, 2)), 1)
INSERT [dbo].[Encabezado_Fac] ([cod_examen], [id_Empleado], [id_Formapago], [fecha], [Nit], [No_Registro], [Num_Tarjeta], [sub_total], [iva], [total], [id_tipopago]) VALUES (3, 2, 1, CAST(N'2020-05-19' AS Date), N'', N'', N'', CAST(45000.00 AS Decimal(8, 2)), CAST(0.00 AS Decimal(8, 2)), CAST(45000.00 AS Decimal(8, 2)), 2)
INSERT [dbo].[Encabezado_Fac] ([cod_examen], [id_Empleado], [id_Formapago], [fecha], [Nit], [No_Registro], [Num_Tarjeta], [sub_total], [iva], [total], [id_tipopago]) VALUES (4, 1, 1, CAST(N'2020-05-19' AS Date), N'', N'', N'', CAST(40.00 AS Decimal(8, 2)), CAST(0.00 AS Decimal(8, 2)), CAST(40.00 AS Decimal(8, 2)), 3)
INSERT [dbo].[Encabezado_Fac] ([cod_examen], [id_Empleado], [id_Formapago], [fecha], [Nit], [No_Registro], [Num_Tarjeta], [sub_total], [iva], [total], [id_tipopago]) VALUES (5, 1, 1, CAST(N'2020-05-19' AS Date), N'', N'', N'', CAST(0.00 AS Decimal(8, 2)), CAST(0.00 AS Decimal(8, 2)), CAST(0.00 AS Decimal(8, 2)), 3)
INSERT [dbo].[Encabezado_Fac] ([cod_examen], [id_Empleado], [id_Formapago], [fecha], [Nit], [No_Registro], [Num_Tarjeta], [sub_total], [iva], [total], [id_tipopago]) VALUES (9, 31, 2, CAST(N'2020-05-19' AS Date), N'22222', N'1122134', N'3323433', CAST(1419.00 AS Decimal(8, 2)), CAST(0.00 AS Decimal(8, 2)), CAST(1419.00 AS Decimal(8, 2)), 1)
INSERT [dbo].[Encabezado_Fac] ([cod_examen], [id_Empleado], [id_Formapago], [fecha], [Nit], [No_Registro], [Num_Tarjeta], [sub_total], [iva], [total], [id_tipopago]) VALUES (10, 21, 1, CAST(N'2020-06-11' AS Date), N'     -       - ', N'', N'    -    -    -', CAST(680.00 AS Decimal(8, 2)), CAST(0.00 AS Decimal(8, 2)), CAST(680.00 AS Decimal(8, 2)), 2)
INSERT [dbo].[Encabezado_Fac] ([cod_examen], [id_Empleado], [id_Formapago], [fecha], [Nit], [No_Registro], [Num_Tarjeta], [sub_total], [iva], [total], [id_tipopago]) VALUES (11, 5, 1, CAST(N'2020-06-11' AS Date), N'     -       - ', N'', N'    -    -    -', CAST(350.00 AS Decimal(8, 2)), CAST(91.00 AS Decimal(8, 2)), CAST(441.00 AS Decimal(8, 2)), 1)
SET IDENTITY_INSERT [dbo].[Encabezado_Fac] OFF
INSERT [dbo].[EstadoCivil] ([Estado_Civil]) VALUES (N'casada')
INSERT [dbo].[EstadoCivil] ([Estado_Civil]) VALUES (N'casado')
INSERT [dbo].[EstadoCivil] ([Estado_Civil]) VALUES (N'divorciada')
INSERT [dbo].[EstadoCivil] ([Estado_Civil]) VALUES (N'divorciado')
INSERT [dbo].[EstadoCivil] ([Estado_Civil]) VALUES (N'soltera')
INSERT [dbo].[EstadoCivil] ([Estado_Civil]) VALUES (N'soltero')
INSERT [dbo].[EstadoCivil] ([Estado_Civil]) VALUES (N'viuda')
INSERT [dbo].[EstadoCivil] ([Estado_Civil]) VALUES (N'viudo')
SET IDENTITY_INSERT [dbo].[Forma_Pago] ON 

INSERT [dbo].[Forma_Pago] ([id_Formapago], [nombre]) VALUES (1, N'Efectivo')
INSERT [dbo].[Forma_Pago] ([id_Formapago], [nombre]) VALUES (2, N'Tarjeta')
INSERT [dbo].[Forma_Pago] ([id_Formapago], [nombre]) VALUES (3, N'Cheque')
SET IDENTITY_INSERT [dbo].[Forma_Pago] OFF
INSERT [dbo].[Genero] ([Sexo]) VALUES (N'F')
INSERT [dbo].[Genero] ([Sexo]) VALUES (N'M')
INSERT [dbo].[Productos] ([ID], [Codigo], [Nombre], [Marca], [Modelo], [Precio], [Nombre_Categoria]) VALUES (1, N'pro1', N'Botas Dr. Marten', N'adidas', N'cuero', CAST(25.00 AS Decimal(5, 2)), N'Zapatillas o Tenis Blancos')
INSERT [dbo].[Productos] ([ID], [Codigo], [Nombre], [Marca], [Modelo], [Precio], [Nombre_Categoria]) VALUES (2, N'pro2', N'zapato tenis casual', N'adidas Originals', N'sharol', CAST(75.00 AS Decimal(5, 2)), N'Zapatillas o Tenis Blancos')
INSERT [dbo].[Productos] ([ID], [Codigo], [Nombre], [Marca], [Modelo], [Precio], [Nombre_Categoria]) VALUES (3, N'pro3', N'Botas australianas', N'Antea', N'Lona', CAST(40.00 AS Decimal(5, 2)), N'Mocasines')
INSERT [dbo].[Productos] ([ID], [Codigo], [Nombre], [Marca], [Modelo], [Precio], [Nombre_Categoria]) VALUES (4, N'pro4', N'Desert Boots', N'Buffalo', N'cuero', CAST(35.00 AS Decimal(5, 2)), N'Mocasines')
INSERT [dbo].[Productos] ([ID], [Codigo], [Nombre], [Marca], [Modelo], [Precio], [Nombre_Categoria]) VALUES (5, N'pro5', N'Lita Boots', N'Victoria', N'cuero', CAST(65.00 AS Decimal(5, 2)), N'Oxford Lisos')
INSERT [dbo].[Productos] ([ID], [Codigo], [Nombre], [Marca], [Modelo], [Precio], [Nombre_Categoria]) VALUES (6, N'pro6', N'Zapatos Planos ', N'Fioni', N'cuero', CAST(85.00 AS Decimal(5, 2)), N'Oxford Lisos')
INSERT [dbo].[Productos] ([ID], [Codigo], [Nombre], [Marca], [Modelo], [Precio], [Nombre_Categoria]) VALUES (7, N'pro7', N'Sandalias de Tacón Florales Azules Hanna para mujer', N'Brash ', N'cuero', CAST(75.00 AS Decimal(5, 2)), N'Mocasines')
INSERT [dbo].[Productos] ([ID], [Codigo], [Nombre], [Marca], [Modelo], [Precio], [Nombre_Categoria]) VALUES (8, N'pro8', N'Derby', N'Zendra Basic', N'cuero', CAST(85.00 AS Decimal(5, 2)), N'Zapatos Monk')
INSERT [dbo].[Productos] ([ID], [Codigo], [Nombre], [Marca], [Modelo], [Precio], [Nombre_Categoria]) VALUES (9, N'pro9', N'Sandalias de Tacón  Cognac Nadine para mujer', N'Brash', N'cuero', CAST(85.00 AS Decimal(5, 2)), N'Oxford Lisos')
INSERT [dbo].[Productos] ([ID], [Codigo], [Nombre], [Marca], [Modelo], [Precio], [Nombre_Categoria]) VALUES (10, N'pro10', N'Derby', N'gucci', N'lona', CAST(15.99 AS Decimal(5, 2)), N'Oxford Lisos')
INSERT [dbo].[Productos] ([ID], [Codigo], [Nombre], [Marca], [Modelo], [Precio], [Nombre_Categoria]) VALUES (11, N'pro11', N'Monk', N'Nike', N'cuero', CAST(150.99 AS Decimal(5, 2)), N'Oxford Lisos')
INSERT [dbo].[Productos] ([ID], [Codigo], [Nombre], [Marca], [Modelo], [Precio], [Nombre_Categoria]) VALUES (12, N'pro12', N'Mocasín', N'Adidas', N'lona', CAST(154.99 AS Decimal(5, 2)), N'Oxford Lisos')
INSERT [dbo].[Productos] ([ID], [Codigo], [Nombre], [Marca], [Modelo], [Precio], [Nombre_Categoria]) VALUES (13, N'pro13', N'Dockside o náutico', N'Adidas', N'cuero', CAST(153.99 AS Decimal(5, 2)), N'Oxford Lisos')
INSERT [dbo].[Productos] ([ID], [Codigo], [Nombre], [Marca], [Modelo], [Precio], [Nombre_Categoria]) VALUES (14, N'pro14', N'Sneakers', N'Adidas', N'cuero', CAST(154.99 AS Decimal(5, 2)), N'Mocasines')
INSERT [dbo].[Productos] ([ID], [Codigo], [Nombre], [Marca], [Modelo], [Precio], [Nombre_Categoria]) VALUES (15, N'pro15', N'Scarpin', N'gucci', N'lona', CAST(156.99 AS Decimal(5, 2)), N'Oxford Lisos')
INSERT [dbo].[Productos] ([ID], [Codigo], [Nombre], [Marca], [Modelo], [Precio], [Nombre_Categoria]) VALUES (16, N'pro16', N'Peep-toe', N'Adidas', N'lona', CAST(157.99 AS Decimal(5, 2)), N'Mocasines')
INSERT [dbo].[Productos] ([ID], [Codigo], [Nombre], [Marca], [Modelo], [Precio], [Nombre_Categoria]) VALUES (17, N'pro17', N'Pumps', N'Nike', N'sharol', CAST(158.99 AS Decimal(5, 2)), N'Mocasines')
INSERT [dbo].[Productos] ([ID], [Codigo], [Nombre], [Marca], [Modelo], [Precio], [Nombre_Categoria]) VALUES (18, N'pro17', N'High Heels', N'gucci', N' sharol', CAST(151.99 AS Decimal(5, 2)), N'Mocasines')
INSERT [dbo].[Productos] ([ID], [Codigo], [Nombre], [Marca], [Modelo], [Precio], [Nombre_Categoria]) VALUES (19, N'pro19', N'Stiletto', N'Nike', N'lona', CAST(152.99 AS Decimal(5, 2)), N'Oxford Lisos')
INSERT [dbo].[Productos] ([ID], [Codigo], [Nombre], [Marca], [Modelo], [Precio], [Nombre_Categoria]) VALUES (20, N'pro20', N'Kitten Heel', N'gucci', N'lona', CAST(153.99 AS Decimal(5, 2)), N'Oxford Lisos')
INSERT [dbo].[Productos] ([ID], [Codigo], [Nombre], [Marca], [Modelo], [Precio], [Nombre_Categoria]) VALUES (21, N'pro21', N'Tenis  Grises Negros y Rosas Concur Sport para mujer', N' lona', N'cuero', CAST(50.00 AS Decimal(5, 2)), N'Oxford Lisos')
INSERT [dbo].[Productos] ([ID], [Codigo], [Nombre], [Marca], [Modelo], [Precio], [Nombre_Categoria]) VALUES (22, N'pro22', N'Tenis Champion Navy Concur ', N'Champion', N'lona', CAST(85.00 AS Decimal(5, 2)), N'Mocasines')
INSERT [dbo].[Productos] ([ID], [Codigo], [Nombre], [Marca], [Modelo], [Precio], [Nombre_Categoria]) VALUES (23, N'pro23', N'Derby', N'Botas de Cuña American Eagle Oro Madrid para niñas', N'cuero', CAST(65.00 AS Decimal(5, 2)), N'Zapatos Brogue')
INSERT [dbo].[Productos] ([ID], [Codigo], [Nombre], [Marca], [Modelo], [Precio], [Nombre_Categoria]) VALUES (24, N'pro24', N'Sandalias Airwalk Negras ', N'Airwalk Basic', N'cuero', CAST(50.00 AS Decimal(5, 2)), N'Mocasines')
INSERT [dbo].[Productos] ([ID], [Codigo], [Nombre], [Marca], [Modelo], [Precio], [Nombre_Categoria]) VALUES (25, N'pro25', N'Sandalias Cafés', N'American Eagle ', N'cuero', CAST(75.00 AS Decimal(5, 2)), N'Mocasines')
INSERT [dbo].[Productos] ([ID], [Codigo], [Nombre], [Marca], [Modelo], [Precio], [Nombre_Categoria]) VALUES (26, N'pro26', N'Sandalias para mujer', N' Brash Navy Print Janie', N'cuero', CAST(54.00 AS Decimal(5, 2)), N'Zapatos Brogue')
INSERT [dbo].[Productos] ([ID], [Codigo], [Nombre], [Marca], [Modelo], [Precio], [Nombre_Categoria]) VALUES (27, N'pro27', N'Zapatos de Tacón ', N'Christian Siriano', N'cuero', CAST(45.00 AS Decimal(5, 2)), N'Zapatos Monk')
INSERT [dbo].[Productos] ([ID], [Codigo], [Nombre], [Marca], [Modelo], [Precio], [Nombre_Categoria]) VALUES (28, N'pro28', N'Tenis  Tan Recreate para mujer Planos  Nude y Amarillos Audra para mujer', N'Champion', N'lona', CAST(85.00 AS Decimal(5, 2)), N'Zapatos Brogue')
INSERT [dbo].[Productos] ([ID], [Codigo], [Nombre], [Marca], [Modelo], [Precio], [Nombre_Categoria]) VALUES (29, N'pro29', N'Tenis  Grises Loren para mujer', N'American Eagle', N'lona', CAST(55.00 AS Decimal(5, 2)), N'Zapatos Monk')
INSERT [dbo].[Productos] ([ID], [Codigo], [Nombre], [Marca], [Modelo], [Precio], [Nombre_Categoria]) VALUES (30, N'pro30', N'Zapatos de Tacón  Navy Lucy Pleat para mujer', N' Fioni', N'cuero', CAST(85.00 AS Decimal(5, 2)), N'Zapatos Monk')
INSERT [dbo].[Roles] ([ID_Rol], [Nombre_Rol], [Descripcion_Corta_Rol]) VALUES (N'Administrador', N'Usuarios Nivel Administradores', N'Departamento de Sistemas TIC')
INSERT [dbo].[Roles] ([ID_Rol], [Nombre_Rol], [Descripcion_Corta_Rol]) VALUES (N'AtencionClientes', N'Atención Al Cliente', N'Departamento de Atención al Cliente, empleados generales')
INSERT [dbo].[Roles] ([ID_Rol], [Nombre_Rol], [Descripcion_Corta_Rol]) VALUES (N'CajerosFC', N'Ventas Full Calzado', N'Empleados Ventas Directas Full Calzado S.A de C.V')
INSERT [dbo].[Roles] ([ID_Rol], [Nombre_Rol], [Descripcion_Corta_Rol]) VALUES (N'Presidencia', N'Presidencia Gerencia', N'Departamento de presidencia, gerencia general')
INSERT [dbo].[Roles] ([ID_Rol], [Nombre_Rol], [Descripcion_Corta_Rol]) VALUES (N'RRHH', N'Recursos Humanos', N'Departamento de Recursos Humanos (RR.HH)')
SET IDENTITY_INSERT [dbo].[tipo_pago] ON 

INSERT [dbo].[tipo_pago] ([id_tipopago], [nombre]) VALUES (1, N'Credito F')
INSERT [dbo].[tipo_pago] ([id_tipopago], [nombre]) VALUES (2, N'Ticket')
INSERT [dbo].[tipo_pago] ([id_tipopago], [nombre]) VALUES (3, N'Factura')
SET IDENTITY_INSERT [dbo].[tipo_pago] OFF
INSERT [dbo].[Usuarios] ([ID_usuario], [Nombre], [Apellido], [Nombre_Usuario], [Contrasenia], [ID_Rol]) VALUES (17, N'Invitado', N'Administrador', N'invitado1', N'NieQminDE4Ggcewn98nKl3Jhgq7Smn3dLlQ1MyLPswq7njpt8qwsIP4jQ2MR1nhWTQyNMFkwV19g4tPQSBhNeQ==', N'Administrador')
INSERT [dbo].[Usuarios] ([ID_usuario], [Nombre], [Apellido], [Nombre_Usuario], [Contrasenia], [ID_Rol]) VALUES (2, N'Fernando', N'Sanchez', N'fernanAsG', N'wcYTu109ZAllFyz701ZMSb3BNJE+Tcb2SSH5S0IC/xZtQuCChna9mw6iinz0qWNK1NhdIRURm4/WuWMUn8xPSg==', N'Administrador')
INSERT [dbo].[Usuarios] ([ID_usuario], [Nombre], [Apellido], [Nombre_Usuario], [Contrasenia], [ID_Rol]) VALUES (3, N'Christian', N'Monge', N'christian.monge', N'wcYTu109ZAllFyz701ZMSb3BNJE+Tcb2SSH5S0IC/xZtQuCChna9mw6iinz0qWNK1NhdIRURm4/WuWMUn8xPSg==', N'Administrador')
INSERT [dbo].[Usuarios] ([ID_usuario], [Nombre], [Apellido], [Nombre_Usuario], [Contrasenia], [ID_Rol]) VALUES (5, N'Xenia', N'Najarro', N'xenia.najarro', N'wcYTu109ZAllFyz701ZMSb3BNJE+Tcb2SSH5S0IC/xZtQuCChna9mw6iinz0qWNK1NhdIRURm4/WuWMUn8xPSg==', N'Administrador')
INSERT [dbo].[Usuarios] ([ID_usuario], [Nombre], [Apellido], [Nombre_Usuario], [Contrasenia], [ID_Rol]) VALUES (7, N'Roxana', N'Miranda', N'roxana.miranda', N'1ARVn2Auq2/WAqx2gNrL+q3RNjAzXpUfCXrzkA6d4Xa22yhRLy4AC50E+6UTPoscbo31nbOoq51gvkuXzJ6B2w==', N'Presidencia')
INSERT [dbo].[Usuarios] ([ID_usuario], [Nombre], [Apellido], [Nombre_Usuario], [Contrasenia], [ID_Rol]) VALUES (11, N'Alejandro', N'Guzman', N'alejandro.guzman', N'1ARVn2Auq2/WAqx2gNrL+q3RNjAzXpUfCXrzkA6d4Xa22yhRLy4AC50E+6UTPoscbo31nbOoq51gvkuXzJ6B2w==', N'Presidencia')
INSERT [dbo].[Usuarios] ([ID_usuario], [Nombre], [Apellido], [Nombre_Usuario], [Contrasenia], [ID_Rol]) VALUES (13, N'Manuel', N'Aguilar', N'manuel.aguilar', N'1ARVn2Auq2/WAqx2gNrL+q3RNjAzXpUfCXrzkA6d4Xa22yhRLy4AC50E+6UTPoscbo31nbOoq51gvkuXzJ6B2w==', N'RRHH')
INSERT [dbo].[Usuarios] ([ID_usuario], [Nombre], [Apellido], [Nombre_Usuario], [Contrasenia], [ID_Rol]) VALUES (14, N'Javier', N'Argueta', N'javier.argueta', N'1ARVn2Auq2/WAqx2gNrL+q3RNjAzXpUfCXrzkA6d4Xa22yhRLy4AC50E+6UTPoscbo31nbOoq51gvkuXzJ6B2w==', N'RRHH')
INSERT [dbo].[Usuarios] ([ID_usuario], [Nombre], [Apellido], [Nombre_Usuario], [Contrasenia], [ID_Rol]) VALUES (16, N'Daniela', N'Ramirez', N'daniela.ramirez', N'6706eb4e21de1fe7f75f8d7dffb23d714c6e44188e5aea11cf5f3af936ce0145', N'AtencionClientes')
INSERT [dbo].[Usuarios] ([ID_usuario], [Nombre], [Apellido], [Nombre_Usuario], [Contrasenia], [ID_Rol]) VALUES (444, N'dd', N'dd', N'dd', N'PJkJr+wlNU1VHa4hWQuybjjVPyFzuNPcPu5MBH56scHri4UQPjvnumE7MbtcnDYhTcnxSkL9ei/bhIVrylxEwg==', N'Administrador')
INSERT [dbo].[Usuarios] ([ID_usuario], [Nombre], [Apellido], [Nombre_Usuario], [Contrasenia], [ID_Rol]) VALUES (18, N'Invitado', N'Presidencia', N'invitado2', N'NieQminDE4Ggcewn98nKl3Jhgq7Smn3dLlQ1MyLPswq7njpt8qwsIP4jQ2MR1nhWTQyNMFkwV19g4tPQSBhNeQ==', N'Presidencia')
INSERT [dbo].[Usuarios] ([ID_usuario], [Nombre], [Apellido], [Nombre_Usuario], [Contrasenia], [ID_Rol]) VALUES (19, N'Invitado', N'RRHH', N'invitado3', N'NieQminDE4Ggcewn98nKl3Jhgq7Smn3dLlQ1MyLPswq7njpt8qwsIP4jQ2MR1nhWTQyNMFkwV19g4tPQSBhNeQ==', N'RRHH')
INSERT [dbo].[Usuarios] ([ID_usuario], [Nombre], [Apellido], [Nombre_Usuario], [Contrasenia], [ID_Rol]) VALUES (20, N'Invitado', N'Atencion Al Cliente', N'invitado4', N'NieQminDE4Ggcewn98nKl3Jhgq7Smn3dLlQ1MyLPswq7njpt8qwsIP4jQ2MR1nhWTQyNMFkwV19g4tPQSBhNeQ==', N'AtencionClientes')
INSERT [dbo].[Usuarios] ([ID_usuario], [Nombre], [Apellido], [Nombre_Usuario], [Contrasenia], [ID_Rol]) VALUES (21, N'Invitado', N'Cajeros', N'invitado5', N'NieQminDE4Ggcewn98nKl3Jhgq7Smn3dLlQ1MyLPswq7njpt8qwsIP4jQ2MR1nhWTQyNMFkwV19g4tPQSBhNeQ==', N'CajerosFC')
INSERT [dbo].[Usuarios] ([ID_usuario], [Nombre], [Apellido], [Nombre_Usuario], [Contrasenia], [ID_Rol]) VALUES (4, N'Karla', N'Navas', N'karla.navas', N'wcYTu109ZAllFyz701ZMSb3BNJE+Tcb2SSH5S0IC/xZtQuCChna9mw6iinz0qWNK1NhdIRURm4/WuWMUn8xPSg==', N'Administrador')
INSERT [dbo].[Usuarios] ([ID_usuario], [Nombre], [Apellido], [Nombre_Usuario], [Contrasenia], [ID_Rol]) VALUES (6, N'Mario', N'Lopez', N'mario.lopez', N'1ARVn2Auq2/WAqx2gNrL+q3RNjAzXpUfCXrzkA6d4Xa22yhRLy4AC50E+6UTPoscbo31nbOoq51gvkuXzJ6B2w==', N'RRHH')
INSERT [dbo].[Usuarios] ([ID_usuario], [Nombre], [Apellido], [Nombre_Usuario], [Contrasenia], [ID_Rol]) VALUES (8, N'Lourdes', N'Ramos', N'lourdes.ramos', N'1ARVn2Auq2/WAqx2gNrL+q3RNjAzXpUfCXrzkA6d4Xa22yhRLy4AC50E+6UTPoscbo31nbOoq51gvkuXzJ6B2w==', N'AtencionClientes')
INSERT [dbo].[Usuarios] ([ID_usuario], [Nombre], [Apellido], [Nombre_Usuario], [Contrasenia], [ID_Rol]) VALUES (9, N'Kenia', N'Solano', N'kenia.solano', N'1ARVn2Auq2/WAqx2gNrL+q3RNjAzXpUfCXrzkA6d4Xa22yhRLy4AC50E+6UTPoscbo31nbOoq51gvkuXzJ6B2w==', N'CajerosFC')
INSERT [dbo].[Usuarios] ([ID_usuario], [Nombre], [Apellido], [Nombre_Usuario], [Contrasenia], [ID_Rol]) VALUES (10, N'Marcos', N'Gutierrez', N'marco.gutierrez', N'1ARVn2Auq2/WAqx2gNrL+q3RNjAzXpUfCXrzkA6d4Xa22yhRLy4AC50E+6UTPoscbo31nbOoq51gvkuXzJ6B2w==', N'Presidencia')
INSERT [dbo].[Usuarios] ([ID_usuario], [Nombre], [Apellido], [Nombre_Usuario], [Contrasenia], [ID_Rol]) VALUES (12, N'Maria', N'Rodriguez', N'maria.rodriguez', N'1ARVn2Auq2/WAqx2gNrL+q3RNjAzXpUfCXrzkA6d4Xa22yhRLy4AC50E+6UTPoscbo31nbOoq51gvkuXzJ6B2w==', N'RRHH')
INSERT [dbo].[Usuarios] ([ID_usuario], [Nombre], [Apellido], [Nombre_Usuario], [Contrasenia], [ID_Rol]) VALUES (15, N'David', N'Cruz', N'david.cruz', N'1ARVn2Auq2/WAqx2gNrL+q3RNjAzXpUfCXrzkA6d4Xa22yhRLy4AC50E+6UTPoscbo31nbOoq51gvkuXzJ6B2w==', N'AtencionClientes')
INSERT [dbo].[Usuarios] ([ID_usuario], [Nombre], [Apellido], [Nombre_Usuario], [Contrasenia], [ID_Rol]) VALUES (1, N'Daniel', N'Rivera', N'daniel.rivera', N'eCjJ1IxK+E972SUkjnBHVwoMwM5UV5VrTqkNjoFqCJrgm3JT8PpvgtA9pSr8151X+d6KJimryyWnVUP0JKA7RA==', N'Administrador')
ALTER TABLE [dbo].[Detalle_Fac]  WITH CHECK ADD FOREIGN KEY([cod_examen])
REFERENCES [dbo].[Encabezado_Fac] ([cod_examen])
GO
ALTER TABLE [dbo].[Detalle_Fac]  WITH CHECK ADD FOREIGN KEY([id_Producto])
REFERENCES [dbo].[Productos] ([ID])
GO
ALTER TABLE [dbo].[Empleados]  WITH CHECK ADD FOREIGN KEY([Estado_Civil])
REFERENCES [dbo].[EstadoCivil] ([Estado_Civil])
GO
ALTER TABLE [dbo].[Empleados]  WITH CHECK ADD FOREIGN KEY([Nombre_cargo])
REFERENCES [dbo].[Cargos] ([Nombre_cargo])
GO
ALTER TABLE [dbo].[Empleados]  WITH CHECK ADD FOREIGN KEY([Sexo])
REFERENCES [dbo].[Genero] ([Sexo])
GO
ALTER TABLE [dbo].[Encabezado_Fac]  WITH CHECK ADD FOREIGN KEY([id_Empleado])
REFERENCES [dbo].[Empleados] ([Id_empleado])
GO
ALTER TABLE [dbo].[Encabezado_Fac]  WITH CHECK ADD FOREIGN KEY([id_Formapago])
REFERENCES [dbo].[Forma_Pago] ([id_Formapago])
GO
ALTER TABLE [dbo].[Encabezado_Fac]  WITH CHECK ADD FOREIGN KEY([id_tipopago])
REFERENCES [dbo].[tipo_pago] ([id_tipopago])
GO
ALTER TABLE [dbo].[Productos]  WITH CHECK ADD FOREIGN KEY([Nombre_Categoria])
REFERENCES [dbo].[Categoria] ([Nombre_Categoria])
GO
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD FOREIGN KEY([ID_Rol])
REFERENCES [dbo].[Roles] ([ID_Rol])
GO
/****** Object:  StoredProcedure [dbo].[INSER_DET_FAC]    Script Date: 19/06/2020 15:57:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[INSER_DET_FAC]
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
ALTER AUTHORIZATION ON [dbo].[INSER_DET_FAC] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[INSER_FAC]    Script Date: 19/06/2020 15:57:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[INSER_FAC]
@id_Empleado INT, @id_Formapago INT, @fecha date, @Nit varchar(15), @No_Registro varchar(10), @Num_tarjeta varchar(20),
@sub_total decimal(8,2), @iva decimal(8,2), @total decimal(8,2), @id_tipopago int
AS
BEGIN
INSERT INTO Encabezado_Fac(id_Empleado,id_Formapago,fecha,Nit,No_Registro,Num_tarjeta,sub_total,iva,total,id_tipopago)
 VALUES (@id_Empleado,@id_Formapago,@fecha,@Nit,@No_Registro,@Num_tarjeta,@sub_total,@iva,@total,@id_tipopago)
END

GO
ALTER AUTHORIZATION ON [dbo].[INSER_FAC] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[ListadProductos]    Script Date: 19/06/2020 15:57:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ListadProductos]
as 
begin
SELECT        Codigo, Nombre, Marca, Modelo, Precio, Nombre_Categoria
FROM            Productos
ORDER BY Codigo, Nombre
end

GO
ALTER AUTHORIZATION ON [dbo].[ListadProductos] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[MontosTotalProductos]    Script Date: 19/06/2020 15:57:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[MontosTotalProductos]
as begin 
select p.Codigo,p.Nombre,sum(p.Precio*d.Cantidad) 
from productos  as p inner join Detalle_Fac as d
on p.ID=d.id_Producto 
group by p.Codigo, p.Nombre
order by sum(p.Precio*d.Cantidad)  asc
end

GO
ALTER AUTHORIZATION ON [dbo].[MontosTotalProductos] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[MostrarEmpleado]    Script Date: 19/06/2020 15:57:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[MostrarEmpleado]
as 
begin
SELECT Id_empleado, Nombre, Apellido, Sueldo_Base, Fecha_Nacimiento, Dui, Sexo, Estado_Civil, Telefono, Direccion, Nombre_cargo 
FROM dbo.Empleados
end

GO
ALTER AUTHORIZATION ON [dbo].[MostrarEmpleado] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[ProductosDañados]    Script Date: 19/06/2020 15:57:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ProductosDañados]
as
begin
SELECT  Productos.Nombre, Productos.Marca, Detalle_Fac.cantidad, Detalle_Fac.precio, Encabezado_Fac.total
FROM    Productos INNER JOIN
        Detalle_Fac ON Productos.ID = Detalle_Fac.id_Producto AND Productos.ID = Detalle_Fac.id_Producto INNER JOIN
        Encabezado_Fac ON Detalle_Fac.cod_examen = Encabezado_Fac.cod_examen AND Detalle_Fac.cod_examen = Encabezado_Fac.cod_examen
ORDER BY Productos.Nombre
end

GO
ALTER AUTHORIZATION ON [dbo].[ProductosDañados] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[REPORTEEMPLEADO]    Script Date: 19/06/2020 15:57:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[REPORTEEMPLEADO]
as begin
SELECT        e.Nombre, e.Nombre_cargo, SUM(e.Sueldo_Base) 
FROM          Empleados AS e 
GROUP BY e.Nombre_cargo, e.Nombre
end

GO
ALTER AUTHORIZATION ON [dbo].[REPORTEEMPLEADO] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[ReporteVentasEmpleado]    Script Date: 19/06/2020 15:57:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[ReporteVentasEmpleado]
 as begin
select e.Nombre,e.Apellido,fecha,sum (en.total)
from Empleados  as e inner join Encabezado_Fac as en
on en.Id_empleado = e.Id_empleado
group by e.Nombre,en.fecha,e.Apellido
end

GO
ALTER AUTHORIZATION ON [dbo].[ReporteVentasEmpleado] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[SP_eliminar_factura]    Script Date: 19/06/2020 15:57:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_eliminar_factura]
@ID_FACTURA INT
AS
BEGIN
DELETE FROM Detalle_Fac where cod_examen=@ID_FACTURA;
DELETE FROM Encabezado_Fac where cod_examen=@ID_FACTURA;
END

GO
ALTER AUTHORIZATION ON [dbo].[SP_eliminar_factura] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[sp_EliminarCargos]    Script Date: 19/06/2020 15:57:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_EliminarCargos]
@Id_cargo AS int
as
begin
delete from  cargos where Id_cargo=@Id_cargo
end

GO
ALTER AUTHORIZATION ON [dbo].[sp_EliminarCargos] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[sp_EliminarCategoria]    Script Date: 19/06/2020 15:57:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_EliminarCategoria]
@ID_categoria Varchar(100)
as
begin
delete from  Categoria where ID_categoria = @ID_categoria
end

GO
ALTER AUTHORIZATION ON [dbo].[sp_EliminarCategoria] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[sp_EliminarEmpleados]    Script Date: 19/06/2020 15:57:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_EliminarEmpleados]
@Id_empleado AS int
as
begin
delete from  Empleados where Id_empleado=@Id_empleado
end 

GO
ALTER AUTHORIZATION ON [dbo].[sp_EliminarEmpleados] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[sp_EliminarProductos]    Script Date: 19/06/2020 15:57:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_EliminarProductos]
@ID AS int
as
begin
delete from  Productos where ID=@ID	
end 

GO
ALTER AUTHORIZATION ON [dbo].[sp_EliminarProductos] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[sp_EliminarRolesUsuarios]    Script Date: 19/06/2020 15:57:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_EliminarRolesUsuarios]
	@ID_Rol varchar(30)
AS 
BEGIN
	DELETE FROM Roles WHERE ID_Rol = @ID_Rol;
END

GO
ALTER AUTHORIZATION ON [dbo].[sp_EliminarRolesUsuarios] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[sp_EliminarUsuarios]    Script Date: 19/06/2020 15:57:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_EliminarUsuarios]
	@ID_usuario int
AS 
BEGIN
	DELETE FROM Usuarios WHERE ID_Usuario = @ID_usuario;
END

GO
ALTER AUTHORIZATION ON [dbo].[sp_EliminarUsuarios] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[sp_insertar_tipodoc]    Script Date: 19/06/2020 15:57:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_insertar_tipodoc]
@nombre varchar(10)
AS
BEGIN
INSERT INTO tipo_pago (nombre) VALUES(@nombre)
END

GO
ALTER AUTHORIZATION ON [dbo].[sp_insertar_tipodoc] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertarCargos]    Script Date: 19/06/2020 15:57:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_InsertarCargos]
	@Id_cargo varchar (100),
	@Nombre_cargo varchar(100),
	@Descripcion varchar(400)
	as
begin
insert into Cargos(Id_cargo,Nombre_cargo,Descripcion) values(@Id_cargo,@Nombre_cargo, @Descripcion)
end

GO
ALTER AUTHORIZATION ON [dbo].[sp_InsertarCargos] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertarCategoria]    Script Date: 19/06/2020 15:57:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_InsertarCategoria]
	@ID_categoria INT,
	@Nombre_Categoria varchar(30),
	@Descripcion_Categoria varchar(400)
as
begin
insert into Categoria(ID_categoria,Nombre_Categoria,Descripcion_Categoria) values(@ID_categoria,@Nombre_Categoria, @Descripcion_Categoria)
end

GO
ALTER AUTHORIZATION ON [dbo].[sp_InsertarCategoria] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertarEmpleados]    Script Date: 19/06/2020 15:57:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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

GO
ALTER AUTHORIZATION ON [dbo].[sp_InsertarEmpleados] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[sp_insertarfpago]    Script Date: 19/06/2020 15:57:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_insertarfpago]
@nombre varchar(25)
AS
BEGIN
INSERT INTO Forma_Pago (nombre) Values(@nombre)
END

GO
ALTER AUTHORIZATION ON [dbo].[sp_insertarfpago] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertarProductos]    Script Date: 19/06/2020 15:57:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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

GO
ALTER AUTHORIZATION ON [dbo].[sp_InsertarProductos] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertarRolesUsuarios]    Script Date: 19/06/2020 15:57:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_InsertarRolesUsuarios]
	@ID_Rol varchar(30),
	@Nombre_Rol varchar(40),
	@Descripcion_Corta_Rol varchar(75)
AS 
BEGIN
	INSERT INTO Roles(ID_Rol,Nombre_Rol,Descripcion_Corta_Rol)
	VALUES (@ID_Rol,@Nombre_Rol,@Descripcion_Corta_Rol);
END

GO
ALTER AUTHORIZATION ON [dbo].[sp_InsertarRolesUsuarios] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertarUsuarios]    Script Date: 19/06/2020 15:57:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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

GO
ALTER AUTHORIZATION ON [dbo].[sp_InsertarUsuarios] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[sp_ModificarCargos]    Script Date: 19/06/2020 15:57:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_ModificarCargos]
	@Id_cargo varchar (100),
	@Nombre_cargo varchar(100),
	@Descripcion varchar(400)
as
begin
update cargos set  Nombre_cargo=@Nombre_cargo, Descripcion=@Descripcion
where Id_cargo=@Id_cargo	
end 

GO
ALTER AUTHORIZATION ON [dbo].[sp_ModificarCargos] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[sp_ModificarCategoria]    Script Date: 19/06/2020 15:57:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_ModificarCategoria]
	@ID_categoria INT,
	@Nombre_Categoria varchar(30),
	@Descripcion_Categoria varchar(400)
as
begin
update Categoria set  Nombre_Categoria=@Nombre_Categoria, Descripcion_Categoria=@Descripcion_Categoria
where ID_categoria=@ID_categoria	
end

GO
ALTER AUTHORIZATION ON [dbo].[sp_ModificarCategoria] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[sp_ModificarEmpleado]    Script Date: 19/06/2020 15:57:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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

GO
ALTER AUTHORIZATION ON [dbo].[sp_ModificarEmpleado] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[sp_ModificarIDProductos]    Script Date: 19/06/2020 15:57:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ModificarIDProductos]
	@ID int,
	@NuevoID_Productos int
AS 
BEGIN
	UPDATE Productos SET ID = @NuevoID_Productos WHERE ID = @ID;
END

GO
ALTER AUTHORIZATION ON [dbo].[sp_ModificarIDProductos] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[sp_ModificarIDUsuarios]    Script Date: 19/06/2020 15:57:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ModificarIDUsuarios]
	@ID_usuario int,
	@NuevoID_Usuario int
AS 
BEGIN
	UPDATE Usuarios SET ID_usuario = @NuevoID_Usuario WHERE ID_usuario = @ID_usuario;
END

GO
ALTER AUTHORIZATION ON [dbo].[sp_ModificarIDUsuarios] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[sp_ModificarProductos]    Script Date: 19/06/2020 15:57:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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

GO
ALTER AUTHORIZATION ON [dbo].[sp_ModificarProductos] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[sp_ModificarRolesUsuarios]    Script Date: 19/06/2020 15:57:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ModificarRolesUsuarios]
	@ID_Rol varchar(30),
	@Nombre_Rol varchar(40),
	@Descripcion_Corta_Rol varchar(75)
AS 
BEGIN
	UPDATE Roles SET ID_Rol = @ID_Rol, Nombre_Rol = @Nombre_Rol, Descripcion_Corta_Rol = @Descripcion_Corta_Rol WHERE ID_Rol = @ID_Rol;
END
GO
ALTER AUTHORIZATION ON [dbo].[sp_ModificarRolesUsuarios] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[sp_ModificarUsuarios]    Script Date: 19/06/2020 15:57:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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

GO
ALTER AUTHORIZATION ON [dbo].[sp_ModificarUsuarios] TO  SCHEMA OWNER 
GO
USE [master]
GO
ALTER DATABASE [FullCalzadoDB] SET  READ_WRITE 
GO
