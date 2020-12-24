USE [master]
GO
/****** Object:  Database [BASEBRIREST]    Script Date: 29/08/2020 05:47:21 p.m. ******/
CREATE DATABASE [BASEBRIREST]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BASEBRIREST', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\BASEBRIREST.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BASEBRIREST_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\BASEBRIREST_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [BASEBRIREST] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BASEBRIREST].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BASEBRIREST] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BASEBRIREST] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BASEBRIREST] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BASEBRIREST] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BASEBRIREST] SET ARITHABORT OFF 
GO
ALTER DATABASE [BASEBRIREST] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BASEBRIREST] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BASEBRIREST] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BASEBRIREST] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BASEBRIREST] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BASEBRIREST] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BASEBRIREST] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BASEBRIREST] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BASEBRIREST] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BASEBRIREST] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BASEBRIREST] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BASEBRIREST] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BASEBRIREST] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BASEBRIREST] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BASEBRIREST] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BASEBRIREST] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BASEBRIREST] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BASEBRIREST] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BASEBRIREST] SET  MULTI_USER 
GO
ALTER DATABASE [BASEBRIREST] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BASEBRIREST] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BASEBRIREST] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BASEBRIREST] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [BASEBRIREST] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BASEBRIREST] SET QUERY_STORE = OFF
GO
USE [BASEBRIREST]
GO
/****** Object:  User [peruinka]    Script Date: 29/08/2020 05:47:22 p.m. ******/
CREATE USER [peruinka] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [magbri]    Script Date: 29/08/2020 05:47:22 p.m. ******/
CREATE USER [magbri] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [ferreteria1]    Script Date: 29/08/2020 05:47:22 p.m. ******/
CREATE USER [ferreteria1] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [peruinka]
GO
ALTER ROLE [db_accessadmin] ADD MEMBER [peruinka]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [peruinka]
GO
ALTER ROLE [db_ddladmin] ADD MEMBER [peruinka]
GO
ALTER ROLE [db_backupoperator] ADD MEMBER [peruinka]
GO
ALTER ROLE [db_datareader] ADD MEMBER [peruinka]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [peruinka]
GO
ALTER ROLE [db_accessadmin] ADD MEMBER [magbri]
GO
ALTER ROLE [db_ddladmin] ADD MEMBER [magbri]
GO
ALTER ROLE [db_datareader] ADD MEMBER [magbri]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [magbri]
GO
ALTER ROLE [db_denydatareader] ADD MEMBER [magbri]
GO
/****** Object:  Table [dbo].[Areas_de_Impresion]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Areas_de_Impresion](
	[Id_area] [int] IDENTITY(1,1) NOT NULL,
	[Area] [varchar](max) NULL,
 CONSTRAINT [PK_Areas_de_Impresion] PRIMARY KEY CLUSTERED 
(
	[Id_area] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ASISTENCIAS]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ASISTENCIAS](
	[Id_asistencia] [int] IDENTITY(1,1) NOT NULL,
	[Id_personal] [int] NULL,
	[Fecha_entrada] [datetime] NULL,
	[Fecha_salida] [datetime] NULL,
	[Estado] [varchar](50) NULL,
	[Horas] [numeric](18, 2) NULL,
 CONSTRAINT [PK_ASISTENCIAS] PRIMARY KEY CLUSTERED 
(
	[Id_asistencia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Caja]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Caja](
	[Id_Caja] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NULL,
	[Tema] [varchar](50) NULL,
	[Serial_PC] [varchar](max) NULL,
	[Estado] [varchar](50) NULL,
	[Tipo] [varchar](50) NULL,
	[Ruta_para_copias_de_seguridad] [varchar](max) NULL,
	[Ultima_fecha_de_copia_de_seguridad] [varchar](50) NULL,
	[Ultima_fecha_de_copia_date] [datetime] NULL,
	[Frecuencia_de_copias] [int] NULL,
	[Estado_Copia_De_seguridad] [varchar](50) NULL,
 CONSTRAINT [PK_Caja_1] PRIMARY KEY CLUSTERED 
(
	[Id_Caja] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[categoria]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[categoria](
	[idcategoria] [int] IDENTITY(1,1) NOT NULL,
	[nombrecategoria] [varchar](50) NULL,
 CONSTRAINT [PK_categoria] PRIMARY KEY CLUSTERED 
(
	[idcategoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CLIENTE_FACTURA_PERU]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CLIENTE_FACTURA_PERU](
	[CLIE_CODIGO] [varchar](8) NOT NULL,
	[TPDC_CODIGO] [varchar](1) NOT NULL,
	[REEC_CODIGO] [varchar](1) NOT NULL,
	[UBDS_CODIGO] [varchar](6) NOT NULL,
	[CLIE_NOMBRES] [varchar](150) NOT NULL,
	[CLIE_APELLIDOPATERNO] [varchar](100) NOT NULL,
	[CLIE_APELLIDOMATERNO] [varchar](100) NOT NULL,
	[CLIE_NRODOCUMENTO] [varchar](18) NOT NULL,
	[CLIE_SEXO] [varchar](15) NOT NULL,
	[CLIE_FECHANACIMIENTO] [datetime] NULL,
	[CLIE_ESTADOCIVIL] [varchar](25) NULL,
	[CLIE_DIRECCION] [varchar](300) NULL,
	[CLIE_REFERENCIA] [varchar](300) NULL,
	[CLIE_TELEFONO] [varchar](75) NULL,
	[CLIE_EMAIL] [varchar](120) NULL,
	[CLIE_OCUPACION] [varchar](150) NULL,
	[CLIE_EMPRESA] [varchar](100) NULL,
	[CLIE_EMPRESADIRECCION] [varchar](300) NULL,
	[CLIE_EMPRESATELEFONO] [varchar](75) NULL,
	[CLIE_ESTADO] [varchar](2) NULL,
	[CLIE_ID_OBRA] [numeric](18, 0) NULL,
	[FlgAnexoConcar] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[clientes]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[clientes](
	[idclientev] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](max) NULL,
	[Direccion_para_factura] [varchar](max) NULL,
	[Ruc] [varchar](max) NULL,
	[movil] [varchar](50) NULL,
	[Cliente] [varchar](50) NULL,
	[Proveedor] [varchar](50) NULL,
	[Estado] [varchar](50) NULL,
	[Saldo] [numeric](18, 2) NULL,
 CONSTRAINT [PK_clientes] PRIMARY KEY CLUSTERED 
(
	[idclientev] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CONCEPTOS]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CONCEPTOS](
	[Id_concepto] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](max) NULL,
 CONSTRAINT [PK_CONCEPTOS] PRIMARY KEY CLUSTERED 
(
	[Id_concepto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CONEXION]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CONEXION](
	[Id_conexion] [int] IDENTITY(1,1) NOT NULL,
	[Data_source_REMOTO] [varchar](max) NULL,
 CONSTRAINT [PK_CONEXION] PRIMARY KEY CLUSTERED 
(
	[Id_conexion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Conteo_de_paginado]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Conteo_de_paginado](
	[Id_conteo] [int] IDENTITY(1,1) NOT NULL,
	[Conteo1] [int] NOT NULL,
	[Conteo2] [int] NOT NULL,
 CONSTRAINT [PK_Conteo_de_paginado] PRIMARY KEY CLUSTERED 
(
	[Id_conteo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CONTROL_DE_COBROS]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CONTROL_DE_COBROS](
	[Id_control_de_cobros] [int] IDENTITY(1,1) NOT NULL,
	[Monto] [numeric](18, 2) NULL,
	[Concepto] [varchar](max) NULL,
	[Id_venta] [int] NULL,
 CONSTRAINT [PK_CONTROL_DE_COBROS] PRIMARY KEY CLUSTERED 
(
	[Id_control_de_cobros] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Correo_base]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Correo_base](
	[Id_correo_base] [int] IDENTITY(1,1) NOT NULL,
	[Correo] [varchar](max) NULL,
	[Password] [varchar](max) NULL,
	[Estado_De_envio] [varchar](max) NULL,
 CONSTRAINT [PK_Correo_base] PRIMARY KEY CLUSTERED 
(
	[Id_correo_base] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DETALLE_CONTROL_DE_COBROS]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DETALLE_CONTROL_DE_COBROS](
	[Id_detalle_de_control_de_cobros] [int] IDENTITY(1,1) NOT NULL,
	[Pago_realizado] [numeric](18, 2) NULL,
	[Fecha_que_pago] [datetime] NULL,
	[Tipo_de_cobro] [varchar](50) NULL,
	[Detalle] [varchar](max) NULL,
	[Id_cliente] [int] NULL,
	[Id_usuario] [int] NULL,
	[Id_caja] [int] NULL,
	[Comprobante] [varchar](max) NULL,
 CONSTRAINT [PK_DETALLE_CONTROL_DE_COBROS] PRIMARY KEY CLUSTERED 
(
	[Id_detalle_de_control_de_cobros] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[detalle_venta]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detalle_venta](
	[iddetalle_venta] [int] IDENTITY(1,1) NOT NULL,
	[idventa] [int] NOT NULL,
	[Id_producto] [int] NOT NULL,
	[cantidad] [numeric](18, 2) NULL,
	[preciounitario] [numeric](18, 2) NULL,
	[Modena] [varchar](50) NULL,
	[Total_a_pagar]  AS ([preciounitario]*[cantidad]),
	[Unidad_de_medida] [varchar](50) NULL,
	[Cantidad_mostrada] [numeric](18, 2) NULL,
	[Estado] [varchar](50) NULL,
	[Costo] [numeric](18, 2) NULL,
	[Ganancia]  AS ([cantidad]*[preciounitario]-[cantidad]*[Costo]),
	[Estado_de_pago] [varchar](50) NULL,
 CONSTRAINT [PK_detalle_venta] PRIMARY KEY CLUSTERED 
(
	[iddetalle_venta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EMPRESA]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EMPRESA](
	[Id_empresa] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_Empresa] [varchar](50) NULL,
	[Logo] [image] NULL,
	[Impuesto] [varchar](50) NULL,
	[Porcentaje_impuesto] [numeric](18, 0) NULL,
	[Moneda] [varchar](50) NULL,
	[Trabajas_con_impuestos] [varchar](50) NULL,
	[Modo_de_busqueda] [varchar](50) NULL,
	[Carpeta_para_copias_de_seguridad] [varchar](max) NULL,
	[Correo_para_envio_de_reportes] [varchar](50) NULL,
	[Ultima_fecha_de_copia_de_seguridad] [varchar](50) NULL,
	[Ultima_fecha_de_copia_date] [datetime] NULL,
	[Frecuencia_de_copias] [int] NULL,
	[Estado] [varchar](50) NULL,
	[Tipo_de_empresa] [varchar](50) NULL,
	[Pais] [varchar](max) NULL,
	[Redondeo_de_total] [varchar](50) NULL,
 CONSTRAINT [PK_EMPRESA] PRIMARY KEY CLUSTERED 
(
	[Id_empresa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GASTOSVARIOS]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GASTOSVARIOS](
	[Idgasto] [int] IDENTITY(1,1) NOT NULL,
	[Fecha_del_Gasto] [datetime] NULL,
	[Nro_Comprobante] [varchar](50) NULL,
	[Tipo_de_Comprobante] [varchar](50) NULL,
	[Importe] [numeric](18, 2) NULL,
	[Descripcion] [varchar](500) NULL,
	[Id_concepto] [int] NULL,
	[Id_usuario] [int] NULL,
	[TIPO] [varchar](50) NULL,
	[Id_caja] [int] NULL,
 CONSTRAINT [PK_GASTOSVARIOS] PRIMARY KEY CLUSTERED 
(
	[Idgasto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Grupo_de_Productos]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Grupo_de_Productos](
	[Idline] [int] IDENTITY(1,1) NOT NULL,
	[Grupo] [varchar](50) NULL,
	[Por_defecto] [varchar](50) NULL,
	[Icono] [image] NULL,
	[Estado] [varchar](50) NULL,
	[Estado_de_icono] [varchar](50) NULL,
 CONSTRAINT [PK_linea] PRIMARY KEY CLUSTERED 
(
	[Idline] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HORARIOS]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HORARIOS](
	[Id_horarios] [int] IDENTITY(1,1) NOT NULL,
	[Cargo] [varchar](50) NULL,
	[Horas_laborales_diarias] [numeric](18, 1) NULL,
	[Costo_hora_normal] [numeric](18, 2) NULL,
	[Costo_hora_extra] [numeric](18, 2) NULL,
	[Horas_libres_diarias] [numeric](18, 1) NULL,
	[lunes] [int] NULL,
	[martes] [int] NULL,
	[miercoles] [int] NULL,
	[jueves] [int] NULL,
	[viernes] [int] NULL,
	[sabado] [int] NULL,
	[domingo] [int] NULL,
 CONSTRAINT [PK_HORARIOS] PRIMARY KEY CLUSTERED 
(
	[Id_horarios] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Impresoras_por_Area]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Impresoras_por_Area](
	[Id_impresora] [int] IDENTITY(1,1) NOT NULL,
	[Id_Areas_de_Impresion] [int] NULL,
	[Impresora] [varchar](max) NULL,
	[Id_caja] [int] NULL,
 CONSTRAINT [PK_Impresoras_por_Area] PRIMARY KEY CLUSTERED 
(
	[Id_impresora] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ImpresorasPedidosPantalla]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ImpresorasPedidosPantalla](
	[Id_ImpresoraPedidos] [int] IDENTITY(1,1) NOT NULL,
	[A_Impresora] [varchar](50) NULL,
	[A_seg_pantalla] [varchar](50) NULL,
	[Id_caja] [int] NULL,
 CONSTRAINT [PK_ImpresorasPedidos] PRIMARY KEY CLUSTERED 
(
	[Id_ImpresoraPedidos] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[INGRESOSVARIOS]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[INGRESOSVARIOS](
	[Idgasto] [int] IDENTITY(1,1) NOT NULL,
	[Fecha_del_Gasto] [datetime] NULL,
	[Nro_Comprobante] [varchar](50) NULL,
	[Tipo_de_Comprobante] [varchar](50) NULL,
	[Importe] [decimal](18, 2) NULL,
	[Observacion] [varchar](500) NULL,
	[Estado] [varchar](50) NULL,
	[Id_concepto] [int] NULL,
 CONSTRAINT [PK_INGRESOSVARIOS] PRIMARY KEY CLUSTERED 
(
	[Idgasto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Inicios_de_sesion_por_caja]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inicios_de_sesion_por_caja](
	[Id_inicio_sesion] [int] IDENTITY(1,1) NOT NULL,
	[Id_serial_Pc] [varchar](max) NULL,
	[Id_usuario] [int] NULL,
 CONSTRAINT [PK_Inicios_de_sesion_por_caja] PRIMARY KEY CLUSTERED 
(
	[Id_inicio_sesion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KARDEX]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KARDEX](
	[Id_kardex] [int] IDENTITY(1,1) NOT NULL,
	[Fecha] [datetime] NULL,
	[Motivo] [varchar](200) NULL,
	[Cantidad] [numeric](18, 0) NULL,
	[Id_producto] [int] NULL,
	[Id_usuario] [int] NULL,
	[Tipo] [varchar](50) NULL,
	[Estado] [varchar](50) NULL,
	[Total]  AS ([Cantidad]*[Costo_unt]),
	[Costo_unt] [numeric](18, 2) NULL,
	[Habia] [numeric](18, 2) NULL,
	[Hay] [numeric](18, 2) NULL,
	[Id_caja] [int] NULL,
 CONSTRAINT [PK_KARDEX] PRIMARY KEY CLUSTERED 
(
	[Id_kardex] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Marcan]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Marcan](
	[Id_marca] [int] IDENTITY(1,1) NOT NULL,
	[S] [varchar](max) NULL,
	[F] [varchar](max) NULL,
	[E] [varchar](max) NULL,
	[FA] [varchar](max) NULL,
 CONSTRAINT [PK_Licencias] PRIMARY KEY CLUSTERED 
(
	[Id_marca] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mesas]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mesas](
	[Id_mesa] [int] IDENTITY(1,1) NOT NULL,
	[Mesa] [varchar](50) NULL,
	[Id_salon] [int] NULL,
	[Estado_de_vida] [varchar](50) NULL,
	[Estado_de_Disponibilidad] [varchar](50) NULL,
 CONSTRAINT [PK_Mesas] PRIMARY KEY CLUSTERED 
(
	[Id_mesa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Modulos]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Modulos](
	[Id_modulo] [int] IDENTITY(1,1) NOT NULL,
	[Modulo] [varchar](max) NULL,
 CONSTRAINT [PK_Modulos] PRIMARY KEY CLUSTERED 
(
	[Id_modulo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Monedero_Electronico_del_ahorro]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Monedero_Electronico_del_ahorro](
	[Id_monedero] [int] IDENTITY(1,1) NOT NULL,
	[Puntos_acumulados] [numeric](18, 0) NULL,
	[Id_conversion] [int] NULL,
	[Estado] [varchar](50) NULL,
	[Id_venta] [int] NULL,
 CONSTRAINT [PK_Monedero_Electronico_del_ahorro] PRIMARY KEY CLUSTERED 
(
	[Id_monedero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MOVIMIENTOCAJA]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MOVIMIENTOCAJA](
	[idmovcaja] [varchar](12) NOT NULL,
	[fechamov] [datetime] NULL,
	[tipomov] [varchar](20) NULL,
	[nombretipomov] [varchar](20) NULL,
	[descripciontipomov] [varchar](120) NULL,
	[totalmov] [real] NULL,
	[movcerrado] [char](2) NULL,
	[estado] [char](1) NULL,
	[mediodepago] [varchar](20) NULL,
	[idcompraventa] [varchar](12) NULL,
	[idusuario] [numeric](18, 0) NULL,
	[idcierrecaja] [varchar](12) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MOVIMIENTOCAJACIERRE]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MOVIMIENTOCAJACIERRE](
	[idcierrecaja] [int] IDENTITY(1,1) NOT NULL,
	[fechainicio] [datetime] NULL,
	[fechafin] [datetime] NULL,
	[fechacierre] [datetime] NULL,
	[ingresos] [numeric](18, 2) NULL,
	[egresos] [numeric](18, 2) NULL,
	[Saldo_queda_en_caja] [numeric](18, 2) NULL,
	[Id_usuario] [int] NULL,
	[Total_calculado] [numeric](18, 2) NULL,
	[Total_real] [numeric](18, 2) NULL,
	[Estado] [varchar](50) NULL,
	[Diferencia] [numeric](18, 2) NULL,
	[Id_caja] [int] NULL,
 CONSTRAINT [PK_MOVIMIENTOCAJACIERRE] PRIMARY KEY CLUSTERED 
(
	[idcierrecaja] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OFERTAS]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OFERTAS](
	[Id_oferta] [int] IDENTITY(1,1) NOT NULL,
	[Id_presentacion_fraccionada] [int] NULL,
	[Cantidad_condicional] [numeric](18, 2) NULL,
	[Id_unidad_condicional] [int] NULL,
	[Descuento] [numeric](18, 2) NULL,
 CONSTRAINT [PK_OFERTAS] PRIMARY KEY CLUSTERED 
(
	[Id_oferta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Permisos]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permisos](
	[Id_Permiso] [int] IDENTITY(1,1) NOT NULL,
	[Id_modulo] [int] NULL,
	[Id_usuario] [int] NULL,
 CONSTRAINT [PK_p] PRIMARY KEY CLUSTERED 
(
	[Id_Permiso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[productoID] [int] NOT NULL,
	[categoriaID] [int] NULL,
	[pro_nombre] [varchar](25) NULL,
	[pro_precio] [decimal](9, 4) NULL,
	[pro_stock] [int] NULL,
	[pro_estado] [char](2) NULL,
PRIMARY KEY CLUSTERED 
(
	[productoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producto1]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto1](
	[Id_Producto1] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NULL,
	[Imagen] [image] NULL,
	[Id_grupo] [int] NULL,
	[Usa_inventarios] [varchar](50) NULL,
	[Stock] [varchar](50) NULL,
	[Precio_de_venta] [numeric](18, 2) NULL,
	[Stock_minimo] [numeric](18, 2) NULL,
	[Precio_de_compra] [numeric](18, 2) NULL,
	[Estado_imagen] [varchar](50) NULL,
 CONSTRAINT [PK_Producto1] PRIMARY KEY CLUSTERED 
(
	[Id_Producto1] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[programacion_de_cuotas]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[programacion_de_cuotas](
	[Id_Programacion_cuota] [int] IDENTITY(1,1) NOT NULL,
	[Monto_cuota] [decimal](18, 2) NULL,
	[Cuotas] [nchar](10) NULL,
	[Estado] [varchar](50) NULL,
	[Fechas_Programadas] [varchar](50) NULL,
	[Saldo] [decimal](18, 2) NULL,
	[Id_programacion_de_cuota_padre] [int] NULL,
 CONSTRAINT [PK_programacion_de_cuotas] PRIMARY KEY CLUSTERED 
(
	[Id_Programacion_cuota] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PROGRAMACION_DE_CUOTAS_PADRE]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PROGRAMACION_DE_CUOTAS_PADRE](
	[Id_programacion_de_cuota_padre] [int] IDENTITY(1,1) NOT NULL,
	[Monto_total] [numeric](18, 2) NULL,
	[Porcentaje_de_inicial] [varchar](50) NULL,
	[Monto_inicial] [numeric](18, 2) NULL,
	[Total_a_financiar] [numeric](18, 2) NULL,
	[Modalidad_de_cuotas] [varchar](50) NULL,
	[Tasa_de_interes_anual] [varchar](50) NULL,
	[Cuotas_totales] [int] NULL,
	[Id_venta] [int] NULL,
	[Valor_final] [numeric](18, 2) NULL,
	[Banco_financiero] [varchar](50) NULL,
	[Bono_de_buen_pagador] [numeric](18, 2) NULL,
	[Estado_de_cobro_de_bono] [varchar](50) NULL,
 CONSTRAINT [PK_PROGRAMACION_DE_CUOTAS_PADRE] PRIMARY KEY CLUSTERED 
(
	[Id_programacion_de_cuota_padre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PROMOCIONES]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PROMOCIONES](
	[Id_promocion] [int] IDENTITY(1,1) NOT NULL,
	[Id_Producto] [int] NULL,
	[A_partir_de] [numeric](18, 2) NULL,
	[Precio_de_promocion] [numeric](18, 2) NULL,
 CONSTRAINT [PK_PROMOCIONES] PRIMARY KEY CLUSTERED 
(
	[Id_promocion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Propiedades_de_mesas]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Propiedades_de_mesas](
	[Id_propiedades] [int] IDENTITY(1,1) NOT NULL,
	[x] [int] NULL,
	[y] [int] NULL,
	[Tamanio_letra] [int] NULL,
 CONSTRAINT [PK_Propiedades_de_mesas] PRIMARY KEY CLUSTERED 
(
	[Id_propiedades] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SALON]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SALON](
	[Id_salon] [int] IDENTITY(1,1) NOT NULL,
	[Salon] [varchar](50) NULL,
	[Estado] [varchar](50) NULL,
 CONSTRAINT [PK_SALON] PRIMARY KEY CLUSTERED 
(
	[Id_salon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Serializacion]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Serializacion](
	[Id_serializacion] [int] IDENTITY(1,1) NOT NULL,
	[Serie] [varchar](50) NULL,
	[Cantidad_de_numeros] [varchar](50) NULL,
	[numerofin] [varchar](50) NULL,
	[Destino] [varchar](50) NULL,
	[Id_tipodoc] [varchar](50) NULL,
	[Por_defecto] [varchar](50) NULL,
 CONSTRAINT [PK_Serializacion] PRIMARY KEY CLUSTERED 
(
	[Id_serializacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ticket]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ticket](
	[Id_ticket] [int] IDENTITY(1,1) NOT NULL,
	[Id_Empresa] [int] NULL,
	[Identificador_fiscal] [varchar](max) NULL,
	[Direccion] [varchar](max) NULL,
	[Provincia_Departamento_Pais] [varchar](max) NULL,
	[Nombre_de_Moneda] [varchar](max) NULL,
	[Agradecimiento] [varchar](max) NULL,
	[pagina_Web_Facebook] [varchar](max) NULL,
	[Anuncio] [varchar](max) NULL,
	[Datos_fiscales_de_autorizacion] [varchar](max) NULL,
	[Por_defecto] [varchar](max) NULL,
 CONSTRAINT [PK_Ticket] PRIMARY KEY CLUSTERED 
(
	[Id_ticket] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[USUARIO2]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[USUARIO2](
	[idUsuario] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_y_Apelllidos] [varchar](50) NULL,
	[Login] [varchar](50) NULL,
	[Password] [varchar](max) NULL,
	[Icono] [image] NULL,
	[Nombre_de_icono] [varchar](max) NULL,
	[Correo] [varchar](max) NULL,
	[Rol] [varchar](max) NULL,
	[Estado] [varchar](50) NULL,
 CONSTRAINT [PK_USUARIO2] PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ventas]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ventas](
	[idventa] [int] IDENTITY(1,1) NOT NULL,
	[idclientev] [int] NULL,
	[fecha_venta] [datetime] NULL,
	[Numero_de_doc] [varchar](50) NULL,
	[Monto_total] [numeric](18, 2) NULL,
	[Tipo_de_pago] [varchar](50) NULL,
	[Estado] [varchar](50) NULL,
	[IGV] [numeric](18, 1) NULL,
	[Comprobante] [varchar](50) NULL,
	[Id_usuario] [int] NULL,
	[Fecha_de_pago] [varchar](50) NULL,
	[ACCION] [varchar](50) NULL,
	[Saldo] [numeric](18, 2) NULL,
	[Pago_con] [numeric](18, 2) NULL,
	[Porcentaje_IGV] [numeric](18, 2) NULL,
	[Id_caja] [int] NULL,
	[Referencia_tarjeta] [varchar](50) NULL,
	[Vuelto] [numeric](18, 2) NULL,
	[Efectivo] [numeric](18, 2) NULL,
	[Credito] [numeric](18, 2) NULL,
	[Tarjeta] [numeric](18, 2) NULL,
	[Id_mesa] [int] NULL,
	[Numero_personas] [int] NULL,
	[Donde_se_consumira] [varchar](50) NULL,
 CONSTRAINT [PK_ventas] PRIMARY KEY CLUSTERED 
(
	[idventa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ASISTENCIAS]  WITH CHECK ADD  CONSTRAINT [FK_ASISTENCIAS_USUARIO2] FOREIGN KEY([Id_personal])
REFERENCES [dbo].[USUARIO2] ([idUsuario])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ASISTENCIAS] CHECK CONSTRAINT [FK_ASISTENCIAS_USUARIO2]
GO
ALTER TABLE [dbo].[CONTROL_DE_COBROS]  WITH CHECK ADD  CONSTRAINT [FK_CONTROL_DE_COBROS_ventas] FOREIGN KEY([Id_venta])
REFERENCES [dbo].[ventas] ([idventa])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CONTROL_DE_COBROS] CHECK CONSTRAINT [FK_CONTROL_DE_COBROS_ventas]
GO
ALTER TABLE [dbo].[DETALLE_CONTROL_DE_COBROS]  WITH CHECK ADD  CONSTRAINT [FK_DETALLE_CONTROL_DE_COBROS_clientes] FOREIGN KEY([Id_cliente])
REFERENCES [dbo].[clientes] ([idclientev])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DETALLE_CONTROL_DE_COBROS] CHECK CONSTRAINT [FK_DETALLE_CONTROL_DE_COBROS_clientes]
GO
ALTER TABLE [dbo].[DETALLE_CONTROL_DE_COBROS]  WITH CHECK ADD  CONSTRAINT [FK_DETALLE_CONTROL_DE_COBROS_USUARIO2] FOREIGN KEY([Id_usuario])
REFERENCES [dbo].[USUARIO2] ([idUsuario])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DETALLE_CONTROL_DE_COBROS] CHECK CONSTRAINT [FK_DETALLE_CONTROL_DE_COBROS_USUARIO2]
GO
ALTER TABLE [dbo].[detalle_venta]  WITH CHECK ADD  CONSTRAINT [FK_detalle_venta_Producto1] FOREIGN KEY([Id_producto])
REFERENCES [dbo].[Producto1] ([Id_Producto1])
GO
ALTER TABLE [dbo].[detalle_venta] CHECK CONSTRAINT [FK_detalle_venta_Producto1]
GO
ALTER TABLE [dbo].[detalle_venta]  WITH CHECK ADD  CONSTRAINT [FK_detalle_venta_ventas1] FOREIGN KEY([idventa])
REFERENCES [dbo].[ventas] ([idventa])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[detalle_venta] CHECK CONSTRAINT [FK_detalle_venta_ventas1]
GO
ALTER TABLE [dbo].[Impresoras_por_Area]  WITH CHECK ADD  CONSTRAINT [FK_Impresoras_por_Area_Areas_de_Impresion] FOREIGN KEY([Id_Areas_de_Impresion])
REFERENCES [dbo].[Areas_de_Impresion] ([Id_area])
GO
ALTER TABLE [dbo].[Impresoras_por_Area] CHECK CONSTRAINT [FK_Impresoras_por_Area_Areas_de_Impresion]
GO
ALTER TABLE [dbo].[Impresoras_por_Area]  WITH CHECK ADD  CONSTRAINT [FK_Impresoras_por_Area_Caja] FOREIGN KEY([Id_caja])
REFERENCES [dbo].[Caja] ([Id_Caja])
GO
ALTER TABLE [dbo].[Impresoras_por_Area] CHECK CONSTRAINT [FK_Impresoras_por_Area_Caja]
GO
ALTER TABLE [dbo].[ImpresorasPedidosPantalla]  WITH CHECK ADD  CONSTRAINT [FK_ImpresorasPedidos_Caja] FOREIGN KEY([Id_caja])
REFERENCES [dbo].[Caja] ([Id_Caja])
GO
ALTER TABLE [dbo].[ImpresorasPedidosPantalla] CHECK CONSTRAINT [FK_ImpresorasPedidos_Caja]
GO
ALTER TABLE [dbo].[INGRESOSVARIOS]  WITH CHECK ADD  CONSTRAINT [FK_INGRESOSVARIOS_CONCEPTOS] FOREIGN KEY([Id_concepto])
REFERENCES [dbo].[CONCEPTOS] ([Id_concepto])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[INGRESOSVARIOS] CHECK CONSTRAINT [FK_INGRESOSVARIOS_CONCEPTOS]
GO
ALTER TABLE [dbo].[KARDEX]  WITH CHECK ADD  CONSTRAINT [FK_KARDEX_Caja] FOREIGN KEY([Id_caja])
REFERENCES [dbo].[Caja] ([Id_Caja])
GO
ALTER TABLE [dbo].[KARDEX] CHECK CONSTRAINT [FK_KARDEX_Caja]
GO
ALTER TABLE [dbo].[KARDEX]  WITH CHECK ADD  CONSTRAINT [FK_KARDEX_Producto1] FOREIGN KEY([Id_producto])
REFERENCES [dbo].[Producto1] ([Id_Producto1])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[KARDEX] CHECK CONSTRAINT [FK_KARDEX_Producto1]
GO
ALTER TABLE [dbo].[KARDEX]  WITH CHECK ADD  CONSTRAINT [FK_KARDEX_USUARIO2] FOREIGN KEY([Id_usuario])
REFERENCES [dbo].[USUARIO2] ([idUsuario])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[KARDEX] CHECK CONSTRAINT [FK_KARDEX_USUARIO2]
GO
ALTER TABLE [dbo].[Mesas]  WITH CHECK ADD  CONSTRAINT [FK_Mesas_SALON] FOREIGN KEY([Id_salon])
REFERENCES [dbo].[SALON] ([Id_salon])
GO
ALTER TABLE [dbo].[Mesas] CHECK CONSTRAINT [FK_Mesas_SALON]
GO
ALTER TABLE [dbo].[MOVIMIENTOCAJACIERRE]  WITH CHECK ADD  CONSTRAINT [FK_MOVIMIENTOCAJACIERRE_Caja] FOREIGN KEY([Id_caja])
REFERENCES [dbo].[Caja] ([Id_Caja])
GO
ALTER TABLE [dbo].[MOVIMIENTOCAJACIERRE] CHECK CONSTRAINT [FK_MOVIMIENTOCAJACIERRE_Caja]
GO
ALTER TABLE [dbo].[MOVIMIENTOCAJACIERRE]  WITH CHECK ADD  CONSTRAINT [FK_MOVIMIENTOCAJACIERRE_USUARIO2] FOREIGN KEY([Id_usuario])
REFERENCES [dbo].[USUARIO2] ([idUsuario])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[MOVIMIENTOCAJACIERRE] CHECK CONSTRAINT [FK_MOVIMIENTOCAJACIERRE_USUARIO2]
GO
ALTER TABLE [dbo].[Permisos]  WITH CHECK ADD  CONSTRAINT [FK_Permisos_Modulos] FOREIGN KEY([Id_modulo])
REFERENCES [dbo].[Modulos] ([Id_modulo])
GO
ALTER TABLE [dbo].[Permisos] CHECK CONSTRAINT [FK_Permisos_Modulos]
GO
ALTER TABLE [dbo].[Permisos]  WITH CHECK ADD  CONSTRAINT [FK_Permisos_USUARIO2] FOREIGN KEY([Id_usuario])
REFERENCES [dbo].[USUARIO2] ([idUsuario])
GO
ALTER TABLE [dbo].[Permisos] CHECK CONSTRAINT [FK_Permisos_USUARIO2]
GO
ALTER TABLE [dbo].[programacion_de_cuotas]  WITH CHECK ADD  CONSTRAINT [FK_programacion_de_cuotas_PROGRAMACION_DE_CUOTAS_PADRE] FOREIGN KEY([Id_programacion_de_cuota_padre])
REFERENCES [dbo].[PROGRAMACION_DE_CUOTAS_PADRE] ([Id_programacion_de_cuota_padre])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[programacion_de_cuotas] CHECK CONSTRAINT [FK_programacion_de_cuotas_PROGRAMACION_DE_CUOTAS_PADRE]
GO
ALTER TABLE [dbo].[PROGRAMACION_DE_CUOTAS_PADRE]  WITH CHECK ADD  CONSTRAINT [FK_PROGRAMACION_DE_CUOTAS_PADRE_ventas] FOREIGN KEY([Id_venta])
REFERENCES [dbo].[ventas] ([idventa])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PROGRAMACION_DE_CUOTAS_PADRE] CHECK CONSTRAINT [FK_PROGRAMACION_DE_CUOTAS_PADRE_ventas]
GO
ALTER TABLE [dbo].[ventas]  WITH CHECK ADD  CONSTRAINT [FK_ventas_Caja] FOREIGN KEY([Id_caja])
REFERENCES [dbo].[Caja] ([Id_Caja])
GO
ALTER TABLE [dbo].[ventas] CHECK CONSTRAINT [FK_ventas_Caja]
GO
ALTER TABLE [dbo].[ventas]  WITH CHECK ADD  CONSTRAINT [FK_ventas_clientes] FOREIGN KEY([idclientev])
REFERENCES [dbo].[clientes] ([idclientev])
GO
ALTER TABLE [dbo].[ventas] CHECK CONSTRAINT [FK_ventas_clientes]
GO
ALTER TABLE [dbo].[ventas]  WITH CHECK ADD  CONSTRAINT [FK_ventas_Mesas] FOREIGN KEY([Id_mesa])
REFERENCES [dbo].[Mesas] ([Id_mesa])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ventas] CHECK CONSTRAINT [FK_ventas_Mesas]
GO
ALTER TABLE [dbo].[ventas]  WITH CHECK ADD  CONSTRAINT [FK_ventas_USUARIO2] FOREIGN KEY([Id_usuario])
REFERENCES [dbo].[USUARIO2] ([idUsuario])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ventas] CHECK CONSTRAINT [FK_ventas_USUARIO2]
GO
/****** Object:  StoredProcedure [dbo].[activar_la_escritura_de_mdf]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[activar_la_escritura_de_mdf]
as
ALTER DATABASE   BASEMAGBRI Set Read_write








GO
/****** Object:  StoredProcedure [dbo].[actualizar_estado_de_cuota]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[actualizar_estado_de_cuota]
@idprogramacioncuota as integer

as 
update  programacion_de_cuotas  set Estado='PAGADO'
where Id_Programacion_cuota=@idprogramacioncuota AND Saldo  = 0 AND Estado='DEUDA'









GO
/****** Object:  StoredProcedure [dbo].[actualizar_serializacion_mas_uno]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[actualizar_serializacion_mas_uno]

@idserie as int  
as 

update Serializacion set  numerofin=numerofin+1          
where Id_serializacion=@idserie 





GO
/****** Object:  StoredProcedure [dbo].[actualizar_serializacion_mas_uno_en_Cobros]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[actualizar_serializacion_mas_uno_en_Cobros]

as 

update Serializacion set  numerofin=numerofin+1          
where Id_tipodoc='INGRESO'









GO
/****** Object:  StoredProcedure [dbo].[actualizarestado_venta]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[actualizarestado_venta]

@resto as decimal(18,2),
@idventa as int
as
if @resto <>0.00
update ventas  set Estado='DEUDA'
where Estado='DEUDA' and idventa  =@idventa
else
update ventas set Estado='CREDITO PAGADO'
where  Estado='DEUDA' and idventa  =@idventa









GO
/****** Object:  StoredProcedure [dbo].[actualizartotal_venta]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[actualizartotal_venta]
@idventa int,
@montototal as numeric(18,1),
@IGV as numeric(18,1)

,@Saldo numeric(18,2),
@Tipo_de_pago varchar(50),
@Estado varchar(50),
@Id_series varchar(50),
@Numero_de_doc varchar(50),
@fecha_venta datetime,
@ACCION varchar(50),
@Fecha_de_pago varchar(50),
@idcliente int,
@Pago_con numeric(18,2),
@Referencia_tarjeta varchar(50)
as

   BEGIN
if EXISTS (SELECT Numero_de_doc  FROM ventas  where Numero_de_doc  = @Numero_de_doc  )
RAISERROR ('Ya existe un Numero de Comprobante con ese Numero y Serie', 16,1)
else
BEGIN
update ventas set Monto_total  =@montototal, IGV=@IGV ,Saldo=@Saldo,
Tipo_de_pago=@Tipo_de_pago 
,Estado=@Estado ,
Comprobante =@Id_series ,
Numero_de_doc=@Numero_de_doc ,
fecha_venta=@fecha_venta ,
ACCION=@ACCION ,Fecha_de_pago =@Fecha_de_pago ,idclientev=@idcliente ,
Pago_con=@Pago_con,Referencia_tarjeta=@Referencia_tarjeta
where idventa =@idventa 
END
END









GO
/****** Object:  StoredProcedure [dbo].[actualizartotal_venta_EFECTIVO]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[actualizartotal_venta_EFECTIVO]
@idventa int,
@montototal as numeric(18,1),
@IGV as numeric(18,1)

,@Saldo numeric(18,2),
@Tipo_de_pago varchar(50),
@Estado varchar(50),
@Id_series varchar(50),
@Numero_de_doc varchar(50),
@fecha_venta datetime,
@ACCION varchar(50),
@Fecha_de_pago varchar(50),
@idcliente int,
@Pago_con numeric(18,2),
@Referencia_tarjeta varchar(50),
@Vuelto as numeric(18,2)
as

   BEGIN
if EXISTS (SELECT Numero_de_doc  FROM ventas  where Numero_de_doc  = @Numero_de_doc  )
RAISERROR ('Ya existe un Numero de Comprobante con ese Numero y Serie', 16,1)
else
BEGIN
update ventas set Monto_total  =@montototal, IGV=@IGV ,Saldo=@Saldo,
Tipo_de_pago=@Tipo_de_pago 
,Estado=@Estado ,
Comprobante =@Id_series ,
Numero_de_doc=@Numero_de_doc ,
fecha_venta=@fecha_venta ,
ACCION=@ACCION ,Fecha_de_pago =@Fecha_de_pago ,idclientev=@idcliente ,
Pago_con=@Pago_con,Referencia_tarjeta=@Referencia_tarjeta,
Vuelto=@Vuelto 
where idventa =@idventa 
END
END









GO
/****** Object:  StoredProcedure [dbo].[actualizarventasfacturaspagadas]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[actualizarventasfacturaspagadas]
@idcliente as integer

as
update ventas set Estado = 'PAGADO'  
where idclientev=@idcliente 












GO
/****** Object:  StoredProcedure [dbo].[aumentar_saldo_a_cliente]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[aumentar_saldo_a_cliente]
@idcliente as integer,
@Saldo numeric(18,2)
          
as 
update clientes set 

          
			Saldo =Saldo+@Saldo 
where idclientev =@idcliente 












GO
/****** Object:  StoredProcedure [dbo].[aumentar_stock]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[aumentar_stock]
@Id_presentacionfraccionada as INT,
@cantidad as decimal (18,2)

as
update Producto1   set Stock=Stock+@cantidad where Id_Producto1  =@Id_presentacionfraccionada AND Usa_inventarios ='SI'










GO
/****** Object:  StoredProcedure [dbo].[aumentar_tamanio_letra]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[aumentar_tamanio_letra]


as

update Propiedades_de_mesas set tamanio_letra=tamanio_letra+10









GO
/****** Object:  StoredProcedure [dbo].[aumentar_tamanio_mesa]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[aumentar_tamanio_mesa]


as
update Propiedades_de_mesas set x=x+10,y=y+10









GO
/****** Object:  StoredProcedure [dbo].[AUTORIZAR_A_USUARIOS_PARA_QUE_PROPIETARIO_DE_BASE_DE_DATOS]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[AUTORIZAR_A_USUARIOS_PARA_QUE_PROPIETARIO_DE_BASE_DE_DATOS]
AS
Alter authorization on database::BASEUP to peruinka








GO
/****** Object:  StoredProcedure [dbo].[backup_base]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[backup_base]
@ruta as varchar(max)
as
BACKUP DATABASE [BASEBRIREST]
TO DISK =N'C:\BASE_MAESTRA_PERUINKA_INDUSTRIAS\BASE\BASEBRIREST.bak'
WITH DESCRIPTION =N'respaldo de la base de datos de BASEBRIREST',
NOFORMAT,
INIT,
NAME=N'BASEBRIREST',
SKIP,
NOREWIND,
NOUNLOAD,
STATS=10,
CHECKSUM








GO
/****** Object:  StoredProcedure [dbo].[Buscar__id_cajas]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Buscar__id_cajas]
@Caja varchar(50)
as
select * from Caja 
where Descripcion =@Caja
order by Id_Caja desc








GO
/****** Object:  StoredProcedure [dbo].[buscar_ASISTENCIAS_por_id]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[buscar_ASISTENCIAS_por_id]
--declare @fecha_sistema date set @fecha_sistema = (SELECT GETDATE())
@letra int
AS 

SELECT        *
FROM            dbo.ASISTENCIAS 						 
WHEre Id_personal=@letra AND Estado='ENTRADA'










GO
/****** Object:  StoredProcedure [dbo].[buscar_ASISTENCIAS_por_id_para_horas]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[buscar_ASISTENCIAS_por_id_para_horas]
@letra int
AS 
declare @fecha_sistema date set @fecha_sistema = (SELECT GETDATE())
SELECT        *
FROM            dbo.ASISTENCIAS 						 
WHEre Id_personal=@letra and convert(date,Fecha_entrada)=@fecha_sistema 










GO
/****** Object:  StoredProcedure [dbo].[buscar_cliente_Form]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[buscar_cliente_Form]

@letra VARCHAR(50)
AS BEGIN
SELECT       top  10 idclientev, Nombre, Direccion_para_factura as Direccion, Ruc,  movil as Celular
                , Estado 
FROM            dbo.clientes 
WHEre Nombre  LIKE  '%' + @letra+'%' and Cliente  ='SI' 
END








GO
/****** Object:  StoredProcedure [dbo].[buscar_cliente_POR_nombre_PARA_COBROS]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[buscar_cliente_POR_nombre_PARA_COBROS]

@letra VARCHAR(50)
AS BEGIN
SELECT       dbo.clientes .Nombre ,dbo.clientes.idclientev ,Saldo 
FROM            clientes 
WHEre Nombre  LIKE  '%' + @letra+'%' and Cliente  ='SI' and Estado ='ACTIVO'
END









GO
/****** Object:  StoredProcedure [dbo].[buscar_cliente_POR_nombre_PARA_COMPRAS]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[buscar_cliente_POR_nombre_PARA_COMPRAS]

@letra VARCHAR(50)
AS BEGIN
SELECT       dbo.clientes .Nombre ,dbo.clientes.idclientev 
FROM            clientes 
WHEre Nombre  LIKE  '%' + @letra+'%' and Proveedor ='SI' 
END









GO
/****** Object:  StoredProcedure [dbo].[buscar_cliente_POR_nombre_PARA_PAGOS]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[buscar_cliente_POR_nombre_PARA_PAGOS]

@letra VARCHAR(50)
AS BEGIN
SELECT       dbo.clientes .Nombre ,dbo.clientes.idclientev ,Saldo 
FROM            clientes 
WHEre Nombre  LIKE  '%' + @letra+'%' and Proveedor   ='SI' and Estado ='ACTIVO'
END









GO
/****** Object:  StoredProcedure [dbo].[buscar_cliente_POR_nombre_PARA_VENTAS]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[buscar_cliente_POR_nombre_PARA_VENTAS]

@letra VARCHAR(50)
AS BEGIN
SELECT        DBO.clientes.Nombre ,DBO.clientes.idclientev  
FROM            clientes 

WHEre Nombre  LIKE  '%' + @letra+'%' and Cliente='SI'  
END








GO
/****** Object:  StoredProcedure [dbo].[buscar_cliente_POR_nombre_PARA_VENTAS_buscador]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[buscar_cliente_POR_nombre_PARA_VENTAS_buscador]

@letra VARCHAR(50)
AS BEGIN
SELECT        DBO.clientes.Nombre  ,clientes.idclientev,clientes.Saldo 
 
FROM         clientes 
WHEre Nombre  LIKE  '%' + @letra+'%' and Cliente='SI' 
group by	DBO.clientes.Nombre ,clientes.idclientev,clientes.Saldo 
END










GO
/****** Object:  StoredProcedure [dbo].[buscar_cliente_POR_nombre_PARA_VENTAS_todos]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[buscar_cliente_POR_nombre_PARA_VENTAS_todos]

@letra VARCHAR(50)
AS BEGIN
SELECT        DBO.clientes.Nombre ,DBO.clientes.idclientev ,Direccion_para_factura  ,movil  ,Ruc
FROM         clientes
WHEre Nombre+movil +Direccion_para_factura   LIKE  '%' + @letra+'%' and Cliente='SI'AND Estado ='ACTIVO' ORDER BY idclientev desc
END








GO
/****** Object:  StoredProcedure [dbo].[buscar_cobros_x_vendedor_y_fecha]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[buscar_cobros_x_vendedor_y_fecha]
@idvendedor as int,
@fecha as date

as
SELECT       sum(DETALLE_CONTROL_DE_COBROS.Pago_realizado ) as TOTAL
						
FROM            DETALLE_CONTROL_DE_COBROS  
where Id_usuario =@idvendedor AND CONVERT(DATE,Fecha_que_pago )=@fecha 








GO
/****** Object:  StoredProcedure [dbo].[BUSCAR_CONCEPTOS_EN_GASTOS_VARIOS]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[BUSCAR_CONCEPTOS_EN_GASTOS_VARIOS]
@letra VARCHAR(50)
AS BEGIN
SELECT        dbo.CONCEPTOS.Id_concepto, dbo.CONCEPTOS.Descripcion AS Concepto 
                      
FROM            dbo.CONCEPTOS 
						 WHERE CONCEPTOS.Descripcion   LIKE  '%' + @letra+'%' 
						 END









GO
/****** Object:  StoredProcedure [dbo].[buscar_creditos_x_vendedor_y_fecha]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[buscar_creditos_x_vendedor_y_fecha]
@idvendedor as int,
@fecha as date

as
SELECT       sum(ventas.Saldo ) as TOTAL
	FROM           
                         dbo.ventas 
						

     
where Id_usuario =@idvendedor AND CONVERT(DATE,ventas.fecha_venta   )=@fecha and
ventas.Estado='DEUDA' AND  ventas.Tipo_de_pago='CREDITO'








GO
/****** Object:  StoredProcedure [dbo].[buscar_Empresa]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[buscar_Empresa]
@letra varchar(50)
as
select LOGO, Nombre_Empresa as Empresa ,(Impuesto + ' ('+  CONVERT(VARCHAR(50),Porcentaje_impuesto) + ')') Impuesto ,Moneda , Id_empresa AS OKA ,Id_empresa  
,Porcentaje_impuesto  ,Impuesto ,Trabajas_con_impuestos,Modo_de_busqueda 
from Empresa
where EMPRESA.Nombre_Empresa =@letra









GO
/****** Object:  StoredProcedure [dbo].[Buscar_id_USUARIOS]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Buscar_id_USUARIOS]
@Nombre_y_Apelllidos varchar(50)
as
select * from USUARIO2 
where Nombre_y_Apelllidos =@Nombre_y_Apelllidos
order by idUsuario desc









GO
/****** Object:  StoredProcedure [dbo].[buscar_linea]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[buscar_linea]
@linea as varchar(50)
as begin
select * from linea Where Linea LIKE @linea+'%'
end













GO
/****** Object:  StoredProcedure [dbo].[buscar_MOVIMIENTOS_DE_KARDEX_filtros_acumulado]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[buscar_MOVIMIENTOS_DE_KARDEX_filtros_acumulado]
@fecha date,
@tipo varchar(50),
@Id_usuario int 
AS BEGIN
SELECT     Producto1.Descripcion ,KARDEX.Tipo ,sum (KARDEX.Cantidad) Cantidad_Total ,@fecha as fecha, USUARIO2.Nombre_y_Apelllidos,@tipo as Tipo_consultado
 FROM            dbo.KARDEX INNER JOIN Producto1 on Producto1.Id_Producto1=KARDEX.Id_producto inner join USUARIO2 on USUARIO2.idUsuario =KARDEX.Id_usuario 
         
				 
WHEre KARDEX.Id_usuario =@Id_usuario and (KARDEX.Tipo=@tipo or @tipo ='-Todos-') and convert(date,KARDEX.Fecha) =convert(date,@fecha )
group by Producto1.Descripcion,KARDEX.Tipo,USUARIO2.Nombre_y_Apelllidos
ORDER BY sum (KARDEX.Cantidad) DESC
END








GO
/****** Object:  StoredProcedure [dbo].[buscar_proveedor_Form]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[buscar_proveedor_Form]

@letra VARCHAR(50)
AS BEGIN
SELECT        top 10 idclientev, Nombre, Direccion_para_factura as Direccion, Ruc,  movil as Celular
                , Estado 
FROM            dbo.clientes 
WHEre Nombre  LIKE  '%' + @letra+'%' and Proveedor   ='SI' 
END








GO
/****** Object:  StoredProcedure [dbo].[buscar_proveedor_POR_nombre]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[buscar_proveedor_POR_nombre]

@letra VARCHAR(50)
AS BEGIN
SELECT   Nombre as Cliente , idclientev 
    
FROM   clientes        
                        
WHEre Nombre  LIKE  '%' + @letra+'%' and Proveedor ='SI'
END










GO
/****** Object:  StoredProcedure [dbo].[buscar_PROVEEDOR_POR_nombre_PARA_VENTAS_todos]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[buscar_PROVEEDOR_POR_nombre_PARA_VENTAS_todos]

@letra VARCHAR(50)
AS BEGIN
SELECT        DBO.clientes.Nombre ,DBO.clientes.idclientev  ,movil  
FROM         clientes
WHEre Nombre+movil   LIKE  '%' + @letra+'%' and Proveedor ='SI' AND Estado ='ACTIVO'  ORDER BY idclientev desc
END








GO
/****** Object:  StoredProcedure [dbo].[buscar_Tipo_de_documentos_para_insertar_en_ventas]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[buscar_Tipo_de_documentos_para_insertar_en_ventas]
@letra VARCHAR(50)
AS BEGIN

SELECT        Serializacion.Id_tipodoc  AS COMPROBANTE , Serializacion.Id_tipodoc  ,dbo.Serializacion.Serie ,dbo.Serializacion.Cantidad_de_numeros  , dbo.Serializacion.numerofin ,dbo.Serializacion.Id_serializacion ,(dbo.Serializacion.Serie  +' - '+ dbo.Serializacion.Cantidad_de_numeros + dbo.Serializacion.numerofin) as serie_completa,Serializacion.Id_tipodoc,Serializacion.Id_tipodoc 
FROM            dbo.Serializacion 
 
 WHEre Serializacion.Id_tipodoc =@letra  and dbo.Serializacion .Destino  ='VENTAS'
 end









GO
/****** Object:  StoredProcedure [dbo].[buscar_USUARIO_por_correo]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[buscar_USUARIO_por_correo]
@correo VARCHAR(max)

AS 
SELECT        Password 
FROM            dbo.USUARIO2						 
WHEre Correo =@correo








GO
/****** Object:  StoredProcedure [dbo].[buscar_USUARIO_por_DNI]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[buscar_USUARIO_por_DNI]
@letrab VARCHAR(50)
AS BEGIN
select USUARIO2 .idUsuario,USUARIO2.Nombre_y_Apelllidos as [Nombres] ,USUARIO2 .Login as Usuario,USUARIO2.Password 
,Icono ,Nombre_de_icono ,Correo ,rol,Estado  from usuario2						 
WHEre Nombre_y_Apelllidos+login LIKE  '%' + @letrab+'%' 
END









GO
/****** Object:  StoredProcedure [dbo].[buscar_USUARIO_por_nombre]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[buscar_USUARIO_por_nombre]
@letra VARCHAR(50),
@pas varchar(50)
AS BEGIN
SELECT        idUsuario, Nombre_y_Apelllidos,Password 
FROM            dbo.USUARIO2						 
WHEre Nombre_y_Apelllidos LIKE  '%' + @letra+'%' AND Password=@pas
END








GO
/****** Object:  StoredProcedure [dbo].[buscar_ventas_a_credito_con_productos_x_vendedor_y_fecha]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[buscar_ventas_a_credito_con_productos_x_vendedor_y_fecha]
@idvendedor as int,
@fecha as date

as
SELECT       sum(ventas.Monto_total) as TOTAL
						
FROM            ventas
where Id_usuario =@idvendedor AND CONVERT(DATE,fecha_venta)=@fecha AND Estado='DEUDA' AND ACCION='VENTA'








GO
/****** Object:  StoredProcedure [dbo].[buscar_ventas_por_fecha]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[buscar_ventas_por_fecha]


@fi  date,
@ff date
AS 
SELECT       ventas. idventa , fecha_venta ,Comprobante +' '+Numero_de_doc  ,Monto_total ,USUARIO2.Nombre_y_Apelllidos ,ventas.Pago_con
,Empresa.Moneda + ' '+convert(varchar(50),Ventas.Monto_total)   as TOTAL
,clientes.Nombre as CLiente,ventas.Tipo_de_pago, ventas.Pago_con , ventas. vuelto 
FROM            dbo.ventas 	inner join USUARIO2  on USUARIO2 .idUsuario  =ventas.Id_usuario  	inner join detalle_venta on detalle_venta.idventa=ventas.idventa 				 
CROSS JOIN EMPRESA
inner join clientes on clientes.idclientev =ventas.idclientev

WHEre  convert(date,ventas.fecha_venta) >=@fi and convert(date,ventas.fecha_venta)  <=@ff and
ACCION ='VENTA' AND ventas.Estado='CONFIRMADO'









GO
/****** Object:  StoredProcedure [dbo].[buscar_ventas_por_numero_de_comprobante]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[buscar_ventas_por_numero_de_comprobante]


@letra VARCHAR(50)
AS 
SELECT      TOP 10 ventas. idventa , fecha_venta ,Comprobante +' '+Numero_de_doc  ,Monto_total ,USUARIO2.Nombre_y_Apelllidos ,ventas.Pago_con
,Empresa.Moneda + ' '+convert(varchar(50),Ventas.Monto_total)   as TOTAL
,clientes.Nombre as CLiente,ventas.Tipo_de_pago, ventas.Pago_con , ventas. vuelto 
FROM            dbo.ventas 	inner join USUARIO2  on USUARIO2 .idUsuario  =ventas.Id_usuario  	inner join detalle_venta on detalle_venta.idventa=ventas.idventa 				 
CROSS JOIN EMPRESA
inner join clientes on clientes.idclientev =ventas.idclientev
WHEre Comprobante +Numero_de_doc    LIKE  '%' + @letra+'%' and ventas.Monto_total >0 AND ventas.Estado='CONFIRMADO'
AND ACCION ='VENTA' 









GO
/****** Object:  StoredProcedure [dbo].[buscar_ventas_por_numero_usuario]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[buscar_ventas_por_numero_usuario]


@letra VARCHAR(50)
AS 

SELECT       ventas. idventa , fecha_venta ,Comprobante +' '+Numero_de_doc  ,Monto_total ,USUARIO2.Nombre_y_Apelllidos ,ventas.Pago_con
,Empresa.Moneda + ' '+convert(varchar(50),Ventas.Monto_total)   as TOTAL
FROM            dbo.ventas 	inner join USUARIO2  on USUARIO2 .idUsuario  =ventas.Id_usuario  	inner join detalle_venta on detalle_venta.idventa=ventas.idventa 				 
CROSS JOIN EMPRESA

WHEre USUARIO2.Nombre_y_Apelllidos    LIKE  '%' + @letra+'%'









GO
/****** Object:  StoredProcedure [dbo].[buscar_ventas_por_numero_usuario_FILTRADO]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[buscar_ventas_por_numero_usuario_FILTRADO]


@letra VARCHAR(50)
AS 
SELECT        idventa , fecha_venta ,Comprobante +Numero_de_doc  ,Monto_total ,USUARIO2.Nombre_y_Apelllidos ,ventas.Pago_con
FROM            dbo.ventas 	inner join USUARIO2  on USUARIO2 .idUsuario  =ventas.Id_usuario  					 
WHEre USUARIO2.Nombre_y_Apelllidos =@letra   









GO
/****** Object:  StoredProcedure [dbo].[buscar_ventas_por_usuario_sin_repeticion]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[buscar_ventas_por_usuario_sin_repeticion]

AS
SELECT USUARIO2.idUsuario ,USUARIO2.Nombre_y_Apelllidos,VENTAS.Tipo_de_pago ,ventas.Fecha_de_pago 
FROM            dbo.ventas 	inner join USUARIO2  on USUARIO2 .idUsuario  =ventas.Id_usuario  					 












GO
/****** Object:  StoredProcedure [dbo].[Cambiar_Password]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Cambiar_Password]
@login varchar(50),
@Password varchar(50),
@NuevoPassword varchar(50)
as
update USUARIO2 set Password = @NuevoPassword
where Login = @login and Password = @Password













GO
/****** Object:  StoredProcedure [dbo].[Cambio_de_mesa_a_otra]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Cambio_de_mesa_a_otra]
@Idmesa int
AS
UPDATE Mesas set Estado_de_Disponibilidad ='LIBRE'
where Id_mesa=@Idmesa 







GO
/****** Object:  StoredProcedure [dbo].[Cambio_de_mesa_a_otra_DESTINO_OCUPADO]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Cambio_de_mesa_a_otra_DESTINO_OCUPADO]
@Idmesa int
AS
UPDATE Mesas set Estado_de_Disponibilidad ='OCUPADO'
where Id_mesa=@Idmesa 







GO
/****** Object:  StoredProcedure [dbo].[CERRAR_CAJA]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[CERRAR_CAJA]
@idcaja as integer,
@fechafin datetime,
@fechacierre datetime


		
as 
update MOVIMIENTOCAJACIERRE set 
Estado ='CAJA CERRADA'
where Id_caja =@idcaja AND Estado='CAJA APERTURADA'












GO
/****** Object:  StoredProcedure [dbo].[cerrar_caja_diaria]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[cerrar_caja_diaria]

	 @fechafin datetime,
	 @fechacierre datetime, 
	  @ingresos numeric(18,2), 
    @egresos numeric(18,2),
	
	@saldo numeric(18,2),
	 @totalcaluclado numeric(18,2),
	  @totalreal real, 
	 @estado as varchar(50),
	 @diferencia numeric(18,2)
as BEGIN
if EXISTS (SELECT idcierrecaja   FROM MOVIMIENTOCAJACIERRE   where idcierrecaja   = idcierrecaja  and Estado='CAJA CERRADA' )
RAISERROR ('YA SE CERRO CAJA DIARIA; COORDINE CON EL ADMINISTRADOR A CARGO', 16,1)
else
BEGIN 

update MOVIMIENTOCAJACIERRE  set 
fechafin=@fechafin ,
fechacierre=@fechacierre,
ingresos=@ingresos,
egresos=@egresos  ,
Saldo_queda_en_caja =@saldo  ,
Total_calculado =@totalcaluclado  ,
Total_real =@totalreal  ,
Estado=@estado, 
Diferencia=@diferencia 
where idcierrecaja  =idcierrecaja


select*from MOVIMIENTOCAJACIERRE 
END
END











GO
/****** Object:  StoredProcedure [dbo].[cerrar_caja_por_turno]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[cerrar_caja_por_turno]
@idcierrecaja as int,
	 @fechafin datetime,
	 @fechacierre datetime, 
	  @ingresos numeric(18,2), 
    @egresos numeric(18,2),	
	@saldo numeric(18,2),
	 @totalcaluclado numeric,
	  @totalreal real, 
	 @estado as varchar(50),
	 @diferencia numeric(18,2),
	 @idusuario as int
as 
update MOVIMIENTOCAJACIERRE  set 
fechafin=@fechafin ,
fechacierre=@fechacierre,
ingresos=@ingresos,
egresos=@egresos  ,
Saldo_queda_en_caja =@saldo  ,
Total_calculado =@totalcaluclado  ,
Total_real =@totalreal  ,
Estado=@estado, 
Diferencia=@diferencia 
where idcierrecaja  =@idcierrecaja














GO
/****** Object:  StoredProcedure [dbo].[cobrar_CONTROL_DE_COBROS]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[cobrar_CONTROL_DE_COBROS]
@Id_venta as int,

@Monto numeric(18,2)

as 
update CONTROL_DE_COBROS  set Monto=Monto - @Monto 
where Id_venta    =@Id_venta  









GO
/****** Object:  StoredProcedure [dbo].[Confirmar_venta]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Confirmar_venta]
@idventa int,
@montototal as numeric(18,2),
@IGV as numeric(18,2)

,@Saldo numeric(18,2),
@Tipo_de_pago varchar(50),
@Estado varchar(50),
@Comprobante varchar(50),
@Numero_de_doc varchar(50),
@fecha_venta datetime,
@ACCION varchar(50),
@Fecha_de_pago varchar(50),
@idcliente int,
@Pago_con numeric(18,2),
@Referencia_tarjeta varchar(50),
@Vuelto as numeric(18,2),

@Efectivo as numeric(18,2),
@Credito numeric(18,2),
@Tarjeta numeric(18,2),
@Donde_se_consumira as varchar(50)
as

update ventas set Monto_total  =@montototal, IGV=@IGV ,Saldo=@Saldo,
Tipo_de_pago=@Tipo_de_pago 
,Estado=@Estado ,
Comprobante =@Comprobante ,
Numero_de_doc=@Numero_de_doc ,
fecha_venta=@fecha_venta ,
ACCION=@ACCION ,Fecha_de_pago =@Fecha_de_pago ,idclientev=@idcliente ,
Pago_con=@Pago_con,Referencia_tarjeta=@Referencia_tarjeta,
Vuelto=@Vuelto ,Efectivo=@Efectivo,Credito=@Credito,Tarjeta=@Tarjeta ,
Donde_se_consumira=@Donde_se_consumira 
where idventa =@idventa 











GO
/****** Object:  StoredProcedure [dbo].[Contar_Paginar_grupos]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Contar_Paginar_grupos]
@Desde INT,
@Hasta INT

AS
BEGIN
SET NOCOUNT ON;
SELECT
Contador
FROM
(SELECT
Count(Idline) as Contador ,

ROW_NUMBER() OVER (ORDER BY Idline) 'Numero_de_fila'
FROM
Grupo_de_Productos
group by Idline
) AS Paginado
WHERE
(Paginado.Numero_de_fila >= @Desde)AND (Paginado.Numero_de_fila<= @Hasta )
END







GO
/****** Object:  StoredProcedure [dbo].[contar_productos_en_espera]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE proc [dbo].[contar_productos_en_espera]
 as
 SELECT      count(detalle_venta.Id_producto  ) as id_producto
FROM            dbo.ventas inner join detalle_venta on detalle_venta.idventa =detalle_venta.idventa  
             
where  
 ventas.Estado='EN ESPERA'or  ventas.Estado='SIN CONFIRMAR'








GO
/****** Object:  StoredProcedure [dbo].[contar_productos_por_grupo]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[contar_productos_por_grupo]
@idgrupo int
as
select count(Id_Producto1) from Producto1
where Id_grupo =@idgrupo 





GO
/****** Object:  StoredProcedure [dbo].[contar_ventas_en_espera]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[contar_ventas_en_espera]

AS 

 SELECT      ventas.idventa , count(detalle_venta.Id_producto  ) as id_producto,Comprobante ,ventas.fecha_venta 
FROM            dbo.ventas inner join detalle_venta on detalle_venta.idventa =detalle_venta.idventa  
     
where  
 ventas.Estado='EN ESPERA'or  ventas.Estado='SIN CONFIRMAR'

 group by ventas.idventa,Comprobante ,ventas.fecha_venta









GO
/****** Object:  StoredProcedure [dbo].[CONTARNOTIFICADOR_COBROS]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[CONTARNOTIFICADOR_COBROS]

as 
SELECT       count(idclientev )
FROM          
                         dbo.clientes 
						 WHERE Saldo >0 AND Cliente ='SI'








GO
/****** Object:  StoredProcedure [dbo].[CONTARNOTIFICADOR_PAGOS]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[CONTARNOTIFICADOR_PAGOS]

as 
SELECT       count(idclientev )
FROM          
                         dbo.clientes 
						 WHERE Saldo >0 AND Proveedor  ='SI'








GO
/****** Object:  StoredProcedure [dbo].[disminuir_stock]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[disminuir_stock]
@Id_presentacionfraccionada as varchar(50),
@cantidad as decimal (18,2)

as
update Producto1  set Stock=Stock-@cantidad where Id_Producto1  =@Id_presentacionfraccionada AND Usa_inventarios ='SI'
and Stock >= @cantidad 










GO
/****** Object:  StoredProcedure [dbo].[disminuir_tamanio_letra]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[disminuir_tamanio_letra]


as
if exists(select Tamanio_letra  from  Propiedades_de_mesas Where Tamanio_letra<=9)
RAISERROR ('Exece el Limite de TamaÃƒÆ’Ã†â€™Ãƒâ€ Ã¢â‚¬â„¢ÃƒÆ’Ã¢â‚¬Â ÃƒÂ¢Ã¢â€šÂ¬Ã¢â€žÂ¢ÃƒÆ’Ã†â€™ÃƒÂ¢Ã¢â€šÂ¬Ã‚Â ÃƒÆ’Ã‚Â¢ÃƒÂ¢Ã¢â‚¬Å¡Ã‚Â¬ÃƒÂ¢Ã¢â‚¬Å¾Ã‚Â¢ÃƒÆ’Ã†â€™Ãƒâ€ Ã¢â‚¬â„¢ÃƒÆ’Ã‚Â¢ÃƒÂ¢Ã¢â‚¬Å¡Ã‚Â¬Ãƒâ€¦Ã‚Â¡ÃƒÆ’Ã†â€™ÃƒÂ¢Ã¢â€šÂ¬Ã…Â¡ÃƒÆ’Ã¢â‚¬Å¡Ãƒâ€šÃ‚Â±o', 16,1)
else
update Propiedades_de_mesas set tamanio_letra=tamanio_letra-10
select x from Propiedades_de_mesas 








GO
/****** Object:  StoredProcedure [dbo].[disminuir_tamanio_mesa]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[disminuir_tamanio_mesa]


as

if exists(select x,y from  Propiedades_de_mesas Where x=92 and y=77)
RAISERROR ('Exece el Limite de TamaÃƒÆ’Ã†â€™Ãƒâ€ Ã¢â‚¬â„¢ÃƒÆ’Ã¢â‚¬Â ÃƒÂ¢Ã¢â€šÂ¬Ã¢â€žÂ¢ÃƒÆ’Ã†â€™ÃƒÂ¢Ã¢â€šÂ¬Ã‚Â ÃƒÆ’Ã‚Â¢ÃƒÂ¢Ã¢â‚¬Å¡Ã‚Â¬ÃƒÂ¢Ã¢â‚¬Å¾Ã‚Â¢ÃƒÆ’Ã†â€™Ãƒâ€ Ã¢â‚¬â„¢ÃƒÆ’Ã‚Â¢ÃƒÂ¢Ã¢â‚¬Å¡Ã‚Â¬Ãƒâ€¦Ã‚Â¡ÃƒÆ’Ã†â€™ÃƒÂ¢Ã¢â€šÂ¬Ã…Â¡ÃƒÆ’Ã¢â‚¬Å¡Ãƒâ€šÃ‚Â±o', 16,1)
else
update Propiedades_de_mesas set x=x-10,y=y-10









GO
/****** Object:  StoredProcedure [dbo].[disminuirmontocuota]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[disminuirmontocuota]
@Id_control_de_cobros as integer,
@montopagado as decimal(18,2)

as 
update  CONTROL_DE_COBROS   set Monto  =Monto -@montopagado 
where Id_control_de_cobros =@Id_control_de_cobros 









GO
/****** Object:  StoredProcedure [dbo].[disminuirSaldocliente]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[disminuirSaldocliente]
@Id_cliente as integer,
@montopagado as numeric(18,2)

as 
update  clientes    set Saldo   =Saldo  -@montopagado 
where idclientev  =@Id_cliente 









GO
/****** Object:  StoredProcedure [dbo].[editar_ASISTENCIAS]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[editar_ASISTENCIAS]
@Id_personal as int,
@Fecha_salida DATETIME,
@Horas NUMERIC(18,2)
as 
update ASISTENCIAS set 
Fecha_salida =@Fecha_salida ,
Horas =@Horas ,
Estado='SALIDA'
where Id_personal   =@Id_personal  AND Estado='ENTRADA' 












GO
/****** Object:  StoredProcedure [dbo].[editar_caja]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[editar_caja]
@idcaja integer,
@descripcion varchar(50)

        
           		
as 
update Caja set 
Descripcion  =@descripcion 

where Id_Caja    =@idcaja    








GO
/****** Object:  StoredProcedure [dbo].[editar_categoria]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[editar_categoria]
@idcategoria integer,
@nombrecategoria varchar(50)
as 
update categoria set nombrecategoria = @nombrecategoria 
where idcategoria = @idcategoria 














GO
/****** Object:  StoredProcedure [dbo].[editar_cliente]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[editar_cliente]
@idcliente as integer,
@Nombre varchar(MAX),
           @Direccion_para_factura varchar(MAX),
            @Ruc varchar(MAX),                      
            @movil varchar(50)
		
as 
if EXISTS (SELECT Nombre  FROM clientes  where (Nombre  = @Nombre and idclientev  <>@idcliente ) )

RAISERROR ('YA EXISTE UN REGISTRO  CON ESTE NOMBRE, POR FAVOR INGRESE DE NUEVO', 16,1)
update clientes set 
Nombre =@Nombre ,
          Direccion_para_factura = @Direccion_para_factura ,
           Ruc = @Ruc ,
          
          movil  = @movil 
where idclientev =@idcliente 









GO
/****** Object:  StoredProcedure [dbo].[editar_CONCEPTO]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[editar_CONCEPTO]
@Id_concepto as int,
@Descripcion varchar(50)
as 
update CONCEPTOS set 

Descripcion=@Descripcion 

where Id_concepto    =@Id_concepto










GO
/****** Object:  StoredProcedure [dbo].[editar_conteo]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[editar_conteo]
as 
update Conteo_de_paginado set Conteo1=1, Conteo2 =15






GO
/****** Object:  StoredProcedure [dbo].[editar_conteo_suma]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[editar_conteo_suma]
as 
update Conteo_de_paginado set Conteo1=Conteo1+15, Conteo2 =Conteo2 +14






GO
/****** Object:  StoredProcedure [dbo].[editar_correo_base]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create proc [dbo].[editar_correo_base]
 @Correo varchar(max),
@Password varchar(max),
@Estado_De_envio varchar(max)

as

update  Correo_base set Correo =@Correo, Password=@Password,Estado_De_envio=@Estado_De_envio








GO
/****** Object:  StoredProcedure [dbo].[editar_correo_Empresa]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create proc [dbo].[editar_correo_Empresa]
 @Correo_para_envio_de_reportes varchar(max)

as

update  EMPRESA set Correo_para_envio_de_reportes =@Correo_para_envio_de_reportes 








GO
/****** Object:  StoredProcedure [dbo].[editar_detalle_descuento_por_producto]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[editar_detalle_descuento_por_producto]

  @porcentaje numeric(18,18)
,@Id_detalleventa  as int   	

as 
	update detalle_venta  set 
preciounitario =preciounitario-@porcentaje*preciounitario


where  detalle_venta.iddetalle_venta =@Id_detalleventa  









GO
/****** Object:  StoredProcedure [dbo].[editar_detalle_venta_Cantidad]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[editar_detalle_venta_Cantidad]
@Id_producto  int,
@cantidad as numeric(18, 2),
@Cantidad_mostrada  numeric(18, 2)   
,@Id_venta  as int   	

as 
update detalle_venta  set 
cantidad    =@cantidad ,
Cantidad_mostrada=@Cantidad_mostrada
where  detalle_venta .Id_producto    =@Id_producto and detalle_venta.idventa=@Id_venta 






GO
/****** Object:  StoredProcedure [dbo].[Editar_detalle_venta_para_cambio_De_mesa]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Editar_detalle_venta_para_cambio_De_mesa]
@id_venta_destino int ,
@id_venta_origen int 
as
update detalle_venta set idventa=@id_venta_destino
where detalle_venta.idventa= @id_venta_origen
begin
delete from ventas where ventas.idventa=@id_venta_origen
end







GO
/****** Object:  StoredProcedure [dbo].[editar_detalle_venta_Precio_de_venta]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[editar_detalle_venta_Precio_de_venta]
@Id_producto  int,
@preciounitario numeric(18,2)
,@Id_venta  as int   	

as 
update detalle_venta  set 
preciounitario     =@preciounitario 
where  Id_producto    =@Id_producto and idventa=@Id_venta 






GO
/****** Object:  StoredProcedure [dbo].[editar_detalle_venta_restar]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[editar_detalle_venta_restar]
@iddetalle_venta  int
   ,@Id_venta  as int     		
as 
		
if EXISTS (SELECT cantidad ,Id_producto    FROM detalle_venta  where detalle_venta .iddetalle_venta   = @iddetalle_venta  AND cantidad <=0 and detalle_venta .idventa    = @Id_venta )

delete from detalle_venta where detalle_venta .iddetalle_venta  =@iddetalle_venta and detalle_venta .idventa    = @Id_venta
else


update detalle_venta  set 
cantidad    =cantidad -1 ,
Cantidad_mostrada=Cantidad_mostrada-1
where detalle_venta .iddetalle_venta  =@iddetalle_venta and  detalle_venta.idventa=@Id_venta 
GO
/****** Object:  StoredProcedure [dbo].[editar_detalle_venta_sumar]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[editar_detalle_venta_sumar]
@iddetalle_venta  int
   ,@Id_venta  as int     		
as 
		
update detalle_venta  set 
cantidad    =cantidad +1 ,
Cantidad_mostrada=Cantidad_mostrada+1
where  detalle_venta .iddetalle_venta    =@iddetalle_venta and detalle_venta.idventa=@Id_venta 












GO
/****** Object:  StoredProcedure [dbo].[editar_dinero_caja_inicial]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[editar_dinero_caja_inicial]
@Id_caja as integer,
@saldo numeric(18,2)


as
update MOVIMIENTOCAJACIERRE  set  Saldo_queda_en_caja =@saldo
where Id_caja =@Id_caja AND Estado ='CAJA APERTURADA'












GO
/****** Object:  StoredProcedure [dbo].[editar_Empresa]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE proc [dbo].[editar_Empresa]
 @Id_empresa int,
@Nombre_Empresa  varchar(50),

@logo as image,
@Impuesto varchar(50),
@Porcentaje_impuesto numeric(18,0),
@Moneda varchar(50),
@Trabajas_con_impuestos VARCHAR(50),
@Modo_de_busqueda VARCHAR(50),

@Carpeta_para_copias_de_seguridad varchar(max),
@Correo_para_envio_de_reportes varchar(50),
@Redondeo varchar(50)
as

update  EMPRESA set Nombre_Empresa=@Nombre_Empresa,Logo=@logo ,Impuesto=@Impuesto ,
Porcentaje_impuesto=@Porcentaje_impuesto,Moneda=@Moneda,Trabajas_con_impuestos=@Trabajas_con_impuestos
,Modo_de_busqueda=@Modo_de_busqueda ,Redondeo_de_total =@Redondeo 
,Carpeta_para_copias_de_seguridad =@Carpeta_para_copias_de_seguridad ,Correo_para_envio_de_reportes =@Correo_para_envio_de_reportes 
where Id_empresa=@Id_empresa 









GO
/****** Object:  StoredProcedure [dbo].[editar_Empresa_copia_de_seguridad]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE proc [dbo].[editar_Empresa_copia_de_seguridad]
 @Ultima_fecha_de_copia_de_seguridad varchar(50),
 @Carpeta_para_copias_de_seguridad varchar(max),
 @Ultima_fecha_de_copia_date datetime
as

update  EMPRESA set Ultima_fecha_de_copia_de_seguridad =@Ultima_fecha_de_copia_de_seguridad ,
Carpeta_para_copias_de_seguridad =@Carpeta_para_copias_de_seguridad ,Ultima_fecha_de_copia_date=@Ultima_fecha_de_copia_date









GO
/****** Object:  StoredProcedure [dbo].[Editar_estado_caja]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Editar_estado_caja]
@estado as varchar(50),
@idcaja int
as
update Caja set Estado=@estado
where Id_Caja=@idcaja 






GO
/****** Object:  StoredProcedure [dbo].[editar_estado_de_detalle_de_venta]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[editar_estado_de_detalle_de_venta]
@iddetalleventa int
as
update detalle_venta  set Estado_de_pago ='PAGADO'
WHERE iddetalle_venta   =@iddetalleventa







GO
/****** Object:  StoredProcedure [dbo].[editar_estado_de_detalle_de_venta_etapa1]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[editar_estado_de_detalle_de_venta_etapa1]
@iddetalleventa int
as
update detalle_venta  set Estado_de_pago ='IMPRESO'
WHERE iddetalle_venta   =@iddetalleventa






GO
/****** Object:  StoredProcedure [dbo].[Editar_estado_de_mesa_a_LIBRE]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Editar_estado_de_mesa_a_LIBRE]
@Idmesa int
AS
UPDATE Mesas set Estado_de_Disponibilidad ='LIBRE'
where Id_mesa=@Idmesa 






GO
/****** Object:  StoredProcedure [dbo].[Editar_estado_de_mesa_a_OCUPADO]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Editar_estado_de_mesa_a_OCUPADO]
@Idmesa int
AS
UPDATE Mesas set Estado_de_Disponibilidad ='OCUPADO'
where Id_mesa=@Idmesa 







GO
/****** Object:  StoredProcedure [dbo].[editar_estado_de_pedido_a_DESPACHADO]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[editar_estado_de_pedido_a_DESPACHADO]
@Iddetalleventa int
as
update detalle_venta set Estado ='DESPACHADO'
WHERE iddetalle_venta =@Iddetalleventa






GO
/****** Object:  StoredProcedure [dbo].[editar_estado_de_pedido_a_ENESPERA]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[editar_estado_de_pedido_a_ENESPERA]
@Iddetalleventa int
as
update detalle_venta set Estado ='EN ESPERA'
WHERE iddetalle_venta =@Iddetalleventa






GO
/****** Object:  StoredProcedure [dbo].[editar_estado_de_pedido_a_ENPREPARACION]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[editar_estado_de_pedido_a_ENPREPARACION]
@Iddetalleventa int
as
update detalle_venta set Estado ='EN PREPARACION'
WHERE iddetalle_venta =@Iddetalleventa






GO
/****** Object:  StoredProcedure [dbo].[editar_estado_de_Venta_DESPACHADO]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[editar_estado_de_Venta_DESPACHADO]
@idventa int
as
update ventas  set Estado ='DESPACHADO'
WHERE idventa  =@idventa






GO
/****** Object:  StoredProcedure [dbo].[editar_estado_de_Venta_ENESPERA]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[editar_estado_de_Venta_ENESPERA]
@idventa int
as
update ventas  set Estado ='EN ESPERA'
WHERE idventa  =@idventa






GO
/****** Object:  StoredProcedure [dbo].[editar_estado_de_Venta_TERMINADO]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[editar_estado_de_Venta_TERMINADO]
@idventa int
as
update ventas  set Estado ='TERMINADO'
WHERE idventa  =@idventa





GO
/****** Object:  StoredProcedure [dbo].[editar_FORMATO_TICKET]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[editar_FORMATO_TICKET]
    	  @Identificador_fiscal varchar(max),
           @Direccion varchar(max),
         
           @Provincia_Departamento_Pais varchar(max),
           @Nombre_de_Moneda varchar(max),
           @Agradecimiento varchar(max),
           @pagina_Web_Facebook varchar(max),
           @Anuncio varchar(max),
	   @Datos_fiscales_de_autorizacion varchar(max),
	   @Por_defecto  varchar(max),
	   @Nombre_Empresa varchar(max),
	   @Logo image
    as
	begin
    update Ticket set  
	Identificador_fiscal=@Identificador_fiscal ,
          Direccion =@Direccion ,    
           Provincia_Departamento_Pais=@Provincia_Departamento_Pais ,
           Nombre_de_Moneda=@Nombre_de_Moneda ,
          Agradecimiento  =@Agradecimiento ,
          pagina_Web_Facebook = @pagina_Web_Facebook ,
         Anuncio =  @Anuncio,
		   Datos_fiscales_de_autorizacion=@Datos_fiscales_de_autorizacion,
		   Por_defecto=@Por_defecto
		   end 

		   begin
		    update EMPRESA  set  
			Nombre_Empresa=@Nombre_Empresa, 
			Logo=@Logo 
			end 








GO
/****** Object:  StoredProcedure [dbo].[editar_frecuencia_y_carpeta_Empresa]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create proc [dbo].[editar_frecuencia_y_carpeta_Empresa]

@Carpeta_para_copias_de_seguridad varchar(max),
@Frecuencia_de_copias int
as

update  EMPRESA set Carpeta_para_copias_de_seguridad =@Carpeta_para_copias_de_seguridad  ,
Frecuencia_de_copias =@Frecuencia_de_copias 









GO
/****** Object:  StoredProcedure [dbo].[editar_gasto]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[editar_gasto]
@idgasto int,
@fecha datetime,

@observacion varchar(500),
@Nro_Comprobante varchar(50),

@Tipo_de_Comprobante varchar(50),

@importe decimal(18,2),

@Id_concepto int


as 
update GASTOSVARIOS  set Nro_Comprobante=@Nro_Comprobante,
Tipo_de_Comprobante=@Tipo_de_Comprobante,
Fecha_del_Gasto=@fecha 
 ,Id_concepto =@Id_concepto 
  ,Importe =@importe  ,
  Descripcion =@observacion  

where Idgasto  =@idgasto  








GO
/****** Object:  StoredProcedure [dbo].[editar_IGV_Empresa]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE proc [dbo].[editar_IGV_Empresa]

@Impuesto varchar(50),
@Porcentaje_impuesto numeric(18,0),

@Trabajas_con_impuestos VARCHAR(50)
as

update  EMPRESA set Impuesto=@Impuesto ,
Porcentaje_impuesto=@Porcentaje_impuesto,Trabajas_con_impuestos=@Trabajas_con_impuestos











GO
/****** Object:  StoredProcedure [dbo].[editar_ingreso]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[editar_ingreso]
@idgasto as int,
@fecha datetime,

@observacion varchar(500),
@Nro_Comprobante varchar(50),

@Tipo_de_Comprobante varchar(50),
@importe decimal(18,2),
@estado as varchar(50),
@Id_concepto INT
as 
update INGRESOSVARIOS  set Estado=@estado ,Nro_Comprobante=@Nro_Comprobante,Tipo_de_Comprobante=@Tipo_de_Comprobante,Fecha_del_Gasto=@fecha  ,Id_concepto =@Id_concepto  ,Importe =@importe  ,Observacion =@observacion  
where Idgasto  =@idgasto  












GO
/****** Object:  StoredProcedure [dbo].[editar_inicio_De_sesion]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[editar_inicio_De_sesion]

 
 @Id_serial_Pc varchar(max),
 @id_usuario int
  as
update Inicios_de_sesion_por_caja set 
Id_usuario =@id_usuario 
where Id_serial_Pc=@Id_serial_Pc 








GO
/****** Object:  StoredProcedure [dbo].[editar_lineas]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[editar_lineas]
@Idline as integer,
@Linea varchar(50)
        
           		
as 
update linea set 
Linea =@Linea  

where Idline   =@Idline   










GO
/****** Object:  StoredProcedure [dbo].[editar_logo_de_EMPRESA]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[editar_logo_de_EMPRESA]
@logo image
as 

update EMPRESA  set  Logo   =@logo            












GO
/****** Object:  StoredProcedure [dbo].[EDITAR_marcan]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[EDITAR_marcan]

	@e varchar(50)
    as
	
    UPDATE Marcan SET E=@e








GO
/****** Object:  StoredProcedure [dbo].[EDITAR_marcan_a]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[EDITAR_marcan_a]

	@e varchar(50),
	@fa varchar(50),
	@f  varchar(max),
	@s varchar(50)
    as
	
    UPDATE Marcan SET E=@e, FA=@fa, F=@f 
	where S=@s 








GO
/****** Object:  StoredProcedure [dbo].[editar_mesa]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[editar_mesa]

@mesa as varchar(50)
,@id_mesa as int
as
if EXISTS (SELECT Mesa FROM Mesas  where (Mesa  = @mesa and Id_mesa  <>@Id_mesa ))

RAISERROR ('Ya Existe una mesa con este Nombre, POR FAVOR INGRESE DE NUEVO', 16,1)
else
update Mesas set Mesa=@mesa 
where Id_mesa=@id_mesa 







GO
/****** Object:  StoredProcedure [dbo].[editar_mesa_en_la_tabla_ventas]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[editar_mesa_en_la_tabla_ventas]
@Id_mesa int
,@Idventa int
as
update ventas  set Id_mesa=@Id_mesa 
where ventas.idventa=@Idventa  







GO
/****** Object:  StoredProcedure [dbo].[editar_Modo_de_busqueda]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[editar_Modo_de_busqueda]
@Modo_de_busqueda as VARCHAR(50)

as 
update EMPRESA  set 
Modo_de_busqueda=@Modo_de_busqueda









GO
/****** Object:  StoredProcedure [dbo].[editar_nombre_de_EMPRESA]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[editar_nombre_de_EMPRESA]
@nombre varchar(50),
@moneda varchar(50)
as 

update EMPRESA   set  Nombre_Empresa  =@nombre  ,Moneda=@moneda  








GO
/****** Object:  StoredProcedure [dbo].[editar_nombre_de_EMPRESA_con_imagen]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[editar_nombre_de_EMPRESA_con_imagen]
@nombre varchar(50),

@Imagen image
as 

update EMPRESA   set  Nombre_Empresa  =@nombre  ,Logo =@Imagen 








GO
/****** Object:  StoredProcedure [dbo].[editar_permisos]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[editar_permisos]
	@Id_modulo  int ,
   @Id_Usuario  int 	
AS


insert into Permisos 
 values (	@Id_modulo  ,
	@Id_usuario
)






GO
/****** Object:  StoredProcedure [dbo].[editar_precio_unitario_en_detalle_De_venta]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[editar_precio_unitario_en_detalle_De_venta]
@iddetalle_venta int,
@precio numeric(18,2)
as
update  detalle_venta set  preciounitario=@precio
where iddetalle_venta=@iddetalle_venta










GO
/****** Object:  StoredProcedure [dbo].[editar_saldo_total]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[editar_saldo_total]
@idcliente as integer,
@saldo as numeric(18,2)


as

update clientes  set  Saldo=@saldo
where idclientev=@idcliente 












GO
/****** Object:  StoredProcedure [dbo].[editar_serializacion]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[editar_serializacion]
@serie VARCHAR(50)  ,
@Cantidad_de_numeros AS VARCHAR(50)    ,
@numerofin as varchar(50) ,
@Tipo as varchar(50), 
   @Id_serie as int
as 
update Serializacion set  Serie =@serie   ,Cantidad_de_numeros=@Cantidad_de_numeros ,numerofin=@numerofin   
         ,Id_tipodoc=@Tipo 
where Id_serializacion=@Id_serie 










GO
/****** Object:  StoredProcedure [dbo].[editar_serializacion_POR_DEFECTO]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[editar_serializacion_POR_DEFECTO]


   @Id_serie as int
as 

BEGIN
update Serializacion set  Por_defecto  ='-' 
     END


	 BEGIN
	 update Serializacion set  Por_defecto  ='SI'
where Id_serializacion=@Id_serie 

END








GO
/****** Object:  StoredProcedure [dbo].[editar_serializacion_TICKET]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[editar_serializacion_TICKET]

@numeroinicio AS VARCHAR(50)    ,
@numerofin as varchar(50) 


as 
update Serializacion set  Cantidad_de_numeros=@numeroinicio ,numerofin=@numerofin   

where Id_tipodoc ='TICKET'









GO
/****** Object:  StoredProcedure [dbo].[editar_Tema]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[editar_Tema]
@Serial varchar(max),
@Tema varchar(50)
as 

update Caja   set  Tema  =@Tema  where Serial_PC=@Serial 






GO
/****** Object:  StoredProcedure [dbo].[editar_usuario]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[editar_usuario]
@idusuario int,
@nombres varchar(50),

@paswor varchar(max)
,@Icono IMAGE
,
@Nombre_de_icono varchar(max)
,@Correo varchar(max),
@rol as varchar(MAX),
@Login as varchar(50)
as
begin
if EXISTS (SELECT Login,idUsuario FROM USUARIO2 where (Login  = @login  AND idUsuario<>@idUsuario and Estado='ACTIVO') or (Nombre_y_Apelllidos   = @nombres  AND idUsuario<>@idUsuario and Estado='ACTIVO'))
RAISERROR ('Usuario en Uso, usa otro nombre de Usuario por favor', 16,1)
else 

update USUARIO2 set Nombre_y_Apelllidos= @nombres,Password =@paswor , Icono=@Icono ,Nombre_de_icono =@Nombre_de_icono
 ,Correo =@Correo , Rol=@rol , Login =@Login 
 where idUsuario = @idusuario 
 end










GO
/****** Object:  StoredProcedure [dbo].[editar_usuario_solo_nombre]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[editar_usuario_solo_nombre]
@idusuario int,
@nombres varchar(50)
as
update USUARIO2 set Nombre_y_Apelllidos= @nombres
 where idUsuario = @idusuario









GO
/****** Object:  StoredProcedure [dbo].[editar_venta]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[editar_venta]
@idventa int,
@montototal as numeric(18,1),
@IGV as numeric(18,1)

as
if @montototal <>0
update ventas set Monto_total  =@montototal, IGV=@IGV 

where idventa =@idventa 
else
begin 
delete
from ventas 
where idventa=@idventa 
end












GO
/****** Object:  StoredProcedure [dbo].[editar_venta_principal_de_la_division]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[editar_venta_principal_de_la_division]
@Idventa int,
@divisor as int 
as
update detalle_venta set preciounitario= (preciounitario/@divisor)
where idventa =@Idventa 





GO
/****** Object:  StoredProcedure [dbo].[eliminar_caja]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[eliminar_caja]
@id integer
as
delete from Caja   where Id_Caja  =@id 










GO
/****** Object:  StoredProcedure [dbo].[eliminar_categoria]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[eliminar_categoria]
@idcategoria integer
as 
delete from categoria where idcategoria=@idcategoria














GO
/****** Object:  StoredProcedure [dbo].[eliminar_cliente]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[eliminar_cliente]
@idcliente integer
as
update  clientes set  Estado ='ELIMINADO'
where idclientev=@idcliente AND Estado='ACTIVO'









GO
/****** Object:  StoredProcedure [dbo].[eliminar_concepto]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[eliminar_concepto]
@idconcepto integer
as
delete from CONCEPTOS  where Id_concepto =@idconcepto 










GO
/****** Object:  StoredProcedure [dbo].[eliminar_DETALLE_CONTROL_DE_COBROS]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[eliminar_DETALLE_CONTROL_DE_COBROS]
@id as int
as
delete from DETALLE_CONTROL_DE_COBROS where Id_detalle_de_control_de_cobros =@id 














GO
/****** Object:  StoredProcedure [dbo].[eliminar_detalle_venta]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[eliminar_detalle_venta]
@iddetalleventa as int
as
delete from detalle_venta where iddetalle_venta=@iddetalleventa 










GO
/****** Object:  StoredProcedure [dbo].[eliminar_Empresa]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[eliminar_Empresa]
@id_Empresa as int


as

delete from EMPRESA 
where id_Empresa=@id_Empresa













GO
/****** Object:  StoredProcedure [dbo].[eliminar_gasto]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[eliminar_gasto]
@idgasto integer
as
delete from GASTOSVARIOS  where Idgasto =@idgasto 













GO
/****** Object:  StoredProcedure [dbo].[eliminar_grupos]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[eliminar_grupos]
@id int
as


if EXISTS (SELECT Idline FROM Grupo_de_Productos  where Por_defecto = 'SI' AND Idline=@id )
RAISERROR ('Este Grupo no se Permite que sea Eliminado ya que es Eliminarias todos los Productos', 16,1)
else

BEGIN
declare @Id_grupo int 
SET @Id_grupo = (SELECT Idline FROM Grupo_de_Productos  where Por_defecto = 'SI')
  
update Producto1 set Id_grupo=@Id_grupo where Id_grupo=@id
delete from Grupo_de_Productos 
where Idline=@id and Por_defecto <> 'SI'
END








GO
/****** Object:  StoredProcedure [dbo].[eliminar_impresora_para_pedidos]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[eliminar_impresora_para_pedidos]

@Impresora as varchar(max),
@idCaja int
as
declare @Id_Areas_de_Impresion int 
set @Id_Areas_de_Impresion =(Select Id_area from Areas_de_Impresion where Area = 'Impresora para Envios de Pedidos')

delete from Impresoras_por_Area  where
Impresora=@Impresora and Id_Areas_de_Impresion =@Id_areas_de_impresion and
Id_caja=  @idCaja







GO
/****** Object:  StoredProcedure [dbo].[eliminar_impresora_por_area]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[eliminar_impresora_por_area]
@Id_areas_de_impresion int,
@Impresora as varchar(max),
@idCaja int
as
delete from Impresoras_por_Area  where
Impresora=@Impresora and Id_Areas_de_Impresion =@Id_areas_de_impresion and
Id_caja=  @idCaja







GO
/****** Object:  StoredProcedure [dbo].[eliminar_ingreso]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[eliminar_ingreso]
@idgasto integer
as
delete from INGRESOSVARIOS  where Idgasto =@idgasto 













GO
/****** Object:  StoredProcedure [dbo].[eliminar_mesa]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[eliminar_mesa]


@id_mesa as int
as

update Mesas set Mesa='NULO' 
where Id_mesa=@id_mesa 







GO
/****** Object:  StoredProcedure [dbo].[eliminar_Pedido]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[eliminar_Pedido]
@idventa as integer 
as
delete from ventas where idventa=@idventa 







GO
/****** Object:  StoredProcedure [dbo].[eliminar_permisos]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[eliminar_permisos]
@Id_Usuario  int 	
AS
begin
delete from Permisos WHERE Id_usuario =@Id_Usuario 
end







GO
/****** Object:  StoredProcedure [dbo].[eliminar_producto]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[eliminar_producto]
@idproducto  int
as
delete from Producto1  where Id_Producto1 =@idproducto 













GO
/****** Object:  StoredProcedure [dbo].[eliminar_PRODUCTO_DE_KARDEX]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[eliminar_PRODUCTO_DE_KARDEX]
@id as int
as
delete from KARDEX  where Id_kardex  =@id










GO
/****** Object:  StoredProcedure [dbo].[eliminar_Producto1]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[eliminar_Producto1]
@id int
as
delete  
from Producto1 

where 
Id_Producto1  =@id



--DELETE TablaConRegistrosAEliminar
       --FROM TablaConRegistrosAEliminar TDel INNER JOIN TablaParaCriterioDeEliminacion TFiltro
       --     ON TDel.idCampo_fk=TFiltro.idCampo_pk
       --WHERE TFiltro.criterio='Valor para filtrar'












GO
/****** Object:  StoredProcedure [dbo].[eliminar_salon]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[eliminar_salon]


@id_salon as int
as

update SALON  set Estado='ELIMINADO' 
where Id_salon =@id_salon 







GO
/****** Object:  StoredProcedure [dbo].[eliminar_Serializacion]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[eliminar_Serializacion]
@id integer
as
if EXISTS (SELECT Destino FROM Serializacion  where Destino <>'OTROS' AND ID_SERIALIZACION=@id )
RAISERROR ('Este Comprobante no se Eliminara ya que generaria Error', 16,1)
else
delete from Serializacion   where Id_serializacion   =@id and Destino='OTROS'











GO
/****** Object:  StoredProcedure [dbo].[eliminar_usuario]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[eliminar_usuario]
@idusuario as int,
@login varchar(50)

as
	   BEGIN
if EXISTS (SELECT Login   FROM USUARIO2  where @login ='admin'  )
RAISERROR ('El Usuario *Admin* es Inborrable, si se borraria Eliminarias el Acceso al Sistema de porvida, Accion Denegada', 16,1)
else
BEGIN
UPDATE USUARIO2  SET Estado ='ELIMINADO'
WHERE idUsuario =@idusuario and Login <>'admin' 
end
end








GO
/****** Object:  StoredProcedure [dbo].[eliminar_venta]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[eliminar_venta]
@idventa as integer 
as
delete from ventas where idventa=@idventa 










GO
/****** Object:  StoredProcedure [dbo].[eliminar_venta__en_cero]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[eliminar_venta__en_cero]

as
delete from ventas where Monto_total=0









GO
/****** Object:  StoredProcedure [dbo].[eliminar_venta_en_espera_todas]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[eliminar_venta_en_espera_todas]
@Id_caja int
as
delete from ventas WHERE Estado= 'EN ESPERA' and Id_caja =@Id_caja 









GO
/****** Object:  StoredProcedure [dbo].[eliminar_venta_en_historial]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[eliminar_venta_en_historial]
@Id_venta int
as
delete from ventas where  idventa=@Id_venta  AND Monto_total =0










GO
/****** Object:  StoredProcedure [dbo].[eliminar_venta_incompletas]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[eliminar_venta_incompletas]

@idCAJA int
as
delete from ventas where  Id_caja =@idCAJA and  Estado ='SIN CONFIRMAR'






GO
/****** Object:  StoredProcedure [dbo].[eliminar_venta_incompletas_en_celular_tablet]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[eliminar_venta_incompletas_en_celular_tablet]
@idmesa int
as
delete from ventas where  Id_mesa  =@idmesa and  Estado ='SIN CONFIRMAR'
GO
/****** Object:  StoredProcedure [dbo].[escalar_tamanio_mesa]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[escalar_tamanio_mesa]

@x  as int
,@y  int
as
update Propiedades_de_mesas set x=@x,y=@y







GO
/****** Object:  StoredProcedure [dbo].[insertar_Areas_De_impresion]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[insertar_Areas_De_impresion]
@Area varchar(max)
as 


insert into Areas_de_Impresion 
values ( 

@Area 
)







GO
/****** Object:  StoredProcedure [dbo].[Insertar_ASISTENCIAS]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Insertar_ASISTENCIAS]
   @Id_personal INT,
          @Fecha_entrada DATETIME,
         @Fecha_salida DATETIME,
           @Estado VARCHAR(50),
          
          @Horas VARCHAR(50)

as

insert into ASISTENCIAS values (   @Id_personal ,
          @Fecha_entrada ,
         @Fecha_salida ,
           @Estado ,
          
          @Horas)











GO
/****** Object:  StoredProcedure [dbo].[Insertar_caja]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Insertar_caja]	
	@descripcion varchar(50),
	 @Tema varchar(50),
	  @Serial_PC varchar(max),
	   @Tipo varchar(50),
	   @Ruta_para_copias_de_seguridad varchar(max),
	   @Ultima_fecha_de_copia_de_seguridad varchar(50),

@Ultima_fecha_de_copia_date datetime,
@Frecuencia_de_copias int,
@Estado_Copia_De_seguridad as varchar(50)
    as
	BEGIN
if EXISTS (SELECT  Descripcion,Serial_PC      FROM Caja    where  Descripcion=@descripcion and Serial_PC =@Serial_PC   )
RAISERROR ('Ya Existe una Caja con ese Nombre, puede ser que ya se haya creado una Caja para Esta Pc, Ingrese un nombre diferente e intente de Nuevo', 16,1)
else
BEGIN
declare @Estado as varchar(50)
set @Estado ='RECIEN CREADA'

    INSERT INTO Caja values 
	(@descripcion,@Tema ,@Serial_PC ,@Estado,@Tipo,@Ruta_para_copias_de_seguridad,
	@Ultima_fecha_de_copia_de_seguridad,
@Ultima_fecha_de_copia_date ,
@Frecuencia_de_copias ,@Estado_Copia_De_seguridad)

	end
	end









GO
/****** Object:  StoredProcedure [dbo].[insertar_categoria]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insertar_categoria]
@nombrecategoria varchar(50)
as
insert into categoria (nombrecategoria) values (@nombrecategoria)














GO
/****** Object:  StoredProcedure [dbo].[insertar_cliente]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE  procedure [dbo].[insertar_cliente]
@Nombre varchar(MAX),
           @Direccion_para_factura varchar(MAX),
            @Ruc varchar(MAX),                      
            @movil varchar(50),               
            @Cliente varchar(50),
            @Proveedor varchar(50),
			@Estado as varchar(50)
		,@Saldo numeric(18,2)
as
		   BEGIN
if EXISTS (SELECT Nombre  FROM clientes  where Nombre  = @Nombre)
RAISERROR ('YA EXISTE UN REGISTRO CON ESE NOMBRE', 16,1)
else
BEGIN
insert into clientes  values 
            (@Nombre
           ,@Direccion_para_factura
           ,@Ruc
           ,@movil     
          
           ,@Cliente
           ,@Proveedor
		   ,@Estado,
		   @Saldo
            )
			end
			end








GO
/****** Object:  StoredProcedure [dbo].[INSERTAR_CLIENTES_FACTURA_PERU]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/**********************************************************************
BASE DE DATOS		:	ERPDHMONT
NOMBRE				:	[Ventas].[USP_MANTENIMIENTO_CLIENTES_BOLETAS]
DESCRIPCION			:   Este procedure de insertar, ACTUALIZAR Y ELIMINAR datos de clientes nuevos que ingresara para
						que pueda imprimir sus boletas						
AUTOR				:	MILTON MORILLO MACHADO
FECHA DE CREACIÃƒÆ’Ã†â€™Ãƒâ€ Ã¢â‚¬â„¢ÃƒÆ’Ã¢â‚¬Â ÃƒÂ¢Ã¢â€šÂ¬Ã¢â€žÂ¢ÃƒÆ’Ã†â€™ÃƒÂ¢Ã¢â€šÂ¬Ã‚Â ÃƒÆ’Ã‚Â¢ÃƒÂ¢Ã¢â‚¬Å¡Ã‚Â¬ÃƒÂ¢Ã¢â‚¬Å¾Ã‚Â¢ÃƒÆ’Ã†â€™Ãƒâ€ Ã¢â‚¬â„¢ÃƒÆ’Ã¢â‚¬Å¡Ãƒâ€šÃ‚Â¢ÃƒÆ’Ã†â€™Ãƒâ€šÃ‚Â¢ÃƒÆ’Ã‚Â¢ÃƒÂ¢Ã¢â‚¬Å¡Ã‚Â¬Ãƒâ€¦Ã‚Â¡ÃƒÆ’Ã¢â‚¬Å¡Ãƒâ€šÃ‚Â¬ÃƒÆ’Ã†â€™ÃƒÂ¢Ã¢â€šÂ¬Ã‚Â¦ÃƒÆ’Ã‚Â¢ÃƒÂ¢Ã¢â‚¬Å¡Ã‚Â¬Ãƒâ€¦Ã¢â‚¬Å“N	:	23.05.2015
FECHA DE MODIFICACION : 
*********************************************************************
*/

CREATE PROCEDURE [dbo].[INSERTAR_CLIENTES_FACTURA_PERU]
@CLIE_CODIGO varchar(8),
@TPDC_CODIGO VARCHAR(1),
@UBDS_CODIGO VARCHAR(6),
@CLIE_NOMBRES VARCHAR(150),
@CLIE_APELLIDOPATERNO VARCHAR(100),
@CLIE_APELLIDOMATERNO VARCHAR(100),
@CLIE_NRODOCUMENTO VARCHAR(18),
@CLIE_SEXO VARCHAR(15),
@CLIE_FECHANACIMIENTO DATETIME,
@CLIE_ESTADOCIVIL VARCHAR(25),
@CLIE_DIRECCION VARCHAR(300),
@CLIE_REFERENCIA VARCHAR(300),
@CLIE_TELEFONO VARCHAR(75),
@CLIE_EMAIL VARCHAR(120),
@CLIE_OCUPACION VARCHAR(150),
@CLIE_EMPRESA VARCHAR(100),
@CLIE_ID_OBRA NUMERIC(18,0),
@TIPO INT

AS 

INSERT INTO CLIENTE_FACTURA_PERU
VALUES (@CLIE_CODIGO,@TPDC_CODIGO,0,@UBDS_CODIGO,@CLIE_NOMBRES,@CLIE_APELLIDOPATERNO,@CLIE_APELLIDOMATERNO,@CLIE_NRODOCUMENTO,@CLIE_SEXO,@CLIE_FECHANACIMIENTO,
		@CLIE_ESTADOCIVIL,@CLIE_DIRECCION,@CLIE_REFERENCIA,@CLIE_TELEFONO,@CLIE_EMAIL,@CLIE_OCUPACION,@CLIE_EMPRESA,0,0,0,@CLIE_ID_OBRA,1)









GO
/****** Object:  StoredProcedure [dbo].[insertar_Conceptos]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[insertar_Conceptos]
@Descripcion varchar(50)
as 


insert into CONCEPTOS 
values ( 

@Descripcion 
)










GO
/****** Object:  StoredProcedure [dbo].[insertar_CONEXION]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insertar_CONEXION]

@Data_source_remoto varchar(max)
as
insert into CONEXION  values (@Data_source_remoto)














GO
/****** Object:  StoredProcedure [dbo].[insertar_control_de_cobros]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE  procedure [dbo].[insertar_control_de_cobros]

         
            @monto as numeric(18,2) ,
			@Concepto varchar(MAX) ,
			 @Id_venta int    	
as

insert into CONTROL_DE_COBROS  values 
            (
        
            @monto,
			@Concepto ,
           
		    @Id_venta )









GO
/****** Object:  StoredProcedure [dbo].[insertar_correo_base]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insertar_correo_base]
@Correo varchar(max),
@Password varchar(max),
@Estado_De_envio varchar(max)
as
insert into Correo_base values (@Correo,@Password,@Estado_De_envio)










GO
/****** Object:  StoredProcedure [dbo].[insertar_DETALLE_cierre_de_caja]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[insertar_DETALLE_cierre_de_caja]	
	@fechaini datetime,
	 @fechafin datetime,
	 @fechacierre datetime, 
	  @ingresos numeric(18,2), 
    @egresos numeric(18,2),
	@saldo numeric(18,2),
	@idusuario int,
	 @totalcaluclado numeric(18,2),
	  @totalreal numeric(18,2), 
	 
	 @estado as varchar(50),
	 @diferencia as numeric(18,2)	,
	 @idcaja as int   
  AS BEGIN

if EXISTS (SELECT Estado FROM MOVIMIENTOCAJACIERRE 
 where  MOVIMIENTOCAJACIERRE.Estado='CAJA APERTURADA' and Id_caja =@idcaja)
RAISERROR ('Ya Fue Iniciado el Turno de esta Caja', 16,1)
else
BEGIN
    INSERT INTO MOVIMIENTOCAJACIERRE values 
	(@fechaini ,
	 @fechafin ,
	 @fechacierre , 
	  @ingresos , 
    @egresos ,
	@saldo ,
	@idusuario ,
	 @totalcaluclado ,
	  @totalreal , 
	
	 @estado ,
	 @diferencia ,
	 @idcaja )


	 end
	 end










GO
/****** Object:  StoredProcedure [dbo].[insertar_DETALLE_CONTROL_DE_COBROS]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE  procedure [dbo].[insertar_DETALLE_CONTROL_DE_COBROS]

@Pago_realizado as numeric(18,2),
@Fecha_que_pago as datetime,
@Tipo_de_cobro    as varchar(50) ,
@Detalle as varchar(max)  ,
@idcliente int   
  ,@Id_usuario int  ,
  @Id_caja int        	
as
update Serializacion set  numerofin=numerofin+1   where Id_tipodoc='INGRESO'
declare @comprobante as varchar(max)
set @comprobante = (select numerofin from Serializacion  where Id_tipodoc='INGRESO') 
insert into DETALLE_CONTROL_DE_COBROS  values 
            (
@Pago_realizado ,
@Fecha_que_pago ,
           @Tipo_de_cobro,
		   @Detalle ,@idcliente,@Id_usuario ,@Id_caja ,@comprobante )










GO
/****** Object:  StoredProcedure [dbo].[insertar_DETALLE_CONTROL_DE_pagos_de_proveedores]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE  procedure [dbo].[insertar_DETALLE_CONTROL_DE_pagos_de_proveedores]
@Id_control_de_cobros int,
@Pago_realizado as numeric(18,2),
@Fecha_que_pago as datetime
,
@Tipo_de_cobro    as varchar(50)              
            	
as

insert into DETALLE_DE_PAGO_A_PROVEEDORES  values 
            (@Id_control_de_cobros ,
@Pago_realizado ,
@Fecha_que_pago ,
@Tipo_de_cobro
            )










GO
/****** Object:  StoredProcedure [dbo].[insertar_detalle_venta]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insertar_detalle_venta]
@idventa as integer,
@Id_producto as int,
@cantidad as numeric(18, 2),
@preciounitario as numeric(18, 2),
@moneda as varchar(50),
@unidades as varchar(50),
@Cantidad_mostrada as numeric(18,2),
@Estado as varchar(50),
@Costo numeric(18,2),
@Estado_de_pago as varchar(50)
as

BEGIN
if EXISTS (SELECT Id_producto,idventa   FROM detalle_venta inner join Producto1 on Producto1.Id_Producto1=detalle_venta.Id_producto 
  where Producto1. Id_Producto1  = @Id_producto AND idventa=@idventa  )
 
update detalle_venta set 
cantidad    =cantidad +@cantidad  , 
Cantidad_mostrada=Cantidad_mostrada+@Cantidad_mostrada
where Id_producto =@Id_producto 

else

BEGIN
insert into detalle_venta 
values (@idventa,@Id_producto ,@cantidad,@preciounitario,@moneda,@unidades,@Cantidad_mostrada
,@Estado,@Costo,@Estado_de_pago)
END

END












GO
/****** Object:  StoredProcedure [dbo].[insertar_detalle_venta_dividida]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insertar_detalle_venta_dividida]
@idventadividido int ,
@Estado_de_pago as varchar(50)
,@iddetalleventa as int
as
update detalle_venta set idventa=@idventadividido, Estado_de_pago=@Estado_de_pago
where iddetalle_venta = @iddetalleventa






GO
/****** Object:  StoredProcedure [dbo].[insertar_Empresa]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[insertar_Empresa]

@Nombre_Empresa  varchar(50),

@logo as image,
@Impuesto varchar(50),
@Porcentaje_impuesto numeric(18,0),
@Moneda varchar(50),

@Trabajas_con_impuestos VARCHAR(50),
@Modo_de_busqueda VARCHAR(50),
@Carpeta_para_copias_de_seguridad varchar(max),
@Correo_para_envio_de_reportes varchar(50),
@Ultima_fecha_de_copia_de_seguridad varchar(50),

@Ultima_fecha_de_copia_date datetime,
@Frecuencia_de_copias int,
@Estado varchar(50),
@Tipo_de_empresa varchar(50),
@Pais varchar(max),
@Redondeo_de_total varchar(50)
as 
 BEGIN
if EXISTS (SELECT Nombre_Empresa   FROM EMPRESA   where Nombre_Empresa  = @Nombre_Empresa   )
RAISERROR ('YA EXISTE UNA EMPRESA CON ESE NOMBRE, Ingrese un nombre diferente', 16,1)
else
BEGIN
insert into EMPRESA  
values (@Nombre_Empresa,@logo,@Impuesto,@Porcentaje_impuesto,@Moneda ,@Trabajas_con_impuestos,@Modo_de_busqueda,
@Carpeta_para_copias_de_seguridad,@Correo_para_envio_de_reportes,@Ultima_fecha_de_copia_de_seguridad,
@Ultima_fecha_de_copia_date ,
@Frecuencia_de_copias ,
@Estado ,@Tipo_de_empresa,@Pais,@Redondeo_de_total)

END
END









GO
/****** Object:  StoredProcedure [dbo].[Insertar_FORMATO_TICKET]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Insertar_FORMATO_TICKET]

  
	  @Identificador_fiscal varchar(max),
           @Direccion varchar(max),
         
           @Provincia_Departamento_Pais varchar(max),
           @Nombre_de_Moneda varchar(max),
           @Agradecimiento varchar(max),
           @pagina_Web_Facebook varchar(max),
           @Anuncio varchar(max),
	   @Datos_fiscales_de_autorizacion varchar(max),
	   @Por_defecto as varchar(max)
	  
    as
	 DECLARE @Id_Empresa int  = (Select Id_empresa from EMPRESA )
    INSERT INTO Ticket values 

	(  
	@Id_Empresa ,
	  @Identificador_fiscal ,
           @Direccion,
         
           @Provincia_Departamento_Pais,
           @Nombre_de_Moneda ,
           @Agradecimiento ,
           @pagina_Web_Facebook ,
           @Anuncio,
	   @Datos_fiscales_de_autorizacion,
	   @Por_defecto )









GO
/****** Object:  StoredProcedure [dbo].[insertar_gasto_sin_comprobante]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[insertar_gasto_sin_comprobante]

@fecha datetime,
@Nro_Comprobante varchar(50),
@Tipo_de_Comprobante varchar(50),
@importe decimal(18,2),
@Descripcion varchar(500),
@Id_concepto int,
@Id_usuario int,
@TIPO VARCHAR(50),
@Id_caja int
as 

insert into GASTOSVARIOS 
values (@fecha,@Nro_Comprobante,@Tipo_de_Comprobante   , @importe,@Descripcion ,@Id_concepto,@Id_usuario,@TIPO,@Id_caja )













GO
/****** Object:  StoredProcedure [dbo].[insertar_Grupo]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[insertar_Grupo]
@Grupo varchar(50),
@Por_defecto varchar(50),
@Icono as image,
@Estado varchar(50),
@Estado_de_icono varchar(50)

as
if EXISTS (SELECT Grupo FROM Grupo_de_Productos  where Grupo = @Grupo  )
RAISERROR ('YA EXISTE UN GRUPO CON ESTE NOMBRE, Ingrese de nuevo', 16,1)
else
insert into Grupo_de_Productos  values (@Grupo, @Por_defecto, @Icono ,@Estado, @Estado_de_icono)








GO
/****** Object:  StoredProcedure [dbo].[insertar_HORARIOS]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[insertar_HORARIOS]

           @Cargo varchar(50),
     @Horas_laborales_diarias numeric(18,1)
           ,@Costo_hora_normal numeric(18,2)
           ,@Costo_hora_extra numeric(18,2)
           ,@Horas_libres_diarias numeric(18,1)
           ,@lunes int
           ,@martes int
           ,@miercoles int
           ,@jueves int
           ,@viernes int
           ,@sabado int
           ,@domingo int
		   as
insert into HORARIOS  VALUES(@Cargo ,
           @Horas_laborales_diarias
           , @Costo_hora_normal
           , @Costo_hora_extra
           , @Horas_libres_diarias
           , @lunes
           , @martes
           , @miercoles
           , @jueves
           , @viernes
           , @sabado
           , @domingo)    









GO
/****** Object:  StoredProcedure [dbo].[Insertar_Impresoras_para_pedidos]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Insertar_Impresoras_para_pedidos] 

@Impresora as varchar(max),
@idCaja int
as
declare @Id_Areas_de_Impresion int 
set @Id_Areas_de_Impresion =(Select Id_area from Areas_de_Impresion where Area = 'Impresora para Envios de Pedidos')

if exists(select Impresora  from Impresoras_por_Area where
Impresora=@Impresora and Id_Areas_de_Impresion =@Id_areas_de_impresion and
Id_caja=  @idCaja)

raiserror('Eliminar',16,1)
else
insert into Impresoras_por_Area 
values(@Id_areas_de_impresion,@Impresora,@idCaja)






GO
/****** Object:  StoredProcedure [dbo].[Insertar_Impresoras_por_Area]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Insertar_Impresoras_por_Area] 
@Id_areas_de_impresion int,
@Impresora as varchar(max),
@idCaja int
as
if exists(select Impresora  from Impresoras_por_Area where
Impresora=@Impresora and Id_Areas_de_Impresion =@Id_areas_de_impresion and
Id_caja=  @idCaja)

raiserror('Eliminar',16,1)
else
insert into Impresoras_por_Area 
values(@Id_areas_de_impresion,@Impresora,@idCaja)






GO
/****** Object:  StoredProcedure [dbo].[Insertar_ImpresorasPedidosPantalla]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Insertar_ImpresorasPedidosPantalla] 

@A_Impresora as varchar(50),
@A_seg_pantalla varchar(50),
@idCaja int
as
insert into Impresoras_por_Area 
values(@A_Impresora,@A_seg_pantalla,@idCaja)






GO
/****** Object:  StoredProcedure [dbo].[insertar_ingreso_sin_comprobante]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[insertar_ingreso_sin_comprobante]

@fecha datetime,

@observacion varchar(500),
@Nro_Comprobante varchar(50),

@Tipo_de_Comprobante varchar(50),

@importe decimal(18,2),
@estado as varchar(50),
@Id_concepto int
as 

insert into INGRESOSVARIOS (Estado,Fecha_del_Gasto ,Id_concepto,Importe, Observacion,Nro_Comprobante,Tipo_de_Comprobante)
values (@estado,@fecha,@Id_concepto   , @importe,@observacion ,@Nro_Comprobante,@Tipo_de_Comprobante)













GO
/****** Object:  StoredProcedure [dbo].[insertar_inicio_De_sesion]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  CREATE proc [dbo].[insertar_inicio_De_sesion]

 
 @Id_serial_Pc varchar(max)

  as
  declare @id_usuario_nuevo as int
  set @id_usuario_nuevo = (SELECT max(idUsuario)  FROM USUARIO2  )

insert into Inicios_de_sesion_por_caja

values (@Id_serial_Pc,@id_usuario_nuevo )









GO
/****** Object:  StoredProcedure [dbo].[insertar_KARDEX_ENTRADA]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insertar_KARDEX_ENTRADA]                
           @Fecha datetime,
		    @Motivo varchar(200),			         
         
          @Cantidad as numeric(18,0)	,
	
	  @Id_producto int	,
	   @Id_usuario as int,	
	   @Tipo as varchar(50),
	   @Estado varchar(50)	
	   
	    ,
		
	
		@Id_caja int
		  AS 
		  DECLARE @Hay AS numeric(18,2)
		 DECLARE @Habia as numeric(18,2)
		 declare @Costo_unt numeric(18,2)
SET @Hay = (SELECT Stock  FROM Producto1 WHERE Producto1.Id_Producto1   =@Id_producto and Producto1.Usa_inventarios ='SI' )
 SET @Costo_unt = (SELECT Producto1.Precio_de_compra   FROM Producto1 WHERE Producto1.Id_Producto1   =@Id_producto and Producto1.Usa_inventarios ='SI' )
		   
SET @Habia = @Hay-@Cantidad 
		   BEGIN
		   INSERT INTO KARDEX
     VALUES
		    (

        @Fecha ,
		    @Motivo ,			         
         
          @Cantidad 	,

	  @Id_producto 	,
	   @Id_usuario ,	
	   @Tipo,
			
		@Estado ,@Costo_unt, @Habia ,@Hay ,@Id_caja)


	
		END








GO
/****** Object:  StoredProcedure [dbo].[insertar_KARDEX_SALIDA]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insertar_KARDEX_SALIDA]                
           @Fecha datetime,
		    @Motivo varchar(200),			         
         
          @Cantidad as numeric(18,0)	,
	
	  @Id_producto int	,
	   @Id_usuario as int,	
	   @Tipo as varchar(50),
	   @Estado varchar(50)	
	   
	    ,
		
	
		@Id_caja int
		  AS 
		  DECLARE @Hay AS numeric(18,2)
		 DECLARE @Habia as numeric(18,2)
		 declare @Costo_unt numeric(18,2)
SET @Hay = (SELECT Stock  FROM Producto1 WHERE Producto1.Id_Producto1   =@Id_producto and Producto1.Usa_inventarios ='SI' )
 SET @Costo_unt = (SELECT Producto1.Precio_de_compra   FROM Producto1 WHERE Producto1.Id_Producto1   =@Id_producto and Producto1.Usa_inventarios ='SI' )
		   
SET @Habia = @Hay+@Cantidad 
		   BEGIN
		   INSERT INTO KARDEX
     VALUES
		    (

        @Fecha ,
		    @Motivo ,			         
         
          @Cantidad 	,

	  @Id_producto 	,
	   @Id_usuario ,	
	   @Tipo,
			
		@Estado ,@Costo_unt, @Habia ,@Hay ,@Id_caja)


	
		END








GO
/****** Object:  StoredProcedure [dbo].[Insertar_lic]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Insertar_lic]

	
	@S varchar(50),
	@F varchar(max),

	 @E varchar(50)
	,@FA DATE
    as
	
    INSERT INTO Marcan values 
	(@S ,
	@F,

	 @E,
	 @FA)








GO
/****** Object:  StoredProcedure [dbo].[insertar_linea]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[insertar_linea]
@Linea varchar(50)

as

insert into linea  values (@Linea)











GO
/****** Object:  StoredProcedure [dbo].[Insertar_marcan]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Insertar_marcan]

	
	@s varchar(MAX),
	@f varchar(MAX),
	@e varchar(MAX),
	@fa varchar(MAX)
    as
	
    INSERT INTO Marcan values 
	(@s,@f,@e ,@fa)








GO
/****** Object:  StoredProcedure [dbo].[insertar_mesa]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[insertar_mesa]
@mesa varchar(50),
@id_salon int

as
declare @Estado_de_vida varchar(50)
declare @Estado_de_Disponibilidad varchar(50)
set @Estado_de_vida='ACTIVO'
SET @Estado_de_Disponibilidad= 'LIBRE'
if EXISTS (SELECT Mesa  FROM Mesas  where Mesa  = @mesa and Mesa <>'NULO' )
RAISERROR ('YA EXISTE UNA MESA CON ESE NOMBRE, Ingrese de nuevo', 16,1)
else
insert into Mesas  values (@mesa , @id_salon ,@Estado_de_vida ,@Estado_de_Disponibilidad)







GO
/****** Object:  StoredProcedure [dbo].[insertar_mesa_estandar]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[insertar_mesa_estandar]
as
declare @mesa varchar(50)
declare @id_salon as int
declare @Estado_de_vida varchar(50)
declare @Estado_de_Disponibilidad varchar(50)
SET @mesa='Servicio Rapido'
set @id_salon = (select top 1 Id_salon  from SALON )
set @Estado_de_vida='NEUTRO369'
SET @Estado_de_Disponibilidad= 'NEUTRO369'

insert into Mesas  values (@mesa , @id_salon ,@Estado_de_vida ,@Estado_de_Disponibilidad)





GO
/****** Object:  StoredProcedure [dbo].[Insertar_modulos]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Insertar_modulos]
@Modulo as varchar(max)
as

insert into Modulos values
(@Modulo)






GO
/****** Object:  StoredProcedure [dbo].[insertar_permisos]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE  procedure [dbo].[insertar_permisos]
	@Id_modulo  int ,
	@Id_usuario int	
as
insert into Permisos 
 values (	@Id_modulo  ,
	@Id_usuario
)







GO
/****** Object:  StoredProcedure [dbo].[insertar_Producto]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insertar_Producto]   
           @Descripcion varchar(50),
		    @Imagen image,			             
          @Id_grupo as int	,     
           @Precio_de_venta numeric(18,2)    ,
		   @Estado_imagen varchar(50)                		      		      
		   AS 
		   declare @Precio_de_compra numeric(18,2)
		   declare @Stock varchar(50)
		   declare @Usa_inventarios varchar(50)
		   declare @Stock_minimo numeric(18,2) 
		   set @Precio_de_compra=0
		   set @Stock=0
		   set @Usa_inventarios='NULO'
		   SET @Stock_minimo=0
if EXISTS (SELECT Descripcion  FROM Producto1  where Descripcion = @Descripcion   )
RAISERROR ('YA EXISTE UN PRODUCTO  CON ESTE NOMBRE, POR FAVOR INGRESE DE NUEVO/ SE GENERARA CODIGO AUTOMATICO', 16,1)
		ELSE
		   INSERT INTO Producto1 
     VALUES
		    (
           @Descripcion        
           ,@Imagen         
		    ,@Id_grupo 
		,@Usa_inventarios	,
		@Stock ,
          @Precio_de_venta  ,
             
           @Stock_minimo ,
       @Precio_de_compra,
	   @Estado_imagen
		 )
		







GO
/****** Object:  StoredProcedure [dbo].[Insertar_propiedades_de_mesas]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Insertar_propiedades_de_mesas]
as
declare @x as int
declare @y as int
declare @Tamanio_letra as int
set @x = 92
set @y=77
set @Tamanio_letra=9
insert into Propiedades_de_mesas values
(@x,@y,@Tamanio_letra )






GO
/****** Object:  StoredProcedure [dbo].[insertar_Salon]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[insertar_Salon]

@Salon varchar(50),
@Estado varchar(50)
as
if EXISTS (SELECT SALON FROM SALON  where Salon = @Salon  )
RAISERROR ('YA EXISTE UN SALON CON ESTE NOMBRE, Ingrese de nuevo', 16,1)
else
insert into SALON  values (@Salon, @Estado )







GO
/****** Object:  StoredProcedure [dbo].[insertar_Serializacion]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[insertar_Serializacion]

@Serie varchar (50),
@numeroinicio as varchar (50),
@numerofin as varchar (50),
@Destino as varchar(50),
@Id_tipodoc varchar(50)
,@Por_defecto varchar(50)
as BEGIN
if EXISTS (SELECT Id_tipodoc  FROM Serializacion  where  Id_tipodoc= @Id_tipodoc )
RAISERROR ('YA EXISTE ESTE COMPROBANTE INGRESE UNO NUEVO', 16,1)
else
BEGIN
insert into Serializacion  values (@Serie ,
@numeroinicio ,
@numerofin,@Destino ,@Id_tipodoc ,@Por_defecto)

END
END








GO
/****** Object:  StoredProcedure [dbo].[insertar_tipo_de_producto]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insertar_tipo_de_producto]


@descripcion varchar(50),
@Ventas varchar(50),
@Compras varchar(50),
@Almacen varchar(50),
@Puede_tener_formulaciones varchar(50)  


as

insert into Tipos_De_productos

values (
@descripcion ,
@Ventas,
@Compras ,
@Almacen ,
@Puede_tener_formulaciones     )











GO
/****** Object:  StoredProcedure [dbo].[insertar_usuario]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[insertar_usuario]
@nombres varchar(50),


@Login varchar(50),
@Password varchar(max)
,@Icono image,
@Nombre_de_icono varchar(max)
,@Correo varchar(max),
@Rol varchar(MAX),
@Estado varchar(50)
as 
if EXISTS (SELECT Login FROM USUARIO2 where Login  = @login and Estado='ACTIVO'  )
RAISERROR ('YA EXISTE UN REGISTRO CON ESE USUARIO, POR FAVOR INGRESE DE NUEVO', 16,1)
else
insert into USUARIO2 
values (@nombres, @Login, @Password ,@Icono,@Nombre_de_icono ,@Correo, @Rol ,@Estado)









GO
/****** Object:  StoredProcedure [dbo].[insertar_venta]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insertar_venta]
@idcliente as integer,
@fecha_venta as datetime,
@nume_documento as varchar(50),
@montototal  as numeric(18,2),
@Tipo_de_pago as varchar(50),
@estado as varchar(50),
@IGV as numeric(18, 1),
@Comprobante as VARCHAR(50),
@id_usuario as int,
@Fecha_de_pago as varchar(50),
@ACCION VARCHAR(50),
@Saldo numeric(18,2),
@Pago_con numeric(18,2),
@Porcentaje_IGV numeric(18,2),
@Id_caja int,
@Referencia_tarjeta varchar(50),
@Id_mesa int,
@Numero_personas int
as 
declare @vuelto numeric(18,2)
declare @Efectivo numeric(18,2)
declare @Credito numeric(18,2)
declare @Tarjeta numeric(18,2)
declare @Donde_se_consumira varchar(50)
SET @vuelto =0
SET @Efectivo =0
SET @Credito =0
SET @Tarjeta =0
SET @Donde_se_consumira ='Consumir en Local'
insert into ventas 
values (@idcliente,@fecha_venta,@nume_documento ,@montototal ,@Tipo_de_pago,@estado ,@IGV 
,@Comprobante,@id_usuario,@Fecha_de_pago,@ACCION ,@Saldo,@Pago_con,@Porcentaje_IGV,@Id_caja,@Referencia_tarjeta,
@vuelto ,@Efectivo,@Credito,@Tarjeta,@Id_mesa ,@Numero_personas,@Donde_se_consumira)



GO
/****** Object:  StoredProcedure [dbo].[Limpiar_base_De_datos]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Limpiar_base_De_datos]
@ventas int,
@productos int,
@clientes int,
@gastos int,
@movimientos_de_caja int
as
delete from ventas   where @ventas = 1
delete from Producto1   where @productos  = 1
delete from clientes where @clientes  = 1
delete from MOVIMIENTOCAJACIERRE where @movimientos_de_caja = 1
delete from MOVIMIENTOCAJA where @movimientos_de_caja = 1
delete from GASTOSVARIOS where @gastos  = 1









GO
/****** Object:  StoredProcedure [dbo].[ListarCategorias]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ListarCategorias]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT *
	FROM Categoria
	ORDER BY nombrecategoria
END













GO
/****** Object:  StoredProcedure [dbo].[mostrar_5_productos_mas_rentables]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_5_productos_mas_rentables]
as
SELECT      TOP 5 convert(varchar(50),convert(numeric(18,0),sum(detalle_venta.Ganancia)) ),Producto1.Descripcion 
FROM            dbo.ventas inner join detalle_venta  ON detalle_venta .idventa =ventas.idventa INNER JOIN
Producto1 ON Producto1.Id_Producto1=detalle_venta.Id_producto 

                       
Group by Producto1.Descripcion  
order by convert(numeric(18,0),sum(detalle_venta.Ganancia))  desc








GO
/****** Object:  StoredProcedure [dbo].[mostrar_5_productos_mas_vendidos]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_5_productos_mas_vendidos]
as
SELECT      TOP 5 COUNT(detalle_venta.Id_producto) ,Producto1.Descripcion 
FROM            dbo.ventas inner join detalle_venta  ON detalle_venta .idventa =ventas.idventa INNER JOIN
Producto1 ON Producto1.Id_Producto1=detalle_venta.Id_producto 

                       
Group by detalle_venta.Id_producto  ,Producto1.Descripcion  









GO
/****** Object:  StoredProcedure [dbo].[mostrar_cajas]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[mostrar_cajas]
as
select * from Caja order by Id_Caja desc









GO
/****** Object:  StoredProcedure [dbo].[mostrar_cajas_por_empresa]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_cajas_por_empresa]
@empresa varchar(50),
@ip varchar(50)
as
select Caja.Id_Caja ,Caja.Descripcion
from Caja 








GO
/****** Object:  StoredProcedure [dbo].[mostrar_cajas_por_empresa_por_serial]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[mostrar_cajas_por_empresa_por_serial]



@serial varchar(50)

AS
SELECT Caja.Id_Caja ,Caja.Descripcion ,
Serial_PC from Caja
 where Caja.Serial_PC = @serial 









GO
/****** Object:  StoredProcedure [dbo].[mostrar_cajas_por_empresa_sin_ip]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_cajas_por_empresa_sin_ip]

as
select Caja.Id_Caja ,Caja.Descripcion from Caja 








GO
/****** Object:  StoredProcedure [dbo].[mostrar_cantidad_de_personas_por_venta]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[mostrar_cantidad_de_personas_por_venta]
@idventa int
as
select Numero_personas    from  ventas 
where idventa =@idventa 






GO
/****** Object:  StoredProcedure [dbo].[mostrar_cargos_sin_repetir]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[mostrar_cargos_sin_repetir]

AS BEGIN
SET NOCOUNT ON;
SELECT DISTINCT  
      Cargo,Id_horarios
FROM           HORARIOS 
                       
end










GO
/****** Object:  StoredProcedure [dbo].[mostrar_categoria]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_categoria]
as
select * from categoria order by idcategoria desc














GO
/****** Object:  StoredProcedure [dbo].[MOSTRAR_CIERRE_DE_CAJA_PENDIENTE]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[MOSTRAR_CIERRE_DE_CAJA_PENDIENTE]

@serial varchar(50)

AS
SELECT MOVIMIENTOCAJACIERRE.fechainicio,MOVIMIENTOCAJACIERRE.fechafin,caja.Id_Caja  FROM MOVIMIENTOCAJACIERRE inner join USUARIO2 on USUARIO2.idUsuario=MOVIMIENTOCAJACIERRE.Id_usuario
 inner join Caja on Caja.Id_Caja =MOVIMIENTOCAJACIERRE.Id_caja 
 where Caja.Serial_PC = @serial    AND MOVIMIENTOCAJACIERRE.Estado='CAJA APERTURADA' 








GO
/****** Object:  StoredProcedure [dbo].[mostrar_cliente]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[mostrar_cliente]
as
SELECT        idclientev, Nombre, Direccion_para_factura as Direccion, Ruc,  movil as Celular, Cliente, Proveedor, 
                    clientes.Saldo ,     Estado as Activo
FROM            dbo.clientes 
WHERE clientes.Cliente='SI' order by Nombre  asc 










GO
/****** Object:  StoredProcedure [dbo].[mostrar_COBROS]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[mostrar_COBROS]

as 
SELECT       * from ventas 
WHERE Estado ='DEUDA'









GO
/****** Object:  StoredProcedure [dbo].[MOSTRAR_CONCEPTOS_EN_GASTOS_VARIOS]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[MOSTRAR_CONCEPTOS_EN_GASTOS_VARIOS]
AS
SELECT        dbo.CONCEPTOS.Id_concepto, dbo.CONCEPTOS.Descripcion AS Concepto 
                      
FROM            dbo.CONCEPTOS 
						
						








GO
/****** Object:  StoredProcedure [dbo].[mostrar_cuentas]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_cuentas]
@idmesa as integer
as
select ventas.*, USUARIO2.Nombre_y_Apelllidos , Mesas.Mesa ,ventas.Id_mesa
from ventas 
inner join clientes on clientes.idclientev=ventas.idclientev 
inner join Mesas on Mesas.Id_mesa=ventas.Id_mesa 
inner join USUARIO2 on USUARIO2.idUsuario= ventas.Id_usuario 
where   ventas.Estado<>'TERMINADO' and ventas.Id_mesa =@idmesa





GO
/****** Object:  StoredProcedure [dbo].[mostrar_cuentas_soloMesas]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_cuentas_soloMesas]
as
select distinct Mesas.Mesa, Mesas.Id_mesa 
from ventas 
inner join clientes on clientes.idclientev=ventas.idclientev 
inner join Mesas on Mesas.Id_mesa=ventas.Id_mesa 
inner join USUARIO2 on USUARIO2.idUsuario= ventas.Id_usuario 
where   ventas.Estado<>'TERMINADO'





GO
/****** Object:  StoredProcedure [dbo].[mostrar_cuentas_soloVentas]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_cuentas_soloVentas]
as
select ventas.*, USUARIO2.Nombre_y_Apelllidos , Mesas.Mesa ,ventas.Id_mesa 
from ventas 
inner join clientes on clientes.idclientev=ventas.idclientev 
inner join Mesas on Mesas.Id_mesa=ventas.Id_mesa 
inner join USUARIO2 on USUARIO2.idUsuario= ventas.Id_usuario 
where   ventas.Estado<>'TERMINADO'





GO
/****** Object:  StoredProcedure [dbo].[mostrar_descripcion_producto_sin_repetir_REST]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[mostrar_descripcion_producto_sin_repetir_REST]

@buscar varchar(50)
as begin
select Descripcion  from Producto1  Where Descripcion  LIKE  '%' + @buscar +'%'
end











GO
/****** Object:  StoredProcedure [dbo].[MOSTRAR_DESPACHOS_DE_MERCADERIAS_PENDIENTES]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[MOSTRAR_DESPACHOS_DE_MERCADERIAS_PENDIENTES]
AS
select * from detalle_venta where Estado='DESPACHO PENDIENTE'









GO
/****** Object:  StoredProcedure [dbo].[mostrar_DETALLE_CONTROL_DE_COBROS]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[mostrar_DETALLE_CONTROL_DE_COBROS]
@id int
as
SELECT  Id_detalle_de_control_de_cobros ,Pago_realizado as [Importe],Tipo_de_cobro as [Tipo], Fecha_que_pago as Fecha  from DETALLE_CONTROL_DE_COBROS 

where Id_cliente=@id








GO
/****** Object:  StoredProcedure [dbo].[mostrar_DETALLE_CONTROL_DE_PAGOS]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[mostrar_DETALLE_CONTROL_DE_PAGOS]
@id int
as
SELECT  Id_detalle_de_control_de_cobros ,Pago_realizado as [Importe],Tipo_de_cobro as [Tipo], Fecha_que_pago as Fecha  from DETALLE_CONTROL_DE_COBROS 

where Id_cliente=@id and DETALLE_CONTROL_DE_COBROS.Detalle ='PAGO'








GO
/****** Object:  StoredProcedure [dbo].[mostrar_detalle_de_cobro_para_Imprimir]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[mostrar_detalle_de_cobro_para_Imprimir]
@Id_detalle_de_control_de_cobros int,
@pagado_en_letras  varchar(max)
as 
SELECT       (EMPRESA.Moneda + convert(varchar(50),Pago_realizado)) as Pago_realizado ,Fecha_que_pago,Detalle
,clientes.Nombre as Cliente, clientes.movil ,(EMPRESA.Moneda + convert(varchar(50),clientes.Saldo)) as Saldo ,
USUARIO2.Nombre_y_Apelllidos  as Usuario, (EMPRESA.Moneda + convert(varchar(50), (Pago_realizado+Saldo ))) as total
 ,@pagado_en_letras as Pagado_letras,clientes.Direccion_para_factura ,
 EMPRESA.Nombre_Empresa ,EMPRESA.Logo ,DETALLE_CONTROL_DE_COBROS.Comprobante
 from DETALLE_CONTROL_DE_COBROS  
inner join clientes on clientes.idclientev=DETALLE_CONTROL_DE_COBROS.Id_cliente 
inner join USUARIO2 on USUARIO2.idUsuario=DETALLE_CONTROL_DE_COBROS.Id_usuario 
cross join EMPRESA 

where DETALLE_CONTROL_DE_COBROS.Id_detalle_de_control_de_cobros =@Id_detalle_de_control_de_cobros 










GO
/****** Object:  StoredProcedure [dbo].[mostrar_Empresa]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_Empresa]
as
select LOGO, Nombre_Empresa as Empresa ,(Impuesto + ' ('+  CONVERT(VARCHAR(50),Porcentaje_impuesto) + ')') Impuesto ,Moneda  ,Id_empresa  
,Porcentaje_impuesto  ,Impuesto ,Modo_de_busqueda ,Trabajas_con_impuestos ,Trabajas_con_impuestos,Correo_para_envio_de_reportes,
Carpeta_para_copias_de_seguridad, Redondeo_de_total  ,Moneda
from Empresa








GO
/****** Object:  StoredProcedure [dbo].[mostrar_Empresa_igv]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_Empresa_igv]
@empresa as varchar(50)
as
select Porcentaje_impuesto , 'IGV'+' ('+CONVERT(VARCHAR(50),Porcentaje_impuesto)+'%)' as IGV FROM EMPRESA

WHERE Nombre_Empresa=@empresa 












GO
/****** Object:  StoredProcedure [dbo].[mostrar_envios_de_pedidos]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[mostrar_envios_de_pedidos]
@Id_caja int
as
SELECT        dbo.ImpresorasPedidos.A_Impresora, dbo.ImpresorasPedidos.A_seg_pantalla, dbo.ImpresorasPedidos.Id_caja
FROM            dbo.Caja INNER JOIN
                         dbo.ImpresorasPedidos ON dbo.Caja.Id_Caja = dbo.ImpresorasPedidos.Id_caja
where Caja .Id_Caja =@Id_caja 






GO
/****** Object:  StoredProcedure [dbo].[mostrar_estado_de_mesa]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[mostrar_estado_de_mesa]
@idmesa int
as
select Estado_de_Disponibilidad  from Mesas 
where Mesas.Id_mesa=@idmesa 







GO
/****** Object:  StoredProcedure [dbo].[mostrar_estado_de_venta_por_id]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[mostrar_estado_de_venta_por_id]
@idventa int
as
select Estado   from  ventas 
where idventa =@idventa 







GO
/****** Object:  StoredProcedure [dbo].[MOSTRAR_FONDO_DE_CAJA_INICIAL]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[MOSTRAR_FONDO_DE_CAJA_INICIAL]
@id_caja int,
@fi as DATEtime,
@ff as DATEtime
AS
SELECT MOVIMIENTOCAJACIERRE.Saldo_queda_en_caja  FROM MOVIMIENTOCAJACIERRE inner join USUARIO2 on USUARIO2.idUsuario=MOVIMIENTOCAJACIERRE.Id_usuario
  inner join Caja on Caja.Id_Caja =MOVIMIENTOCAJACIERRE.Id_caja 
 where Caja.Id_Caja  = @id_caja    AND MOVIMIENTOCAJACIERRE.Estado='CAJA APERTURADA'  









GO
/****** Object:  StoredProcedure [dbo].[Mostrar_formato_ticket]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Mostrar_formato_ticket]
as
select EMPRESA.Logo,Empresa.Nombre_Empresa ,Ticket.*  from Ticket 
INNER JOIN EMPRESA ON EMPRESA.Id_empresa=Ticket.Id_Empresa 








GO
/****** Object:  StoredProcedure [dbo].[mostrar_Formato_ticket_con_datos_de_detalleventa]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE proc [dbo].[mostrar_Formato_ticket_con_datos_de_detalleventa]
@Subtotal as varchar(50),
@Total varchar (50),
@Descuento varchar(50),
@Son varchar(50),
@Impuesto varchar(50),
@Monto_impuesto varchar(50),
@Numero_comprobante as varchar(50),
@Cliente varchar(50),
@Cajero varchar(50)
as
Select *,@Subtotal as Subtotal,@Total as total,@Descuento as descuento,@Son as son , @Impuesto as impuesto
,@Monto_impuesto as monto_impuesto,@Numero_comprobante as numero_comprobante,@Cliente as cliente,@Cajero as cajero  from Ticket 









GO
/****** Object:  StoredProcedure [dbo].[MOSTRAR_GANANCIAS_DE_VENTAS]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[MOSTRAR_GANANCIAS_DE_VENTAS]
as
select CONVERT(NUMERIC(18,1),SUM(Ganancia ) ) from detalle_venta  INNER JOIN VENTAS ON detalle_venta.idventa =ventas.idventa 










GO
/****** Object:  StoredProcedure [dbo].[MOSTRAR_Ganancias_por_fecha]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[MOSTRAR_Ganancias_por_fecha]
@FI AS DATE,
@FF AS DATE
as
select CONVERT(NUMERIC(18,1),sum( Ganancia )) 
FROM            dbo.detalle_venta  inner join ventas on ventas.idventa=detalle_venta.idventa 
WHERE convert(date,ventas.fecha_venta)>= @FI    AND   convert(date,ventas.fecha_venta)<= @FF 
                       








GO
/****** Object:  StoredProcedure [dbo].[mostrar_gastos]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[mostrar_gastos]
as
SELECT        dbo.CONCEPTOS.Descripcion AS Concepto, dbo.GASTOSVARIOS.Idgasto, dbo.GASTOSVARIOS.Fecha_del_Gasto, 
                         dbo.GASTOSVARIOS.Tipo_de_Comprobante + ' '+dbo.GASTOSVARIOS.Nro_Comprobante AS Comprobante, dbo.GASTOSVARIOS.Importe, 
						 dbo.GASTOSVARIOS.Descripcion  as Detalle, 
                         dbo.GASTOSVARIOS.Id_concepto,USUARIO2.Nombre_y_Apelllidos as Usuario
,GASTOSVARIOS.Nro_Comprobante ,GASTOSVARIOS.Tipo_de_Comprobante 
FROM            dbo.CONCEPTOS INNER JOIN
                         dbo.GASTOSVARIOS ON dbo.CONCEPTOS.Id_concepto = dbo.GASTOSVARIOS.Id_concepto inner join USUARIO2 
						 on USUARIO2.idUsuario=GASTOSVARIOS.Id_usuario 
 where GASTOSVARIOS.TIPO='SALIDA'
 order by Fecha_del_Gasto   desc








GO
/****** Object:  StoredProcedure [dbo].[mostrar_gastos_por_anio_en_comboboxAnio]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[mostrar_gastos_por_anio_en_comboboxAnio]

AS BEGIN
SET NOCOUNT ON;
SELECT DISTINCT  
      DATEPART (year,Fecha_del_Gasto) as anio
FROM           GASTOSVARIOS 
WHERE GASTOSVARIOS.TIPO ='SALIDA' 
end









GO
/****** Object:  StoredProcedure [dbo].[mostrar_gastos_por_MES_en_comboboxMES]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[mostrar_gastos_por_MES_en_comboboxMES]
@anio int
AS BEGIN
SET NOCOUNT ON;
SELECT DISTINCT  
      datename(month,Fecha_del_Gasto) as mes
FROM           GASTOSVARIOS 
WHERE GASTOSVARIOS.TIPO ='SALIDA'  and DATEPART (year,Fecha_del_Gasto) =@anio
end









GO
/****** Object:  StoredProcedure [dbo].[mostrar_gastos_por_usuario]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[mostrar_gastos_por_usuario]
@idusuario int,
@fecha date
as
select*from GASTOSVARIOS 
where Id_usuario=@idusuario and convert(date,Fecha_del_Gasto) =@fecha 









GO
/****** Object:  StoredProcedure [dbo].[mostrar_HORARIOS]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[mostrar_HORARIOS]
as
SELECT        *FROM HORARIOS








GO
/****** Object:  StoredProcedure [dbo].[mostrar_horas_dia]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[mostrar_horas_dia]
@idpersonal int,
@fecha_sistema date
AS 

SELECT       sum(Horas ) as  Horas
FROM            dbo.ASISTENCIAS 						 
WHEre Id_personal=@idpersonal and (convert(date,Fecha_salida )=@fecha_sistema or convert(date,Fecha_entrada  )=@fecha_sistema)










GO
/****** Object:  StoredProcedure [dbo].[mostrar_id_caja_por_serial]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_id_caja_por_serial]
@Serial as varchar(max)
as
select Caja.Id_Caja 
from Caja 
where caja.Serial_PC =@Serial






GO
/****** Object:  StoredProcedure [dbo].[mostrar_Id_cajas_por_Serial]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[mostrar_Id_cajas_por_Serial]
@Serial as varchar(MAX)
as
select Id_Caja 
from Caja 
where Serial_PC =@Serial







GO
/****** Object:  StoredProcedure [dbo].[mostrar_id_por_area]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_id_por_area]
@Area as varchar(max)
as
select Id_area 
from Areas_de_Impresion 
where Area = @Area 






GO
/****** Object:  StoredProcedure [dbo].[mostrar_id_salon_recien_ingresado]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[mostrar_id_salon_recien_ingresado]
@Salon as varchar(50)
AS
select Id_salon from SALON
where Salon= @Salon






GO
/****** Object:  StoredProcedure [dbo].[mostrar_id_venta_dividida]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_id_venta_dividida]
@Id_mesa int
as
select MAX(idventa) from ventas
where  ventas.Id_mesa=@Id_mesa and Estado='EN ESPERA'





GO
/****** Object:  StoredProcedure [dbo].[mostrar_id_venta_existente]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_id_venta_existente]
@Id_mesa int
as
select (idventa) from ventas
inner join Mesas on Mesas.Id_mesa=ventas.Id_mesa 
inner join Caja on Caja.Id_Caja=ventas.Id_caja 
where   ventas.Id_mesa=@Id_mesa and ventas.Estado<>'TERMINADO' order by ventas.idventa desc 





GO
/****** Object:  StoredProcedure [dbo].[mostrar_id_venta_por_mesa]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[mostrar_id_venta_por_mesa]
@idmesa int
as
select Estado_de_Disponibilidad  from Mesas inner join ventas on ventas.Id_mesa=Mesas.Id_mesa 
where ventas .Id_mesa=@idmesa







GO
/****** Object:  StoredProcedure [dbo].[mostrar_id_venta_por_mesa_DESTINO]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[mostrar_id_venta_por_mesa_DESTINO]
@idmesa int
as
select MAX (ventas.idventa)   from Mesas inner join ventas on ventas.Id_mesa=Mesas.Id_mesa 
where ventas .Id_mesa=@idmesa 







GO
/****** Object:  StoredProcedure [dbo].[mostrar_id_venta_por_mesa_ORIGEN]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[mostrar_id_venta_por_mesa_ORIGEN]
@idmesa int
as
select MAX (ventas.idventa)   from Mesas inner join ventas on ventas.Id_mesa=Mesas.Id_mesa 
where ventas .Id_mesa=@idmesa 







GO
/****** Object:  StoredProcedure [dbo].[mostrar_id_venta_Srapido]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_id_venta_Srapido]
@Id_mesa int,
@Serialpc as varchar(max)
as
select  (idventa) from ventas
inner join Mesas on Mesas.Id_mesa=ventas.Id_mesa 
inner join Caja on Caja.Id_Caja=ventas.Id_caja 
where Caja.Serial_PC =@Serialpc and  ventas.Id_mesa=@Id_mesa and ventas.Estado='SIN CONFIRMAR'





GO
/****** Object:  StoredProcedure [dbo].[mostrar_impresoras_agregadas_por_area]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_impresoras_agregadas_por_area]
@idarea int,
@idcaja int
as
select Impresoras_por_Area.Id_impresora ,Impresoras_por_Area.Impresora, Impresoras_por_Area.Id_Areas_de_Impresion  
 from Impresoras_por_Area 
where Impresoras_por_Area .Id_Areas_de_Impresion =@idarea and
Id_caja = @idcaja






GO
/****** Object:  StoredProcedure [dbo].[mostrar_impresoras_para_pedidos]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[mostrar_impresoras_para_pedidos]
@idcaja int
as
declare @Id_Areas_de_Impresion int 
set @Id_Areas_de_Impresion =(Select Id_area from Areas_de_Impresion where Area = 'Impresora para Envios de Pedidos')
select Impresoras_por_Area.Id_impresora ,Impresoras_por_Area.Impresora, Impresoras_por_Area.Id_Areas_de_Impresion  
 from Impresoras_por_Area 
where Impresoras_por_Area .Id_Areas_de_Impresion =@Id_Areas_de_Impresion and
Id_caja = @idcaja






GO
/****** Object:  StoredProcedure [dbo].[mostrar_ingresos]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[mostrar_ingresos]
as
SELECT       dbo.GASTOSVARIOS.Descripcion  as Detalle, dbo.GASTOSVARIOS.Idgasto, dbo.GASTOSVARIOS.Fecha_del_Gasto, 
                         dbo.GASTOSVARIOS.Tipo_de_Comprobante + ' '+dbo.GASTOSVARIOS.Nro_Comprobante AS Comprobante, dbo.GASTOSVARIOS.Importe, 
						  
                         dbo.GASTOSVARIOS.Id_concepto,USUARIO2.Nombre_y_Apelllidos as Usuario
,GASTOSVARIOS.Nro_Comprobante ,GASTOSVARIOS.Tipo_de_Comprobante,GASTOSVARIOS.Tipo_de_Comprobante
FROM           
                         dbo.GASTOSVARIOS  inner join USUARIO2 
						 on USUARIO2.idUsuario=GASTOSVARIOS.Id_usuario 
 where GASTOSVARIOS.TIPO='INGRESO'
 order by Fecha_del_Gasto   desc








GO
/****** Object:  StoredProcedure [dbo].[mostrar_inicio_De_sesion]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_inicio_De_sesion]
  @id_serial_pc as varchar(max)
  as
select Inicios_de_sesion_por_caja .Id_usuario,USUARIO2.Nombre_y_Apelllidos    from Inicios_de_sesion_por_caja 
inner join USUARIO2 on USUARIO2.idUsuario = Inicios_de_sesion_por_caja.Id_usuario 
where Id_serial_Pc =@id_serial_pc 






GO
/****** Object:  StoredProcedure [dbo].[MOSTRAR_Inventarios_bajo_minimo_COUNT]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[MOSTRAR_Inventarios_bajo_minimo_COUNT]
AS
select  count(Id_Producto1 ) from Producto1 
				where Stock <= Stock_minimo 	and Usa_inventarios ='SI'








GO
/****** Object:  StoredProcedure [dbo].[mostrar_lineas]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[mostrar_lineas]
as
select * from linea order by Idline desc 










GO
/****** Object:  StoredProcedure [dbo].[mostrar_mayores_GASTOS_POR_CONCEPTO_por_anio]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_mayores_GASTOS_POR_CONCEPTO_por_anio]
@anio as integer
as

SELECT    top 5 CONCEPTOS.Descripcion  , convert(varchar(50),SUM(Importe))    FROM GASTOSVARIOS INNER JOIN CONCEPTOS ON CONCEPTOS.Id_concepto =GASTOSVARIOS.Id_concepto 
WHERE GASTOSVARIOS.TIPO ='SALIDA' and DATEPART (year,Fecha_del_Gasto) =@anio
GROUP BY CONCEPTOS.Descripcion 
Order by SUM(Importe) desc








GO
/****** Object:  StoredProcedure [dbo].[mostrar_mayores_GASTOS_POR_CONCEPTO_por_mes_de_anio]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_mayores_GASTOS_POR_CONCEPTO_por_mes_de_anio]
@mes as varchar(50),
@anio as integer
as

SELECT    top 5 CONCEPTOS.Descripcion  , convert(varchar(50),SUM(Importe))    FROM GASTOSVARIOS INNER JOIN CONCEPTOS ON CONCEPTOS.Id_concepto =GASTOSVARIOS.Id_concepto 
WHERE GASTOSVARIOS.TIPO ='SALIDA' and datename(month,Fecha_del_Gasto) =@mes and DATEPART (year,Fecha_del_Gasto) =@anio
GROUP BY CONCEPTOS.Descripcion 
Order by SUM(Importe) desc








GO
/****** Object:  StoredProcedure [dbo].[mostrar_mesas_por_salon]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[mostrar_mesas_por_salon]
@id_salon  int
as
select *, Propiedades_de_mesas.x, Propiedades_de_mesas.y,
Tamanio_letra from Mesas cross join Propiedades_de_mesas
inner join SALON on SALON.Id_salon= Mesas.Id_salon
where Mesas.Id_salon=@id_salon and Estado_de_vida<>'NEUTRO369'



GO
/****** Object:  StoredProcedure [dbo].[mostrar_mesas_por_salon_en_celular_tablet]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[mostrar_mesas_por_salon_en_celular_tablet]
@id_salon  int
as
select *, Propiedades_de_mesas.x, Propiedades_de_mesas.y,
Tamanio_letra from Mesas cross join Propiedades_de_mesas
inner join SALON on SALON.Id_salon= Mesas.Id_salon
where Mesas.Id_salon=@id_salon and Estado_de_vida<>'NEUTRO369' AND Mesas.Mesa <>'NULO'
GO
/****** Object:  StoredProcedure [dbo].[mostrar_minutos_transcurridos_por_pedido]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[mostrar_minutos_transcurridos_por_pedido]
@idventa as integer
as
SELECT    
			convert(varchar(50),  DATEDIFF( minute ,ventas.fecha_venta ,getdate() ))+' min' as Minutos_transcurridos
FROM            dbo.detalle_venta INNER JOIN
                         dbo.ventas ON dbo.detalle_venta.idventa = dbo.ventas.idventa 
						 inner join Producto1 on detalle_venta.Id_producto=Producto1.Id_Producto1 
						

						 where detalle_venta.idventa  =@idventa AND detalle_venta .Estado <>'DESPACHADO'






GO
/****** Object:  StoredProcedure [dbo].[mostrar_MOTIVOS_sin_repetir]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[mostrar_MOTIVOS_sin_repetir]
@letrab VARCHAR(50)
AS BEGIN
SET NOCOUNT ON;
SELECT DISTINCT  
      Motivo 
FROM           KARDEX  
 where  (Motivo) LIKE  '%' + @letrab+'%'     AND Tipo = 'ENTRADA'             
end










GO
/****** Object:  StoredProcedure [dbo].[MOSTRAR_MOVIMIENTOS_DE_CAJA_POR_SERIAL]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[MOSTRAR_MOVIMIENTOS_DE_CAJA_POR_SERIAL]

@serial varchar(50)

AS
SELECT USUARIO2.Login,USUARIO2.Nombre_y_Apelllidos    FROM MOVIMIENTOCAJACIERRE inner join USUARIO2 on USUARIO2.idUsuario=MOVIMIENTOCAJACIERRE.Id_usuario
 inner join Caja on Caja.Id_Caja =MOVIMIENTOCAJACIERRE.Id_caja 
 where Caja.Serial_PC = @serial    AND MOVIMIENTOCAJACIERRE.Estado='CAJA APERTURADA' 










GO
/****** Object:  StoredProcedure [dbo].[MOSTRAR_MOVIMIENTOS_DE_CAJA_POR_SERIAL_y_usuario]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[MOSTRAR_MOVIMIENTOS_DE_CAJA_POR_SERIAL_y_usuario]

@serial varchar(50),
@idusuario int

AS
SELECT USUARIO2.Login,USUARIO2.Nombre_y_Apelllidos    FROM MOVIMIENTOCAJACIERRE inner join USUARIO2 on USUARIO2.idUsuario=MOVIMIENTOCAJACIERRE.Id_usuario
 inner join Caja on Caja.Id_Caja =MOVIMIENTOCAJACIERRE.Id_caja 
 where Caja.Serial_PC = @serial    AND MOVIMIENTOCAJACIERRE.Estado='CAJA APERTURADA' and MOVIMIENTOCAJACIERRE.Id_usuario =@idusuario and USUARIO2.Estado ='ACTIVO'









GO
/****** Object:  StoredProcedure [dbo].[mostrar_mozo_por_mesa]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_mozo_por_mesa]
as
select USUARIO2.Login, Mesas.Mesa    from ventas inner join USUARIO2 on
USUARIO2.idUsuario=ventas.Id_usuario 
inner join Mesas on Mesas.Id_mesa =ventas.Id_mesa 
where Mesas.Estado_de_Disponibilidad ='OCUPADO' and ventas.Estado <>'TERMINADO'





GO
/****** Object:  StoredProcedure [dbo].[mostrar_pedido_por_mesa]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_pedido_por_mesa]
@idventa as int
,@Id_mesa int
as
SELECT      ( Producto1 .Descripcion ) as Producto, dbo.detalle_venta.Cantidad_mostrada as Cant, 
                          dbo.ventas.Estado , USUARIO2.Nombre_y_Apelllidos as Mozo , Mesas.Mesa  
					
						
						  
FROM            dbo.detalle_venta INNER JOIN
                         dbo.ventas ON dbo.detalle_venta.idventa = dbo.ventas.idventa 
						 inner join Producto1 on detalle_venta.Id_producto=Producto1.Id_Producto1
						 inner join USUARIO2 on USUARIO2.idUsuario = ventas.Id_usuario  
						 inner join Mesas on Mesas.Id_mesa = ventas.Id_mesa 
where dbo.detalle_venta .idventa =@idventa AND detalle_venta.cantidad >0 and ventas.Id_mesa = @Id_mesa order by detalle_venta.iddetalle_venta desc







GO
/****** Object:  StoredProcedure [dbo].[mostrar_permisos]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[mostrar_permisos]
@idusuario int
as
SELECT        dbo.permisos.Id_modulo 
FROM            dbo.USUARIO2 INNER JOIN
                         dbo.permisos ON dbo.USUARIO2.idUsuario = dbo.permisos.Id_Usuario
						 where dbo.USUARIO2.idUsuario =@idusuario 






GO
/****** Object:  StoredProcedure [dbo].[mostrar_permisos_por_usuario]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_permisos_por_usuario]
@LOGIN VARCHAR(50)
as 
select Rol 
from USUARIO2 
where USUARIO2.LOGIN =@LOGIN 








GO
/****** Object:  StoredProcedure [dbo].[mostrar_permisos_por_usuario_ROL_UNICO]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_permisos_por_usuario_ROL_UNICO]
@LOGIN VARCHAR(50)
as 
select 
USUARIO2.Rol 
from USUARIO2 
where USUARIO2.LOGIN =@LOGIN and USUARIO2.Estado ='ACTIVO'








GO
/****** Object:  StoredProcedure [dbo].[mostrar_pre_cuenta]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_pre_cuenta]
@idventa as int,
@idmesa as int

as
SELECT      Producto1.Descripcion  as Producto, dbo.detalle_venta.cantidad  as Cant, 
                         dbo.detalle_venta.preciounitario as Importe,
						 (EMPRESA.Moneda + convert(varchar(50),convert(numeric(18,2), Sum( detalle_venta.Total_a_pagar))))   as Total
						 ,EMPRESA.Nombre_Empresa as Empresa, ventas.fecha_venta as fecha, USUARIO2.Nombre_y_Apelllidos as Usuario 
FROM            dbo.detalle_venta INNER JOIN
                         dbo.ventas ON dbo.detalle_venta.idventa = dbo.ventas.idventa inner join usuario2 on Usuario2.idUsuario=ventas.Id_usuario 
						 INNER JOIN Producto1  ON Producto1.Id_Producto1  =detalle_venta .Id_producto  
						  cross join Empresa											
		where dbo.ventas  .idventa =@idventa and ventas.Id_mesa =@idmesa 		


	 group by Producto1.Descripcion  , dbo.detalle_venta.cantidad , 
                         dbo.detalle_venta.preciounitario , EMPRESA.Moneda 
						 ,EMPRESA.Nombre_Empresa , ventas.fecha_venta, USUARIO2.Nombre_y_Apelllidos 
GO
/****** Object:  StoredProcedure [dbo].[mostrar_pre_cuenta_dividido]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[mostrar_pre_cuenta_dividido]
@idventa  as int,
@Total as varchar(50)
as
SELECT      Producto1.Descripcion  as Producto, dbo.detalle_venta.cantidad  as Cant, 
                         dbo.detalle_venta.preciounitario as Importe, (EMPRESA.Moneda +' ' + @Total+ ' dividido de '+ EMPRESA.Moneda+' '+ convert(varchar(50), convert(numeric(18,2), Sum( detalle_venta.Total_a_pagar))) )   as Total
						 ,EMPRESA.Nombre_Empresa as Empresa, ventas.fecha_venta as fecha, USUARIO2.Nombre_y_Apelllidos as Usuario 
FROM            dbo.detalle_venta INNER JOIN
                         dbo.ventas ON dbo.detalle_venta.idventa = dbo.ventas.idventa inner join usuario2 on Usuario2.idUsuario=ventas.Id_usuario 
						 INNER JOIN Producto1  ON Producto1.Id_Producto1  =detalle_venta .Id_producto  
						  cross join Empresa
						 cross join Ticket
					
		where dbo.ventas  .idventa =@idventa 			


	 group by Producto1.Descripcion  , dbo.detalle_venta.cantidad , 
                         dbo.detalle_venta.preciounitario , EMPRESA.Moneda 
						 ,EMPRESA.Nombre_Empresa , ventas.fecha_venta, USUARIO2.Nombre_y_Apelllidos 









GO
/****** Object:  StoredProcedure [dbo].[mostrar_Producto1]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_Producto1]
@id_grupo int
as

select *from Producto1 INNER JOIN Grupo_de_Productos on
Grupo_de_Productos.Idline=Producto1.Id_grupo

where Id_grupo=@id_grupo 







GO
/****** Object:  StoredProcedure [dbo].[mostrar_productos_agregados_a_venta]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_productos_agregados_a_venta]
@idventa as int
,@Id_mesa int
as
SELECT      Producto1 .Id_Producto1  ,( Producto1 .Descripcion ) as Producto, dbo.detalle_venta.Cantidad_mostrada as Cant, 
                         dbo.detalle_venta.preciounitario as P_Unit ,convert(numeric(18,2),dbo.detalle_venta.Total_a_pagar) as Importe ,DBO.detalle_venta.iddetalle_venta ,dbo.ventas.Estado 
						 ,dbo.detalle_venta.cantidad ,ventas.idclientev 
						   ,detalle_venta.idventa
						  
FROM            dbo.detalle_venta INNER JOIN
                         dbo.ventas ON dbo.detalle_venta.idventa = dbo.ventas.idventa 
						 inner join Producto1 on detalle_venta.Id_producto=Producto1.Id_Producto1 
where dbo.detalle_venta .idventa =@idventa AND detalle_venta.cantidad >0 and ventas.Id_mesa = @Id_mesa
and detalle_venta.Estado_de_pago ='DEBE'
order by detalle_venta.iddetalle_venta desc

GO
/****** Object:  StoredProcedure [dbo].[mostrar_productos_EN_ESPERA_COCINA]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_productos_EN_ESPERA_COCINA]
@idventa as integer
as
SELECT     Mesas.Mesa , USUARIO2.Nombre_y_Apelllidos as Mozo, Producto1 .Descripcion  as Producto, 
detalle_venta.Cantidad_mostrada as Cant, 
                         detalle_venta.iddetalle_venta ,dbo.detalle_venta .Estado 
						 ,dbo.detalle_venta.cantidad 
						   ,detalle_venta.idventa, ventas.Id_mesa , ROW_NUMBER() OVER(ORDER BY detalle_venta.iddetalle_venta ASC) as Orden
						  ,'('+RIGHT( CONVERT(DATETIME, ventas.fecha_venta, 108),8) + ')' as Hora,
						convert(varchar(50),  DATEDIFF( minute ,ventas.fecha_venta ,getdate() ))+' min' as Minutos_transcurridos
						, ventas.Donde_se_consumira
FROM           detalle_venta INNER JOIN
                         dbo.ventas ON dbo.detalle_venta.idventa = dbo.ventas.idventa 
						 inner join Producto1 on detalle_venta.Id_producto=Producto1.Id_Producto1 
						 inner join Mesas on Mesas .Id_mesa= ventas.Id_mesa 
						 inner join USUARIO2 on USUARIO2.idUsuario= ventas.Id_usuario 

						 where detalle_venta.idventa  =@idventa AND detalle_venta .Estado <>'DESPACHADO'





GO
/****** Object:  StoredProcedure [dbo].[MOSTRAR_PRODUCTOS_NUEVOS]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[MOSTRAR_PRODUCTOS_NUEVOS]
@DESCRIPCION as VARCHAR(MAX)
as

select Id_Producto1 FROM Producto1 
WHERE Descripcion  = @DESCRIPCION








GO
/****** Object:  StoredProcedure [dbo].[mostrar_productos_para_ventas]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_productos_para_ventas]
as
SELECT        (dbo.Producto1.Descripcion +' '+dbo.Presentaciones.Presentacion+ ' x'+dbo.Presentaciones.Cantidad_por_presentacion+ dbo.Presentaciones.Unidad_de_medida) as Descripcion,dbo.Producto1.Id_Producto1 ,
                       
                        dbo.Producto1.Imagen ,Presentaciones_fraccionadas.Id_presentacionfraccionada 
                  
FROM            
                         dbo.Producto1 INNER JOIN
                         dbo.Presentaciones_fraccionadas ON dbo.Producto1.Id_Producto1 = dbo.Presentaciones_fraccionadas.Id_producto INNER JOIN
                         dbo.Presentaciones ON dbo.Presentaciones_fraccionadas.Id_presentacion = dbo.Presentaciones.Id_Presentacion










GO
/****** Object:  StoredProcedure [dbo].[mostrar_productos_por_cuenta]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_productos_por_cuenta]
@idventa as int
,@Id_mesa int
as
SELECT      Producto1 .Id_Producto1  ,( Producto1 .Descripcion ) as Producto, dbo.detalle_venta.Cantidad_mostrada as Cant, 
                         dbo.detalle_venta.preciounitario as P_Unit ,convert(numeric(18,2),dbo.detalle_venta.Total_a_pagar) as Importe ,DBO.detalle_venta.iddetalle_venta ,dbo.ventas.Estado 
						 ,dbo.detalle_venta.cantidad ,ventas.idclientev 
						   ,detalle_venta.idventa
						  
FROM            dbo.detalle_venta INNER JOIN
                         dbo.ventas ON dbo.detalle_venta.idventa = dbo.ventas.idventa 
						 inner join Producto1 on detalle_venta.Id_producto=Producto1.Id_Producto1 
						 inner join Mesas on Mesas.Id_mesa=ventas.Id_mesa  
where dbo.detalle_venta .idventa =@idventa AND detalle_venta.cantidad >0 and ventas.Id_mesa = @Id_mesa
and detalle_venta.Estado_de_pago ='DEBE' OR ( ventas .Estado ='TERMINADO_EN_ESPERA' and dbo.detalle_venta .idventa =@idventa and ventas.Id_mesa = @Id_mesa)
order by detalle_venta.iddetalle_venta desc







GO
/****** Object:  StoredProcedure [dbo].[mostrar_Productos_por_grupo]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_Productos_por_grupo]
@id_grupo int
as

select *from Producto1 INNER JOIN Grupo_de_Productos on
Grupo_de_Productos.Idline=Producto1.Id_grupo

where Producto1.Id_grupo =@id_grupo 


select * from Grupo_de_Productos 
SELECT * FROM ventas





GO
/****** Object:  StoredProcedure [dbo].[mostrar_PROVEEEDOR]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[mostrar_PROVEEEDOR]
as
SELECT        idclientev, Nombre, Direccion_para_factura as Direccion, Ruc, movil as Celular, Cliente, Proveedor, 
                    clientes.Saldo ,     Estado as Activo
FROM            dbo.clientes 
WHERE clientes.Proveedor ='SI' order by Nombre  asc 










GO
/****** Object:  StoredProcedure [dbo].[mostrar_recibo_digital_cobros]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[mostrar_recibo_digital_cobros]
@idcliente int,
@idcaja int
as
select *from DETALLE_CONTROL_DE_COBROS inner join clientes on clientes.idclientev=DETALLE_CONTROL_DE_COBROS.Id_cliente 

where DETALLE_CONTROL_DE_COBROS.Id_cliente=@idcliente








GO
/****** Object:  StoredProcedure [dbo].[mostrar_SALON]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[mostrar_SALON]

@buscar varchar(50)
as begin
select *  from SALON  Where SALON  LIKE  '%' + @buscar +'%'
end








GO
/****** Object:  StoredProcedure [dbo].[mostrar_solo_saldo_cliente_proveedor]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[mostrar_solo_saldo_cliente_proveedor]
@id int
as
SELECT  Saldo  from clientes  
where idclientev =@id








GO
/****** Object:  StoredProcedure [dbo].[mostrar_tema_por_caja]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_tema_por_caja]
@Serial as varchar(max)
as
select Caja.Tema 
from Caja 

where caja.Serial_PC =@Serial






GO
/****** Object:  StoredProcedure [dbo].[mostrar_ticket_impreso]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_ticket_impreso]
@idventa as int,
@total_en_letras as varchar(50)


as
declare @cantidad_de_productos as int
set @cantidad_de_productos = (select SUM(detalle_venta.cantidad) from detalle_venta inner join ventas ON dbo.detalle_venta.idventa = dbo.ventas.idventa
 where detalle_venta.idventa=@idventa)
SELECT      (Producto1.Descripcion ) as Producto, dbo.detalle_venta.Cantidad_mostrada as Cant, 
                         dbo.detalle_venta.preciounitario as P_Unit ,convert(numeric(18,2),dbo.detalle_venta.Total_a_pagar) as Importe, detalle_venta .Id_producto  ,DBO.detalle_venta.iddetalle_venta ,dbo.ventas.Estado 
						  ,dbo.detalle_venta.cantidad ,ventas.idclientev 
						  ,ventas.idventa,Empresa.Nombre_Empresa as Empresa
,Empresa.Logo,Ticket.Identificador_fiscal,Ticket.Direccion,Ticket.Provincia_Departamento_Pais,Ticket.Nombre_de_Moneda,
Ticket.Agradecimiento,Ticket.pagina_Web_Facebook,Ticket.Anuncio,ventas.Numero_de_doc ,ventas.fecha_venta as fecha
,Empresa.Impuesto +'('+ convert(varchar(50),EMPRESA.Porcentaje_impuesto) +'%):' as Impuesto
,convert(numeric (18,2),(ventas.Monto_total*ventas.Porcentaje_IGV)/100 )as TotalImpuesto,
ventas.Monto_total ,USUARIO2.Nombre_y_Apelllidos as Usuario,
ventas.Pago_con   , ventas.Vuelto ,EMPRESA.Moneda ,clientes.Nombre ,ticket.Datos_fiscales_de_autorizacion
,ventas.Tipo_de_pago,@cantidad_de_productos as Cantidad_de_productos,@total_en_letras AS total_en_letras,ventas.Comprobante
,convert(numeric (18,2),(ventas.Monto_total-( ventas.Monto_total*ventas.Porcentaje_IGV)/100) ) as SubTotal
FROM            dbo.detalle_venta INNER JOIN
                         dbo.ventas ON dbo.detalle_venta.idventa = dbo.ventas.idventa inner join usuario2 on Usuario2.idUsuario=ventas.Id_usuario 
						 INNER JOIN clientes ON clientes.idclientev =ventas.idclientev 
						  cross join Empresa
						 cross join Ticket
						 inner join Producto1 on Producto1.Id_Producto1 =detalle_venta.Id_producto 
where dbo.detalle_venta .idventa =@idventa  And ventas.Monto_total >0 order by detalle_venta.iddetalle_venta desc











GO
/****** Object:  StoredProcedure [dbo].[mostrar_ticket_impreso_dividido]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_ticket_impreso_dividido]
@idventa as int,
@total_en_letras as varchar(50)


as
declare @cantidad_de_productos as int
set @cantidad_de_productos = (select SUM(detalle_venta.cantidad) from detalle_venta inner join ventas ON dbo.detalle_venta.idventa = dbo.ventas.idventa
 where detalle_venta.idventa=@idventa)
SELECT      (Producto1.Descripcion ) as Producto, dbo.detalle_venta.Cantidad_mostrada as Cant, 
                         dbo.detalle_venta.preciounitario as P_Unit ,convert(numeric(18,2),dbo.detalle_venta.Total_a_pagar) as Importe, detalle_venta .Id_producto  ,DBO.detalle_venta.iddetalle_venta ,dbo.ventas.Estado 
						  ,dbo.detalle_venta.cantidad ,ventas.idclientev 
						  ,ventas.idventa,Empresa.Nombre_Empresa as Empresa
,Empresa.Logo,Ticket.Identificador_fiscal,Ticket.Direccion,Ticket.Provincia_Departamento_Pais,Ticket.Nombre_de_Moneda,
Ticket.Agradecimiento,Ticket.pagina_Web_Facebook,Ticket.Anuncio,ventas.Numero_de_doc ,ventas.fecha_venta as fecha
,Empresa.Impuesto +'('+ convert(varchar(50),EMPRESA.Porcentaje_impuesto) +'%):' as Impuesto
,convert(numeric (18,2),((ventas.Efectivo +ventas.Credito+ventas.Tarjeta)*ventas.Porcentaje_IGV)/100 )as TotalImpuesto,
(ventas.Efectivo +ventas.Credito+ventas.Tarjeta) as Monto_total ,USUARIO2.Nombre_y_Apelllidos as Usuario,
ventas.Pago_con   , ventas.Vuelto ,EMPRESA.Moneda ,clientes.Nombre ,ticket.Datos_fiscales_de_autorizacion
,ventas.Tipo_de_pago,@cantidad_de_productos as Cantidad_de_productos,@total_en_letras AS total_en_letras,ventas.Comprobante
,convert(numeric (18,2),((ventas.Efectivo +ventas.Credito+ventas.Tarjeta)-( (ventas.Efectivo +ventas.Credito+ventas.Tarjeta)*ventas.Porcentaje_IGV)/100) ) as SubTotal
FROM            dbo.detalle_venta INNER JOIN
                         dbo.ventas ON dbo.detalle_venta.idventa = dbo.ventas.idventa inner join usuario2 on Usuario2.idUsuario=ventas.Id_usuario 
						 INNER JOIN clientes ON clientes.idclientev =ventas.idclientev 
						  cross join Empresa
						 cross join Ticket
						 inner join Producto1 on Producto1.Id_Producto1 =detalle_venta.Id_producto 
where detalle_venta.Estado_de_pago ='IMPRESO' AND dbo.detalle_venta .idventa =@idventa  And ventas.Monto_total >0 order by detalle_venta.iddetalle_venta desc 











GO
/****** Object:  StoredProcedure [dbo].[mostrar_tipo_de_caja_por_serial]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_tipo_de_caja_por_serial]
@Serial as varchar(max)
as
select Caja.Tipo  
from Caja 
where caja.Serial_PC =@Serial






GO
/****** Object:  StoredProcedure [dbo].[mostrar_Tipo_de_documentos_para_insertar_estos_mismos]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_Tipo_de_documentos_para_insertar_estos_mismos]
as

SELECT       dbo.Serializacion.Serie ,dbo.Serializacion.Cantidad_de_numeros , dbo.Serializacion.numerofin ,dbo.Serializacion.Id_serializacion ,(dbo.Serializacion.Serie  +' - '+ dbo.Serializacion.Cantidad_de_numeros + dbo.Serializacion.numerofin) as serie_completa,Serializacion.Id_tipodoc AS COMPROBANTE
,Por_defecto 
FROM            dbo.Serializacion where destino='VENTAS'








GO
/****** Object:  StoredProcedure [dbo].[mostrar_todos_los_productos]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[mostrar_todos_los_productos]
AS 
select Producto1.*,EMPRESA .* from Producto1 cross join EMPRESA 








GO
/****** Object:  StoredProcedure [dbo].[mostrar_ultima_venta]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_ultima_venta]
@idcaja int
as
select top 1 Monto_total,((Porcentaje_IGV*Monto_total )/100) as Impuesto , Vuelto ,(Monto_total - (Monto_total *Porcentaje_IGV )/100)
,Pago_con 
from ventas
where Monto_total >0 and Id_caja  =@idcaja 
order by idventa Desc 





GO
/****** Object:  StoredProcedure [dbo].[mostrar_ultimo_efectivo]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[mostrar_ultimo_efectivo]
@idventa int
as
select Efectivo  
from ventas
where idventa =@idventa





GO
/****** Object:  StoredProcedure [dbo].[mostrar_ultimo_efectivo_vuelto]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_ultimo_efectivo_vuelto]
@idcaja int
as
select top 1 (EMPRESA.Moneda +' ' + CONVERT (varchar(50), Pago_con )) as Efectivo ,(EMPRESA.Moneda +' ' + CONVERT (varchar(50),Vuelto )) as Vuelto
from ventas
cross join EMPRESA 
where Id_caja =@idcaja and Monto_total >0 order by Numero_de_doc   desc





GO
/****** Object:  StoredProcedure [dbo].[mostrar_ultimo_total]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[mostrar_ultimo_total]
@idventa int
as
select Monto_total 
from ventas
where idventa =@idventa





GO
/****** Object:  StoredProcedure [dbo].[mostrar_usuario_POR_ID]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_usuario_POR_ID]
@ID INT
as 
select *
from USUARIO2 inner join Permisos on Permisos. Id_Usuario=USUARIO2.idUsuario

WHERE USUARIO2.idUsuario=@ID 
order by USUARIO2.idUsuario desc











GO
/****** Object:  StoredProcedure [dbo].[mostrar_usuario_POR_login]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_usuario_POR_login]
@login varchar(50)
as 
select Icono 
from USUARIO2
WHERE USUARIO2.login =@login AND ESTADO='ACTIVO'









GO
/****** Object:  StoredProcedure [dbo].[mostrar_USUARIO_por_nombre_contrasenia]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[mostrar_USUARIO_por_nombre_contrasenia]
@letra VARCHAR(50),
@pas varchar(50)
AS BEGIN
SELECT        idUsuario, Login ,Password ,Nombre_y_Apelllidos 
FROM            dbo.USUARIO2						 
WHEre Login =@letra  AND Password=@pas
END









GO
/****** Object:  StoredProcedure [dbo].[mostrar_vendedores]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_vendedores]
as 
select * from USUARIO2














GO
/****** Object:  StoredProcedure [dbo].[mostrar_ventas_en_espera]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_ventas_en_espera]


AS BEGIN
SET NOCOUNT ON;
SELECT DISTINCT  
(detalle_venta.idventa )
FROM         dbo.detalle_venta
             inner join ventas  on ventas .idventa =detalle_venta.idventa 
          where  
 ventas.Estado='EN ESPERA'
 group by detalle_venta.idventa             
end








GO
/****** Object:  StoredProcedure [dbo].[mostrar_ventas_en_espera_Anuncio]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[mostrar_ventas_en_espera_Anuncio]

as
SELECT      count(ventas.idventa ) 
FROM            dbo.ventas
             inner join detalle_venta on detalle_venta.idventa =ventas.idventa 
where  
 ventas.Estado='EN ESPERA'or  ventas.Estado='SIN CONFIRMAR'








GO
/****** Object:  StoredProcedure [dbo].[mostrar_ventas_en_espera_con_fecha_y_monto]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_ventas_en_espera_con_fecha_y_monto]

		AS   

SELECT    ventas. idventa,ventas.Comprobante,ventas.fecha_venta
FROM            dbo.detalle_venta INNER JOIN
                         dbo.ventas ON dbo.detalle_venta.idventa = dbo.ventas.idventa    
					
where  (ventas.Estado='EN ESPERA') 
	 GROUP BY     ventas. idventa,ventas.Comprobante,ventas.fecha_venta 












GO
/****** Object:  StoredProcedure [dbo].[mostrar_ventas_en_espera_solo_para_vendedores]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[mostrar_ventas_en_espera_solo_para_vendedores]
@id_caja int

as
SELECT      count(ventas.idventa ) as id_ventas, count(ventas.idventa ) as id_producto
FROM            dbo.ventas inner join Caja  on caja.Id_Caja=ventas.Id_caja 
             
where  
 ventas.Estado='EN ESPERA'or  ventas.Estado='SIN CONFIRMAR' and ventas.Id_caja =@id_caja 

 union 
 SELECT      count(ventas.idventa  ) as id_ventas,count(ventas.idventa ) as id_producto
FROM            dbo.ventas inner join detalle_venta on detalle_venta.idventa =detalle_venta.idventa  
             inner join Caja  on caja.Id_Caja=ventas.Id_caja
where  
 ventas.Estado='EN ESPERA'or  ventas.Estado='SIN CONFIRMAR' and ventas.Id_caja =@id_caja








GO
/****** Object:  StoredProcedure [dbo].[mostrar_ventas_realizadas]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_ventas_realizadas]
as
SELECT       (datename(month,fecha_venta) + ' ' +DateName(year,fecha_venta))as fecha,convert(varchar(50),sum( Monto_total))  as Total

FROM            dbo.ventas 
       where ACCION= 'VENTA'           
group by datename(month,fecha_venta),DateName(year,fecha_venta)








GO
/****** Object:  StoredProcedure [dbo].[mostrar_ventas_realizadas_CANTIDADES]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_ventas_realizadas_CANTIDADES]
as
SELECT        convert(varchar(50),convert(date,fecha_venta)) as fecha,COUNT(ventas.idventa ) 
FROM            dbo.ventas 
                       
group by convert(date,fecha_venta)








GO
/****** Object:  StoredProcedure [dbo].[mostrar_ventas_realizadas_POR_FECHA]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_ventas_realizadas_POR_FECHA]
@FI AS DATE,
@FF AS DATE
as
select CONVERT(NUMERIC(18,1),sum( Monto_total  )) 
FROM            dbo.ventas   
 WHERE convert(date,fecha_venta)>= @FI    AND   convert(date,fecha_venta)<= @FF 









GO
/****** Object:  StoredProcedure [dbo].[mostrar_ventas_realizadas_POR_FECHAS]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_ventas_realizadas_POR_FECHAS]
@FI AS DATE,
@FF AS DATE
as
SELECT        datename(MONTH ,convert(date,fecha_venta)) +' '+ convert(varchar(50),datepart(year ,convert(date,fecha_venta)))  as fecha,convert(varchar(50),sum( Monto_total) ) 
FROM            dbo.ventas 
     WHERE convert(date,fecha_venta)>= @FI    AND   convert(date,fecha_venta)<= @FF            
group by convert(date,fecha_venta)









GO
/****** Object:  StoredProcedure [dbo].[mostras_ventaspormeses]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostras_ventaspormeses]

as
select month(dbo.ventas.fecha_venta )as mes , sum(dbo.ventas.Monto_total) as importe
from dbo.ventas 
where month(dbo.ventas.fecha_venta)  BETWEEN 0 AND 12 GROUP BY MONTH(dbo.ventas.fecha_venta ) 













GO
/****** Object:  StoredProcedure [dbo].[NOTIFICADOR_COBROS]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[NOTIFICADOR_COBROS]

as 
SELECT       Saldo ,Nombre 
FROM          
                         dbo.clientes 
						 WHERE Saldo >0 AND Cliente ='SI'








GO
/****** Object:  StoredProcedure [dbo].[NOTIFICADOR_PAGOS]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[NOTIFICADOR_PAGOS]

as 
SELECT       Saldo ,Nombre 
FROM          
                         dbo.clientes 
						 WHERE Saldo >0 AND Proveedor  ='SI'








GO
/****** Object:  StoredProcedure [dbo].[Obtener_id_usuario]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Obtener_id_usuario]
@Login as varchar(50)
as
select idUsuario  from USUARIO2 where Login =@Login  






GO
/****** Object:  StoredProcedure [dbo].[Paginar_grupos]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Paginar_grupos]
@Desde INT,
@Hasta INT

AS
BEGIN
SET NOCOUNT ON;
SELECT
Idline,
Grupo,
Icono,
Estado_de_icono
FROM
(SELECT
Idline ,
Grupo ,
Icono ,
Estado_de_icono,
ROW_NUMBER() OVER (ORDER BY Idline) 'Numero_de_fila'
FROM
Grupo_de_Productos

) AS Paginado
WHERE
(Paginado.Numero_de_fila >= @Desde)AND (Paginado.Numero_de_fila<= @Hasta )
END







GO
/****** Object:  StoredProcedure [dbo].[paginar_Productos_por_grupo]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[paginar_Productos_por_grupo]
@Desde INT,
@Hasta INT,
@id_grupo int
AS
BEGIN
SET NOCOUNT ON;
SELECT
Id_Producto1,
Descripcion,
Imagen,
Precio_de_venta,
Estado_imagen,
Id_grupo
FROM
(SELECT
Id_Producto1,
Descripcion,
Imagen,
Precio_de_venta,
Estado_imagen,
Producto1 .Id_grupo  ,
ROW_NUMBER() OVER (ORDER BY Idline) 'Numero_de_fila'
FROM
Producto1 INNER JOIN Grupo_de_Productos on
Grupo_de_Productos.Idline=Producto1.Id_grupo

) AS Paginado
WHERE
(Paginado.Numero_de_fila >= @Desde)AND (Paginado.Numero_de_fila<= @Hasta ) and Paginado.Id_grupo  =@id_grupo
END







GO
/****** Object:  StoredProcedure [dbo].[Poner_nombre_a_venta_en_espera]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Poner_nombre_a_venta_en_espera]
@id_venta int,
@nombre as varchar(50)
as
update ventas   set Comprobante=@nombre, Estado = 'EN ESPERA' where idventa   =@id_venta 








GO
/****** Object:  StoredProcedure [dbo].[probar_impresora]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[probar_impresora]

as
declare @Producto as varchar(50)
declare @Cant as varchar(50)
declare @Mozo as varchar(50)
declare @Mesa as varchar(50)

set @Producto='Producto Prueba'
set @Cant='1'
set @Mozo='Mozo Prueba'
set @Mesa='Mesa Prueba'
SELECT      
		@Producto as Producto,	@Cant as Cant	,@Mozo as Mozo 	,@Mesa	 as Mesa
						  
FROM            dbo.EMPRESA  






GO
/****** Object:  StoredProcedure [dbo].[PRUEBA_DE_NOTIFIC]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create proc [dbo].[PRUEBA_DE_NOTIFIC]
 AS
 select COUNT (iddetalle_venta  )as idprod from detalle_venta 








GO
/****** Object:  StoredProcedure [dbo].[REPORT_CIERRE_DE_CAJA_diaria_por_TURNOS]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[REPORT_CIERRE_DE_CAJA_diaria_por_TURNOS]
@id_caja AS INT,
@fi as DATE,
@ff as DATEtime
as

select SUM(Monto_total)  from ventas 
where Tipo_de_pago ='EFECTIVO' AND 
(fecha_venta >=@fi and fecha_venta<=@ff )AND Id_caja=@id_caja








GO
/****** Object:  StoredProcedure [dbo].[REPORT_COBROS_EN_EFECTIVO_por_turnos]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[REPORT_COBROS_EN_EFECTIVO_por_turnos]
@id_caja AS INT,
@fi as DATEtime,
@ff as DATETIME
as

select SUM(Pago_realizado )  from DETALLE_CONTROL_DE_COBROS     where  
(Fecha_que_pago >=@fi AND Fecha_que_pago<=@ff )AND Id_caja=@id_caja AND Tipo_de_cobro ='EFECTIVO' and DETALLE_CONTROL_DE_COBROS.Detalle ='COBRO'










GO
/****** Object:  StoredProcedure [dbo].[REPORT_GANANCIAS_DE_VENTAS_por_TURNOS]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[REPORT_GANANCIAS_DE_VENTAS_por_TURNOS]
@id_caja AS INT,
@fi as DATEtime,
@ff as DATEtime
as

select SUM(Ganancia )  from detalle_venta  INNER JOIN VENTAS ON detalle_venta.idventa =ventas.idventa 
where
(ventas.fecha_venta  >=@fi and ventas.fecha_venta<=@ff )AND VENTAS.Id_caja=@id_caja AND ventas.Estado <> 'OTRAS CUENTAS'









GO
/****** Object:  StoredProcedure [dbo].[REPORT_GASTOS_VARIOS]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[REPORT_GASTOS_VARIOS]
@id_caja AS INT,
@fi as DATE,
@ff as DATE
as

select SUM(Importe)  from GASTOSVARIOS INNER JOIN CONCEPTOS ON CONCEPTOS.Id_concepto =GASTOSVARIOS.Id_concepto   where  
(Fecha_del_Gasto >=@fi OR Fecha_del_Gasto<=@ff )AND Id_caja=@id_caja AND TIPO='SALIDA'










GO
/****** Object:  StoredProcedure [dbo].[REPORT_GASTOS_VARIOS_por_turnos]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[REPORT_GASTOS_VARIOS_por_turnos]
@id_caja AS INT,
@fi as DATEtime,
@ff as DATEtime
as

select SUM(Importe)  from GASTOSVARIOS INNER JOIN CONCEPTOS ON CONCEPTOS.Id_concepto =GASTOSVARIOS.Id_concepto   where  
(Fecha_del_Gasto >=@fi AND Fecha_del_Gasto<=@ff )AND Id_caja=@id_caja AND TIPO='SALIDA'










GO
/****** Object:  StoredProcedure [dbo].[REPORT_INGRESOS_VARIOS_por_turnos]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[REPORT_INGRESOS_VARIOS_por_turnos]
@id_caja AS INT,
@fi as DATEtime,
@ff as DATEtime
as

select SUM(Importe)  from GASTOSVARIOS   where  
(Fecha_del_Gasto >=@fi AND Fecha_del_Gasto<=@ff )AND Id_caja=@id_caja AND GASTOSVARIOS . TIPO='INGRESO'










GO
/****** Object:  StoredProcedure [dbo].[REPORT_PAGOS_EN_EFECTIVO_por_turnos]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[REPORT_PAGOS_EN_EFECTIVO_por_turnos]
@id_caja AS INT,
@fi as DATEtime,
@ff as DATETIME
as
select SUM(Pago_realizado )  from DETALLE_CONTROL_DE_COBROS     where  
(Fecha_que_pago >=@fi AND Fecha_que_pago<=@ff )AND Id_caja=@id_caja AND Tipo_de_cobro ='EFECTIVO' and Detalle ='PAGO'









GO
/****** Object:  StoredProcedure [dbo].[REPORT_VENTAS_POR_PERIODOS_EN_GENERAL_DE_KARDEX]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[REPORT_VENTAS_POR_PERIODOS_EN_GENERAL_DE_KARDEX]
@fecha_inicial as date,
@fecha_final as date
as

SELECT       convert(date,KARDEX.Fecha) ,KARDEX.Total ,KARDEX.Motivo 
					,@fecha_inicial,@fecha_final
FROM            dbo.KARDEX 

						 where 
						Cast(dbo.KARDEX   .Fecha    As Date) >=@fecha_inicial 
				AND Cast(dbo.KARDEX   .Fecha   As Date) <= @fecha_final 
						 
						 AND (KARDEX.Motivo ='DESPACHO DIARIO DE VENDEDORES...'
						 or KARDEX.Motivo ='RECHAZO DIARIO')and (KARDEX.Total >0 or KARDEX.Total  <0)















GO
/****** Object:  StoredProcedure [dbo].[REPORT_VENTAS_por_TURNOS_en_EFECTIVO]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[REPORT_VENTAS_por_TURNOS_en_EFECTIVO]
@id_caja AS INT,
@fi as DATEtime,
@ff as DATEtime
as

select SUM(Monto_total)  from ventas 
where Tipo_de_pago ='EFECTIVO' AND 
(fecha_venta >=@fi and fecha_venta<=@ff )AND Id_caja=@id_caja









GO
/****** Object:  StoredProcedure [dbo].[REPORT_VENTAS_por_TURNOS_Por_Credito]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[REPORT_VENTAS_por_TURNOS_Por_Credito]
@id_caja AS INT,
@fi as DATEtime,
@ff as DATEtime
as

select SUM(Monto_total)  from ventas 
where Tipo_de_pago ='CREDITO' AND 
(fecha_venta >=@fi and fecha_venta<=@ff )AND Id_caja=@id_caja and ventas.Estado <> 'OTRAS CUENTAS'









GO
/****** Object:  StoredProcedure [dbo].[REPORT_VENTAS_por_TURNOS_Por_tarjeta]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[REPORT_VENTAS_por_TURNOS_Por_tarjeta]
@id_caja AS INT,
@fi as DATEtime,
@ff as DATEtime
as

select SUM(Monto_total)  from ventas 
where Tipo_de_pago ='TARJETA' AND 
(fecha_venta >=@fi and fecha_venta<=@ff )AND Id_caja=@id_caja









GO
/****** Object:  StoredProcedure [dbo].[REPORT_VENTAS_POR_VENDEDOR_VENTAS_AL_CONTADO]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[REPORT_VENTAS_POR_VENDEDOR_VENTAS_AL_CONTADO]
@fecha_inicial as date,
@fecha_final as date,
@Id_usuario int
as
SELECT      sum(dbo.ventas.Monto_total)AS VENTAS_TOTAL_CONTADO 
                         					 
FROM            dbo.ventas INNER JOIN
                         
                         dbo.USUARIO2 ON dbo.ventas.Id_usuario = dbo.USUARIO2.idUsuario
					
						  where dbo.USUARIO2.idUsuario =@Id_usuario  and Cast(dbo.ventas .fecha_venta   As Date) >=@fecha_inicial AND Cast(dbo.ventas .fecha_venta   As Date) <= @fecha_final AND Tipo_de_pago  ='CONTADO'

						  group by dbo.ventas.Monto_total









GO
/****** Object:  StoredProcedure [dbo].[reporte_cierre_de_caja]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[reporte_cierre_de_caja]


@ventastotales as varchar(50)
,@ganancia as varchar(50)
,@fondo as varchar(50)
, @ventasefectivo as varchar(50)
, @pagosefectivo as varchar(50)
, @cobrosefectivo as varchar(50)
, @ingresosvarios as varchar(50)
, @gastosvarios as varchar(50)
, @esperado as varchar(50)
,@Vefectivo as varchar(50)
,@Vtarjeta as varchar(50)
,@Vcredito as varchar(50)
, @TOTALventas as varchar(50)
, @cajero  as varchar(50)
, @fechas  as varchar(max)
, @caja  as varchar(max)
as
select empresa.Moneda +' '+ @ventastotales as ventastotales ,empresa.Moneda +' '+@ganancia as ganancia,empresa.Moneda +' '+@fondo as fondo,empresa.Moneda +' '+@ventasefectivo as ventasefectivo,empresa.Moneda +' '+@pagosefectivo as pagosefectivo ,empresa.Moneda +' '+@cobrosefectivo as cobrosefectivo,empresa.Moneda +' '+@ingresosvarios as ingresosvarios,empresa.Moneda +' '+@gastosvarios as gastosvarios
,empresa.Moneda +' '+@esperado AS esperado ,empresa.Moneda +' '+@esperado AS esperado,empresa.Moneda +' '+@Vefectivo AS Vefectivo,empresa.Moneda +' '+@Vtarjeta AS Vtarjeta,empresa.Moneda +' '+@Vcredito AS Vcredito,empresa.Moneda +' '+@TOTALventas AS TOTALventas,@cajero AS cajero,@fechas AS fechas,@caja AS caja
,EMPRESA.Nombre_Empresa , EMPRESA.Logo 
from Caja
cross join EMPRESA 
 where Caja.Descripcion =@caja  








GO
/****** Object:  StoredProcedure [dbo].[REPORTEcierredecajaGASTOSVARIOS]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[REPORTEcierredecajaGASTOSVARIOS]
 @fechaini DATE,
 @fechafin DATE
 as
select month(dbo.GASTOSVARIOS.Fecha_del_Gasto ) as Mes, year(dbo.GASTOSVARIOS.Fecha_del_Gasto) as anio,
  sum(dbo.GASTOSVARIOS.Importe  ) as Egresos_Gastos_varios

 from dbo.GASTOSVARIOS 
 where     Fecha_del_Gasto >= @fechaini AND   Fecha_del_Gasto <= @fechafin  GROUP BY MONTH(dbo.GASTOSVARIOS.Fecha_del_Gasto  ), YEAR(dbo.GASTOSVARIOS.Fecha_del_Gasto ) ORDER BY YEAR(dbo.GASTOSVARIOS.Fecha_del_Gasto ) asc









GO
/****** Object:  StoredProcedure [dbo].[REPORTEcierredecajaGASTOSVARIOS_diario]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[REPORTEcierredecajaGASTOSVARIOS_diario]
 @fechaini DATE
 as
select month(dbo.GASTOSVARIOS.Fecha_del_Gasto ) as Mes, year(dbo.GASTOSVARIOS.Fecha_del_Gasto) as anio,
  sum(dbo.GASTOSVARIOS.Importe  ) as Egresos_Gastos_varios, day(dbo.GASTOSVARIOS.Fecha_del_Gasto) as dia

 from dbo.GASTOSVARIOS 
 where     Fecha_del_Gasto = @fechaini   GROUP BY MONTH(dbo.GASTOSVARIOS.Fecha_del_Gasto  ), day(dbo.GASTOSVARIOS.Fecha_del_Gasto),YEAR(dbo.GASTOSVARIOS.Fecha_del_Gasto ) ORDER BY YEAR(dbo.GASTOSVARIOS.Fecha_del_Gasto ) asc










GO
/****** Object:  StoredProcedure [dbo].[REPORTEcierredecajaVENTAS]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[REPORTEcierredecajaVENTAS]
 @fechaini DATE,
 @fechafin DATE
 as
 --LEFT( CONVERT( VARCHAR, d.fecha, 112 ),6)+'01' as fechaVenta
 select month(dbo.ventas.fecha_venta) as Mes, year(dbo.ventas.fecha_venta) as anio,
  sum(dbo.ventas.Monto_total) as Ingreso_de_Ventas

 from dbo.ventas
 where      fecha_venta >= @fechaini AND    fecha_venta <= @fechafin and Estado='PAGADO' GROUP BY MONTH(dbo.ventas.fecha_venta ), YEAR(dbo.ventas.fecha_venta ) ORDER BY YEAR(dbo.ventas.fecha_venta ) asc










GO
/****** Object:  StoredProcedure [dbo].[restar_saldo_a_cliente_por_eliminacion]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[restar_saldo_a_cliente_por_eliminacion]
@idventa int,
@montototal as numeric(18,1)


as

update CONTROL_DE_COBROS set Monto  =Monto - @montototal
where Id_venta =@idventa 










GO
/****** Object:  StoredProcedure [dbo].[restar_total_venta_por_eliminacion]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[restar_total_venta_por_eliminacion]
@idventa int,
@montototal as numeric(18,2)


as

update ventas set Monto_total  =Monto_total - @montototal
where idventa =@idventa 










GO
/****** Object:  StoredProcedure [dbo].[restaurar_cliente]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[restaurar_cliente]
@idcliente integer
as
update  clientes set  Estado ='ACTIVO'
where idclientev=@idcliente AND Estado='ELIMINADO' 








GO
/****** Object:  StoredProcedure [dbo].[restaurar_salon]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[restaurar_salon]


@id_salon as int
as

update SALON  set Estado='ACTIVO' 
where Id_salon =@id_salon 







GO
/****** Object:  StoredProcedure [dbo].[restaurar_usuario]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[restaurar_usuario]
@idusuario as int,
@login varchar(50)

as
	 
UPDATE USUARIO2  SET Estado ='ACTIVO'
WHERE idUsuario =@idusuario and Login <>'admin' 








GO
/****** Object:  StoredProcedure [dbo].[sumar_COBROS]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sumar_COBROS]
@FI as date,
@FF as date
as
select sum(dbo.DETALLE_CONTROL_DE_COBROS  .Pago_realizado   )
from dbo.DETALLE_CONTROL_DE_COBROS 
 where DETALLE_CONTROL_DE_COBROS.Detalle='COBRO'  AND CONVERT(DATE,Fecha_que_pago)  >= @FI and CONVERT(DATE,Fecha_que_pago)  <= @FF










GO
/****** Object:  StoredProcedure [dbo].[sumar_cobros_POR_TURNO]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sumar_cobros_POR_TURNO]
@fechainicio as datetime,
@fechafin as datetime
as
select sum(dbo.DETALLE_CONTROL_DE_COBROS.Pago_realizado)
from dbo.DETALLE_CONTROL_DE_COBROS  
 where  Fecha_que_pago  >= @fechainicio and Fecha_que_pago  <=@fechafin









GO
/****** Object:  StoredProcedure [dbo].[sumar_compras_POR_TURNO]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sumar_compras_POR_TURNO]
@FI as date,
@FF as date
as
select sum(dbo.ventas  .Monto_total  )
from dbo.ventas 
 where (ventas.ACCION='COMPRA' OR ventas.ACCION='PEDIDO DE COMPRA' ) AND ventas.Tipo_de_pago  ='CONTADO' AND CONVERT(DATE,fecha_venta)  >= @FI and CONVERT(DATE,fecha_venta)  <= @FF










GO
/****** Object:  StoredProcedure [dbo].[sumar_gastos_POR_TURNO]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sumar_gastos_POR_TURNO]
@FI as date,
@FF as date
as
select sum(dbo.GASTOSVARIOS    .Importe    )
from dbo.GASTOSVARIOS   
 where GASTOSVARIOS .TIPO    ='SALIDA'  AND CONVERT(DATE,Fecha_del_Gasto )  >= @FI and CONVERT(DATE,Fecha_del_Gasto)  <= @FF










GO
/****** Object:  StoredProcedure [dbo].[sumar_INGRESOS_VARIOS]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sumar_INGRESOS_VARIOS]
@FI as date,
@FF as date
as
select sum(dbo.GASTOSVARIOS    .Importe    )
from dbo.GASTOSVARIOS   
 where GASTOSVARIOS .TIPO    ='INGRESO'  AND CONVERT(DATE,Fecha_del_Gasto )  >= @FI and CONVERT(DATE,Fecha_del_Gasto)  <= @FF










GO
/****** Object:  StoredProcedure [dbo].[sumar_INGRESOS_VARIOS_POR_TURNO]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sumar_INGRESOS_VARIOS_POR_TURNO]
@fechainicio as datetime,
@fechafin as datetime
as
select sum(dbo.INGRESOSVARIOS .Importe )
from dbo.INGRESOSVARIOS
 where Estado='PAGADO' AND Fecha_del_Gasto >= @fechainicio and Fecha_del_Gasto <=@fechafin 









GO
/****** Object:  StoredProcedure [dbo].[sumar_INGRESOS-VARIOS_POR_TURNO]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sumar_INGRESOS-VARIOS_POR_TURNO]
@fechainicio as datetime,
@fechafin as datetime
as
select sum(dbo.INGRESOSVARIOS .Importe + 0) 
from dbo.INGRESOSVARIOS
 where Estado='PAGADO' AND Fecha_del_Gasto >= @fechainicio and Fecha_del_Gasto <=@fechafin 









GO
/****** Object:  StoredProcedure [dbo].[sumar_KARDEX_RECHASOS]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sumar_KARDEX_RECHASOS]
@FI as date,
@FF as date
as
select sum(dbo.KARDEX   .Total   )
from dbo.KARDEX  
 where KARDEX .Motivo   ='RECHAZO DIARIO' AND CONVERT(DATE,Fecha)  >= @FI and CONVERT(DATE,Fecha)  <= @FF










GO
/****** Object:  StoredProcedure [dbo].[sumar_KARDEX_VENTAS]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sumar_KARDEX_VENTAS]
@FI as date,
@FF as date
as
select sum(dbo.KARDEX   .Total   )
from dbo.KARDEX  
 where (KARDEX .Motivo   ='DESPACHO DIARIO DE VENDEDORES...'  OR   KARDEX .Motivo   ='DESPACHO DE PEDIDOS...' )AND CONVERT(DATE,Fecha)  >= @FI and CONVERT(DATE,Fecha)  <= @FF










GO
/****** Object:  StoredProcedure [dbo].[sumar_pagos_POR_TURNO]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sumar_pagos_POR_TURNO]
@FI as date,
@FF as date
as
select sum(dbo.DETALLE_CONTROL_DE_COBROS  .Pago_realizado   )
from dbo.DETALLE_CONTROL_DE_COBROS 
 where DETALLE_CONTROL_DE_COBROS.Detalle='PAGO'  AND CONVERT(DATE,Fecha_que_pago)  >= @FI and CONVERT(DATE,Fecha_que_pago)  <= @FF










GO
/****** Object:  StoredProcedure [dbo].[SUMAR_POR_COBRAR]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SUMAR_POR_COBRAR]
@FI as date,
@FF as date
as
SELECT    SUM(   clientes.Saldo )

FROM           clientes  
						
 where clientes .Cliente='SI' 








GO
/****** Object:  StoredProcedure [dbo].[SUMAR_POR_COBRAR_OK]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SUMAR_POR_COBRAR_OK]

as
SELECT    SUM(   clientes.Saldo )

FROM           clientes  
						
 where clientes .Cliente='SI' 








GO
/****** Object:  StoredProcedure [dbo].[SUMAR_POR_PAGAR_OK]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SUMAR_POR_PAGAR_OK]

as
SELECT    SUM(   clientes.Saldo )

FROM           clientes  
						
 where clientes .Proveedor ='SI' 








GO
/****** Object:  StoredProcedure [dbo].[sumar_ventas_POR_TURNO]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sumar_ventas_POR_TURNO]
@FI as date,
@FF as date
as
select sum(dbo.ventas  .Monto_total  )
from dbo.ventas 
 where (ventas.ACCION='VENTA' OR ventas.ACCION='PEDIDO DE VENTA' )AND ventas.Tipo_de_pago  ='CONTADO' AND CONVERT(DATE,fecha_venta)  >= @FI and CONVERT(DATE,fecha_venta)  <= @FF










GO
/****** Object:  StoredProcedure [dbo].[Tema]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Tema]
@Id_caja int,
@Tema varchar(50)
as 

update Caja   set  Tema  =@Tema  where Id_Caja=@Id_caja 








GO
/****** Object:  StoredProcedure [dbo].[validar_usuario]    Script Date: 29/08/2020 05:47:22 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[validar_usuario]

@password varchar(max),
@login varchar(50)
as
select idUsuario  from USUARIO2
where  Password   = @password and Login=@Login and Estado ='ACTIVO'




GO
USE [master]
GO
ALTER DATABASE [BASEBRIREST] SET  READ_WRITE 
GO
